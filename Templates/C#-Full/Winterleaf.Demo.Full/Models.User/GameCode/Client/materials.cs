using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
    {
    public class materials
        {
        public static void initialize()
            {
            SingletonCreator sc = new SingletonCreator("Material", "WarningMaterial");
            sc["diffuseMap[0]"] = "core/art/warnMat";
            sc["emissive[0]"] = false;
            sc["translucent"] = false;
            sc.Create();

            sc = new SingletonCreator("CubemapData", "WarnMatCubeMap");
            sc["cubeFace[0]"] = "core/art/warnMat";
            sc["cubeFace[1]"] = "core/art/warnMat";
            sc["cubeFace[2]"] = "core/art/warnMat";
            sc["cubeFace[3]"] = "core/art/warnMat";
            sc["cubeFace[4]"] = "core/art/warnMat";
            sc["cubeFace[5]"] = "core/art/warnMat";
            sc.Create();
            }
        }
    }