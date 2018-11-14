// JavaScript Document

$(document).ready(function(){ 
$("table#one tr").mouseover(function(){ 
$(this).removeClass("tablebg2");
$(this).removeClass("tablebg3");
$(this).addClass("tablebg1");//鼠標移到ID為mytable的表格的tr上時，執行函數
}); 
$("table#one tr").mouseout(function(){ 
$(this).removeClass("tablebg1");//移除該行的class 
$("table#one tr:even").addClass("tablebg2");
$("table#one tr:odd").addClass("tablebg3");
}); 
$("table#one tr:even").addClass("tablebg2");
$("table#one tr:odd").addClass("tablebg1");//even----奇數,and odd----偶數

$("table#one").find("tr").each(function(i){ 
if(i%2 != 0){ 
$(this).addClass("tablebg3"); 
}
});//each實現表格偶數行換色

}) 
