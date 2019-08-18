using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarden
{
    public class Flower
    {
        public string Color;

        public void Water()
        {

        }
    }
    public class Vegetable
    {
        public bool Yummy;
    }
    public class Daisy : Flower
    {
        public double Height;
    }
    public class Sunflower : Flower
    {
        public bool Harvested;
    }
    public class Tomato : Vegetable
    {
        public double StakeHeight;
    }
    public class Carrot : Vegetable
    {
        public double Depth;
    }
}
