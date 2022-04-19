# ResourceModule
`SFS.Parts.Modules.ResourceModule` adds resources storing capabilities to parts.

## Fields
`resourceType` defined as a `SFS.Parts.Modules.ResourceType` defines the type of resource stored.

`wetMass` defined as a `SFS.Variables.Double_Reference` holds a reference to the variable used to define the wet mass of the module.

`dryMassPercent` defined as a `SFS.Variables.Double_Reference` holds a reference to the variable used to define the percentage of dry mass of the module.

`resourcePercent` defined as a `SFS.Variables.Double_Reference` holds a reference to the variable used to define the remaining percentage of resource in the module.

`setMass` defined as a `bool` defines whether the mass of the module should be recalculated when `wetMass`, `dryMassPercent` or `resourcePercent` change.

`mass` defined as a `SFS.Variables.Double_Reference` holds a reference to the variable used to define the base mass of the module.

`showDescription` defined as a `bool` defines whether the description of the module should be displayed.

## Fields summary
| Name | Type | Description |
|-|-|-|
| `resourceType` | `SFS.Parts.Modules.ResourceType` | Stored resource |
| `wetMass` | `SFS.Variables.Double_Reference` | Wet mass variable reference |
| `dryMassPercent` | `SFS.Variables.Double_Reference` | Percentage of dry mass variable reference |
| `resourcePercent` | `SFS.Variables.Double_Reference` | Remaining percentage of resource variable reference |
| `setMass` | `bool` | Recalculate mass on changes |
| `mass` | `SFS.Variables.Double_Reference` | Base mass variable reference |
| `showDescription` | `bool` | Show description |