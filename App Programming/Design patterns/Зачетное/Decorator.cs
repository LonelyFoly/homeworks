using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зачетное
{
    public class Decorator: Things
    {
        private Things thing;
        public Decorator(Things thing)
        {
            this.thing = thing; 
        }

        public bool isEqual (Things other_thing)
        {
            return thing == other_thing;
        }
        public void setThing(Things thing)
        {
            this.thing = thing;
        }
        public int[] return_coords()
        {
            return (new int[2] { thing.x0, thing.y0 });
        }
        public override bool Touch(float mx, float my)
        {
            if (thing is Rect)
            {
                return ((Rect)thing).Touch(mx,my);
            }
            else if (thing is Elips)
            {
                return ((Elips)thing).Touch(mx, my);
            }
            else if (thing is Tracks)
            {
                return ((Tracks)thing).Touch(mx, my);
            }

            throw new ArgumentNullException(paramName: nameof(thing), message: "Wrong touchable type");
        }
        public override void Move(int x, int y, int rx, int ry)
        {
            if (thing is Rect)
            {
                ((Rect)thing).Move(x, y, rx,ry);
            }
            else if (thing is Elips)
            {
                ((Elips)thing).Move(x, y, rx, ry);
            }
            else if (thing is Tracks)
            {
                ((Tracks)thing).Move(x, y, rx, ry);
            }
            else
                throw new ArgumentNullException(paramName: nameof(thing), message: "Wrong movable type");
            return;
        }
        public override IPrototype clone()
        {
            if (thing is Rect)
            {
                return ((Rect)thing).clone();
            }
            else if (thing is Tracks)
            {
                return ((Tracks)thing).clone();
            }
            else if (thing is Elips)
            {
                return ((Elips)thing).clone();
            }

            return null;
        }
    }
}
