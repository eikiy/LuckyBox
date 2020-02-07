(function($) {
"use strict";


jQuery('.goTop').click(function(){
    jQuery("html, body").animate({ scrollTop: 0 }, 700);
    return false;
});


jQuery('button.smallScreenNav').on('click', function() {
	jQuery('.main-nav ul').toggleClass('smallNavMenu');
});


jQuery('.vjs-big-play-button').on('click', function(event) {
	jQuery('.pattern').remove();
});



if (jQuery(window).width() > 1600) {
	jQuery(document).scroll(function() {

		if (jQuery(this).scrollTop() > 1600) {

			jQuery('.animationElementsWrapp img.hitem1').css({
				left: '-490px',
				opacity: 1
			});

			setTimeout(function() {
				jQuery('.animationElementsWrapp img.hitem2').css({
					opacity: 1,
					top: 420
				});
			}, 800);

			setTimeout(function() {
				jQuery('.animationElementsWrapp img.hitem3').css({
					opacity: 1,
					top: 200
				});
			}, 400);

			setTimeout(function() {
				jQuery('.animationElementsWrapp img.hitem6').css({
					opacity: 1,
					top: 420
				});
			}, 320);

			setTimeout(function() {
				jQuery('.animationElementsWrapp img.hitem4').css({
					opacity: 1,
					left: 30
				});
			}, 600);

			setTimeout(function() {
				jQuery('.animationElementsWrapp img.hitem5').css({
					opacity: 1,
					left: 70,
					top: 140
				});
			}, 800);

		} else {
			jQuery('.animationElementsWrapp img').css('opacity', 0);
		}
	});

} else {

	jQuery('.animationElementsWrapp img.hitem1').css({
		left: '-490px',
		opacity: 1
	});

	setTimeout(function() {
		jQuery('.animationElementsWrapp img.hitem2').css({
			opacity: 1,
			top: 420
		});
	}, 800);

	setTimeout(function() {
		jQuery('.animationElementsWrapp img.hitem3').css({
			opacity: 1,
			top: 200
		});
	}, 400);

	setTimeout(function() {
		jQuery('.animationElementsWrapp img.hitem6').css({
			opacity: 1,
			top: 420
		});
	}, 320);

	setTimeout(function() {
		jQuery('.animationElementsWrapp img.hitem4').css({
			opacity: 1,
			left: 30
		});
	}, 600);

	setTimeout(function() {
		jQuery('.animationElementsWrapp img.hitem5').css({
			opacity: 1,
			left: 70,
			top: 140
		});
	}, 800);
}


if (jQuery(window).width() < 1600) {

	jQuery('.fullscreen-container').remove();
}


jQuery(window).load(function() {
	jQuery('img.el1').css({
		top: -110,
		left: '35%',
		opacity: 1
	});

	jQuery('img.el2').css({
		top: -150,
		left: '52%',
		opacity: 1
	});

	jQuery('img.el3').css({
		top: -110,
		left: '67%',
		opacity: 1
	});

	jQuery('img.el4').css({
		top: 350,
		left: '45%',
		opacity: 1
	});


	setTimeout(function() {
		jQuery('a.slideDown').fadeIn('slow');
	}, 1200);

});



jQuery('a.slideDown').on('click', function(event) {
	var bHeight = jQuery('#big-video-wrap, #supersized_wrapper').height();
	jQuery("html, body").animate({ scrollTop: bHeight }, 1200);
	return false;
});




jQuery(window).load(function() {
	jQuery('img.aitem').addClass('animateIt');

	jQuery('.preloader').fadeOut('slow', function() {
		jQuery(this).remove();
	});
});


jQuery("a[rel^='prettyPhoto']").prettyPhoto();


jQuery(window).resize(function(event) {
	if ($(window).width() < 890	) {
		$('body').css('overflow-x', 'hidden');
	} else {

	}
});


/*----------------------------------------------------*/
/* MOBILE AND TABLET DETECT FUNCTION
/*----------------------------------------------------*/

var isMobile = {
    Android: function() {
        return navigator.userAgent.match(/Android/i);
    },
    BlackBerry: function() {
        return navigator.userAgent.match(/BlackBerry/i);
    },
    iOS: function() {
        return navigator.userAgent.match(/iPhone|iPad|iPod/i);
    },
    Opera: function() {
        return navigator.userAgent.match(/Opera Mini/i);
    },
    Windows: function() {
        return navigator.userAgent.match(/IEMobile/i);
    },
    any: function() {
	    return (isMobile.Android() || isMobile.BlackBerry() || isMobile.iOS() || isMobile.Opera() || isMobile.Windows());
	}
};

function parallaxInit() {
	var testMobile = isMobile.any();
	if (testMobile == null) {

		$('.animationStart').css('opacity', 0);

		$('.animationStart').waypoint(function() {
		  $(this).addClass('animated fadeInUp');
		}, { offset: '30%' });
	}
}

$(window).bind("load", function() {
    parallaxInit()
});


})(jQuery);














