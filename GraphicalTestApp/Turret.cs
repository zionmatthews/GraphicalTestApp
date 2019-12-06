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
        }

        public void Rotateleft(float deltatime)
        {
            //Rotates the Turrent to the left (q)
            if (Input.IsKeyDown(81))
            {

                Rotate(-1f * deltatime);
            }
        }


        public void Rotateright(float deltatime)
        {
            //Rotates the Turrent to the right (e)
            if (Input.IsKeyDown(69))
            {

                Rotate(1f * deltatime);
            }
        }

     
    }
}
