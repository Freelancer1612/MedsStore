
// Init function
function Init() {
    Events();
}

/* ======================================================*/

///Events

function Events() {
    Clearall();

    $("#txtPurchaseSave").click(function () {
        Save();
    });

    $("#txtPurchaseCancel").click(function () {
        Cancel();
    })

}

/* ======================================================*/

// Clear 

function Clearall() {

    $("#txtGRNID").val("");
    $("#txtGRNDate").val("");
    $("#txtSupplierCash").val("");
}

/* ======================================================*/

// Save 

function Save() {
    if (Validation()) 
    {

//Get Header information

        var t_GRNID = $("#txtGRNID").val();
        var t_GRNDate = $("#txtGRNDate").val();
        var t_SupplierType="cash";
        var t_SupplierCash = $("#txtSupplierCash").val();        
        var t_SupplierID=0;
        var t_SupplierName="Null"
        var t_TotalQty=0;
        var t_TotalAmount=0;

 //Get Detail Information 

        var t_RowCount=$("#tbl tbody tr").length;
        var t_ListDetails=[];
        var col_ProductCode=1;
        for(var i=0; i < t_RowCount; i++)
        {
            t_ListDetails.push({
                ProductCode:$($($("#tbl tbody tr")[i]).find("td")[col_ProductCode]).text(),
                ProductName:$($($("#tbl tbody tr")[i]).find("td")[2]).text(),
                PurchaseRate:$($($("#tbl tbody tr")[i]).find("td")[3]).text(),
                PurchaseQuantity:$($($("#tbl tbody tr")[i]).find("td")[4]).text(),
                PurchaseAmount: $($($("#tbl tbody tr")[i]).find("td")[5]).text()
            })
        }
        $.ajax({
            url: "/Purchase/SetPurchase",
            type: "POST",
            data: 
            {
                "Header": 
                {
                    "GRNID": t_GRNID,
                    "GRNDate": t_GRNDate,
                    "SupplierType": t_SupplierType,
                    "SupplierId": t_SupplierID,
                    "SupplierName": t_SupplierName,
                    "SupplierCash": t_SupplierCash,
                    "TotalQty": t_TotalQty,
                    "TotalAmount": t_TotalAmount
                },
                "Details": t_ListDetails
            },
            success: function (Response) 
            {
                if (Response != null) {
                    if (Response.status == "Success") 
                    {
                        alert(Response.message);
                        Clearall();
                    }
                    else 
                    {
                        alert(Response.message);
                    }
                }
            },

            error: function (Error) {
            alert(Error);
            }
        });
    }
}
/* ======================================================*/

// Validation 

function Validation() {

    var IsVaild = true;

    var t_GRNID = $("#txtGRNID").val();
    var t_GRNDate = $("#txtGRNDate").val();

    if (t_GRNID == "")
     {
        alert("Please provide GRNID correctly");
        IsVaild = false;
    }
    else if (t_GRNDate == "") {
        alert("Please provide GRN Date correctly");
        IsVaild = false;
    }
    return IsVaild;
}
/* ======================================================*/

// Cancel 

function Cancel() {
    Clearall();

}
/* ======================================================*/

//The END
