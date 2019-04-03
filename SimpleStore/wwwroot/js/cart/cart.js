var SimpleStore = (function () {

    'use strict';

    /* =================== private methods ================= */
    // bind events
    function updateCartItem() {
        $(".update-cart-item").click(function (e) {

            var $row = $(this).parents('tr');

            var model = JSON.stringify({
                ProductId: $row.find('input[name="ProductId"]').val(),
                Quantity: $row.find('input[name="Quantity"]').val(),
                ReturnUrl: $row.find('input[name="ReturnUrl"]').val()
            });

            $.ajax({
                method: "POST",
                url: SimpleStore.updateAction,
                contentType: "application/json",
                data: model,
                dataType: "json",
                success: function (result, status, xhr) {
                    toastr.success(
                        result.resultMessage,
                        'Update cart item',
                        {
                            timeOut: 3000,
                            fadeOut: 1000,
                            onHidden: function () {
                                window.location.reload();
                            }
                        }
                    );
                },
                error: function (xhr, status, error) {
                    toastr.error('Something went wrong! Please try again.');
                }
            });
        });
    }

    // main init method
    function init() {
        updateCartItem();
        SimpleStore.updateAction = "";
    }

    /* =============== export public methods =============== */
    return {
        init: init
    };
}());