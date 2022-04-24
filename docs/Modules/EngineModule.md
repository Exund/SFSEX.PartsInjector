# EngineModule
`SFS.Parts.Modules.EngineModule` adds engine functionalities to parts.

## Fields
`thrust` defined as a `SFS.Variables.Composed_Float` defines the thrust of the engine.

`thrustNormal` defined as a `SFS.Variables.Composed_Vector2` defines the thrust normal (direction) of the engine. Defaults to `Vector2.up`.

`ISP` defined as a `SFS.Variables.Composed_Float` defines the ISP (specific impulse) of the engine.

`thrustPosition` defined as a `SFS.Variables.Composed_Vector2` defines the thrust position (offset) of the engine. Defaults to `Vector2.zero`.

`source` defined as a `SFS.Parts.Modules.FlowModule` references the resource source of the engine.

`gimbal` defined as a `SFS.Parts.Modules.MoveModule` references the `MoveModule` that will be responsible for the gimbal of the engine.

`engineOn` defined as a `SFS.Variables.Bool_Reference` holds a reference to the variable that defines the state of the engine. It usually references a variable named `engine_on`.

`throttle_Out` defined as a `SFS.Variables.Float_Reference` holds a reference to the variable that defines the throttle output of the engine. It usually references a variable named `throttle`.

`heatOn` defined as a `SFS.Variables.Bool_Reference` holds a reference to the variable that defines if the engine should emit heat. It usually references a variable named `heat_on__for_creative_use`.

`heatHolder` defined as a `UnityEngine.GameObject` references the heat emmiting part of the engine.

`oldMass` defined as a `float` defines the mass of the engine.

## Fields summary
### SFS.Parts.Modules.EngineModule
| Name | Type | Description |
|-|-|-|
| `thrust` | `SFS.Variables.Composed_Float` | Engine thrust |
| `thrustNormal` | `SFS.Variables.Composed_Vector2` | Engine thrust normal |
| `ISP` | `SFS.Variables.Composed_Float` | Engine ISP |
| `thrustPosition` | `SFS.Variables.Composed_Vector2` | Engine thrust position |
| `source` | `SFS.Parts.Modules.FlowModule` | Engine resource source |
| `gimbal` | `SFS.Parts.Modules.MoveModule` | Engine gimbal |
| `engineOn` | `SFS.Variables.Bool_Reference` | Engine on variable reference |
| `throttle_Out` | `SFS.Variables.Float_Reference` | Engine throttle output variable reference |
| `heatOn` | `SFS.Variables.Bool_Reference` | Engine heat on variable reference |
| `heatHolder` | `UnityEngine.GameObject` | Engine heat emmiting part reference |
| `oldMass` | `float` | Engine mass |