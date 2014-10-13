// WinterLeaf Entertainment
// Copyright (c) 2014, WinterLeaf Entertainment LLC
// 
// All rights reserved.
// 
// The use of the WinterLeaf Entertainment LLC OMNI "Community Edition" is governed by this license agreement ("Agreement").
// 
// These license terms are an agreement between WinterLeaf Entertainment LLC and you.  Please read them. They apply to the source code and any other assets or works that are included with the product named above, which includes the media on which you received it, if any. These terms also apply to any updates, supplements, internet-based services, and support services for this software and its associated assets, unless other terms accompany those items. If so, those terms apply. You must read and agree to this Agreement terms BEFORE installing OMNI "Community Edition" to your hard drive or using OMNI in any way. If you do not agree to the license terms, do not download, install or use OMNI. Please make copies of this Agreement for all those in your organization who need to be familiar with the license terms.
// 
// This license allows companies of any size, government entities or individuals to create, sell, rent, lease, or otherwise profit commercially from, games using executables created from the source code that accompanies OMNI "Community Edition".
// 
// BY CLICKING THE ACCEPTANCE BUTTON AND/OR INSTALLING OR USING OMNI "Community Edition", THE INDIVIDUAL ACCESSING OMNI ("LICENSEE") IS CONSENTING TO BE BOUND BY AND BECOME A PARTY TO THIS AGREEMENT. IF YOU DO NOT ACCEPT THESE TERMS, DO NOT INSTALL OR USE OMNI. IF YOU COMPLY WITH THESE LICENSE TERMS, YOU HAVE THE RIGHTS BELOW:
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     Redistributions of source code must retain the all copyright notice, this list of conditions and the following disclaimer.
//     Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     With respect to any Product that the Licensee develop using the Software:
//     Licensee shall:
//         display the OMNI Logo, in the start-up sequence of the Product (unless waived by WinterLeaf Entertainment);
//         display in the "About" box or in the credits screen of the Product the text "OMNI by WinterLeaf Entertainment";
//         display the OMNI Logo, on all external Product packaging materials and the back cover of any printed instruction manual or the end of any electronic instruction manual;
//         notify WinterLeaf Entertainment in writing that You are publicly releasing a Product that was developed using the Software within the first 30 days following the release; and
//         the Licensee hereby grant WinterLeaf Entertainment permission to refer to the Licensee or the name of any Product the Licensee develops using the Software for marketing purposes. All goodwill in each party's trademarks and logos will inure to the sole benefit of that party.
//     Neither the name of WinterLeaf Entertainment LLC or OMNI nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//     The following restrictions apply to the use of OMNI "Community Edition":
//     Licensee may not:
//         create any derivative works of OMNI Engine, including but not limited to translations, localizations, or game making software other than Games;
//         redistribute, encumber, sell, rent, lease, sublicense, or otherwise transfer rights to OMNI "Community Edition"; or
//         remove or alter any trademark, logo, copyright or other proprietary notices, legends, symbols or labels in OMNI Engine; or
//         use the Software to develop or distribute any software that competes with the Software without WinterLeaf Entertainment’s prior written consent; or
//         use the Software for any illegal purpose.
// 
// THIS SOFTWARE IS PROVIDED BY WINTERLEAF ENTERTAINMENT LLC ''AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL WINTERLEAF ENTERTAINMENT LLC BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.EditorClasses.RSSNews
{
    public class RSSStructs
    {
        [ConsoleInteraction]
        public static string constructRSSHeadline(string headline, string link)
        {
            ObjectCreator oc = new ObjectCreator("ScriptObject", "", typeof (RSSHeadline));
            oc["_headline"] = headline;
            oc["_link"] = link;

            RSSHeadline ret = oc.Create();

            return ret;
        }

        //------------------------------------------------------------------------------

        [ConsoleInteraction]
        public static string constructRSSHeadlineCollection()
        {
            RSSHeadlineCollection ret = new ObjectCreator("ScriptObject", "", typeof (RSSHeadlineCollection)).Create();

            // Create sim group for it
            ret._simGroup = new ObjectCreator("SimGroup").Create().AsString();

            return ret;
        }

        [TypeConverter(typeof (TypeConverterGeneric<RSSHeadline>))]
        public class RSSHeadline : ScriptObject
        {
            [ConsoleInteraction]
            public string getHeadline()
            {
                return this["_headline"];
            }

            [ConsoleInteraction]
            public string getLink()
            {
                return this["_link"];
            }

            [ConsoleInteraction]
            public bool sameAs(RSSHeadline headline)
            {
                return (Util.strcmp(this.toString(), headline.toString()) == 0);
            }

            [ConsoleInteraction]
            public string toString()
            {
                return this.getHeadline() + " ( " + this.getLink() + " ) ";
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(RSSHeadline ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(RSSHeadline ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(RSSHeadline ts)
            {
                if (ReferenceEquals(ts, null))
                    return "0";
                return ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator RSSHeadline(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (RSSHeadline) Omni.self.getSimObject(simobjectid, typeof (RSSHeadline));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(RSSHeadline ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator RSSHeadline(int simobjectid)
            {
                return (RSSHeadline) Omni.self.getSimObject((uint) simobjectid, typeof (RSSHeadline));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(RSSHeadline ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator RSSHeadline(uint simobjectid)
            {
                return (RSSHeadline) Omni.self.getSimObject(simobjectid, typeof (RSSHeadline));
            }

            #endregion
        }

        public class RSSHeadlineCollection : ScriptObject
        {
            public SimGroup _simGroup
            {
                get { return this["_simGroup"]; }
                set { this["_simGroup"] = value; }
            }

            [ConsoleInteraction]
            public string getObject(uint index)
            {
                string ret = this._simGroup.getObject(index);

                if (!ret.isObject())
                    {
                    Util._warn("No such index in headline collection.");
                    return "0";
                    }

                return ret;
            }

            [ConsoleInteraction]
            public int getCount()
            {
                return this._simGroup.getCount();
            }

            [ConsoleInteraction]
            public bool addHeadline(RSSHeadline headline, bool skipReorder)
            {
                for (uint i = 0; i < this.getCount(); i++)
                    {
                    RSSHeadline obj = this.getObject(i);

                    if (obj.sameAs(headline))
                        {
                        //echo( "cache hit headline: " @ %headline.toString() );
                        return false;
                        }
                    }

                this._simGroup.add(headline);

                if (!skipReorder)
                    this._simGroup.bringToFront(headline);

                //echo( "adding headline: " @ %headline.toString() );

                return true;
            }

            [ConsoleInteraction]
            public void writeToFile(string file)
            {
                iGlobal["$rssHeadlineCollection::count"] = this.getCount();

                for (uint i = 0; i < this.getCount(); i++)
                    {
                    RSSHeadline hdl = this.getObject(i);
                    sGlobal["$rssHeadlineCollection::headline[" + i + "]"] = hdl.getHeadline();
                    sGlobal["$rssHeadlineCollection::link[" + i + "]"] = hdl.getLink();
                    }

                Util.export("$rssHeadlineCollection::*", file, false);
            }

            [ConsoleInteraction]
            public void loadFromFile(string file)
            {
                this._simGroup.clear();

                iGlobal["$rssHeadlineCollection::count"] = 0;

                file = Util.getPrefsPath(file);
                if (Util.isFile(file) || Util.isFile(file + ".dso"))
                    Util.exec(file, false, false);

                for (int i = 0; i < iGlobal["$rssHeadlineCollection::count"]; i++)
                    {
                    //echo( "[LD: " @ %i @ "] Headline: " @ $rssHeadlineCollection::headline[%i] );
                    //echo( "[LD: " @ %i @ "] Link: " @ $rssHeadlineCollection::link[%i] );

                    RSSHeadline hdl = constructRSSHeadline(sGlobal["$rssHeadlineCollection::headline[" + i + "]"], sGlobal["$rssHeadlineCollection::link[" + i + "]"]);

                    // This does negate the cache check, but that is ok -pw                             
                    this.addHeadline(hdl, true);
                    }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(RSSHeadlineCollection ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(RSSHeadlineCollection ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(RSSHeadlineCollection ts)
            {
                if (ReferenceEquals(ts, null))
                    return "0";
                return ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator RSSHeadlineCollection(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (RSSHeadlineCollection) Omni.self.getSimObject(simobjectid, typeof (RSSHeadlineCollection));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(RSSHeadlineCollection ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator RSSHeadlineCollection(int simobjectid)
            {
                return (RSSHeadlineCollection) Omni.self.getSimObject((uint) simobjectid, typeof (RSSHeadlineCollection));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(RSSHeadlineCollection ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator RSSHeadlineCollection(uint simobjectid)
            {
                return (RSSHeadlineCollection) Omni.self.getSimObject(simobjectid, typeof (RSSHeadlineCollection));
            }

            #endregion
        }
    }
}