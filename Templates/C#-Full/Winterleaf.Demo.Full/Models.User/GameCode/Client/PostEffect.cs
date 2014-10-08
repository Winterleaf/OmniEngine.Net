#region

using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    /// <summary>
    /// 
    /// </summary>
    public partial class PostEffect
        {
        private static string _mColorCorrectionFileName;

        public static string mColorCorrectionFileName
            {
            get { return _mColorCorrectionFileName ?? ""; }
            set { _mColorCorrectionFileName = value; }
            }

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        [ConsoleInteraction(true)]
        public virtual void inspectVars()
            {
            string globals = "$" + this.name + "::*";
            //Calls ConsoleVarDlg.gui function
            console.Call("inspectVars", new[] {globals});
            }

        [ConsoleInteraction(true)]
        public virtual void PostEffectviewDisassembly()
            {
            string file = dumpShaderDisassembly();
            if (file != "")
                {
                console.print("PostEffect::viewDisassembly - no shader disassembly found.");
                }
            else
                {
                console.print("PostEffect::viewDisassembly - shader disassembly file dumped ( " + file + " ).");
                Util.openFile(file);
                }
            }

        public override bool onEnabled()
            {
            return true;
            }
        }
    }