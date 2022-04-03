# PipeMesh
> Note: most classes discussed here are defined in `SFS.Parts.Modules`

`SFS.Parts.Modules.PipeMesh` is one of the components used to generate the parts meshes. It references pipe data in `pipeData` defined as a `PipeData` and holds the texture mapping data in `textures` defined as a `Textures` as well as the color tinting data in `colors` defined as a `Colors`.

> See [PipeData](./SurfaceData/PolygonData/PipeData/PipeData.md) for more info

## Textures
`Textures` holds texture mapping data. The configuration mode is stored in `textureMode` defined as a `Mode`.

The data is stored in different fields depending on the value of `textureMode`.

| Field | Type | Value of `textureMode` |
|-|-|-|
| `texture` | `Textures.TextureSelector` | `Mode.Basic` |
| `textures` | `Textures.TextureKey[]` | `Mode.Advanced` |

The mapped width of the texture data is different depending on the vaue of `widthMode` defined as a `Textures.WidthMode`

| Width calculation | Value of `textureMode` |
|-|-|
| Average of the average of the width of the first and last point of the `PipeData`, and of the maximum width bewteen the first and last point of the `PipeData`  | `Textures.WidthMode.Standard` |
| Field `width` defined as a `SFS.Variables.Composed_Float`  | `Textures.WidthMode.Composed` |

### Textures.TextureSelector
`Textures.TextureSelector` holds the color texture in `colorTexture` defined as a `ColorTexture` and the shape texture in `shapeTexture` defined as a `ShapeTexture` for the entire size of the mesh. Used for parts with a single texture.

> You can find a dictionary of all `ColorTextures` in `SFS.Base.partsLoader.colorTextures`. The keys are the same values as the ones saved in bluprints in `color_tex`.

> You can find a dictionary of all `ShapeTextures` in `SFS.Base.partsLoader.shapeTextures`. The keys are the same values as the ones saved in bluprints in `shape_tex`.

### Textures.TextureKey
`Textures.TextureKey` holds the texture data in `texture` defined as a `Textures.TextureSelector` and the height of the texture in `height` defined as a `float`.

> When used in a list, the height should be the sum of then preceding `Textures.TextureKey`s' heights plus whatever height wanted.

## Colors
`Colors` holds color tinting data. The configuration mode is stored in `mode` defined as a `Mode`.

The data is stored in different fields depending on the value of `mode`.

| Field | Type | Value of `mode` |
|-|-|-|
| `color` | `Colors.ColorSelector` | `Mode.Basic` |
| `colors` | `Colors.ColorKey[]` | `Mode.Advanced` |

### Colors.ColorSelector
`Colors.ColorSelector` holds the configuration mode in `type` defined as a `Colors.ColorSelector.Type`.

The color tinting data is stored in different fields depending on the value of `type`.

| Field | Type | Value of `mode` |
|-|-|-|
| `colorBasic` | `UnityEngine.Color` | `Colors.ColorSelector.Type.Local` |
| `colorModule` | `ColorModule` | `Colors.ColorSelector.Type.Module` |

### Colors.ColorKey
`Colors.ColorKey` holds the color tinting data in `color` defined as a `Colors.ColorSelector` and the height of the texture in `height` defined as a `float`.

> When used in a list, the height should be the sum of then preceding `Colors.ColorKey`s' heights plus whatever height wanted.

## Fields summary
### SFS.Parts.Modules.PipeMesh
| Name | Type | Description |
|-|-|-|
| `pipeData` | `SFS.Parts.Modules.PipeData` | Reference to a `PipeData` component |
| `textures` | `SFS.Parts.Modules.Textures` | Texture mapping data |
| `colors` | `SFS.Parts.Modules.Colors` | Color tinting data |

### SFS.Parts.Modules.Textures
| Name | Type | Description |
|-|-|-|
| `textureMode` |  `SFS.Parts.Modules.Mode` | Configuration mode |
| `texture` | `SFS.Parts.Modules.Textures.TextureSelector` | Single texture config |
| `textures` | `SFS.Parts.Modules.Textures.TextureKey[]` | Multi texture config |
| `widthMode` | `SFS.Parts.Modules.Textures.WidthMode` | Texture width calculation mode |
| `width` | `SFS.Variables.Composed_Float` | Manually defined texture width |

### SFS.Parts.Modules.Textures.WidthMode
| Name | Value |
|-|-|
| `Standard` | 0 |
| `Composed` | 1 |

### SFS.Parts.Modules.Textures.TextureSelector
| Name | Type | Description |
|-|-|-|
| `colorTexture` | `SFS.Parts.ColorTexture` | Color texture |
| `shapeTexture` | `SFS.Parts.ShapeTexture` | Shape texture |

### SFS.Parts.Modules.Textures.TextureKey
| Name | Type | Description |
|-|-|-|
| `texture` | `SFS.Parts.Modules.Textures.TextureSelector` | Texture data |
| `height` | `float` | Texture height |

### SFS.Parts.Modules.Colors
| Name | Type | Description |
|-|-|-|
| `mode` |  `SFS.Parts.Modules.Mode` | Configuration mode |
| `color` | `SFS.Parts.Modules.Colors.ColorSelector` | Single color config |
| `colors` | `SFS.Parts.Modules.Colors.ColorKey[]` | Multi color config |

### SFS.Parts.Modules.Colors.ColorSelector
| Name | Type | Description |
|-|-|-|
| `type` | `SFS.Parts.Modules.Colors.ColorSelector.Type` | Configuratioon mode |
| `colorBasic` | `UnityEngine.Color` | Direct color |
| `colorModule` | `SFS.Parts.Modules.ColorModule` | Color provider |

### SFS.Parts.Modules.Colors.ColorSelector.Type
| Name | Value |
|-|-|
| `Local` | 0 |
| `Module` | 1 |

### SFS.Parts.Modules.Colors.ColorKey
| Name | Type | Description |
|-|-|-|
| `color` | `SFS.Parts.Modules.Colors.ColorSelector` | Color tinting data |
| `height` | `float` | Color height |