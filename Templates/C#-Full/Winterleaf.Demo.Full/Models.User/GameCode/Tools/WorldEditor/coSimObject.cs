namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class SimObject
        {
        public override void onDefineFieldTypes()
            {
            setFieldType("Locked", "TypeBool");
            }
        }
    }