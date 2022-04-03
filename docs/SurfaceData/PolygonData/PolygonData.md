## PolygonData
`SFS.Parts.Modules.PolygonData` inherits from `SFS.Parts.Modules.SurfaceData` and defines a polygonal shape.

`PolygonData` is an abstract class so it can't be used directly. Implementations are detailed here:
- [PipeData](./PipeData/PipeData.md)
- [BoxPolygon](./BoxPolygon.md)
- [CustomPolygon](./CustomPolygon.md)

`colliderArea` defined as a `bool` is used to generate the collider area in build mode when set to `true`.

`clickArea` defined as a `bool` is used to generate clickable areas when set to `true`.

> Both of those are currently defined as private fields but extension methods have been added to set those without having to manually use reflection in `SFSEX.PartsInjector.Utils`.

`baseDepth` defined as a `float` is used to defined the depth of the mesh. This is used when a raycast is performed and when multiple meshes overlap.

## Fields Summary
### SFS.Parts.Modules.PolygonData
Inherits from [`SFS.Parts.Modules.SurfaceData`](../SurfaceData.md#sfspartsmodulessurfacedata)
| Name | Type | Description |
|-|-|-|
| `colliderArea` (private) | `bool` | Generate collider area in build mode |
| `clickArea` (private) | `bool` | Generate clickable area |