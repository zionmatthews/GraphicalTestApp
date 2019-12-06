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
        private Turret _turret;


        public Tank(float x, float y, string path) : base(x, y)
        {
            _tank = new Sprite(path);
            _outline = new AABB(20, 20);
            _turret = new Turret(0, 0);

            AddChild(_tank);
            AddChild(_outline);
            AddChild(_turret);

            OnUpdate += Movement;
            OnUpdate += Rotateleft;
            OnUpdate += Rotateright;

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

        public void Movement(float deltatime)
        {
            //Moves up (w)
            if (Input.IsKeyDown(83))
            {
                YVelocity = 150;
            }
            //Moves Down (s)
            else if (Input.IsKeyDown(87))
            {
                YVelocity = -80;
            }
            else
            {
                YVelocity = 0;
            }
        }

        public void Rotateleft(float deltatime)
        {
            //Rotates the object to the right
            if (Input.IsKeyDown(81))
            {

                Rotate(-1f * deltatime);
            }
        }


        public void Rotateright(float deltatime)
        {
            //Rotates the object to the right
            if (Input.IsKeyDown(69))
            {

                Rotate(1f * deltatime);
            }
        }







    }
}
