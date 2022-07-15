(function($) {
    $.anythingSlider = function(el, options) {
        var base = this;
        base.$el = $(el);
        base.el = el;
        base.currentPage = 1;
        base.timer = null;
        base.playing = false;
        base.$el.data("AnythingSlider", base);
        base.init = function() {
            base.options = $.extend({}, $.anythingSlider.defaults, options);
            base.$wrapper = base.$el.find('> div').css('overflow', 'hidden');
            base.$slider = base.$wrapper.find('> ul');
            base.$items = base.$slider.find('> li');
            base.$single = base.$items.filter(':first');
            if (base.options.buildNavigation) base.buildNavigation();
            base.singleWidth = base.$single.outerWidth();
            base.pages = base.$items.length;
            base.$items.filter(':first').before(base.$items.filter(':last').clone().addClass('cloned'));
            base.$items.filter(':last').after(base.$items.filter(':first').clone().addClass('cloned'));
            base.$items = base.$slider.find('> li');
            base.buildNextBackButtons();
            if (base.options.autoPlay) {
                base.playing = !base.options.startStopped;
                base.buildAutoPlay();
            };
            if (base.options.pauseOnHover) {
                base.$el.hover(function() {
                    base.clearTimer();
                }, function() {
                    base.startStop(base.playing);
                });
            }
            if ((base.options.hashTags == true && !base.gotoHash()) || base.options.hashTags == false) {
                base.setCurrentPage(1);
            };
        };
        base.gotoPage = function(page, autoplay) {
            if (autoplay !== true) autoplay = false;
            if (!autoplay) base.startStop(false);
            if (typeof(page) == "undefined" || page == null) {
                page = 1;
                base.setCurrentPage(1);
            };
            if (page > base.pages + 1) page = base.pages;
            if (page < 0) page = 1;
            var dir = page < base.currentPage ? -1 : 1,
                n = Math.abs(base.currentPage - page),
                left = base.singleWidth * dir * n;
            base.$wrapper.filter(':not(:animated)').animate({
                scrollLeft: '+=' + left
            }, base.options.animationTime, base.options.easing, function() {
                if (page == 0) {
                    base.$wrapper.scrollLeft(base.singleWidth * base.pages);
                    page = base.pages;
                } else if (page > base.pages) {
                    base.$wrapper.scrollLeft(base.singleWidth);
                    page = 1;
                };
                base.setCurrentPage(page);
            });
        };
        base.setCurrentPage = function(page, move) {
            if (base.options.buildNavigation) {
                base.$nav.find('.cur').removeClass('cur');
                $(base.$navLinks[page - 1]).addClass('cur');
            };
            if (move !== false) base.$wrapper.scrollLeft(base.singleWidth * page);
            base.currentPage = page;
        };
        base.goForward = function(autoplay) {
            if (autoplay !== true) autoplay = false;
            base.gotoPage(base.currentPage + 1, autoplay);
        };
        base.goBack = function() {
            base.gotoPage(base.currentPage - 1);
        };
        base.gotoHash = function() {
            if (/^#?panel-\d+$/.test(window.location.hash)) {
                var index = parseInt(window.location.hash.substr(7));
                var $item = base.$items.filter(':eq(' + index + ')');
                if ($item.length != 0) {
                    base.setCurrentPage(index);
                    return true;
                };
            };
            return false;
        };
        base.buildNavigation = function() {
            base.$nav = $("<div id='thumbNav'></div>").appendTo(base.$el);
            base.$items.each(function(i, el) {
                var index = i + 1;
                var $a = $("<a href='#'></a>");
                if (typeof(base.options.navigationFormatter) == "function") {
                    $a.html(base.options.navigationFormatter(index, $(this)));
                } else {
                    $a.text(index);
                }
                $a.click(function(e) {
                    base.gotoPage(index);
                    if (base.options.hashTags)
                        base.setHash('panel-' + index);
                    e.preventDefault();
                });
                base.$nav.append($a);
            });
            base.$navLinks = base.$nav.find('> a');
        };
        base.buildNextBackButtons = function() {
            var $forward = $('<a class="arrow forward">&gt;</a>'),
                $back = $('<a class="arrow back">&lt;</a>');
            $back.click(function(e) {
                base.goBack();
                e.preventDefault();
            });
            $forward.click(function(e) {
                base.goForward();
                e.preventDefault();
            });
            base.$wrapper.after($back).after($forward);
        };
        base.buildAutoPlay = function() {
            base.$startStop = $("<a href='#' id='start-stop'></a>").html(base.playing ? base.options.stopText : base.options.startText);
            base.$el.append(base.$startStop);
            base.$startStop.click(function(e) {
                base.startStop(!base.playing);
                e.preventDefault();
            });
            base.startStop(base.playing);
        };
        base.startStop = function(playing) {
            if (playing !== true) playing = false;
            base.playing = playing;
            if (base.options.autoPlay) base.$startStop.toggleClass("playing", playing).html(playing ? base.options.stopText : base.options.startText);
            if (playing) {
                base.clearTimer();
                base.timer = window.setInterval(function() {
                    base.goForward(true);
                }, base.options.delay);
            } else {
                base.clearTimer();
            };
        };
        base.clearTimer = function() {
            if (base.timer) window.clearInterval(base.timer);
        };
        base.setHash = function(hash) {
            if (typeof window.location.hash !== 'undefined') {
                if (window.location.hash !== hash) {
                    window.location.hash = hash;
                };
            } else if (location.hash !== hash) {
                location.hash = hash;
            };
            return hash;
        };
        base.init();
    };
    $.anythingSlider.defaults = {
        easing: "swing",
        autoPlay: true,
        startStopped: false,
        delay: 3000,
        animationTime: 600,
        hashTags: true,
        buildNavigation: true,
        pauseOnHover: true,
        startText: "Start",
        stopText: "Stop",
        navigationFormatter: null
    };
    $.fn.anythingSlider = function(options) {
        if (typeof(options) == "object") {
            return this.each(function(i) {
                (new $.anythingSlider(this, options));
                options.hashTags = false;
            });
        } else if (typeof(options) == "number") {
            return this.each(function(i) {
                var anySlide = $(this).data('AnythingSlider');
                if (anySlide) {
                    anySlide.gotoPage(options);
                }
            });
        }
    };
})(jQuery);
