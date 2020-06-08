
$(function(){

//登入海外新人專區
	$("#LoginDownload").click(function (e) {

		goLogin();

		});

	$('#passwds').keyup(function(event) {

		var e = event.keyCode;


		if (e==13)
		{
			goLogin();
			return;

		}

	});
	$('#logout').click(function(){

		if(confirm("您將登出校稿專區?"))
		{
			window.location.href="logout.php";
		}

	});

	$('#proofreading_case').change(function(){


		window.location.href="proofreadingAlbums.php?c1="+$('#proofreading_case').val();


	});

	//清除留言欄位文字
	$("#p_notes").click(function (e) {

		if($("#p_notes").val() == '請輸入您的意見')
		{

			$("#p_notes").val('');
		}

	});






//搜尋
	function goLogin()
	{
		if($("#passwds").val() == '')
		{

			alert('請輸入密碼!');
			//$("#passwds").focus();
			return false;

		}
		else
		{
			useAjax('goLogin' , $("#passwds").val());

		}

	}



	//送出表單
	$("#setBut").click(function (e) {

		$("#setForm").submit(function (e) {



		});



		return;
	});

	$('.icon-cross').click(function(){

		if(confirm("Do you want remove this product?"))
		{
			useAjax('removeInquiry', $(this).attr('data-rel'));
		}


	});

	$('#_dateSelect').change(function(){

		window.location.href='resource01.php?d='+$(this).val();

	});


	$('#_addInquiryBut').click(function(){


					$('#_addInquiryButText').html('Success!');


					$('#_addInquiryButText').animate({
						opacity: 0.5
					}, 700, function() {



						//alert( $("#_addInquiryBut").attr('data-rel'));

						useAjax('saveInquiry', $("#_addInquiryBut").attr('data-rel'));

					});




	});


	$('._scrolTop').click(function(){

		var moveID = $(this).attr("data-toggle");
		// 讓捲軸移動到 0 的位置
		//$('#'+moveID).scrollTop(200);
		$.scrollTo('#'+moveID,1000);
		return false;
	});




});

//確認滿意圖片
function sendOKPic(ID)
{
	if(confirm("將送出紀錄為滿意照片?"))
	{

		useAjax('sendOKPic',ID);
	}

}

//送出校稿留言
function sendNotes(ID)
{
	if(confirm("將送出該照片的意見?"))
	{

		var needVal = (ID + "§" + $('#p_notes').val());
		useAjax('sendNotes',needVal);
	}
}

function changYear(Year , Pages)
{
    var needVal = Year + "," + Pages;
	useAjax('changYear' , needVal);
}


//重新讀取股票
function reloadStock(stock)
{
	setLoadPlayer( '' , '' , '');
	useAjax('reloadStock' , stock);
}

//AJAX動作
function useAjax(ACT , needVal){


	$.ajax({
		type: 'POST',
		url: 'ajax.php',
		data: {Func:ACT,Val:encodeURI(needVal)},
		dataType:'json',
		beforeSend:function(){


		},
		success:function(json){


			//回傳判斷
			switch(ACT)
			{

				//海外新人專區
			   	case "goLogin":

					if(json.re == 'Err')
					{
						$('#_showErr').html('您輸入的密碼錯誤！');
						$('#passwds').val('');
					}
					else if(json.re == 'TimeOut')
					{

						$('#_showErr').html('該組密碼已過下載期限！');
						$('#passwds').val('');
					}
					else
					{

						window.location.href = 'aboutAbroadDownload.php';
					}

					break;


				//確認滿意圖片
				case "sendOKPic":

					$('#_chk'+json.re).hide();
					$('#ar'+json.re).append('<a class="icon-check check" title="選取"><span class="text-hide">選取</span></a>');

					break;

				//校稿留言
				case "sendNotes":

					$('#qty'+json.re).html('<em class="message icon-align-left"><span>'+json.reQty+'</span></em>');
					$('#_notesList').prepend(json.reNotes);
					$('#p_notes').val('');

					break;

			}



		},
		complete:function(){ //生成分頁條

		},
		error:function(){
			//alert("讀取錯誤!");
		}
	});



}


//調整讀取條位置
function setLoadPlayer( view , left , top)
{


	if(view == 'none')
	{
		$.unblockUI();
	}
	else
	{
		$.blockUI({ css: {
			border: 'none',
			padding: '15px',
			backgroundColor: '#000',
			'-webkit-border-radius': '10px',
			'-moz-border-radius': '10px',
			opacity: .5,
			color: '#fff'
		} });

	}

}
