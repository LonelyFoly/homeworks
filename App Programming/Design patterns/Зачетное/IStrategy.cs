using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зачетное
{
    public abstract class Strategy
    {
        protected List<Things> collection;
        protected Decorator selectedItem_Decorator;

        public virtual void MouseDown(MouseEventArgs e) { }
        public virtual void MouseMove(MouseEventArgs e) { }
    }

    public class SelectStrategy: Strategy
    {
        int rx, ry;
        public bool selected;
        public SelectStrategy(List<Things> collection, Decorator selectedItem_Decorator)
        {
            this.collection = collection;
            this.selectedItem_Decorator = selectedItem_Decorator;

        }
        public override void MouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bool touch_check = false;
                foreach (var item in collection)
                {
                    if ((item.Touch(e.X, e.Y)) && (item.active))
                    {
                        selectedItem_Decorator.setThing(item);
                        selected = true;
                        rx = e.X - selectedItem_Decorator.return_coords()[0];
                        ry = e.Y - selectedItem_Decorator.return_coords()[1];
                        touch_check = true;
                        
                        break;
                    }
                }
                if (!touch_check) selected = false;


            }
            
        }
        public override void MouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (selected)
                {
                    selectedItem_Decorator.Move(e.X, e.Y, (int)rx, (int)ry);
                    //selected_item.Move(e.X, e.Y, (int)rx, (int)ry);
                }
            }
        }
    }
    public class EditorWindowStrategy : Strategy
    {
        public bool selected;
        public bool editor_openned;
        Form1 form;
        Form_editor editor;
        public EditorWindowStrategy(List<Things> collection, bool editor_openned, Decorator selectedItem_Decorator, Form1 form, Form_editor editor)
        {
            this.editor_openned = editor_openned;
            this.selectedItem_Decorator = selectedItem_Decorator;
            this.form = form;
            this.editor = editor;
            this.collection = collection;
        }
        public void MouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (var item in collection)
                {

                    if ((item.Touch(e.X, e.Y)) && (item.active))
                    {
                        if (!editor_openned)
                        {
                            editor = new Form_editor(form);
                            editor_openned = true;
                            editor.oldValue_w = item.w;
                            editor.oldValue_h = item.h;
                            editor.Show();
                        }
                        editor.ChangeThing(item);
                        selectedItem_Decorator.setThing(item);
                        selected = true;

                        break;
                    }

                }
            }
        }
    }
    public class EditdorWindowsStrategy : Strategy
    {
        public void MouseDown(MouseEventArgs e)
        {

        }
        public void MouseMove(MouseEventArgs e)
        {

        }
    }
}
