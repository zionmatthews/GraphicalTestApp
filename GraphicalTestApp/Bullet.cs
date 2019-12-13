using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Bullet : Entity
    {
        private Sprite _bullet;
        private AABB _box;


        public Bullet(float x, float y) : base(x, y)
        {
            _bullet = new Sprite("Bullet-Transparent-Background.png");
            _box = new AABB(25, 25);



            AddChild(_bullet);
            AddChild(_box);


        }

        public AABB GetAABB
        {
            get
            {
                return _box;
            }
        }







    }
}
