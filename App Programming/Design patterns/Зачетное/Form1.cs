using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.ObjectModel;

namespace Зачетное
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            select_strategy = new SelectStrategy(All_Things, selectedItem_Decorator);
            editorWindow_strategy = new EditorWindowStrategy(All_Things,editor_openned,selectedItem_Decorator,this,editor);
        }

        void change_selectedItem(Things item)
        {
            selectedItem_Decorator.setThing(item);
            selected = true;
        }

        private void checkRects_Change(object sender, EventArgs e)
        {
            if (isCopying) return;

            CheckBox temp_CheckBox = (CheckBox)sender;
            int t=0;

            for (int i = 0; i < checkRects.Count(); i++)
            {
                if (temp_CheckBox==checkRects[i])
                {
                    t = i;
                }
            }

            int iter = -1;
            for (int j = 0; j < All_Things.Count; j++)
            {
                if (All_Things[j] is Rect) iter++;
                if (iter == t)
                {
                    iter = j;
                    break;
                }
                
                
            }
            if (selectedItem_Decorator.isEqual(All_Things[iter])) selected = false;
            if (editor_openned && editor.thing ==All_Things[iter])
            {
                All_Things[iter].Change();
                editor.ChangeThing(All_Things[iter]);
            }
            else
            All_Things[iter].Change();
            Refresh();
        }


        private void checkEllipses_Change(object sender, EventArgs e)
        {
            if (isCopying) return;
            CheckBox temp_CheckBox = (CheckBox)sender;
            int t = 0;

            for (int i = 0; i < checkEllipses.Count(); i++)
            {
                if (temp_CheckBox == checkEllipses[i])
                {
                    t = i;
                    break;
                }
            }

            int iter = -1;
            for (int j = 0; j < All_Things.Count; j++)
            {
                if (All_Things[j] is Elips) iter++;

                if (iter == t)
                {
                    iter = j;
                    break;
                }
                
                
            }

            if (selectedItem_Decorator.isEqual(All_Things[iter])) selected = false;
            if (editor_openned && editor.thing == All_Things[iter])
            {
                All_Things[iter].Change();
                editor.ChangeThing(All_Things[iter]);
            }
            else
                All_Things[iter].Change();
            Refresh();

        }

        private void checkTracktors_Change(object sender, EventArgs e)
        {
            if (isCopying) return;
            CheckBox temp_CheckBox = (CheckBox)sender;
            int t = 0;

            for (int i = 0; i < checkTracktors.Count(); i++)
            {
                if (temp_CheckBox == checkTracktors[i])
                {
                    t = i;
                }
            }

            int iter = -1;
            for (int j = 0; j < All_Things.Count; j++)
            {
                if (All_Things[j] is Tracks) iter++;
                if (iter == t)
                {
                    iter = j;
                    break;
                }
                
                
            }
            if (selectedItem_Decorator.isEqual(All_Things[iter])) selected = false;
            if (editor_openned && editor.thing == All_Things[iter])
            {
                All_Things[iter].Change();
                editor.ChangeThing(All_Things[iter]);
            }
            else
                All_Things[iter].Change();
            Refresh();

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(Color.White);
           // if ((All_Things.Count > 0) && (selected)) selected_item.SelectedDraw(e.Graphics);
            foreach (var item in All_Things)
            {

                if (selected && selectedItem_Decorator.isEqual(item))
                    item.SelectedDraw(e.Graphics);
                else
                    item.Draw(e.Graphics);
            }




            Tracks tr = new Tracks(20, 92, 20,10, Color.Black);
            tr.Draw(e.Graphics);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), 20, 12, 20, 20);
            e.Graphics.FillEllipse(new SolidBrush(Color.Black), 20, 52, 20, 20);
        }
        List<CheckBox> checkRects = new List<CheckBox>();
        List<CheckBox> checkEllipses = new List<CheckBox>();
        List<CheckBox> checkTracktors = new List<CheckBox>();
        List<Things> All_Things = new List<Things>();

        Random rnd = new Random();
        RectCreator rectCreator = new RectCreator();
        ElipsCreator elipsCreator = new ElipsCreator();
        TrackCreator trackCreator = new TrackCreator();
        private void domainRect_SelectedItemChanged(object sender, EventArgs e)
        {
            if (isCopying) return;
            if (GOdomain)
            {
                if (checkRects.Count() < Convert.ToInt32(domainRect.Text))
                {
                    CheckBox time_CheckBox = new CheckBox();
                    time_CheckBox.Checked = true;
                    time_CheckBox.CheckedChanged += new EventHandler(checkRects_Change);
                    time_CheckBox.Size = new Size(20, 20);
                    time_CheckBox.Location = new Point(110 + 20 * Convert.ToInt32(domainRect.Text), 12);
                    Controls.Add(time_CheckBox);
                    checkRects.Add(time_CheckBox);

                    Things r = rectCreator.FactoryMethod(rnd.Next(50, Width - 100), rnd.Next(50, Height - 100),
                        rnd.Next(50, 100), rnd.Next(50, 100), Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255),
                        rnd.Next(0, 255)));

                    //Rect r = new Rect(rnd.Next(50, Width - 100), rnd.Next(50, Height - 100), rnd.Next(50, 100), rnd.Next(50, 100), Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)));
                    All_Things.Add(r);


                    change_selectedItem(r);
                    
                    Refresh();
                }
                else
                {
                    Controls.Remove(checkRects[checkRects.Count() - 1]);
                    checkRects.RemoveAt(checkRects.Count() - 1);
                    int i = All_Things.Count() - 1;
                    while (i >= 0)
                    {
                        if (All_Things[i] is Rect)
                        {
                            if (selectedItem_Decorator.isEqual(All_Things[i])) selected = false;
                            All_Things.RemoveAt(i);
                            break;

                        }
                        else
                            i--;
                    }

                    Refresh();
                }
            }
            
        }
        private void domainEllipse_SelectedItemChanged(object sender, EventArgs e)
        {
            if (isCopying) return;
            if (GOdomain)
            {
                if (checkEllipses.Count() < Convert.ToInt32(domainEllipse.Text))
                {
                    CheckBox time_CheckBox = new CheckBox();
                    time_CheckBox.Checked = true;
                    time_CheckBox.CheckedChanged += new EventHandler(checkEllipses_Change);
                    time_CheckBox.Size = new Size(20, 20);
                    time_CheckBox.Location = new Point(110 + 20 * Convert.ToInt32(domainEllipse.Text), 52);
                    Controls.Add(time_CheckBox);
                    checkEllipses.Add(time_CheckBox);

                    Things el = elipsCreator.FactoryMethod(rnd.Next(50, Width - 100),
                        rnd.Next(50, Height - 100), rnd.Next(50, 100), rnd.Next(50, 100),
                        Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)));
                    //Elips el = new Elips(rnd.Next(50, Width - 100), rnd.Next(50, Height - 100), rnd.Next(50, 100), rnd.Next(50, 100), Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)));
                    All_Things.Add(el);
                    change_selectedItem(el);
                    Refresh();
                }
                else
                {
                    Controls.Remove(checkEllipses[checkEllipses.Count() - 1]);
                    checkEllipses.RemoveAt(checkEllipses.Count() - 1);
                    int i = All_Things.Count() - 1;
                    while (i >= 0)
                    {
                        if (All_Things[i] is Elips)
                        {
                            if (selectedItem_Decorator.isEqual(All_Things[i])) selected = false;
                            All_Things.RemoveAt(i);
                            break;

                        }
                        else
                            i--;
                    }
                    Refresh();
                }
            }
        }   

        private void domainTracktor_SelectedItemChanged(object sender, EventArgs e)
        {
            if (isCopying) return;
            if (GOdomain)
            {
                if (checkTracktors.Count() < Convert.ToInt32(domainTracktor.Text))
                {
                    CheckBox time_CheckBox = new CheckBox();
                    time_CheckBox.Checked = true;
                    time_CheckBox.CheckedChanged += new EventHandler(checkTracktors_Change);
                    time_CheckBox.Size = new Size(20, 20);
                    time_CheckBox.Location = new Point(110 + 20 * Convert.ToInt32(domainTracktor.Text), 92);
                    Controls.Add(time_CheckBox);
                    checkTracktors.Add(time_CheckBox);

                    Things tr = trackCreator.FactoryMethod(rnd.Next(50, Width - 100),
                        rnd.Next(50, Height - 100), rnd.Next(50, 100), rnd.Next(10, 50),
                        Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)));
                    //Tracks tr = new Tracks(rnd.Next(50, Width - 100), rnd.Next(50, Height - 100), rnd.Next(50, 100), rnd.Next(10, 50), Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)));
                    All_Things.Add(tr);
                    change_selectedItem(tr);
                    Refresh();
                }
                else
                {
                    Controls.Remove(checkTracktors[checkTracktors.Count() - 1]);
                    checkTracktors.RemoveAt(checkTracktors.Count() - 1);
                    int i = All_Things.Count() - 1;
                    while (i >= 0)
                    {
                        if (All_Things[i] is Tracks)
                        {
                            if (selectedItem_Decorator.isEqual(All_Things[i])) selected = false;
                            All_Things.RemoveAt(i);
                            break;

                        }
                        else
                            i--;
                    }
                    Refresh();
                }
            }

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void button_Load_Click(object sender, EventArgs e)
        {

            foreach (var item in checkTracktors)
                Controls.Remove(item);
            foreach (var item in checkRects)
                Controls.Remove(item);
            foreach (var item in checkEllipses)
                Controls.Remove(item);
            checkTracktors.Clear();
            checkRects.Clear();
            checkEllipses.Clear();
            All_Things.Clear();

            stateSaver = new Saver(All_Things);
            stateSaver.Load();
            All_Things = stateSaver.return_load();


            
            int i_rects = 1;
            int i_el = 1;
            int i_track = 1;
            foreach (Things s in All_Things)
            {

                if (s is Rect)
                {

                    CheckBox time_CheckBox = new CheckBox();
                    if (!s.active)
                    {
                        time_CheckBox.Checked = false;

                    }
                    else
                        time_CheckBox.Checked = true;
                    time_CheckBox.CheckedChanged += new EventHandler(checkRects_Change);
                    time_CheckBox.Size = new Size(20, 20);
                    time_CheckBox.Location = new Point(110 + 20 * i_rects, 12);
                    i_rects++;
                    Controls.Add(time_CheckBox);
                    checkRects.Add(time_CheckBox);

                   
                    
                }
                if (s is Elips)
                {

                    CheckBox time_CheckBox = new CheckBox();
                    if (!s.active)
                    {
                        time_CheckBox.Checked = false;

                    }
                    else
                        time_CheckBox.Checked = true;
                    time_CheckBox.CheckedChanged += new EventHandler(checkEllipses_Change);
                    time_CheckBox.Size = new Size(20, 20);
                    time_CheckBox.Location = new Point(110 + 20 * i_el, 52);
                    i_el++;
                    Controls.Add(time_CheckBox);
                    checkEllipses.Add(time_CheckBox);

                }
                if (s is Tracks)
                {

                    CheckBox time_CheckBox = new CheckBox();
                    if (!s.active)
                    {
                        time_CheckBox.Checked = false;

                    }
                    else
                        time_CheckBox.Checked = true;

                    time_CheckBox.CheckedChanged += new EventHandler(checkTracktors_Change);
                    time_CheckBox.Size = new Size(20, 20);
                    time_CheckBox.Location = new Point(110 + 20 * i_track, 92);
                    i_track++;
                    Controls.Add(time_CheckBox);
                    checkTracktors.Add(time_CheckBox);
                }



            }
            GOdomain = false;
            domainRect.Text = Convert.ToString(i_rects-1);
            domainEllipse.Text = Convert.ToString(i_el-1);
            domainTracktor.Text = Convert.ToString(i_track-1);
            GOdomain = true;
            Refresh();
        }
        bool GOdomain=true;
        private void button_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("фыжзвщшоРВАГПШямдпгмвляоадмшмпгдаав \n пваптывадпягипавялоитыЮЛатыювдлатювыаы \n mfdknlbjzgdfjhvbfzgdlx.!.!.!");
           

        }

        double rx, ry;
        public Point coords;

        Decorator selectedItem_Decorator = new Decorator(null);
        Things selected_item;
        bool selected = false;
        public bool editor_openned = false;
        Form_editor editor;
        SelectStrategy select_strategy;
        EditorWindowStrategy editorWindow_strategy;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //select_strategy = new SelectStrategy(All_Things, selectedItem_Decorator);
            select_strategy.selected = selected;
            select_strategy.MouseDown(e);
            selected = select_strategy.selected;

            editorWindow_strategy.selected = selected;
            editorWindow_strategy.editor_openned = editor_openned;
            editorWindow_strategy.MouseDown(e);
            selected = editorWindow_strategy.selected;
            editor_openned = editorWindow_strategy.editor_openned;
            Refresh();

        }

        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            isCopying = false;

            select_strategy.selected = selected;
            select_strategy.MouseMove(e);
            
            Refresh();
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (All_Things.Count()!=0 && (!IsEqual()))
            {
                DialogResult result = MessageBox.Show(
                "Хотите сохранить изменения?",
                "Сообщение",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
        );

                if (result == DialogResult.Yes)
                    Save();
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            
           
                
        }
        private bool IsEqual()
        {
            StreamWriter compare_file = new StreamWriter("compare.txt");
            
            
            foreach (var item in All_Things)
            {
                string compare_line = "";
                if (item is Rect)
                {
                    compare_line += "Rect ";

                }
                else if (item is Elips)
                {
                    compare_line += "Elips ";
                }
                else
                {
                    compare_line += "Tracks ";
                }//чё-то сделать с тем, что цвет ТРАКТОРА и цвет КОРПУСА - разыне вещи, или забить вообще.......
                compare_line += Convert.ToString(item.x0) + " " + Convert.ToString(item.y0) + " " + Convert.ToString(item.w) + " " + Convert.ToString(item.h) + " " + item.color.ToArgb().ToString() + " " + Convert.ToString(item.active) + " ";
                if (item is Tracks)
                {
                    Tracks itemt = (Tracks)item;
                    compare_line += itemt.c_big.color.ToArgb().ToString() + " " + itemt.c_small.color.ToArgb().ToString() + " " + itemt.wheel_left.color.ToArgb().ToString() + " " + itemt.wheel_right.color.ToArgb().ToString();
                }
                compare_file.WriteLine(compare_line);
            }
            compare_file.Close();

            string[] lines_saves = File.ReadAllLines("saves.txt");
            string[] lines_compare = File.ReadAllLines("compare.txt");
            if (lines_compare.Length != lines_saves.Length)
                return false;
            for (int i = 0; i < lines_compare.Length; i++)
            {
                if (lines_saves[i] != lines_compare[i])
                    return false;
            }
            return true;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //проверка, копируется ли сейчас selected_item
        bool isCopying = false;
        private void buttonObjectCopy_Click(object sender, EventArgs e)
        {
            if (GOdomain && selected)
            {
                    isCopying = true;
                    IPrototype r = selectedItem_Decorator.clone();
                    Things r2 = null;
                    CheckBox time_CheckBox = new CheckBox();
                    time_CheckBox.Checked = true;
                   
                    time_CheckBox.Size = new Size(20, 20);

                   
                    
                    

                    if (r is Rect)
                    {
                        r2 = (Rect)r;
                        domainRect.Text = (Convert.ToInt32(domainRect.Text) + 1).ToString();
                        time_CheckBox.CheckedChanged += new EventHandler(checkRects_Change);
                        time_CheckBox.Location = new Point(110 + 20 * Convert.ToInt32(domainRect.Text), 12);
                        checkRects.Add(time_CheckBox);

                    }
                    else if (r is Tracks)
                    {
                        r2 = (Tracks)r;
                        domainTracktor.Text = (Convert.ToInt32(domainTracktor.Text) + 1).ToString();
                        time_CheckBox.CheckedChanged += new EventHandler(checkTracktors_Change);
                        time_CheckBox.Location = new Point(110 + 20 * Convert.ToInt32(domainTracktor.Text), 92);
                        checkTracktors.Add(time_CheckBox);
                    }
                    else if (r is Elips)
                    {
                        r2 = (Elips)r;
                        domainEllipse.Text = (Convert.ToInt32(domainEllipse.Text) + 1).ToString();
                        time_CheckBox.CheckedChanged += new EventHandler(checkEllipses_Change);
                        time_CheckBox.Location = new Point(110 + 20 * Convert.ToInt32(domainEllipse.Text), 52);
                        checkEllipses.Add(time_CheckBox);
                    }
                    Controls.Add(time_CheckBox);
                    All_Things.Add(r2);
                    change_selectedItem(r2);
                    Refresh();
            }
        }
        Saver stateSaver;
        private void Save()
        {
            stateSaver = new Saver(All_Things);
            stateSaver.Save();
        }
    }
}
