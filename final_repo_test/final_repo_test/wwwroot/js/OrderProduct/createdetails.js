
var orderDetailTemplate = '<tr>' +
    '<td>' +
    '<select class="form-control product-list" name="odetails.P_ID" required></select>' +
    '</td>' +
    '<td>' +
    '<input type="number" class="form-control quantity" name="odetails.Od_Quantity" min="1" value="1" required />' +
    '</td>' +
    '<td>' +
    '<span class="form-control price">0</span>' +
    '</td>' +
    '<td>' +
    '<span class="total-price">0</span>' +
    '</td>' +
    '<td>' +
    '<button type="button" class="btn btn-danger delete-order-detail">Delete</button>' +
    '</td>' +
    '</tr>';


$(function () {
    $('#add-order-detail').on('click', function (event) {
        //var index = $('#order-detail-list tr').length;
        //var newOrderDetail = orderDetailTemplate.replace(/\[0\]/g, '[' + index + ']');
        //$('#order-detail-list').append(newOrderDetail);
        var index = $('#order-detail-list tr').length;
        var newOrderDetail = $(orderDetailTemplate.replace(/\[0\]/g, '[' + index + ']'));
        var select = newOrderDetail.find('.product-list');
        for (var i = 0; i < products.length; i++) {
            select.append($('<option>', {
                value: products[i].p_ID,
                text: products[i].p_Name,
            }));
        }
        $('#order-detail-list').append(newOrderDetail);
    });
    $(document).on('change', '.product-list', function () {
        var row = $(this).closest('tr');
        var productId = $(this).val();

        $.ajax({
            url: `${getprice}`,
            type: 'GET',
            data: { productId: productId },
            success: function (price) {
                var quantity = row.find('.quantity').val();
                row.find('.price').text(price.toFixed(0));
                row.find('.total-price').text((price * quantity).toFixed(0));
                updateTotalPrice();
            },
            error: function () {
                alert('Error occurred while getting product price.');
            }
        });
    });
    $(document).on('change', '#quantity', test);
    $(document).on('click', '.delete-order-detail', function () {
        var orderDetailId = $(this).data('order-detail-id');
        var row = $(this).closest('tr');
        if (orderDetailId) {
            if (confirm('Are you sure you want to delete this order detail?')) {
                $.ajax({
                    url: `${deletedetail}`,
                    type: 'POST',
                    data: { orderDetailId: orderDetailId },
                    success: function () {
                        row.remove();
                        updateTotalPrice();
                    },
                    error: function () {
                        alert('Error occurred while deleting order detail.');
                    }
                });
            }
        } else {
            row.remove();
            updateTotalPrice();
        }
    });

    function updateTotalPrice() {
        var totalPrice = 0;

        $('.total-price').each(function () {
            var price = parseFloat($(this).text());
            if (!isNaN(price)) {
                totalPrice += price;
            }
        });

        $('#total-price').text(totalPrice.toFixed(0));
        $('#ordertotalprice').text(totalPrice.toFixed(0));
    }

    function test() {
        var row = $(this).closest('tr');
        var productId = $(this).val();
        var quantity = row.find('.quantity').val();
        var price = row.find('.price').text();

        row.find('.total-price').text((price * quantity).toFixed(0));
        updateTotalPrice();
    }

});