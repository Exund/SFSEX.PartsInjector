# PipeData
`SFS.Parts.Modules.PipeData` is used to defined a pipe-like mesh for parts (closer to the camera in the center and further away on the sides).

`PipeData` inherits from `SFS.Parts.Modules.PolygonData` which itself inherits from `SFS.Parts.Modules.SurfaceData`.

> Note: `SurfaceData` and `PolygonData` have not been fully figured out yet but some of their fields are used in `PipeData` and will be explained here.

`PipeData` is an abstract class so it can't be used directly. Implementations are detailed here:
- [SimplePipe](./SimplePipe.md)
- [CustomPipe](./CustomPipe.md)

## SurfaceData
`SFS.Parts.Modules.SurfaceData` defines 2 important fields for parts.

`attachmentSurfaces` defined as a `bool` is used to generate attachment surfaces (parts that stick to other parts) when set to `true`.

`dragSurfaces` defined as a `bool` is used to generate drag surfaces when set to `true`.

> Both of those are currently defined as private fields but extension methods have been added to set those without having to manually use reflection in `SFSEX.PartsInjector.Utils`.

## PolygonData
`SFS.Parts.Modules.PolygonData` defines 3 important fields for parts.

`colliderArea` defined as a `bool` is used to generate the collider area in build mode when set to `true`.

`clickArea` defined as a `bool` is used to generate clickable areas when set to `true`.

> Both of those are currently defined as private fields but extension methods have been added to set those without having to manually use reflection in `SFSEX.PartsInjector.Utils`.

`baseDepth` defined as a `float` is used to defined the depth of the part This is used when a raycast is performed and when multiple meshes overlap.

## Fields
`depthMultiplier` defined as a `float` is used to multiply the depths of the pipe points.

`cut` defined as a `float` between `-1` and `1`.

`reduceResolution` defined as a `bool`. Used to generate a secondary lower poly version of the mesh when set to `true`.

## Fields Summary
### SFS.Parts.Modules.SurfaceData
| Name | Type | Description | 
|-|-|-|
| `attachmentSurfaces` (private) | `bool` | Generate attachement surfaces |
| `dragSurfaces` (private) | `bool` | Generate drag surfaces |

### SFS.Parts.Modules.PolygonData
Inherits from `SFS.Parts.Modules.SurfaceData`
| Name | Type | Description | 
|-|-|-|
| `colliderArea` (private) | `bool` | Generate collider area in build mode |
| `clickArea` (private) | `bool` | Generate clickable area |

### SFS.Parts.Modules.PipeData
Inherits from `SFS.Parts.Modules.PolygonData`
| Name | Type | Description | 
|-|-|-|
| `depthMultiplier` | `float` | Pipe points depth multiplier |
| `cut` | `float` | |
| `reduceResolution` | `bool` | Define secondary low poly mesh |