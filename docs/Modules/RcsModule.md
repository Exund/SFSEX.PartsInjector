# RcsModule
`SFS.Parts.Modules.RcsModule` adds RCS functionalities to parts.

## Fields
`directionAngleThreshold` defined as a `float` defines the angle threshold for the RCS direction.

`torqueAngleThreshold` defined as a `float` defines the angle threshold for the RCS torque.

> The thresholds are compared to the thrust normals of the RCS thrusters to determine their state.

`thrust` defined as a `float` defines the thrust of the RCS.

`ISP` defined as a `float` defines the ISP (specific impulse) of the RCS.

`thrusters` defined as a `List<RcsModule.Thruster>` defines the thrusters of the RCS.

`source` defined as a `SFS.Parts.Modules.FlowModule` references the resource source of the RCS.

`thrustPosition` defined as a `Vector2` defines the thrust position (offset) of the RCS.

## RcsModule.Thruster
`SFS.Parts.Modules.RcsModule.Thruster` defines a thruster of the RCS.

`thrustNormal` defined as a `Vector2` defines the thrust normal (direction) of the thruster.

`effect` defined as a `SFS.Parts.Modules.MoveModule` references the `MoveModule` that will be responsible for the thruster visual effects.

## Fields summary
### SFS.Parts.Modules.RcsModule
| Name | Type | Description |
|-|-|-|
| `directionAngleThreshold` | `float` | RCS direction angle threshold |
| `torqueAngleThreshold` | `float` | RCS torque angle threshold |
| `thrust` | `float` | RCS thrust |
| `ISP` | `float` | RCS ISP |
| `thrusters` | `List<RcsModule.Thruster>` | RCS thrusters |
| `source` | `SFS.Parts.Modules.FlowModule` | RCS resource source |
| `thrustPosition` | `Vector2` | RCS thrust position |

### SFS.Parts.Modules.RcsModule.Thruster
| Name | Type | Description |
|-|-|-|
| `thrustNormal` | `Vector2` | RCS thrust normal |
| `effect` | `SFS.Parts.Modules.MoveModule` | RCS thruster visual effects |