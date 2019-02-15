using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public abstract void Draw();
    }
    public class Texts : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public override void Draw()
        {
            base.Draw();
        }

    }
}
