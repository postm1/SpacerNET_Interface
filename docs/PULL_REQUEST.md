# Add a group-selection window, transforms and Objects tree selection

Group editing now has a separate tool window with numeric translation/rotation, 22 filters,
live selection count, undo availability and localized control instructions.
Objects and Fast access can build the same group with Ctrl/Shift-click additions and Alt-click removal.
Returning to the viewport with LMB preserves the group instead of clearing it as an empty rectangle.

The viewport keeps its size. Group highlighting follows theme changes and backend membership;
folders/expanders retain normal navigation and the separate VOB List window keeps its original behavior.
Closing the group window exits multi-selection mode. Transform controls are disabled in play mode.

This change requires the corresponding native implementation in
[Bezimienny111/SpacerNET_Union](https://github.com/Bezimienny111/SpacerNET_Union).
Both DLLs must be built and distributed together. The native feature adds group selection/transform exports;
this interface also provides the input-blocking callback used by the backend.

The .NET Framework target remains **4.0**. DllExport's restore condition also handles a missing generated metadata cache.
New code does not require a .NET 4.8 migration. User documentation is provided in English and Polish.

## Validation

- Release x86 build against .NET Framework 4.0 reference assemblies passed.
- 70 interface/interop checks passed, using real forms, queued Windows mouse messages and a v140-built native stub.
- Checks cover localization, input limits, undo state, viewport size, instructions layout, Objects/Fast access selection, navigation, themes, rebuilding and ordinary selection outside group mode.
- Companion backend: 119 regression scenarios and a v140_xp/SDK 1.0l G2A release build passed.
- These rebuilt legacy-target DLLs still need actual-engine/DX7/DX11, save/reload and Windows XP runtime release checks.

See [user guide](GROUP_SELECTION.md), [Polish guide](GROUP_SELECTION.pl.md) and
[validation details](https://github.com/Bezimienny111/SpacerNET_Union/blob/feature/group-selection/docs/VALIDATION.md).
