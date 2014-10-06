var GG = function () {
    return {
        init: function () {
            dp.SyntaxHighlighter.ClipboardSwf = STATIC_HOST + "/static/swf/clipboard.swf";
            dp.SyntaxHighlighter.HighlightAll("code");
            $("a.download").each(function () {
                $(this).mouseup(function () {
                    $.post("/products/trackdownload", {
                        productID: $("#product-name-hidden").text(),
                        downloadID: $(this).attr("title")
                    });
                    pageTracker._trackEvent("Download", "Start", $(this).text());
                });
            });
            $("#product-features .tab-list a, #product-media .tab-list a, #related-products .tab-list a").each(function () {
                $(this).mouseup(function () {
                    if ($(this).hasClass("active-tab") == false) {
                        pageTracker._trackEvent("Tab", $("#product-name-hidden").text(), $(this).text());
                    }
                });
            });
            $(".tab-box .tab-list:not(.no-link) li a").click(function (b) {
                $(this).parents(".tab-list").find("a.active-tab").each(function () {
                    $(this).removeClass("active-tab");
                    var c = $(this).attr("href");
                    $(c).removeClass("active-tab-body");
                });
                $(this).addClass("active-tab");
                var a = $(this).attr("href");
                $(a).addClass("active-tab-body");
                if ($(a).children("ul.jcarousel-skin-tango").length>0) {
                    $(a).children("ul.jcarousel-skin-tango").jcarousel({
                        scroll: 4,
                        wrap: "both"
                    })
                }
                b.preventDefault();
            });
            $(".tab-box .tab-list:not(.no-link) li a.first").click();
            $(".vertical-tab-box .vertical-tab-list li a").each(function () {
                $(this).mousedown(function () {
                    GG.stopEngineRotator = true;
                });
                $(this).click(function (d) {
                    d.preventDefault();
                    var e = $(this).parents(".vertical-tab-list").find("a.active-tab");
                    var c = $(this).parents(".vertical-tab-box").find("div.active-tab-body");
                    var b = $(this);
                    var a = $($(this).attr("href"));
                    c.fadeOut("fast", function () {
                        e.removeClass("active-tab");
                        c.removeClass("active-tab-body");
						c.hide();
                        b.parent().parent().find("a.no-border").removeClass("no-border");
                        b.parent().prev().find("a").addClass("no-border");
                        b.addClass("active-tab");
                        a.fadeIn("fast", function () {
                            a.addClass("active-tab-body");
                        });
                    });
                    return false;
                });
            });
			$("#t3dpro .demo").click(function(d){
				d.preventDefault();
				iframe = document.getElementById("hiddenDownloader");
    			if (iframe === null)
    			{
        			iframe = document.createElement('iframe');  
        			iframe.id = "hiddenDownloader";
			        iframe.style.visibility = 'hidden';
        			document.body.appendChild(iframe);
    			}
    			iframe.src = "http://demos.garagegames.com/t3d/Torque3D_Tools_Demo_1_2.exe"; 
			});
            $(".iconic-tab-box .iconic-tab-list li a").each(function () {
                $(this).mousedown(function (a) {
                    window.clearInterval(rotatingbanner);
                    return false;
                });
              
                $(this).click(function (e) {
                    e.preventDefault();
                    var f = $(this).parents(".iconic-tab-list").find("a.active-tab");
                    var d = $(this).parents(".iconic-tab-box").find("div.active-tab-body");
                    var c = $(this);
                    var b = $($(this).attr("href"));
                    var a = $(this).parents(".iconic-tab-box").find(".iconic-tab-label");
					
                    d.fadeOut("fast", function () {
                        f.removeClass("active-tab");
                        d.removeClass("active-tab-body");
                        c.parent().parent().find("a.no-border").removeClass("no-border");
                        c.parent().prev().find("a").addClass("no-border");
                        c.addClass("active-tab");
                        a.attr("title", c.text());
                        a.text(c.text());
                        b.fadeIn("fast", function () {
                            b.addClass("active-tab-body");
                        });
                    });
                });
            });
			$(".betabuttons .iconic-tab-list li a").each(function () {
                $(this).mousedown(function (a) {

                    window.clearInterval(rotatingbanner);
                    return false;
                });
                $(this).mouseover(function (b) {
                    var a = $(this).parents(".iconic-tab-box").find(".iconic-tab-label");
                    a.text($(this).text());
                });
                $(this).mouseout(function (b) {
                    var a = $(this).parents(".iconic-tab-box").find(".iconic-tab-label");
                    if (a.attr("title") == $(this).text()) {
                        return
                    }
                    a.text(a.attr("title"));
                });
                $(this).click(function (e) {

                    e.preventDefault();
                    var f = $(this).parents(".iconic-tab-list").find("a.active-tab");
                    var d = $(this).parents(".iconic-tab-box").find("div.active-tab-body");
                    var c = $(this);
                    var b = $($(this).attr("href"));

                    var a = $(this).parents(".iconic-tab-box").find(".iconic-tab-label");
                    d.fadeOut("fast", function () {
                        f.removeClass("active-tab");
                        d.removeClass("active-tab-body");
                        c.parent().parent().find("a.no-border").removeClass("no-border");
                        c.parent().prev().find("a").addClass("no-border");
                        c.addClass("active-tab");
                        a.attr("title", c.text());
                        a.text(c.text());
                        b.fadeIn("fast", function () {
                            b.addClass("active-tab-body");
                        });
                    });
                });
            });
            $(".engine-feature-list li a").each(function () {
                $(this).click(function (d) {
                    d.preventDefault();
                    var e = $(this).parents(".engine-feature-list").find("a.current");
                    var c = $(".feature-tab.current:first");
                    var b = $(this);
                    var a = $($(this).attr("href"));
                    c.fadeOut("fast", function () {
                        e.removeClass("current");
                        c.removeClass("current");
                        b.addClass("current");
                        a.fadeIn("fast", function () {
                            a.addClass("current")
                        })
                    })
                })
            });
			


//			$(".section-subtabs-list a").each(function () {
//				
//                $(this).click(function (d) {
//                    d.preventDefault();
//                    var e = $(this).parents(".section-subtabs-list").find("a.current");
//                    var c = $(e.attr("href"));
//                    var b = $(this);
//					var f = $($(this).attr("href")+'image');
//					var a = $($(this).attr("href"));
//					e.removeClass("current");
//                    b.addClass("current");
//					c.removeClass("currentfeature");
//					a.addClass("currentfeature");					
//                    c.hide();
//                    a.show();
//					if($(this).attr("rel")=="Overview"){
//						$(".iconic-tab-panel").hide();
//						$(".iconic-tab-list a.first").click();
//						$(".active-tab").removeClass("active-tab");						
//						$(".iconic-tab-list a.first").addClass("active-tab");
//						GG.currentEngineTab = $(".iconic-tab-list a.first");
//						$("#featureimagecontainer").hide();
//						$("#subnav").hide();
//					} 
//					$("#featureimage").attr("src", f.val());
//				});
//            });
//			$("#overviewlinks a").each(function () {
//				
//                $(this).click(function (d) {
//                    d.preventDefault();
//                    var e = $("a.current");
//	                var c = $(".currentfeature");
//                    var b = $("a[rel="+$(this).attr('rel')+"]");
//					var f = $($(this).attr("href")+'image');
//					var a = $($(this).attr("href"));
//					e.removeClass("current");
//                    b.addClass("current");
//                    c.removeClass("currentfeature");
//					a.addClass("currentfeature");
//					c.hide();
//                    a.show();
//					if($(this).attr("rel")!="Overview"){
//						$("#featureimagecontainer").show();
//						$("#subnav").show();
//					} else {
//						$("#featureimagecontainer").hide();
//						$("#subnav").hide();	
//					}
//					$("#featureimage").attr("src", f.val());
//				})
//            });
			$(".documenttabs a").each(function () {
                $(this).click(function (d) {
                    d.preventDefault();
                    var c = $(".active-toc");
                    var b = $(this);
					var a = $($(this).attr("href"));
					if($(this).parent().hasClass('notselected'))
					{

						$('.selecteddoctab').addClass('notselected').removeClass('selecteddoctab');
						$(this).parent().toggleClass('selecteddoctab').removeClass('notselected');					
					}
					c.removeClass("active-toc");
                    a.addClass("active-toc");
                    c.hide();
                    a.show();
					
				//	$("#featureimage").attr("src", f.val());
				})
            });
			$("a.reveal").live('click',function(e){
					e.preventDefault();
					$(this).removeClass("reveal");
					$(this).addClass("revealed");
					$($(this).attr("href")).slideDown("fast",function(){});	
			});
			$("a.revealed").live('click',function(e){
					e.preventDefault();				
					$(this).removeClass("revealed");
					$(this).addClass("reveal");
					$($(this).attr("href")).slideUp("fast",function(){});	
			});
			
            $("#main-nav").droppy({
                speed: 0
            });
            $("#header-status").droppy({
                speed: 0
            });
            $("a.button").each(function () {
                var a = $(this);
                a.hover(function () {
                    $(this).toggleClass("ui-state-hover")
                }, function () {
                    $(this).toggleClass("ui-state-hover")
                }).mousedown(function (b) {
                    $(this).addClass("ui-state-active")
                }).mouseup(function (b) {
                    $(this).removeClass("ui-state-active")
                })
            });
            $("a.thumbnail.screen").fancybox({
                showOverlay: true
            });
			$("a.thumbnailbeta.screen").fancybox({
                'overlayShow': true,
				'showNavArrows':false
            });
            $("a.thumbnail.video").fancybox({
                frameWidth: 900,
                frameHeight: 507,
                showOverlay: true,
                hideOnContentClick: false,
                callbackOnHide: function () {
                    $("#fancy_content").empty()
                }
            });

            $("div.game").each(function () {
                $(this).find("div.caption").each(function () {
                    var f = $(this).parents("div.game");
                    var b = f.attr("id").replace(/game-/, "");
                    var e = $(this).attr("id");
                    var a = e.split(/-/);
                    var c = a[a.length - 1];
                    var d = $(this).text();
                    f.find(".image-" + c).each(function () {
                        $(this).attr("title", d)
                    })
                });
                $(this).find("a.botscreen").fancybox({
                    showOverlay: true
                });
                $(this).find("a.gamevideo").fancybox({
                    frameWidth: 900,
                    frameHeight: 507,
                    showOverlay: true,
                    hideOnContentClick: false,
                    callbackOnClose: function () {
                        $("#fancy_content").empty()
                    }
                })
            });
            $("a.clicker").each(function () {
                $(this).click(function (c) {
                    c.preventDefault();
                    var d = $(this).closest(".collapsable");
                    var a = d.children("a.clicker");
                    if (a.length == 0) {
                        d.find(".clicker").toggleClass("open")
                    } else {
                        a.toggleClass("open")
                    }
                    var b = d.children(".collapsableContent");
                    if (b.is(":visible")) {
                        b.hide()
                    } else {
                        b.show()
                    }
                })
            });
            $("a.delete").each(function () {
                $(this).click(function (a) {
                    a.preventDefault();
                    $('<div class="ui-state-highlight ui-state-error-text" style="margin: 10px;"><a href="' + $(this).attr("href") + '" style="display: none;">b</a><p><span style="float: left; margin-right: 5px;" class="ui-icon ui-icon-alert">Info</span>You are about to permanently delete an item. <b>This cannot be undone.</b><br /><br /></p></div>').dialog({
                        title: "Delete Item",
                        modal: true,
                        resizable: false,
                        draggable: false,
                        buttons: {
                            Cancel: function () {
                                $(this).dialog("close")
                            },
                            Ok: function () {
                                $(this).dialog("close");
                                if ($(this).find("a").attr("href") != "#") {
                                    window.location = $(this).find("a").attr("href")
                                } else {
                                    return
                                }
                            }
                        }
                    })
                })
            });
            $("table.tablesorter").tablesorter({
                widgets: ["zebra"]
            });
            $("table.tablepager").tablesorterPager({
                container: $("#tablesorterPager")
            });
            $("input[title]").each(function () {
                if (this.value == "") {
                    this.value = this.title
                }
                $(this).focus(function () {
                    if (this.value == this.title) {
                        this.value = ""
                    } else {
                        this.select()
                    }
                }).blur(function () {
                    if (this.value == "") {
                        this.value = this.title
                    }
                })
            });
            $("input:not([title])[type=text], input[type=password], textarea").each(function () {
                $(this).focus(function () {
                    $(this).addClass("active")
                }).blur(function () {
                    $(this).removeClass("active")
                })
            });
			
			$('select').bind('focusin', function() {
		        $(this).addClass('active');
		    }).bind('focusout', function() {
		        $(this).removeClass('active');
		    });

            $().qtip.styles.gg = {
                width: 300,
                background: "#444",
                color: "white",
                border: {
                    width: 8,
                    radius: 4,
                    color: "#111"
                },
                title: {
                    "background-color": "#222"
                },
                name: "dark"
            };
            $("a.profile-link").each(function () {
                $(this).unbind("mouseup").qtip({
                    content: {
                        text: "Loading content...",
                        url: $(this).attr("href"),
                        title: {
                            text: $(this).attr("rel"),
                            button: "Close"
                        }
                    },
                    position: {
                        corner: {
                            target: "bottomMiddle",
                            tooltip: "topMiddle"
                        },
                        adjust: {
                            screen: true
                        }
                    },
                    show: {
                        when: "click",
                        delay: 0,
                        solo: true
                    },
                    hide: "unfocus",
                    style: {
                        width: 200,
                        name: "gg",
                        tip: true
                    },
                    api: {
                        onHide: function () {
                            this.elements.target.removeClass("ui-state-active")
                        }
                    }
                })
            });
            $("span.tooltip").each(function () {
                var a = $(this);
                var b = a.find("span.content").text();
                a.find("a.anchor").qtip({
                    content: '<div style="padding: 5px;">' + b + "</div>",
                    position: {
                        target: $(this),
                        corner: {
                            target: "bottomMiddle",
                            tooltip: "topMiddle"
                        },
                        adjust: {
                            y: 10
                        }
                    },
                    style: {
                        name: "gg"
                    }
                })
            });
			 $("a.info").each(function () {

                $(this).click(function (f) {
					f.preventDefault();
                alert("woo woo woo");
                
                })
            });
            $("a.snapshot").each(function () {
                $(this).qtip({
                    style: {
                        width: 500,
                        tip: true,
                        name: "gg"
                    },
                    content: {
                        text: $("#" + $(this).attr("id") + "-content").html()
                    },
                    position: {
                        corner: {
                            target: "leftMiddle",
                            tooltip: "rightMiddle"
                        },
                        adjust: {
                            screen: true
                        }
                    },
                    show: {
                        solo: true,
                        when: {
                            event: "mouseover"
                        }
                    },
                    hide: "mouseout"
                })
            });
            $("#ml-link").qtip({
                content: {
                    url: "/support/markuplite",
                    title: {
                        text: "MarkupLite Reference",
                        button: "Close"
                    }
                },
                position: {
                    target: $("#formBody"),
                    corner: {
                        target: "topMiddle",
                        tooltip: "bottomMiddle"
                    },
                    adjust: {
                        y: -25
                    }
                },
                style: {
                    width: 800,
                    height: 300,
                    name: "gg"
                },
                show: {
                    when: "click",
                    delay: 0,
                    solo: true
                },
                hide: "unfocus",
                api: {
                    beforeHide: function () {
                        $("#markuplite").scrollTo(0)
                    }
                }
            });
            $("a[href=#indievscommercial]").each(function () {
                $("#indievscommercial").dialog({
                    modal: true,
                    resizable: false,
                    draggable: false,
                    autoOpen: false,
                    buttons: {
                        Close: function () {
                            $(this).dialog("close")
                        }
                    },
                    title: "Individual or Studio",
                    width: "800px"
                });
                $(this).click(function () {
                    $("#indievscommercial").dialog("open");
                    return false
                })
            });
            $("a.purchase").qtip({
                style: {
                    width: 300,
                    tip: true,
                    name: "gg"
                },
                content: {
                    text: $("#explainDiscount").html()
                },
                position: {
                    corner: {
                        target: "leftMiddle",
                        tooltip: "rightMiddle"
                    },
                    adjust: {
                        screen: true
                    }
                },
                show: {
                    solo: true,
                    when: {
                        event: "mouseover"
                    }
                },
                hide: "mouseout"
            });
            $("a.purchase2").qtip({
                style: {
                    width: 300,
                    tip: true,
                    name: "gg"
                },
                content: {
                    text: $("#explainDiscount2").html()
                },
                position: {
                    corner: {
                        target: "leftMiddle",
                        tooltip: "rightMiddle"
                    },
                    adjust: {
                        screen: true
                    }
                },
                show: {
                    solo: true,
                    when: {
                        event: "mouseover"
                    }
                },
                hide: "mouseout"
            });
            $("a.purchase3").qtip({
                style: {
                    width: 300,
                    tip: true,
                    name: "gg"
                },
                content: {
                    text: $("#explainDiscount3").html()
                },
                position: {
                    corner: {
                        target: "leftMiddle",
                        tooltip: "rightMiddle"
                    },
                    adjust: {
                        screen: true
                    }
                },
                show: {
                    solo: true,
                    when: {
                        event: "mouseover"
                    }
                },
                hide: "mouseout"
            });
            $("a.purchase4").qtip({
                style: {
                    width: 300,
                    tip: true,
                    name: "gg"
                },
                content: {
                    text: $("#explainDiscount4").html()
                },
                position: {
                    corner: {
                        target: "leftMiddle",
                        tooltip: "rightMiddle"
                    },
                    adjust: {
                        screen: true
                    }
                },
                show: {
                    solo: true,
                    when: {
                        event: "mouseover"
                    }
                },
                hide: "mouseout"
            });
            setTimeout(function () {
                GG.textRotator()
            }, 5000);
            $("#content .body img[hspace]").each(function () {
                var a = $(this).attr("hspace");
                $(this).css({
                    "margin-left": a + "px",
                    "margin-right": a + "px"
                })
            });
            $("#content .body img[vspace]").each(function () {
                var a = $(this).attr("vspace");
                $(this).css({
                    "margin-top": a + "px",
                    "margin-bottom": a + "px"
                })
            });
            $("#content .body img[align=left]").each(function () {
                $(this).css("float", "left")
            });
            $("#content .body img[align=right]").each(function () {
                $(this).css("float", "right")
            });
			
			//$(".jqwyg").wysiwyg();
            $(".jqwyg").css({width: '900px'}).htmlarea({
            	css: "/static/styles/main.css",
            	loaded: function()
            	{
            		$('.jHtmlArea').css('width', '890px'); // Require for outer frame's width
            		$('.jHtmlArea').find('iframe').css('width', '890px'); // Should allow for padding based on CSS rules
            		$('.jHtmlArea').find('iframe').css('height', '430px'); // Required for inner iframe's height
            	}
            });
        },
		
        currentEngineTab: null,
        stopEngineRotator: false,
        engineRotator: function (a) {
            if (GG.stopEngineRotator == true) {
                return
            }
            if (GG.currentEngineTab == null) {
                var c = $(a).find("a:first")
            } else {
                var c = GG.currentEngineTab
            }
            var b = c.parent().next().find("a");
            if (b.length == 0) {
                b = $(a).find("a:first")
            }
            GG.currentEngineTab = b;
            b.click();
        },
        prevRotatorText: null,
        currentRotatorText: null,
        textRotator: function () {
            var a = $("#twitter span");
            var c = $("#twitter span.show");
            var b = c.next();
            if (b.length == 0) {
                b = $(a[0])
            }
            GG.prevRotatorText = c;
            GG.currentRotatorText = b;
            if ($.browser.msie) {
                c.removeClass("show");
                b.addClass("show");
                setTimeout(function () {
                    GG.textRotator()
                }, 5000)
            } else {
                c.fadeOut("normal", function () {
                    GG.currentRotatorText.fadeIn("normal", function () {
                        GG.prevRotatorText.removeClass("show");
                        GG.currentRotatorText.addClass("show");
                        setTimeout(function () {
                            GG.textRotator()
                        }, 5000)
                    })
                })
            }
        },
        ivc: false,
        initDeleteButtons: function (a) {
            $("#" + a + " a.delete").each(function () {
                $(this).click(function (b) {
                    b.preventDefault();
                    $('<div class="ui-state-highlight ui-state-error-text" style="margin: 10px;"><a href="' + $(this).attr("href") + '" style="display: none;">b</a><p><span style="float: left; margin-right: 5px;" class="ui-icon ui-icon-alert">Info</span>You are about to permanently delete an item. <b>This cannot be undone.</b><br /><br /></p></div>').dialog({
                        title: "Delete Item",
                        modal: true,
                        resizable: false,
                        draggable: false,
                        buttons: {
                            Cancel: function () {
                                $(this).dialog("close")
                            },
                            Ok: function () {
                                $(this).dialog("close");
                                window.location = $(this).find("a").attr("href")
                            }
                        }
                    })
                })
            })
        },
        initEditButtons: function (a) {
            $("#" + a + " a.edit").each(function () {
                $(this).click(function (b) {
                    b.preventDefault();
                    $('<div class="ui-state-highlight ui-state-error-text" style="margin: 10px;"><a href="' + $(this).attr("href") + '" style="display: none;">b</a><p><span style="float: left; margin-right: 5px;" class="ui-icon ui-icon-alert">Info</span>You are about to edit an item. <b>This cannot be undone.</b><br /><br /></p></div>').dialog({
                        title: "Edit Item",
                        modal: true,
                        resizable: false,
                        draggable: false,
                        buttons: {
                            Cancel: function () {
                                $(this).dialog("close")
                            },
                            Ok: function () {
                                $(this).dialog("close");
                                window.location = $(this).find("a").attr("href")
                            }
                        }
                    })
                })
            })
        },
        addToCart: function (a, b) {
            $("#supersecrethiddendiv").load("/store/addtocart", {
                productID: a,
                commercial: b
            }, GG.addToCartResults, "script")
        },
        addToCartDynamic: function () {
            var b = document.productform.productradio;
            if (b.length > 1) {
                for (var d = b.length - 1; d >= 0; d--) {
                    if (b[d].checked) {
                        var a = b[d].value
                    }
                }
            } else {
                var a = b.value
            }
            if (a.match(/-commercial/)) {
                var a = a.split(/-/)[0];
                var c = 1
            } else {
                var c = 0
            }
            GG.addToCart(a, c)
        },
        blogNotify: function (a, c) {
            var b = {
                accountID: c,
                blogID: a
            };
            $("#supersecrethiddendiv").load("/community/notifyuser", b)
        },
        threadNotify: function (c, b) {
            var a = {
                accountID: b,
                threadID: c
            };
            $("#supersecrethiddendiv").load("/community/notifyuser", a)
        },
		tutorialThreadNotify: function (c, b) {
            var a = {
                accountID: b,
                tutorialID: c
            };
            $("#supersecrethiddendiv").load("/community/tutorialnotifyuser", a)
        },
        growl: function (b) {
            for (var a = b.length - 1; a >= 0; a--) {
                $.jgrowl(b[a])
            }
        },
        trackLink: function (b) {
            var a = $(this).text();
            pageTracker._trackEvent("Downloads", "Click", a)
        },
        findTransaction: function () {
            var a = prompt("Enter transaction #");
            window.location = "/admin/accounting/viewtransaction/transactionID/" + a;
            return false
        },
        alreadyOwned: function () {
            $("<div>You have already purchased this item and it is limited to 1 license per account.</div>").dialog({
                draggable: false,
                resizable: false,
                modal: true,
                title: "Cannot purchase",
                buttons: {
                    Ok: function () {
                        $(this).dialog("close")
                    }
                }
            })
        },
        startDemo: function () {
            var a = window.open("/products/webdemo", "webdemo", "height=768,width=1024")
        }
		
    }
}();
$.fn.extend({
    insertAtCaret: function (c) {
        if (document.selection) {
            this.focus();
            sel = document.selection.createRange();
            sel.text = c;
            this.focus()
        } else {
            if (this.selectionStart || this.selectionStart == "0") {
                var b = this.selectionStart;
                var a = this.selectionEnd;
                var d = this.scrollTop;
                this.value = this.value.substring(0, b) + c + this.value.substring(a, this.value.length);
                this.focus();
                this.selectionStart = b + c.length;
                this.selectionEnd = b + c.length;
                this.scrollTop = d
            } else {
                $(this).val($(this).val() + c);
                this.focus()
            }
        }
    }
});
jQuery(document).ready(function(){
	GG.init();
});