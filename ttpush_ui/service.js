// Popup (邀請好友)
var popInvite       = document.getElementById("popInvite");
var buttonInvite    = document.getElementById("invite");
var close           = popInvite.getElementsByClassName("close")[0];
var submit          = popInvite.getElementsByClassName("submit")[0];
var cancel          = popInvite.getElementsByClassName("cancel")[0];
buttonInvite.onclick    = function() { popInvite.style.display = "flex"; }
close.onclick           = function() { popInvite.style.display = "none"; }
submit.onclick          = function() { popInvite.style.display = "none"; }
cancel.onclick          = function() { popInvite.style.display = "none"; }

// All Popup (Click outside popup close)
window.onclick = function(event) {
    if (event.target == popInvite) {
        popInvite.style.display = "none";
    }
}