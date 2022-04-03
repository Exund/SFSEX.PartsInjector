# PipeData
`SFS.Parts.Modules.PipeData` inherits from `SFS.Parts.Modules.PolygonData` and defines a pipe-like mesh for parts (closer to the camera in the center and further away on the sides).

`PipeData` is an abstract class so it can't be used directly. Implementations are detailed here:
- [SimplePipe](./SimplePipe.md)
- [CustomPipe](./CustomPipe.md)

## Fields
`depthMultiplier` defined as a `float` is used to multiply the depths of the pipe points.

`cut` defined as a `float` between `-1` and `1`.

`reduceResolution` defined as a `bool` is used to generate a secondary lower poly version of the mesh when set to `true`.

## Fields Summary
### SFS.Parts.Modules.PipeData
Inherits from [`SFS.Parts.Modules.PolygonData`](../PolygonData.md#sfspartsmodulespolygondata)
| Name | Type | Description |
|-|-|-|
| `depthMultiplier` | `float` | Pipe points depth multiplier |
| `cut` | `float` | |
| `reduceResolution` | `bool` | Define secondary low poly mesh |