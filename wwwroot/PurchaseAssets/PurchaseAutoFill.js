$(function () {

  //overriding jquery-ui.autocomplete .js functions

  $.ui.autocomplete.prototype._renderMenu = function (ul, items) {
    var self = this;

    //table definitions

    ul.append("<table><thead><tr><th>Product&nbsp;&nbsp;Code#</th><th>Product&nbsp;&nbsp;Name</th><th>Rate</th><th>Quantity</th><th>Amount</th></tr></thead><tbody></tbody></table>");

    $.each(items, function (index, item) {
      self._renderItemData(ul, ul.find("table tbody"), item);
    });
  };
  $.ui.autocomplete.prototype._renderItemData = function (ul, table, item) {
    return this._renderItem(table, item).data("ui-autocomplete-item", item);
  };
  $.ui.autocomplete.prototype._renderItem = function (table, item) {
    return $("<tr class='ui-menu-item' role='presentation'></tr>")

      //.data( "item.autocomplete", item )

      .append("<td >" + item.ProductCode + "</td>" + "<td>" + item.ProductName + "</td>" + "<td>" + item.ProductRate + "</td>" + "<td>" + item.ProductQuantity + "</td>" + "<td>" + item.ProductAmount + "</td>")
      .appendTo(table);
  };

  //random json values

  var projects = [{
    ProductCode: 1,
    ProductName: "Thomas",
    ProductRate: 100,
    ProductQuantity: 1,
    ProductAmount: 200
  },
  {
    ProductCode: 2,
    ProductName: "san",
    ProductRate: 10,
    ProductQuantity: 2,
    ProductAmount: 20
  },
  {
    ProductCode: 3,
    ProductName: "gopi",
    ProductRate: 25,
    ProductQuantity: 4,
    ProductAmount: 100
  },

  {
    ProductCode: 4,
    ProductName: "tamil",
    ProductRate: 50,
    ProductQuantity: 3,
    ProductAmount: 150
  }];
  
  $("#txtProductName").autocomplete({
    minLength: 1,
    source: projects,

    focus: function (event, ui) {
      console.log(ui.item.ProductName);
      $("#txtProductName").val(ui.item.ProductName);
      $("#txtProductCode").val(ui.item.ProductCode);
      $("#txtProductRate").val(ui.item.ProductRate);
      $("#txtProductQuantity").val(ui.item.ProductQuantity);
      $("#txtProductAmount").val(ui.item.ProductAmount);

      return false;

    } 
    
    //you can write for select too
    /*select:*/
    
  })
});
