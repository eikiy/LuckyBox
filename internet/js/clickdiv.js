// JavaScript Document

$(function(){
	
        function showLayer(DivID) {
            DivID = document.getElementById(DivID);
            DivID.style.display = '';
            //return true;
        }
        function hideLayer(DivID) {
            DivID = document.getElementById(DivID);
            DivID.style.display = 'none';
            //return true;
        }
        function MM_showHideLayers() { //v9.0
            var i, p, v, obj, args = MM_showHideLayers.arguments;
            for (i = 0; i < (args.length - 2); i += 3)
                with (document) if (getElementById && ((obj = getElementById(args[i])) != null)) {
                v = args[i + 2];
                if (obj.style) { obj = obj.style; v = (v == 'show') ? 'visible' : (v == 'hide') ? 'hidden' : v; }
                obj.visibility = v;
            }
        }

    });