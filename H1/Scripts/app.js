var app = function() {

    $(function() {
        navToggleRight();
        navToggleLeft();
        navToggleSub();
        profileToggle();
        toggleSettings();
        fullscreenWidget();
        fullscreenMode();
        widgetToggle();



    });

    var widgetToggle = function () {
        $(".actions > .fa-chevron-down").click(function () {
            $(this).parent().parent().next().slideToggle("fast"), $(this).toggleClass("fa-chevron-down fa-chevron-up")
        });
    };
    var toggleSettings = function () {
        $('.config-link').click(function () {
            if ($(this).hasClass('open')) {
                $('#config').animate({
                    "right": "-205px"
                }, 150);
                $(this).removeClass('open').addClass('closed');
            } else {
                $("#config").animate({
                    "right": "0px"
                }, 150);
                $(this).removeClass('closed').addClass('open');
            }
        });
    };

    var navToggleRight = function() {
        $('#toggle-right').on('click', function() {
            $('#sidebar-right').toggleClass('sidebar-right-open');
            $("#toggle-right .fa").toggleClass("fa-indent fa-dedent");

        });
    };

   

    var navToggleLeft = function() {
        $('#toggle-left').on('click', function() {
            var bodyEl = $('#main-wrapper');
            ($(window).width() > 767) ? $(bodyEl).toggleClass('sidebar-mini'): $(bodyEl).toggleClass('sidebar-opened');
        });
    };

    var navToggleSub = function() {
        var subMenu = $('.sidebar .nav');
        $(subMenu).navgoco({
            caretHtml: false,
            accordion: true
        });

    };

    var profileToggle = function() {
        $('#toggle-profile').click(function() {
            $('.sidebar-profile').slideToggle();
        });
    };

    var fullscreenWidget = function () {
        $('.panel .fa-expand').click(function () {
            var panel = $(this).closest('.panel');
            panel.toggleClass('widget-fullscreen');
            $(this).toggleClass('fa-expand fa-compress');
            $('body').toggleClass('fullscreen-widget-active')
            $('footer').toggleClass('fullscreen-widget-active')

        })
    };

    var fullscreenMode = function () {
        $('#toggle-fullscreen.expand').on('click', function () {
            $(document).toggleFullScreen()
            $('#toggle-fullscreen .fa').toggleClass('fa-expand fa-compress');
        });
    };



    //return functions
    return {

    };
}();

function showMsgErro(msg) {
    Messenger.options = {
        extraClasses: 'messenger-fixed messenger-on-top messenger-on-right',
        theme: 'flat'
    }
    Messenger( ).post({
        
        message: msg,
        type: 'error',
        showCloseButton: true,
        hideAfter: 8
    });
}

function showMsgSuccess(msg) {
    Messenger.options = {
        extraClasses: 'messenger-fixed messenger-on-top messenger-on-right',
        theme: 'flat'
    }
    Messenger().post({
        message: msg,
        type: 'success',
        showCloseButton: true,
        hideAfter: 8
    });
}

function showMsgInfo(msg) {

    Messenger.options = {
        extraClasses: 'messenger-fixed messenger-on-top messenger-on-right',
        theme: 'flat'
    }
    Messenger().post({
        message: msg,
        type: 'info',
        showCloseButton: true,
        hideAfter: 8
    });
}


