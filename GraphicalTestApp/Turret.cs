﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Turret : Actor
    {
        private Sprite _turret;


        public Turret(float x, float y)
        {
            _turret = new Sprite("barrelBlue.png");


            _turret.X = -8.0f;
            _turret.Y = -45;

            X = 0;
            Y = 0;

            AddChild(_turret);



            OnUpdate += Rotateleft;
            OnUpdate += Rotateright;
            OnUpdate += Fire;
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

        public void Fire(float deltatime)
        {
            //Shoots the turret (Space Bar)
            if (Input.IsKeyDown(32))
            {
                Bullet _bullet = new Bullet(XAbsolute, YAbsolute);
                Vector3 direction = GetDirectionAbsolute();
                _bullet.Rotate(GetRotationAbsolute());
                _bullet.X += direction.x * -50f;
                _bullet.Y += direction.y * -50f;
                _bullet.XVelocity += direction.x * -300f;
                _bullet.YVelocity += direction.y * -300f;
                Parent.AddChild(_bullet);
            }
        }

        /* Bullet _bullet = new Bullet(XAbsolute, YAbsolute);
         Vector3 direction = GetDirectionAbsolute();
         direction.Normalize();
                 direction *= 50;
                 _bullet.XVelocity = direction.x;
                 _bullet.YVelocity = direction.y;
                 Parent.Parent.AddChild(_bullet); */


    }
}
