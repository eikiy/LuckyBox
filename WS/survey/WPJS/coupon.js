document.write('<script type=\"text/javascript\" src=\"WPJS/base.js\"></script>');


function api_couponQuery(cbppkey)
{
    var url = api_url + "/api/Campaign";
    var post_data = $.extend(getBasePostData(), {       
        "act": "detailWithCorrectDate",        
        "CPBPKey":cbppkey        
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
            var htl='';
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }            
             if (data != null && data.code == 200) {
                if(data.data.status==400)
                {
                    window.location.href=homeurl;
                    return;
                }

                $('#expiredate').html('兌換期間：'+data.data.result[0]["cpbStartDate"].substr(0,10).replace(/\-/g,'/')+'~'+data.data.result[0]["cpbEndDate"].substr(0,10).replace(/\-/g,'/'))
                if(data.data.message!='')
                {                    
                    htl='<input type="button" name="button" class="butn input_field form_tx" id="btnsend" value="'+data.data.message+'">';
                    $('#txtbtn').html(htl);                    
                    $('#txtbtn').attr('disabled',true);
                }
                else
                {   
                     htl='<button class="butn input_field form_tx" id="btnsend" onclick="api_sendopen(\''+data.data.result[0]["cpbpKey"]+'\');" >優惠兌換 (請由服務人員點選)</button>';                    
                     $('#txtbtn').html(htl);
                    
                    
                }       
				
            }
            else
            {
                window.location.href=homeurl;
                return;
            }
			 
        },
        error: function(jqXHR, textStatus, errorThrown) {},
        complete: function(jqXHR, textStatus) {}
    });    
}



function api_sendopen(cbppkey)
{
    var url = api_url + "/api/Campaign";
    var post_data = $.extend(getBasePostData(), {       
        "act": "OpenUdp",        
        "CPBPKey":cbppkey        
    });

      swal({
                title: '確認兌換優惠',
                text: "如需兌換請呼叫服務人員為您服務，一旦開啟即視為已經使用",
                type: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: '立即兌換',
                cancelButtonText:'暫不兌換'
            }).then(function () {

        $.ajax({
            url: url,
            method: "POST",
            crossDomain: true,
            dataType: "json",
            data: post_data,
            beforeSend: function(jqXHR, settings) {

            },
            success: function(data, textStatus, jqXHR) {
                var htl='';
                if (debug_mode) {
                    console.log("success data=" + JSON.stringify(data));
                }            
                 if (data != null && data.code == 200) {
                    if(data.data.message=='不合理的錯誤發生')
                    {
                        window.location.href='https://www.tokiya.com.tw/';
                        return;
                    }

                    if(data.data.message!='')
                    {
                       sweetAlert("Sorry..", data.data.message, "error");
                    }
                    else
                    {
                        //htl='<span class="btn"><strong>'+data.data.result+'</strong></span>'
                        htl='<button class="butn input_field form_tx" id="btnsend" >'+data.data.result+'</button>'
                        $('#txtbtn').html(htl);
                    }                
                }
            },
            error: function(jqXHR, textStatus, errorThrown) {},
            complete: function(jqXHR, textStatus) {}
        });    
    })
}