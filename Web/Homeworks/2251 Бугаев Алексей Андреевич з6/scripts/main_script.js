function autoplay (ID)
{
  var currentSlider = document.getElementById(ID);
  var arrayOfSliders = document.getElementsByClassName('slider');
  var index = 0;
  for (var i = 0; i < arrayOfSliders.length; i++) {
    if (arrayOfSliders[i]==currentSlider)
    {
      index = i;
      break;
    }
  }
  thunder[index] = !thunder[index];
  var slidesOfCurrent = currentSlider.getElementsByClassName('arrow');


  var timer = setInterval(function()
  {
    if (thunder[index])
    {
      clearInterval(timer);
      return;
    }
     slideChange(ID,'right', false)
  } ,2200);

}



function slideChange (ID,side,isAutoplay)
{
  var currentSlider = document.getElementById(ID);
  var arrayOfSliders = document.getElementsByClassName('slider');
  var index = 0;
  for (var i = 0; i < arrayOfSliders.length; i++) {
    if (arrayOfSliders[i]==currentSlider)
    {
      index = i;
      break;
    }
  }

  if (isAutoplay &&  isPlaying[index])
  {
    return;
  }
  if ((!thunder[index] && isAutoplay))
  {
    return;
  }

  isPlaying[index]=true;

  var slidesOfCurrent = currentSlider.getElementsByClassName('slide');
  for (var i = 0; i < slidesOfCurrent.length; i++)
   {
     if (slidesOfCurrent[i].classList.contains('activeSlide'))
     {
       slidesOfCurrent[i].classList.remove('activeSlide');
       slidesOfCurrent[i].classList.add('inactiveSlide');
       if (side == 'left')
       {
         if (i==0)
         { i=slidesOfCurrent.length-1;}
         else {i--;}
       }
       else
       {
         if (i==slidesOfCurrent.length-1) {i=0;}
         else { i++;}
       }
       slidesOfCurrent[i].classList.remove('inactiveSlide');
       slidesOfCurrent[i].classList.add('activeSlide');
       break;
     }
  }
var i = 0;
  var main_timer = setTimeout(function(){isPlaying[index]=false;},1000);

}
