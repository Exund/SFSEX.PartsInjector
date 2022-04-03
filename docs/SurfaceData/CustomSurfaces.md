# CustomSurfaces
`SFS.Parts.Modules.CustomSurfaces` inherits from `SFS.Parts.Modules.SurfaceData` and defines arbitrary surfaces.

## Fields
`pointsArray` defined as a `List<SFS.Parts.Modules.ComposedSurfaces>` holds a list of surfaces.

## ComposedSurfaces
`SFS.Parts.Modules.ComposedSurfaces` defines a surface composed of multiple points.

`points` defined as a `SFS.Variables.Composed_Vector2[]` holds a list of points determining the shape of the surface.

`loop` defined as a `bool` defines if the surface is a loop.

## Fields summary
### SFS.Parts.Modules.CustomSurfaces
Inherits from [`SFS.Parts.Modules.SurfaceData`](./SurfaceData.md#sfspartsmodulessurfacedata)
| Name | Type | Description |
|-|-|-|
| `pointsArray` | `List<SFS.Parts.Modules.ComposedSurfaces>` | List of surfaces |

### SFS.Parts.Modules.ComposedSurfaces
| Name | Type | Description |
|-|-|-|
| `points` | `SFS.Variables.Composed_Vector2[]` | List of points |
| `loop` | `bool` | Is the surface a loop |