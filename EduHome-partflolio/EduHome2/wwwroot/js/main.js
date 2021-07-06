

$(document).ready(function() {

    $(".menu-items .menu").on("click", function(e) {
        e.preventDefault()
        $(".custom-navbar-responsive").slideToggle(300);
        if ($(this).find("i").hasClass("fa-bars")) {
            $(this).find("i").removeClass("fa-bars");
            $(this).find("i").addClass("fa-times");
        } else {
            $(this).find("i").removeClass("fa-times");
            $(this).find("i").addClass("fa-bars");
        }
    })
    $(window).scroll(function() {
        
        if ($("html").scrollTop() >= 68) {
            $("header .header-bottom").addClass("scrolled");
            $("header .header-bottom").css("top", "0px");
            $(".custom-nav-item .custom-nav-link").css("line-height", "58px")
            $(".media").css("padding", "11px 0px")
            $(".Icon").css("line-height", "58px")
        } else {
            $("header .header-bottom").removeClass("scrolled");
            $("header .header-bottom").css("top", "68px");
            $(".custom-nav-item .custom-nav-link").css("line-height", "130px")
            $(" .Icon").css("line-height", "130px")
            $(".media").css("padding", "47px 0px 30px")
        }

    });
    $(".Icon").on("click", function() {
        $(".search").css("opacity", "1")
        $(".search").css("dispaly", "block")
        $(".search").slideToggle()
    })
    $(".custom-navbar-responsive .custom-nav-container .plus").on("click", function(e) {
        e.preventDefault();
        $(this).prev().slideToggle(300);
    })

    $('.owl-items').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        arrows: false,
    });
    $("#scrollup").click(function(e) {
        e.preventDefault()
        $("html").animate({ scrollTop: 0 });
    })

    //Backend Code
    $(".addToCard").click(function (e) {
        e.preventDefault();
        let CourseId = $(this).attr("data-courseId");
        console.log(CourseId)

        $.ajax({
            url: "Course/AddToCard/",
            data: {
                courseId: CourseId
            },
            type: "GET",
            dataType: "JSON",
            success: function (response) {
                console.log(response)

                if (response.responsType != "not-added") {

                    let cartCount = parseInt($("#cart-count").text());

                    if (!isNaN(cartCount)) {
                        $("#cart-count").text(cartCount + 1);
                    } else {
                        $("#cart-count").text(1);
                    }
                }
            }, error: function (error) {
                console.log(error)
            }
        });
    });
})