// JavaScript Document
$(function(){
$("#product2").hide();
$("#product3").hide();
$("#product4").hide();
$("#product5").hide();
$("#bg").hide();

	$('#click1').click(function(){
	$("#product1").show();
	$("#product2").hide();
	$("#product3").hide();
	$("#product4").hide();
    $("#product5").hide();
	$("#bg").hide();
	});

	$('#click2').click(function(){
	$("#product2").show();
	$("#product1").hide();
	$("#product3").hide();
	$("#product4").hide();
    $("#product5").hide();
	$("#bg").show();
	});

	$('#click3').click(function(){
	$("#product3").show();
	$("#product1").hide();
	$("#product2").hide();
	$("#product4").hide();
    $("#product5").hide();
	$("#bg").hide();
	});

	$('#click4').click(function(){
	$("#product4").show();
	$("#product1").hide();
	$("#product3").hide();
	$("#product2").hide();
    $("#product5").hide();
	$("#bg").hide();
	});

    $('#click5').click(function(){
	$("#product5").show();
	$("#product1").hide();
	$("#product3").hide();
	$("#product2").hide();
    $("#product4").hide();
	$("#bg").hide();
	});

});