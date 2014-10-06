var swfobject=function(){var b="undefined",Q="object",n="Shockwave Flash",p="ShockwaveFlash.ShockwaveFlash",P="application/x-shockwave-flash",m="SWFObjectExprInst",j=window,K=document,T=navigator,o=[],N=[],i=[],d=[],J,Z=null,M=null,l=null,e=false,A=false;var h=function(){var v=typeof K.getElementById!=b&&typeof K.getElementsByTagName!=b&&typeof K.createElement!=b,AC=[0,0,0],x=null;if(typeof T.plugins!=b&&typeof T.plugins[n]==Q){x=T.plugins[n].description;if(x&&!(typeof T.mimeTypes!=b&&T.mimeTypes[P]&&!T.mimeTypes[P].enabledPlugin)){x=x.replace(/^.*\s+(\S+\s+\S+$)/,"$1");AC[0]=parseInt(x.replace(/^(.*)\..*$/,"$1"),10);AC[1]=parseInt(x.replace(/^.*\.(.*)\s.*$/,"$1"),10);AC[2]=/r/.test(x)?parseInt(x.replace(/^.*r(.*)$/,"$1"),10):0}}else{if(typeof j.ActiveXObject!=b){var y=null,AB=false;try{y=new ActiveXObject(p+".7")}catch(t){try{y=new ActiveXObject(p+".6");AC=[6,0,21];y.AllowScriptAccess="always"}catch(t){if(AC[0]==6){AB=true}}if(!AB){try{y=new ActiveXObject(p)}catch(t){}}}if(!AB&&y){try{x=y.GetVariable("$version");if(x){x=x.split(" ")[1].split(",");AC=[parseInt(x[0],10),parseInt(x[1],10),parseInt(x[2],10)]}}catch(t){}}}}var AD=T.userAgent.toLowerCase(),r=T.platform.toLowerCase(),AA=/webkit/.test(AD)?parseFloat(AD.replace(/^.*webkit\/(\d+(\.\d+)?).*$/,"$1")):false,q=false,z=r?/win/.test(r):/win/.test(AD),w=r?/mac/.test(r):/mac/.test(AD);
/*@cc_on q=true;@if(@_win32)z=true;@elif(@_mac)w=true;@end@*/
		return {
			w3cdom : v,
			pv : AC,
			webkit : AA,
			ie : q,
			win : z,
			mac : w
		}
	}();
	var L = function() {
		if (!h.w3cdom) {
			return
		}
		f(H);
		if (h.ie && h.win) {
			try {
				K
						.write("<script id=__ie_ondomload defer=true src=//:><\/script>");
				J = C("__ie_ondomload");
				if (J) {
					I(J, "onreadystatechange", S)
				}
			} catch (q) {
			}
		}
		if (h.webkit && typeof K.readyState != b) {
			Z = setInterval(function() {
				if (/loaded|complete/.test(K.readyState)) {
					E()
				}
			}, 10)
		}
		if (typeof K.addEventListener != b) {
			K.addEventListener("DOMContentLoaded", E, null)
		}
		R(E)
	}();
	function S() {
		if (J.readyState == "complete") {
			J.parentNode.removeChild(J);
			E()
		}
	}
	function E() {
		if (e) {
			return
		}
		if (h.ie && h.win) {
			var v = a("span");
			try {
				var u = K.getElementsByTagName("body")[0].appendChild(v);
				u.parentNode.removeChild(u)
			} catch (w) {
				return
			}
		}
		e = true;
		if (Z) {
			clearInterval(Z);
			Z = null
		}
		var q = o.length;
		for ( var r = 0; r < q; r++) {
			o[r]()
		}
	}
	function f(q) {
		if (e) {
			q()
		} else {
			o[o.length] = q
		}
	}
	function R(r) {
		if (typeof j.addEventListener != b) {
			j.addEventListener("load", r, false)
		} else {
			if (typeof K.addEventListener != b) {
				K.addEventListener("load", r, false)
			} else {
				if (typeof j.attachEvent != b) {
					I(j, "onload", r)
				} else {
					if (typeof j.onload == "function") {
						var q = j.onload;
						j.onload = function() {
							q();
							r()
						}
					} else {
						j.onload = r
					}
				}
			}
		}
	}
	function H() {
		var t = N.length;
		for ( var q = 0; q < t; q++) {
			var u = N[q].id;
			if (h.pv[0] > 0) {
				var r = C(u);
				if (r) {
					N[q].width = r.getAttribute("width") ? r
							.getAttribute("width") : "0";
					N[q].height = r.getAttribute("height") ? r
							.getAttribute("height") : "0";
					if (c(N[q].swfVersion)) {
						if (h.webkit && h.webkit < 312) {
							Y(r)
						}
						W(u, true)
					} else {
						if (N[q].expressInstall && !A && c("6.0.65")
								&& (h.win || h.mac)) {
							k(N[q])
						} else {
							O(r)
						}
					}
				}
			} else {
				W(u, true)
			}
		}
	}
	function Y(t) {
		var q = t.getElementsByTagName(Q)[0];
		if (q) {
			var w = a("embed"), y = q.attributes;
			if (y) {
				var v = y.length;
				for ( var u = 0; u < v; u++) {
					if (y[u].nodeName == "DATA") {
						w.setAttribute("src", y[u].nodeValue)
					} else {
						w.setAttribute(y[u].nodeName, y[u].nodeValue)
					}
				}
			}
			var x = q.childNodes;
			if (x) {
				var z = x.length;
				for ( var r = 0; r < z; r++) {
					if (x[r].nodeType == 1 && x[r].nodeName == "PARAM") {
						w.setAttribute(x[r].getAttribute("name"), x[r]
								.getAttribute("value"))
					}
				}
			}
			t.parentNode.replaceChild(w, t)
		}
	}
	function k(w) {
		A = true;
		var u = C(w.id);
		if (u) {
			if (w.altContentId) {
				var y = C(w.altContentId);
				if (y) {
					M = y;
					l = w.altContentId
				}
			} else {
				M = G(u)
			}
			if (!(/%$/.test(w.width)) && parseInt(w.width, 10) < 310) {
				w.width = "310"
			}
			if (!(/%$/.test(w.height)) && parseInt(w.height, 10) < 137) {
				w.height = "137"
			}
			K.title = K.title.slice(0, 47) + " - Flash Player Installation";
			var z = h.ie && h.win ? "ActiveX" : "PlugIn", q = K.title, r = "MMredirectURL="
					+ j.location + "&MMplayerType=" + z + "&MMdoctitle=" + q, x = w.id;
			if (h.ie && h.win && u.readyState != 4) {
				var t = a("div");
				x += "SWFObjectNew";
				t.setAttribute("id", x);
				u.parentNode.insertBefore(t, u);
				u.style.display = "none";
				var v = function() {
					u.parentNode.removeChild(u)
				};
				I(j, "onload", v)
			}
			U({
				data : w.expressInstall,
				id : m,
				width : w.width,
				height : w.height
			}, {
				flashvars : r
			}, x)
		}
	}
	function O(t) {
		if (h.ie && h.win && t.readyState != 4) {
			var r = a("div");
			t.parentNode.insertBefore(r, t);
			r.parentNode.replaceChild(G(t), r);
			t.style.display = "none";
			var q = function() {
				t.parentNode.removeChild(t)
			};
			I(j, "onload", q)
		} else {
			t.parentNode.replaceChild(G(t), t)
		}
	}
	function G(v) {
		var u = a("div");
		if (h.win && h.ie) {
			u.innerHTML = v.innerHTML
		} else {
			var r = v.getElementsByTagName(Q)[0];
			if (r) {
				var w = r.childNodes;
				if (w) {
					var q = w.length;
					for ( var t = 0; t < q; t++) {
						if (!(w[t].nodeType == 1 && w[t].nodeName == "PARAM")
								&& !(w[t].nodeType == 8)) {
							u.appendChild(w[t].cloneNode(true))
						}
					}
				}
			}
		}
		return u
	}
	function U(AG, AE, t) {
		var q, v = C(t);
		if (v) {
			if (typeof AG.id == b) {
				AG.id = t
			}
			if (h.ie && h.win) {
				var AF = "";
				for ( var AB in AG) {
					if (AG[AB] != Object.prototype[AB]) {
						if (AB.toLowerCase() == "data") {
							AE.movie = AG[AB]
						} else {
							if (AB.toLowerCase() == "styleclass") {
								AF += ' class="' + AG[AB] + '"'
							} else {
								if (AB.toLowerCase() != "classid") {
									AF += " " + AB + '="' + AG[AB] + '"'
								}
							}
						}
					}
				}
				var AD = "";
				for ( var AA in AE) {
					if (AE[AA] != Object.prototype[AA]) {
						AD += '<param name="' + AA + '" value="' + AE[AA]
								+ '" />'
					}
				}
				v.outerHTML = '<object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000"'
						+ AF + ">" + AD + "</object>";
				i[i.length] = AG.id;
				q = C(AG.id)
			} else {
				if (h.webkit && h.webkit < 312) {
					var AC = a("embed");
					AC.setAttribute("type", P);
					for ( var z in AG) {
						if (AG[z] != Object.prototype[z]) {
							if (z.toLowerCase() == "data") {
								AC.setAttribute("src", AG[z])
							} else {
								if (z.toLowerCase() == "styleclass") {
									AC.setAttribute("class", AG[z])
								} else {
									if (z.toLowerCase() != "classid") {
										AC.setAttribute(z, AG[z])
									}
								}
							}
						}
					}
					for ( var y in AE) {
						if (AE[y] != Object.prototype[y]) {
							if (y.toLowerCase() != "movie") {
								AC.setAttribute(y, AE[y])
							}
						}
					}
					v.parentNode.replaceChild(AC, v);
					q = AC
				} else {
					var u = a(Q);
					u.setAttribute("type", P);
					for ( var x in AG) {
						if (AG[x] != Object.prototype[x]) {
							if (x.toLowerCase() == "styleclass") {
								u.setAttribute("class", AG[x])
							} else {
								if (x.toLowerCase() != "classid") {
									u.setAttribute(x, AG[x])
								}
							}
						}
					}
					for ( var w in AE) {
						if (AE[w] != Object.prototype[w]
								&& w.toLowerCase() != "movie") {
							F(u, w, AE[w])
						}
					}
					v.parentNode.replaceChild(u, v);
					q = u
				}
			}
		}
		return q
	}
	function F(t, q, r) {
		var u = a("param");
		u.setAttribute("name", q);
		u.setAttribute("value", r);
		t.appendChild(u)
	}
	function X(r) {
		var q = C(r);
		if (q && (q.nodeName == "OBJECT" || q.nodeName == "EMBED")) {
			if (h.ie && h.win) {
				if (q.readyState == 4) {
					B(r)
				} else {
					j.attachEvent("onload", function() {
						B(r)
					})
				}
			} else {
				q.parentNode.removeChild(q)
			}
		}
	}
	function B(t) {
		var r = C(t);
		if (r) {
			for ( var q in r) {
				if (typeof r[q] == "function") {
					r[q] = null
				}
			}
			r.parentNode.removeChild(r)
		}
	}
	function C(t) {
		var q = null;
		try {
			q = K.getElementById(t)
		} catch (r) {
		}
		return q
	}
	function a(q) {
		return K.createElement(q)
	}
	function I(t, q, r) {
		t.attachEvent(q, r);
		d[d.length] = [ t, q, r ]
	}
	function c(t) {
		var r = h.pv, q = t.split(".");
		q[0] = parseInt(q[0], 10);
		q[1] = parseInt(q[1], 10) || 0;
		q[2] = parseInt(q[2], 10) || 0;
		return (r[0] > q[0] || (r[0] == q[0] && r[1] > q[1]) || (r[0] == q[0]
				&& r[1] == q[1] && r[2] >= q[2])) ? true : false
	}
	function V(v, r) {
		if (h.ie && h.mac) {
			return
		}
		var u = K.getElementsByTagName("head")[0], t = a("style");
		t.setAttribute("type", "text/css");
		t.setAttribute("media", "screen");
		if (!(h.ie && h.win) && typeof K.createTextNode != b) {
			t.appendChild(K.createTextNode(v + " {" + r + "}"))
		}
		u.appendChild(t);
		if (h.ie && h.win && typeof K.styleSheets != b
				&& K.styleSheets.length > 0) {
			var q = K.styleSheets[K.styleSheets.length - 1];
			if (typeof q.addRule == Q) {
				q.addRule(v, r)
			}
		}
	}
	function W(t, q) {
		var r = q ? "visible" : "hidden";
		if (e && C(t)) {
			C(t).style.visibility = r
		} else {
			V("#" + t, "visibility:" + r)
		}
	}
	function g(s) {
		var r = /[\\\"<>\.;]/;
		var q = r.exec(s) != null;
		return q ? encodeURIComponent(s) : s
	}
	var D = function() {
		if (h.ie && h.win) {
			window.attachEvent("onunload", function() {
				var w = d.length;
				for ( var v = 0; v < w; v++) {
					d[v][0].detachEvent(d[v][1], d[v][2])
				}
				var t = i.length;
				for ( var u = 0; u < t; u++) {
					X(i[u])
				}
				for ( var r in h) {
					h[r] = null
				}
				h = null;
				for ( var q in swfobject) {
					swfobject[q] = null
				}
				swfobject = null
			})
		}
	}();
	return {
		registerObject : function(u, q, t) {
			if (!h.w3cdom || !u || !q) {
				return
			}
			var r = {};
			r.id = u;
			r.swfVersion = q;
			r.expressInstall = t ? t : false;
			N[N.length] = r;
			W(u, false)
		},
		getObjectById : function(v) {
			var q = null;
			if (h.w3cdom) {
				var t = C(v);
				if (t) {
					var u = t.getElementsByTagName(Q)[0];
					if (!u || (u && typeof t.SetVariable != b)) {
						q = t
					} else {
						if (typeof u.SetVariable != b) {
							q = u
						}
					}
				}
			}
			return q
		},
		embedSWF : function(x, AE, AB, AD, q, w, r, z, AC) {
			if (!h.w3cdom || !x || !AE || !AB || !AD || !q) {
				return
			}
			AB += "";
			AD += "";
			if (c(q)) {
				W(AE, false);
				var AA = {};
				if (AC && typeof AC === Q) {
					for ( var v in AC) {
						if (AC[v] != Object.prototype[v]) {
							AA[v] = AC[v]
						}
					}
				}
				AA.data = x;
				AA.width = AB;
				AA.height = AD;
				var y = {};
				if (z && typeof z === Q) {
					for ( var u in z) {
						if (z[u] != Object.prototype[u]) {
							y[u] = z[u]
						}
					}
				}
				if (r && typeof r === Q) {
					for ( var t in r) {
						if (r[t] != Object.prototype[t]) {
							if (typeof y.flashvars != b) {
								y.flashvars += "&" + t + "=" + r[t]
							} else {
								y.flashvars = t + "=" + r[t]
							}
						}
					}
				}
				f(function() {
					U(AA, y, AE);
					if (AA.id == AE) {
						W(AE, true)
					}
				})
			} else {
				if (w && !A && c("6.0.65") && (h.win || h.mac)) {
					A = true;
					W(AE, false);
					f(function() {
						var AF = {};
						AF.id = AF.altContentId = AE;
						AF.width = AB;
						AF.height = AD;
						AF.expressInstall = w;
						k(AF)
					})
				}
			}
		},
		getFlashPlayerVersion : function() {
			return {
				major : h.pv[0],
				minor : h.pv[1],
				release : h.pv[2]
			}
		},
		hasFlashPlayerVersion : c,
		createSWF : function(t, r, q) {
			if (h.w3cdom) {
				return U(t, r, q)
			} else {
				return undefined
			}
		},
		removeSWF : function(q) {
			if (h.w3cdom) {
				X(q)
			}
		},
		createCSS : function(r, q) {
			if (h.w3cdom) {
				V(r, q)
			}
		},
		addDomLoadEvent : f,
		addLoadEvent : R,
		getQueryParamValue : function(v) {
			var u = K.location.search || K.location.hash;
			if (v == null) {
				return g(u)
			}
			if (u) {
				var t = u.substring(1).split("&");
				for ( var r = 0; r < t.length; r++) {
					if (t[r].substring(0, t[r].indexOf("=")) == v) {
						return g(t[r].substring((t[r].indexOf("=") + 1)))
					}
				}
			}
			return ""
		},
		expressInstallCallback : function() {
			if (A && M) {
				var q = C(m);
				if (q) {
					q.parentNode.replaceChild(M, q);
					if (l) {
						W(l, true);
						if (h.ie && h.win) {
							M.style.display = "block"
						}
					}
					M = null;
					l = null;
					A = false
				}
			}
		}
	}
}();

$.fn.droppy = function(a) {
	a = $.extend({
		speed : 250
	}, a || {});
	this.each(function() {
		var c = this, g = 1000;
		function f(l) {
			if (l.nodeName.toLowerCase() == "li") {
				var k = $("> ul", l);
				return k.length ? k[0] : null
			} else {
				return l
			}
		}
		function d(k) {
			if (k.nodeName.toLowerCase() == "ul") {
				return $(k).parents("li")[0]
			} else {
				return k
			}
		}
		function e() {
			if (this.nodeName.toLowerCase() == "ul") {
				return
			}
			var k = f(this);
			if (!k) {
				return
			}
			$.data(k, "cancelHide", false);
			setTimeout(function() {
				if (!$.data(k, "cancelHide")) {
					$(k).slideUp(a.speed)
				}
			}, a.speed)
		}
		function b() {
			var l = f(this);
			if (!l) {
				return
			}
			$.data(l, "cancelHide", true);
			$(l).css({
				zIndex : g++
			}).slideDown(a.speed);
			if (this.nodeName.toLowerCase() == "ul") {
				var k = d(this);
				$(k).addClass("hover");
				$("> a", k).addClass("hover")
			}
		}
		$("ul, li", this).hover(b, e);
		$("li", this).hover(function() {
			$(this).addClass("hover");
			$("> a", this).addClass("hover")
		}, function() {
			$(this).removeClass("hover");
			$("> a", this).removeClass("hover")
		})
	})
};

(function(a) {
	a.fn.kwicks = function(b) {
		var c = {
			isVertical : false,
			sticky : false,
			defaultKwick : 0,
			event : "mouseover",
			spacing : 0,
			duration : 500
		};
		var e = a.extend(c, b);
		var f = (e.isVertical ? "height" : "width");
		var d = (e.isVertical ? "top" : "left");
		return this
				.each(function() {
					container = a(this);
					var l = container.children("li");
					var k = l.eq(0).css(f).replace(/px/, "");
					if (!e.max) {
						e.max = (k * l.size()) - (e.min * (l.size() - 1))
					} else {
						e.min = ((k * l.size()) - e.max) / (l.size() - 1)
					}
					if (e.isVertical) {
						container.css({
							width : l.eq(0).css("width"),
							height : (k * l.size())
									+ (e.spacing * (l.size() - 1)) + "px"
						})
					} else {
						container.css({
							width : (k * l.size())
									+ (e.spacing * (l.size() - 1)) + "px",
							height : l.eq(0).css("height")
						})
					}
					var g = [];
					for (i = 0; i < l.size(); i++) {
						g[i] = [];
						for (j = 1; j < l.size() - 1; j++) {
							if (i == j) {
								g[i][j] = e.isVertical ? j * e.min
										+ (j * e.spacing) : j * e.min
										+ (j * e.spacing)
							} else {
								g[i][j] = (j <= i ? (j * e.min) : (j - 1)
										* e.min + e.max)
										+ (j * e.spacing)
							}
						}
					}
					l
							.each(function(m) {
								var n = a(this);
								if (m === 0) {
									n.css(d, "0px")
								} else {
									if (m == l.size() - 1) {
										n.css(
												e.isVertical ? "bottom"
														: "right", "0px")
									} else {
										if (e.sticky) {
											n.css(d, g[e.defaultKwick][m])
										} else {
											n.css(d, (m * k) + (m * e.spacing))
										}
									}
								}
								if (e.sticky) {
									if (e.defaultKwick == m) {
										n.css(f, e.max + "px");
										n.addClass("active")
									} else {
										n.css(f, e.min + "px")
									}
								}
								n.css({
									margin : 0,
									position : "absolute"
								});
								n
										.bind(
												e.event,
												function() {
													var q = [];
													var s = [];
													l.stop().removeClass(
															"active");
													for (j = 0; j < l.size(); j++) {
														q[j] = l.eq(j).css(f)
																.replace(/px/,
																		"");
														s[j] = l.eq(j).css(d)
																.replace(/px/,
																		"")
													}
													var p = {};
													p[f] = e.max;
													var r = e.max - q[m];
													var o = q[m] / r;
													n
															.addClass("active")
															.animate(
																	p,
																	{
																		step : function(
																				u) {
																			var t = r != 0 ? u
																					/ r
																					- o
																					: 1;
																			l
																					.each(function(
																							v) {
																						if (v != m) {
																							l
																									.eq(
																											v)
																									.css(
																											f,
																											q[v]
																													- ((q[v] - e.min) * t)
																													+ "px")
																						}
																						if (v > 0
																								&& v < l
																										.size() - 1) {
																							l
																									.eq(
																											v)
																									.css(
																											d,
																											s[v]
																													- ((s[v] - g[m][v]) * t)
																													+ "px")
																						}
																					})
																		},
																		duration : e.duration,
																		easing : e.easing
																	})
												})
							});
					if (!e.sticky) {
						container
								.bind(
										"mouseleave",
										function() {
											var n = [];
											var o = [];
											l.removeClass("active").stop();
											for (i = 0; i < l.size(); i++) {
												n[i] = l.eq(i).css(f).replace(
														/px/, "");
												o[i] = l.eq(i).css(d).replace(
														/px/, "")
											}
											var m = {};
											m[f] = k;
											var p = k - n[0];
											l
													.eq(0)
													.animate(
															m,
															{
																step : function(
																		r) {
																	var q = p != 0 ? (r - n[0])
																			/ p
																			: 1;
																	for (i = 1; i < l
																			.size(); i++) {
																		l
																				.eq(
																						i)
																				.css(
																						f,
																						n[i]
																								- ((n[i] - k) * q)
																								+ "px");
																		if (i < l
																				.size() - 1) {
																			l
																					.eq(
																							i)
																					.css(
																							d,
																							o[i]
																									- ((o[i] - ((i * k) + (i * e.spacing))) * q)
																									+ "px")
																		}
																	}
																},
																duration : e.duration,
																easing : e.easing
															})
										})
					}
				})
	}
})(jQuery);

(function(f) {
	f.fn.fixPNG = function() {
		return this
				.each(function() {
					var m = f(this).css("backgroundImage");
					if (m.match(/^url\(["']?(.*\.png)["']?\)$/i)) {
						m = RegExp.$1;
						f(this)
								.css(
										{
											backgroundImage : "none",
											filter : "progid:DXImageTransform.Microsoft.AlphaImageLoader(enabled=true, sizingMethod="
													+ (f(this).css(
															"backgroundRepeat") == "no-repeat" ? "crop"
															: "scale")
													+ ", src='" + m + "')"
										}).each(function() {
									var n = f(this).css("position");
									if (n != "absolute" && n != "relative") {
										f(this).css("position", "relative")
									}
								})
					}
				})
	};
	var d, a, g = false, c = new Image, k, l = 1, e = /\.(jpg|gif|png|bmp|jpeg)(.*)?$/i;
	var b = (f.browser.msie && parseInt(f.browser.version.substr(0, 1)) < 8);
	f.fn.fancybox = function(n) {
		n = f.extend({}, f.fn.fancybox.defaults, n);
		var v = this;
		function q() {
			d = this;
			a = n;
			o();
			return false
		}
		function o() {
			if (g) {
				return
			}
			if (f.isFunction(a.callbackOnStart)) {
				a.callbackOnStart()
			}
			a.itemArray = [];
			a.itemCurrent = 0;
			if (n.itemArray.length > 0) {
				a.itemArray = n.itemArray
			} else {
				var y = {};
				for ( var x = 0; x < v.length; x++) {
					y = {
						href : v[x].href,
						title : v[x].title
					};
					if (f(v[x]).children("img:first").length) {
						y.orig = f(v[x]).children("img:first")
					}
					a.itemArray.push(y)
				}
			}
			while (a.itemArray[a.itemCurrent].href != d.href) {
				a.itemCurrent++
			}
			if (a.overlayShow) {
				if (b) {
					f("embed, object, select").css("visibility", "hidden")
				}
				f("#fancy_overlay").css("opacity", a.overlayOpacity).show()
			}
			r()
		}
		function r() {
			f("#fancy_right, #fancy_left, #fancy_close, #fancy_title").hide();
			var x = a.itemArray[a.itemCurrent].href;
			if (x.match(/#/)) {
				var y = window.location.href.split("#")[0];
				y = x.replace(y, "");
				p('<div id="fancy_div">' + f(y).html() + "</div>",
						a.frameWidth, a.frameHeight)
			} else {
				if (x.match(e)) {
					c = new Image;
					c.src = x;
					if (c.complete) {
						u()
					} else {
						f.fn.fancybox.showLoading();
						f(c).unbind().bind("load", function() {
							f(".fancy_loading").hide();
							u()
						})
					}
				} else {
					if (x.match("iframe")) {
						p(
								'<iframe id="fancy_frame" onload="$.fn.fancybox.showIframe()" name="fancy_iframe'
										+ Math.round(Math.random() * 1000)
										+ '" frameborder="0" hspace="0" src="'
										+ x + '"></iframe>', a.frameWidth,
								a.frameHeight)
					} else {
						f.get(x, function(z) {
							p('<div id="fancy_ajax">' + z + "</div>",
									a.frameWidth, a.frameHeight)
						})
					}
				}
			}
		}
		function u() {
			if (a.imageScale) {
				var y = f.fn.fancybox.getViewport();
				var A = Math.min(Math.min(y[0] - 36, c.width) / c.width, Math
						.min(y[1] - 60, c.height)
						/ c.height);
				var z = Math.round(A * c.width);
				var x = Math.round(A * c.height)
			} else {
				var z = c.width;
				var x = c.height
			}
			p('<img alt="" id="fancy_img" src="' + c.src + '" />', z, x);
			s()
		}
		function s() {
			if ((a.itemArray.length - 1) > a.itemCurrent) {
				var x = a.itemArray[a.itemCurrent + 1].href;
				if (x.match(e)) {
					objNext = new Image();
					objNext.src = x
				}
			}
			if (a.itemCurrent > 0) {
				var x = a.itemArray[a.itemCurrent - 1].href;
				if (x.match(e)) {
					objNext = new Image();
					objNext.src = x
				}
			}
		}
		function p(B, y, D) {
			var C = f.fn.fancybox.getViewport();
			var z = (y + 36) > C[0] ? C[2] : (C[2] + Math
					.round((C[0] - y - 36) / 2));
			var F = (D + 50) > C[1] ? C[3] : (C[3] + Math
					.round((C[1] - D - 50) / 2));
			var E = {
				left : z,
				top : F,
				width : y + "px",
				height : D + "px"
			};
			if (f("#fancy_outer").is(":visible")) {
				if (y == f("#fancy_content").width()
						&& D == f("#fancy_content").height()) {
					f("#fancy_content").fadeOut(
							"fast",
							function() {
								f("#fancy_content").empty().append(f(B))
										.fadeIn("fast", function() {
											m()
										})
							})
				} else {
					f("#fancy_content").fadeOut(
							"fast",
							function() {
								f("#fancy_content").empty();
								f("#fancy_outer").animate(
										E,
										a.zoomSpeedChange,
										a.easingChange,
										function() {
											f("#fancy_content").append(f(B))
													.fadeIn("fast", function() {
														m()
													})
										})
							})
				}
			} else {
				if (a.zoomSpeedIn > 0
						&& a.itemArray[a.itemCurrent].orig !== undefined) {
					f("#fancy_content").empty().append(f(B));
					var A = a.itemArray[a.itemCurrent].orig;
					var x = f.fn.fancybox.getPosition(A);
					f("#fancy_outer").css({
						left : (x.left - 18) + "px",
						top : (x.top - 18) + "px",
						width : f(A).width(),
						height : f(A).height()
					});
					g = true;
					if (a.zoomOpacity) {
						E.opacity = "show"
					}
					f("#fancy_outer").animate(E, a.zoomSpeedIn, a.easingIn,
							function() {
								m()
							})
				} else {
					f("#fancy_content").empty().append(f(B));
					g = true;
					f("#fancy_outer").css(E).fadeIn("normal", function() {
						m()
					})
				}
			}
		}
		function t() {
			if (a.itemCurrent != 0) {
				f("#fancy_left, #fancy_left_ico").unbind().bind("click",
						function(x) {
							x.stopPropagation();
							a.itemCurrent--;
							r();
							return false
						});
				f("#fancy_left").show()
			}
			if (a.itemCurrent != (a.itemArray.length - 1)) {
				f("#fancy_right, #fancy_right_ico").unbind().bind("click",
						function(x) {
							x.stopPropagation();
							a.itemCurrent++;
							r();
							return false
						});
				f("#fancy_right").show()
			}
		}
		function m() {
			t();
			f(document)
					.keydown(
							function(x) {
								if (x.keyCode == 27) {
									f.fn.fancybox.close();
									f(document).unbind("keydown")
								} else {
									if (x.keyCode == 37 && a.itemCurrent != 0) {
										a.itemCurrent--;
										r();
										f(document).unbind("keydown")
									} else {
										if (x.keyCode == 39
												&& a.itemCurrent != (a.itemArray.length - 1)) {
											a.itemCurrent++;
											r();
											f(document).unbind("keydown")
										}
									}
								}
							});
			if (a.centerOnScroll) {
				f(window).bind("resize scroll", f.fn.fancybox.scrollBox)
			} else {
				f("div#fancy_outer").css("position", "absolute")
			}
			if (a.hideOnContentClick) {
				f("#fancy_wrap").click(f.fn.fancybox.close)
			} else {
				f("#fancy_wrap").unbind()
			}
			f("#fancy_close").show();
			if (a.itemArray[a.itemCurrent].title !== undefined
					&& a.itemArray[a.itemCurrent].title.length > 0) {
				f("#fancy_title div").html(a.itemArray[a.itemCurrent].title);
				f("#fancy_title").show()
			}
			if (a.overlayShow && b) {
				f("#fancy_content").find("embed, object, select").css(
						"visibility", "visible")
			}
			g = false
		}
		return this.unbind("click").click(q)
	};
	f.fn.fancybox.scrollBox = function() {
		var m = f.fn.fancybox.getViewport();
		f("#fancy_outer")
				.css(
						"left",
						((f("#fancy_outer").width() + 36) > m[0] ? m[2]
								: m[2]
										+ Math
												.round((m[0]
														- f("#fancy_outer")
																.width() - 36) / 2)));
		f("#fancy_outer")
				.css(
						"top",
						((f("#fancy_outer").height() + 50) > m[1] ? m[3]
								: m[3]
										+ Math
												.round((m[1]
														- f("#fancy_outer")
																.height() - 50) / 2)))
	};
	f.fn.fancybox.getNumeric = function(m, n) {
		return parseInt(f.curCSS(m.jquery ? m[0] : m, n, true)) || 0
	};
	f.fn.fancybox.getPosition = function(m) {
		var n = m.offset();
		n.top += f.fn.fancybox.getNumeric(m, "paddingTop");
		n.top += f.fn.fancybox.getNumeric(m, "borderTopWidth");
		n.left += f.fn.fancybox.getNumeric(m, "paddingLeft");
		n.left += f.fn.fancybox.getNumeric(m, "borderLeftWidth");
		return n
	};
	f.fn.fancybox.showIframe = function() {
		f(".fancy_loading").hide();
		f("#fancy_frame").show()
	};
	f.fn.fancybox.getViewport = function() {
		return [ f(window).width(), f(window).height(),
				f(document).scrollLeft(), f(document).scrollTop() ]
	};
	f.fn.fancybox.animateLoading = function() {
		if (!f("#fancy_loading").is(":visible")) {
			clearInterval(k);
			return
		}
		f("#fancy_loading > div").css("top", (l * -40) + "px");
		l = (l + 1) % 12
	};
	f.fn.fancybox.showLoading = function() {
		clearInterval(k);
		var m = f.fn.fancybox.getViewport();
		f("#fancy_loading").css({
			left : ((m[0] - 40) / 2 + m[2]),
			top : ((m[1] - 40) / 2 + m[3])
		}).show();
		f("#fancy_loading").bind("click", f.fn.fancybox.close);
		k = setInterval(f.fn.fancybox.animateLoading, 66)
	};
	f.fn.fancybox.close = function() {
		f(c).unbind();
		f(
				"#fancy_close, .fancy_loading, #fancy_left, #fancy_right, #fancy_title")
				.hide();
		__cleanup = function() {
			f("#fancy_overlay, #fancy_outer").hide();
			if (b) {
				f("embed, object, select").css("visibility", "visible")
			}
			if (f.isFunction(a.callbackOnClose)) {
				a.callbackOnClose()
			}
			g = false
		};
		if (f("#fancy_outer").is(":visible") !== false) {
			g = true;
			if (a.zoomSpeedOut > 0
					&& a.itemArray[a.itemCurrent].orig !== undefined) {
				var n = a.itemArray[a.itemCurrent].orig;
				var m = f.fn.fancybox.getPosition(n);
				var o = {
					left : (m.left - 18) + "px",
					top : (m.top - 18) + "px",
					width : f(n).width(),
					height : f(n).height()
				};
				if (a.zoomOpacity) {
					o.opacity = "hide"
				}
				f("#fancy_outer").animate(o, a.zoomSpeedOut, a.easingOut,
						__cleanup)
			} else {
				f("#fancy_outer").stop().fadeOut("fast", __cleanup)
			}
		} else {
			__cleanup()
		}
		return false
	};
	f.fn.fancybox.build = function() {
		var m = "";
		m += '<div id="fancy_overlay"></div>';
		m += '<div id="fancy_wrap">';
		m += '<div class="fancy_loading" id="fancy_loading"><div></div></div>';
		m += '<div id="fancy_outer">';
		m += '<div id="fancy_inner">';
		m += '<div id="fancy_close"></div>';
		m += '<div id="fancy_bg"><div class="fancy_bg fancy_bg_n"></div><div class="fancy_bg fancy_bg_ne"></div><div class="fancy_bg fancy_bg_e"></div><div class="fancy_bg fancy_bg_se"></div><div class="fancy_bg fancy_bg_s"></div><div class="fancy_bg fancy_bg_sw"></div><div class="fancy_bg fancy_bg_w"></div><div class="fancy_bg fancy_bg_nw"></div></div>';
		m += '<a href="javascript:;" id="fancy_left"><span class="fancy_ico" id="fancy_left_ico"></span></a><a href="javascript:;" id="fancy_right"><span class="fancy_ico" id="fancy_right_ico"></span></a>';
		m += '<div id="fancy_content"></div>';
		m += '<div id="fancy_title"></div>';
		m += "</div>";
		m += "</div>";
		m += "</div>";
		f(m).appendTo("body");
		f(
				'<table cellspacing="0" cellpadding="0" border="0"><tr><td class="fancy_title" id="fancy_title_left"></td><td class="fancy_title" id="fancy_title_main"><div></div></td><td class="fancy_title" id="fancy_title_right"></td></tr></table>')
				.appendTo("#fancy_title");
		if (b) {
			f("#fancy_inner")
					.prepend(
							'<iframe class="fancy_bigIframe" scrolling="no" frameborder="0"></iframe>');
			f("#fancy_close, .fancy_bg, .fancy_title, .fancy_ico").fixPNG()
		}
		f("#fancy_overlay, #fancy_bigIframe, #fancy_loading, #fancy_close")
				.bind("click", f.fn.fancybox.close)
	};
	f.fn.fancybox.defaults = {
		imageScale : true,
		zoomOpacity : false,
		zoomSpeedIn : 0,
		zoomSpeedOut : 0,
		zoomSpeedChange : 300,
		easingIn : "swing",
		easingOut : "swing",
		easingChange : "swing",
		frameWidth : 425,
		frameHeight : 355,
		overlayShow : true,
		overlayOpacity : 0.3,
		hideOnContentClick : true,
		centerOnScroll : true,
		itemArray : [],
		callbackOnStart : null,
		callbackOnClose : null
	};
	f(document).ready(function() {
		f.fn.fancybox.build()
	})
})(jQuery);

(function($) {
	$.extend({
		metadata : {
			defaults : {
				type : "class",
				name : "metadata",
				cre : /({.*})/,
				single : "metadata"
			},
			setType : function(type, name) {
				this.defaults.type = type;
				this.defaults.name = name
			},
			get : function(elem, opts) {
				var settings = $.extend({}, this.defaults, opts);
				if (!settings.single.length) {
					settings.single = "metadata"
				}
				var data = $.data(elem, settings.single);
				if (data) {
					return data
				}
				data = "{}";
				if (settings.type == "class") {
					var m = settings.cre.exec(elem.className);
					if (m) {
						data = m[1]
					}
				} else {
					if (settings.type == "elem") {
						if (!elem.getElementsByTagName) {
							return undefined
						}
						var e = elem.getElementsByTagName(settings.name);
						if (e.length) {
							data = $.trim(e[0].innerHTML)
						}
					} else {
						if (elem.getAttribute != undefined) {
							var attr = elem.getAttribute(settings.name);
							if (attr) {
								data = attr
							}
						}
					}
				}
				if (data.indexOf("{") < 0) {
					data = "{" + data + "}"
				}
				data = eval("(" + data + ")");
				$.data(elem, settings.single, data);
				return data
			}
		}
	});
	$.fn.metadata = function(opts) {
		return $.metadata.get(this[0], opts)
	}
})(jQuery);

(function($) {
	$
			.extend({
				tablesorter : new function() {
					var parsers = [], widgets = [];
					this.defaults = {
						cssHeader : "header",
						cssAsc : "headerSortUp",
						cssDesc : "headerSortDown",
						sortInitialOrder : "asc",
						sortMultiSortKey : "shiftKey",
						sortForce : null,
						sortAppend : null,
						textExtraction : "simple",
						parsers : {},
						widgets : [],
						widgetZebra : {
							css : [ "even", "odd" ]
						},
						headers : {},
						widthFixed : false,
						cancelSelection : true,
						sortList : [],
						headerList : [],
						dateFormat : "us",
						decimal : ".",
						debug : false
					};
					function benchmark(s, d) {
						log(s + "," + (new Date().getTime() - d.getTime())
								+ "ms")
					}
					this.benchmark = benchmark;
					function log(s) {
						if (typeof console != "undefined"
								&& typeof console.debug != "undefined") {
							console.log(s)
						} else {
							alert(s)
						}
					}
					function buildParserCache(table, $headers) {
						if (table.config.debug) {
							var parsersDebug = ""
						}
						var rows = table.tBodies[0].rows;
						if (table.tBodies[0].rows[0]) {
							var list = [], cells = rows[0].cells, l = cells.length;
							for ( var i = 0; i < l; i++) {
								var p = false;
								if ($.metadata
										&& ($($headers[i]).metadata() && $(
												$headers[i]).metadata().sorter)) {
									p = getParserById($($headers[i]).metadata().sorter)
								} else {
									if ((table.config.headers[i] && table.config.headers[i].sorter)) {
										p = getParserById(table.config.headers[i].sorter)
									}
								}
								if (!p) {
									p = detectParserForColumn(table, cells[i])
								}
								if (table.config.debug) {
									parsersDebug += "column:" + i + " parser:"
											+ p.id + "\n"
								}
								list.push(p)
							}
						}
						if (table.config.debug) {
							log(parsersDebug)
						}
						return list
					}
					function detectParserForColumn(table, node) {
						var l = parsers.length;
						for ( var i = 1; i < l; i++) {
							if (parsers[i].is($.trim(getElementText(
									table.config, node)), table, node)) {
								return parsers[i]
							}
						}
						return parsers[0]
					}
					function getParserById(name) {
						var l = parsers.length;
						for ( var i = 0; i < l; i++) {
							if (parsers[i].id.toLowerCase() == name
									.toLowerCase()) {
								return parsers[i]
							}
						}
						return false
					}
					function buildCache(table) {
						if (table.config.debug) {
							var cacheTime = new Date()
						}
						var totalRows = (table.tBodies[0] && table.tBodies[0].rows.length) || 0, totalCells = (table.tBodies[0].rows[0] && table.tBodies[0].rows[0].cells.length) || 0, parsers = table.config.parsers, cache = {
							row : [],
							normalized : []
						};
						for ( var i = 0; i < totalRows; ++i) {
							var c = table.tBodies[0].rows[i], cols = [];
							cache.row.push($(c));
							for ( var j = 0; j < totalCells; ++j) {
								cols.push(parsers[j].format(getElementText(
										table.config, c.cells[j]), table,
										c.cells[j]))
							}
							cols.push(i);
							cache.normalized.push(cols);
							cols = null
						}
						if (table.config.debug) {
							benchmark("Building cache for " + totalRows
									+ " rows:", cacheTime)
						}
						return cache
					}
					function getElementText(config, node) {
						if (!node) {
							return ""
						}
						var t = "";
						if (config.textExtraction == "simple") {
							if (node.childNodes[0]
									&& node.childNodes[0].hasChildNodes()) {
								t = node.childNodes[0].innerHTML
							} else {
								t = node.innerHTML
							}
						} else {
							if (typeof (config.textExtraction) == "function") {
								t = config.textExtraction(node)
							} else {
								t = $(node).text()
							}
						}
						return t
					}
					function appendToTable(table, cache) {
						if (table.config.debug) {
							var appendTime = new Date()
						}
						var c = cache, r = c.row, n = c.normalized, totalRows = n.length, checkCell = (n[0].length - 1), tableBody = $(table.tBodies[0]), rows = [];
						for ( var i = 0; i < totalRows; i++) {
							rows.push(r[n[i][checkCell]]);
							if (!table.config.appender) {
								var o = r[n[i][checkCell]];
								var l = o.length;
								for ( var j = 0; j < l; j++) {
									tableBody[0].appendChild(o[j])
								}
							}
						}
						if (table.config.appender) {
							table.config.appender(table, rows)
						}
						rows = null;
						if (table.config.debug) {
							benchmark("Rebuilt table:", appendTime)
						}
						applyWidget(table);
						setTimeout(function() {
							$(table).trigger("sortEnd")
						}, 0)
					}
					function buildHeaders(table) {
						if (table.config.debug) {
							var time = new Date()
						}
						var meta = ($.metadata) ? true : false, tableHeadersRows = [];
						for ( var i = 0; i < table.tHead.rows.length; i++) {
							tableHeadersRows[i] = 0
						}
						$tableHeaders = $("thead th", table);
						$tableHeaders
								.each(function(index) {
									this.count = 0;
									this.column = index;
									this.order = formatSortingOrder(table.config.sortInitialOrder);
									if (checkHeaderMetadata(this)
											|| checkHeaderOptions(table, index)) {
										this.sortDisabled = true
									}
									if (!this.sortDisabled) {
										$(this)
												.addClass(
														table.config.cssHeader)
									}
									table.config.headerList[index] = this
								});
						if (table.config.debug) {
							benchmark("Built headers:", time);
							log($tableHeaders)
						}
						return $tableHeaders
					}
					function checkCellColSpan(table, rows, row) {
						var arr = [], r = table.tHead.rows, c = r[row].cells;
						for ( var i = 0; i < c.length; i++) {
							var cell = c[i];
							if (cell.colSpan > 1) {
								arr = arr.concat(checkCellColSpan(table,
										headerArr, row++))
							} else {
								if (table.tHead.length == 1
										|| (cell.rowSpan > 1 || !r[row + 1])) {
									arr.push(cell)
								}
							}
						}
						return arr
					}
					function checkHeaderMetadata(cell) {
						if (($.metadata)
								&& ($(cell).metadata().sorter === false)) {
							return true
						}
						return false
					}
					function checkHeaderOptions(table, i) {
						if ((table.config.headers[i])
								&& (table.config.headers[i].sorter === false)) {
							return true
						}
						return false
					}
					function applyWidget(table) {
						var c = table.config.widgets;
						var l = c.length;
						for ( var i = 0; i < l; i++) {
							getWidgetById(c[i]).format(table)
						}
					}
					function getWidgetById(name) {
						var l = widgets.length;
						for ( var i = 0; i < l; i++) {
							if (widgets[i].id.toLowerCase() == name
									.toLowerCase()) {
								return widgets[i]
							}
						}
					}
					function formatSortingOrder(v) {
						if (typeof (v) != "Number") {
							i = (v.toLowerCase() == "desc") ? 1 : 0
						} else {
							i = (v == (0 || 1)) ? v : 0
						}
						return i
					}
					function isValueInArray(v, a) {
						var l = a.length;
						for ( var i = 0; i < l; i++) {
							if (a[i][0] == v) {
								return true
							}
						}
						return false
					}
					function setHeadersCss(table, $headers, list, css) {
						$headers.removeClass(css[0]).removeClass(css[1]);
						var h = [];
						$headers.each(function(offset) {
							if (!this.sortDisabled) {
								h[this.column] = $(this)
							}
						});
						var l = list.length;
						for ( var i = 0; i < l; i++) {
							h[list[i][0]].addClass(css[list[i][1]])
						}
					}
					function fixColumnWidth(table, $headers) {
						var c = table.config;
						if (c.widthFixed) {
							var colgroup = $("<colgroup>");
							$("tr:first td", table.tBodies[0]).each(
									function() {
										colgroup.append($("<col>").css("width",
												$(this).width()))
									});
							$(table).prepend(colgroup)
						}
					}
					function updateHeaderSortCount(table, sortList) {
						var c = table.config, l = sortList.length;
						for ( var i = 0; i < l; i++) {
							var s = sortList[i], o = c.headerList[s[0]];
							o.count = s[1];
							o.count++
						}
					}
					function multisort(table, sortList, cache) {
						if (table.config.debug) {
							var sortTime = new Date()
						}
						var dynamicExp = "var sortWrapper = function(a,b) {", l = sortList.length;
						for ( var i = 0; i < l; i++) {
							var c = sortList[i][0];
							var order = sortList[i][1];
							var s = (getCachedSortType(table.config.parsers, c) == "text") ? ((order == 0) ? "sortText"
									: "sortTextDesc")
									: ((order == 0) ? "sortNumeric"
											: "sortNumericDesc");
							var e = "e" + i;
							dynamicExp += "var " + e + " = " + s + "(a[" + c
									+ "],b[" + c + "]); ";
							dynamicExp += "if(" + e + ") { return " + e
									+ "; } ";
							dynamicExp += "else { "
						}
						var orgOrderCol = cache.normalized[0].length - 1;
						dynamicExp += "return a[" + orgOrderCol + "]-b["
								+ orgOrderCol + "];";
						for ( var i = 0; i < l; i++) {
							dynamicExp += "}; "
						}
						dynamicExp += "return 0; ";
						dynamicExp += "}; ";
						eval(dynamicExp);
						cache.normalized.sort(sortWrapper);
						if (table.config.debug) {
							benchmark("Sorting on " + sortList.toString()
									+ " and dir " + order + " time:", sortTime)
						}
						return cache
					}
					function sortText(a, b) {
						return ((a < b) ? -1 : ((a > b) ? 1 : 0))
					}
					function sortTextDesc(a, b) {
						return ((b < a) ? -1 : ((b > a) ? 1 : 0))
					}
					function sortNumeric(a, b) {
						return a - b
					}
					function sortNumericDesc(a, b) {
						return b - a
					}
					function getCachedSortType(parsers, i) {
						return parsers[i].type
					}
					this.construct = function(settings) {
						return this
								.each(function() {
									if (!this.tHead || !this.tBodies) {
										return
									}
									var $this, $document, $headers, cache, config, shiftDown = 0, sortOrder;
									this.config = {};
									config = $.extend(this.config,
											$.tablesorter.defaults, settings);
									$this = $(this);
									$headers = buildHeaders(this);
									this.config.parsers = buildParserCache(
											this, $headers);
									cache = buildCache(this);
									var sortCSS = [ config.cssDesc,
											config.cssAsc ];
									fixColumnWidth(this);
									$headers
											.click(
													function(e) {
														$this
																.trigger("sortStart");
														var totalRows = ($this[0].tBodies[0] && $this[0].tBodies[0].rows.length) || 0;
														if (!this.sortDisabled
																&& totalRows > 0) {
															var $cell = $(this);
															var i = this.column;
															this.order = this.count++ % 2;
															if (!e[config.sortMultiSortKey]) {
																config.sortList = [];
																if (config.sortForce != null) {
																	var a = config.sortForce;
																	for ( var j = 0; j < a.length; j++) {
																		if (a[j][0] != i) {
																			config.sortList
																					.push(a[j])
																		}
																	}
																}
																config.sortList
																		.push([
																				i,
																				this.order ])
															} else {
																if (isValueInArray(
																		i,
																		config.sortList)) {
																	for ( var j = 0; j < config.sortList.length; j++) {
																		var s = config.sortList[j], o = config.headerList[s[0]];
																		if (s[0] == i) {
																			o.count = s[1];
																			o.count++;
																			s[1] = o.count % 2
																		}
																	}
																} else {
																	config.sortList
																			.push([
																					i,
																					this.order ])
																}
															}
															setTimeout(
																	function() {
																		setHeadersCss(
																				$this[0],
																				$headers,
																				config.sortList,
																				sortCSS);
																		appendToTable(
																				$this[0],
																				multisort(
																						$this[0],
																						config.sortList,
																						cache))
																	}, 1);
															return false
														}
													})
											.mousedown(
													function() {
														if (config.cancelSelection) {
															this.onselectstart = function() {
																return false
															};
															return false
														}
													});
									$this
											.bind(
													"update",
													function() {
														this.config.parsers = buildParserCache(
																this, $headers);
														cache = buildCache(this)
													})
											.bind(
													"sorton",
													function(e, list) {
														$(this).trigger(
																"sortStart");
														config.sortList = list;
														var sortList = config.sortList;
														updateHeaderSortCount(
																this, sortList);
														setHeadersCss(this,
																$headers,
																sortList,
																sortCSS);
														appendToTable(
																this,
																multisort(
																		this,
																		sortList,
																		cache))
													}).bind(
													"appendCache",
													function() {
														appendToTable(this,
																cache)
													}).bind(
													"applyWidgetId",
													function(e, id) {
														getWidgetById(id)
																.format(this)
													}).bind("applyWidgets",
													function() {
														applyWidget(this)
													});
									if ($.metadata
											&& ($(this).metadata() && $(this)
													.metadata().sortlist)) {
										config.sortList = $(this).metadata().sortlist
									}
									if (config.sortList.length > 0) {
										$this.trigger("sorton",
												[ config.sortList ])
									}
									applyWidget(this)
								})
					};
					this.addParser = function(parser) {
						var l = parsers.length, a = true;
						for ( var i = 0; i < l; i++) {
							if (parsers[i].id.toLowerCase() == parser.id
									.toLowerCase()) {
								a = false
							}
						}
						if (a) {
							parsers.push(parser)
						}
					};
					this.addWidget = function(widget) {
						widgets.push(widget)
					};
					this.formatFloat = function(s) {
						var i = parseFloat(s);
						return (isNaN(i)) ? 0 : i
					};
					this.formatInt = function(s) {
						var i = parseInt(s);
						return (isNaN(i)) ? 0 : i
					};
					this.isDigit = function(s, config) {
						var DECIMAL = "\\" + config.decimal;
						var exp = "/(^[+]?0("
								+ DECIMAL
								+ "0+)?$)|(^([-+]?[1-9][0-9]*)$)|(^([-+]?((0?|[1-9][0-9]*)"
								+ DECIMAL
								+ "(0*[1-9][0-9]*)))$)|(^[-+]?[1-9]+[0-9]*"
								+ DECIMAL + "0+$)/";
						return RegExp(exp).test($.trim(s))
					};
					this.clearTableBody = function(table) {
						if ($.browser.msie) {
							function empty() {
								while (this.firstChild) {
									this.removeChild(this.firstChild)
								}
							}
							empty.apply(table.tBodies[0])
						} else {
							table.tBodies[0].innerHTML = ""
						}
					}
				}
			});
	$.fn.extend({
		tablesorter : $.tablesorter.construct
	});
	var ts = $.tablesorter;
	ts.addParser({
		id : "text",
		is : function(s) {
			return true
		},
		format : function(s) {
			return $.trim(s.toLowerCase())
		},
		type : "text"
	});
	ts.addParser({
		id : "digit",
		is : function(s, table) {
			var c = table.config;
			return $.tablesorter.isDigit(s, c)
		},
		format : function(s) {
			return $.tablesorter.formatFloat(s)
		},
		type : "numeric"
	});
	ts.addParser({
		id : "currency",
		is : function(s) {
			return /^[£$€?.]/.test(s)
		},
		format : function(s) {
			return $.tablesorter.formatFloat(s.replace(new RegExp(/[^0-9.]/g),
					""))
		},
		type : "numeric"
	});
	ts.addParser({
		id : "ipAddress",
		is : function(s) {
			return /^\d{2,3}[\.]\d{2,3}[\.]\d{2,3}[\.]\d{2,3}$/.test(s)
		},
		format : function(s) {
			var a = s.split("."), r = "", l = a.length;
			for ( var i = 0; i < l; i++) {
				var item = a[i];
				if (item.length == 2) {
					r += "0" + item
				} else {
					r += item
				}
			}
			return $.tablesorter.formatFloat(r)
		},
		type : "numeric"
	});
	ts.addParser({
		id : "url",
		is : function(s) {
			return /^(https?|ftp|file):\/\/$/.test(s)
		},
		format : function(s) {
			return jQuery.trim(s.replace(new RegExp(/(https?|ftp|file):\/\//),
					""))
		},
		type : "text"
	});
	ts.addParser({
		id : "isoDate",
		is : function(s) {
			return /^\d{4}[\/-]\d{1,2}[\/-]\d{1,2}$/.test(s)
		},
		format : function(s) {
			return $.tablesorter.formatFloat((s != "") ? new Date(s.replace(
					new RegExp(/-/g), "/")).getTime() : "0")
		},
		type : "numeric"
	});
	ts.addParser({
		id : "percent",
		is : function(s) {
			return /\%$/.test($.trim(s))
		},
		format : function(s) {
			return $.tablesorter.formatFloat(s.replace(new RegExp(/%/g), ""))
		},
		type : "numeric"
	});
	ts
			.addParser({
				id : "usLongDate",
				is : function(s) {
					return s
							.match(new RegExp(
									/^[A-Za-z]{3,10}\.? [0-9]{1,2}, ([0-9]{4}|'?[0-9]{2}) (([0-2]?[0-9]:[0-5][0-9])|([0-1]?[0-9]:[0-5][0-9]\s(AM|PM)))$/))
				},
				format : function(s) {
					return $.tablesorter.formatFloat(new Date(s).getTime())
				},
				type : "numeric"
			});
	ts.addParser({
		id : "shortDate",
		is : function(s) {
			return /\d{1,2}[\/\-]\d{1,2}[\/\-]\d{2,4}/.test(s)
		},
		format : function(s, table) {
			var c = table.config;
			s = s.replace(/\-/g, "/");
			if (c.dateFormat == "us") {
				s = s.replace(/(\d{1,2})[\/\-](\d{1,2})[\/\-](\d{4})/,
						"$3/$1/$2")
			} else {
				if (c.dateFormat == "uk") {
					s = s.replace(/(\d{1,2})[\/\-](\d{1,2})[\/\-](\d{4})/,
							"$3/$2/$1")
				} else {
					if (c.dateFormat == "dd/mm/yy"
							|| c.dateFormat == "dd-mm-yy") {
						s = s.replace(/(\d{1,2})[\/\-](\d{1,2})[\/\-](\d{2})/,
								"$1/$2/$3")
					}
				}
			}
			return $.tablesorter.formatFloat(new Date(s).getTime())
		},
		type : "numeric"
	});
	ts
			.addParser({
				id : "time",
				is : function(s) {
					return /^(([0-2]?[0-9]:[0-5][0-9])|([0-1]?[0-9]:[0-5][0-9]\s(am|pm)))$/
							.test(s)
				},
				format : function(s) {
					return $.tablesorter
							.formatFloat(new Date("2000/01/01 " + s).getTime())
				},
				type : "numeric"
			});
	ts.addParser({
		id : "metadata",
		is : function(s) {
			return false
		},
		format : function(s, table, cell) {
			var c = table.config, p = (!c.parserMetadataName) ? "sortValue"
					: c.parserMetadataName;
			return $(cell).metadata()[p]
		},
		type : "numeric"
	});
	ts.addWidget({
		id : "zebra",
		format : function(table) {
			if (table.config.debug) {
				var time = new Date()
			}
			$("tr:visible", table.tBodies[0]).filter(":even").removeClass(
					table.config.widgetZebra.css[1]).addClass(
					table.config.widgetZebra.css[0]).end().filter(":odd")
					.removeClass(table.config.widgetZebra.css[0]).addClass(
							table.config.widgetZebra.css[1]);
			if (table.config.debug) {
				$.tablesorter.benchmark("Applying Zebra widget", time)
			}
		}
	})
})(jQuery);

(function(a) {
	a.fn.extend({
		autocomplete : function(b, c) {
			var d = typeof b == "string";
			c = a.extend({}, a.Autocompleter.defaults, {
				url : d ? b : null,
				data : d ? null : b,
				delay : d ? a.Autocompleter.defaults.delay : 10,
				max : c && !c.scroll ? 10 : 150
			}, c);
			c.highlight = c.highlight || function(e) {
				return e
			};
			c.formatMatch = c.formatMatch || c.formatItem;
			return this.each(function() {
				new a.Autocompleter(this, c)
			})
		},
		result : function(b) {
			return this.bind("result", b)
		},
		search : function(b) {
			return this.trigger("search", [ b ])
		},
		flushCache : function() {
			return this.trigger("flushCache")
		},
		setOptions : function(b) {
			return this.trigger("setOptions", [ b ])
		},
		unautocomplete : function() {
			return this.trigger("unautocomplete")
		}
	});
	a.Autocompleter = function(o, g) {
		var c = {
			UP : 38,
			DOWN : 40,
			DEL : 46,
			TAB : 9,
			RETURN : 13,
			ESC : 27,
			COMMA : 188,
			PAGEUP : 33,
			PAGEDOWN : 34,
			BACKSPACE : 8
		};
		var b = a(o).attr("autocomplete", "off").addClass(g.inputClass);
		var m;
		var s = "";
		var p = a.Autocompleter.Cache(g);
		var e = 0;
		var y;
		var B = {
			mouseDownOnSelect : false
		};
		var u = a.Autocompleter.Select(g, o, d, B);
		var A;
		a.browser.opera && a(o.form).bind("submit.autocomplete", function() {
			if (A) {
				A = false;
				return false
			}
		});
		b.bind(
				(a.browser.opera ? "keypress" : "keydown") + ".autocomplete",
				function(C) {
					e = 1;
					y = C.keyCode;
					switch (C.keyCode) {
					case c.UP:
						C.preventDefault();
						if (u.visible()) {
							u.prev()
						} else {
							x(0, true)
						}
						break;
					case c.DOWN:
						C.preventDefault();
						if (u.visible()) {
							u.next()
						} else {
							x(0, true)
						}
						break;
					case c.PAGEUP:
						C.preventDefault();
						if (u.visible()) {
							u.pageUp()
						} else {
							x(0, true)
						}
						break;
					case c.PAGEDOWN:
						C.preventDefault();
						if (u.visible()) {
							u.pageDown()
						} else {
							x(0, true)
						}
						break;
					case g.multiple && a.trim(g.multipleSeparator) == ","
							&& c.COMMA:
					case c.TAB:
					case c.RETURN:
						if (d()) {
							C.preventDefault();
							A = true;
							return false
						}
						break;
					case c.ESC:
						u.hide();
						break;
					default:
						clearTimeout(m);
						m = setTimeout(x, g.delay);
						break
					}
				}).focus(function() {
			e++
		}).blur(function() {
			e = 0;
			if (!B.mouseDownOnSelect) {
				v()
			}
		}).click(function() {
			if (e++ > 1 && !u.visible()) {
				x(0, true)
			}
		}).bind("search", function() {
			var C = (arguments.length > 1) ? arguments[1] : null;
			function D(H, G) {
				var E;
				if (G && G.length) {
					for ( var F = 0; F < G.length; F++) {
						if (G[F].result.toLowerCase() == H.toLowerCase()) {
							E = G[F];
							break
						}
					}
				}
				if (typeof C == "function") {
					C(E)
				} else {
					b.trigger("result", E && [ E.data, E.value ])
				}
			}
			a.each(k(b.val()), function(E, F) {
				f(F, D, D)
			})
		}).bind("flushCache", function() {
			p.flush()
		}).bind("setOptions", function() {
			a.extend(g, arguments[1]);
			if ("data" in arguments[1]) {
				p.populate()
			}
		}).bind("unautocomplete", function() {
			u.unbind();
			b.unbind();
			a(o.form).unbind(".autocomplete")
		});
		function d() {
			var F = u.selected();
			if (!F) {
				return false
			}
			var C = F.result;
			s = C;
			if (g.multiple) {
				var I = k(b.val());
				if (I.length > 1) {
					var E = g.multipleSeparator.length;
					var H = a(o).selection().start;
					var G, D = 0;
					a.each(I, function(J, K) {
						D += K.length;
						if (H <= D) {
							G = J;
							return false
						}
						D += E
					});
					I[G] = C;
					C = I.join(g.multipleSeparator)
				}
				C += g.multipleSeparator
			}
			b.val(C);
			z();
			b.trigger("result", [ F.data, F.value ]);
			return true
		}
		function x(E, D) {
			if (y == c.DEL) {
				u.hide();
				return
			}
			var C = b.val();
			if (!D && C == s) {
				return
			}
			s = C;
			C = l(C);
			if (C.length >= g.minChars) {
				b.addClass(g.loadingClass);
				if (!g.matchCase) {
					C = C.toLowerCase()
				}
				f(C, n, z)
			} else {
				q();
				u.hide()
			}
		}
		function k(C) {
			if (!C) {
				return [ "" ]
			}
			if (!g.multiple) {
				return [ a.trim(C) ]
			}
			return a.map(C.split(g.multipleSeparator), function(D) {
				return a.trim(C).length ? a.trim(D) : null
			})
		}
		function l(C) {
			if (!g.multiple) {
				return C
			}
			var E = k(C);
			if (E.length == 1) {
				return E[0]
			}
			var D = a(o).selection().start;
			if (D == C.length) {
				E = k(C)
			} else {
				E = k(C.replace(C.substring(D), ""))
			}
			return E[E.length - 1]
		}
		function t(C, D) {
			if (g.autoFill && (l(b.val()).toLowerCase() == C.toLowerCase())
					&& y != c.BACKSPACE) {
				b.val(b.val() + D.substring(l(s).length));
				a(o).selection(s.length, s.length + D.length)
			}
		}
		function v() {
			clearTimeout(m);
			m = setTimeout(z, 200)
		}
		function z() {
			var C = u.visible();
			u.hide();
			clearTimeout(m);
			q();
			if (g.mustMatch) {
				b.search(function(D) {
					if (!D) {
						if (g.multiple) {
							var E = k(b.val()).slice(0, -1);
							b.val(E.join(g.multipleSeparator)
									+ (E.length ? g.multipleSeparator : ""))
						} else {
							b.val("");
							b.trigger("result", null)
						}
					}
				})
			}
		}
		function n(D, C) {
			if (C && C.length && e) {
				q();
				u.display(C, D);
				t(D, C[0].value);
				u.show()
			} else {
				z()
			}
		}
		function f(D, F, C) {
			if (!g.matchCase) {
				D = D.toLowerCase()
			}
			var E = p.load(D);
			if (E && E.length) {
				F(D, E)
			} else {
				if ((typeof g.url == "string") && (g.url.length > 0)) {
					var G = {
						timestamp : +new Date()
					};
					a.each(g.extraParams, function(H, I) {
						G[H] = typeof I == "function" ? I() : I
					});
					a.ajax({
						mode : "abort",
						port : "autocomplete" + o.name,
						dataType : g.dataType,
						url : g.url,
						data : a.extend({
							q : l(D),
							limit : g.max
						}, G),
						success : function(I) {
							var H = g.parse && g.parse(I) || r(I);
							p.add(D, H);
							F(D, H)
						}
					})
				} else {
					u.emptyList();
					C(D)
				}
			}
		}
		function r(F) {
			var C = [];
			var E = F.split("\n");
			for ( var D = 0; D < E.length; D++) {
				var G = a.trim(E[D]);
				if (G) {
					G = G.split("|");
					C[C.length] = {
						data : G,
						value : G[0],
						result : g.formatResult && g.formatResult(G, G[0])
								|| G[0]
					}
				}
			}
			return C
		}
		function q() {
			b.removeClass(g.loadingClass)
		}
	};
	a.Autocompleter.defaults = {
		inputClass : "ac_input",
		resultsClass : "ac_results",
		loadingClass : "ac_loading",
		minChars : 1,
		delay : 400,
		matchCase : false,
		matchSubset : true,
		matchContains : false,
		cacheLength : 10,
		max : 100,
		mustMatch : false,
		extraParams : {},
		selectFirst : true,
		formatItem : function(b) {
			return b[0]
		},
		formatMatch : null,
		autoFill : false,
		width : 0,
		multiple : false,
		multipleSeparator : ", ",
		highlight : function(c, b) {
			return c.replace(new RegExp("(?![^&;]+;)(?!<[^<>]*)("
					+ b.replace(/([\^\$\(\)\[\]\{\}\*\.\+\?\|\\])/gi, "\\$1")
					+ ")(?![^<>]*>)(?![^&;]+;)", "gi"), "<strong>$1</strong>")
		},
		scroll : true,
		scrollHeight : 180
	};
	a.Autocompleter.Cache = function(c) {
		var f = {};
		var d = 0;
		function k(n, m) {
			if (!c.matchCase) {
				n = n.toLowerCase()
			}
			var l = n.indexOf(m);
			if (c.matchContains == "word") {
				l = n.toLowerCase().search("\\b" + m.toLowerCase())
			}
			if (l == -1) {
				return false
			}
			return l == 0 || c.matchContains
		}
		function g(m, l) {
			if (d > c.cacheLength) {
				b()
			}
			if (!f[m]) {
				d++
			}
			f[m] = l
		}
		function e() {
			if (!c.data) {
				return false
			}
			var m = {}, l = 0;
			if (!c.url) {
				c.cacheLength = 1
			}
			m[""] = [];
			for ( var o = 0, n = c.data.length; o < n; o++) {
				var r = c.data[o];
				r = (typeof r == "string") ? [ r ] : r;
				var q = c.formatMatch(r, o + 1, c.data.length);
				if (q === false) {
					continue
				}
				var p = q.charAt(0).toLowerCase();
				if (!m[p]) {
					m[p] = []
				}
				var s = {
					value : q,
					data : r,
					result : c.formatResult && c.formatResult(r) || q
				};
				m[p].push(s);
				if (l++ < c.max) {
					m[""].push(s)
				}
			}
			a.each(m, function(t, u) {
				c.cacheLength++;
				g(t, u)
			})
		}
		setTimeout(e, 25);
		function b() {
			f = {};
			d = 0
		}
		return {
			flush : b,
			add : g,
			populate : e,
			load : function(o) {
				if (!c.cacheLength || !d) {
					return null
				}
				if (!c.url && c.matchContains) {
					var n = [];
					for ( var l in f) {
						if (l.length > 0) {
							var p = f[l];
							a.each(p, function(r, q) {
								if (k(q.value, o)) {
									n.push(q)
								}
							})
						}
					}
					return n
				} else {
					if (f[o]) {
						return f[o]
					} else {
						if (c.matchSubset) {
							for ( var m = o.length - 1; m >= c.minChars; m--) {
								var p = f[o.substr(0, m)];
								if (p) {
									var n = [];
									a.each(p, function(r, q) {
										if (k(q.value, o)) {
											n[n.length] = q
										}
									});
									return n
								}
							}
						}
					}
				}
				return null
			}
		}
	};
	a.Autocompleter.Select = function(e, m, o, s) {
		var l = {
			ACTIVE : "ac_over"
		};
		var n, f = -1, u, p = "", v = true, c, r;
		function q() {
			if (!v) {
				return
			}
			c = a("<div/>").hide().addClass(e.resultsClass).css("position",
					"absolute").appendTo(document.body);
			r = a("<ul/>").appendTo(c).mouseover(function(x) {
				if (t(x).nodeName && t(x).nodeName.toUpperCase() == "LI") {
					f = a("li", r).removeClass(l.ACTIVE).index(t(x));
					a(t(x)).addClass(l.ACTIVE)
				}
			}).click(function(x) {
				a(t(x)).addClass(l.ACTIVE);
				o();
				m.focus();
				return false
			}).mousedown(function() {
				s.mouseDownOnSelect = true
			}).mouseup(function() {
				s.mouseDownOnSelect = false
			});
			if (e.width > 0) {
				c.css("width", e.width)
			}
			v = false
		}
		function t(y) {
			var x = y.target;
			while (x && x.tagName != "LI") {
				x = x.parentNode
			}
			if (!x) {
				return []
			}
			return x
		}
		function k(x) {
			n.slice(f, f + 1).removeClass(l.ACTIVE);
			g(x);
			var z = n.slice(f, f + 1).addClass(l.ACTIVE);
			if (e.scroll) {
				var y = 0;
				n.slice(0, f).each(function() {
					y += this.offsetHeight
				});
				if ((y + z[0].offsetHeight - r.scrollTop()) > r[0].clientHeight) {
					r.scrollTop(y + z[0].offsetHeight - r.innerHeight())
				} else {
					if (y < r.scrollTop()) {
						r.scrollTop(y)
					}
				}
			}
		}
		function g(x) {
			f += x;
			if (f < 0) {
				f = n.size() - 1
			} else {
				if (f >= n.size()) {
					f = 0
				}
			}
		}
		function b(x) {
			return e.max && e.max < x ? e.max : x
		}
		function d() {
			r.empty();
			var y = b(u.length);
			for ( var z = 0; z < y; z++) {
				if (!u[z]) {
					continue
				}
				var A = e.formatItem(u[z].data, z + 1, y, u[z].value, p);
				if (A === false) {
					continue
				}
				var x = a("<li/>").html(e.highlight(A, p)).addClass(
						z % 2 == 0 ? "ac_even" : "ac_odd").appendTo(r)[0];
				a.data(x, "ac_data", u[z])
			}
			n = r.find("li");
			if (e.selectFirst) {
				n.slice(0, 1).addClass(l.ACTIVE);
				f = 0
			}
			if (a.fn.bgiframe) {
				r.bgiframe()
			}
		}
		return {
			display : function(y, x) {
				q();
				u = y;
				p = x;
				d()
			},
			next : function() {
				k(1)
			},
			prev : function() {
				k(-1)
			},
			pageUp : function() {
				if (f != 0 && f - 8 < 0) {
					k(-f)
				} else {
					k(-8)
				}
			},
			pageDown : function() {
				if (f != n.size() - 1 && f + 8 > n.size()) {
					k(n.size() - 1 - f)
				} else {
					k(8)
				}
			},
			hide : function() {
				c && c.hide();
				n && n.removeClass(l.ACTIVE);
				f = -1
			},
			visible : function() {
				return c && c.is(":visible")
			},
			current : function() {
				return this.visible()
						&& (n.filter("." + l.ACTIVE)[0] || e.selectFirst
								&& n[0])
			},
			show : function() {
				var z = a(m).offset();
				c
						.css(
								{
									width : typeof e.width == "string"
											|| e.width > 0 ? e.width : a(m)
											.width(),
									top : z.top + m.offsetHeight,
									left : z.left
								}).show();
				if (e.scroll) {
					r.scrollTop(0);
					r.css({
						maxHeight : e.scrollHeight,
						overflow : "auto"
					});
					if (a.browser.msie
							&& typeof document.body.style.maxHeight === "undefined") {
						var x = 0;
						n.each(function() {
							x += this.offsetHeight
						});
						var y = x > e.scrollHeight;
						r.css("height", y ? e.scrollHeight : x);
						if (!y) {
							n.width(r.width() - parseInt(n.css("padding-left"))
									- parseInt(n.css("padding-right")))
						}
					}
				}
			},
			selected : function() {
				var x = n && n.filter("." + l.ACTIVE).removeClass(l.ACTIVE);
				return x && x.length && a.data(x[0], "ac_data")
			},
			emptyList : function() {
				r && r.empty()
			},
			unbind : function() {
				c && c.remove()
			}
		}
	};
	a.fn.selection = function(l, b) {
		if (l !== undefined) {
			return this.each(function() {
				if (this.createTextRange) {
					var m = this.createTextRange();
					if (b === undefined || l == b) {
						m.move("character", l);
						m.select()
					} else {
						m.collapse(true);
						m.moveStart("character", l);
						m.moveEnd("character", b);
						m.select()
					}
				} else {
					if (this.setSelectionRange) {
						this.setSelectionRange(l, b)
					} else {
						if (this.selectionStart) {
							this.selectionStart = l;
							this.selectionEnd = b
						}
					}
				}
			})
		}
		var g = this[0];
		if (g.createTextRange) {
			var c = document.selection.createRange(), k = g.value, f = "<->", d = c.text.length;
			c.text = f;
			var e = g.value.indexOf(f);
			g.value = k;
			this.selection(e, e + d);
			return {
				start : e,
				end : e + d
			}
		} else {
			if (g.selectionStart !== undefined) {
				return {
					start : g.selectionStart,
					end : g.selectionEnd
				}
			}
		}
	}
})(jQuery);

(function(a) {
	a.extend({
		tablesorterPager : new function() {
			function m(o) {
				var n = a(o.cssPageDisplay, o.container).val(
						(o.page + 1) + o.seperator + o.totalPages)
			}
			function b(o, n) {
				var p = o.config;
				p.size = n;
				p.totalPages = Math.ceil(p.totalRows / p.size);
				p.pagerPositionSet = false;
				d(o);
				e(o)
			}
			function e(n) {
				var q = n.config;
				if (!q.pagerPositionSet && q.positionFixed) {
					var q = n.config, p = a(n);
					if (p.offset) {
						q.container.css({
							top : p.offset().top + p.height() + "px",
							position : "absolute"
						})
					}
					q.pagerPositionSet = true
				}
			}
			function f(n) {
				var o = n.config;
				o.page = 0;
				d(n)
			}
			function c(n) {
				var o = n.config;
				o.page = (o.totalPages - 1);
				d(n)
			}
			function l(n) {
				var o = n.config;
				o.page++;
				if (o.page >= (o.totalPages - 1)) {
					o.page = (o.totalPages - 1)
				}
				d(n)
			}
			function g(n) {
				var o = n.config;
				o.page--;
				if (o.page <= 0) {
					o.page = 0
				}
				d(n)
			}
			function d(n) {
				var o = n.config;
				if (o.page < 0 || o.page > (o.totalPages - 1)) {
					o.page = 0
				}
				k(n, o.rowsCopy)
			}
			function k(x, y) {
				var v = x.config;
				var q = y.length;
				var z = (v.page * v.size);
				var u = (z + v.size);
				if (u > y.length) {
					u = y.length
				}
				var p = a(x.tBodies[0]);
				a.tablesorter.clearTableBody(x);
				for ( var t = z; t < u; t++) {
					var n = y[t];
					var q = n.length;
					for ( var r = 0; r < q; r++) {
						p[0].appendChild(n[r])
					}
				}
				e(x, p);
				a(x).trigger("applyWidgets");
				if (v.page >= v.totalPages) {
					c(x)
				}
				m(v)
			}
			this.appender = function(n, o) {
				var p = n.config;
				p.rowsCopy = o;
				p.totalRows = o.length;
				p.totalPages = Math.ceil(p.totalRows / p.size);
				k(n, o)
			};
			this.defaults = {
				size : 25,
				offset : 0,
				page : 0,
				totalRows : 0,
				totalPages : 0,
				container : null,
				cssNext : ".next",
				cssPrev : ".prev",
				cssFirst : ".first",
				cssLast : ".last",
				cssPageDisplay : ".pagedisplay",
				cssPageSize : ".pagesize",
				seperator : "/",
				positionFixed : true,
				appender : this.appender
			};
			this.construct = function(n) {
				return this.each(function() {
					config = a.extend(this.config, a.tablesorterPager.defaults,
							n);
					var p = this, o = config.container;
					a(this).trigger("appendCache");
					config.size = parseInt(a(".pagesize", o).val());
					a(config.cssFirst, o).click(function() {
						f(p);
						return false
					});
					a(config.cssNext, o).click(function() {
						l(p);
						return false
					});
					a(config.cssPrev, o).click(function() {
						g(p);
						return false
					});
					a(config.cssLast, o).click(function() {
						c(p);
						return false
					});
					a(config.cssPageSize, o).change(function() {
						b(p, parseInt(a(this).val()));
						return false
					})
				})
			}
		}
	});
	a.fn.extend({
		tablesorterPager : a.tablesorterPager.construct
	})
})(jQuery);

/*
 * jquery.qtip. The jQuery tooltip plugin
 *
 * Copyright (c) 2009 Craig Thompson
 * http://craigsworks.com
 *
 * Licensed under MIT
 * http://www.opensource.org/licenses/mit-license.php
 *
 * Launch  : February 2009
 * Version : 1.0.0-rc2
 * Released: Monday 27th April, 2009 - 23:30
 * Debug: jquery.qtip.debug.js
 */
(function(f){f.fn.qtip=function(D,x){var B,v,C,u,A,z,y;if(!x){x=false}if(typeof D=="string"){if(D=="api"){if(typeof f(this).eq(0).data("qtip")=="object"){return f(this).eq(0).data("qtip")}else{f.fn.qtip.log.error.call(self,1,f.fn.qtip.constants.NO_TOOLTIP_PRESENT,false)}}}else{if(!D){D={}}if(typeof D.content!=="object"){D.content={text:D.content}}if(typeof D.content.title!=="object"){D.content.title={text:D.content.title}}if(typeof D.position!=="object"){D.position={corner:D.position}}if(typeof D.position.corner!=="object"){D.position.corner={target:D.position.corner,tooltip:D.position.corner}}if(typeof D.show!=="object"){D.show={when:D.show}}if(typeof D.show.when!=="object"){D.show.when={event:D.show.when}}if(typeof D.show.effect!=="object"){D.show.effect={type:D.show.effect}}if(typeof D.hide!=="object"){D.hide={when:D.hide}}if(typeof D.hide.when!=="object"){D.hide.when={event:D.hide.when}}if(typeof D.hide.effect!=="object"){D.hide.effect={type:D.hide.effect}}if(typeof D.style!=="object"){D.style={name:D.style}}D.style=c(D.style);u=f.extend(true,{},f.fn.qtip.defaults,D);u.style=a.call({options:u},u.style);u.user=f.extend(true,{},D)}return f(this).each(function(){if(typeof D=="string"){z=D.toLowerCase();C=f(this).data("interfaces");if(typeof C=="object"){if(x&&z=="destroy"){while(C.length>0){C[C.length-1].destroy()}}else{if(x===false){C=[C[C.length-1]]}for(B=0;B<C.length;B++){if(z=="destroy"){C[B].destroy()}else{if(C[B].status.rendered===true){if(z=="show"){C[B].show()}else{if(z=="hide"){C[B].hide()}else{if(z=="focus"){C[B].focus()}else{if(z=="disable"){C[B].disable(true)}else{if(z=="enable"){C[B].disable(false)}}}}}}}}}}}else{y=f.extend(true,{},u);y.hide.effect.length=u.hide.effect.length;y.show.effect.length=u.show.effect.length;if(y.position.container===false){y.position.container=f(document.body)}if(y.position.target===false){y.position.target=f(this)}if(y.show.when.target===false){y.show.when.target=f(this)}if(y.hide.when.target===false){y.hide.when.target=f(this)}v=f.fn.qtip.interfaces.length;for(B=0;B<v;B++){if(typeof f.fn.qtip.interfaces[B]=="undefined"){v=B;break}}A=new d(f(this),y,v);f.fn.qtip.interfaces[v]=A;f(this).data("qtip",A);if(f(this).data("interfaces")){f(this).data("interfaces").push(A)}else{f(this).data("interfaces",[A])}}})};function d(x,v,y){var u=this;u.id=y;u.options=v;u.status={rendered:false,disabled:false,focused:false};u.elements={target:x.addClass(u.options.style.classes.target),tooltip:null,wrapper:null,content:null,contentWrapper:null,title:null,tip:null,bgiframe:null};u.cache={mouse:{},position:{}};u.timers={};f.extend(u,u.options.api,{show:function(B){var A,C;if(!u.status.rendered){f.fn.qtip.log.error.call(u,2,f.fn.qtip.constants.TOOLTIP_NOT_RENDERED,"show");return u}if(u.elements.tooltip.css("display")!=="none"){return u}u.elements.tooltip.stop(true,true);A=u.beforeShow.call(u,B);if(A===false){return u}function z(){if(u.options.position.type!=="static"){u.focus()}u.onShow.call(u,B);if(f.browser.msie){u.elements.tooltip.get(0).style.removeAttribute("filter")}}if(typeof u.options.show.when.target.data("qtip-toggle")=="number"){u.options.show.when.target.data("qtip-toggle",1)}if(u.options.position.type!=="static"){u.updatePosition(B,(u.options.show.effect.length>0))}if(typeof u.options.show.solo=="object"){C=f(u.options.show.solo)}else{if(u.options.show.solo===true){C=f("div.qtip").not(u.elements.tooltip)}}if(C){C.each(function(){if(f(this).qtip("api").status.rendered===true){f(this).qtip("api").hide()}})}if(typeof u.options.show.effect.type=="function"){u.options.show.effect.type.call(u.elements.tooltip,u.options.show.effect.length);u.elements.tooltip.queue(function(){z();f(this).dequeue()})}else{switch(u.options.show.effect.type.toLowerCase()){case"fade":u.elements.tooltip.fadeIn(u.options.show.effect.length,z);break;case"slide":u.elements.tooltip.slideDown(u.options.show.effect.length,function(){z();if(u.options.position.type!=="static"){u.updatePosition(B,true)}});break;case"grow":u.elements.tooltip.show(u.options.show.effect.length,z);break;default:u.elements.tooltip.show(null,z);break}u.elements.tooltip.addClass(u.options.style.classes.active)}u.onShow.call(u,B);f.fn.qtip.log.error.call(u,1,f.fn.qtip.constants.EVENT_SHOWN,"show");return u},hide:function(B){var A;if(!u.status.rendered){f.fn.qtip.log.error.call(u,2,f.fn.qtip.constants.TOOLTIP_NOT_RENDERED,"hide");return u}if(u.elements.tooltip.css("display")==="none"){return u}clearTimeout(u.timers.show);u.elements.tooltip.stop(true,true);A=u.beforeHide.call(u,B);if(A===false){return u}function z(){u.onHide.call(u,B)}if(typeof u.options.show.when.target.data("qtip-toggle")=="number"){u.options.show.when.target.data("qtip-toggle",0)}if(typeof u.options.hide.effect.type=="function"){u.options.hide.effect.type.call(u.elements.tooltip,u.options.hide.effect.length);u.elements.tooltip.queue(function(){z();f(this).dequeue()})}else{switch(u.options.hide.effect.type.toLowerCase()){case"fade":u.elements.tooltip.fadeOut(u.options.hide.effect.length,z);break;case"slide":u.elements.tooltip.slideUp(u.options.hide.effect.length,z);break;case"grow":u.elements.tooltip.hide(u.options.hide.effect.length,z);break;default:u.elements.tooltip.hide(null,z);break}u.elements.tooltip.removeClass(u.options.style.classes.active)}u.onHide.call(u,B);f.fn.qtip.log.error.call(u,1,f.fn.qtip.constants.EVENT_HIDDEN,"hide");return u},updatePosition:function(z,A){var F,J,O,M,K,H,B,L,E,G,N,D,I,C;if(!u.status.rendered){f.fn.qtip.log.error.call(u,2,f.fn.qtip.constants.TOOLTIP_NOT_RENDERED,"updatePosition");return u}else{if(u.options.position.type=="static"){f.fn.qtip.log.error.call(u,1,f.fn.qtip.constants.CANNOT_POSITION_STATIC,"updatePosition");return u}}J={position:{left:0,top:0},dimensions:{height:0,width:0},corner:u.options.position.corner.target};O={position:u.getPosition(),dimensions:u.getDimensions(),corner:u.options.position.corner.tooltip};if(u.options.position.target!=="mouse"){if(u.options.position.target.get(0).nodeName.toLowerCase()=="area"){M=u.options.position.target.attr("coords").split(",");for(F=0;F<M.length;F++){M[F]=parseInt(M[F])}K=u.options.position.target.parent("map").attr("name");H=f('img[usemap="#'+K+'"]:first').offset();J.position={left:Math.floor(H.left+M[0]),top:Math.floor(H.top+M[1])};switch(u.options.position.target.attr("shape").toLowerCase()){case"rect":J.dimensions={width:Math.floor(Math.abs(M[2]-M[0])),height:Math.floor(Math.abs(M[3]-M[1]))};break;case"circle":J.dimensions={width:M[2],height:M[2]};J.position.left+=M[2];J.position.top+=M[2];break;case"poly":J.dimensions={width:M[0],height:M[1]};for(F=0;F<M.length;F++){if(F%2==0){if(M[F]>J.dimensions.width){J.dimensions.width=M[F]}if(M[F]<M[0]){J.position.left=Math.floor(H.left+M[F])}}else{if(M[F]>J.dimensions.height){J.dimensions.height=M[F]}if(M[F]<M[1]){J.position.top=Math.floor(H.top+M[F])}}}J.dimensions.width=J.dimensions.width-(J.position.left-H.left);J.dimensions.height=J.dimensions.height-(J.position.top-H.top);break;default:f.fn.qtip.log.error.call(u,4,f.fn.qtip.constants.INVALID_AREA_SHAPE,"updatePosition");return u;break}J.dimensions.width-=2;J.dimensions.height-=2}else{if(u.options.position.target.add(document.body).length!==1){J.position=u.options.position.target.offset();J.dimensions={height:u.options.position.target.outerHeight(),width:u.options.position.target.outerWidth()}}else{J.position={left:f(document).scrollLeft(),top:f(document).scrollTop()};J.dimensions={height:f(window).height(),width:f(window).width()}}}B=f.extend({},J.position);if(J.corner.search(/right/i)!==-1){B.left+=J.dimensions.width}if(J.corner.search(/bottom/i)!==-1){B.top+=J.dimensions.height}if(J.corner.search(/((top|bottom)Middle)|center/)!==-1){B.left+=(J.dimensions.width/2)}if(J.corner.search(/((left|right)Middle)|center/)!==-1){B.top+=(J.dimensions.height/2)}}else{J.position=B={left:u.cache.mouse.x,top:u.cache.mouse.y};J.dimensions={height:1,width:1}}if(O.corner.search(/right/i)!==-1){B.left-=O.dimensions.width}if(O.corner.search(/bottom/i)!==-1){B.top-=O.dimensions.height}if(O.corner.search(/((top|bottom)Middle)|center/)!==-1){B.left-=(O.dimensions.width/2)}if(O.corner.search(/((left|right)Middle)|center/)!==-1){B.top-=(O.dimensions.height/2)}L=(f.browser.msie)?1:0;E=(f.browser.msie&&parseInt(f.browser.version.charAt(0))===6)?1:0;if(u.options.style.border.radius>0){if(O.corner.search(/Left/)!==-1){B.left-=u.options.style.border.radius}else{if(O.corner.search(/Right/)!==-1){B.left+=u.options.style.border.radius}}if(O.corner.search(/Top/)!==-1){B.top-=u.options.style.border.radius}else{if(O.corner.search(/Bottom/)!==-1){B.top+=u.options.style.border.radius}}}if(L){if(O.corner.search(/top/)!==-1){B.top-=L}else{if(O.corner.search(/bottom/)!==-1){B.top+=L}}if(O.corner.search(/left/)!==-1){B.left-=L}else{if(O.corner.search(/right/)!==-1){B.left+=L}}if(O.corner.search(/leftMiddle|rightMiddle/)!==-1){B.top-=1}}if(u.options.position.adjust.screen===true){B=q.call(u,B,J,O)}if(u.options.position.target==="mouse"&&u.options.position.adjust.mouse===true){if(u.options.position.adjust.screen===true&&u.elements.tip){N=u.elements.tip.attr("rel")}else{N=u.options.position.corner.tooltip}B.left+=(N.search(/right/i)!==-1)?-6:6;B.top+=(N.search(/bottom/i)!==-1)?-6:6}if(!u.elements.bgiframe&&f.browser.msie&&parseInt(f.browser.version.charAt(0))==6){f("select, object").each(function(){D=f(this).offset();D.bottom=D.top+f(this).height();D.right=D.left+f(this).width();if(B.top+O.dimensions.height>=D.top&&B.left+O.dimensions.width>=D.left){m.call(u)}})}B.left+=u.options.position.adjust.x;B.top+=u.options.position.adjust.y;I=u.getPosition();if(B.left!=I.left||B.top!=I.top){C=u.beforePositionUpdate.call(u,z);if(C===false){return u}if(A===true){u.elements.tooltip.animate(B,200,"swing")}else{u.elements.tooltip.css(B)}u.onPositionUpdate.call(u,z);if(typeof z!=="undefined"&&z.type&&z.type!=="mousemove"){f.fn.qtip.log.error.call(u,1,f.fn.qtip.constants.EVENT_POSITION_UPDATED,"updatePosition")}}return u},updateWidth:function(z){if(!u.status.rendered){f.fn.qtip.log.error.call(u,2,f.fn.qtip.constants.TOOLTIP_NOT_RENDERED,"updateWidth");return u}if(z&&typeof z!=="number"){f.fn.qtip.log.error.call(u,2,"newWidth must be of type number","updateWidth");return u}if(!z){if(typeof u.options.style.width.value=="number"){z=u.options.style.width.value}else{u.elements.tooltip.css({width:"auto"});u.elements.contentWrapper.siblings().add(u.elements.tip).hide();if(f.browser.msie){u.elements.wrapper.add(u.elements.contentWrapper.children()).css({zoom:"normal"})}z=u.getDimensions().width+1;if(!u.options.style.width.value){if(z>u.options.style.width.max){z=u.options.style.width.max}if(z<u.options.style.width.min){z=u.options.style.width.min}}}}if(z%2!==0){z-=1}u.elements.tooltip.width(z);u.elements.contentWrapper.siblings().add(u.elements.tip).show();if(u.options.style.border.radius){u.elements.tooltip.find(".qtip-betweenCorners").each(function(A){f(this).width(z-(u.options.style.border.radius*2))})}if(f.browser.msie){u.elements.wrapper.add(u.elements.contentWrapper.children()).css({zoom:"1"});u.elements.wrapper.width(z);if(u.elements.bgiframe){u.elements.bgiframe.width(z).height(u.getDimensions.height)}}f.fn.qtip.log.error.call(u,1,f.fn.qtip.constants.EVENT_WIDTH_UPDATED,"updateWidth");return u},updateStyle:function(z){var C,D,A,B,E;if(!u.status.rendered){f.fn.qtip.log.error.call(u,2,f.fn.qtip.constants.TOOLTIP_NOT_RENDERED,"updateStyle");return u}if(typeof z!=="string"||!f.fn.qtip.styles[z]){f.fn.qtip.log.error.call(u,2,f.fn.qtip.constants.STYLE_NOT_DEFINED,"updateStyle");return u}u.options.style=a.call(u,f.fn.qtip.styles[z],u.options.user.style);u.elements.content.css(s(u.options.style));if(u.options.content.title.text!==false){u.elements.title.css(s(u.options.style.title,true))}u.elements.contentWrapper.css({borderColor:u.options.style.border.color});if(u.options.style.tip.corner!==false){if(f("<canvas>").get(0).getContext){C=u.elements.tooltip.find(".qtip-tip canvas:first");A=C.get(0).getContext("2d");A.clearRect(0,0,300,300);B=C.parent("div[rel]:first").attr("rel");E=b(B,u.options.style.tip.size.width,u.options.style.tip.size.height);k.call(u,C,E,u.options.style.tip.color||u.options.style.border.color)}else{if(f.browser.msie){C=u.elements.tooltip.find('.qtip-tip [nodeName="shape"]');C.attr("fillcolor",u.options.style.tip.color||u.options.style.border.color)}}}if(u.options.style.border.radius>0){u.elements.tooltip.find(".qtip-betweenCorners").css({backgroundColor:u.options.style.border.color});if(f("<canvas>").get(0).getContext){D=g(u.options.style.border.radius);u.elements.tooltip.find(".qtip-wrapper canvas").each(function(){A=f(this).get(0).getContext("2d");A.clearRect(0,0,300,300);B=f(this).parent("div[rel]:first").attr("rel");t.call(u,f(this),D[B],u.options.style.border.radius,u.options.style.border.color)})}else{if(f.browser.msie){u.elements.tooltip.find('.qtip-wrapper [nodeName="arc"]').each(function(){f(this).attr("fillcolor",u.options.style.border.color)})}}}f.fn.qtip.log.error.call(u,1,f.fn.qtip.constants.EVENT_STYLE_UPDATED,"updateStyle");return u},updateContent:function(D,B){var C,A,z;if(!u.status.rendered){f.fn.qtip.log.error.call(u,2,f.fn.qtip.constants.TOOLTIP_NOT_RENDERED,"updateContent");return u}else{if(!D){f.fn.qtip.log.error.call(u,2,"You must specify some content with which to update","updateContent");return false}}C=u.beforeContentUpdate.call(u,D);if(typeof C=="string"){D=C}else{if(C===false){return}}if(f.browser.msie){u.elements.contentWrapper.children().css({zoom:"normal"})}if(D.jquery&&D.length>0){D.clone(true).appendTo(u.elements.content)}else{u.elements.content.html(D)}A=u.elements.content.find("img[complete=false]");if(A.length>0){z=0;A.each(function(F){f('<img src="'+f(this).attr("src")+'" />').load(function(){if(++z==A.length){E()}})})}else{E()}function E(){u.updateWidth();if(B!==false){if(u.options.position.type!=="static"){u.updatePosition(u.elements.tooltip.is(":visible"),true)}if(u.options.style.tip.corner!==false){p.call(u)}}}u.onContentUpdate.call(u);f.fn.qtip.log.error.call(u,1,f.fn.qtip.constants.EVENT_CONTENT_UPDATED,"loadContent");return u},loadContent:function(z,C,D){var B;if(!u.status.rendered){f.fn.qtip.log.error.call(u,2,f.fn.qtip.constants.TOOLTIP_NOT_RENDERED,"loadContent");return u}B=u.beforeContentLoad.call(u);if(B===false){return u}if(D=="post"){f.post(z,C,A)}else{f.get(z,C,A)}function A(E){u.onContentLoad.call(u);f.fn.qtip.log.error.call(u,1,f.fn.qtip.constants.EVENT_CONTENT_LOADED,"loadContent");u.updateContent(E)}return u},focus:function(C){var A,z,B;if(!u.status.rendered){f.fn.qtip.log.error.call(u,2,f.fn.qtip.constants.TOOLTIP_NOT_RENDERED,"focus");return u}else{if(u.options.position.type=="static"){f.fn.qtip.log.error.call(u,1,f.fn.qtip.constants.CANNOT_FOCUS_STATIC,"focus");return u}}A=parseInt(u.elements.tooltip.css("z-index"));z=6000+f(".qtip").length-1;if(!u.status.focussed&&A!==z){B=u.beforeFocus.call(u,C);if(B===false){return u}f(".qtip").not(u.elements.tooltip).each(function(){if(f(this).qtip("api").status.rendered===true){if(typeof parseInt(f(this).css("z-index"))=="number"){f(this).css({zIndex:parseInt(f(this).css("z-index"))-1})}f(this).qtip("api").status.focused=false}});u.elements.tooltip.css({zIndex:z});u.status.focused=true;u.onFocus.call(u,C);f.fn.qtip.log.error.call(u,1,f.fn.qtip.constants.EVENT_FOCUSED,"focus")}return u},disable:function(z){if(!u.status.rendered){f.fn.qtip.log.error.call(u,2,f.fn.qtip.constants.TOOLTIP_NOT_RENDERED,"disable");return u}if(z){if(!u.status.disabled){u.status.disabled=true;f.fn.qtip.log.error.call(u,1,f.fn.qtip.constants.EVENT_DISABLED,"disable")}else{f.fn.qtip.log.error.call(u,1,f.fn.qtip.constants.TOOLTIP_ALREADY_DISABLED,"disable")}}else{if(u.status.disabled){u.status.disabled=false;f.fn.qtip.log.error.call(u,1,f.fn.qtip.constants.EVENT_ENABLED,"disable")}else{f.fn.qtip.log.error.call(u,1,f.fn.qtip.constants.TOOLTIP_ALREADY_ENABLED,"disable")}}return u},destroy:function(){var z,A,B;A=u.beforeDestroy.call(u);if(A===false){return u}if(u.status.rendered){u.options.show.when.target.unbind("mousemove.qtip",u.updatePosition);u.options.show.when.target.unbind("mouseout.qtip",u.hide);u.options.show.when.target.unbind(u.options.show.when.event+".qtip");u.options.show.when.target.removeData("qtip-toggle");u.options.hide.when.target.unbind(u.options.hide.when.event+".qtip");u.elements.tooltip.unbind(u.options.hide.when.event+".qtip");u.elements.tooltip.unbind("mouseover.qtip",u.focus);u.elements.tooltip.remove()}else{u.options.show.when.target.unbind(u.options.show.when.event+".qtip-create")}B=u.elements.target.data("interfaces");if(typeof B=="object"&&B.length>0){for(z=0;z<B.length-1;z++){if(B[z].id==u.id){B.splice(z,1)}}}delete f.fn.qtip.interfaces[u.id];if(typeof B=="object"&&B.length>0){u.elements.target.data("qtip",B[B.length-1])}else{u.elements.target.removeData("qtip")}u.onDestroy.call(u);f.fn.qtip.log.error.call(u,1,f.fn.qtip.constants.EVENT_DESTROYED,"destroy");return u.elements.target},getPosition:function(){var z,A;if(!u.status.rendered){f.fn.qtip.log.error.call(u,2,f.fn.qtip.constants.TOOLTIP_NOT_RENDERED,"getPosition");return u}z=(u.elements.tooltip.css("display")!=="none")?false:true;if(z){u.elements.tooltip.css({visiblity:"hidden"}).show()}A=u.elements.tooltip.offset();if(z){u.elements.tooltip.css({visiblity:"visible"}).hide()}return A},getDimensions:function(){var z,A;if(!u.status.rendered){f.fn.qtip.log.error.call(u,2,f.fn.qtip.constants.TOOLTIP_NOT_RENDERED,"getDimensions");return u}z=(!u.elements.tooltip.is(":visible"))?true:false;if(z){u.elements.tooltip.css({visiblity:"hidden"}).show()}A={height:u.elements.tooltip.outerHeight(),width:u.elements.tooltip.outerWidth()};if(z){u.elements.tooltip.css({visiblity:"visible"}).hide()}return A}});r.call(u)}function r(){var u,y,v;u=this;if(u.options.content.prerender===false&&u.options.show.when.event!==false&&u.options.show.ready!==true){y=u.options.show.when.target;v=u.options.show.when.event;y.bind(v+".qtip-create",function(z){y.unbind(v+".qtip-create");x();u.cache.mouse={x:z.pageX,y:z.pageY};y.trigger(v)})}else{x()}function x(){var C,A,z,B,E,D;u.status.rendered=true;u.beforeRender.call(u);u.elements.tooltip='<div qtip="'+u.id+'" class="qtip '+(u.options.style.classes.tooltip||u.options.style)+'"style="display:none; -moz-border-radius:0; -webkit-border-radius:0; border-radius:0;position:'+u.options.position.type+';">  <div class="qtip-wrapper" style="position:relative; overflow:hidden; text-align:left;">    <div class="qtip-contentWrapper" style="overflow:hidden;">       <div class="qtip-content '+u.options.style.classes.content+'"></div></div></div></div>';u.elements.tooltip=f(u.elements.tooltip);u.elements.tooltip.appendTo(u.options.position.container).data("qtip",u);u.elements.wrapper=u.elements.tooltip.children("div:first").css({zoom:(f.browser.msie)?1:0});u.elements.contentWrapper=u.elements.wrapper.children("div:first").css({background:u.options.style.background});u.elements.content=u.elements.contentWrapper.children("div:first").css(s(u.options.style)).css({zoom:(f.browser.msie)?1:0});if(typeof u.options.style.width.value=="number"){u.updateWidth()}if(f("<canvas>").get(0).getContext||f.browser.msie){if(u.options.style.border.radius>0){o.call(u)}else{u.elements.contentWrapper.css({border:u.options.style.border.width+"px solid "+u.options.style.border.color})}if(u.options.style.tip.corner!==false){e.call(u)}}else{u.elements.contentWrapper.css({border:u.options.style.border.width+"px solid "+u.options.style.border.color});u.options.style.border.radius=0;u.options.style.tip.corner=false;f.fn.qtip.log.error.call(u,2,f.fn.qtip.constants.CANVAS_VML_NOT_SUPPORTED,"render")}if(typeof u.options.content.text=="string"){A=u.options.content.text}else{if(u.options.content.text.jquery&&u.options.content.text.length>0){A=u.options.content.text}else{if(u.options.content.text===false){A=u.elements.target.attr("title").replace("\\n","<br />");u.elements.target.attr("title","")}else{A="&nbsp;";f.fn.qtip.log.error.call(u,1,f.fn.qtip.constants.NO_VALID_CONTENT,"render")}}}if(u.options.content.title.text!==false){l.call(u)}u.updateContent(A);if(u.options.content.url!==false){z=u.options.content.url;B=u.options.content.data;E=u.options.content.method||"get";u.loadContent(z,B,E)}n.call(u);if(u.options.show.ready===true){u.show()}u.onRender.call(u);f.fn.qtip.log.error.call(u,1,f.fn.qtip.constants.EVENT_RENDERED,"render")}}function o(){var I,C,v,E,A,H,x,J,G,B,z,F,D,u,y;I=this;I.elements.wrapper.find(".qtip-borderBottom, .qtip-borderTop").remove();v=I.options.style.border.width;E=I.options.style.border.radius;A=I.options.style.border.color||I.options.style.tip.color;H=g(E);x={};for(C in H){x[C]='<div rel="'+C+'" style="'+((C.search(/Left/)!==-1)?"left":"right")+":0; position:absolute; height:"+E+"px; width:"+E+'px; overflow:hidden; line-height:0.1px; font-size:1px">';if(f("<canvas>").get(0).getContext){x[C]+='<canvas height="'+E+'" width="'+E+'" style="vertical-align: top"></canvas>'}else{if(f.browser.msie){J=E*2+3;x[C]+='<v:arc stroked="false" fillcolor="'+A+'" startangle="'+H[C][0]+'" endangle="'+H[C][1]+'" style="width:'+J+"px; height:"+J+"px; margin-top:"+((C.search(/bottom/)!==-1)?-2:-1)+"px; margin-left:"+((C.search(/Right/)!==-1)?H[C][2]-3.5:-1)+'px; vertical-align:top; display:inline-block; behavior:url(#default#VML)"></v:arc>'}}x[C]+="</div>"}G=I.getDimensions().width-(Math.max(v,E)*2);B='<div class="qtip-betweenCorners" style="height:'+E+"px; width:"+G+"px; overflow:hidden; background-color:"+A+'; line-height:0.1px; font-size:1px;">';z='<div class="qtip-borderTop" dir="ltr" style="height:'+E+"px; margin-left:"+E+'px; line-height:0.1px; font-size:1px; padding:0;">'+x.topLeft+x.topRight+B;I.elements.wrapper.prepend(z);F='<div class="qtip-borderBottom" dir="ltr" style="height:'+E+"px; margin-left:"+E+'px; line-height:0.1px; font-size:1px; padding:0;">'+x.bottomLeft+x.bottomRight+B;I.elements.wrapper.append(F);if(f("<canvas>").get(0).getContext){I.elements.wrapper.find("canvas").each(function(){D=H[f(this).parent("[rel]:first").attr("rel")];t.call(I,f(this),D,E,A)})}else{if(f.browser.msie){I.elements.tooltip.append('<v:image style="behavior:url(#default#VML);"></v:image>')}}u=Math.max(E,(E+(v-E)));y=Math.max(v-E,0);I.elements.contentWrapper.css({border:"0px solid "+A,borderWidth:y+"px "+u+"px"})}function t(x,z,u,v){var y=x.get(0).getContext("2d");y.fillStyle=v;y.beginPath();y.arc(z[0],z[1],u,0,Math.PI*2,false);y.fill()}function e(y){var v,u,A,x,z;v=this;if(v.elements.tip!==null){v.elements.tip.remove()}u=v.options.style.tip.color||v.options.style.border.color;if(v.options.style.tip.corner===false){return}else{if(!y){y=v.options.style.tip.corner}}A=b(y,v.options.style.tip.size.width,v.options.style.tip.size.height);v.elements.tip='<div class="'+v.options.style.classes.tip+'" dir="ltr" rel="'+y+'" style="position:absolute; height:'+v.options.style.tip.size.height+"px; width:"+v.options.style.tip.size.width+'px; margin:0 auto; line-height:0.1px; font-size:1px;">';if(f("<canvas>").get(0).getContext){v.elements.tip+='<canvas height="'+v.options.style.tip.size.height+'" width="'+v.options.style.tip.size.width+'"></canvas>'}else{if(f.browser.msie){x=v.options.style.tip.size.width+","+v.options.style.tip.size.height;z="m"+A[0][0]+","+A[0][1];z+=" l"+A[1][0]+","+A[1][1];z+=" "+A[2][0]+","+A[2][1];z+=" xe";v.elements.tip+='<v:shape fillcolor="'+u+'" stroked="false" filled="true" path="'+z+'" coordsize="'+x+'" style="width:'+v.options.style.tip.size.width+"px; height:"+v.options.style.tip.size.height+"px; line-height:0.1px; display:inline-block; behavior:url(#default#VML); vertical-align:"+((y.search(/top/)!==-1)?"bottom":"top")+'"></v:shape>';v.elements.tip+='<v:image style="behavior:url(#default#VML);"></v:image>';v.elements.contentWrapper.css("position","relative")}}v.elements.tooltip.prepend(v.elements.tip+"</div>");v.elements.tip=v.elements.tooltip.find("."+v.options.style.classes.tip).eq(0);if(f("<canvas>").get(0).getContext){k.call(v,v.elements.tip.find("canvas:first"),A,u)}if(y.search(/top/)!==-1&&f.browser.msie&&parseInt(f.browser.version.charAt(0))===6){v.elements.tip.css({marginTop:-4})}p.call(v,y)}function k(v,y,u){var x=v.get(0).getContext("2d");x.fillStyle=u;x.beginPath();x.moveTo(y[0][0],y[0][1]);x.lineTo(y[1][0],y[1][1]);x.lineTo(y[2][0],y[2][1]);x.fill()}function p(y){var v,A,u,B,x,z;v=this;if(v.options.style.tip.corner===false||!v.elements.tip){return}if(!y){y=v.elements.tip.attr("rel")}A=positionAdjust=(f.browser.msie)?1:0;v.elements.tip.css(y.match(/left|right|top|bottom/)[0],0);if(y.search(/top|bottom/)!==-1){if(f.browser.msie){if(parseInt(f.browser.version.charAt(0))===6){positionAdjust=(y.search(/top/)!==-1)?-3:1}else{positionAdjust=(y.search(/top/)!==-1)?1:2}}if(y.search(/Middle/)!==-1){v.elements.tip.css({left:"50%",marginLeft:-(v.options.style.tip.size.width/2)})}else{if(y.search(/Left/)!==-1){v.elements.tip.css({left:v.options.style.border.radius-A})}else{if(y.search(/Right/)!==-1){v.elements.tip.css({right:v.options.style.border.radius+A})}}}if(y.search(/top/)!==-1){v.elements.tip.css({top:-positionAdjust})}else{v.elements.tip.css({bottom:positionAdjust})}}else{if(y.search(/left|right/)!==-1){if(f.browser.msie){positionAdjust=(parseInt(f.browser.version.charAt(0))===6)?1:((y.search(/left/)!==-1)?1:2)}if(y.search(/Middle/)!==-1){v.elements.tip.css({top:"50%",marginTop:-(v.options.style.tip.size.height/2)})}else{if(y.search(/Top/)!==-1){v.elements.tip.css({top:v.options.style.border.radius-A})}else{if(y.search(/Bottom/)!==-1){v.elements.tip.css({bottom:v.options.style.border.radius+A})}}}if(y.search(/left/)!==-1){v.elements.tip.css({left:-positionAdjust})}else{v.elements.tip.css({right:positionAdjust})}}}u="padding-"+y.match(/left|right|top|bottom/)[0];B=v.options.style.tip.size[(u.search(/left|right/)!==-1)?"width":"height"];v.elements.tooltip.css("padding",0);v.elements.tooltip.css(u,B);if(f.browser.msie&&parseInt(f.browser.version.charAt(0))==6){x=parseInt(v.elements.tip.css("margin-top"));z=x+parseInt(v.elements.content.css("margin-top"));v.elements.tip.css({marginTop:z})}}function l(){var u=this;if(u.elements.title!==null){u.elements.title.remove()}u.elements.title=f("<div>").addClass(u.options.style.classes.title).css(s(u.options.style.title,true)).css({zoom:(f.browser.msie)?1:0}).html(u.options.content.title.text).prependTo(u.elements.contentWrapper);if(u.options.content.title.button!==false&&typeof u.options.content.title.button=="string"){f('<a href="#" style="float:right; position:relative;">').attr("href","#").addClass(u.options.style.classes.button).html(u.options.content.title.button).prependTo(u.elements.title).click(function(){if(!u.status.disabled){u.hide()}return false})}}function n(){var v,y,x,u;v=this;y=v.options.show.when.target;x=v.options.hide.when.target;if(v.options.hide.fixed){x=x.add(v.elements.tooltip)}if(v.options.hide.when.event=="inactive"){u=["click","dblclick","mousedown","mouseup","mousemove","mouseout","mouseenter","mouseleave","mouseover"];function B(){if(v.status.disabled===true){return}clearTimeout(v.timers.inactive);v.timers.inactive=setTimeout(function(){f(u).each(function(){x.unbind(this+".qtip-inactive");v.elements.content.unbind(this+".qtip-inactive")});v.hide()},v.options.hide.delay)}}else{if(v.options.hide.fixed===true){v.elements.tooltip.bind("mouseover.qtip",function(){if(v.status.disabled===true){return}clearTimeout(v.timers.hide)})}}function A(C){if(v.status.disabled===true){return}if(v.options.hide.when.event=="inactive"){f(u).each(function(){x.bind(this+".qtip-inactive",B);v.elements.content.bind(this+".qtip-inactive",B)});B()}clearTimeout(v.timers.show);clearTimeout(v.timers.hide);v.timers.show=setTimeout(function(){v.show(C)},v.options.show.delay)}function z(C){if(v.status.disabled===true){return}if(v.options.hide.fixed===true&&v.options.hide.when.event.search(/mouse(out|leave)/i)!==-1&&f(C.relatedTarget).parents(".qtip").length>0){C.stopPropagation();C.preventDefault();clearTimeout(v.timers.hide);return false}clearTimeout(v.timers.show);clearTimeout(v.timers.hide);v.timers.hide=setTimeout(function(){v.hide(C)},v.options.hide.delay)}if((v.options.show.when.target.add(v.options.hide.when.target).length===1&&v.options.show.when.event==v.options.hide.when.event&&v.options.hide.when.event!=="inactive")||v.options.hide.when.event=="unfocus"){y.data("qtip-toggle",0);if(v.options.hide.when.event=="unfocus"){v.elements.tooltip.attr("unfocus",true)}y.bind(v.options.show.when.event+".qtip",function(C){if(parseInt(f(this).data("qtip-toggle"))===0){A(C)}else{z(C)}})}else{y.bind(v.options.show.when.event+".qtip",A);if(v.options.hide.when.event!=="inactive"){x.bind(v.options.hide.when.event+".qtip",z)}}if(v.options.position.type.search(/(fixed|absolute)/)!==-1){v.elements.tooltip.bind("mouseover.qtip",v.focus)}if(v.options.position.target==="mouse"&&v.options.position.type!=="static"){y.bind("mousemove.qtip",function(C){v.cache.mouse={x:C.pageX,y:C.pageY};if(v.status.disabled===false&&v.options.position.adjust.mouse===true&&v.options.position.type!=="static"&&v.elements.tooltip.css("display")!=="none"){v.updatePosition(C)}})}}function q(u,A,z){var v,C,y,B,x;v=this;if(z.corner=="center"){return A.position}C=f.extend({},u);y={x:false,y:false};B={left:(C.left<f.fn.qtip.cache.screen.scroll.left),right:(C.left+z.dimensions.width+2>=f.fn.qtip.cache.screen.width+f.fn.qtip.cache.screen.scroll.left),top:(C.top<f.fn.qtip.cache.screen.scroll.top),bottom:(C.top+z.dimensions.height+2>=f.fn.qtip.cache.screen.height+f.fn.qtip.cache.screen.scroll.top)};v.cache.position.adjust={left:(B.left&&(z.corner.search(/right/i)!=-1||(z.corner.search(/right/i)==-1&&!B.right))),right:(B.right&&(z.corner.search(/left/i)!=-1||(z.corner.search(/left/i)==-1&&!B.left))),top:(B.top&&z.corner.search(/top/i)==-1),bottom:(B.bottom&&z.corner.search(/bottom/i)==-1)};if(v.cache.position.adjust.left){if(v.options.position.target!=="mouse"){C.left=A.position.left+A.dimensions.width}else{C.left=v.cache.mouse.x}y.x="Left"}else{if(v.cache.position.adjust.right){if(v.options.position.target!=="mouse"){C.left=A.position.left-z.dimensions.width}else{C.left=v.cache.mouse.x-z.dimensions.width}y.x="Right"}}if(v.cache.position.adjust.top){if(v.options.position.target!=="mouse"){C.top=A.position.top+A.dimensions.height}else{C.top=v.cache.mouse.y}y.y="top"}else{if(v.cache.position.adjust.bottom){if(v.options.position.target!=="mouse"){C.top=A.position.top-z.dimensions.height}else{C.top=v.cache.mouse.y-z.dimensions.height}y.y="bottom"}}if(C.left<0){C.left=u.left;y.x=false}if(C.top<0){C.top=u.top;y.y=false}if(v.options.style.tip.corner!==false){C.corner=new String(z.corner);if(y.x!==false){C.corner=C.corner.replace(/Left|Right|Middle/,y.x)}if(y.y!==false){C.corner=C.corner.replace(/top|bottom/,y.y)}if(C.corner!==v.elements.tip.attr("rel")){e.call(v,C.corner)}}return C}function s(v,y){var x,u;x=f.extend(true,{},v);for(u in x){if(y===true&&u.search(/(tip|classes)/i)!==-1){delete x[u]}else{if(u.search(/(width|border|tip|title|classes|user)/i)!==-1){delete x[u]}}}return x}function c(u){if(typeof u.tip!=="object"){u.tip={corner:u.tip}}if(typeof u.tip.size!=="object"){u.tip.size={width:u.tip.size,height:u.tip.size}}if(typeof u.border!=="object"){u.border={width:u.border}}if(typeof u.width!=="object"){u.width={value:u.width}}if(typeof u.width.max=="string"){u.width.max=parseInt(u.width.max.replace(/([0-9]+)/i,"$1"))}if(typeof u.width.min=="string"){u.width.min=parseInt(u.width.min.replace(/([0-9]+)/i,"$1"))}if(typeof u.tip.size.x=="number"){u.tip.size.width=u.tip.size.x;delete u.tip.size.x}if(typeof u.tip.size.y=="number"){u.tip.size.height=u.tip.size.y;delete u.tip.size.y}return u}function a(){var u,v,x,A,y,z;u=this;x=[true,{}];for(v=0;v<arguments.length;v++){x.push(arguments[v])}A=[f.extend.apply(f,x)];while(typeof A[0].name=="string"){A.unshift(c(f.fn.qtip.styles[A[0].name]))}A.unshift(true,{classes:{tooltip:"qtip-"+(arguments[0].name||"defaults")}},f.fn.qtip.styles.defaults);y=f.extend.apply(f,A);z=(f.browser.msie)?1:0;y.tip.size.width+=z;y.tip.size.height+=z;if(y.tip.size.width%2>0){y.tip.size.width+=1}if(y.tip.size.height%2>0){y.tip.size.height+=1}if(y.tip.corner===true){y.tip.corner=(u.options.position.corner.tooltip==="center")?false:u.options.position.corner.tooltip}return y}function b(y,x,v){var u={bottomRight:[[0,0],[x,v],[x,0]],bottomLeft:[[0,0],[x,0],[0,v]],topRight:[[0,v],[x,0],[x,v]],topLeft:[[0,0],[0,v],[x,v]],topMiddle:[[0,v],[x/2,0],[x,v]],bottomMiddle:[[0,0],[x,0],[x/2,v]],rightMiddle:[[0,0],[x,v/2],[0,v]],leftMiddle:[[x,0],[x,v],[0,v/2]]};u.leftTop=u.bottomRight;u.rightTop=u.bottomLeft;u.leftBottom=u.topRight;u.rightBottom=u.topLeft;return u[y]}function g(u){var v;if(f("<canvas>").get(0).getContext){v={topLeft:[u,u],topRight:[0,u],bottomLeft:[u,0],bottomRight:[0,0]}}else{if(f.browser.msie){v={topLeft:[-90,90,0],topRight:[-90,90,-u],bottomLeft:[90,270,0],bottomRight:[90,270,-u]}}}return v}function m(){var u,v,x;u=this;x=u.getDimensions();v='<iframe class="qtip-bgiframe" frameborder="0" tabindex="-1" src="javascript:false" style="display:block; position:absolute; z-index:-1; filter:alpha(opacity=\'0\'); border: 1px solid red; height:'+x.height+"px; width:"+x.width+'px" />';u.elements.bgiframe=u.elements.wrapper.prepend(v).children(".qtip-bgiframe:first")}f(document).ready(function(){f.fn.qtip.cache={screen:{scroll:{left:f(window).scrollLeft(),top:f(window).scrollTop()},width:f(window).width(),height:f(window).height()}};var u;f(window).bind("resize scroll",function(v){clearTimeout(u);u=setTimeout(function(){if(v.type==="scroll"){f.fn.qtip.cache.screen.scroll={left:f(window).scrollLeft(),top:f(window).scrollTop()}}else{f.fn.qtip.cache.screen.width=f(window).width();f.fn.qtip.cache.screen.height=f(window).height()}f(".qtip").each(function(){var x=f(this).qtip("api");if(x.options.position.type!=="static"||x.options.position.adjust.scroll&&v.type==="scroll"||x.options.position.adjust.resize&&v.type==="resize"){x.updatePosition(v,true)}})},100)});f(document).bind("mousedown.qtip",function(v){if(f(v.target).parents("div.qtip").length===0){f(".qtip[unfocus]").each(function(){var x=f(this).qtip("api");if(f(this).is(":visible")&&!x.status.disabled&&f(v.target).add(x.elements.target).length>1){x.hide()}})}})});f.fn.qtip.interfaces=[];f.fn.qtip.log={error:function(){}};f.fn.qtip.constants={};f.fn.qtip.defaults={content:{prerender:false,text:false,url:false,data:null,title:{text:false,button:false}},position:{target:false,corner:{target:"bottomRight",tooltip:"topLeft"},adjust:{x:0,y:0,mouse:true,screen:false,scroll:true,resize:true},type:"absolute",container:false},show:{when:{target:false,event:"mouseover"},effect:{type:"fade",length:100},delay:140,solo:false,ready:false},hide:{when:{target:false,event:"mouseout"},effect:{type:"fade",length:100},delay:0,fixed:false},api:{beforeRender:function(){},onRender:function(){},beforePositionUpdate:function(){},onPositionUpdate:function(){},beforeShow:function(){},onShow:function(){},beforeHide:function(){},onHide:function(){},beforeContentUpdate:function(){},onContentUpdate:function(){},beforeContentLoad:function(){},onContentLoad:function(){},beforeDestroy:function(){},onDestroy:function(){},beforeFocus:function(){},onFocus:function(){}}};f.fn.qtip.styles={defaults:{background:"white",color:"#111",overflow:"hidden",textAlign:"left",width:{min:0,max:250},padding:"5px 9px",border:{width:1,radius:0,color:"#d3d3d3"},tip:{corner:false,color:false,size:{width:13,height:13},opacity:1},title:{background:"#e1e1e1",fontWeight:"bold",padding:"7px 12px"},classes:{target:"",tip:"qtip-tip",title:"qtip-title",content:"qtip-content",active:"qtip-active"}},cream:{border:{width:3,radius:0,color:"#F9E98E"},title:{background:"#F0DE7D",color:"#A27D35"},background:"#FBF7AA",color:"#A27D35",classes:{tooltip:"qtip-cream"}},light:{border:{width:3,radius:0,color:"#E2E2E2"},title:{background:"#f1f1f1",color:"#454545"},background:"white",color:"#454545",classes:{tooltip:"qtip-light"}},dark:{border:{width:3,radius:0,color:"#303030"},title:{background:"#404040",color:"#f3f3f3"},background:"#505050",color:"#f3f3f3",classes:{tooltip:"qtip-dark"}},red:{border:{width:3,radius:0,color:"#CE6F6F"},title:{background:"#f28279",color:"#9C2F2F"},background:"#F79992",color:"#9C2F2F",classes:{tooltip:"qtip-red"}},green:{border:{width:3,radius:0,color:"#A9DB66"},title:{background:"#b9db8c",color:"#58792E"},background:"#CDE6AC",color:"#58792E",classes:{tooltip:"qtip-green"}},blue:{border:{width:3,radius:0,color:"#ADD9ED"},title:{background:"#D0E9F5",color:"#5E99BD"},background:"#E5F6FE",color:"#4D9FBF",classes:{tooltip:"qtip-blue"}}}})(jQuery);
(function(c){var a=c.scrollTo=function(f,e,d){c(window).scrollTo(f,e,d)};a.defaults={axis:"xy",duration:parseFloat(c.fn.jquery)>=1.3?0:1};a.window=function(d){return c(window).scrollable()};c.fn.scrollable=function(){return this.map(function(){var e=this,d=!e.nodeName||c.inArray(e.nodeName.toLowerCase(),["iframe","#document","html","body"])!=-1;if(!d){return e}var f=(e.contentWindow||e).document||e.ownerDocument||e;return c.browser.safari||f.compatMode=="BackCompat"?f.body:f.documentElement})};c.fn.scrollTo=function(f,e,d){if(typeof e=="object"){d=e;e=0}if(typeof d=="function"){d={onAfter:d}}if(f=="max"){f=9000000000}d=c.extend({},a.defaults,d);e=e||d.speed||d.duration;d.queue=d.queue&&d.axis.length>1;if(d.queue){e/=2}d.offset=b(d.offset);d.over=b(d.over);return this.scrollable().each(function(){var p=this,n=c(p),o=f,m,k={},q=n.is("html,body");switch(typeof o){case"number":case"string":if(/^([+-]=)?\d+(\.\d+)?(px)?$/.test(o)){o=b(o);break}o=c(o,this);case"object":if(o.is||o.style){m=(o=c(o)).offset()}}c.each(d.axis.split(""),function(u,v){var x=v=="x"?"Left":"Top",y=x.toLowerCase(),t="scroll"+x,r=p[t],s=v=="x"?"Width":"Height";if(m){k[t]=m[y]+(q?0:r-n.offset()[y]);if(d.margin){k[t]-=parseInt(o.css("margin"+x))||0;k[t]-=parseInt(o.css("border"+x+"Width"))||0}k[t]+=d.offset[y]||0;if(d.over[y]){k[t]+=o[s.toLowerCase()]()*d.over[y]}}else{k[t]=o[y]}if(/^\d+$/.test(k[t])){k[t]=k[t]<=0?0:Math.min(k[t],g(s))}if(!u&&d.queue){if(r!=k[t]){l(d.onAfterFirst)}delete k[t]}});l(d.onAfter);function l(r){n.animate(k,e,d.easing,r&&function(){r.call(this,f,d)})}function g(v){var s="scroll"+v;if(!q){return p[s]}var u="client"+v,t=p.ownerDocument.documentElement,r=p.ownerDocument.body;return Math.max(t[s],r[s])-Math.min(t[u],r[u])}}).end()};function b(d){return typeof d=="object"?d:{top:d,left:d}}})(jQuery);

/*
 * jQuery resize event - v1.1 - 3/14/2010
 * http://benalman.com/projects/jquery-resize-plugin/
 * 
 * Copyright (c) 2010 "Cowboy" Ben Alman
 * Dual licensed under the MIT and GPL licenses.
 * http://benalman.com/about/license/
 */
(function($,h,c){var a=$([]),e=$.resize=$.extend($.resize,{}),i,k="setTimeout",j="resize",d=j+"-special-event",b="delay",f="throttleWindow";e[b]=250;e[f]=true;$.event.special[j]={setup:function(){if(!e[f]&&this[k]){return false}var l=$(this);a=a.add(l);$.data(this,d,{w:l.width(),h:l.height()});if(a.length===1){g()}},teardown:function(){if(!e[f]&&this[k]){return false}var l=$(this);a=a.not(l);l.removeData(d);if(!a.length){clearTimeout(i)}},add:function(l){if(!e[f]&&this[k]){return false}var n;function m(s,o,p){var q=$(this),r=$.data(this,d);r.w=o!==c?o:q.width();r.h=p!==c?p:q.height();n.apply(this,arguments)}if($.isFunction(l)){n=l;return m}else{n=l.handler;l.handler=m}}};function g(){i=h[k](function(){a.each(function(){var n=$(this),m=n.width(),l=n.height(),o=$.data(this,d);if(m!==o.w||l!==o.h){n.trigger(j,[o.w=m,o.h=l])}});g()},e[b])}})(jQuery,this);

//jHtmlArea - http://jhtmlarea.codeplex.com - (c)2009 Chris Pietschmann
(function($){$.fn.htmlarea=function(opts){if(opts&&typeof(opts)==="string"){var args=[];for(var i=1;i<arguments.length;i++){args.push(arguments[i]);}
var htmlarea=jHtmlArea(this[0]);var f=htmlarea[opts];if(f){return f.apply(htmlarea,args);}}
return this.each(function(){jHtmlArea(this,opts);});};var jHtmlArea=window.jHtmlArea=function(elem,options){if(elem.jquery){return jHtmlArea(elem[0]);}
if(elem.jhtmlareaObject){return elem.jhtmlareaObject;}else{return new jHtmlArea.fn.init(elem,options);}};jHtmlArea.fn=jHtmlArea.prototype={jhtmlarea:"0.7.0",init:function(elem,options){if(elem.nodeName.toLowerCase()==="textarea"){var opts=$.extend({},jHtmlArea.defaultOptions,options);elem.jhtmlareaObject=this;var textarea=this.textarea=$(elem);var container=this.container=$("<div/>").addClass("jHtmlArea").width(textarea.width()).insertAfter(textarea);var toolbar=this.toolbar=$("<div/>").addClass("ToolBar").appendTo(container);priv.initToolBar.call(this,opts);var iframe=this.iframe=$("<iframe/>").height(textarea.height());iframe.width(textarea.width()-($.browser.msie?0:4));var htmlarea=this.htmlarea=$("<div/>").append(iframe);container.append(htmlarea).append(textarea.hide());priv.initEditor.call(this,opts);priv.attachEditorEvents.call(this);iframe.height(iframe.height()-toolbar.height());toolbar.width(textarea.width()-2);if(opts.loaded){opts.loaded.call(this);}}},dispose:function(){this.textarea.show().insertAfter(this.container);this.container.remove();this.textarea[0].jhtmlareaObject=null;},execCommand:function(a,b,c){this.iframe[0].contentWindow.focus();this.editor.execCommand(a,b||false,c||null);this.updateTextArea();},ec:function(a,b,c){this.execCommand(a,b,c);},queryCommandValue:function(a){this.iframe[0].contentWindow.focus();return this.editor.queryCommandValue(a);},qc:function(a){return this.queryCommandValue(a);},getSelectedHTML:function(){if($.browser.msie){return this.getRange().htmlText;}else{var elem=this.getRange().cloneContents();return $("<p/>").append($(elem)).html();}},getSelection:function(){if($.browser.msie){return this.editor.selection;}else{return this.iframe[0].contentDocument.defaultView.getSelection();}},getRange:function(){var s=this.getSelection();if(!s){return null;}
return(s.getRangeAt)?s.getRangeAt(0):s.createRange();},html:function(v){if(v){this.pastHTML(v);}else{return toHtmlString();}},pasteHTML:function(html){this.iframe[0].contentWindow.focus();var r=this.getRange();if($.browser.msie){r.pasteHTML(html);}else if($.browser.mozilla){r.deleteContents();r.insertNode($((html.indexOf("<")!=0)?$("<span/>").append(html):html)[0]);}else{r.deleteContents();r.insertNode($(this.iframe[0].contentWindow.document.createElement("span")).append($((html.indexOf("<")!=0)?"<span>"+html+"</span>":html))[0]);}
r.collapse(false);if (typeof r.select=='function'){r.select();}},cut:function(){this.ec("cut");},copy:function(){this.ec("copy");},paste:function(){this.ec("paste");},bold:function(){this.ec("bold");},italic:function(){this.ec("italic");},underline:function(){this.ec("underline");},strikeThrough:function(){this.ec("strikethrough");},image:function(url){if($.browser.msie&&!url){this.ec("insertImage",true);}else{this.ec("insertImage",false,(url||prompt("Image URL:","http://")));}},removeFormat:function(){this.ec("removeFormat",false,[]);this.unlink();},link:function(){if($.browser.msie){this.ec("createLink",true);}else{this.ec("createLink",false,prompt("Link URL:","http://"));}},unlink:function(){this.ec("unlink",false,[]);},orderedList:function(){this.ec("insertorderedlist");},unorderedList:function(){this.ec("insertunorderedlist");},superscript:function(){this.ec("superscript");},subscript:function(){this.ec("subscript");},p:function(){this.formatBlock("<p>");},h1:function(){this.heading(1);},h2:function(){this.heading(2);},h3:function(){this.heading(3);},h4:function(){this.heading(4);},h5:function(){this.heading(5);},h6:function(){this.heading(6);},heading:function(h){this.formatBlock($.browser.msie?"Heading "+h:"h"+h);},indent:function(){this.ec("indent");},outdent:function(){this.ec("outdent");},insertHorizontalRule:function(){this.ec("insertHorizontalRule",false,"ht");},justifyLeft:function(){this.ec("justifyLeft");},justifyCenter:function(){this.ec("justifyCenter");},justifyRight:function(){this.ec("justifyRight");},increaseFontSize:function(){if($.browser.msie){this.ec("fontSize",false,this.qc("fontSize")+1);}else if($.browser.safari){this.getRange().surroundContents($(this.iframe[0].contentWindow.document.createElement("span")).css("font-size","larger")[0]);}else{this.ec("increaseFontSize",false,"big");}},decreaseFontSize:function(){if($.browser.msie){this.ec("fontSize",false,this.qc("fontSize")-1);}else if($.browser.safari){this.getRange().surroundContents($(this.iframe[0].contentWindow.document.createElement("span")).css("font-size","smaller")[0]);}else{this.ec("decreaseFontSize",false,"small");}},forecolor:function(c){this.ec("foreColor",false,c||prompt("Enter HTML Color:","#"));},formatBlock:function(v){this.ec("formatblock",false,v||null);},showHTMLView:function(){this.updateTextArea();this.textarea.show();this.htmlarea.hide();$("ul li:not(li:has(a.html))",this.toolbar).hide();$("ul:not(:has(:visible))",this.toolbar).hide();$("ul li a.html",this.toolbar).addClass("highlighted");},hideHTMLView:function(){this.updateHtmlArea();this.textarea.hide();this.htmlarea.show();$("ul",this.toolbar).show();$("ul li",this.toolbar).show().find("a.html").removeClass("highlighted");},toggleHTMLView:function(){(this.textarea.is(":hidden"))?this.showHTMLView():this.hideHTMLView();},toHtmlString:function(){return this.editor.body.innerHTML;},toString:function(){return this.editor.body.innerText;},updateTextArea:function(){this.textarea.val(this.toHtmlString());},updateHtmlArea:function(){this.editor.body.innerHTML=this.textarea.val();}};jHtmlArea.fn.init.prototype=jHtmlArea.fn;jHtmlArea.defaultOptions={toolbar:[["html"],["bold","italic","underline","strikethrough","|","subscript","superscript"],["increasefontsize","decreasefontsize"],["orderedlist","unorderedlist"],["indent","outdent"],["justifyleft","justifycenter","justifyright"],["link","unlink","image","horizontalrule"],["p","h1","h2","h3","h4","h5","h6"],["cut","copy","paste"]],css:null,toolbarText:{bold:"Bold",italic:"Italic",underline:"Underline",strikethrough:"Strike-Through",cut:"Cut",copy:"Copy",paste:"Paste",h1:"Heading 1",h2:"Heading 2",h3:"Heading 3",h4:"Heading 4",h5:"Heading 5",h6:"Heading 6",p:"Paragraph",indent:"Indent",outdent:"Outdent",horizontalrule:"Insert Horizontal Rule",justifyleft:"Left Justify",justifycenter:"Center Justify",justifyright:"Right Justify",increasefontsize:"Increase Font Size",decreasefontsize:"Decrease Font Size",forecolor:"Text Color",link:"Insert Link",unlink:"Remove Link",image:"Insert Image",orderedlist:"Insert Ordered List",unorderedlist:"Insert Unordered List",subscript:"Subscript",superscript:"Superscript",html:"Show/Hide HTML Source View"}};var priv={toolbarButtons:{strikethrough:"strikeThrough",orderedlist:"orderedList",unorderedlist:"unorderedList",horizontalrule:"insertHorizontalRule",justifyleft:"justifyLeft",justifycenter:"justifyCenter",justifyright:"justifyRight",increasefontsize:"increaseFontSize",decreasefontsize:"decreaseFontSize",html:function(btn){this.toggleHTMLView();}},initEditor:function(options){var edit=this.editor=this.iframe[0].contentWindow.document;edit.designMode='on';edit.open();edit.write(this.textarea.val());edit.close();if(options.css){var e=edit.createElement('link');e.rel='stylesheet';e.type='text/css';e.href=options.css;edit.getElementsByTagName('head')[0].appendChild(e);}},initToolBar:function(options){var that=this;var menuItem=function(className,altText,action){return $("<li/>").append($("<a href='javascript:void(0);'/>").addClass(className).attr("title",altText).click(function(){action.call(that,$(this));}));};function addButtons(arr){var ul=$("<ul/>").appendTo(that.toolbar);for(var i=0;i<arr.length;i++){var e=arr[i];if((typeof(e)).toLowerCase()==="string"){if(e==="|"){ul.append($('<li class="separator"/>'));}else{var f=(function(e){var m=priv.toolbarButtons[e]||e;if((typeof(m)).toLowerCase()==="function"){return function(btn){m.call(this,btn);};}else{return function(){this[m]();this.editor.body.focus();};}})(e.toLowerCase());var t=options.toolbarText[e.toLowerCase()];ul.append(menuItem(e.toLowerCase(),t||e,f));}}else{ul.append(menuItem(e.css,e.text,e.action));}}};if(options.toolbar.length!==0&&priv.isArray(options.toolbar[0])){for(var i=0;i<options.toolbar.length;i++){addButtons(options.toolbar[i]);}}else{addButtons(options.toolbar);}},attachEditorEvents:function(){var t=this;var fnHA=function(){t.updateHtmlArea();};this.textarea.click(fnHA).keyup(fnHA).keydown(fnHA).mousedown(fnHA).blur(fnHA);var fnTA=function(){t.updateTextArea();};$(this.editor.body).click(fnTA).keyup(fnTA).keydown(fnTA).mousedown(fnTA).blur(fnTA);$('form').submit(function(){t.toggleHTMLView();t.toggleHTMLView();});if(window.__doPostBack){var old__doPostBack=__doPostBack;window.__doPostBack=function(){if(t){if(t.toggleHTMLView){t.toggleHTMLView();t.toggleHTMLView();}}
return old__doPostBack.apply(window,arguments);};}},isArray:function(v){return v&&typeof v==='object'&&typeof v.length==='number'&&typeof v.splice==='function'&&!(v.propertyIsEnumerable('length'));}};})(jQuery);

//jHtmlArea - http://jhtmlarea.codeplex.com - (c)2009 Chris Pietschmann
(function($){if(jHtmlArea){var oldForecolor=jHtmlArea.fn.forecolor;jHtmlArea.fn.forecolor=function(c){if(c){oldForecolor.call(this,c);}else{var that=this;var rng=this.getRange();jHtmlAreaColorPickerMenu($(".forecolor",this.toolbar),{colorChosen:function(color){if($.browser.msie){rng.execCommand("ForeColor",false,color);}else{that.forecolor(color);}}});}};}
var menu=window.jHtmlAreaColorPickerMenu=function(ownerElement,options){return new jHtmlAreaColorPickerMenu.fn.init(ownerElement,options);};menu.fn=menu.prototype={jhtmlareacolorpickermenu:"0.7.0",init:function(ownerElement,options){var opts=$.extend({},menu.defaultOptions,options);var that=this;var owner=this.owner=$(ownerElement);var position=owner.position();if(menu.instance){menu.instance.hide();}
jHtmlAreaColorPickerMenu.instance=this;var picker=this.picker=$("<div/>").css({position:"absolute",left:position.left+opts.offsetLeft,top:position.top+owner.height()+opts.offsetTop,"z-index":opts["z-index"]}).addClass("jHtmlAreaColorPickerMenu");for(var i=0;i<opts.colors.length;i++){var c=opts.colors[i];$("<div/>").css("background-color",c).appendTo(picker).click((function(color){return function(){if(opts.colorChosen){opts.colorChosen.call(this,color);}
that.hide();};})(c));}
$("<div/>").html("<div></div>Automatic").addClass("automatic").appendTo(picker).click(function(){if(opts.colorChosen){opts.colorChosen.call(this,null);}
that.hide();});var autoHide=false;picker.appendTo(owner.parent()).show().mouseout(function(){autoHide=true;that.currentTimeout=window.setTimeout(function(){if(autoHide===true){that.hide();}},1000);}).mouseover(function(){if(that.currentTimeout){window.clearTimeout(that.currentTimeout);that.currentTimeout=null;}
autoHide=false;});},hide:function(){this.picker.hide();this.picker.remove();}};menu.fn.init.prototype=menu.fn;menu.defaultOptions={"z-index":0,offsetTop:0,offsetLeft:0,colors:["#ffffff","#cccccc","#c0c0c0","#999999","#666666","#333333","#000000","#ffcccc","#ff6666","#ff0000","#cc0000","#990000","#660000","#330000","#ffcc99","#ff9966","#ff9900","#ff6600","#cc6600","#993300","#663300","#ffff99","#ffff66","#ffcc66","#ffcc33","#cc9933","#996633","#663333","#ffffcc","#ffff33","#ffff00","#ffcc00","#999900","#666600","#333300","#99ff99","#66ff99","#33ff33","#33cc00","#009900","#006600","#003300","#99FFFF","#33FFFF","#66CCCC","#00CCCC","#339999","#336666","#003333","#CCFFFF","#66FFFF","#33CCFF","#3366FF","#3333FF","#000099","#000066","#CCCCFF","#9999FF","#6666CC","#6633FF","#6600CC","#333399","#330099","#FFCCFF","#FF99FF","#CC66CC","#CC33CC","#993399","#663366","#330033"],colorChosen:null};})(jQuery);
/**
 * jquery.Jcrop.min.js v0.9.10 (build:20120429)
 * jQuery Image Cropping Plugin - released under MIT License
 * Copyright (c) 2008-2012 Tapmodo Interactive LLC
 * https://github.com/tapmodo/Jcrop
 */
(function(a){a.Jcrop=function(b,c){function h(a){return a+"px"}function i(a){return d.baseClass+"-"+a}function j(){return a.fx.step.hasOwnProperty("backgroundColor")}function k(b){var c=a(b).offset();return[c.left,c.top]}function l(a){return[a.pageX-e[0],a.pageY-e[1]]}function m(b){typeof b!="object"&&(b={}),d=a.extend(d,b),a.each(["onChange","onSelect","onRelease","onDblClick"],function(a,b){typeof d[b]!="function"&&(d[b]=function(){})})}function n(a,b){e=k(E),bd.setCursor(a==="move"?a:a+"-resize");if(a==="move")return bd.activateHandlers(p(b),u);var c=ba.getFixed(),d=q(a),f=ba.getCorner(q(d));ba.setPressed(ba.getCorner(d)),ba.setCurrent(f),bd.activateHandlers(o(a,c),u)}function o(a,b){return function(c){if(!d.aspectRatio)switch(a){case"e":c[1]=b.y2;break;case"w":c[1]=b.y2;break;case"n":c[0]=b.x2;break;case"s":c[0]=b.x2}else switch(a){case"e":c[1]=b.y+1;break;case"w":c[1]=b.y+1;break;case"n":c[0]=b.x+1;break;case"s":c[0]=b.x+1}ba.setCurrent(c),bc.update()}}function p(a){var b=a;return be.watchKeys(),function(a){ba.moveOffset([a[0]-b[0],a[1]-b[1]]),b=a,bc.update()}}function q(a){switch(a){case"n":return"sw";case"s":return"nw";case"e":return"nw";case"w":return"ne";case"ne":return"sw";case"nw":return"se";case"se":return"nw";case"sw":return"ne"}}function r(a){return function(b){return d.disabled?!1:a==="move"&&!d.allowMove?!1:(e=k(E),X=!0,n(a,l(b)),b.stopPropagation(),b.preventDefault(),!1)}}function s(a,b,c){var d=a.width(),e=a.height();d>b&&b>0&&(d=b,e=b/a.width()*a.height()),e>c&&c>0&&(e=c,d=c/a.height()*a.width()),U=a.width()/d,V=a.height()/e,a.width(d).height(e)}function t(a){return{x:a.x*U,y:a.y*V,x2:a.x2*U,y2:a.y2*V,w:a.w*U,h:a.h*V}}function u(a){var b=ba.getFixed();b.w>d.minSelect[0]&&b.h>d.minSelect[1]?(bc.enableHandles(),bc.done()):bc.release(),bd.setCursor(d.allowSelect?"crosshair":"default")}function v(a){if(d.disabled)return!1;if(!d.allowSelect)return!1;X=!0,e=k(E),bc.disableHandles(),bd.setCursor("crosshair");var b=l(a);return ba.setPressed(b),bc.update(),bd.activateHandlers(w,u),be.watchKeys(),a.stopPropagation(),a.preventDefault(),!1}function w(a){ba.setCurrent(a),bc.update()}function z(){var b=a("<div></div>").addClass(i("tracker"));return a.browser.msie&&b.css({opacity:0,backgroundColor:"white"}),b}function bf(a){H.removeClass().addClass(i("holder")).addClass(a)}function bg(a,b){function t(){window.setTimeout(u,l)}var c=a[0]/U,e=a[1]/V,f=a[2]/U,g=a[3]/V;if(Y)return;var h=ba.flipCoords(c,e,f,g),i=ba.getFixed(),j=[i.x,i.y,i.x2,i.y2],k=j,l=d.animationDelay,m=h[0]-j[0],n=h[1]-j[1],o=h[2]-j[2],p=h[3]-j[3],q=0,r=d.swingSpeed;x=k[0],y=k[1],f=k[2],g=k[3],bc.animMode(!0);var s,u=function(){return function(){q+=(100-q)/r,k[0]=x+q/100*m,k[1]=y+q/100*n,k[2]=f+q/100*o,k[3]=g+q/100*p,q>=99.8&&(q=100),q<100?(bi(k),t()):(bc.done(),typeof b=="function"&&b.call(bt))}}();t()}function bh(a){bi([a[0]/U,a[1]/V,a[2]/U,a[3]/V]),d.onSelect.call(bt,t(ba.getFixed())),bc.enableHandles()}function bi(a){ba.setPressed([a[0],a[1]]),ba.setCurrent([a[2],a[3]]),bc.update()}function bj(){return t(ba.getFixed())}function bk(){return ba.getFixed()}function bl(a){m(a),bs()}function bm(){d.disabled=!0,bc.disableHandles(),bc.setCursor("default"),bd.setCursor("default")}function bn(){d.disabled=!1,bs()}function bo(){bc.done(),bd.activateHandlers(null,null)}function bp(){H.remove(),B.show(),a(b).removeData("Jcrop")}function bq(a,b){bc.release(),bm();var c=new Image;c.onload=function(){var e=c.width,f=c.height,g=d.boxWidth,h=d.boxHeight;E.width(e).height(f),E.attr("src",a),I.attr("src",a),s(E,g,h),F=E.width(),G=E.height(),I.width(F).height(G),N.width(F+M*2).height(G+M*2),H.width(F).height(G),bb.resize(F,G),bn(),typeof b=="function"&&b.call(bt)},c.src=a}function br(a,b,c){var e=b||d.bgColor;d.bgFade&&j()&&d.fadeTime&&!c?a.animate({backgroundColor:e},{queue:!1,duration:d.fadeTime}):a.css("backgroundColor",e)}function bs(a){d.allowResize?a?bc.enableOnly():bc.enableHandles():bc.disableHandles(),bd.setCursor(d.allowSelect?"crosshair":"default"),bc.setCursor(d.allowMove?"move":"default"),d.hasOwnProperty("trueSize")&&(U=d.trueSize[0]/F,V=d.trueSize[1]/G),d.hasOwnProperty("setSelect")&&(bh(d.setSelect),bc.done(),delete d.setSelect),bb.refresh(),d.bgColor!=O&&(br(d.shade?bb.getShades():H,d.shade?d.shadeColor||d.bgColor:d.bgColor),O=d.bgColor),P!=d.bgOpacity&&(P=d.bgOpacity,d.shade?bb.refresh():bc.setBgOpacity(P)),Q=d.maxSize[0]||0,R=d.maxSize[1]||0,S=d.minSize[0]||0,T=d.minSize[1]||0,d.hasOwnProperty("outerImage")&&(E.attr("src",d.outerImage),delete d.outerImage),bc.refresh()}var d=a.extend({},a.Jcrop.defaults),e,f,g=!1;a.browser.msie&&a.browser.version.split(".")[0]==="6"&&(g=!0),typeof b!="object"&&(b=a(b)[0]),typeof c!="object"&&(c={}),m(c);var A={border:"none",visibility:"visible",margin:0,padding:0,position:"absolute",top:0,left:0},B=a(b),C=!0;if(b.tagName=="IMG"){if(B[0].width!=0&&B[0].height!=0)B.width(B[0].width),B.height(B[0].height);else{var D=new Image;D.src=B[0].src,B.width(D.width),B.height(D.height)}var E=B.clone().removeAttr("id").css(A).show();E.width(B.width()),E.height(B.height()),B.after(E).hide()}else E=B.css(A).show(),C=!1,d.shade===null&&(d.shade=!0);s(E,d.boxWidth,d.boxHeight);var F=E.width(),G=E.height(),H=a("<div />").width(F).height(G).addClass(i("holder")).css({position:"relative",backgroundColor:d.bgColor}).insertAfter(B).append(E);d.addClass&&H.addClass(d.addClass);var I=a("<div />"),J=a("<div />").width("100%").height("100%").css({zIndex:310,position:"absolute",overflow:"hidden"}),K=a("<div />").width("100%").height("100%").css("zIndex",320),L=a("<div />").css({position:"absolute",zIndex:600}).dblclick(function(){var a=ba.getFixed();d.onDblClick.call(bt,a)}).insertBefore(E).append(J,K);C&&(I=a("<img />").attr("src",E.attr("src")).css(A).width(F).height(G),J.append(I)),g&&L.css({overflowY:"hidden"});var M=d.boundary,N=z().width(F+M*2).height(G+M*2).css({position:"absolute",top:h(-M),left:h(-M),zIndex:290}).mousedown(v),O=d.bgColor,P=d.bgOpacity,Q,R,S,T,U,V,W=!0,X,Y,Z;e=k(E);var _=function(){function a(){var a={},b=["touchstart","touchmove","touchend"],c=document.createElement("div"),d;try{for(d=0;d<b.length;d++){var e=b[d];e="on"+e;var f=e in c;f||(c.setAttribute(e,"return;"),f=typeof c[e]=="function"),a[b[d]]=f}return a.touchstart&&a.touchend&&a.touchmove}catch(g){return!1}}function b(){return d.touchSupport===!0||d.touchSupport===!1?d.touchSupport:a()}return{createDragger:function(a){return function(b){return b.pageX=b.originalEvent.changedTouches[0].pageX,b.pageY=b.originalEvent.changedTouches[0].pageY,d.disabled?!1:a==="move"&&!d.allowMove?!1:(X=!0,n(a,l(b)),b.stopPropagation(),b.preventDefault(),!1)}},newSelection:function(a){return a.pageX=a.originalEvent.changedTouches[0].pageX,a.pageY=a.originalEvent.changedTouches[0].pageY,v(a)},isSupported:a,support:b()}}(),ba=function(){function h(d){d=n(d),c=a=d[0],e=b=d[1]}function i(a){a=n(a),f=a[0]-c,g=a[1]-e,c=a[0],e=a[1]}function j(){return[f,g]}function k(d){var f=d[0],g=d[1];0>a+f&&(f-=f+a),0>b+g&&(g-=g+b),G<e+g&&(g+=G-(e+g)),F<c+f&&(f+=F-(c+f)),a+=f,c+=f,b+=g,e+=g}function l(a){var b=m();switch(a){case"ne":return[b.x2,b.y];case"nw":return[b.x,b.y];case"se":return[b.x2,b.y2];case"sw":return[b.x,b.y2]}}function m(){if(!d.aspectRatio)return p();var f=d.aspectRatio,g=d.minSize[0]/U,h=d.maxSize[0]/U,i=d.maxSize[1]/V,j=c-a,k=e-b,l=Math.abs(j),m=Math.abs(k),n=l/m,r,s,t,u;return h===0&&(h=F*10),i===0&&(i=G*10),n<f?(s=e,t=m*f,r=j<0?a-t:t+a,r<0?(r=0,u=Math.abs((r-a)/f),s=k<0?b-u:u+b):r>F&&(r=F,u=Math.abs((r-a)/f),s=k<0?b-u:u+b)):(r=c,u=l/f,s=k<0?b-u:b+u,s<0?(s=0,t=Math.abs((s-b)*f),r=j<0?a-t:t+a):s>G&&(s=G,t=Math.abs(s-b)*f,r=j<0?a-t:t+a)),r>a?(r-a<g?r=a+g:r-a>h&&(r=a+h),s>b?s=b+(r-a)/f:s=b-(r-a)/f):r<a&&(a-r<g?r=a-g:a-r>h&&(r=a-h),s>b?s=b+(a-r)/f:s=b-(a-r)/f),r<0?(a-=r,r=0):r>F&&(a-=r-F,r=F),s<0?(b-=s,s=0):s>G&&(b-=s-G,s=G),q(o(a,b,r,s))}function n(a){return a[0]<0&&(a[0]=0),a[1]<0&&(a[1]=0),a[0]>F&&(a[0]=F),a[1]>G&&(a[1]=G),[a[0],a[1]]}function o(a,b,c,d){var e=a,f=c,g=b,h=d;return c<a&&(e=c,f=a),d<b&&(g=d,h=b),[e,g,f,h]}function p(){var d=c-a,f=e-b,g;return Q&&Math.abs(d)>Q&&(c=d>0?a+Q:a-Q),R&&Math.abs(f)>R&&(e=f>0?b+R:b-R),T/V&&Math.abs(f)<T/V&&(e=f>0?b+T/V:b-T/V),S/U&&Math.abs(d)<S/U&&(c=d>0?a+S/U:a-S/U),a<0&&(c-=a,a-=a),b<0&&(e-=b,b-=b),c<0&&(a-=c,c-=c),e<0&&(b-=e,e-=e),c>F&&(g=c-F,a-=g,c-=g),e>G&&(g=e-G,b-=g,e-=g),a>F&&(g=a-G,e-=g,b-=g),b>G&&(g=b-G,e-=g,b-=g),q(o(a,b,c,e))}function q(a){return{x:a[0],y:a[1],x2:a[2],y2:a[3],w:a[2]-a[0],h:a[3]-a[1]}}var a=0,b=0,c=0,e=0,f,g;return{flipCoords:o,setPressed:h,setCurrent:i,getOffset:j,moveOffset:k,getCorner:l,getFixed:m}}(),bb=function(){function f(a,b){e.left.css({height:h(b)}),e.right.css({height:h(b)})}function g(){return i(ba.getFixed())}function i(a){e.top.css({left:h(a.x),width:h(a.w),height:h(a.y)}),e.bottom.css({top:h(a.y2),left:h(a.x),width:h(a.w),height:h(G-a.y2)}),e.right.css({left:h(a.x2),width:h(F-a.x2)}),e.left.css({width:h(a.x)})}function j(){return a("<div />").css({position:"absolute",backgroundColor:d.shadeColor||d.bgColor}).appendTo(c)}function k(){b||(b=!0,c.insertBefore(E),g(),bc.setBgOpacity(1,0,1),I.hide(),l(d.shadeColor||d.bgColor,1),bc.isAwake()?n(d.bgOpacity,1):n(1,1))}function l(a,b){br(p(),a,b)}function m(){b&&(c.remove(),I.show(),b=!1,bc.isAwake()?bc.setBgOpacity(d.bgOpacity,1,1):(bc.setBgOpacity(1,1,1),bc.disableHandles()),br(H,0,1))}function n(a,e){b&&(d.bgFade&&!e?c.animate({opacity:1-a},{queue:!1,duration:d.fadeTime}):c.css({opacity:1-a}))}function o(){d.shade?k():m(),bc.isAwake()&&n(d.bgOpacity)}function p(){return c.children()}var b=!1,c=a("<div />").css({position:"absolute",zIndex:240,opacity:0}),e={top:j(),left:j().height(G),right:j().height(G),bottom:j()};return{update:g,updateRaw:i,getShades:p,setBgColor:l,enable:k,disable:m,resize:f,refresh:o,opacity:n}}(),bc=function(){function k(b){var c=a("<div />").css({position:"absolute",opacity:d.borderOpacity}).addClass(i(b));return J.append(c),c}function l(b,c){var d=a("<div />").mousedown(r(b)).css({cursor:b+"-resize",position:"absolute",zIndex:c}).addClass("ord-"+b);return _.support&&d.bind("touchstart.jcrop",_.createDragger(b)),K.append(d),d}function m(a){var b=d.handleSize;return l(a,c++).css({opacity:d.handleOpacity}).width(b).height(b).addClass(i("handle"))}function n(a){return l(a,c++).addClass("jcrop-dragbar")}function o(a){var b;for(b=0;b<a.length;b++)g[a[b]]=n(a[b])}function p(a){var b,c;for(c=0;c<a.length;c++){switch(a[c]){case"n":b="hline";break;case"s":b="hline bottom";break;case"e":b="vline right";break;case"w":b="vline"}e[a[c]]=k(b)}}function q(a){var b;for(b=0;b<a.length;b++)f[a[b]]=m(a[b])}function s(a,b){d.shade||I.css({top:h(-b),left:h(-a)}),L.css({top:h(b),left:h(a)})}function u(a,b){L.width(a).height(b)}function v(){var a=ba.getFixed();ba.setPressed([a.x,a.y]),ba.setCurrent([a.x2,a.y2]),w()}function w(a){if(b)return x(a)}function x(a){var c=ba.getFixed();u(c.w,c.h),s(c.x,c.y),d.shade&&bb.updateRaw(c),b||A(),a?d.onSelect.call(bt,t(c)):d.onChange.call(bt,t(c))}function y(a,c,e){if(!b&&!c)return;d.bgFade&&!e?E.animate({opacity:a},{queue:!1,duration:d.fadeTime}):E.css("opacity",a)}function A(){L.show(),d.shade?bb.opacity(P):y(P,!0),b=!0}function B(){F(),L.hide(),d.shade?bb.opacity(1):y(1),b=!1,d.onRelease.call(bt)}function C(){j&&K.show()}function D(){j=!0;if(d.allowResize)return K.show(),!0}function F(){j=!1,K.hide()}function G(a){Y===a?F():D()}function H(){G(!1),v()}var b,c=370,e={},f={},g={},j=!1;d.dragEdges&&a.isArray(d.createDragbars)&&o(d.createDragbars),a.isArray(d.createHandles)&&q(d.createHandles),d.drawBorders&&a.isArray(d.createBorders)&&p(d.createBorders),a(document).bind("touchstart.jcrop-ios",function(b){a(b.currentTarget).hasClass("jcrop-tracker")&&b.stopPropagation()});var M=z().mousedown(r("move")).css({cursor:"move",position:"absolute",zIndex:360});return _.support&&M.bind("touchstart.jcrop",_.createDragger("move")),J.append(M),F(),{updateVisible:w,update:x,release:B,refresh:v,isAwake:function(){return b},setCursor:function(a){M.css("cursor",a)},enableHandles:D,enableOnly:function(){j=!0},showHandles:C,disableHandles:F,animMode:G,setBgOpacity:y,done:H}}(),bd=function(){function f(){N.css({zIndex:450}),_.support&&a(document).bind("touchmove.jcrop",k).bind("touchend.jcrop",m),e&&a(document).bind("mousemove.jcrop",h).bind("mouseup.jcrop",i)}function g(){N.css({zIndex:290}),a(document).unbind(".jcrop")}function h(a){return b(l(a)),!1}function i(a){return a.preventDefault(),a.stopPropagation(),X&&(X=!1,c(l(a)),bc.isAwake()&&d.onSelect.call(bt,t(ba.getFixed())),g(),b=function(){},c=function(){}),!1}function j(a,d){return X=!0,b=a,c=d,f(),!1}function k(a){return a.pageX=a.originalEvent.changedTouches[0].pageX,a.pageY=a.originalEvent.changedTouches[0].pageY,h(a)}function m(a){return a.pageX=a.originalEvent.changedTouches[0].pageX,a.pageY=a.originalEvent.changedTouches[0].pageY,i(a)}function n(a){N.css("cursor",a)}var b=function(){},c=function(){},e=d.trackDocument;return e||N.mousemove(h).mouseup(i).mouseout(i),E.before(N),{activateHandlers:j,setCursor:n}}(),be=function(){function e(){d.keySupport&&(b.show(),b.focus())}function f(a){b.hide()}function h(a,b,c){d.allowMove&&(ba.moveOffset([b,c]),bc.updateVisible(!0)),a.preventDefault(),a.stopPropagation()}function i(a){if(a.ctrlKey||a.metaKey)return!0;Z=a.shiftKey?!0:!1;var b=Z?10:1;switch(a.keyCode){case 37:h(a,-b,0);break;case 39:h(a,b,0);break;case 38:h(a,0,-b);break;case 40:h(a,0,b);break;case 27:d.allowSelect&&bc.release();break;case 9:return!0}return!1}var b=a('<input type="radio" />').css({position:"fixed",left:"-120px",width:"12px"}),c=a("<div />").css({position:"absolute",overflow:"hidden"}).append(b);return d.keySupport&&(b.keydown(i).blur(f),g||!d.fixedSupport?(b.css({position:"absolute",left:"-20px"}),c.append(b).insertBefore(E)):b.insertBefore(E)),{watchKeys:e}}();_.support&&N.bind("touchstart.jcrop",_.newSelection),K.hide(),bs(!0);var bt={setImage:bq,animateTo:bg,setSelect:bh,setOptions:bl,tellSelect:bj,tellScaled:bk,setClass:bf,disable:bm,enable:bn,cancel:bo,release:bc.release,destroy:bp,focus:be.watchKeys,getBounds:function(){return[F*U,G*V]},getWidgetSize:function(){return[F,G]},getScaleFactor:function(){return[U,V]},getOptions:function(){return d},ui:{holder:H,selection:L}};return a.browser.msie&&H.bind("selectstart",function(){return!1}),B.data("Jcrop",bt),bt},a.fn.Jcrop=function(b,c){var d;return this.each(function(){if(a(this).data("Jcrop")){if(b==="api")return a(this).data("Jcrop");a(this).data("Jcrop").setOptions(b)}else this.tagName=="IMG"?a.Jcrop.Loader(this,function(){a(this).css({display:"block",visibility:"hidden"}),d=a.Jcrop(this,b),a.isFunction(c)&&c.call(d)}):(a(this).css({display:"block",visibility:"hidden"}),d=a.Jcrop(this,b),a.isFunction(c)&&c.call(d))}),this},a.Jcrop.Loader=function(b,c,d){function g(){f.complete?(e.unbind(".jcloader"),a.isFunction(c)&&c.call(f)):window.setTimeout(g,50)}var e=a(b),f=e[0];e.bind("load.jcloader",g).bind("error.jcloader",function(b){e.unbind(".jcloader"),a.isFunction(d)&&d.call(f)}),f.complete&&a.isFunction(c)&&(e.unbind(".jcloader"),c.call(f))},a.Jcrop.defaults={allowSelect:!0,allowMove:!0,allowResize:!0,trackDocument:!0,baseClass:"jcrop",addClass:null,bgColor:"black",bgOpacity:.6,bgFade:!1,borderOpacity:.4,handleOpacity:.5,handleSize:7,aspectRatio:0,keySupport:!0,createHandles:["n","s","e","w","nw","ne","se","sw"],createDragbars:["n","s","e","w"],createBorders:["n","s","e","w"],drawBorders:!0,dragEdges:!0,fixedSupport:!0,touchSupport:null,shade:null,boxWidth:0,boxHeight:0,boundary:2,fadeTime:400,animationDelay:20,swingSpeed:3,minSelect:[0,0],maxSize:[0,0],minSize:[0,0],onChange:function(){},onSelect:function(){},onDblClick:function(){},onRelease:function(){}}})(jQuery);