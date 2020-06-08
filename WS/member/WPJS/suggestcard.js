document.write('<script type=\"text/javascript\" src=\"WPJS/sha1.js\"></script>');
document.write('<script type=\"text/javascript\" src=\"WPJS/base.js\"></script>');

function api_Sgetstorelist(area,ctrl)
{

	var url = api_url + "/api/SuggestCard";
    var post_data = $.extend(getBasePostData(), {    	
        "act": "bindstore",
        "area":area
        
    });
    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {

        },
        success: function(data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }            
            if (data != null && data.code == 200) {
            	
            	var obj=jQuery.parseJSON(JSON.stringify(data.data.result));           	
            	
            	if(obj.length>0)
            	{
            		//有門店就列出
            		var store='';

            		$('#'+ctrl+' option').remove();
            		$('#'+ctrl).append($("<option></option>").attr("value", "").text("請選擇門店"));
            		$.each(obj,function(index, el) {
            			$('#'+ctrl).append($("<option></option>").attr("value", el.storeNo).text(el.storeName));            			
            		});            		            		

            	}
            	else
            	{
            		sweetAlert("Sorry..", city+'暫無分店', "info");       

            	}                
            }

        },
        error: function(jqXHR, textStatus, errorThrown) {},
        complete: function(jqXHR, textStatus) {}
    });
    return false;
};


