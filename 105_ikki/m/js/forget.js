function checkdata() {
	var frmObj = window.document.form1;
	if (frmObj.email.value.length == 0) {
		alert("請輸入 [e - mail]");
		frmObj.email.focus();
		return false
	}
	var em = frmObj.email.value;
	var len = em.length;
	for (var i = 0; i < len; i++) {
		var c = em.charAt(i);
		if (!((c >= "A" && c <= "Z") || (c >= "a" && c <= "z") || (c >= "0" && c <= "9") || (c == "-") || (c == "_") || (c == ".") || (c == "@"))) {
			alert("您輸入的e-mail不正確,請重新輸入");
			frmObj.email.focus();
			return false
		}
	}
	if ((em.indexOf("@") == -1) || (em.indexOf("@") == 0) || (em.indexOf("@") == (len - 1))) {
		alert("您輸入的e-mail不正確,請重新輸入");
		frmObj.email.focus();
		return false
	}
	if ((em.indexOf("@") != -1) && (em.substring(em.indexOf("@") + 1, len).indexOf("@") != -1)) {
		alert("您輸入的e-mail不正確,請重新輸入");
		frmObj.email.focus();
		return false
	}
	if ((em.indexOf(".") == -1) || (em.indexOf(".") == 0) || (em.lastIndexOf(".") == (len - 1))) {
		alert("您輸入的e-mail不正確,請重新輸入");
		frmObj.email.focus();
		return false
	}
	return true
}