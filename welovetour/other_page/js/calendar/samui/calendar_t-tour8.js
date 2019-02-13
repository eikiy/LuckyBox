
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

/*
for(var i=9;i<=12;i++)
{
	if(i==1||i==3||i==5||i==7||i==8||i==10||i==12){
		if(i<10){
			i = '0' + i;
		}
		
		for(var lk=1;lk<=31;lk++){
			if(lk<10){
				lk = '0' + lk;
			}
			//document.write('{title:"34,800",start:' + '"' + year + '-' + i + '-' + lk + '"' + '},');
			//document.write('<br>');
		}
	}
	
	if(i==2){
		//console.log(i + "28天");
		//for(dk=1;dk<=28;dk++){
		//}
	}
	
	if(i==4||i==6||i==9||i==11){
		//console.log(i + "小月");
		if(i<10){
			i = '0' + i;
		}
		
		for(var sk=1;sk<=30;sk++){
			if(sk<10){
				sk = '0' + sk;
			}
			//document.write('{title:"34,800",start:' + '"' + year + '-' + i + '-' + sk + '"' + '},');
			//document.write('<br>');
		}
	}
}
*/


$(document).ready(function() {
	$('#calendar01').fullCalendar({
		header: {
			left: 'prev,next today',
			center: 'title',
			right: 'month,agendaWeek,agendaDay,listWeek'
		},
		defaultDate:calendar,
		weekends: true, // 顯示星期六跟星期日
		editable: false,  // 啟動拖曳調整日期
		events: [
{title:"34,800",start:"2018-09-10"},
{title:"34,800",start:"2018-09-11"},
{title:"34,800",start:"2018-09-12"},
{title:"34,800",start:"2018-09-13"},
{title:"34,800",start:"2018-09-14"},
{title:"34,800",start:"2018-09-15"},
{title:"34,800",start:"2018-09-16"},
{title:"34,800",start:"2018-09-17"},
{title:"34,800",start:"2018-09-18"},
{title:"34,800",start:"2018-09-19"},
{title:"34,800",start:"2018-09-20"},
{title:"35,800",start:"2018-09-21"},
{title:"34,800",start:"2018-09-22"},
{title:"34,800",start:"2018-09-23"},
{title:"34,800",start:"2018-09-24"},
{title:"34,800",start:"2018-09-25"},
{title:"34,800",start:"2018-09-26"},
{title:"34,800",start:"2018-09-27"},
{title:"34,800",start:"2018-09-28"},
{title:"34,800",start:"2018-09-29"},
{title:"34,800",start:"2018-09-30"},
{title:"34,800",start:"2018-10-01"},
{title:"34,800",start:"2018-10-02"},
{title:"34,800",start:"2018-10-03"},
{title:"34,800",start:"2018-10-04"},
{title:"34,800",start:"2018-10-05"},
{title:"35,800",start:"2018-10-06"},
{title:"34,800",start:"2018-10-07"},
{title:"34,800",start:"2018-10-08"},
{title:"34,800",start:"2018-10-09"},
{title:"34,800",start:"2018-10-10"},
{title:"34,800",start:"2018-10-11"},
{title:"34,800",start:"2018-10-12"},
{title:"34,800",start:"2018-10-13"},
{title:"34,800",start:"2018-10-14"},
{title:"34,800",start:"2018-10-15"},
{title:"34,800",start:"2018-10-16"},
{title:"34,800",start:"2018-10-17"},
{title:"34,800",start:"2018-10-18"},
{title:"34,800",start:"2018-10-19"},
{title:"34,800",start:"2018-10-20"},
{title:"34,800",start:"2018-10-21"},
{title:"34,800",start:"2018-10-22"},
{title:"34,800",start:"2018-10-23"},
{title:"34,800",start:"2018-10-24"},
{title:"34,800",start:"2018-10-25"},
{title:"34,800",start:"2018-10-26"},
{title:"34,800",start:"2018-10-27"},
{title:"34,800",start:"2018-10-28"},
{title:"34,800",start:"2018-10-29"},
{title:"34,800",start:"2018-10-30"},
{title:"34,800",start:"2018-10-31"},
{title:"34,800",start:"2018-11-01"},
{title:"34,800",start:"2018-11-02"},
{title:"34,800",start:"2018-11-03"},
{title:"34,800",start:"2018-11-04"},
{title:"34,800",start:"2018-11-05"},
{title:"34,800",start:"2018-11-06"},
{title:"34,800",start:"2018-11-07"},
{title:"34,800",start:"2018-11-08"},
{title:"34,800",start:"2018-11-09"},
{title:"34,800",start:"2018-11-10"},
{title:"34,800",start:"2018-11-11"},
{title:"34,800",start:"2018-11-12"},
{title:"34,800",start:"2018-11-13"},
{title:"34,800",start:"2018-11-14"},
{title:"34,800",start:"2018-11-15"},
{title:"34,800",start:"2018-11-16"},
{title:"34,800",start:"2018-11-17"},
{title:"34,800",start:"2018-11-18"},
{title:"34,800",start:"2018-11-19"},
{title:"34,800",start:"2018-11-20"},
{title:"34,800",start:"2018-11-21"},
{title:"34,800",start:"2018-11-22"},
{title:"34,800",start:"2018-11-23"},
{title:"34,800",start:"2018-11-24"},
{title:"34,800",start:"2018-11-25"},
{title:"34,800",start:"2018-11-26"},
{title:"34,800",start:"2018-11-27"},
{title:"34,800",start:"2018-11-28"},
{title:"34,800",start:"2018-11-29"},
{title:"34,800",start:"2018-11-30"},
{title:"34,800",start:"2018-12-01"},
{title:"34,800",start:"2018-12-02"},
{title:"34,800",start:"2018-12-03"},
{title:"34,800",start:"2018-12-04"},
{title:"34,800",start:"2018-12-05"},
{title:"34,800",start:"2018-12-06"},
{title:"34,800",start:"2018-12-07"},
{title:"34,800",start:"2018-12-08"},
{title:"34,800",start:"2018-12-09"},
{title:"34,800",start:"2018-12-10"},
{title:"34,800",start:"2018-12-11"},
{title:"34,800",start:"2018-12-12"},
{title:"34,800",start:"2018-12-13"},
{title:"34,800",start:"2018-12-14"},
{title:"34,800",start:"2018-12-15"},
{title:"34,800",start:"2018-12-16"},
{title:"34,800",start:"2018-12-17"},
{title:"34,800",start:"2018-12-18"},
{title:"34,800",start:"2018-12-19"},
{title:"34,800",start:"2018-12-20"},
		]
	});
	
	$('#calendar02').fullCalendar({
		header: {
			left: 'prev,next today',
			center: 'title',
			right: 'month,agendaWeek,agendaDay,listWeek'
		},
		defaultDate: nextCalendar,
		weekends: true, // 顯示星期六跟星期日
		editable: false,  // 啟動拖曳調整日期
		events: [
			{title:"34,800",start:"2018-09-10"},
{title:"34,800",start:"2018-09-11"},
{title:"34,800",start:"2018-09-12"},
{title:"34,800",start:"2018-09-13"},
{title:"34,800",start:"2018-09-14"},
{title:"34,800",start:"2018-09-15"},
{title:"34,800",start:"2018-09-16"},
{title:"34,800",start:"2018-09-17"},
{title:"34,800",start:"2018-09-18"},
{title:"34,800",start:"2018-09-19"},
{title:"34,800",start:"2018-09-20"},
{title:"35,800",start:"2018-09-21"},
{title:"34,800",start:"2018-09-22"},
{title:"34,800",start:"2018-09-23"},
{title:"34,800",start:"2018-09-24"},
{title:"34,800",start:"2018-09-25"},
{title:"34,800",start:"2018-09-26"},
{title:"34,800",start:"2018-09-27"},
{title:"34,800",start:"2018-09-28"},
{title:"34,800",start:"2018-09-29"},
{title:"34,800",start:"2018-09-30"},
{title:"34,800",start:"2018-10-01"},
{title:"34,800",start:"2018-10-02"},
{title:"34,800",start:"2018-10-03"},
{title:"34,800",start:"2018-10-04"},
{title:"34,800",start:"2018-10-05"},
{title:"35,800",start:"2018-10-06"},
{title:"34,800",start:"2018-10-07"},
{title:"34,800",start:"2018-10-08"},
{title:"34,800",start:"2018-10-09"},
{title:"34,800",start:"2018-10-10"},
{title:"34,800",start:"2018-10-11"},
{title:"34,800",start:"2018-10-12"},
{title:"34,800",start:"2018-10-13"},
{title:"34,800",start:"2018-10-14"},
{title:"34,800",start:"2018-10-15"},
{title:"34,800",start:"2018-10-16"},
{title:"34,800",start:"2018-10-17"},
{title:"34,800",start:"2018-10-18"},
{title:"34,800",start:"2018-10-19"},
{title:"34,800",start:"2018-10-20"},
{title:"34,800",start:"2018-10-21"},
{title:"34,800",start:"2018-10-22"},
{title:"34,800",start:"2018-10-23"},
{title:"34,800",start:"2018-10-24"},
{title:"34,800",start:"2018-10-25"},
{title:"34,800",start:"2018-10-26"},
{title:"34,800",start:"2018-10-27"},
{title:"34,800",start:"2018-10-28"},
{title:"34,800",start:"2018-10-29"},
{title:"34,800",start:"2018-10-30"},
{title:"34,800",start:"2018-10-31"},
{title:"34,800",start:"2018-11-01"},
{title:"34,800",start:"2018-11-02"},
{title:"34,800",start:"2018-11-03"},
{title:"34,800",start:"2018-11-04"},
{title:"34,800",start:"2018-11-05"},
{title:"34,800",start:"2018-11-06"},
{title:"34,800",start:"2018-11-07"},
{title:"34,800",start:"2018-11-08"},
{title:"34,800",start:"2018-11-09"},
{title:"34,800",start:"2018-11-10"},
{title:"34,800",start:"2018-11-11"},
{title:"34,800",start:"2018-11-12"},
{title:"34,800",start:"2018-11-13"},
{title:"34,800",start:"2018-11-14"},
{title:"34,800",start:"2018-11-15"},
{title:"34,800",start:"2018-11-16"},
{title:"34,800",start:"2018-11-17"},
{title:"34,800",start:"2018-11-18"},
{title:"34,800",start:"2018-11-19"},
{title:"34,800",start:"2018-11-20"},
{title:"34,800",start:"2018-11-21"},
{title:"34,800",start:"2018-11-22"},
{title:"34,800",start:"2018-11-23"},
{title:"34,800",start:"2018-11-24"},
{title:"34,800",start:"2018-11-25"},
{title:"34,800",start:"2018-11-26"},
{title:"34,800",start:"2018-11-27"},
{title:"34,800",start:"2018-11-28"},
{title:"34,800",start:"2018-11-29"},
{title:"34,800",start:"2018-11-30"},
{title:"34,800",start:"2018-12-01"},
{title:"34,800",start:"2018-12-02"},
{title:"34,800",start:"2018-12-03"},
{title:"34,800",start:"2018-12-04"},
{title:"34,800",start:"2018-12-05"},
{title:"34,800",start:"2018-12-06"},
{title:"34,800",start:"2018-12-07"},
{title:"34,800",start:"2018-12-08"},
{title:"34,800",start:"2018-12-09"},
{title:"34,800",start:"2018-12-10"},
{title:"34,800",start:"2018-12-11"},
{title:"34,800",start:"2018-12-12"},
{title:"34,800",start:"2018-12-13"},
{title:"34,800",start:"2018-12-14"},
{title:"34,800",start:"2018-12-15"},
{title:"34,800",start:"2018-12-16"},
{title:"34,800",start:"2018-12-17"},
{title:"34,800",start:"2018-12-18"},
{title:"34,800",start:"2018-12-19"},
{title:"34,800",start:"2018-12-20"},
		]
	});
});
