$(document).ready(function() {
	let params = new URL(document.location).searchParams;
	let status = params.get('status');
	const now = new Date();
	let start = params.get('start') || now.setMonth(now.getMonth() - 1);
	let end = params.get('end') || now.setMonth(now.getMonth() + 2);
	loadList(status, start, end);

	$('#datepicker').daterangepicker(
		{
			startDate: moment(start),
			endDate: moment(end)
		},
		function(start, end) {
			location.href = `${window.location.origin}${window.location
				.pathname}?status=${status}&start=${start.toISOString()}&end=${end.toISOString()}`;
		}
	);
});

function loadList(param, start, end) {
	const startDate = new Date(start).toISOString();
	const endDate = new Date(end).toISOString();
	dataTable = $('#DT-load').DataTable({
		ajax: {
			url: `/api/order?status=${param}&startDate=${startDate}&endDate=${endDate}`,
			type: 'GET',
			datatype: 'json'
		},

		columns: [
			{ data: 'orderHeader.id', autoWidth: true },
			{ data: 'orderHeader.pickupName', autoWidth: true },
			{ data: 'orderHeader.applicationUser.email', autoWidth: true },
			{
				data: 'orderHeader.orderDate',
				render: function(data) {
					var date = new Date(data);
					var month = date.getMonth() + 1;
					return (
						(month.toString().length > 1 ? month : '0' + month) +
						'/' +
						date.getDate() +
						'/' +
						date.getFullYear()
					);
				},
				autoWidth: true
			},
			{
				data: 'orderHeader.orderTotal',
				render: $.fn.dataTable.render.number(',', '.', 2, '$'),
				width: '20%'
			},
			{
				data: 'orderHeader.id',
				render: function(data) {
					return ` <div class="text-center">
                                <a href="/Admin/Order/OrderDetails?id=${data}" class="btn btn-success text-white" style="cursor:pointer; width:100px;">
                                    <i class="far fa-edit"></i> Details
                                </a>
                             </div>
                           
                           `;
				},
				autoWidth: true
			}
		],
		language: {
			emptyTable: 'no data found.'
		},
		width: '100%',
		order: [ [ 3, 'asc' ] ]
	});
}
