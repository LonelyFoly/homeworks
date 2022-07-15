var menuIsToggle=false;
var mobilemenuIsToggle=false;
var lastSize;
/*для скрытия менюше при переходе в мобильный режим и из него*/
window.addEventListener('resize', function() {
    if ((lastSize>=940 & window.innerWidth<940) || (lastSize<940 & window.innerWidth>=940) )
    {
      var toggleMenus = document.getElementsByClassName('toggleMenu');
      var underlines = document.getElementsByClassName('underline');

      for (var i = 0; i < toggleMenus.length; i++) {
        if (toggleMenus[i].style.display=="block")
        {
          toggleMenus[i].style.display="none";
          underlines[i].style.removeProperty('opacity');
          menuIsToggle=false;
          break;
        }
      }
    }
    if (window.innerWidth>=940)
    {
      var toggleMenus = document.getElementsByClassName('mobiletoggleMenu');
      toggleMenus[0].style.display="none";
      mobilemenuIsToggle=false;
    }

    lastSize=window.innerWidth;
}, true);
function toggleMenuToToggle(ID)
{

  var toggleMenus = document.getElementsByClassName('toggleMenu');

  var underlines = document.getElementsByClassName('underline');
  for (var i = 0; i < toggleMenus.length; i++) {
    if (toggleMenus[i].style.display=="block")
    {
      toggleMenus[i].style.display="none";
      underlines[i].style.removeProperty('opacity');
      menuIsToggle=false;
      break;
    }

  }
  underlines[ID].style.opacity="1";
  toggleMenus[ID].style.display="block";
  menuIsToggle=true;


}
function togglemobileMenuToToggle()
{
  var mtoggleMenus = document.getElementsByClassName('mobiletoggleMenu');

  if (mobilemenuIsToggle)
  {
      mtoggleMenus[0].style.display="none";
      var toggleMenus = document.getElementsByClassName('toggleMenu');

      for (var i = 0; i < toggleMenus.length; i++) {
        if (toggleMenus[i].style.display=="block")
        {
          toggleMenus[i].style.display="none";

          menuIsToggle=false;
          break;
        }
      }
  }
  else {
      mtoggleMenus[0].style.display="block";
  }

  mobilemenuIsToggle=!mobilemenuIsToggle;

}
function toggleMenutoCLose()
{
  var valHeight = (document.getElementById('headerforJs')).clientHeight;
  var y =event.pageY;
  if (!menuIsToggle)
  {
    return;
  }
  var underlines = document.getElementsByClassName('underline');
  var toggleMenus = document.getElementsByClassName('toggleMenu');
  for (var i = 0; i < toggleMenus.length; i++) {
    if (toggleMenus[i].style.display=="block")
    {
      if (y>valHeight+toggleMenus[i].clientHeight)
      {
        toggleMenus[i].style.display="none";
        underlines[i].style.removeProperty('opacity');
        menuIsToggle=false;
      }

      break;
    }

  }

}

//document.getElementsByClassName("main_form").attachEvent('onsubmit',func_input);
