using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.art.gui
    {
    [TypeConverter(typeof (TypeConverterGenericString<consoleVarDlg>))]
    public class consoleVarDlg : GuiControl
        {
        }
    }