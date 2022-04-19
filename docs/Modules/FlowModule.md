# FlowModule
`SFS.Parts.Modules.FlowModule` adds resources flow capabilities to parts.

## Fields
`sources` defined as a `SFS.Parts.Modules.FlowModule.Flow[]` holds a list of flow sources.

## FlowModule.Flow
`SFS.Parts.Modules.FlowModule.Flow` defines a resource flow.

`resourceType` defined as a `SFS.Parts.Modules.ResourceType` defines the type of resource.

`flowPercent` defined as a `float` defines the percentage of the flow. Used to scale the flow rate of the module and the mass of the resource. Defaults to 1.

`sourceSearchMode` defined as a `FlowModule.SourceMode` defines the mode of the flow source.

`surface` defined as a `SurfaceData` defines the surface through which the flow passes.

`flowType` defined as a `FlowModule.FlowType` defines the type of flow.

`flowRate` defined as a `Double_Reference` holds a reference to the variable used to define the flow rate.

`state` defined as a `FlowModule.State_Local` defines the state of the flow.

`sources` defined as a `ResourceModule[]` holds a list of flow sources.

## FlowModule.State_Local
`SFS.Parts.Modules.FlowModule.State_Local` inherits from `SFS.Variables.Obs<FlowModule.FlowState>`.

## Fields summary
### SFS.Parts.Modules.FlowModule
| Name | Type | Description |
|-|-|-|
| `sources` | `SFS.Parts.Modules.FlowModule.Flow[]` | List of flow sources |

### SFS.Parts.Modules.FlowModule.Flow
| Name | Type | Description |
|-|-|-|
| `resourceType` | `SFS.Parts.Modules.ResourceType` | Type of resource |
| `flowPercent` | `float` | Percentage of the flow |
| `sourceSearchMode` | `FlowModule.SourceMode` | Mode of the flow source |
| `surface` | `SurfaceData` | Surface through which the flow passes |
| `flowType` | `FlowModule.FlowType` | Type of flow |
| `flowRate` | `Double_Reference` | Flow rate variable reference |
| `state` | `FlowModule.State_Local` | State of the flow |
| `sources` | `ResourceModule[]` | List of sources |

### SFS.Parts.Modules.FlowModule.SourceMode
| Name | Value |
|-|-|
| `Global` | 0 |
| `Surfaces` | 1 |
| `Local` | 2 |

### SFS.Parts.Modules.FlowModule.FlowType
| Name | Value |
|-|-|
| `Negative` | 0 |
| `Positive` | 1 |

### SFS.Parts.Modules.FlowModule.FlowState
| Name | Value |
|-|-|
| `NoSources` | 0 |
| `NoResource` | 1 |
| `NoSpace` | 2 |
| `CanFlow` | 3 |
| `IsFlowing` | 4 |