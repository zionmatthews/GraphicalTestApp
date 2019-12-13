using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Turret : Actor
    {
        private Sprite _turret;
        private Bullet _bullet;


        public Turret(float x, float y)
        {
            _turret = new Sprite("barrelBlue.png");
            _bullet = new Bullet(0, 0);

            _turret.X = -8.0f;
            _turret.Y = -45;

            X = 0;
            Y = 0;

            AddChild(_turret);



            OnUpdate += Rotateleft;
            OnUpdate += Rotateright;
            OnUpdate += Fire;
            OnUpdate += BulletCollision;
        }

        public void Rotateleft(float deltatime)
        {
            //Rotates the Turrent to the left (Q)
            if (Input.IsKeyDown(81))
            {

                Rotate(-1f * deltatime);
            }
        }


        public void Rotateright(float deltatime)
        {
            //Rotates the Turrent to the right (E)
            if (Input.IsKeyDown(69))
            {

                Rotate(1f * deltatime);
            }
        }

        //A failed feature rip :(
        public void BulletCollision(float deltatime)
        {
            if (_bullet.GetAABB.DetectCollision(Program.box) == true)
            {
                RemoveChild(_bullet);
            }
        }

        public void Fire(float deltatime)
        {
            //Shoots the turret (Space Bar)
            if (Input.IsKeyDown(32))
            {
                Bullet Turretbullet = new Bullet(XAbsolute, YAbsolute);
                Vector3 direction = GetDirectionAbsolute();
                direction.Normalize();
                direction *= 30;
                Turretbullet.X = XAbsolute + direction.x * -2;
                Turretbullet.Y = YAbsolute + direction.y * -2;
                Turretbullet.XVelocity = direction.x * -8.0f;
                Turretbullet.YVelocity = direction.y * -45;
                Parent.Parent.Parent.AddChild(Turretbullet);
            }
        }


    }
}
