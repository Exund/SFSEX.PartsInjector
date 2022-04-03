# Variants
> Note: most classes discussed here are defined in `SFS.Parts.Modules.Variants`

Variants are a concept that makes multiple parts differing only slighty very easy to make. For example all the basic fuel tanks are defined as 1 part in the parts registry but are all defined as variants of a base setup.

## Variant groups
`SFS.Parts.Modules.Variants` can be considered a variant group. It holds the pick categories common to every variant in `tags` defined as a `PickTag[]` and the list of variants in `variants` defined as a `Variant[]`

### Pick tags
A `PickTag` holds the inventory category for a variant in `tag` defined as a `SFS.Builds.PickCategory` and the priority of the part in that category in `priority` defined as an `int`.

A list containing every `PickCategory` can be obtained using:
```csharp
UnityEngine.Resources.FindObjectsOfTypeAll<PickCategory>()
``` 
or individually loaded with 
```csharp
UnityEngine.Resources.Load<PickCategory>("pick categories/<name>")
```
where `<name>` is the name of the category object.

## Variant
A variant holds its own pick categories in `tags` defined as a `PickTag[]` and its variables changes in `changes` defined as a `Variable[]`

## Variable
`Variable` holds the name of the variable to change in `name` defined as a `string` and the type of the variable in `type` defined as a `Variable.ValueType`.

It also holds the new value of the variable in different fields depending on `type`.

| Field | Type | Value of `type` |
|-|-|-|
| `numberValue` | `double` | `ValueType.Number` |
| `toggleValue` | `bool` | `ValueType.Toggle` |
| `textValue` | `string` | `ValueType.Text` |

## Fields summary
### SFS.Parts.Modules.Variants
| Name | Type | Description |
|-|-|-|
| `tags` | `SFS.Parts.Modules.Variants.PickTag[]` | Inventory categories for all variants in this variant group |
| `variants` | `SFS.Parts.Modules.Variants.Variant[]` | Variants data |

### SFS.Parts.Modules.Variants.PickTag
| Name | Type | Description |
|-|-|-|
| `tag` | `SFS.Builds.PickCategory` | Inventory category |
| `priority` | `int` | Priority of the part in the inventory (determines position) |

### SFS.Parts.Modules.Variants.Variant
| Name | Type | Description |
|-|-|-|
| `tags` | `SFS.Parts.Modules.Variants.PickTag[]` | Inventory categories for this variant |
| `changes` | `SFS.Parts.Modules.Variants.Variable[]` | Variables changes |

### SFS.Parts.Modules.Variants.Variable
| Name | Type | Description |
|-|-|-|
| `name` | `string` | Name of the variable to change |
| `type` | `Variants.Variable.ValueType` | Type of the variable to change |
| `numberValue` | `double` | |
| `toggleValue` | `bool` | |
| `textValue` | `string` | |

### SFS.Parts.Modules.Variants.Variable.ValueType
| Name | Value |
|-|-|
| `Number` | 0 |
| `Toggle` | 1 |
| `Text` | 2 |