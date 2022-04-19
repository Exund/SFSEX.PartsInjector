# MoveModule
`SFS.Parts.Modules.MoveModule` adds animation capabilities to parts.

## Fields
`time` defined as a `SFS.Variables.Float_Reference` holds a reference to the variable used to define the current time of the animation.

`targetTime` defined as a `SFS.Variables.Float_Reference` holds a reference to the variable used to define the target time of the animation.

`animationTime` defined as a `float` defines speed of the animation.

`unscaledTime` defined as a `bool` defines whether the animation should be played at the same speed regardless of the time scale.

`animationElements` defined as a `SFS.Parts.Modules.MoveData[]` holds the animation data.

## MoveData
`SFS.Parts.Modules.MoveData` defines animation data.

`type` defined as a `SFS.Parts.Modules.MoveData.Type` defines the animation type.

`offset` defined as a `float` defines the offset of the animation.

`transform` defined as a `UnityEngine.Transform` defines the target transform.

`spriteRenderer` defined as a `UnityEngine.SpriteRenderer` defines the target sprite renderer.

`image` defined as a `UnityEngine.UI.Image` defines the target image.

`X` defined as a `UnityEngine.AnimationCurve` defines the animation curve for the X axis.

`Y` defined as a `UnityEngine.AnimationCurve` defines the animation curve for the Y axis.

`gradient` defined as a `UnityEngine.Gradient` defines the color gradient for the animation.

`audioSource` defined as a `UnityEngine.AudioSource` defines the target audio source.

The animation and the involved fields depend on the value of the `type` field.

| Value of `type` | Fields | Curves | Description |
|-|-|-|-|
| `Type.RotationZ` | `transform` | `X` | Animates the local euler angles of the `transform` on the Z axis |
| `Type.Scale` | `transform` | `X`, `Y` | Animates the local scale of the `transform` on the X and Y axis |
| `Type.Position` | `transform` | `X`, `Y` | Animates the local position of the `transform` on the X and Y axis |
| `Type.SpriteColor` | `spriteRenderer` | `gradient` | Animates the color of the `spriteRenderer` |
| `Type.ImageColor` | `image` | `gradient` | Animates the color of the `image` |
| `Type.Active` | `transform` | `X` | Activates the `transform` gameobject if the evaluated value <= 0. Also animates the volume of the first `UnityEngine.AudioSource` found on the `transform` |
| `Type.Inactive` | `transform` | `X` | Deactivates the `transform` gameobject if the evaluated value > 0 |
| `Type.SoundVolume` | `audioSource` | `X` | Animates the volume of the `audioSource`. |
| `Type.AnchoredPosition` | `transform` | `X`, `Y` | Animates the anchored position of the `transform` casted as a `UnityEngine.RectTransform` on the X and Y axis |
| `Type.RotationXY` | `transform` | `X`, `Y` | Animates the local euler angles of the `transform` on the X and Y axis |

## Fields summary
### SFS.Parts.Modules.MoveModule
| Name | Type | Description |
|-|-|-|
| `time` | `SFS.Variables.Float_Reference` | Current time variable reference |
| `targetTime` | `SFS.Variables.Float_Reference` | Target time variable reference |
| `animationTime` | `float` | Animation speed |
| `unscaledTime` | `bool` | Ignore global time scale |
| `animationElements` | `SFS.Parts.Modules.MoveData[]` | Animation data |

### SFS.Parts.Modules.MoveData
| Name | Type | Description |
|-|-|-|
| `type` | `SFS.Parts.Modules.MoveData.Type` | Animation type |
| `offset` | `float` | Animation offset |
| `transform` | `UnityEngine.Transform` | Target transform |
| `spriteRenderer` | `UnityEngine.SpriteRenderer` | Target sprite renderer |
| `image` | `UnityEngine.UI.Image` | Target image |
| `X` | `UnityEngine.AnimationCurve` | Animation curve for the X axis |
| `Y` | `UnityEngine.AnimationCurve` | Animation curve for the Y axis |
| `gradient` | `UnityEngine.Gradient` | Color gradient |
| `audioSource` | `UnityEngine.AudioSource` | Target audio source |

### SFS.Parts.Modules.MoveData.Type
| Name | Value |
|-|-|
| `RotationZ` | `0` |
| `Scale` | `1` |
| `Position` | `2` |
| `CenterOfMass` | `3` |
| `CenterOfDrag` | `4` |
| `SpriteColor` | `5` |
| `ImageColor` | `6` |
| `Active` | `7` |
| `Inactive` | `8` |
| `SoundVolume` | `9` |
| `AnchoredPosition` | `10` |
| `RotationXY` | `11` |