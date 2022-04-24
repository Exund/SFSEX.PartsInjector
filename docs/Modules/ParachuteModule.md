# ParachuteModule
`SFS.Parts.Modules.ParachuteModule` adds parachute capabilities to parts.

## Fields
`parachute` defined as a `UnityEngine.Transform` references the actual parachute transform.

`drag` defined as a `UnityEngine.AnimationCurve` defines the drag curve of the parachute according to its opening state.

`onDeploy` defined as a `UnityEngine.Events.UnityEvent` is triggered when the parachute is deployed. It is currently not used by vanilla parachutes.

`maxDeployHeight` defined as a `double` defines the maximum height the parachute can be deployed.

`maxDeployVelocity` defined as a `double` defines the maximum velocity the parachute can be deployed.

`state` defined as a `SFS.Variables.Float_Reference` holds a reference to the variable that defines the state of the parachute. It is usually the same as the `time` variable of the `SFS.Parts.Modules.MoveModule` used for animation.

`targetState` defined as a `SFS.Variables.Float_Reference` holds a reference to the variable that defines the target state of the parachute. It is usually the same as the `targetTime` variable of the `SFS.Parts.Modules.MoveModule` used for animation.

## Fields summary
### SFS.Parts.Modules.ParachuteModule
| Name | Type | Description |
|-|-|-|
| `parachute` | `UnityEngine.Transform` | Parachute transform |
| `drag` | `UnityEngine.AnimationCurve` | Parachute drag curve |
| `onDeploy` | `UnityEngine.Events.UnityEvent` | Parachute deploy event |
| `maxDeployHeight` | `double` | Maximum parachute deploy height |
| `maxDeployVelocity` | `double` | Maximum parachute deploy velocity |
| `state` | `SFS.Variables.Float_Reference` | Parachute state variable reference |
| `targetState` | `SFS.Variables.Float_Reference` | Parachute target state variable reference |