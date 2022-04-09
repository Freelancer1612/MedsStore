#pragma checksum "C:\Users\Gopivigneshkumar\source\MedsStore\Views\Customer\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4129dcf7a909eb476943cc96b4a2f760469b09cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Test), @"mvc.1.0.view", @"/Views/Customer/Test.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Test.cshtml", typeof(AspNetCore.Views_Customer_Test))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Gopivigneshkumar\source\MedsStore\Views\_ViewImports.cshtml"
using MedsOnline;

#line default
#line hidden
#line 2 "C:\Users\Gopivigneshkumar\source\MedsStore\Views\_ViewImports.cshtml"
using MedsOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4129dcf7a909eb476943cc96b4a2f760469b09cb", @"/Views/Customer/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fed8639d8283172c22cd0b1c782801d54d3c710e", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2052, true);
            WriteLiteral(@"<!-- bootstrap & fontawesome -->
		<link rel=""stylesheet"" href=""/assets/css/bootstrap.min.css"" />
		<!-- ace styles -->
		<link rel=""stylesheet"" href=""/assets/css/ace.min.css"" class=""ace-main-stylesheet"" id=""main-ace-style"" />

<div class=""row"">
	<div class=""col-xs-12"">
		<h3 class=""header smaller lighter blue"">Customer Details</h3>
		<div class=""pull-right tableTools-container"">
	<div class=""dt-buttons btn-overlap btn-group"">
		<a class=""dt-button buttons-collection buttons-colvis btn btn-white btn-primary btn-bold"">
			<span>
				<i class=""fa fa-search bigger-110 blue""></i>
				<span class=""hidden"">Show or hide column</span>
			</span>
		</a>
		<a class=""dt-button buttons-collection buttons-colvis btn btn-white btn-primary btn-bold"">
			<span>
				<i class=""fa fa-copy bigger-110 pink""></i>
				<span class=""hidden"">Copy to clipboard</span>
			</span>
		</a>
		<a class=""dt-button buttons-collection buttons-colvis btn btn-white btn-primary btn-bold"">
			<span>
				<i class=""fa fa-databa");
            WriteLiteral(@"se bigger-110 orange""></i>
				<span class=""hidden"">Export to CSV</span>
			</span>
		</a>
		<a class=""dt-button buttons-collection buttons-colvis btn btn-white btn-primary btn-bold"">
			<span>
				<i class=""fa fa-print bigger-110 grey""></i>
				<span class=""hidden"">Print</span>
			</span>
		</a>
</div>
</div>
		<div class=""clearfix"">
			<div class=""pull-right tableTools-container""></div>
		</div>
		<div class=""table-header"">
			Results for ""Latest Registered Domains""
		</div>
		<div>
			<table id=""dynamic-table"" class=""table table-striped table-bordered table-hover results"">
				<thead>
					<tr>
						<th class=""center"">
							<label class=""pos-rel"">
								<input type=""checkbox"" class=""ace"" />
								<span class=""lbl""></span>
							</label>
						</th>
						<th class=""hide"">Customer ID</th>
						<th>Customer Name</th>
						<th>Contact No</th>
						<th>Email</th>
						<th>Landmark</th>
						<th>City</th>
						<th>Outstanding Amount</th>
						<th></th>
					</t");
            WriteLiteral("r>\r\n");
            EndContext();
            BeginContext(2192, 2111, true);
            WriteLiteral(@"				</thead>

				<tbody>
					<tr>
						<td class=""center"">
							<label class=""pos-rel"">
								<input type=""checkbox"" class=""ace"" />
								<span class=""lbl""></span>
							</label>
						</td>
						<td class=""hide""></td>
						<td></td>
						<td></td>
						<td></td>
						<td></td>
						<td></td>
						<td></td>
						<td style=""text-align: center ;"">
							<div class=""hidden-sm hidden-xs action-buttons"">
								<a class=""blue"" href=""#"">
									<i class=""ace-icon fa fa-search-plus bigger-130""></i>
								</a>

								<a class=""green"" href=""#"">
									<i class=""ace-icon fa fa-pencil bigger-130""></i>
								</a>

								<a class=""red"" href=""#"">
									<i class=""ace-icon fa fa-trash-o bigger-130""></i>
								</a>
							</div>

							<div class=""hidden-md hidden-lg"">
								<div class=""inline pos-rel"">
									<button class=""btn btn-minier btn-yellow dropdown-toggle"" data-toggle=""dropdown""
										data-position=""auto"">
										<i class=""ace-icon");
            WriteLiteral(@" fa fa-caret-down icon-only bigger-120""></i>
									</button>

									<ul
										class=""dropdown-menu dropdown-only-icon dropdown-yellow dropdown-menu-right dropdown-caret dropdown-close"">
										<li>
											<a href=""#"" class=""tooltip-info"" data-rel=""tooltip"" title=""View"">
												<span class=""blue"">
													<i class=""ace-icon fa fa-search-plus bigger-120""></i>
												</span>
											</a>
										</li>

										<li>
											<a href=""#"" class=""tooltip-success"" data-rel=""tooltip"" title=""Edit"">
												<span class=""green"">
													<i class=""ace-icon fa fa-pencil-square-o bigger-120""></i>
												</span>
											</a>
										</li>

										<li>
											<a href=""#"" class=""tooltip-error"" data-rel=""tooltip"" title=""Delete"">
												<span class=""red"">
													<i class=""ace-icon fa fa-trash-o bigger-120""></i>
												</span>
											</a>
										</li>
									</ul>
								</div>
							</div>
						</td>
			");
            WriteLiteral("\t\t</tr>\r\n\t\t\t\t</tbody>\r\n\t\t\t</table>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4320, 49, true);
                WriteLiteral("\r\n<!-- basic scripts -->\r\n\r\n\t\t<!--[if !IE]> -->\r\n");
                EndContext();
                BeginContext(4431, 9068, true);
                WriteLiteral(@"
		<!-- <![endif]-->

		<!--[if IE]>
<script src=""assets/js/jquery-1.11.3.min.js""></script>
<![endif]-->
		<script type=""text/javascript"">
			if('ontouchstart' in document.documentElement) document.write(""<script src='assets/js/jquery.mobile.custom.min.js'>""+""<""+""/script>"");
		</script>
		<script src=""/assets/js/bootstrap.min.js""></script>

		<!-- page specific plugin scripts -->
		<script src=""/assets/js/jquery.dataTables.min.js""></script>
		<script src=""/assets/js/jquery.dataTables.bootstrap.min.js""></script>
		<script src=""/assets/js/dataTables.buttons.min.js""></script>
		<script src=""/assets/js/buttons.flash.min.js""></script>
		<script src=""/assets/js/buttons.html5.min.js""></script>
		<script src=""/assets/js/buttons.print.min.js""></script>
		<script src=""/assets/js/buttons.colVis.min.js""></script>
		<script src=""/assets/js/dataTables.select.min.js""></script>

		<!-- ace scripts -->
		<script src=""/assets/js/ace-elements.min.js""></script>
		<script src=""/assets/js/ace.min.js""></scrip");
                WriteLiteral(@"t>

		<!-- inline scripts related to this page -->
		<script type=""text/javascript"">
			jQuery(function($) {
				//initiate dataTables plugin
				var myTable = 
				$('#dynamic-table')
				//.wrap(""<div class='dataTables_borderWrap' />"")   //if you are applying horizontal scrolling (sScrollX)
				.DataTable( {
					bAutoWidth: false,
					""aoColumns"": [
					  { ""bSortable"": false },
					  null, null,null, null, null,
					  { ""bSortable"": false }
					],
					""aaSorting"": [],
					
					
					//""bProcessing"": true,
			        //""bServerSide"": true,
			        //""sAjaxSource"": ""http://127.0.0.1/table.php""	,
			
					//,
					//""sScrollY"": ""200px"",
					//""bPaginate"": false,
			
					//""sScrollX"": ""100%"",
					//""sScrollXInner"": ""120%"",
					//""bScrollCollapse"": true,
					//Note: if you are applying horizontal scrolling (sScrollX) on a "".table-bordered""
					//you may want to wrap the table inside a ""div.dataTables_borderWrap"" element
			
					//""iDisplayLength"": 50
			
			");
                WriteLiteral(@"
					select: {
						style: 'multi'
					}
			    } );
			
				
				
				$.fn.dataTable.Buttons.defaults.dom.container.className = 'dt-buttons btn-overlap btn-group btn-overlap';
				
				new $.fn.dataTable.Buttons( myTable, {
					buttons: [
					  {
						""extend"": ""colvis"",
						""text"": ""<i class='fa fa-search bigger-110 blue'></i> <span class='hidden'>Show/hide columns</span>"",
						""className"": ""btn btn-white btn-primary btn-bold"",
						columns: ':not(:first):not(:last)'
					  },
					  {
						""extend"": ""copy"",
						""text"": ""<i class='fa fa-copy bigger-110 pink'></i> <span class='hidden'>Copy to clipboard</span>"",
						""className"": ""btn btn-white btn-primary btn-bold""
					  },
					  {
						""extend"": ""csv"",
						""text"": ""<i class='fa fa-database bigger-110 orange'></i> <span class='hidden'>Export to CSV</span>"",
						""className"": ""btn btn-white btn-primary btn-bold""
					  },
					  {
						""extend"": ""excel"",
						""text"": ""<i class='fa fa-file-excel-o bigger-110");
                WriteLiteral(@" green'></i> <span class='hidden'>Export to Excel</span>"",
						""className"": ""btn btn-white btn-primary btn-bold""
					  },
					  {
						""extend"": ""pdf"",
						""text"": ""<i class='fa fa-file-pdf-o bigger-110 red'></i> <span class='hidden'>Export to PDF</span>"",
						""className"": ""btn btn-white btn-primary btn-bold""
					  },
					  {
						""extend"": ""print"",
						""text"": ""<i class='fa fa-print bigger-110 grey'></i> <span class='hidden'>Print</span>"",
						""className"": ""btn btn-white btn-primary btn-bold"",
						autoPrint: false,
						message: 'This print was produced using the Print button for DataTables'
					  }		  
					]
				} );
				myTable.buttons().container().appendTo( $('.tableTools-container') );
				
				//style the message box
				var defaultCopyAction = myTable.button(1).action();
				myTable.button(1).action(function (e, dt, button, config) {
					defaultCopyAction(e, dt, button, config);
					$('.dt-button-info').addClass('gritter-item-wrapper gritter-info gritter-c");
                WriteLiteral(@"enter white');
				});
				
				
				var defaultColvisAction = myTable.button(0).action();
				myTable.button(0).action(function (e, dt, button, config) {
					
					defaultColvisAction(e, dt, button, config);
					
					
					if($('.dt-button-collection > .dropdown-menu').length == 0) {
						$('.dt-button-collection')
						.wrapInner('<ul class=""dropdown-menu dropdown-light dropdown-caret dropdown-caret"" />')
						.find('a').attr('href', '#').wrap(""<li />"")
					}
					$('.dt-button-collection').appendTo('.tableTools-container .dt-buttons')
				});
			
				////
			
				setTimeout(function() {
					$($('.tableTools-container')).find('a.dt-button').each(function() {
						var div = $(this).find(' > div').first();
						if(div.length == 1) div.tooltip({container: 'body', title: div.parent().text()});
						else $(this).tooltip({container: 'body', title: $(this).text()});
					});
				}, 500);
				
				
				
				
				
				myTable.on( 'select', function ( e, dt, type, index ) {
                WriteLiteral(@"
					if ( type === 'row' ) {
						$( myTable.row( index ).node() ).find('input:checkbox').prop('checked', true);
					}
				} );
				myTable.on( 'deselect', function ( e, dt, type, index ) {
					if ( type === 'row' ) {
						$( myTable.row( index ).node() ).find('input:checkbox').prop('checked', false);
					}
				} );
			
			
			
			
				/////////////////////////////////
				//table checkboxes
				$('th input[type=checkbox], td input[type=checkbox]').prop('checked', false);
				
				//select/deselect all rows according to table header checkbox
				$('#dynamic-table > thead > tr > th input[type=checkbox], #dynamic-table_wrapper input[type=checkbox]').eq(0).on('click', function(){
					var th_checked = this.checked;//checkbox inside ""TH"" table header
					
					$('#dynamic-table').find('tbody > tr').each(function(){
						var row = this;
						if(th_checked) myTable.row(row).select();
						else  myTable.row(row).deselect();
					});
				});
				
				//select/deselect a row when ");
                WriteLiteral(@"the checkbox is checked/unchecked
				$('#dynamic-table').on('click', 'td input[type=checkbox]' , function(){
					var row = $(this).closest('tr').get(0);
					if(this.checked) myTable.row(row).deselect();
					else myTable.row(row).select();
				});
			
			
			
				$(document).on('click', '#dynamic-table .dropdown-toggle', function(e) {
					e.stopImmediatePropagation();
					e.stopPropagation();
					e.preventDefault();
				});
				
				
				
				//And for the first simple table, which doesn't have TableTools or dataTables
				//select/deselect all rows according to table header checkbox
				var active_class = 'active';
				$('#simple-table > thead > tr > th input[type=checkbox]').eq(0).on('click', function(){
					var th_checked = this.checked;//checkbox inside ""TH"" table header
					
					$(this).closest('table').find('tbody > tr').each(function(){
						var row = this;
						if(th_checked) $(row).addClass(active_class).find('input[type=checkbox]').eq(0).prop('checked', true);
		");
                WriteLiteral(@"				else $(row).removeClass(active_class).find('input[type=checkbox]').eq(0).prop('checked', false);
					});
				});
				
				//select/deselect a row when the checkbox is checked/unchecked
				$('#simple-table').on('click', 'td input[type=checkbox]' , function(){
					var $row = $(this).closest('tr');
					if($row.is('.detail-row ')) return;
					if(this.checked) $row.addClass(active_class);
					else $row.removeClass(active_class);
				});
			
				
			
				/********************************/
				//add tooltip for small view action buttons in dropdown menu
				$('[data-rel=""tooltip""]').tooltip({placement: tooltip_placement});
				
				//tooltip placement on right or left
				function tooltip_placement(context, source) {
					var $source = $(source);
					var $parent = $source.closest('table')
					var off1 = $parent.offset();
					var w1 = $parent.width();
			
					var off2 = $source.offset();
					//var w2 = $source.width();
			
					if( parseInt(off2.left) < parseInt(off1.left) +");
                WriteLiteral(@" parseInt(w1 / 2) ) return 'right';
					return 'left';
				}
				
				
				
				
				/***************/
				$('.show-details-btn').on('click', function(e) {
					e.preventDefault();
					$(this).closest('tr').next().toggleClass('open');
					$(this).find(ace.vars['.icon']).toggleClass('fa-angle-double-down').toggleClass('fa-angle-double-up');
				});
				/***************/
				
				
				
				
				
				/**
				//add horizontal scrollbars to a simple table
				$('#simple-table').css({'width':'2000px', 'max-width': 'none'}).wrap('<div style=""width: 1000px;"" />').parent().ace_scroll(
				  {
					horizontal: true,
					styleClass: 'scroll-top scroll-dark scroll-visible',//show the scrollbars on top(default is bottom)
					size: 2000,
					mouseWheelLock: true
				  }
				).css('padding-top', '12px');
				*/
			
			
			})
		</script>

");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591