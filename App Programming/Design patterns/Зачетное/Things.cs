using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Зачетное
{
    public interface IsMovable
    {
        void Move(int x, int y, int rx, int ry);
        bool Touch(float mx, float my);
    }
    public abstract class Things: IsMovable, IPrototype
    {
        // List<Point> points = new List<Point>();


        public bool active;
        public int x0, y0;
        public int w, h;
        public Color color;

        public abstract IPrototype clone();
        
        virtual public void Draw(Graphics g){}
        abstract public bool Touch(float mx, float my);
        abstract public void Move(int x, int y, int rx, int ry);
        virtual public void SelectedDraw(Graphics g) { }
        virtual public void editor_change()
        {
            
        }
        public virtual IMemento Save() { return null; }
        public virtual void Load(IMemento input) {}
        //проверка нахождения курсора внутри фигуры

        virtual public void Change()
        {
            
            if (active)
            
                color = Color.FromArgb(100, color);
            
            else
            
                color = Color.FromArgb(255, color);
            active = !active;
        }
        
    }
}
