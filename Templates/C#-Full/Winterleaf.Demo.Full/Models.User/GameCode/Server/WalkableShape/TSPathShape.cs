#region

using WinterLeaf.Demo.Full.Models.Base;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Enums;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    /// <summary>
    /// 
    /// </summary>
    public partial class TSPathShape : TSPathShape_Base
        {
        public override void onAdd()
            {
            if (Path.isObject())
                {
                this.pushPath(Path);
                setPathPosition();
                }
            }

        public override void onPathChange()
            {
            // Save the current position and move state before resetting the path
            float pos = getPathPosition();
            TypePathShapeState moveState = movementState;

            this.reset(0, false); // Stop and reset the shapes path, don't create first node

            if (!this.Path.isObject())
                return;

            this.pushPath(this.Path);
            this.setPathPosition(pos);
            this.setMoveState(moveState);
            }

        public override void onNode(int node)
            {
            //console.print("TSPathShape::onNode(" + this + ", " + node + ")");
            base.onNode(node);
            }

        public void pushPath(Path path)
            {
            //install the new path
            if (path["speed"] == "")
                path["speed"] = "2";

            for (uint i = 0; i < path.getCount(); i++)
                this.pushNode(path.getObject(i));

            // If looping, push the starting node onto the end to make this a loop
            if (this.Path.isLooping)
                this.pushNode(path.getObject(0));

            this.setLooping(this.Path.isLooping);
            }

        public void pushNode(Marker node)
            {
            string speed = node["speed"] != "" ? node["speed"] : this.Path["speed"];

            string type = node["type"] == "" ? "Normal" : node["type"];

            string smoothing = node["smoothing"] == "" ? "Linear" : node["smoothing"];

            this.pushBack(node.getTransform(), speed.AsFloat(), type, smoothing);
            this["nodeCount"] = this.getNodeCount().AsString();
            }


        }
    }