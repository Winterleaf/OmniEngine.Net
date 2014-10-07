using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

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
                this.send("GET " + sGlobal["$RSSFeed::serverURL"] + " HTTP/1.0\nHost: " +
                          sGlobal["$RSSFeed::serverName"] + "\nUser-Agent: " + sGlobal["$RSSFeed::userAgent"] +
                          "\n\r\n\r\n");
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
                    headline[i] = this.getTagContents(sGlobal["$RSSFeed::requestResults"], "title",
                        this["lastOffset"].AsInt());
                    headlineLink[i] = this.getTagContents(sGlobal["$RSSFeed::requestResults"], "link",
                        this["lastOffset"].AsInt());

                    // Skip the content - it's not going to do anything but confuse us.
                    string garbage = this.getTagContents(sGlobal["$RSSFeed::requestResults"], "content:encoded",
                        this["lastOffset"].AsInt());
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
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
                    : ts.Equals(simobjectid);
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
                if (object.ReferenceEquals(ts, null))
                    return !object.ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
                }


            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(RSSFeedObject ts)
                {
                if (object.ReferenceEquals(ts, null))
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
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
                    : ts.Equals(simobjectid);
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
                if (object.ReferenceEquals(ts, null))
                    return !object.ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
                }


            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(RSSUpdate ts)
                {
                if (object.ReferenceEquals(ts, null))
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