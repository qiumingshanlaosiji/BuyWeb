var currentAjaxPage=1,moreNew=$(".moreNew");$(document).ready(function(){$('.actionList .actionList-li').hover(function(e){$('.actionList .actionList-li').removeClass('action');$(this).addClass('action');},function(e){$(this).removeClass('action');$('.actionList .actionList-li').eq(0).addClass('action');});$('.navBar').on('click','.navLink',function(){$('.navLink').removeClass('navAction');$(this).addClass('navAction');});ajaxLoadNews();moreNew.bind("click",ajaxLoadNews);var $leftImg=$('.focusBox-left .leftImg'),leftImg_top=0;if($leftImg.height()>350){leftImg_top=(350-$leftImg.height())/2;$leftImg.css('top',leftImg_top.toString()+'px');}});