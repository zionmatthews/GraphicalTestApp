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
        private int _num;       

        public Bullet(float x, float y, int num) : base(x, y)
        {
            _bullet = new Sprite("Bullet-Transparent-Background.png");
            _box = new AABB(25, 25);
            _num = num;


            AddChild(_bullet);
            AddChild(_box);

            //OnUpdate += Detection;
        }

        public void Detection(float deltime)
        {
            if (_num == 1 && _box.DetectCollision(ObjectAxis.hitbox.ElementAt(0)))
            {
                Parent.RemoveChild(this);
            }
            else if (_num == 0 && _box.DetectCollision(ObjectAxis.hitbox.ElementAt(1)))
            {
                Parent.RemoveChild(this);
            }
        }
      

       


    }
}
