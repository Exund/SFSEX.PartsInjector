# ResourceType
`SFS.Parts.Modules.ResourceType` defines a type of resource.

A list containing every `ResourceType` can be obtained using:
```csharp
UnityEngine.Resources.FindObjectsOfTypeAll<ResourceType>()
``` 
or individually loaded with 
```csharp
UnityEngine.Resources.Load<ResourceType>("fuels/<name>")
```
where `<name>` is the name of the resource object.

## Fields
`displayName` defined as a `SFS.Translations.TranslationVariable` defines the name of the resource.

`resourceUnit` defined as a `SFS.Translations.TranslationVariable` defines the name of the unit of the resource.

> `SFS.Translations.TranslationVariable` has utilities for its creation defined in `SFSEX.PartsInjector.Utils.Translations`

`resourceMass` defined as a `double` defines the mass of the resource.

`transferRate` defined as a `double` defines the transfer rate of the resource.

## Fields summary
| Name | Type | Description |
|-|-|-|
| `displayName` | `SFS.Translations.TranslationVariable` | Name of the resource |
| `resourceUnit` | `SFS.Translations.TranslationVariable` | Name of the unit of the resource |
| `resourceMass` | `double` | Mass of the resource |
| `transferRate` | `double` | Transfer rate of the resource |