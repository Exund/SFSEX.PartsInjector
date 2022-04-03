# ColliderModule
`SFS.Parts.Modules.ColliderModule` is used to handle collision for parts.

It itself doesn't define the collider so a separate `Collider2D` needs to be defined on the part at some point (may be handled by other modules).

## Fields
`impactTolerance` defined as a `ColliderModule.ImpactTolerance` defines the impact tolerance of a part.

The actual values for impact tolerance are defined as the max relative velocity in Unity units of the impacted object supported.
| Value of `impactTolerance` | Actual value |
|-|-|
| `ImpactTolerance.Low` | 2.5 |
| `ImpactTolerance.Medium` | 5.5 |
| `ImpactTolerance.High` | 12.5 |
| `ImpactTolerance.Wheel` | 50.5 |

## Fields summary
### SFS.Parts.Modules.ColliderModule
| Name | Type | Description |
|-|-|-|
| `impactTolerance` | `SFS.Parts.Modules.ColliderModule.ImpactTolerance` | Impact tolerance |

### SFS.Parts.Modules.ColliderModule.ImpactTolerance
| Name | Value |
|-|-|
| `Low` | 0 |
| `Medium` | 1 |
| `High` | 2 |
| `Wheel` | 3 |