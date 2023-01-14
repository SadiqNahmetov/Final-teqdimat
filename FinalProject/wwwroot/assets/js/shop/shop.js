
"use strict"


$(document).on("click", ".show-more .my-button", function () {
    console.log("ok")
    let parent = $("#parent-products");

    let skipCount = $("#parent-products").children().length;

    let productCount = $("#product-count").val();


    $.ajax({

        url: "/shop/loadmore",
        type: "Get",
        data: {
            skip: skipCount
        },
        success: function (res) {

            $(parent).append(res);

            skipCount = $("#parent-products").children().length;

            if (skipCount >= productCount) {

                $(".show-more .my-button").addClass("d-none");
            }
        }
    })
})

    // product wishlist start
    let wishlistBtns = document.querySelectorAll("#product-area .card .icon-shop .wishList")

    let products = [];

    if (localStorage.getItem("products")) {
        products = JSON.parse(localStorage.getItem("products"))
    }

    document.querySelector(".heart sup").innerText = getProductsCount(products);
    document.querySelector("#scrol-navbar-area .heart sup").innerHTML = getProductsCount(products);

    wishlistBtns.forEach(wishlistBtn => {

        let productId = parseInt(wishlistBtn.parentNode.parentNode.parentNode.parentNode.getAttribute("cart-id"));

        let existProduct = products.find(m => m.id == productId);
        if (existProduct && products.includes(existProduct)) {
            wishlistBtn.classList.add('heart-active')
        }
        wishlistBtn.addEventListener("click", function (e) {
            e.preventDefault();
            if (!wishlistBtn.classList.contains("heart-active")) {

                wishlistBtn.classList.add("heart-active")

                let productImage = this.parentNode.parentNode.previousElementSibling.getAttribute("src");
                let productBrand = this.parentNode.parentNode.parentNode.nextElementSibling.firstElementChild.innerText;
                let productName = this.parentNode.parentNode.parentNode.nextElementSibling.firstElementChild.nextElementSibling.innerText;
                let productPrice = this.parentNode.parentNode.parentNode.nextElementSibling.nextElementSibling.firstElementChild.innerText;
                let productDisCountPrice = this.parentNode.parentNode.parentNode.nextElementSibling.nextElementSibling.firstElementChild.nextElementSibling.innerText;
                let productId = parseInt(this.parentNode.parentNode.parentNode.parentNode.getAttribute("cart-id"));

                let existProduct = products.find(m => m.id == productId);
                if (existProduct != undefined) {
                    existProduct.count += 0;
                }
                else {
                    products.push({

                        id: productId,
                        brand: productBrand,
                        image: productImage,
                        name: productName,
                        price: productPrice,
                        discountprice: productDisCountPrice,
                        count: 1
                    })
                    document.querySelector(".heart sup").innerText = getProductsCount(products);
                    document.querySelector("#scrol-navbar-area .heart sup").innerHTML = getProductsCount(products);

                }


                localStorage.setItem("products", JSON.stringify(products));
                document.querySelector(".heart sup").innerText = getProductsCount(products);
                document.querySelector("#scrol-navbar-area .heart sup").innerHTML = getProductsCount(products);
            }
            else {

                wishlistBtn.classList.remove("heart-active");

                let productId = parseInt(this.parentNode.parentNode.parentNode.parentNode.getAttribute("cart-id"));

                let existProduct = products.find(m => m.id == productId);
                if (existProduct) {

                    const newProducts = products.filter(m => m !== existProduct);
                    localStorage.setItem('products', JSON.stringify(newProducts));
                    document.querySelector(".heart sup").innerText = getProductsCount(newProducts);
                    document.querySelector("#scrol-navbar-area .heart sup").innerHTML = getProductsCount(newProducts);
                    window.location.reload()
                }

            }


        })
    });

    function getProductsCount(items) {
        return items.length;
    }

    //wishlist end



    let headers = document.querySelectorAll("#product-area .category .my-btn");
    let contents = document.querySelectorAll(".card")

    headers.forEach(header => {
        header.addEventListener("click", function () {
            let activeElem = document.querySelector(".tab-active");
            activeElem.classList.remove("tab-active");
            this.classList.add("tab-active");

            contents.forEach(content => {
                if (this.getAttribute("data-id") == content.getAttribute("data-id")) {
                    content.parentNode.classList.remove("d-none")
                } else {
                    content.parentNode.classList.add("d-none")
                }
                if (this.getAttribute("data-id") == undefined) {
                    content.parentNode.classList.remove("d-none")
                }
            });
        })
    });

  




    $(document).ready(function () {
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
    });