function api_GetQuestion(eatdate,eatstore,eatmeal)
{

	var url = api_url + "/api/SuggestCard";
    var post_data = $.extend(getBasePostData(), {    	
        "act": "getSurveyQ",        
        "eatstore":eatstore,
        "eatdate":eatdate,
        "eatmeal":eatmeal
    });
    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {

        },
        success: function(data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }            
            if (data != null && data.code == 200) {
            	
            	var obj=jQuery.parseJSON(JSON.stringify(data.data.result));           	
            	var AnsString='';
    			var AnsArray;	

    			BindSSF_AnalysisMain('drpsugtype0');

            	if(obj.length>0)
            	{
            		$('#lblmaindataguid').val(obj[0].maindataguid);   
            		$('#lblversionid').val(data.data.message);   
            		        	    
        			$.each(obj,function(index, el) {                    			
        			$('#lblQ'+el.questionorder.toString()).val(el.questionguid);        		
        			//開始載入答案
        			switch(el.questionorder) {
        				case '1':        					
        					AnsArray=jQuery.parseJSON(JSON.stringify(el.ans));
        					$.each(AnsArray,function(index, el1) {
							AnsString=AnsString+'<input id="rblQ1" name="rblQ1" value="'+el1.ansGUID+'" type="radio" class="radio" onclick="Q1click()">'+el1.ansName+'</input>';
        					});          					
        					$('#Q1Content').html(AnsString);
        					break;

        				case '2':
        					$("#drpQ2 option").remove();
        					AnsArray=jQuery.parseJSON(JSON.stringify(el.ans));
        					$("#drpQ2").append($("<option></option>").attr("value", " ").text("請選擇"));
        					$.each(AnsArray,function(index, el1) {
							$("#drpQ2").append($("<option></option>").attr("value", el1.ansGUID).text(el1.ansName));    							
        					});          					
        					break;
        				case '3':
        					$("#selQ3").html('');
        					var Q3='';
        					AnsArray=jQuery.parseJSON(JSON.stringify(el.ans));        					
        					$.each(AnsArray,function(index, el1) {
        					Q3=Q3+'<input id="chkQ3_'+el1.ansOrder+'" name="chkQ3" type="checkbox" class="radio" onclick="Q3click(\'chkQ3_'+el1.ansOrder+'\');" value="'+el1.ansGUID+'"><label for="chkQ3_0">'+el1.ansName+'</label>';
        					});  
        					$("#selQ3").html(Q3);
        				break;
        				case '12':
        					$('#selQ12').html('');
        					var Q12='';
        					AnsArray=jQuery.parseJSON(JSON.stringify(el.ans));
        					$.each(AnsArray,function(index, el1) {
        					Q12=Q12+'<input id="rblQ12_"'+el1.ansOrder+' name="rblQ12" value="'+el1.ansGUID+'" type="radio" class="radio"><label for="rblQ12_0">'+el1.ansName+'</label>';
        					}); 
        					$("#selQ12").html(Q12);
        				break;
        				case '5':
        					$("#drpQ5 option").remove();
        					AnsArray=jQuery.parseJSON(JSON.stringify(el.ans));
        					$("#drpQ5").append($("<option></option>").attr("value", " ").text("請選擇"));
        					$.each(AnsArray,function(index, el1) {
							$("#drpQ5").append($("<option></option>").attr("value", el1.ansGUID).text(el1.ansName));    							
        					});          					
        					break;
        				case '6':
        					AnsArray=jQuery.parseJSON(JSON.stringify(el.ans));
        					$.each(AnsArray,function(index, el1) {
								$('#lblQ6'+(parseInt(el1.ansOrder)+1).toString()).val(el1.ansGUID)
        					});

        				break;
						case '7':
        					$("#selQ7").html('');
        					var Q7='';
        					AnsArray=jQuery.parseJSON(JSON.stringify(el.ans));        					
        					$.each(AnsArray,function(index, el1) {
        					Q7=Q7+'<input id="chkQ7_'+el1.ansOrder+'" name="chkQ7" type="checkbox" class="radio" onclick="Q7click(\'chkQ7_'+el1.ansOrder+'\');" value="'+el1.ansGUID+'"><label for="chkQ7_0">'+el1.ansName+'</label>';
        					});  
        					$("#selQ7").html(Q7);
        				break;  
        				case '8':
        					$('#selQ8').html('');
        					var Q8='';
        					AnsArray=jQuery.parseJSON(JSON.stringify(el.ans));
        					$.each(AnsArray,function(index, el1) {
        					if(el1.ansName!='無')
        					{
        						Q8=Q8+'<input id="rblQ8_"'+el1.ansOrder+' name="rblQ8" value="'+el1.ansGUID+'" type="radio" class="radio"><label for="rblQ8_0">'+el1.ansName+'</label>';
        					}
        					}); 
        					$("#selQ8").html(Q8);
        				break;     
        				case '9':
						//性別，預設帶無
	        				$('#selQ9').val('');
	        				AnsArray=jQuery.parseJSON(JSON.stringify(el.ans)); 
	        				$.each(AnsArray,function(index, el1) {
	        				if(el1.ansName='無'){
	        					$('#SelQ9').val(el1.ansGUID);
	        					} 
        					}); 
	        				       								
        				break;
    					case '10':
						//年齡，預設帶無
	        				$('#selQ10').val('');
	        				AnsArray=jQuery.parseJSON(JSON.stringify(el.ans)); 
	        				$.each(AnsArray,function(index, el1) {
	        				if(el1.ansName='無'){
	        					$('#SelQ10').val(el1.ansGUID);
	        					}
        					}); 
	        				        								
        				break;
        				case '11':
						//用餐時間
	        				$('#selQ11').val('');
	        				AnsArray=jQuery.parseJSON(JSON.stringify(el.ans)); 
	        				$.each(AnsArray,function(index, el1) {
	        				if(el1.ansOrder=loadSessionStorage("eattime")){
	        					$('#SelQ11').val(el1.ansGUID);
	        					}
        					}); 
	        				        								
        				break;
        				}
        			});       		  		          		            
            	}
            	else
            	{
            		sweetAlert("Sorry..", '此問卷暫無題目', "error");       

            	}                
            }

        },
        error: function(jqXHR, textStatus, errorThrown) {},
        complete: function(jqXHR, textStatus) {}
    });
    return false;
}


function BindSSF_AnalysisMain(Tctrl)
{
	var url = api_url + "/api/SuggestCard";
    var post_data = $.extend(getBasePostData(), {    	
        "act": "SSF_AnalysisMain"               
    });
    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {
        },
        success: function(data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }            
            if (data != null && data.code == 200) {            	
            	var obj=jQuery.parseJSON(JSON.stringify(data.data.result));
            	$("#"+jQuery.trim(Tctrl)+" option").remove();
            	$("#"+jQuery.trim(Tctrl)).append($("<option></option>").attr("value", " ").text("類別"));	
            	$.each(obj,function(index, el1) {
				$("#"+jQuery.trim(Tctrl)).append($("<option></option>").attr("value", el1.val).text(el1.txt));    							
				});              	           
            }
        },
        error: function(jqXHR, textStatus, errorThrown) {},
        complete: function(jqXHR, textStatus) {}
    });
    return false;
};

