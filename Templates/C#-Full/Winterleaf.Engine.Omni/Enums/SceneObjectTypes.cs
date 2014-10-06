#region

using System;

#endregion

namespace WinterLeaf.Engine.Enums
    {
    /// <summary>
    /// The Scene Object type flags.
    /// </summary>
    [Flags]
    public enum SceneObjectTypesAsUint : uint
        {
        /// <summary>
        /// 
        /// </summary>
        DefaultObjectType = 0x00000000,

        /// <summary>
        /// 
        /// </summary>
        StaticObjectType = 0x00000001,

        /// <summary>
        /// 
        /// </summary>
        EnvironmentObjectType = 0x00000002,

        /// <summary>
        /// 
        /// </summary>
        TerrainObjectType = 0x00000004,


        /// <summary>
        /// 
        /// </summary>
        WaterObjectType = 0x00000008, //

        /// <summary>
        /// 
        /// </summary>
        TriggerObjectType = 0x00000010, //

        /// <summary>
        /// 
        /// </summary>
        MarkerObjectType = 0x00000020, //

        /// <summary>
        /// 
        /// </summary>
        LightObjectType = 0x00000040, //

        /// <summary>
        /// 
        /// </summary>
        ZoneObjectType = 0x00000080, //

        /// <summary>
        /// 
        /// </summary>
        StaticShapeObjectType = 0x00000100, //

        /// <summary>
        /// 
        /// </summary>
        DynamicShapeObjectType = 0x00000200, //

        /// <summary>
        /// 
        /// </summary>
        GameBaseObjectType = 0x00000400, //

        /// <summary>
        /// 
        /// </summary>
        GameBaseHiFiObjectType = 0x00000800, //

        /// <summary>
        /// 
        /// </summary>
        ShapeBaseObjectType = 0x00001000, //

        /// <summary>
        /// 
        /// </summary>
        CameraObjectType = 0x00002000, //

        /// <summary>
        /// 
        /// </summary>
        PlayerObjectType = 0x00004000, //

        /// <summary>
        /// 
        /// </summary>
        ItemObjectType = 0x00008000, //

        /// <summary>
        /// 
        /// </summary>
        VehicleObjectType = 0x00010000, //

        /// <summary>
        /// 
        /// </summary>
        VehicleBlockerObjectType = 0x00020000, //

        /// <summary>
        /// 
        /// </summary>
        ProjectileObjectType = 0x00040000, //

        /// <summary>
        /// 
        /// </summary>
        ExplosionObjectType = 0x00080000, //

        /// <summary>
        /// 
        /// </summary>
        CorpseObjectType = 0x00100000, //

        /// <summary>
        /// 
        /// </summary>
        DebrisObjectType = 0x00200000, //

        /// <summary>
        /// 
        /// </summary>
        PhysicalZoneObjectType = 0x00400000,

        /// <summary>
        /// 
        /// </summary>
        Flag24 = 0x00800000,

        /// <summary>
        /// 
        /// </summary>
        Flag25 = 0x01000000,

        /// <summary>
        /// 
        /// </summary>
        Flag26 = 0x02000000,

        /// <summary>
        /// 
        /// </summary>
        Flag27 = 0x04000000,

        /// <summary>
        /// 
        /// </summary>
        Flag28 = 0x08000000,

        /// <summary>
        /// 
        /// </summary>
        Flag29 = 0x10000000,

        /// <summary>
        /// 
        /// </summary>
        Flag30 = 0x20000000,

        /// <summary>
        /// 
        /// </summary>
        Flag31 = 0x40000000
        }

    /// <summary>
    /// The Scene Object type flags.
    /// </summary>
    [Flags]
    public enum SceneObjectTypesAsInt
        {
        /// <summary>
        /// 
        /// </summary>
        DefaultObjectType = 0x00000000,

        /// <summary>
        /// 
        /// </summary>
        StaticObjectType = 0x00000001,

        /// <summary>
        /// 
        /// </summary>
        EnvironmentObjectType = 0x00000002,

        /// <summary>
        /// 
        /// </summary>
        TerrainObjectType = 0x00000004,


        /// <summary>
        /// 
        /// </summary>
        WaterObjectType = 0x00000008, //

        /// <summary>
        /// 
        /// </summary>
        TriggerObjectType = 0x00000010, //

        /// <summary>
        /// 
        /// </summary>
        MarkerObjectType = 0x00000020, //

        /// <summary>
        /// 
        /// </summary>
        LightObjectType = 0x00000040, //

        /// <summary>
        /// 
        /// </summary>
        ZoneObjectType = 0x00000080, //

        /// <summary>
        /// 
        /// </summary>
        StaticShapeObjectType = 0x00000100, //

        /// <summary>
        /// 
        /// </summary>
        DynamicShapeObjectType = 0x00000200, //

        /// <summary>
        /// 
        /// </summary>
        GameBaseObjectType = 0x00000400, //

        /// <summary>
        /// 
        /// </summary>
        GameBaseHiFiObjectType = 0x00000800, //

        /// <summary>
        /// 
        /// </summary>
        ShapeBaseObjectType = 0x00001000, //

        /// <summary>
        /// 
        /// </summary>
        CameraObjectType = 0x00002000, //

        /// <summary>
        /// 
        /// </summary>
        PlayerObjectType = 0x00004000, //

        /// <summary>
        /// 
        /// </summary>
        ItemObjectType = 0x00008000, //

        /// <summary>
        /// 
        /// </summary>
        VehicleObjectType = 0x00010000, //

        /// <summary>
        /// 
        /// </summary>
        VehicleBlockerObjectType = 0x00020000, //

        /// <summary>
        /// 
        /// </summary>
        ProjectileObjectType = 0x00040000, //

        /// <summary>
        /// 
        /// </summary>
        ExplosionObjectType = 0x00080000, //

        /// <summary>
        /// 
        /// </summary>
        CorpseObjectType = 0x00100000, //

        /// <summary>
        /// 
        /// </summary>
        DebrisObjectType = 0x00200000, //

        /// <summary>
        /// 
        /// </summary>
        PhysicalZoneObjectType = 0x00400000,

        /// <summary>
        /// 
        /// </summary>
        Flag24 = 0x00800000,

        /// <summary>
        /// 
        /// </summary>
        Flag25 = 0x01000000,

        /// <summary>
        /// 
        /// </summary>
        Flag26 = 0x02000000,

        /// <summary>
        /// 
        /// </summary>
        Flag27 = 0x04000000,

        /// <summary>
        /// 
        /// </summary>
        Flag28 = 0x08000000,

        /// <summary>
        /// 
        /// </summary>
        Flag29 = 0x10000000,

        /// <summary>
        /// 
        /// </summary>
        Flag30 = 0x20000000,

        /// <summary>
        /// 
        /// </summary>
        Flag31 = 0x40000000
        }
    }