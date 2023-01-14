


$(function () {

    let scrollSection = document.getElementById("scrol-navbar-area")
  
    window.onscroll = function () { scrollFunction() };
  
    function scrollFunction() {
      if (document.body.scrollTop > 65 || document.documentElement.scrollTop > 65) {
        scrollSection.style.top = "0";
      } else {
        scrollSection.style.top = "-0px";
        scrollSection.classList.remove("visibl");
      }
    }

    $(window).scroll(function () {
        if ($(window).scrollTop() > 200) {
            $('.angleUp').css({
                "opacity": "1", "pointer-events": "auto"
            });
        } else {
            $('.angleUp').css({
                "opacity": "0", "pointer-events": "none"
            })
        }
    });
    $('.angleUp').click(function () {
        $('html').animate({ scrollTop: 0 }, 800)
    })



    $(document).on('click', '#deleteBtn', function () {
        var id = $(this).data('id')
        var basketCount = $('#basketCount')
        var basketCurrentCount = $('#basketCount').html()
        var id = $(this).data('id');
        var quantity = $(this).data('quantity')
        var sum = basketCurrentCount - quantity
       
        

        $.ajax({
            method: 'POST',
            url: "/basket/delete",
            data: {
                id : id
            },
            success: function (res) {
               
                Swal.fire({
                    icon: 'success',
                    title: 'Product deleted',
                    showConfirmButton: false,
                    timer: 1500
                })

          
                $(`.basket-product[id=${id}]`).remove();
                basketCount.html("")
                basketCount.append(sum)
                location.reload();

              
            }
        })

    })
  
  
  });
  






