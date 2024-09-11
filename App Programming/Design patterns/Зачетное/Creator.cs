using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зачетное
{
    
    public abstract class FigureCreator
    {
        public abstract Things FactoryMethod(int x0_input, int y0_input, int w_input, int h_input, Color color_input);
        
    }
    public class RectCreator : FigureCreator
    {

        public override Things FactoryMethod(int x0_input, int y0_input, int w_input, int h_input, Color color_input)
        {
            return new Rect(x0_input, y0_input, w_input, h_input, color_input);
        }
    }

    public class ElipsCreator : FigureCreator
    {

        public override Things FactoryMethod(int x0_input, int y0_input, int w_input, int h_input, Color color_input)
        {
            return new Elips(x0_input, y0_input, w_input, h_input, color_input);
        }
    }
    public class TrackCreator : FigureCreator
    {

        public override Things FactoryMethod(int x0_input, int y0_input, int w_input, int h_input, Color color_input)
        {
            return new Tracks(x0_input, y0_input, w_input, h_input, color_input);
        }
    }
}
