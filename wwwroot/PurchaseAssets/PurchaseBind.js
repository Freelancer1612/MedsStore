
var EmptyRow = "<tr><td colspan='12' class='text-center'>No Records Available</td></tr>";

$(document).ready(function(){

$("#tbl tbody").append(EmptyRow);
$("#btnPurchaseRowAdd").click(function()
{
	var code = $("#txtProductCode").val();
	var name = $("#txtProductName").val();
	var rate = $("#txtProductRate").val();
	var qty = $("#txtProductQuantity").val();
	var amount = rate*qty;
//var amount = rate * qty;

// validation

if(code != "" && name != "" && rate != "" && qty != "")
{
	if($("#tbl tbody").children().children().length ==1)
	{
		$("#tbl tbody").html("");
	}
	var S_No = $("#tbl tbody").children().length +1;

// Creating dynamic html string

var dynamicTr = "<tr><td>"+S_No+"</td><td>"+code+"</td><td>"+name+"</td><td>"+rate+"</td><td>"+qty+"</td><td>"+amount+"</td><td><button class='btn btn-danger btn-sm' id='btnDEL'>Delete</button></td></tr>";	$("#tbl tbody").append(dynamicTr);
	$("#txtProductCode").val("");
	$("#txtProductName").val("");
	$("#txtProductRate").val("");
	$("#txtProductQuantity").val("");
//		$("#txtProductAmount").val("");
	$("#btnDEL").click(function()
	{
		$(this).parent().parent().remove();
		if($("#tbl tbody").children().children().length == 0)
		{
			$("#tbl tbody").append(EmptyRow);
		}
	});
}
else
{
	alert("Please provide values");
}
});
});
