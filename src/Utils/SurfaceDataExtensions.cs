using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

using SFS.Parts.Modules;

namespace SFSEX.PartsInjector.Utils
{
    public static class SurfaceDataExtensions
    {
        private static readonly FieldInfo attachmentSurfaces = AccessTools.Field(typeof(SurfaceData), "attachmentSurfaces");
        private static readonly FieldInfo dragSurfaces = AccessTools.Field(typeof(SurfaceData), "dragSurfaces");

        public static void GenerateAttachmentSurfaces(this SurfaceData surface, bool value)
        {
            attachmentSurfaces.SetValue(surface, value);
        }

        public static void GenerateDragSurfaces(this SurfaceData surface, bool value)
        {
            dragSurfaces.SetValue(surface, value);
        }

        private static readonly FieldInfo colliderArea = AccessTools.Field(typeof(PolygonData), "colliderArea");
        private static readonly FieldInfo clickArea = AccessTools.Field(typeof(PolygonData), "clickArea");

        public static void GenerateColliderArea(this PolygonData polygon, bool value)
        {
            attachmentSurfaces.SetValue(polygon, value);
        }

        public static void GenerateClickArea(this PolygonData polygon, bool value)
        {
            dragSurfaces.SetValue(polygon, value);
        }
    }
}
