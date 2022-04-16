/* ========================================================================= */
function Init() {
    Events();
}

/* ======================================================*/

///Events

function Events() {
    Clearall();

    $("#btnSearch").click(function () {
        GetPurchaseDetails();
    })

}
//Get the Details 
function GetPurchaseDetails() {
    if (Validation()) 
    {
        var t_GRNID = $("#txtGRNID").val();
    $.ajax({
        url: "/Purchase/GetPurchase",
        type: "POST",
        data: {
            "GRNID": t_GRNID
        },
        success: function (Response) {
            if (Response != null) {
                if (Response.status == "Success") {
                    BindData(Response.result);
                }
            }
            else {
                alert(Response.message);
            }
        },
        error: function (error) {
            alert(error);
        }
    });
}
}

function Validation() {

    var IsVaild = true;

    var t_GRNID = $("#txtGRNID").val();

    if (t_GRNID == "")
     {
        alert("Please provide GRNID correctly");
        IsVaild = false;
    }
    return IsVaild;
}
/* ========================================================================= */

//Display the Data 

function BindData(Data) {

    /* Declearation */
    var t_tableBodyId = "#tbPurchasesDetails";
    var t_TR, t_TD = null;
    $(t_tableBodyId).html("");
    if (Data != null) {
        for (var i = 0; i < Data.length; i++) {

            t_TR = $(document.createElement("tr"));

            t_TD = $(document.createElement("td"));
            t_TD.html(i + 1);
            t_TD.appendTo(t_TR);

            t_TD = $(document.createElement("td"));
            t_TD.html(Data[i].ProductCode);
            t_TD.appendTo(t_TR);

            t_TD = $(document.createElement("td"));
            t_TD.html(Data[i].ProductName);
            t_TD.appendTo(t_TR);

            t_TD = $(document.createElement("td"));
            t_TD.html(Data[i].PurchaseRate);
            t_TD.appendTo(t_TR);

            t_TD = $(document.createElement("td"));
            t_TD.html(Data[i].PurchaseQuantity);
            t_TD.appendTo(t_TR);

            t_TD = $(document.createElement("td"));
            t_TD.html(Data[i].PurchaseAmount);
            t_TD.appendTo(t_TR);

          // t_TD = $(document.createElement("td"));
          // t_TD.html("<i class=\"btn btn-primary\" style=\"color:white\" aria-hidden=\"true\" onclick=\"EditRecord(" + Data[i].productId + ")\">Edit</i>");
          // t_TD.appendTo(t_TR);

            t_TD = $(document.createElement("td"));
            t_TD.html("<i class=\"btn btn-danger glyphicon glyphicon-trash\"  style=\"color:white\" aria-hidden=\"true\" onclick=\"DeleteRecord(" + Data[i].productId + ")\"></i>");
            t_TD.appendTo(t_TR);

            t_TR.appendTo(t_tableBodyId);
        }
    }
}
/* ========================================================================= */

// Edit the Record 

function EditRecord(ProductId) {
    window.location.href = "/Product/Edit/" + ProductId
}

/* ========================================================================= */

// Delete the Record 

function DeleteRecord(ProductId) {

    $.ajax({
        url: "/Product/DeleteProduct",
        type: "POST",
        data: {
            ProductId: ProductId
        },
        success: function (Response) {
            if (Response != null) {
                if (Response.status == "Success") {
                    alert("Product has been Removed");
                    GetDetails();
                }
            }
            else {
                alert(Response.message);
            }
        },
        error: function (error) {
            alert(error);
        }
    });
}