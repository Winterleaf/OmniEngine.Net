using System;

namespace WinterLeaf.Engine.Classes.Decorations
    {
    /// <summary>
    /// Used by the code generator to group Model properties by type defined in the T3D engine.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MemberGroup : Attribute
        {
        string _groupName = "";
        public MemberGroup(string groupname)
            {
            GroupName = groupname;
            }

        public string GroupName
            {
            get { return _groupName; }
            set { _groupName = value; }
            }
        }
    }
