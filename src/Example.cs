using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

using SFS;
using SFS.Builds;
using SFS.Parts;
using SFS.Parts.Modules;
using SFS.Variables;
using SFSEX.PartsInjector.Utils;

namespace Example
{
    class Example : ModLoader.SFSMod
    {
        public Example() : base("example", "example", "", "v1.x.x", "v0.0.1", dependencies: new Dictionary<string, string[]>
        {
            // Add dependency to Part Injector
            {
                "SFSEX.PartsInjector",
                new []
                {
                    "v0.0.1"
                }
            }
        })
        { }

        public override void load()
        {
            LoadParts();
        }

        public override void unload()
        {
            
        }

        void LoadParts()
        {
            // Create a new game object for the part
            var gameobject = new GameObject("Example"); // Unique name can be wither set by creating a new game object or setting it later with "name"
            gameobject.SetActive(false); // Not technically required but creates some issues with some components when the object is active

            // Add a part component
            Part p = gameobject.AddComponent<Part>();
            // Part name can also be set here
            // p.name = "Example"; 

            // Add the variables module
            p.variablesModule = gameobject.AddComponent<SFS.Variables.VariablesModule>();

            // Define variables before usage
            p.variablesModule.doubleVariables.SetValue("size", 1, (true, true));

            // Example of Translation utility usage
            p.displayName = SFSEX.PartsInjector.Utils.Translations.AddTranslation("Example_Name", SFS.Translations.Field.Text("Example Part"));

            // Example of Variables utility usage
            p.mass = SFSEX.PartsInjector.Utils.Variables.CreateComposedFloat("size * size", p.variablesModule);

            p.centerOfMass = new Composed_Vector2(Vector2.zero)
            {
                x = SFSEX.PartsInjector.Utils.Variables.CreateComposedFloat("size * 0.5", p.variablesModule),
                y = SFSEX.PartsInjector.Utils.Variables.CreateComposedFloat("size * 0.5", p.variablesModule),
            };

            // Orientation module
            p.orientation = gameobject.AddComponent<OrientationModule>();

            // Variants
            var tags = new Variants.PickTag[]
            {
                new Variants.PickTag()
                {
                    priority = 0,
                    tag = Resources.Load<PickCategory>("pick categories/Structural")
                }
            };

            p.variants = new Variants[]
            {
                new Variants()
                {
                    tags = tags,
                    variants = new Variants.Variant[]
                    {
                        new Variants.Variant()
                        {
                            changes = new Variants.Variable[]
                            {
                                new Variants.Variable()
                                {
                                    name = "size",
                                    type = Variants.Variable.ValueType.Number,
                                    numberValue = 1
                                }
                            }
                        },
                        new Variants.Variant()
                        {
                            changes = new Variants.Variable[]
                            {
                                new Variants.Variable()
                                {
                                    name = "size",
                                    type = Variants.Variable.ValueType.Number,
                                    numberValue = 2
                                }
                            }
                        },
                        new Variants.Variant()
                        {
                            changes = new Variants.Variable[]
                            {
                                new Variants.Variable()
                                {
                                    name = "size",
                                    type = Variants.Variable.ValueType.Number,
                                    numberValue = 3
                                }
                            }
                        }
                    }
                }
            };

            // Pipe mesh
            var pipeMesh = gameobject.AddComponent<PipeMesh>();

            pipeMesh.textures = new Textures()
            {
                textureMode = Mode.Basic,
                texture = new Textures.TextureSelector()
                {
                    colorTexture = Base.partsLoader.colorTextures["Color_White"],
                    shapeTexture = Base.partsLoader.shapeTextures["Flat Smooth 4"]
                },
                widthMode = Textures.WidthMode.Standard,
            };

            pipeMesh.colors = new Colors()
            {
                mode = Mode.Basic,
                color = new Colors.ColorSelector()
                {
                    type = Colors.ColorSelector.Type.Local,
                    colorBasic = Color.green
                }
            };

            // Collider
            var collider = gameobject.AddComponent<PolygonCollider>();
            collider.impactTolerance = ColliderModule.ImpactTolerance.Low;

            // Mesh/Collider data
            var pipeData = gameobject.AddComponent<SimplePipe>();

            // Set using utility extension methods from SFSEX.PartsInjector.Utils
            pipeData.GenerateAttachmentSurfaces(true);
            pipeData.GenerateDragSurfaces(true);
            pipeData.GenerateColliderArea(true);
            pipeData.GenerateClickArea(false);

            pipeData.width_a = SFSEX.PartsInjector.Utils.Variables.CreateComposedFloat("size", p.variablesModule);
            pipeData.width_b = SFSEX.PartsInjector.Utils.Variables.CreateComposedFloat("size", p.variablesModule);

            pipeData.height_a = SFSEX.PartsInjector.Utils.Variables.CreateComposedFloat("0", p.variablesModule);
            pipeData.height_b = SFSEX.PartsInjector.Utils.Variables.CreateComposedFloat("size", p.variablesModule);

            pipeMesh.pipeData = pipeData;
            collider.polygon = pipeData;

            // Register part
            SFSEX.PartsInjector.Injector.RegisterPart(p);


            /*
            // Parts can also be created by cloning existing parts
            var reference = Base.partsLoader.parts["Strut"];
            reference.SetActive(false); // Not technically required but creates some issues with some components when the object is active

            var part = UnityEngine.Object.Instantiate(reference).gameObject;
            var gameobject = part.gameObject;

            // Rest of the configuration ... 
            */
        }
    }
}
