var thunder = [true, true];
var isPlaying = [false, false];
function define_count_of_sliders ()
{
  var sliders = document.getElementsByClassName('slider');
  var countOfSliders = sliders.length;
  thunder = new Array(countOfSliders);
  isPlaying = new Array(countOfSliders);
  for (var i = 0; i < countOfSliders; i++) {
      thunder[i]=true;
      isPlaying[i]=false;
  }
}
