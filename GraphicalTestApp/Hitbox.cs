using System;
using Raylib;
using RL = Raylib.Raylib;

namespace GraphicalTestApp
{
    class Hitbox : Actor
    {
        public float Width { get; set; } = 1;
        public float Height { get; set; } = 1;

        public float Top
        {
            //## Implement Top ##//
            get { return 0; }
        }

        public float Bottom
        {
            //## Implement Bottom ##//
            get { return 0; }
        }

        public float Left
        {
            //## Implement Left ##//
            get { return 0; }
        }

        public float Right
        {
            //## Implement Right ##//
            get { return 0; }
        }

        //Default constructor
        public Hitbox()
        {

        }

        //Returns whether this Hitbox and another are colliding
        public bool GetCollision(Hitbox other)
        {
            if (Left < other.Right && Right > other.Left &&
                Top < other.Bottom && Bottom > other.Top)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Returns whether this Hitbox and a Vector3 are colliding
        public bool GetCollision(Vector3 point)
        {
            if (Left < point.x && Right > point.x &&
                Top < point.y && Bottom > point.y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Render()
        {
            RL.DrawRectangleLines((int)XAbsolute, (int)YAbsolute, (int)Width, (int)Height, Color.RED);
        }
    }
}
