// JavaScript Document
$(function(){
$("#tech2").hide();
$("#tech3").hide();
$("#tech4").hide();
$("#tech5").hide();
	
	$('#click1').click(function(){
	$("#tech1").show();
	$("#tech2").hide();
	$("#tech3").hide();
	$("#tech4").hide();
	$("#tech5").hide();
	});

	$('#click2').click(function(){
	$("#tech2").show();
	$("#tech1").hide();
	$("#tech3").hide();
	$("#tech4").hide();
	$("#tech5").hide();
	});

	$('#click3').click(function(){
	$("#tech3").show();
	$("#tech1").hide();
	$("#tech2").hide();
	$("#tech4").hide();
	$("#tech5").hide();
	});

	$('#click4').click(function(){
	$("#tech4").show();
	$("#tech1").hide();
	$("#tech3").hide();
	$("#tech2").hide();
	$("#tech5").hide();
	});
	
	
	$('#click5').click(function(){
	$("#tech5").show();
	$("#tech1").hide();
	$("#tech3").hide();
	$("#tech2").hide();
	$("#tech4").hide();
	});
});