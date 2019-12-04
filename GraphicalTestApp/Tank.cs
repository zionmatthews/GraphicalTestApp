using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Tank : Entity
    {
        private AABB _outline;
        private Sprite _tank;


        public Tank(float x, float y, string path) : base(x, y)
        {
            _tank = new Sprite(path);
            _outline = new AABB(20, 20);


            AddChild(_tank);
            AddChild(_outline);

        }

        public Tank() : this(640, 380, "tankBlue_outline.png")
        {

        }

        public Tank(string path) : this(640, 380, path)
        {


        }

        public Tank(float x, float y) : this(x, y, "tankBlue_outline.png")
        {

        }

        public void  Movement()
        {

        }


    }
}
