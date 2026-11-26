# SpacerNET_Interface — Agent Guide

A short overview of the project, its main files, and its windows. Read together with `README.md`.

## What this is

This is the **UI frontend of the Spacer.NET world editor for Gothic II: Night of the Raven**. It owns the
interface, user interaction, and forwards commands to the game core.

The editor itself (engine, `.ZEN` handling, rendering) lives in the native C++ backend plugin
**`SpacerUnionNet.dll`** (bridged through Union 1.0l+). This project is only a UI shell around it.

- Builds as a **library** (`OutputType=Library`), not an `.exe`. There is no `Main()` entry point.
- **.NET Framework 4.0**, platform **`x86` only** (AnyCPU in the csproj is dead; the real configs are `Debug|x86`, `Release|x86`).
- Targeted at Windows XP support: that's why .NET 4.0 is pinned (VS 2015–2019).
- Exported functions are exposed via the NuGet **DllExport 1.7.4** package (`3F/DllExport`, requires `DllExport.bat` at repo root, attribute `[DllExport]`).
- `AssemblyName = SpacerUnionInterface`, `RootNamespace = SpacerUnion`.
- App version: `Constants.SPACER_VERSION = "1.58"` (`Common/Utils.cs`).

## Namespaces (important — they are mixed)

Windows are spread across several namespaces; there is no single convention in the `.cs` files:
- `SpacerUnion` — legacy windows: `MainForm`, `ObjTree`, `PropertiesWin` (class `ObjectsWindow`), `ObjectsWin`, `VobListForm`, `SoundWin`, `InfoWin`, `CompileWorldWin`, `CompileLightWin`, `LoadingForm`, `SpacerNET`, `Utils`, `CProperty`, `TreeEntry`, `TriggerEntry`, `ConsoleEx`.
- `SpacerUnion.Windows` — newer windows: `MaterialFilterForm`, `UVReporterForm`, `PFXEditorWin`, `VobCatalog*`, `GrassWin`, `CameraCoords`, `KeysForm`, `MacrosForm`, `SettingsMain`, `SearchErrorsForm`, `ConfirmForm`, `RenameForm`.
- `SpacerUnion.Common` — `Imports`, `Exports`, `Localizator`, `Theme`, `ThemeApplier`, `DarkToolStripRenderer`, `Macros`, `ErrorReport`, `ScreenUtils`, `CameraKeyEntry`, `VobCatalogEntry`, `QuickVobsManager`, `VobCatalogManager`.
- The namespace of a file does not follow its folder: `Common/KeyFormInit.cs` is `SpacerUnion.Windows`,
  `Common/PFX_Editor/PFXEditorWin_Utils.cs` is `SpacerUnion.Windows`, `Common/Extended/DBufPanel.cs` is
  `SpacerUnion.Common.Extended`.

## Interop architecture (the key concept)

Bidirectional PInvoke with `SpacerUnionNet.dll`. All communication goes through the static classes `Imports`/`Exports`.

### 1. UI → backend: `Common/Imports.cs` + `Imports_Interchange.cs`
- `[DllImport("SpacerUnionNet.dll", CallingConvention=Cdecl)] public static extern void Extern_*(...)`.
- ~175 `Extern_*` functions: load/save/compile world, select/create/reparent vobs,
  triggers and mover keys, camera and camera key-frames, light/presets, PFX, material filter, UV,
  search, spawn, rain, settings (`Extern_GetSetting`/`SetSetting` — they read/write arguments via the stack).
- **Marshalling via a "stack"** (`Imports_Interchange.cs`): before an `Extern_*` call, push data with
  `Imports.Stack_PushString / PushInt / PushUInt / PushFloat / PushBool ...`; afterward read with
  `Stack_PeekString / PeekInt ...` (Peek calls `Stack_Pop()` internally). Wide/Unicode strings — `Stack_PushStringWide`.
  Example: `Imports.Stack_PushString(name); Imports.Extern_CreateItem();`.
- String helpers between managed/native: `PtrWToString`, `PtrAToString`, `StringToPtrA/W` (HGlobal + manual `FreeHGlobal`).

### 2. Backend → UI: `[DllExport]` methods (must be `static`)
The backend calls these by name from native code; arguments are read with the same `Imports.Stack_Peek*` stack.
Lifecycle entry points (`Common/SpacerNET.cs`):
- `UnionInitialize` — main launch: creates ALL windows, applies language/theme, restores positions.
- `UI_Initialize`, `Form_EnableInterface` (called after `Game_Init`, enables the menu and shows windows).
- `GetHandlerFunc` — returns `form.renderTarget.Handle` (see below); also `GetMainWinHandler`, `GetVobsWinHandler`, `IsAppActive`.
- `HideWindows`/`ShowWindows`, `ShowLoadingForm`/`CloseLoadingForm`, `AcceptKey`.

