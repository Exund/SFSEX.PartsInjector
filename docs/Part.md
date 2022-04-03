# Part
The `SFS.Parts.Part` component is what defines a gameobject as an actual part. 

All the parts in the build inventory are defined in `SFS.Base.partsLoader.parts` defined as a `Dictionary<string, Part>`.

The key is the name of the gameobject on which the `Part` component is added (The strut part is indexed at "Strut" and the gameobject name of the `Part` is also "Strut").

## Fields
### Name
The name of the part is a unique string used to index the part in `SFS.Base.partsLoader.parts`. It's stored in `name` and is defined as a `string`.

### Display name and description
The display name and description of parts are defined as the `displayName` and `description` fields. Both are defined as `SFS.Translations.TranslationVariable`s which has utilities for its creation defined in `SFSEX.PartsInjector.Utils.Translations`.

### Mass and center of mass
The mass and center of mass of parts are defined as the `mass` and `centerOfMass` fields.

`mass` is defined as a `SFS.Variables.Composed_Float` and `centerOfMass` as a `SFS.Variables.Composed_Vector2` which is itself composed of 2 `Composed_Float`s.
> See [VariableModule](./VariablesModule.md#using-variables) for more info

### Modules references
There are references to at least 2 other modules namely a `SFS.Variables.VariablesModule` with `variablesModule` and an `SFS.Parts.Modules.OrientationModule` with `orientation`. Both needing to be assigned for the part to work.

`variablesModule` stores all the variables used by that part.
> See [VariableModule](./VariablesModule.md) for more info

`orientation` is used to keep track of the scale and rotation of the part.

### Variants
The different variants of a part are stored in `variants` defined as a `SFS.Parts.Modules.Variants[]`.
> See [Variants](./Variants.md) for explaination

## Fields summary
### SFS.Parts.Part
| Name | Type | Description |
|-|-|-|
| `name` | `string` | GameObject name (must be unique for every part) |
| `displayName` | `SFS.Translations.TranslationVariable` | |
| `description` | `SFS.Translations.TranslationVariable` | |
| `mass` | `SFS.Variables.Composed_Float` | |
| `centerOfMass` | `SFS.Variables.Composed_Vector2` | |
| `variablesModule` | `SFS.Variables.VariablesModule` | [Variables](VariablesModule.md) storage |
| `orientation` | `SFS.Parts.Modules.OrientationModule` | Scale and rotation tracking at runtime |
| `variants` | `SFS.Parts.Modules.Variants[]` | [Variants](./Variants.md) definitions |