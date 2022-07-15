function Chaos(){
  var square = document.getElementById("square"),
  circle = document.getElementById("circle"),
  triangle_up = document.getElementById("triangle-up"),
  triangle_down = document.getElementById("triangle-down");
var windowWidth=window.innerWidth, windowHeight=window.innerHeight;
var Wsquare=square.offsetWidth, Hsquare=square.offsetHeight,
Wcircle=circle.offsetWidth, Hcircle=circle.offsetHeight,
Wtriangle1=triangle_up.offsetWidth, Htriangle1=triangle_up.offsetHeight,
Wtriangle2=triangle_down.offsetWidth, Htriangle2=triangle_down.offsetHeight;

  var x1=1,y1=1,x2=1,y2=1,x3=1,y3=1,x4=1,y4=1;

  //начальные значения координат
  var posx1 = windowWidth*0+1;
  var posx2 = Math.round(windowWidth*0.2);
  var posx3 = Math.round(windowWidth*0.4);
  var posx4 = Math.round(windowWidth*0.3);
  var posy1 = Math.round(windowHeight*0+1);
  var posy2 = Math.round(windowHeight*0.5);
  var posy3 = Math.round(windowHeight*0.7);
  var posy4 = Math.round(windowHeight*0.4);
  setInterval(function() {
    //чтобы работать с media

    windowWidth=window.innerWidth, windowHeight=window.innerHeight;

    //высчитывание смещения
    if (posx1+Wsquare==windowWidth || posx1==0){
      x1*=-1;
    }
    if (posx2+Wcircle==windowWidth || posx2==0){
      x2*=-1;
    }
    if (posx3+Wtriangle1==windowWidth || posx3==0){
      x3*=-1;
    }
    if (posx4+Wtriangle2==windowWidth || posx4==0){
      x4*=-1;
    }
    if (posy1+Hsquare==windowHeight || posy1==0){
      y1*=-1;
    }
    if (posy2+Hcircle==windowHeight || posy2==0){
      y2*=-1;
    }
    if (posy3+Htriangle1/2==windowHeight || posy3==0){
      y3*=-1;
    }
    if (posy4+Htriangle2==windowHeight || posy4==-Htriangle2/2){
      y4*=-1;
    }
    //условия вылета за карту

    if (posx1+Wsquare>windowWidth || posx1<0 || posy1+Hsquare>windowHeight || posy1<0){
      posx1=0;
      posy1=0;
      x1=1;y1=1;
    }
    if (posx2+Wcircle>windowWidth || posx2<0 || posy2+Hcircle>windowHeight || posy2<0){
      posx2=0;
      posy2=0;
      x2=1;y2=1;
    }
    if (posx3+Wtriangle1>windowWidth || posx3<0 || posy3+Htriangle1/2>windowHeight || posy3<0){
      posx3=0;
      posy3=0;
      x3=1;y3=1;
    }
    if (posx4+Wtriangle2>windowWidth || posx4<0 || posy4+Htriangle2>windowHeight || posy4<-Htriangle2/2){
      posx4=0;
      posy4=0;
      x4=1;y4=1;
    }
    //смещение фигур
    posx1+=x1; posx2+=x2; posx3+=x3; posx4+=x4;
    posy1+=y1; posy2+=y2; posy3+=y3; posy4+=y4;
    //
    square.style.left=String(posx1)+"px";
    circle.style.left=String(posx2)+"px";
    triangle_up.style.left=String(posx3+"px");
    triangle_down.style.left=String(posx4)+"px";
    square.style.top=String(posy1)+"px";
    circle.style.top=String(posy2)+"px";
    triangle_up.style.top=String(posy3)+"px";
    triangle_down.style.top=String(posy4)+"px";
  }, 5);
}