Other callbacks: `Common/Exports.cs` (toggle `BeginUpdate/EndUpdate` on lists via the `UIElementType` enum,
logging into `InfoWin`, `Export_SelectNodeByPtr`, `MatFilter_*`, `Export_GetSha256`),
`Localizator.GetLangString/GetCurrentLangId`, `Utils.GetConfirmWindowYesNo`, `MainForm.GetSpacerVersion/ToggleMainMenuInterface/LoadZenAuto`,
and many `Export_*` inside `ObjTree.cs`, `ObjectsWin.cs`, `PropertiesWin.cs`, `SoundWin.cs`, `VobListForm.cs`.

### 3. Render host
`MainForm.renderTarget` is a **borderless child `Form`** (`TopLevel=false`, `Dock=Fill`)
added into `panelMain` in `MainForm_Load`. The backend, through `GetHandlerFunc()`, receives its `Handle`
and embeds its own 3D-view render window there. The whole "view area" is that `renderTarget`.

## Window lifecycle
- All windows are created **once** in `UnionInitialize` and stored as `public static` fields:
  `SpacerNET.form / objTreeWin / propWin / objectsWin / vobList / infoWin / settingsMain / ...`. Access them as `SpacerNET.<window>.<control>`.
- Each window's `Owner = form`. All (except modal dialogs) are in `windowsList` → theme toggling and `HideWindows/ShowWindows`.
- Closing is **`Hide()`, not `Close()`**: `FormClosing` sets `e.Cancel = true`. Actual shutdown — `SpacerNET.CloseApplication()` → saves settings then `Imports.Extern_Exit()`.
- On close, window visibility/positions/sizes are saved into `Properties.Settings.Default`
  (user-scoped settings, `app.config`; the `...ShowNext` flags = windows that were hidden and should re-open next run).

## Localization
- `Localizator` (`Common/Localizator.cs`) + data in `Common/LocalizedStrings.cs` (`Localizator.Init()`).
- 5 languages: `LangEnum { RU, EN, DE, PL, CZ }` (codepage 1251 / 1250). Default is EN (`Settings.Language=1`).
- Every window has an `UpdateLang()` method that fills captions via `Localizator.Get("KEY")`.
  `Localizator.UpdateInterface()` calls all of them at once.
- To add text: `AddNewWord("KEY", new List<string>{ RU, EN, DE, PL, CZ })` in `LocalizedStrings.cs`,
  then `Localizator.Get("KEY")` in the window's `UpdateLang()`.

## Dark theme
- `Theme` (color flags, `Theme.IsDark`, `ThemeChanged` event), `ThemeApplier` (applies to all controls),
  `DarkToolStripRenderer`. Toggled by the `DarkMode` setting; re-tints via `ThemeApplier.ApplyAll(windowsList)`.
- **Important:** modal dialogs (not in `windowsList`) must be registered —
  `ThemeApplier.RegisterDialog(form)` (see `VobCatalog`, `Macros`, `MaterialFilterForm`, `PFXEditorWin`).

## Main files

### Root
- `SpacerNET_Interface.sln`, `SpacerNET_Interface/SpacerNET_Interface.csproj` — the project (x86, .NET 4.0, DllExport).
- `DllExport.bat` — restores DllExport during build.
- `README.md`, `LICENSE.md`.

### `Common/` — core and helpers
- `SpacerNET.cs` — **coordinator**: registry of all windows, lifecycle (`UnionInitialize`, `Form_EnableInterface`),
  window position/size persistence, `CloseApplication`.
- `Imports.cs` / `Imports_Interchange.cs` — PInvoke into the backend + "stack" marshalling.
- `Exports.cs` — backend callbacks (incl. material filter) + enums (`UIElementType`, `SpacerNetInterfaceAction`, ...).
- `Localizator.cs` + `LocalizedStrings.cs` — localization (5 languages).
- `Theme.cs`, `ThemeApplier.cs`, `DarkToolStripRenderer.cs` — dark/light theme.
- `Macros.cs` (`Macros`, `MacroEntry`) — macro parser/runner; file `../_work/tools/macros_spacernet.txt`.
- `CProperty.cs` — property model (`TPropEditType`: bool/enum/int/float/string/vec3/color/raw), used by the property editor and PFX.
- `Utils.cs` — `Constants` (version, file filters, path `/_WORK/DATA`), `Utils` (hashes, sorting, `PrintTimeInfo`, `[DllExport] GetConfirmWindowYesNo`), `ExtMap`.
- `TreeEntry.cs` — vob tree entry (`zCVob` uint address, parent, name, className, `TreeNode node`, children).
- `TriggerEntry.cs`, `CameraKeyEntry.cs` — trigger / camera-key models (with `[DllExport]` callbacks).
- `VobCatalogEntry.cs` (`VobCatalogEntry`, `VobCatalogManager`) — model for the user vob catalog.
- `QuickVobsManager.cs` — "quick" vobs (parent container) in the tree.
- `ErrorReport.cs` — world error-report model (`ErrorReportEntry` + problem/level enums).
- `KeyFormInit.cs` — hotkey binding (`KeysForm` partial): map of virtual VK codes → Gothic key codes.
- `ScreenUtils.cs` (clamp window into visible screen), `ConsoleEx.cs` (colored log), `Extended/DBufPanel.cs` (double buffering), `PFX_Editor/PFXEditorWin_Utils.cs`.

