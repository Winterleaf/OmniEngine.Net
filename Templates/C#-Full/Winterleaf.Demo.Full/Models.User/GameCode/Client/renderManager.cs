using System;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
    {
    public class renderManager
        {
        public static void initialize()
            {
            SingletonCreator sc = new SingletonCreator("GFXStateBlockData",
                "AL_FormatTokenState : PFX_DefaultStateBlock");
            sc["samplersDefined"] = true;
            sc["samplerStates[0]"] = "SamplerClampPoint";
            sc.Create();

            sc = new SingletonCreator("PostEffect", "AL_FormatCopy");
            // This PostEffect is used by 'AL_FormatToken' directly. It is never added to
            // the PostEffectManager. Do not call enable() on it.
            sc["isEnabled"] = false;
            sc["allowReflectPass"] = true;

            sc["shader"] = "PFX_PassthruShader";
            sc["stateBlock"] = "AL_FormatTokenState";

            sc["texture[0]"] = "$inTex";
            sc["target"] = "$backbuffer";
            sc.Create();
            }

        public static void initRenderManager()
            {
            if ("DiffuseRenderPassManager".isObject())
                throw new Exception("initRenderManager() - DiffuseRenderPassManager already initialized!");

            #region 	new RenderPassManager( DiffuseRenderPassManager );

            RenderPassManager DiffuseRenderPassManager =
                new ObjectCreator("RenderPassManager", "DiffuseRenderPassManager").Create();

            #endregion

            // This token, and the associated render managers, ensure that driver MSAA 
            // does not get used for Advanced Lighting renders.  The 'AL_FormatResolve' 
            // PostEffect copies the result to the backbuffer.

            #region  new RenderFormatToken(AL_FormatToken)

            ObjectCreator oc = new ObjectCreator("RenderFormatToken", "AL_FormatToken");
            oc["enabled"] = "false";
            oc["format"] = "GFXFormatR8G8B8A8";
            oc["depthFormat"] = "GFXFormatD24S8";
            oc["aaLevel"] = 0; // -1 = match backbuffer
            // The contents of the back buffer before this format token is executed
            // is provided in $inTex
            oc["copyEffect"] = "AL_FormatCopy";
            // The contents of the render target created by this format token is
            // provided in $inTex
            oc["resolveEffect"] = "AL_FormatCopy";
            oc.Create();

            #endregion

            #region DiffuseRenderPassManager.addManager( new RenderPassStateBin() { renderOrder = 0.001; stateToken = AL_FormatToken; } );

            oc = new ObjectCreator("RenderPassStateBin");
            oc["renderOrder"] = 0.001f;
            oc["stateToken"] = "AL_FormatToken";

            DiffuseRenderPassManager.addManager(oc.Create().AsString());

            #endregion

            // We really need to fix the sky to render after all the 
            // meshes... but that causes issues in reflections.

            #region DiffuseRenderPassManager.addManager( new RenderObjectMgr() { bintype = "Sky"; renderOrder = 0.1; processAddOrder = 0.1; } );

            oc = new ObjectCreator("RenderObjectMgr");
            oc["bintype"] = "\"Sky\"";
            oc["renderOrder"] = 0.1f;
            oc["processAddOrder"] = 0.1f;
            DiffuseRenderPassManager.addManager(oc.Create().AsString());

            #endregion

            //DiffuseRenderPassManager.addManager( new RenderVistaMgr()               { bintype = "Vista"; renderOrder = 0.15; processAddOrder = 0.15; } );

            #region DiffuseRenderPassManager.addManager( new RenderObjectMgr()              { bintype = "Begin"; renderOrder = 0.2; processAddOrder = 0.2; } );

            oc = new ObjectCreator("RenderObjectMgr");
            oc["bintype"] = "\"Begin\"";
            oc["renderOrder"] = 0.2f;
            oc["processAddOrder"] = 0.2f;
            DiffuseRenderPassManager.addManager(oc.Create().AsString());

            #endregion

            // Normal mesh rendering.

            #region DiffuseRenderPassManager.addManager( new RenderTerrainMgr()             { renderOrder = 0.4; processAddOrder = 0.4; } );

            oc = new ObjectCreator("RenderTerrainMgr");
            oc["renderOrder"] = 0.4f;
            oc["processAddOrder"] = 0.4f;
            DiffuseRenderPassManager.addManager(oc.Create().AsString());

            #endregion

            #region DiffuseRenderPassManager.addManager( new RenderMeshMgr()                { bintype = "Mesh"; renderOrder = 0.5; processAddOrder = 0.5; } );

            oc = new ObjectCreator("RenderMeshMgr");
            oc["bintype"] = "\"Mesh\"";
            oc["renderOrder"] = 0.5f;
            oc["processAddOrder"] = 0.5f;
            DiffuseRenderPassManager.addManager(oc.Create().AsString());

            #endregion

            #region DiffuseRenderPassManager.addManager( new RenderImposterMgr()            { renderOrder = 0.56; processAddOrder = 0.56; } );

            oc = new ObjectCreator("RenderImposterMgr");
            oc["renderOrder"] = 0.56f;
            oc["processAddOrder"] = 0.56f;
            DiffuseRenderPassManager.addManager(oc.Create().AsString());

            #endregion

            #region DiffuseRenderPassManager.addManager( new RenderObjectMgr()              { bintype = "Object"; renderOrder = 0.6; processAddOrder = 0.6; } );

            oc = new ObjectCreator("RenderObjectMgr");
            oc["bintype"] = "\"Object\"";
            oc["renderOrder"] = 0.6f;
            oc["processAddOrder"] = 0.6f;
            DiffuseRenderPassManager.addManager(oc.Create().AsString());

            #endregion

            #region DiffuseRenderPassManager.addManager( new RenderObjectMgr()              { bintype = "Shadow"; renderOrder = 0.7; processAddOrder = 0.7; } );

            oc = new ObjectCreator("RenderObjectMgr");
            oc["bintype"] = "\"Shadow\"";
            oc["renderOrder"] = 0.7f;
            oc["processAddOrder"] = 0.7f;
            DiffuseRenderPassManager.addManager(oc.Create().AsString());

            #endregion

            #region DiffuseRenderPassManager.addManager( new RenderMeshMgr()                { bintype = "Decal"; renderOrder = 0.8; processAddOrder = 0.8; } );

            oc = new ObjectCreator("RenderMeshMgr");
            oc["bintype"] = "\"Decal\"";
            oc["renderOrder"] = 0.8f;
            oc["processAddOrder"] = 0.8f;
            DiffuseRenderPassManager.addManager(oc.Create().AsString());

            #endregion

            #region DiffuseRenderPassManager.addManager( new RenderOcclusionMgr()           { bintype = "Occluder"; renderOrder = 0.9; processAddOrder = 0.9; } );

            oc = new ObjectCreator("RenderOcclusionMgr");
            oc["bintype"] = "\"Occluder\"";
            oc["renderOrder"] = 0.9f;
            oc["processAddOrder"] = 0.9f;
            DiffuseRenderPassManager.addManager(oc.Create().AsString());

            #endregion

            // We now render translucent objects that should handle
            // their own fogging and lighting.

            // Note that the fog effect is triggered before this bin.

            #region DiffuseRenderPassManager.addManager( new RenderObjectMgr(ObjTranslucentBin) { bintype = "ObjectTranslucent"; renderOrder = 1.0; processAddOrder = 1.0; } );

            oc = new ObjectCreator("RenderObjectMgr", "ObjTranslucentBin");
            oc["bintype"] = "\"ObjectTranslucent\"";
            oc["renderOrder"] = 1.0f;
            oc["processAddOrder"] = 1.0f;
            DiffuseRenderPassManager.addManager(oc.Create().AsString());

            #endregion

            #region DiffuseRenderPassManager.addManager( new RenderObjectMgr()              { bintype = "Water"; renderOrder = 1.2; processAddOrder = 1.2; } );

            oc = new ObjectCreator("RenderObjectMgr");
            oc["bintype"] = "\"Water\"";
            oc["renderOrder"] = 1.2f;
            oc["processAddOrder"] = 1.2f;
            DiffuseRenderPassManager.addManager(oc.Create().AsString());

            #endregion

            #region DiffuseRenderPassManager.addManager( new RenderObjectMgr()              { bintype = "Foliage"; renderOrder = 1.3; processAddOrder = 1.3; } );

            oc = new ObjectCreator("RenderObjectMgr");
            oc["bintype"] = "\"Foliage\"";
            oc["renderOrder"] = 1.3f;
            oc["processAddOrder"] = 1.3f;
            DiffuseRenderPassManager.addManager(oc.Create().AsString());

            #endregion

            #region DiffuseRenderPassManager.addManager( new RenderParticleMgr()            { renderOrder = 1.35; processAddOrder = 1.35; } );

            oc = new ObjectCreator("RenderParticleMgr");
            oc["renderOrder"] = 1.35f;
            oc["processAddOrder"] = 1.35f;
            DiffuseRenderPassManager.addManager(oc.Create().AsString());

            #endregion

            #region DiffuseRenderPassManager.addManager( new RenderTranslucentMgr()         { renderOrder = 1.4; processAddOrder = 1.4; } );
            
            oc = new ObjectCreator("RenderObjectMgr");
            oc["bintype"] = "\"ObjectVolumetricFog\"";
            oc["renderOrder"] = 1.45f;
            oc["processAddOrder"] = 1.45f;
            DiffuseRenderPassManager.addManager(oc.Create().AsString());

            #endregion

            oc = new ObjectCreator("RenderTranslucentMgr");
            oc["renderOrder"] = 1.4f;
            oc["processAddOrder"] = 1.4f;
            DiffuseRenderPassManager.addManager(oc.Create().AsString());

            // Note that the GlowPostFx is triggered after this bin.

            #region DiffuseRenderPassManager.addManager( new RenderGlowMgr(GlowBin) { renderOrder = 1.5; processAddOrder = 1.5; } );

            oc = new ObjectCreator("RenderGlowMgr", "GlowBin");
            oc["renderOrder"] = 1.5f;
            oc["processAddOrder"] = 1.5f;
            DiffuseRenderPassManager.addManager(oc.Create().AsString());

            #endregion

            // We render any editor stuff from this bin.  Note that the HDR is
            // completed before this bin to keep editor elements from tone mapping.   

            #region DiffuseRenderPassManager.addManager( new RenderObjectMgr(EditorBin) { bintype = "Editor"; renderOrder = 1.6; processAddOrder = 1.6; } );

            oc = new ObjectCreator("RenderObjectMgr", "EditorBin");
            oc["bintype"] = "\"Editor\"";
            oc["renderOrder"] = 1.6f;
            oc["processAddOrder"] = 1.6f;
            DiffuseRenderPassManager.addManager(oc.Create().AsString());

            #endregion

            // Resolve format change token last.

            #region DiffuseRenderPassManager.addManager( new RenderPassStateBin() { renderOrder = 1.7; stateToken = AL_FormatToken; } );

            oc = new ObjectCreator("RenderPassStateBin");
            oc["renderOrder"] = 1.7f;
            oc["stateToken"] = "AL_FormatToken";
            DiffuseRenderPassManager.addManager(oc.Create().AsString());

            #endregion

            SingletonCreator sc = new SingletonCreator("GFXStateBlockData",
                "AL_FormatTokenState : PFX_DefaultStateBlock");
            sc["samplersDefined"] = true;
            sc["samplerStates[0]"] = "SamplerClampPoint";
            sc.Create();

            sc = new SingletonCreator("PostEffect", "AL_FormatCopy");
            // This PostEffect is used by 'AL_FormatToken' directly. It is never added to
            // the PostEffectManager. Do not call enable() on it.
            sc["isEnabled"] = false;
            sc["allowReflectPass"] = true;

            sc["shader"] = "PFX_PassthruShader";
            sc["stateBlock"] = "AL_FormatTokenState";

            sc[" texture[0]"] = "$inTex";
            sc["target"] = "$backbuffer";
            sc.Create();
            }
        }
    }