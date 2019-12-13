using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class ObjectAxis : Entity
    {
        private Tank _tank;
        private AABB _boxline;
        private float _placementX;
        private float _placementY;



        public ObjectAxis(float x, float y) : base(x, y)
        {
            _tank = new Tank(0, 0);
            _boxline = new AABB(10, 10);

            AddChild(_tank);

            _placementX = X;
            _placementY = Y;

            OnUpdate += TankAxis;
            OnUpdate += Rotateright;
            OnUpdate += Rotateleft;
            OnUpdate += Collision;
            OnUpdate += Placement;
        }

        public void TankAxis(float deltatime)
        {

            _tank.Y = 0;
            X = _tank.XAbsolute;
            Y = _tank.YAbsolute;
        }

        public void Placement(float deltatime)
        {
            _placementX = X;
            _placementY = Y;
        }

        public void Collision(float deltatime)
        {
            if (_tank.GetAABB.DetectCollision(Program.box) == true)
            {
                X = _placementX;
                Y = _placementY;
            }

        }

        public void Rotateleft(float deltatime)
        {
            //Rotates the Tank to the left
            if (Input.IsKeyDown(65))
            {

                Rotate(-1f * deltatime);
            }
        }


        public void Rotateright(float deltatime)
        {
            //Rotates the Tank to the right
            if (Input.IsKeyDown(68))
            {

                Rotate(1f * deltatime);
            }
        }


    }
}
