namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    /// <summary>
    /// 
    /// </summary>
    public partial class LevelInfo
        {
        public override void onDefineFieldTypes()
            {
            this.setFieldType("Desc", "TypeString");
            this.setFieldType("DescLines", "TypeS32");
            }
        }
    }