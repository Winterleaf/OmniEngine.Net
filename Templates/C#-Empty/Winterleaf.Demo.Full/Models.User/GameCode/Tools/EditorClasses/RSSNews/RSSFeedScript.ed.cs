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
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.EditorClasses.RSSNews
{
    public class RSSFeedScript
    {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction(true, "RSSFeedScript_initialize")]
        public static void initialize()
        {
            // RSS ticker configuration:
            omni.sGlobal["$RSSFeed::serverName"] = "feeds.garagegames.com";
            omni.iGlobal["$RSSFeed::serverPort"] = 80;
            omni.sGlobal["$RSSFeed::serverURL"] = "/product/tgea";
            omni.sGlobal["$RSSFeed::userAgent"] = "TorqueGameEngineAdvances/1.1";
            omni.iGlobal["$RSSFeed::maxNewHeadlines"] = 10;

            // Load up the helper objects
            //exec( "./RSSStructs.ed.cs" );
        }

        [TypeConverter(typeof (TypeConverterGeneric<RSSFeedObject>))]
        public class RSSFeedObject : TCPObject
        {
            [ConsoleInteraction]
            public override void onConnected()
            {
                //echo("RSS Feed");
                //echo("   - Requesting RSS data at URL: " @ $RSSFeed::serverURL );

                // Reset some useful state information.
                iGlobal["$RSSFeed::lineCount"] = 0;
                sGlobal["$RSSFeed::requestResults"] = "";

                // Load the cache here...
                iGlobal["$RSSFeed::rssCache"] = 0;

                // Request our RSS.
                this.send("GET " + sGlobal["$RSSFeed::serverURL"] + " HTTP/1.0\nHost: " + sGlobal["$RSSFeed::serverName"] + "\nUser-Agent: " + sGlobal["$RSSFeed::userAgent"] + "\n\r\n\r\n");
            }

            [ConsoleInteraction]
            public override void onLine(string line)
            {
                // Collate info.
                iGlobal["$RSSFeed::lineCount"]++;
                sGlobal["$RSSFeed::requestResults"] = sGlobal["$RSSFeed::requestResults"] + line;
            }

            [ConsoleInteraction]
            public string getTagContents(string stringx, string tag, int startChar)
            {
                // This function occasionally makes Torque hard crash. It doesn't
                // seem to do it anymore but be careful!

                // Ok, get thing between <%tag> and </%tag> after char #
                // %startChar in the passed string.

                string startTag = "<" + tag + ">";
                string endTag = "</" + tag + ">";

                int startTagOffset = Util.strpos(stringx, startTag, startChar);

                // Compensate for presence of start tag.
                int startOffset = startTagOffset + Util.strlen(startTag);

                // Ok, now look for end tag.
                int endTagOffset = Util.strpos(stringx, endTag, startOffset - 1);

                // If we didn't find it, bail. 
                if (endTagOffset < 0)
                    return "";

                // Evil hack - store last found item in a global.
                this["lastOffset"] = endTagOffset.AsString();

                // And get & return the substring between the tags.
                string result = Util.getSubStr(stringx, startOffset, (endTagOffset - startOffset));

                // Do a little mojo to deal with &quot; and some other htmlentities.
                result = Util.strreplace(result, "&quot;", "\"");
                result = Util.strreplace(result, "&amp;", "&");

                return result;
            }

            [ConsoleInteraction]
            public override void onDisconnect()
            {
                // Create collection and load cache.
                RSSStructs.RSSHeadlineCollection ret = RSSStructs.constructRSSHeadlineCollection();
                ret.loadFromFile("RSSCache.cs");

                // Ok, we have a full buffer now, hopefully. Let's process it.
                //echo("   - Got " @ $RSSFeed::lineCount @ " lines.");

                // We want the feed title and the first three headlines + links.

                // Feed title - get the first <title> occurence in the string.
                string title = this.getTagContents(sGlobal["$RSSFeed::requestResults"], "title", 0);
                string titleLink = this.getTagContents(sGlobal["$RSSFeed::requestResults"], "link", 0);

                //echo("   - Feed title: '" @ %title @ "'");
                //echo("   - Feed link:  '" @ %titleLink @ "'");

                bool newItems = false;
                string[] headline = {};
                string[] headlineLink = {};

                // Ok, get the first headlines, if any...
                for (int i = 0; i < iGlobal["RSSFeed::maxNewHeadlines"]; i++)
                    {
                    headline[i] = this.getTagContents(sGlobal["$RSSFeed::requestResults"], "title", this["lastOffset"].AsInt());
                    headlineLink[i] = this.getTagContents(sGlobal["$RSSFeed::requestResults"], "link", this["lastOffset"].AsInt());

                    // Skip the content - it's not going to do anything but confuse us.
                    string garbage = this.getTagContents(sGlobal["$RSSFeed::requestResults"], "content:encoded", this["lastOffset"].AsInt());
                    bool isNew = ret.addHeadline(RSSStructs.constructRSSHeadline(headline[i], headlineLink[i]), false);

                    if (isNew)
                        {
                        newItems = true;
                        //echo("   - Headline      #" @ %i @ " : '" @ %headline[%i] @ "'");
                        //echo("   - Headline Link #" @ %i @ " : '" @ %headlineLink[%i] @ "'");
                        }
                    }

                if (this["_callback"] != "")
                    {
                    string paramsx = ret;

                    if (newItems)
                        paramsx = paramsx + ", \"" + newItems + "\"";

                    Util.eval(this["_callback"] + "(" + paramsx + ");");
                    }

                ret.writeToFile("RSSCache.cs");
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(RSSFeedObject ts, string simobjectid)
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
            public static bool operator !=(RSSFeedObject ts, string simobjectid)
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
            public static implicit operator string(RSSFeedObject ts)
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
            public static implicit operator RSSFeedObject(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (RSSFeedObject) Omni.self.getSimObject(simobjectid, typeof (RSSFeedObject));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(RSSFeedObject ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator RSSFeedObject(int simobjectid)
            {
                return (RSSFeedObject) Omni.self.getSimObject((uint) simobjectid, typeof (RSSFeedObject));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(RSSFeedObject ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator RSSFeedObject(uint simobjectid)
            {
                return (RSSFeedObject) Omni.self.getSimObject(simobjectid, typeof (RSSFeedObject));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<RSSUpdate>))]
        public class RSSUpdate : SimObject
        {
            [ConsoleInteraction]
            public void initialize(string callback)
            {
                RSSFeedObject RSSFeedObject = "RSSFeedObject";

                RSSFeedObject = new ObjectCreator("TCPObject", "RSSFeedObject", typeof (RSSFeedObject)).Create();
                RSSFeedObject["_callback"] = callback;

                RSSFeedObject.connect(sGlobal["$RSSFeed::serverName"] + ":" + sGlobal["$RSSFeed::serverPort"]);
            }

            [ConsoleInteraction]
            public void destroy()
            {
                RSSFeedObject RSSFeedObject = "RSSFeedObject";

                if (RSSFeedObject.isObject())
                    RSSFeedObject.delete();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(RSSUpdate ts, string simobjectid)
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
            public static bool operator !=(RSSUpdate ts, string simobjectid)
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
            public static implicit operator string(RSSUpdate ts)
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
            public static implicit operator RSSUpdate(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (RSSUpdate) Omni.self.getSimObject(simobjectid, typeof (RSSUpdate));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(RSSUpdate ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator RSSUpdate(int simobjectid)
            {
                return (RSSUpdate) Omni.self.getSimObject((uint) simobjectid, typeof (RSSUpdate));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(RSSUpdate ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator RSSUpdate(uint simobjectid)
            {
                return (RSSUpdate) Omni.self.getSimObject(simobjectid, typeof (RSSUpdate));
            }

            #endregion
        }
    }
}