## Windows (`Windows/`)

### Framework
| File | Class | Purpose |
|---|---|---|
| `MainForm.cs` | `MainForm` | Main window: menu (`menuStripTopMain`), toolbar (`toolStripTop`), status bar (world/polys/RAM). Hosts `renderTarget` (3D view). Many `[DllExport]` callbacks, console log `AddText`. |
| `InfoWin.cs` | `InfoWin` | Log/messages window + zSpy message stream (`AddText_External`, `AddText_ExternalSpy`, timer). |
| `LoadingForm.cs` | `LoadingForm` | Modal loading/progress (`ShowLoadingForm`/`CloseLoadingForm`). |
| `ConfirmForm.cs` | `ConfirmForm` | Custom Yes/No dialog (macros, filter, catalog). |

### World object handling
| File | Class | Purpose |
|---|---|---|
| `ObjTree.cs` | `ObjTree` | Vob hierarchy tree (`globalTree`, static dictionary `globalEntries: uint→TreeEntry`), drag&drop reparenting, context menu, quick vobs. Many export callbacks. |
| `PropertiesWin.cs` | `ObjectsWindow` | Editor for the selected object's properties (`CProperty` in a TreeView), "Apply properties" (`Extern_ApplyProps`). |
| `ObjectsWin.cs` | `ObjectsWin` | "Parts/objects" palette (the largest file, ~4250 lines): class tree, lists of items/PFX/camera presets/search results, spawn, trigger editing (`triggerEntry`), camera key-frames (`camEntry`), light presets, vob search/compare/convert. |
| `VobListForm.cs` | `VobListForm` | List of vobs near the camera (radius `trackBarRadius`), pick/type filters. |

### Sub-editors and reports
| File | Class | Purpose |
|---|---|---|
| `PFXEditorWin.cs` (+`Common/PFX_Editor/PFXEditorWin_Utils.cs`) | `PFXEditorWin` | PFX (particle effects) editor, `CProperty` fields, preview. |
| `MaterialFilterForm.cs` | `MaterialFilterForm` | Material filter (.PML) editor + texture preview and texture display settings. |
| `UVReporterForm.cs` | `UVReporterForm` | UV/lightmap error report. |
| `SearchErrorsForm.cs` | `SearchErrorsForm` | World error report (`ErrorReportEntry` + filter), jump-to-object. |
| `VobCatalog.cs` (+`VobCatalogPropsForm.cs`, `VobCatalogMoveForm.cs`) | `VobCatalogForm` etc. | User-defined quick-vob catalog; file `../_work/tools/vobcatalog_spacernet.txt`. |
| `SoundWin.cs` | `SoundWin` | Sound & music lists, playback. |
| `GrassWin.cs` | `GrassWin` | Grass/visual settings. |

### Camera, compilation, input, settings
| File | Class | Purpose |
|---|---|---|
| `CameraCoords.cs` | `CameraCoords` | Set camera position/orientation (X/Y/Z + yaw/pitch). |
| `SettingsMain.cs` (+`SettingsMain.Catalog.cs`) | `SettingsMain` | One settings window for camera, vobs and misc (see "Settings window" below). |
| `CompileWorldWin.cs` / `CompileLightWin.cs` | `CompileWorldWin`/`CompileLightWin` | Dialogs for compiling the world (indoor/outdoor) and lighting (quality/radius). |
| `KeysForm.cs` (+`Common/KeyFormInit.cs`) | `KeysForm` | Hotkey configuration (VK → Gothic code mapping). |
| `MacrosForm.cs` (+`Common/Macros.cs`) | `MacrosForm` | Macro-script runner window. |
| `RenameForm.cs` | `RenameForm` | Batch rename dialog (`ObjectsWin.renameWin`). |

## Settings window (`Windows/SettingsMain.cs`)

