//عملت get للبيانات و عرضتها


$.ajax({
    url: "http://localhost:44370/manageProduct/getProduct",
    type: "get",
    contentType: "application/json",
    success: function (result, status, xhr) {
        console.log(result);
        $.each(result/*.$values*/, function (index, value) {
            $("tbody").append($("<tr>"));
            appendElement = $("tbody tr").last();
            appendElement.append($("<td>").html(value["id"]));
            appendElement.append($("<td>").html(value["name"]));
            appendElement.append($("<td>").html(value["price"]));
            appendElement.append($("<td>").html(value["quantity"]));

            //if (value["cat"]){
            //    appendElement.append($("<td>").html(value["cat"]["name"]));
            //}
            //appendElement.append($("<td>").html(""));
          
        });
    },
    error: function (xhr, status, error) {
        console.log(xhr)
    }
});