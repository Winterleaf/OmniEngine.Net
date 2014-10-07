

#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;
using System.ComponentModel;
using System.Threading;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Demo.Full.Models.Base;
#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    /// <summary>
    /// 
    /// </summary>
    public partial class VolumetricFog : VolumetricFog_Base
        {
        public override void onEnterFog(string obj)
            {
            console.print("Control Object " + obj + " entered fog " + this);
            }

        public override void onLeaveFog(string obj)
            {
            console.print("Control Object " + obj + " left fog " + this);
            }
        /// <summary>
        /// This method dissolves the fog at speed milliseconds
        /// </summary>
        /// <param name="speed">milliseconds</param>
        [ConsoleInteraction]
        public void Dissolve(float speed)
            {
            if (!(this.FogDensity > 0))
                return;
            this.SetFogDensity(this.FogDensity - 0.01f);
            this.schedule(speed.AsString(), "Dissolve", speed.AsString());
            }

        /// <summary>
        /// This method thickens the fog at speed milliseconds to a density of end_density
        /// </summary>
        /// <param name="speed">milliseconds</param>
        /// <param name="end_density">final density</param>
        [ConsoleInteraction]
        public void Thicken(float speed, float end_density)
            {
            if (this.FogDensity + .01 < end_density)
                {
                this.SetFogDensity(this.FogDensity + .01f);
                this.schedule(speed.AsString(), "Thicken", speed.AsString(), end_density.AsString());
                }
            else
                {
                this.SetFogDensity(end_density);
                }
            }

        }
    }
