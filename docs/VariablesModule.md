# VariablesModule
> Note: most classes discussed here are defined in `SFS.Variables`

`SFS.Variables.VariablesModule` is a very important component that is used all across the part system.

It is used to store string, boolean or double/float variables that can be used by other part modules.

It needs to be referenced in the `Part` component of a part by assigning its `variablesModule`.

## Adding variables
New variables can be defined using the `SetValue` method on one of the `VariableList<T>` of the variables module. There are currently 3 variables lists:
- doubleVariables
- boolVariables
- stringVariables

The signature of `SetValue` depends on the type `T` of the variable list but follow the structure: 
```csharp
SetValue("variable name", VALUE, (true, true));
```
The first value of the tuple at the end is to add the variable if it doesn't exist and the second value is to add the variable to the list of saved variables.

## Using variables
Variables are used either via `Composed<T>` or `ReferenceVariable<T>`. Both have utilities for their creation defined in `SFSEX.PartsInjector.Utils.Variables`.

`Composed_Float`s are the most common type of `Composed<T>` and are used to defined equations that use variables in other modules.
Example: the `mass` of the `Part` of a strut is defined as `size * 0.1`.

`ReferenceVariable<T>` are used to directly reference the value of a variable without further operations. 
Example: the `colorTextureName` of the `SkinModule` of a  fuel tank is set to a `String_Reference` that points to a variable named `color_tex`.

## Fields summary
### SFS.Variables.VariablesModule
| Name | Type | Description | 
|-|-|-|
| `doubleVariables` | `SFS.Variables.DoubleVariableList` | `double` variables |
| `boolVariables` | `SFS.Variables.BoolVariableList` | `bool` variables |
| `stringVariables` | `SFS.Variables.StringVariableList` | `string` variables |