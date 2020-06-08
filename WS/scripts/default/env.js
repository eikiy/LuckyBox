   (function() {
       var env = (function() {
           var ua = navigator.userAgent.toLowerCase(),
               os = {
                   windows: /windows|win32/.test(ua),
                   macintosh: /macintosh|powerpc/.test(ua),
                   linux: /linux/.test(ua),
                   symbos: /symbos/.test(ua),
                   ios: /ios|iphone|ipad|ipod/.test(ua),
                   android: /android/.test(ua),
                   blackBerry: /blackBerry/.test(ua),
               },
               device = {
                   iphone: /iphone/.test(ua),
                   ipad: /ipad/.test(ua),
                   ipod: /ipod/.test(ua),
                   mobile: /(ios|iphone|ipad|ipod)|android|iemobile|blackberry/.test(ua)
               },
               browser = (function() {
                   var NO_MATCHED,
                       KUNOW_VERSION = -1,
                       map = {
                           mozilla: /mozilla/.test(ua),
                           webkit: /webkit/.test(ua),
                           safari: /safari/.test(ua) && !/chrome/.test(ua) && !/opera/.test(ua),
                           chrome: /chrome/.test(ua),
                           firefox: /firefox/.test(ua),
                           opera: /opera/.test(ua),
                           msie: (function() {
                               var matches, version = NO_MATCHED;

                               if (/msie/.test(ua)) {
                                   version = KUNOW_VERSION;
                                   if ((matches = ua.match(/msie ([\w.]+)/))) {
                                       version = matches[1];
                                   }
                               }

                               if ((matches = ua.match(/trident\/.*rv:([0-9]{1,}[\.0-9]{0,})/))) {
                                   if (/netscape/.test(navigator.appName.toLowerCase())) {
                                       version = matches[1];
                                   }
                               }

                               if (version !== NO_MATCHED) {
                                   version = parseFloat(version);
                               }

                               return version;
                           }())
                       };

                   // Version
                   $.each(map, function(name, browser) {
                       map[name] = typeof browser === 'number' ? browser : NO_MATCHED;
                       if (browser === true) {
                           var matches,
                               patterns = {
                                   chrome: /chrome[ \/]([\w.]+)/,
                                   firefox: /firefox[ \/]([\w.]+)/,
                                   safari: /version[ \/]([\w.]+).*safari/,
                                   webkit: /webkit[ \/]([\w.]+)/,
                                   mozilla: /mozilla[ \/]([\w.]+)/,
                                   opera: /opera(?:.*version)?[ \/]([\w.]+)/,
                               };

                           map[name] = KUNOW_VERSION;
                           if (patterns[name] && (matches = ua.match(patterns[name]))) {
                               map[name] = matches[1];
                           }
                       }

                       if (map[name] !== NO_MATCHED) {
                           map[name] = parseFloat(map[name]);
                       }
                   });

                   return map;
               }());

           return {
               ua: ua,
               os: os,
               device: device,
               browser: browser,
           };
       }());

       $(function() {
           $(window).resize((function() {
               var root = $('html'),
                   msie = 'msie',
                   clientWidth = $(window).width(),
                   clientHeight = $(window).height()
               forcePcVersion = true;
               
               $.each($.extend({}, env.os, env.device, env.browser), function(name, value) {
                   value && root.addClass(name);
                   if (name === msie) {
                       root.addClass(msie +"-"+ env.browser.msie);
                   }
               });

               if (env.device.mobile || forcePcVersion) {
                   /*
                   root.toggleClass('min-sm-size', clientWidth >= 768);
                   root.toggleClass('min-md-size', clientWidth >= 992);
                   root.toggleClass('min-lg-size', clientWidth >= 1200);
                   root.toggleClass('min-bg-size', clientWidth >= 1408);


                   root.toggleClass('max-xs-size', clientWidth <= 480);
                   root.toggleClass('max-sm-size', clientWidth <= 767);
                   root.toggleClass('max-md-size', clientWidth <= 991);
                   root.toggleClass('max-lg-size', clientWidth <= 1199);
                   root.toggleClass('max-bg-size', clientWidth <= 1407);
                   root.toggleClass('max-xl-size', clientWidth <= 1680);
                   */

                   /*暫時無用
                   root.toggleClass('int-xs-size', 992 >= clientWidth <= 1199);
                   root.toggleClass('int-sm-size', 768 >= clientWidth <= 991);
                   root.toggleClass('int-md-size', 992 >= clientWidth <= 1199);
                   root.toggleClass('int-lg-size', 992 >= clientWidth <= 1199);
                   */
               }

               return arguments.callee;
           }()));
       });
   }());
