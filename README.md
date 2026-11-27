# SpacerNET_Interface

## Table of contents

- [About](#about)
- [Download](#download)
- [Usage requirements](#usage-requirements)
- [Build requirements](#build-requirements)
- [Group-selection documentation](#group-selection-documentation)
- [Group selection and movement](#group-selection-and-movement)
- [Interface smoke test](#group-selection-interface-smoke-test)
- [Contributing](#contributing)

## About

### Spacer.NET

**Spacer.NET** is a world editor for **Gothic II: Night of the Raven** that allows you to edit .ZEN world files.  
It's mainly inspired by the original **Spacer** editor, it offers almost the same functionallity from the original editor and some additional features. The main purpose of it is to give a better vobbing experience without many inconveniences of original editor.

### SpacerNET_Interface

This project is a front-end plugin written in **C#** for **Spacer.NET** editor.  
It's responsibility is to display the UI and interact with the game via **SpacerUnionNet** back-end plugin.

## Download

You can download the latest release of Spacer.NET from [worldofplayers.de](https://forum.worldofplayers.de/forum/threads/1557793-WORLD-EDITOR-Spacer-NET) forum.  
Or you can use Google drive: [Link](https://drive.google.com/drive/folders/1shwV7oFBP2vQfxZkBCw9KjScDlx-Wueq)

## Usage requirements

In order to use this project you need'll to install:
- **.NET Framework 4.0**
    The project keeps the original framework target; group selection and transforms do not require .NET 4.8.

- **Union 1.0l or newer**  
    Install it via [Union Resource Manager](https://worldofplayers.ru/threads/41415/).

## Build requirements

- **Visual Studio 2017-2019**, with **.NET desktop development** and the **.NET Framework 4.0 targeting pack**.
  The existing upstream sources use C# 7 syntax, so the stock Visual Studio 2015 C# compiler is insufficient.
- Access to **NuGet** to restore **DllExport 1.7.4** on the first build.

Build from a Visual Studio Developer Command Prompt in the repository root:

```bat
msbuild SpacerNET_Interface.sln /t:Build /p:Configuration=Release /p:Platform=x86
```

The 32-bit interface is written to `SpacerNET_Interface\bin\x86\Release\SpacerUnionInterface.dll`.
The build restores DllExport's generated metadata cache automatically when it is missing.
To prepare it manually, run `DllExport.bat -action Restore` from the repository root.
Keep native DllExport processing enabled: the C++ plugin calls the exported functions in this DLL.
If DllExport is not installed yet, restore packages with NuGet before building.
For a targeting pack outside the standard installation location, pass `TargetFrameworkRootPath` to MSBuild.
Microsoft's [Microsoft.NETFramework.ReferenceAssemblies.net40](https://www.nuget.org/packages/Microsoft.NETFramework.ReferenceAssemblies.net40/1.0.3) NuGet package provides a compatible `build` directory.
This changes the reference-assembly location, not the .NET 4.0 target.

The C++ backend is maintained separately in [SpacerNET_Union](https://github.com/postm1/SpacerNET_Union).
Running the editor also needs Gothic, Union, and the remaining Spacer.NET runtime files.

## Group-selection documentation

The paired development forks are [Bezimienny111/SpacerNET_Interface](https://github.com/Bezimienny111/SpacerNET_Interface)
and [Bezimienny111/SpacerNET_Union](https://github.com/Bezimienny111/SpacerNET_Union).
Build and distribute both feature DLLs together.

- [Complete user guide](docs/GROUP_SELECTION.md)
- [Instrukcja po polsku](docs/GROUP_SELECTION.pl.md)
- [Native API contracts](https://github.com/Bezimienny111/SpacerNET_Union/blob/feature/group-selection/docs/GROUP_SELECTION_API.md)
- [Validation results and manual checks](https://github.com/Bezimienny111/SpacerNET_Union/blob/feature/group-selection/docs/VALIDATION.md)
- [Prepared pull-request description](docs/PULL_REQUEST.md)
- [Publikacja dwóch PR-ów krok po kroku](https://github.com/Bezimienny111/SpacerNET_Union/blob/feature/group-selection/docs/PUBLISHING.pl.md)

## Group selection and movement

Enable **Multi selection mode** on the main toolbar. A separate modeless **Group selection and transform** window opens after a world is loaded.
The render viewport keeps its full size. Closing the tool window exits group-selection mode.
The window follows the editor's theme and participates in hiding/showing tool windows.

The initial five group filters are:

- **All objects**: editable scene objects, including objects without visible models.
- **Without movers**: exclude movers and their entire descendant hierarchies.
- **Without WP and freepoints**: exclude waypoints and freepoints.
- **Items only**: oCItem objects and derived classes.
- **VOBs (no items or movers)**: any editable VOB except oCItem and zCMover, including other specialized VOB classes.

The list now has **22 filters**, covering both lists in **VOB List** and the selection filter in the object tree:
WP + freepoints, WP only, freepoints only, oCMOB, dynamic collision enabled, oCMobInter, lights, sounds,
ignore PFX, invisible objects, ignore decals, ignore decals and PFX, decals only, PFX only, zCTrigger, zCZone, and oCZoneMusic.
The old selection list labels its oCMobInter test as "Trigger"; the group window explicitly offers oCMobInter and zCTrigger separately.
"Invisible" includes objects with no visual or with showVisual disabled.

The active viewport camera, editor helpers, temporary objects marked not to be archived, and level-composition geometry are excluded from every filter.
Changing the filter immediately removes nonmatching objects from the existing selection.

Drag a rectangle to replace the selection. Hold **Shift** to add or **Alt** to subtract.
The rectangle tests object origins, rather than requiring the whole model to fit.
Enable **Through obstacles**, or hold **Ctrl** during selection, to include objects hidden by world geometry.
The same selection algorithm is used with DX7 and DX11.

The **Objects list window** can also build the same group selection, from either
the **Objects** tree or its **Fast access** tab:
**Ctrl+left click** or **Shift+left click** adds an object, **Alt+left click** removes it,
and an unmodified left click replaces the group with that object.
Adding an already selected object keeps it selected. Group filters still apply;
objects rejected by the filter leave the group unchanged. Tree selection ignores camera visibility and obstacles.
Selected nodes follow selection changes in the viewport, including clearing and filter changes.
Folders and expand/collapse buttons navigate the tree without changing the group.
Sorting or rebuilding tree nodes preserves selection by object address.
These controls require Multi selection mode and are disabled in play mode.
Outside group mode, the tree retains its usual single-object selection behavior.
The separate **VOB List** search window retains its original behavior.

Returning from a tool window with a left click activates the viewport without changing the group.
That activating gesture is ignored until the button is released; the next drag selects normally.
A click without a rectangle also keeps the selection. A deliberate empty rectangle still clears it.
The group tool window includes a visible **Controls** section for mouse selection, the object tree,
camera movement, mode-specific keyboard transforms and undo. The descriptions follow the interface language.

Move the group with **WASD**, **Space/X**, **Shift** (faster), and **Ctrl** (slower), using the configured movement bindings.
Hold the right mouse button to move the camera instead.
Choose **Translation** or **Rotation** in the tool window, or use the configured tool shortcuts (default **1** / **2**) in the viewport.
In translation mode, enter **delta X/Y/Z** and click **Move selection**.
In rotation mode, enter world-axis angles in degrees and click **Rotate selection**.
The numeric rotation order is X, then Y, then Z.
Rotation uses the shared arithmetic center of all selected object origins; W/S rotate about X, A/D about Z, Q/E about Y.
The configured rotation speed, faster/slower modifiers, hierarchy protection and undo also apply.
Every selected object receives the same world-space offset, preserving relative positions.
A selected child is moved once even if its parent is selected. Unselected descendants retain their original world-space transforms.

Waypoint network positions, camera splines, and PFX bounds are refreshed.
Moving a selected mover also offsets all its saved keyframe positions. Rotating it rotates its keyframe positions about the group pivot and composes its keyframe orientations.
The existing option that blocks movement of objects with children is respected.

**Undo operation** or **Ctrl+Z** restores the complete translation or rotation, including object orientations and mover keyframes.
One uninterrupted keyboard movement is one operation; one numeric move is another.
History stores up to 32 group operations, and is cleared when leaving group mode or deleting objects.
Undo refuses changed worlds, changed hierarchies, or changed mover keyframe counts.
Parent-cut in group mode uses **Ctrl+X**; **Ctrl+V** applies the chosen parent.

The group window uses its own transformation implementation with either controller setting.
Group movement by dragging an external-controller gizmo is not part of this implementation.

## Group-selection interface smoke test

Build **Release x86**, then run from an **x86 Visual Studio Developer Command Prompt**:

    tests\run-interface-selection-tests.cmd

The smoke-test executable also compiles against .NET Framework 4.0 references.
If the targeting pack is outside its standard location, set `NET40_REFERENCE_PATH` to its `v4.0` directory.

This instantiates the real main form without showing a window, using a native test stub in SpacerNET_Interface\bin\tests.
It checks all 22 filter indices, the separate owned window, unchanged viewport size, Polish labels/locale,
translation and rotation API calls, live count, angle limits, undo, localization without data loss, closing the window, and disabled editing in play mode.
It also sends real Windows mouse messages to Objects list to verify additive selection,
duplicate clicks, node synchronization, folders, expanders, rebuilding, Fast access, theme changes,
and preservation of ordinary selection. A preview is saved as objects-list-group-selection.png.
The group-window checks also verify the translated controls and that they fit without clipping.
A layout preview is saved as group-selection-window.png in the test output.
For the preview, the tool window is created off-screen with zero opacity.
The normal release output remains in SpacerNET_Interface\bin\x86\Release.

## Contributing

Any contribution to this repository is welcome.  
In order to add your own changes to the project, just open a pull request.
