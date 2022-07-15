var wasPushed = false;

function func_input()
{
  var q1=document.forms.main_form.q1;
  var q2=document.forms.main_form.q2;
  var q3=document.forms.main_form.q3;
  var c1=document.forms.main_form.c1;
  var c2=document.forms.main_form.c2;
  var c3=document.forms.main_form.c3;
  var r1=document.forms.main_form.r1;
  var r2=document.forms.main_form.r2;
  var r3=document.forms.main_form.r3;
  var selector = document.forms.main_form.selector1.value;
  var points=0;
  var isFilled=false;
  var countOfFilled = 0;
  var allQuestions = document.getElementsByClassName('variant');

//
  for (var i = 0; i < r1.length; i++) {
    if (r1[i].checked==true)
    {
      points+=Number(r1[i].value);
      countOfFilled+=1;
    }
  }
  for (var i = 0; i < r2.length; i++) {
    if (r2[i].checked==true)
    {
      points+=Number(r2[i].value);
      countOfFilled+=1;
    }
  }
  for (var i = 0; i < r3.length; i++) {
    if (r3[i].checked==true)
    {
      points+=Number(r3[i].value);
      countOfFilled+=1;
    }
  }
///////////////////////////////////////
var isRight=true;
for (var i = 0; i < c1.length; i++) {
  if ((c1[i].checked==true && c1[i].value=="0") || (c1[i].checked==false && c1[i].value=="1"))
  {

    isRight=false;
    break;

  }
}
if (isRight)
{
  points+=1;
}

var isRight=true;
for (var i = 0; i < c2.length; i++) {
  if ((c2[i].checked==true && c2[i].value=="0") || (c2[i].checked==false && c2[i].value=="1"))
  {
    isRight=false;
    break;

  }
}
if (isRight)
{
  points+=1;
}


var isRight=true;
for (var i = 0; i < c3.length; i++) {
  if ((c3[i].checked==true && c3[i].value=="0") || (c3[i].checked==false && c3[i].value=="1"))
  {
    isRight=false;
    break;

  }
}
if (isRight)
{
  points+=1;
}
///////////////////////////////////////

var x=false;
for (var i = 0; i < c1.length; i++) {
  if (c1[i].checked==true) {x=true; break;}

}
if (x){countOfFilled+=1}

var x=false;
for (var i = 0; i < c2.length; i++) {
  if (c2[i].checked==true) {x=true; break;}

}
if (x){countOfFilled+=1}

var x=false;
for (var i = 0; i < c3.length; i++) {
  if (c3[i].checked==true) {x=true; break;}

}
if (x) {countOfFilled+=1}

if (q1.value!="") {countOfFilled+=1;}
if (q2.value!="") {countOfFilled+=1;}
if (q3.value!="") {countOfFilled+=1;}
if (q1.value=="Матроскин") {points+=1;}
if (q2.value=="Том") {points+=1;}
if (q3.value=="Гав") {points+=1;}
var selecTorIsChecked = false;

if (selector!="-1"){selecTorIsChecked=true;}
if (selector=="1"){points+=1;}
var isReturn=true;


if (countOfFilled<9) {
 isReturn=false; alert('Ты не на все вопросы ответил.....');}

else
{
  if (!selecTorIsChecked) {alert('Осталось ответить на супер-вопрос!'); return false;}
  else
  {
  if (points<5) {alert('Ты ночинающий котолюб. \nУдачи на столь нелёгком пути! \nПосмотри свои ошибки!');}


  else if (points <8) {alert('Ты продвинутый котофаг. \nОставшийся путь тернист, но у тебя всё получится! \nПосмотри свои ошибки!');}
  else if (points <10) {alert('Ты достиг дзен-котизма. \nКыс-кыс-кыс, шур-шур-шур. \nПосмотри свои ошибки!');}
  else {alert('Да ты и есть сладкий котичек! \nОсталось тебя только почухать. \nМяу :з');}
  }

  //теперь подкрасим
  for (var i = 0; i < allQuestions.length; i++) {
     allQuestions[i].className=allQuestions[i].className.replace('_', '');
     allQuestions[i].className += "_";
  }
  q1.className=q1.className.replace('_', '');
  q2.className=q2.className.replace('_', '');
  q3.className=q3.className.replace('_', '');
  if (q1.value=="Матроскин") {q1.className = "text_green_";}
  if (q2.value=="Том") {q2.className = "text_green_";}
  if (q3.value=="Гав") {q3.className = "text_green_";}
  var thing = document.getElementsByClassName('corrector');
  thing[0].className=thing[0].className.replace('_', '');
  if (selector=="1"){
  thing[0].className+="_";}


}
return false;


}


//document.getElementsByClassName("main_form").attachEvent('onsubmit',func_input);