function BindSSF_AnalysisDetail(Sctrl,Tctrl)
{
	var url = api_url + "/api/SuggestCard";
    var post_data = $.extend(getBasePostData(), {    	
        "act": "SSF_AnalysisDetail",
        "AnalyMGUID":$('#'+Sctrl).val(),
        "VersionID":$('#lblversionid').val()
    });
    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {

        },
        success: function(data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }            
            if (data != null && data.code == 200) {            	
            	var obj=jQuery.parseJSON(JSON.stringify(data.data.result));
            	$("#"+Tctrl+" option").remove();
            	$("#"+Tctrl).append($("<option></option>").attr("value", " ").text("類別"));	
            	$.each(obj,function(index, el1) {
				$("#"+Tctrl).append($("<option></option>").attr("value", el1.val).text(el1.txt));    							
				});              	           
            }

        },
        error: function(jqXHR, textStatus, errorThrown) {},
        complete: function(jqXHR, textStatus) {}
    });
    return false;
};


function BindSSF_SuggestionDetail(Sctrl,Tctrl)
{
	var url = api_url + "/api/SuggestCard";
    var post_data = $.extend(getBasePostData(), {    	
        "act": "SuggestionDetail",
        "AnalyMGUID":$('#'+Sctrl).val(),
        "VersionID":$('#lblversionid').val()
    });
    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {

        },
        success: function(data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }            
            if (data != null && data.code == 200) {            	
            	var obj=jQuery.parseJSON(JSON.stringify(data.data.result));
            	$("#"+Tctrl+" option").remove();
            	$("#"+Tctrl).append($("<option></option>").attr("value", " ").text("意見內容"));	
            	$.each(obj,function(index, el1) {
				$("#"+Tctrl).append($("<option></option>").attr("value", el1.val).text(el1.txt));    							
				});              	           
            }

        },
        error: function(jqXHR, textStatus, errorThrown) {},
        complete: function(jqXHR, textStatus) {}
    });
    return false;
};


