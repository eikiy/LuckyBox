// JavaScript Document
$(function(){
$("#product2").hide();
$("#product3").hide();
$("#product4").hide();
$("#bg").hide();
	
	$('#click1').click(function(){
	$("#product1").show();
	$("#product2").hide();
	$("#product3").hide();
	$("#product4").hide();
	$("#bg").hide();
	});

	$('#click2').click(function(){
	$("#product2").show();
	$("#product1").hide();
	$("#product3").hide();
	$("#product4").hide();
	$("#bg").hide();
	});

	$('#click3').click(function(){
	$("#product3").show();
	$("#product1").hide();
	$("#product2").hide();
	$("#product4").hide();
	$("#bg").show();
	});

	$('#click4').click(function(){
	$("#product4").show();
	$("#product1").hide();
	$("#product3").hide();
	$("#product2").hide();
	$("#bg").hide();
	});
});