$(function () {
	var beginYear = 1911;
	var endYear = new Date().getFullYear();
	var ff = document.form1;
	for (var i = beginYear; i <= endYear; i++) {
		ff.year2.options[i - beginYear + 1] = new Option(i, i, false, false)
	}
	for (var i = 1; i <= 12; i++) {
		ff.month2.options[i] = new Option(i, i, false, false)
	}
	for (var i = 1; i <= 31; i++) {
		ff.day2.options[i] = new Option(i, i, false, false)
	}
});

function change_sex(id) {
	$("#woman").attr("src", "images/woman.png");
	$("#man").attr("src", "images/man.png");
	$("#" + id).attr("src", "images/" + id + "-2.png");
	document.form1.sex.value = id
}
function change_checkbox(id, id2) {
	$("#" + id).attr("src", "images/" + id.charAt(0) + ".png");
	$("#" + id2).attr("src", "images/" + id2.charAt(0) + ".png");
	$("#" + id).attr("src", "images/" + id.charAt(0) + "-2.png");
	document.form1.edm1.value = id
}
function change_checkbox2(id, id2) {
	$("#" + id).attr("src", "images/" + id.charAt(0) + ".png");
	$("#" + id2).attr("src", "images/" + id2.charAt(0) + ".png");
	$("#" + id).attr("src", "images/" + id.charAt(0) + "-2.png");
	document.form1.edm2.value = id
}
function get_zipcode(city) {
	$.ajax({
		type: "POST",
		url: 'get_data.aspx',
		data: "t=2&city=" + city,
		cache: false,
		success: function (data) {
			array = data.split(';');
			document.getElementById('zipcode').innerHTML = '';
			document.getElementById('zipcode').options.add(new Option('請選擇', ''));
			for (var i = 0; i < array.length - 1; i++) {
				val = array[i].split(',');
				document.getElementById('zipcode').options.add(new Option(val[0], val[1]))
			}
		}
	})
}
function checkuser() {
	var userid = window.document.form1.email.value;
	if (userid != "") {
		$.ajax({
			type: "POST",
			url: 'check_user.aspx',
			data: "id=" + userid,
			cache: false,
			success: function (data) {
				if (data == "yes") {
					alert("這個email帳號已註冊過，請使用其他帳號~謝謝~");
					window.document.form1.email.value = '';
					window.document.form1.email.focus()
				}
			}
		})
	}
}
function checkdata() {
	var frmObj = window.document.form1;
	if (frmObj.name.value.length == 0) {
		alert("姓名未輸入,請重新填寫");
		frmObj.name.focus();
		return false
	}
	if (frmObj.nickname.value.length == 0) {
		alert("您的暱稱未輸入,請重新填寫");
		frmObj.nickname.focus();
		return false
	}
	if (frmObj.email.value.length == 0) {
		alert("您的email未輸入,請重新填寫");
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
	if (frmObj.year2.value != "") {
		if (frmObj.month2.value == "") {
			alert("您的結婚月份未選擇,請重新填寫");
			return false
		}
		if (frmObj.day2.value == "") {
			alert("您的結婚日期未選擇,請重新填寫");
			return false
		}
		if (checkDate(frmObj.month2.value, frmObj.day2.value) == false) {
			alert("您的結婚日期選擇錯誤");
			return false
		}
	}
	if (frmObj.mobile.value == "" && (frmObj.phone1.value == "" || frmObj.phone2.value == "")) {
		alert("手機或電話至少填寫一項,請重新輸入");
		frmObj.mobile.focus();
		return false
	}
	if (frmObj.mobile.value != "") {
		if (frmObj.mobile.value.length < 10) {
			alert("手機須為10碼,請重新輸入");
			frmObj.mobile.value = '';
			frmObj.mobile.focus();
			return false
		}
		re = /^[09]{2}[0-9]{8}$/;
		if (!re.test(frmObj.mobile.value)) {
			alert("手機格式不正確,請重新輸入");
			frmObj.mobile.value = '';
			frmObj.mobile.focus();
			return false
		}
	}
	if (frmObj.city.value == "") {
		alert("您的縣市未選擇,請重新填寫");
		return false
	}
	if (frmObj.zipcode.value == "") {
		alert("您的區域未選擇,請重新填寫");
		return false
	}
	if (frmObj.pwd.value.length < 4) {
		alert("密碼請設定4~8個字,請重新輸入");
		frmObj.pwd.focus();
		return false
	}
	var pass = frmObj.pwd.value;
	for (var i = 0; i < pass.length; i++) {
		var c = pass.charAt(i);
		if (!((c >= "A" && c <= "Z") || (c >= "a" && c <= "z") || (c >= "0" && c <= "9"))) {
			alert("您輸入的密碼含有特殊字元或空白,請重新輸入");
			frmObj.pwd.focus();
			return false
		}
	}
	if (frmObj.chk_pwd.value.length == 0) {
		alert("確認密碼未輸入,請重新填寫");
		frmObj.chk_pwd.focus();
		return false
	}
	if (frmObj.pwd.value != frmObj.chk_pwd.value) {
		alert("您兩次輸入的密碼不吻合,請重新輸入");
		frmObj.chk_pwd.focus();
		return false
	}
	return true
}
function checkDate(m, d) {
	if (m == "2" && (d == "31" || d == "30")) {
		return false
	}
	if ((m == "4" || m == "6" || m == "9" || m == "11") && (d == "31")) {
		return false
	}
	return true
}