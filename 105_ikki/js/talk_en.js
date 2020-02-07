function checkdata() {

	if($("#name").val() == ''){
		alert("Your name is not completed, please re-enter the information..");
		$("#name").focus();
		return false;
	}
	
	if($('input:radio:checked[name="sex"]').val() == undefined){
		alert("Your gender is not completed, please re-enter the information..");
		return false;
	}
	
	if ($("#phone").val() == "") {
    	alert("Your phone is not completed, please re-enter the information..");
        $("#phone").focus();
        return false;
    }
		
	if($("#email").val() == ''){
		alert("Your e-mail is not completed, please re-enter the information..");
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
      		alert("Invalid e-mail, please re-enter the information..");
			$("#email").focus();
			return false;
    	}
  	}
	
	if((em.indexOf("@")==-1)||(em.indexOf("@")==0)||(em.indexOf("@")==(len-1))) 
	{
    	alert("Invalid e-mail, please re-enter the information..");	
		$("#email").focus();
		return false;
	}
  	if((em.indexOf("@")!=-1)&&(em.substring(em.indexOf("@")+1,len).indexOf("@")!=-1)) 
	{
    	alert("Invalid e-mail, please re-enter the information..");	
		$("#email").focus();
		return false; 
  	}
  	
	if((em.indexOf(".")==-1)||(em.indexOf(".")==0)||(em.lastIndexOf(".")==(len-1))) 
	{
    	alert("Invalid e-mail, please re-enter the information..");
		$("#email").focus();
		return false;
  	}
	
	if($("#subject").val()=="" ){
		alert("Your subject is not completed, please re-enter the information..");
		$("#subject").focus();
		return false;
	}
	
	if($("#content").val()=="" ){
		alert("Your suggestion is not completed, please re-enter the information..");
		$("#content").focus();
		return false;
    }

    if ($("#content").val().length > 1000) {
        alert("1000 words or less is recommended!!");
        $("#content").focus();
        return false;
    }
	
	
	return true;
}