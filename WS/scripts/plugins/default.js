function strip_menu_image() {
    var w = $('.page-menu .box2 .tab-cont .list-item').width();
    $('.page-menu .box2 .tab-cont .list-item').each(function () {
        $(this).outerHeight(w);
    });
    $('.page-menu .box2 .tab-cont .menuimage').each(function () {
        var e = $(this);
        var p = e.data('wallpaper');
        e.css({ 'background-image': 'url(' + p + ')' });
    });

    $('.home #header .bannerimg').each(function () {
        $(this).height($(this).width());
    });
    var h = Math.floor($(this).width() / 2.4);
    $('.page #header .bannerimg').each(function () {
        $(this).height(h);
    });
    $('.page #header').height(h);
    $('.page #header .banner').height(h);
}

$(document).ready(function () {
    $('div[pload]').each(function () {
        $(this).load($(this).attr('pload')).removeAttr('pload');
    });
});

(function ($) {
    window.console = window.console || function (t) {
    };
    $(document).ready(function () {

        // detect IE version
        if ($("html").hasClass("msie-9") || $("html").hasClass("msie-8") || $("html").hasClass("msie-7")) {
            alert("為提供您更順暢與優質的瀏覽頁面\n請使用Chrome瀏覽器或將IE瀏覽器更新至IE 10以上版本");
        }

        (function () {
            var self = this,
                that = $('#loading'),
                current = that.find('.current'),
                progress = that.find('.progress'),
                isNeedLoaddng = String(that.css('display')).toLowerCase() === 'block';
            if (!isNeedLoaddng) {
                return onDone();
            }
            preloader({
                lazy: 20,
                onLoading: function (event) {
                    var percentage = event.progressed + '%';
                    current.text(percentage);
                    progress.stop().animate({
                        width: percentage
                    });
                },
                onComplete: function () {
                    that.animate({
                        top: '-100%',
                        opacity: '0'
                    }, {
                        duration: 1800,
                        easing: 'easeInOutBack'
                    });
                    onDone();
                }
            });
        }());

        function onDone() {
            if (typeof WOW != "undefined")
                new WOW().init();
            /* onDone star */
            /* document STAR */
            h = $(window).height();
            w = $(window).width();


            $winH = $('.winH');
            $jqimgFill = $('.jqimgFill');
            $pro55s = $('.pro55s');
            $body = $('body');
            $navbarToggle = $('.navbar-toggle');
            $banner = $('.banner .slider');
            $down = $('.down');
            $footerH = $('#footer').height();
            $footerTop = $('#footer .top');
            $body.addClass('in');
            $subnav = $('.sub-nav');

            $homeEvents = $('.home-events');
            $listSlick = $('.list-slick');
            $navList = $('.nav-list');
            $homemember = $('.home-member');

            resizeCss();


            $('.inImg img').each(function () {
                $(this).fadeTo(400, 1);
            });

            $('a[data-rel^=lightcase]').each(function () {
                $(this).lightcase({
                    maxWidth: 830,
                    maxHeight: 620,
                    liveResize: true,
                    showSequenceInfo: false,
                    inline: {

                    }

                });
            });

            $('a[data-rel^=lightcasepic]').each(function () {
                $(this).lightcase({
                    maxWidth: 830,
                    maxHeight: 620,
                    liveResize: true,
                    showSequenceInfo: false,
                    onFinish: {
                        baz: function () {
                            $('#lightcase-case').addClass('lightcasePic'); // 增加class
                            window.parent.$('.lightcase-icon-pause').click(); // 暫停自動撥放

                        }
                    },


                });
            });

            /* == banner =========================== */
            $banner.each(function () {
                $(this).slick({
                    dots: false,
                    infinite: true,
                    speed: 2000,
                    speed: 1500,
                    cssEase: 'linear'
                })
            });

            $('.home #header .bannerimg').each(function () {
                $(this).height($(this).width());
            });
            var h = Math.floor($(this).width() / 3);
            $('.page #header .bannerimg').each(function () {
                $(this).height(h);
            });
            $('.page #header').height(h + 6);
            $('.page #header .banner').height(h);

            /*== home .home-artPalace =========================== */            $homeEvents.each(function () {
                $listSlick.slick({
                    adaptiveHeight: true,                    slidesToShow: 1,                    slidesToScroll: 1,                    fade: true,                    dots: false,                    arrows: true,                    autoplay: true,
                    responsive: [
                                    {
                                        breakpoint: 1024,
                                        settings: {
                                            slidesToShow: 1,
                                            slidesToScroll: 1,
                                        }
                                    },
                                    {
                                        breakpoint: 600,
                                        settings: {
                                            slidesToShow: 1,
                                            slidesToScroll: 1
                                        }
                                    },
                                    {
                                        breakpoint: 480,
                                        settings: {
                                            slidesToShow: 1,
                                            slidesToScroll: 1
                                        }
                                    }
                                    // You can unslick at a given breakpoint now by adding:
                                    // settings: "unslick"
                                    // instead of a settings object
                    ]
                });
            });            /*== home .home-artists=========================== */            /*    		$homemember.each(function () {
    		    $(this).find('.slider').slick({
    		        slidesToShow: 1,    		        slidesToScroll: 1,    		        dots: true,    		        infinite: true,    		        speed: 1000,    		        autoplay: false,    		        arrows: false,
    		    });
    		});
    		*/


            /* == page .page-about3 =========================== */
            $('.page-about3 .mvplay').each(function () {
                $(this).click(function (event) {
                    callPlayer("myVideo", "playVideo");
                    $(this).hide();
                    $("#myVideo").show();
                });
            });

            /*== page .page-store =========================== */            /*    		$('.page-store').each(function () {
    		    $('.nav a').click(function () {
    		        $namelink = $(this).attr("href");    		        $('html,body').animate({
    		            scrollTop: $($namelink).offset().top - 100
    		        }, 800);
    		    });
    		});
            */

            /*== page .page-menu =========================== */            /*    		$('.page-menu').each(function () {
    		    function projectInterface() {
    		        this.run = run;    		        function run() {
    		            var tabber = new HashTabber();    		            tabber.run();
    		        }
    		    }    		    var hashTabberSoundsLikeDrugs = new projectInterface();    		    hashTabberSoundsLikeDrugs.run();    		    $('.view').click(function () {
    		        $namelink = $(this).attr("href");    		        $('html,body').animate({
    		            scrollTop: $($namelink).offset().top - 100
    		        }, 800);
    		    });
    		});
            */

            /* = windows scroll =========================== */
            function scroll() {
                h = $(window).height();
                var $this = $(this);
                var $this_Top = $this.scrollTop();
                if ($this_Top < 90) {
                    $body.removeClass("scroll");
                    $footerTop.removeClass("fixed");
                    // $banner.slick('slickPlay'); // banner play

                }
                if ($this_Top > 90) {
                    $body.addClass("scroll");
                    $footerTop.addClass("fixed");
                    // $banner.slick('slickPause'); // banner stop
                }
            }

            /* == scroll =========================== */
            $(window).bind('scroll', function () {
                scroll();
            }).scroll();


            /* == mobile navbar =========================== */


            /*
               * ==========================================================================
               * resize
               * ==========================================================================
            */
            /* 螢幕寬高 */
            $(window).resize(function () {
                resizeCss();
            });

            function resizeCss() {
                h = $(window).height();
                w = $(window).width();
                $jqimgFill.focusPoint();

                $winH.each(function () {
                    $(this).css({
                        "height": h,
                    });
                });
                /* 判斷螢幕是否旋轉 */
                if (h < w) {
                    $("body").addClass('landscape');
                    $body.removeClass('upright');
                } else {
                    $body.removeClass('landscape');
                    $("body").addClass('upright');
                }
                /* 形狀-正方形 */
                $pro55s.each(function () {
                    $(this).find(".list-item").css("height", $(this).find(".list-item:first-child  .pic").width());
                });
            }


        }

    });

    /*
	 * =============================================================================
	 * preloader
	 * =============================================================================
	 */
    function preloader(options) {
        var callee = arguments.callee,
            defaultProcess = 'default',
            historyLoaded = [],
            historyFailed = [];
        callee.instances = callee.instances || {};
        if (!$.isPlainObject(options)) {
            var process = String(options) || defaultProcess;
            return callee.instances[process];
        }
        options.process = options.process || defaultProcess;
        return (callee.instances[options.process] = ({
            state: [],
            loaded: [],
            failed: [],
            settings: {
                urls: [],
                onComplete: null,
                onLoading: null,
                workspace: null,
                gather: true,
                lazy: 0
            },
            init: function (options) {
                var self = this;
                $.extend(true, self.settings, options);
                $($.proxy(self.onReady, self));
                return self;
            },
            onReady: function () {
                var self = this;
                if (self.settings.gather) {
                    self.gatherImages(self.settings.workspace);
                }
                self.onStart();
            },
            onStart: function () {
                var self = this,
                    info = {
                        all: self.settings.urls.length,
                        loaded: 0,
                        success: 0,
                        error: 0,
                        progressed: 0
                    },
                    trigger = function (method, args, index) {
                        var eventObject = $.extend({}, args);
                        if (index !== undefined && index !== null) {
                            eventObject.url = self.settings.urls[index];
                        }
                        method && method.call(self, eventObject);
                    };
                if (self.aborted) return;
                trigger(self.settings.onStart, info);
                if (!info.all) {
                    trigger(self.onComplete, info);
                } else {
                    // TODO: Delay?
                    $.each(self.settings.urls, function (index, url) {
                        if (self.aborted) return false;
                        if (historyLoaded[url] || historyFailed[url]) {
                            info.loaded++;
                            historyLoaded[url] && info.success++;
                            historyFailed[url] && info.error++;
                            trigger(self.onLoading, info, index);
                            return true;
                        }
                        var image = new Image(),
                            unbind = function () {
                                image.onload = image.onerror = null;
                            };
                        image.onload = function () {
                            unbind();
                            info.loaded++;
                            info.success++;
                            self.loaded[url] = true;
                            historyLoaded[url] = true;
                            trigger(self.onLoading, info, index);
                        };
                        image.onerror = function () {
                            unbind();
                            info.loaded++;
                            info.error++;
                            self.failed[url] = true;
                            historyFailed[url] = true;
                            trigger(self.onLoading, info, index);
                        };
                        image.src = url;
                    });
                }
            },
            onLoading: function (event) {
                var self = this;
                if (self.aborted) return;
                event.progressed = Math.round((event.loaded / event.all) * 100);

                function loading() {
                    if (self.aborted) return;
                    if (self.settings.onLoading) {
                        self.settings.onLoading.call(self, event);
                    }
                    if (event.loaded === event.all) {
                        self.onComplete.call(self, event);
                    }
                }
                if (!self.settings.lazy) loading();
                else setTimeout(loading, event.loaded * self.settings.lazy);
            },
            onComplete: function (event) {
                var self = this;
                if (self.aborted) return;
                if (self.settings.onComplete) {
                    delete event.url;
                    event.progressed = 100;
                    self.settings.onComplete.call(self, event);
                }
            },
            abort: function () {
                var self = this;
                self.aborted = true;
            },
            gatherImages: function (workspace) {
                var self = this;

                function addUrl(url) {
                    var key = url;
                    if (self.state[key]) return;
                    var url = self.buildUrl(url);
                    self.settings.urls.push(url);
                    self.state[key] = true;
                }
                $(workspace || document).find('*:not(script, link)').each(function () {
                    var element = $(this),
                        background = element.css('backgroundImage'),
                        matches;
                    // TODO: Not support :befor/:after
                    if (background && background.indexOf('url') !== -1) {
                        if ((matches = background.match(/^url\("?([^"]*)"?\)/))) {
                            addUrl(matches[1]);
                        }
                    }
                    if (element.get(0).tagName.toLowerCase() === 'img') {
                        if ((matches = element.attr('data-src'))) {
                            element.attr('src', matches);
                            addUrl(matches);
                        } else if ((matches = element.attr('src'))) {
                            addUrl(matches);
                        }
                    }
                });
            },
            parseCss: function () {
                // TODO...
            },
            buildUrl: function (url, workspace) {
                var self = this,
                    baseUrl = self.baseUrl();
                if (baseUrl && url && !url.match(/^https?:\/\/.+$/i) && !url.match(/^\//)) {
                    url = baseUrl.replace(/\/*$/, '/' + url);
                }
                return url;
            },
            baseUrl: function () {
                var self = this;
                if (arguments.callee.cache) return arguments.callee.cache;
                return (arguments.callee.cache = $('base[href]').attr('href'));
            },
            isLoaded: function (uri) {
                var self = this,
                    url = self.buildUrl(uri);
                return !!self.loaded[url];
            }
        })
            .init(options));
    }
})(jQuery);

