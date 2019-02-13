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
		defaultDate:"2019-01-01",
		//defaultDate: $('#calendar').fullCalendar('today'),
		weekends: true, // 顯示星期六跟星期日
		editable: false,  // 啟動拖曳調整日期
		events: [
{title:"29,900",start:"2019-01-09"},
{title:"28,900",start:"2019-01-16"},
{title:"28,900",start:"2019-01-23"},
{title:"30,900",start:"2019-01-30"},
{title:"41,000",start:"2019-02-03"},
{title:"39,900",start:"2019-02-07"},
{title:"(春節清倉)",start:"2019-02-07"},
{title:"(32900,四連休,再扣1000)",start:"2019-02-27"},
{title:"28,900",start:"2019-03-06"},
{title:"28,900",start:"2019-03-13"},
{title:"28,900",start:"2019-03-20"},
{title:"28,900",start:"2019-03-22"},
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
{title:"29,900",start:"2019-01-09"},
{title:"28,900",start:"2019-01-16"},
{title:"28,900",start:"2019-01-23"},
{title:"30,900",start:"2019-01-30"},
{title:"41,000",start:"2019-02-03"},
{title:"39,900",start:"2019-02-07"},
{title:"(春節清倉)",start:"2019-02-07"},
{title:"(32900,四連休,再扣1000)",start:"2019-02-27"},
{title:"28,900",start:"2019-03-06"},
{title:"28,900",start:"2019-03-13"},
{title:"28,900",start:"2019-03-20"},
{title:"28,900",start:"2019-03-22"},
		]
	});
});
