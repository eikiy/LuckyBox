/*
var dt = new Date();
var month = dt.getMonth()+1;
var day = dt.getDate();
var nextMonth = dt.getMonth()+2;
var year = dt.getFullYear();
if( month < 10 || day <10 ){
	month = '0' + month; 
	day = '0' + day;
}
var calendar = year + '-' + month + '-' + day;
var nextCalendar = year + '-' + nextMonth + '-' + '01';
*/
$(document).ready(function() {
	$('#calendar01').fullCalendar({
		header: {
			left: 'prev,next today',
			center: 'title',
			right: 'month,agendaWeek,agendaDay,listWeek'
		},
		//defaultDate:$('#calendar').fullCalendar('today'),
		defaultDate:"2019-01-01",
		weekends: true, // 顯示星期六跟星期日
		editable: false,  // 啟動拖曳調整日期
		events: [
{title:"24900起",start:"2019-01-12"},
{title:"24900起",start:"2019-01-16"},
{title:"25900起",start:"2019-01-24"},
{title:"24900起",start:"2019-01-28"},
{title:"22900起",start:"2019-01-20"},
{title:"33500起",start:"2019-02-01"},
{title:"39900起",start:"2019-02-05"},
{title:"31500起",start:"2019-02-09"},
{title:"24900起",start:"2019-02-13"},
{title:"24900起",start:"2019-02-21"},
{title:"24900起",start:"2019-02-25"},
{title:"22900起",start:"2019-02-17"},
{title:"26900起",start:"2019-03-01"},
{title:"23900起",start:"2019-03-05"},
{title:"24900起",start:"2019-03-09"},
{title:"24900起",start:"2019-03-13"},
{title:"24900起",start:"2019-03-21"},
{title:"23900起",start:"2019-03-25"},
{title:"22900起",start:"2019-03-17"},
		]
	});
	
	$('#calendar02').fullCalendar({
		header: {
			left: 'prev,next today',
			center: 'title',
			right: 'month,agendaWeek,agendaDay,listWeek'
		},
		//defaultDate: moment().add(1, "months"),
		defaultDate:"2019-02-01",
		weekends: true, // 顯示星期六跟星期日
		editable: false,  // 啟動拖曳調整日期
		events: [
{title:"24900起",start:"2019-01-12"},
{title:"24900起",start:"2019-01-16"},
{title:"25900起",start:"2019-01-24"},
{title:"24900起",start:"2019-01-28"},
{title:"22900起",start:"2019-01-20"},
{title:"33500起",start:"2019-02-01"},
{title:"39900起",start:"2019-02-05"},
{title:"31500起",start:"2019-02-09"},
{title:"24900起",start:"2019-02-13"},
{title:"24900起",start:"2019-02-21"},
{title:"24900起",start:"2019-02-25"},
{title:"22900起",start:"2019-02-17"},
{title:"26900起",start:"2019-03-01"},
{title:"23900起",start:"2019-03-05"},
{title:"24900起",start:"2019-03-09"},
{title:"24900起",start:"2019-03-13"},
{title:"24900起",start:"2019-03-21"},
{title:"23900起",start:"2019-03-25"},
{title:"22900起",start:"2019-03-17"},
		]
	});
});
