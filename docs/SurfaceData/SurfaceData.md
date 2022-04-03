## SurfaceData
`SFS.Parts.Modules.SurfaceData` defines 2D surfaces.

`SurfaceData` is an abstract class so it can't be used directly. Implementations are detailed here:
- [PolygonData](./PolygonData/PolygonData.md)
- [CustomSurfaces](./CustomSurfaces.md)
- [PipeSurface](./PipeSurface.md)

## Fields
`attachmentSurfaces` defined as a `bool` is used to generate attachment surfaces (parts that stick to other parts) when set to `true`.

`dragSurfaces` defined as a `bool` is used to generate drag surfaces when set to `true`.

> Both of those are currently defined as private fields but extension methods have been added to set those without having to manually use reflection in `SFSEX.PartsInjector.Utils`.

## Fields Summary
### SFS.Parts.Modules.SurfaceData
| Name | Type | Description |
|-|-|-|
| `attachmentSurfaces` (private) | `bool` | Generate attachement surfaces |
| `dragSurfaces` (private) | `bool` | Generate drag surfaces |