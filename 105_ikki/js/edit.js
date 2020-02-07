var return_code = "";
$(function(){
	var array;
	var val;
	$.ajax({ 
		type: "POST",
		url: 'm/get_data.aspx', 
		data: "t=1",
		cache: false,
		success: function(data) 
		{ 
			array = data.split(';');
			for (var i=0;i<array.length-1;i++)
			{
				val = array[i].split(',');
                document.getElementById('city').options.add(new Option(val[0],val[1])); 
			}
		} 
	});
});

function change_checkbox(id, id2)
{
	$("#" + id).attr("src", "images/" + id.charAt(0) + ".png");	
	$("#" + id2).attr("src",  "images/" + id2.charAt(0) + ".png");	
	$("#" + id).attr("src", "images/" + id.charAt(0) + "-2.png");	
	document.form1.edm1.value= id;
}

function change_checkbox2(id, id2)
{
	$("#" + id).attr("src", "images/" + id.charAt(0) + ".png");	
	$("#" + id2).attr("src",  "images/" + id2.charAt(0) + ".png");	
	$("#" + id).attr("src", "images/" + id.charAt(0) + "-2.png");	
	document.form1.edm2.value= id;
}

function get_zipcode(city)
{
	$.ajax({ 
		type: "POST",
		url: 'm/get_data.aspx', 
		data: "t=2&city=" + city,
		cache: false,
		success: function(data) 
		{ 
			array = data.split(';');
			document.getElementById('zipcode').innerHTML='';
			document.getElementById('zipcode').options.add(new Option('請選擇','')); 
			for (var i=0;i<array.length-1;i++)
			{
				val = array[i].split(',');
                document.getElementById('zipcode').options.add(new Option(val[0],val[1])); 
			}
		} 
	}); 
}

function checkdata() {
	if($("#name").val() == ''){
		alert("姓名未輸入,請重新填寫");
		$("#name").focus();
		return false;
	}
	
	if($("#sex").val() == ''){
		alert("您的性別未選擇,請重新填寫");
		return false;
	}
	
	if($("#nickname").val() == ''){
		alert("您的暱稱未輸入,請重新填寫");
		$("#nickname").focus();
		return false;
	}

	if ($("#year2").val() != "")
	{
		if($("#month2").val() == ""){
			alert("您的結婚月份未選擇,請重新填寫");
			return false;
		}
		
		if($("#day2").val() == ""){
			alert("您的結婚日期未選擇,請重新填寫");
			return false;
		}
		if (checkDate($("#month2").val(), $("#day2").val())==false)
		{
			alert("您的結婚日期選擇錯誤");
			return false;
		}
	}
	
	
	if ($("#month2").val() != "")
	{
		if($("#year2").val() == ""){
			alert("您的結婚年份未選擇,請重新填寫");
			return false;
		}
		
		if($("#day2").val() == ""){
			alert("您的結婚日期未選擇,請重新填寫");
			return false;
		}
		if (checkDate($("#month2").val(), $("#day2").val())==false)
		{
			alert("您的結婚日期選擇錯誤");
			return false;
		}
	}
	
	if ($("#day2").val() != "")
	{
		if($("#year2").val() == ""){
			alert("您的結婚年份未選擇,請重新填寫");
			return false;
		}
		
		if($("#month2").val() == ""){
			alert("您的結婚月份未選擇,請重新填寫");
			return false;
		}
		if (checkDate($("#month2").val(), $("#day2").val())==false)
		{
			alert("您的結婚日期選擇錯誤");
			return false;
		}
	}
	
	if ($("#mobile").val() == "" && ($("#phone1").val() == "" || $("#phone2").val() == ""))
	{
    	alert("手機或電話至少填寫一項,請重新輸入");
        $("#mobile").focus();
        return false;
    }
		
    if ($("#mobile").val() != "")
	{
		if($("#mobile").val().length < 10 ){
			alert("手機須為10碼,請重新輸入");
			$("#mobile").val('');
			$("#mobile").focus();
			return false;
		}
		
		re = /^[09]{2}[0-9]{8}$/;
		
		if (!re.test($("#mobile").val()))
		{
			alert("手機格式不正確,請重新輸入");
			$("#mobile").val('');
			$("#mobile").focus();
			return false;
		}
	}
	
	if($("#city").val()=="" ){
		alert("您的縣市未選擇,請重新填寫");
		return false;
	}
	
	if($("#zipcode").val()=="" ){
		alert("您的區域未選擇,請重新填寫");
		return false;
	}
	
	if($("#pwd").val().length < 4 ){
		alert("密碼請設定4~8個字,請重新輸入");
		$("#pwd").focus();
		return false;
	}
	
	var pass = $("#pwd").val();
	for(var i = 0; i < pass.length; i++)
	{
    	var c = pass.charAt(i);
		if(!((c >= "A" && c <= "Z") || (c >= "a" && c <= "z")||(c >= "0" && c <= "9")))
		{
			alert("您輸入的密碼含有特殊字元或空白,請重新輸入");
			$("#pwd").focus();
			return false;
    	}
  	}
	
	if($("#chk_pwd").val() == ''){
		alert("確認密碼未輸入,請重新填寫");
		$("#chk_pwd").focus();
		return false;
	}
	
	if($("#pwd").val() != $("#chk_pwd").val() ){
		alert("您兩次輸入的密碼不吻合,請重新輸入");
		$("#chk_pwd").focus();
		return false;
	}
	
	return true;
}

function checkDate(m, d) {
	if(m == "2" && (d == "31" || d == "30")){
		return false;
    }
	
	if ((m=="4" || m=="6" || m=="9" || m=="11") && (d == "31"))
	{
		 return false;
    }
	
	return true;
}