- One window for camera, vobs and misc — the old `SettingsCamera`, `SettingsVobs` and `MiscSettingsWin` are gone.
  Open it through `SpacerNET.settingsMain.ShowSettings(category)`: `Settings → Main` shows the whole page,
  `Camera` / `Vobs` / `Misc` open the same window and scroll to their category.
- `SettingsMain.Catalog.cs` describes every option once (`BuildCatalog()`): key in the C++ settings stack,
  localization key, category, group, kind, ranges. The page, the search and the counts of the left list are
  built from that catalog — add new options there, not in the designer.
- Values are read in `LoadSettings()` and written back only if the user really changed them
  (`Setting.Dirty`, `ApplyAll()`). Other classes keep reading flags as before:
  `SpacerNET.settingsMain.GetFlag(key)` / `GetValue(key)`.
- `Setting.Hidden` keeps an option in the catalog but hides it (no row, no place, no count, no search);
  `Separator(...)` is a blank line inside a section that keeps unrelated options apart.
- Scrolling is ours, not `AutoScroll`: `pageScrollBar` (a `VScrollBar` docked to the right) plus `scrollOffset`,
  `SetScroll`, `PlacePage`, `UpdateScrollSize`. Heights are measured by hand (`UpdateSectionHeight`), so
  `RelayoutPage()` must run after a font, width or language change.
- The wheel of the mouse is taken by a thread hook (`WheelHook` class, a Win32 `WH_GETMESSAGE` hook — the
  const is `WhGetMessage`): this window lives inside the
  native editor, which pumps its messages itself, so `Application.AddMessageFilter` is never called at all.
  The hook scrolls the page from over any of its controls and empties the message, so a slider under the cursor
  never changes its value (`PageTrackBar` also ignores the wheel). The wheel over the bar itself is left to the bar.
- The search marks the options it finds (green stripe at the left edge of the section, "Found: 1 / 20") and
  never hides or reorders anything; the left list is rebuilt only on a language change.
- Language is applied on start-up and on a manual language change only (`UpdateLang`), and then the whole window
  is re-laid out and repainted (`RefreshWholeWindow`). Heavy repaints are batched with
  `BeginPaintBatch` / `EndPaintBatch` (`WM_SETREDRAW` + `RedrawWindow` with `RDW_UPDATENOW`).

## Conventions: how to add a feature

- **Comments and commit messages are English only.** Never write them in Russian: the user-visible text lives
  in `LocalizedStrings.cs` (5 languages), everything else in the sources is English. Do not translate the
  Russian text that is part of the data (a value in `Settings.settings`, a string inside commented-out code).
- **New backend call:** add a `[DllImport] Extern_*` to `Imports.cs`, call it from a handler; push strings via `Imports.Stack_PushString` before the call.
- **New backend callback:** add a `public static void` with `[DllExport]` (in the relevant window or `Exports.cs`), read args via `Imports.Stack_Peek*`, update a control through `SpacerNET.<window>.<control>`. The method must be `static`.
- **New button/menu item:** control in `*MainForm.Designer.cs` → handler in `*MainForm.cs` → `Imports.Extern_*`. Toolbar toggles are synced in `SpacerNET.LoadSettingsToInterface()` (indices `toolStripTop.Items[i]`).
- **New text:** key in `LocalizedStrings.cs` (5 columns) + `Localizator.Get(key)` in the window's `UpdateLang()`; if the window is new, add its `UpdateLang()` call to `Localizator.UpdateInterface()`.
- **New window:** create it in `UnionInitialize`, add it to `windowsList`, wire positions/sizes in `SpacerNET.LoadSettingsToInterface()`/`CloseApplication()` (setting fields in `Properties/Settings.settings` + `app.config`). Don't forget `ThemeApplier.RegisterDialog` if it's a modal.

## Gotchas
- `[DllExport]` methods and backend fields use **uint vob addresses** as identifiers (see `TreeEntry.zCVob`, `Extern_SelectVob(uint)`).
- Strings over PInvoke are ANSI/UTF; wide (`Wide`) are used for localization; don't forget to free `HGlobal` (already handled in the wrappers).
- `Settings.Default` has many `...ShowNext` fields — windows "closed but to restore next run".
- Config files live **outside the build output**: `../_work/tools/*.txt` (macros, vob catalog), data in `/_WORK/DATA`.
- Some code is commented out and disabled (e.g. `AddGlobalEntryMat`, parts of `UVWinSize`, `GrassWin.Show`) — historically disabled features; don't accidentally restore them.
- `packages/`, `bin/`, `obj/` and `*.Designer.cs`/`*.resx` are generated/auto-code; no need to read them (except `Settings.settings`, `app.config`).
