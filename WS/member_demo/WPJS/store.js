document.write('<script type=\"text/javascript\" src=\"WPJS/base.js\"></script>');

//取門店列表
function api_getstorelist(area,city)
{

	var url = api_url + "/api/store";
    var post_data = $.extend(getBasePostData(), {    	
        "act": "getStoreList",
        "area":area,
        "city": city       
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
                sessionStorage.removeItem("storelist");
                saveSessionStorage("storelist",JSON.stringify(data.data.result));
            	var store='';
            	if(obj.length>0)
            	{
            		//有門店就列出            		
            		store=store.concat('<tr><th colspan="3">',city,'</th></tr>');
            		$.each(obj,function(index, el) {
            			store=store.concat('<tr><td id="store01"><a href="mapInfo.html?storeid=',$.trim(el.store_id),'" ><span>',el.store_name,'</span><img src="img/zoom.png" alt=""><div class="cl"></div></a></td><td>',el.store_address,'</td><td>',el.store_tel,'</td>');	            			
            		});            		
            		$('#storeList').html(store);

            	}
            	else
            	{
                    $('#storeList').html('');
            		sweetAlert("Sorry..", city+'暫無分店', "info");       

            	}                
            }

        },
        error: function(jqXHR, textStatus, errorThrown) {},
        complete: function(jqXHR, textStatus) {}
    });
    return false;
};


function bindStoreList(inobj)
{
    if(inobj!="")
                {
                    //有門店就列出
                    var store='';
                    var obj=jQuery.parseJSON(inobj); 
                    if(typeof(loadSessionStorage("city"))!='undefined')
                    {
                    store=store.concat('<tr><th colspan="3">',loadSessionStorage("city"),'</th></tr>');
                    $.each(obj,function(index, el) {
                        store=store.concat('<tr><td id="store01"><a href="mapInfo.html?storeid=',$.trim(el.store_id),'" ><span>',el.store_name,'</span><img src="img/zoom.png" alt=""><div class="cl"></div></a></td><td>',el.store_address,'</td><td>',el.store_tel,'</td>');                          
                    });                 
                    $('#storeList').html(store);
                }

                }
}



//進入門店訊息
function getStoreDetail()
{

	var storeid=getUrlParameter('storeid');	
	if(storeid!=null)
	{
		api_getstoredetail(storeid);
	}
	else
	{
		window.location.href('index.html#map-nav');
	}
	
};


//取門店明細
function api_getstoredetail(storeid)
{
	var url = api_url + "/api/store";
    var post_data = $.extend(getBasePostData(), {    	
        "act": "getStoreDetail",
        "storeno":storeid
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
            		
            		$('#storename').html(obj[0].store_name);
            		$('#address').html(obj[0].store_address);
            		$('#tel').html(obj[0].store_tel);
            		$('#openperiod').html(obj[0].store_opening_hours.replace('\n','<br/>'));            		
            		$('#storemap').attr('src',obj[0].store_map);            		
            		$('#parking').html(obj[0].store_parking_info.replace('\n','<br/>'));            		
            		$('#remark').html(obj[0].store_remark);
            		$('#googleMap').attr('src','http://maps.google.com.tw/maps?f=q&hl=zh-TW&geocode=&q='+obj[0].store_address+'&z=16&output=embed&t=p')
            		            		
            		

            	}
            	else
            	{
            		sweetAlert("Sorry..", '無分店資料', "info");                                                                           
					window.location.href="index.html#map-nav";                                                                    
            	}                
            }

        },
        error: function(jqXHR, textStatus, errorThrown) {},
        complete: function(jqXHR, textStatus) {}
    });
    return false;
};
