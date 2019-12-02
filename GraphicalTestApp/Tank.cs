using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Tank : Entity
    {
        private Input _input = new Input();
        private Entity _turrnet = new Entity('|');
        private static Tank _instance;


        public Tank(float x, float y) : base(x, y)
        {
            // _sprite = new Sprite("");
            // _hitbox = new AABB(Tank);
            // AddChild(_sprite);
            // AddChild(_hitbox);
            _instance = this;
        }

        public Tank() : this('=')
        {

        }

        public Tank(string imageName) : base('=', imageName)
        {
            //Bind movement methods to the arrow keys

        }

        public Tank(char icon) : base(icon)
        {

        }


    }
}
