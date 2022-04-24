# SkinModule
`SFS.Parts.Modules.SkinModule` adds texture customization capabilities to parts.

## Fields
`skinTag` defined as a `string` defines in which "skin group" the part is. This is the value referenced in the `tags` field of `SFS.Parts.ColorTexture` and `SFS.Parts.ShapeTexture`.

`meshModules` defined as a `SFS.Parts.Modules.PipeMesh[]` holds the `PipeMesh`es affected by the skin changes. The `textureMode` field of the `PipeMesh`es' `textures` needs to be set to `Basic` in order to be affected.

`colorTextureName` defined as a `SFS.Variables.String_Reference` holds a reference to the variable used to define the color texture. It usually references a variable named `color_tex`.

`shapeTextureName` defined as a `SFS.Variables.String_Reference` holds a reference to the variable used to define the shape texture. It usually references a variable named `shape_tex`.

`disableColorSelect` defined as a `bool` determines if the meshes color texture can be changed.

`disableShapeSelect` defined as a `bool` determines if the meshes shape texture can be changed.

## Fields summary
### SFS.Parts.Modules.SkinModule
| Name | Type | Description |
|-|-|-|
| `skinTag` | `string` | Skin "group" |
| `meshModules` | `SFS.Parts.Modules.PipeMesh[]` | List of `PipeMesh`es to affect |
| `colorTextureName` | `SFS.Variables.String_Reference` | Color texture variable reference |
| `shapeTextureName` | `SFS.Variables.String_Reference` | Shape texture variable reference |
| `disableColorSelect` | `bool` | Disable color texture selection |
| `disableShapeSelect` | `bool` | Disable shape texture selection |