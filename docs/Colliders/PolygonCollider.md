# PolygonCollider
`SFS.Parts.Modules.PolygonCollider` inherits from `SFS.Parts.Modules.ColliderModule` and is used to give polygonal collision to parts.

It adds a `UnityEngine.BoxCollider2D` to the part if there are only 4 vertices in the polygon data in the shape of a rectangle.
Else it adds a `UnityEngine.PolygonCollider2D`.

## Fields
`polygon` defined as a `SFS.Parts.Modules.PolygonData` holds the collider data.

## Fields summary
### SFS.Parts.Modules.PolygonCollider
Inherits from `SFS.Parts.Modules.ColliderModule`
| Name | Type | Description |
|-|-|-|
| `polygon` | `SFS.Parts.Modules.PolygonData` | Collider polygon data |