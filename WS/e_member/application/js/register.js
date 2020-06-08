var return_code = "";
$(function(){
	var array;
	var val;
	$.ajax({ 
		type: "POST",
		url: 'js/get_data.aspx', 
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
	
//	$.ajax({ 
//		type: "POST",
//		url: 'js/get_data.aspx', 
//		data: "t=3",
//		cache: false,
//		success: function(data) 
//		{ 
//			array = data.split(';');
//			for (var i=0;i<array.length-1;i++)
//			{
//				val = array[i].split(',');
//                document.getElementById('store').options.add(new Option(val[0],val[1])); 
//			}
//		} 
//	});
	
});

function change_sex(id)
{
	$("#woman").attr("src", "images/woman1.png");
	$("#man").attr("src", "images/man1.png");
	$("#" + id).attr("src", "images/" + id + "2.png");	
	document.form1.sex.value= id;
}

function change_checkbox(id, id2)
{
	$("#" + id).attr("src", "images/" + id.charAt(0) + ".png");
	$("#" + id2).attr("src", "images/" + id2.charAt(0) + ".png");
	$("#" + id).attr("src", "images/" + id.charAt(0) + "-2.png");	
	document.form1.edm1.value= id;
}

function change_checkbox2(id, id2)
{
    $("#" + id).attr("src", "images/" + id.charAt(0) + ".png");
    $("#" + id2).attr("src", "images/" + id2.charAt(0) + ".png");
    $("#" + id).attr("src", "images/" + id.charAt(0) + "-2.png");	
	document.form1.edm2.value= id;
}

//找行政區
function get_zipcode(city)
{
	$.ajax({ 
		type: "POST",
		url: 'js/get_data.aspx', 
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

//找路
function get_street(zipcode) {
    $.ajax({
        type: "POST",
        url: 'js/get_data.aspx',
        data: "t=4&zipcode=" + zipcode,
        cache: false,
        success: function(data) {
            array = data.split(';');
            document.getElementById('street').innerHTML = '';
            document.getElementById('street').options.add(new Option('請選擇', ''));
            for (var i = 0; i < array.length - 1; i++) {
                val = array[i].split(',');
                document.getElementById('street').options.add(new Option(val[0], val[1]));
            }
        }
    });
}

//檢查email唯一
function checkuser()
{
	var userid = $("#email").val();
	if (userid !="")
	{
		$.ajax({ 
			type: "POST",
			url: 'js/check_user.aspx', 
					data: "id=" + userid,
					cache: false,
					success: function(data) 
					{ 
						if (data == "yes")
						{
							alert("這個email帳號已註冊過，請使用其他帳號~謝謝~");
							$("#email").val('');
							$("#email").focus();
						}
					}
			}); 
	}
}

//檢查手機唯一
function checkuser_mobile() 
{
    var userid = $("#mobile").val();
    if (userid != "") {
        $.ajax({
            type: "POST",
            url: 'js/check_user.aspx',
            data: "id=" + userid,
            cache: false,
            success: function(data) {
                if (data == "yes") {
                    alert("這個手機號碼已註冊過，請使用其他帳號~謝謝~");
                    $("#mobile").val('');
                    $("#mobile").focus();
                }
            }
        });
    }
}

function checkcode(code)
{
	//檢查驗證碼
	$.ajax({ 
		type: "POST",
		url: 'js/check_code.aspx', 
		data: "code=" + code,
		cache: false,
		async : false,
		success: function(data) 
		{ 
			if (data == "no")
			{
				return_code = "no";
			}else{
				return_code = "yes";
			}
			
		},
		error: function(xhr, ajaxOptions, thrownError)
		{
 	    	alert(thrownError);
   		}    
	}); 
	return return_code;
	
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

	if($("#email").val() == ''){
		alert("您的email未輸入,請重新填寫");
		$("#email").focus();
		return false;
	}
    	
	var em = $("#email").val();
	var len = em.length;
	for(var i = 0; i < len; i++) 
	{
    	var c = em.charAt(i);
    	if(!((c >= "A" && c <= "Z")||(c >= "a" && c <= "z")||(c >= "0" && c <= "9")||(c == "-")||(c == "_")||(c == ".")||(c == "@"))) 
		{
      		alert("您輸入的e-mail不正確,請重新輸入");
			$("#email").focus();
			return false;
    	}
  	}
	
	if((em.indexOf("@")==-1)||(em.indexOf("@")==0)||(em.indexOf("@")==(len-1))) 
	{
    	alert("您輸入的e-mail不正確,請重新輸入");	
		$("#email").focus();
		return false;
	}
  	if((em.indexOf("@")!=-1)&&(em.substring(em.indexOf("@")+1,len).indexOf("@")!=-1)) 
	{
    	alert("您輸入的e-mail不正確,請重新輸入");	
		$("#email").focus();
		return false; 
  	}
  	
	if((em.indexOf(".")==-1)||(em.indexOf(".")==0)||(em.lastIndexOf(".")==(len-1))) 
	{
    	alert("您輸入的e-mail不正確,請重新輸入");
		$("#email").focus();
		return false;
  	}
	
	if($("#year1").val() == ""){
		alert("您的出生年份未選擇,請重新填寫");
		return false;
	}
	
	if($("#month1").val() == ""){
		alert("您的出生月份未選擇,請重新填寫");
		return false;
	}
	
	if($("#day1").val() == ""){
		alert("您的出生日期未選擇,請重新填寫");
		return false;
	}
	
	if (checkDate($("#month1").val(), $("#day1").val())==false)
	{
		alert("您的出生日期選擇錯誤");
		return false;
    }

    //手機為避填欄位(沐容)
    if ($("#mobile").val() == '') {
        alert("您的手機未輸入,請重新填寫!!");
        $("#mobile").focus();
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
	
	if($("#code").val()=="" ){
		alert("請輸入驗證碼");
		$("#code").focus();
		return false;
	}

	if(checkcode($("#code").val()) == "no"){
		alert("驗證碼錯誤,請重新填寫");
		$("#code").val('');
		$("#code").focus();
		return false;
	}
	
	if(document.getElementById("rule").checked==false) 
	{
		alert("您尚未同意隱私權條款");
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