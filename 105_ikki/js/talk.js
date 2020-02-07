function change_sex(id)
{
	$("#woman").attr("src", "images/woman1.png");	
	$("#man").attr("src", "images/man1.png");
	$("#" + id).attr("src", "images/" + id + "2.png");	
	document.form1.sex.value= id;
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
	
	if ($("#mobile").val() == "" && ($("#phone1").val() == "" || $("#phone2").val() == "")) {
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
	
	if($("#store").val()=="" ){
		alert("您的店別未選擇,請重新填寫");
		return false;
	}
	
	if($("#subject").val()=="" ){
		alert("您的主題未輸入,請重新填寫");
		$("#subject").focus();
		return false;
	}
	
	if($("#content").val()=="" ){
		alert("您的內容未輸入,請重新填寫");
		$("#content").focus();
		return false;
	}
	
	if($("#content").val().length > 1000 ){
		alert("建議字數1000字!!");
		$("#content").focus();
		return false;
	}
	
	
	return true;
}