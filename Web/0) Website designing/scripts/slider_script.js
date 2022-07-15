var isPlaying;
var isDefined=false;
function define_count_of_sliders ()
{
  var sliders = document.getElementsByClassName('slider');
  var countOfSliders = sliders.length;
  var slidesOfCurrent;

  isPlaying = new Array(countOfSliders);
  for (var i = 0; i < countOfSliders; i++) {
      isPlaying[i]=false;
  }

	  var main_timer = setTimeout(function(){slide_to_full_opacity();},1000);




}
function slide_to_full_opacity ()
{
  var sliders = document.getElementsByClassName('slider');
  var countOfSliders = sliders.length;
  var slidesOfCurrent;
  for (var i = 0; i < countOfSliders; i++) {
	    slidesOfCurrent = sliders[i].getElementsByClassName('slide');
	    for (var j = 0; j < slidesOfCurrent.length; j++) {
		      if (slidesOfCurrent[j].style.opacity=="0")
		        {
                slidesOfCurrent[j].removeAttribute("style");
		        }
	  }

  }
}

function slideChange (ID,side)
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

  if (isPlaying[index])
  {
    return;
  }

  isPlaying[index]=true;

  var slidesOfCurrent = currentSlider.getElementsByClassName('slide');
  for (var i = 0; i < slidesOfCurrent.length; i++)
   {
     if (slidesOfCurrent[i].classList.contains('activeSlide') || slidesOfCurrent[i].classList.length==1)
     {
       slidesOfCurrent[i].classList.remove('activeSlide');
       slidesOfCurrent[i].classList.remove('leftSlideACTIVE');
       slidesOfCurrent[i].classList.remove('rightSlideACTIVE');
       slidesOfCurrent[i].classList.add('inactiveSlide');

       if (side == 'left')
       {
         slidesOfCurrent[i].classList.add('leftSlide');
         if (i==0)
         { i=slidesOfCurrent.length-1;}
         else {i--;}
         slidesOfCurrent[i].classList.remove('inactiveSlide');
         slidesOfCurrent[i].classList.remove('leftSlide');
         slidesOfCurrent[i].classList.remove('rightSlide');
         slidesOfCurrent[i].classList.add('activeSlide');
         slidesOfCurrent[i].classList.add('leftSlideACTIVE');
       }
       else
       {
         slidesOfCurrent[i].classList.add('rightSlide');
         if (i==slidesOfCurrent.length-1) {i=0;}
         else { i++;}
         slidesOfCurrent[i].classList.remove('inactiveSlide');
         slidesOfCurrent[i].classList.remove('leftSlide');
         slidesOfCurrent[i].classList.remove('rightSlide');
         slidesOfCurrent[i].classList.add('activeSlide');
         slidesOfCurrent[i].classList.add('rightSlideACTIVE');
       }

       break;
     }
  }
var i = 0;
  var main_timer = setTimeout(function(){isPlaying[index]=false;},1000);

}
