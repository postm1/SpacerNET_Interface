# Group selection and transforms

[Polski](GROUP_SELECTION.pl.md) · [Build requirements](../README.md#build-requirements) · [Backend API](https://github.com/Bezimienny111/SpacerNET_Union/blob/feature/group-selection/docs/GROUP_SELECTION_API.md)

## Install and open

Use the matching `SpacerUnionInterface.dll` and `SpacerUnionNet.dll` from this feature.
Replace both files in the existing Spacer.NET installation. The interface targets .NET Framework 4.0;
the backend targets x86 with v140_xp and Union SDK 1.0l. Gothic, Union and the remaining Spacer.NET runtime files are still required.

Load a world, then enable **Multi selection mode** on the main toolbar.
The separate **Group selection and transform** window opens without reducing the viewport.
It follows the editor theme and tool-window visibility. Closing it exits group mode.
Its **Controls** section describes mouse input and the shortcuts for the chosen transform mode.

## Select in the 3D view

| Input | Result |
| --- | --- |
| Drag with LMB | Replace the group with object origins inside the rectangle |
| Shift + drag | Add matching objects |
| Alt + drag | Remove objects from the group |
| Ctrl + drag | Include objects hidden by world geometry |
| Through obstacles | Keep the through-geometry option enabled without holding Ctrl |
| Click without a rectangle | Keep the current group |
| Drag a rectangle containing no matching objects | Clear the group, unless adding/subtracting |

The first LMB gesture after returning from a tool window activates the viewport and preserves the group through mouse-up.
The following drag selects normally. Returning with RMB or another input without holding LMB leaves the next selection gesture available.
DX7 and DX11 use the same candidate-selection algorithm. Occlusion here means static world geometry, not other VOB models.

## Select in Objects list

This is the **Objects list window**, with **Objects** and **Fast access** tabs.
The separate **VOB List** search window keeps its original behavior.

| Input on an object label or icon | Result |
| --- | --- |
| Ctrl + LMB or Shift + LMB | Add that object; repeating the click does not create a duplicate |
| Alt + LMB | Remove only that object |
| LMB without modifiers | Replace the group with that object |
| Double-click without modifiers | Select that object and move the camera to it |
| Click a folder or expand/collapse button | Navigate the tree without changing the group |

Both tabs share the viewport group and show its members. Sorting or rebuilding nodes retains membership by object address.
The current group filter applies to additions and replacements; a rejected object leaves the group intact.
Tree selection does not depend on camera direction, distance or occlusion. Editing is disabled in play mode.

## Group filters

These IDs belong to the group-selection API; they are not indices for the independent legacy VOB List controls.

| ID | Filter | Meaning |
| --- | --- | --- |
| 0 | All objects | All editable objects, including those without visible models |
| 1 | Without movers | Exclude movers and every descendant of a mover |
| 2 | Without WP and freepoints | Exclude waypoints and freepoints |
| 3 | Items only | `oCItem` and derived classes |
| 4 | VOBs (no items or movers) | All editable VOB classes except `oCItem` and `zCMover` |
| 5 | WP + Freepoint | Both waypoint and freepoint objects |
| 6 | WP | `zCVobWaypoint` |
| 7 | Freepoint | `zCVobSpot` |
| 8 | oCMOB | `oCMOB` and derived classes |
| 9 | Dynamic collision enabled | Dynamic collision flag is enabled |
| 10 | oCMobInter | Interactive MOB classes; separate from `zCTrigger` |
| 11 | Lights | `zCVobLight` and derived classes |
| 12 | Sounds | `zCVobSound` and derived classes |
| 13 | Ignore PFX | Exclude particle visuals |
| 14 | Invisible objects | No visual, or `showVisual` disabled |
| 15 | Ignore decals | Exclude decal visuals |
| 16 | Ignore decals and PFX | Exclude both visual types |
| 17 | Decals only | Visual derives from `zCDecal` |
| 18 | PFX only | Visual derives from `zCParticleFX` |
| 19 | zCTrigger | `zCTrigger` and derived classes |
| 20 | zCZone | `zCZone` and derived classes |
| 21 | oCZoneMusic | Music zones |

All filters exclude the active viewport camera, editor helpers, objects marked not to be archived, level-composition geometry and objects outside the current world.
Changing the filter immediately removes nonmatching members from the current group.

## Move and rotate

Choose **Translation** or **Rotation** in the group window.
For numeric input, enter X/Y/Z and use **Move selection** or **Rotate selection**.
Translation uses world-space deltas in engine units. Rotation uses degrees about world axes, applied X, then Y, then Z.
The pivot is the arithmetic mean of the selected object origins, not a bounding-box center.

Default viewport shortcuts are shown below. Existing key settings can override them.

| Input | Translation mode | Rotation mode |
| --- | --- | --- |
| 1 / 2 | Switch to translation / rotation | Switch to translation / rotation |
| W / S | Move forward/backward relative to the horizontal camera direction | Rotate about world X |
| A / D | Move left/right relative to the horizontal camera direction | Rotate about world Z |
| Space / X | Move up/down | — |
| Q / E | — | Rotate about world Y |
| Shift | 10 times faster | 3 times faster |
| Ctrl | 10 times slower | 10 times slower |
| Hold RMB | Control the camera instead of transforming the group | Control the camera instead of transforming the group |
| Ctrl+Z | Undo the last group transform | Undo the last group transform |

Offsets must be finite and within ±1,000,000 per axis. Angles must be finite and within ±3,600 degrees per axis per request.
Numeric input is reset when switching transform modes; changing language preserves the current mode and values.

## Hierarchies, movers and undo

Every selected object receives the group transform once, even when its parent is also selected.
Unselected descendants retain their original world-space transforms.
Selected mover keyframe positions and orientations follow the group; unselected movers and their saved routes stay fixed.
Waypoint network positions, camera splines and PFX bounds are refreshed.
The existing setting that blocks movement of objects with children is respected for the entire operation.

**Undo operation** or Ctrl+Z restores positions, orientations and mover keyframes.
One continuous keyboard gesture is one history entry; one numeric action is another. At most 32 group operations are stored.
Clearing membership with **Clear selection** retains valid transform history. Leaving group mode, deleting an object or resetting the world invalidates it.
Undo rejects a different world, changed parent/child relationships or a changed mover-keyframe count.
This history covers group translation/rotation; it is not a general editor undo for deletion or reparenting.

The existing parent-change workflow remains available: Ctrl+X arms the chosen global parent, then Ctrl+V applies it to the group.

## Limits and troubleshooting

| Symptom | Check |
| --- | --- |
| An object does not join the group | Enable group mode, leave play mode and check the group filter |
| Movement is rejected for a hierarchy | Check the existing block-movement-of-objects-with-children setting |
| Undo is rejected | Reselect after a world/hierarchy/keyframe change; stale snapshots are discarded |
| A new export is missing | Install the matching interface/backend pair from this feature |

Both controller settings use this group-transform implementation. Dragging an external-controller gizmo is not implemented for groups.
Automated renderer tests use an engine double; actual DX7/DX11 and Windows XP runtime validation require separate checks.

See [validation and manual checks](https://github.com/Bezimienny111/SpacerNET_Union/blob/feature/group-selection/docs/VALIDATION.md).
