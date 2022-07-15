function func_input()
{
  var control1=document.forms.main_form.control1.value;
  var control2=document.forms.main_form.control2.value;
  var control3=document.forms.main_form.control3.value;
  var descr=document.forms.main_form.descr.value;
  var selector1=document.forms.main_form.selector1.value;
  var button1=document.forms.main_form.b1;
  var button_select=false;
  var x=false;
  for (var i = 0; i<button1.length; i++)
  {
    if(button1[i].checked==true)
    {
      button_select=true;
      break;

    }

  }
  if ((control1!='')&&(control2!='')&&(descr!='')&&(control3!='')&&(selector1!='0')&&(button_select==true))
  {
    x=true;
  }
  else
  {
    x=false;
    alert('Ты не все необходимые поля заполнил, чел');
  }
  return x;

}

//для работы в IE
document.getElementsByClassName("main_form").attachEvent('onsubmit',func_input);