function SendCard(isPrize)
{
	//整理答案
	var q3ans='';
	$('input:checkbox:checked[name="chkQ3"]').each(function(i,el) { 		
		q3ans=q3ans+el.value+',';
	});
	q3ans=q3ans.substr(0,q3ans.length-1);

	var q7ans='';
	$('input:checkbox:checked[name="chkQ7"]').each(function(i,el) { 		
		q7ans=q7ans+el.value+',';
	});
	q7ans=q7ans.substr(0,q7ans.length-1);

	var sugg=''
	for(i=0;i<rowCount;i++)
	{
		if($('#txtsuggestion'+i.toString()).val()!='')
		{
			 sugg=sugg+'{"sugtype":"'+$('#drpsugtype'+i.toString()).val()+'","analysismain":"'+$('#drpanalysismain'+i.toString()).val()+'","analysisdetail":"'+$('#drpanalysisdetail'+i.toString()).val()+'","txtsuggest":"'+$('#txtsuggestion'+i.toString()).val()+'"},';			
		}
	}
	if(sugg!='')
	{		
		sugg='['+sugg.substr(0,sugg.length-1)+']';
	}
	


	var url = api_url + "/api/SuggestCard";
    var post_data = $.extend(getBasePostData(), {    	
        "act": "IQSave",
        "MainDataGUID":$('#lblmaindataguid').val(),
        "VersionID":$('#lblversionid').val(),
        "VersionName":loadSessionStorage("versionname"),
        "eatstore":loadSessionStorage("eatstore"),
        "eatdate":loadSessionStorage("eatdate"),
        "eattime":loadSessionStorage("eattime"),
        "cname":'',
        "invoice":loadSessionStorage("eatinvoice"),
        "q1questionguid":$('#lblQ1').val(),
        "q1ansguid":$('input:radio:checked[name="rblQ1"]').val(),
        "q2questionguid":$('#lblQ2').val(),
        "q2ansguid":$('select[name="drpQ2"]').val(),
        "q3questionguid":$('#lblQ3').val(),
        "q3ansguid":q3ans, //多個要組合
        "q12questionguid":$('#lblQ12').val(),
        "q12ansguid":$('input:radio:checked[name="rblQ12"]').val(),
        "q6questionguid":$('#lblQ6').val(),
        "q62ansguid":$('#lblQ62').val(),
        "sQ62Code":$('input:radio:checked[name="grdQ62"]').val(),
        "q63ansguid":$('#lblQ63').val(),
        "sQ63Code":$('input:radio:checked[name="grdQ63"]').val(),
        "q64ansguid":$('#lblQ64').val(),
        "sQ64Code":$('input:radio:checked[name="grdQ64"]').val(),
        "q65ansguid":$('#lblQ65').val(),
        "sQ65Code":$('input:radio:checked[name="grdQ65"]').val(),
        "q66ansguid":$('#lblQ66').val(),
        "sQ66Code":$('input:radio:checked[name="grdQ66"]').val(),
        "q67ansguid":$('#lblQ67').val(),
        "sQ67Code":$('input:radio:checked[name="grdQ67"]').val(),
        "q5questionguid":$('#lblQ5').val(),
        "q5ansguid":$('#drpQ5').val(),
        "q7questionguid":$('#lblQ7').val(),
        "q7ansguid":q7ans,   //多個要組合
        "q8questionguid":$('#lblQ8').val(),
        "q8ansguid":$('input:radio:checked[name="rblQ8"]').val(),
        "q9questionguid":$('#lblQ9').val(),
        "q9ansguid":$('#SelQ9').val(),
        "q10questionguid":$('#lblQ10').val(),
        "q10ansguid":$('#SelQ10').val(),
        "q11questionguid":$('#lblQ11').val(),
        "q11ansguid":$('#SelQ11').val(),
        "sugg":sugg
        
    });
    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {

        },
        success: function(data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }            
            
            if (data != null && data.code == 200) {  
	            if(!isPrize)
	            {
	            	sessionStorage.removeItem("eatstore");
	            	swal({
					  title: 'Thank you',
					  text: '感謝您的填寫',
					  type: 'success'
					}, function() {
					  location.href="index.html";
					});				
	            }
	            else
	            {
	            	saveSessionStorage("recMainGuid",data.data.message);
	            	location.href="memberlogin.html";
	            }
            }
            else
            {
            	swal({
					  title: 'Error..',
					  text: '發生錯誤，請重新填寫',
					  type: 'error'
					}, function() {
						sessionStorage.clear();
					  location.href="index.html";
					});	
            }

        },
        error: function(jqXHR, textStatus, errorThrown) {},
        complete: function(jqXHR, textStatus) {}
    });
    return false;
}

function api_suglogin()
{
	var url = api_url + "/api/SuggestCard";
    var post_data = $.extend(getBasePostData(), {    	
        "act": "PrizeInto",
        "RecMainGuid":loadSessionStorage("recMainGuid"),
        "email":$('#email').val(),
        "invoice":loadSessionStorage("eatinvoice"),
        "eatstore":loadSessionStorage("eatstore"),
        "eatdate":loadSessionStorage("eatdate"),
        "pwd":CryptoJS.SHA1($('#pwd').val()).toString()

    });
    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {
        },
        success: function(data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }            
            if (data != null && data.code == 200) {            	
            	if(data.data.message!="")
            	{
            		sweetAlert("Oops..","發生錯誤："+data.data.message,"error");
            		return false;
            	}
            	else
            	{	
            		sessionStorage.clear();
            		swal({
					  title: 'Thank you',
					  text: '感謝您的填寫',
					  type: 'success'
					}, function() {
					  location.href="index.html";
					});	
					
            	}
            }
        },
        error: function(jqXHR, textStatus, errorThrown) {},
        complete: function(jqXHR, textStatus) {}
    });
    return false;
}



