using System;

namespace GraphicalTestApp
{
    class Entity : Actor
    {
        private Vector3 _velocity = new Vector3();
        private Vector3 _acceleration = new Vector3();

        public char Icon { get; set; } = ' ';

        public Sprite Image { get; set; }

        public float XVelocity
        {
            //## Implement velocity on the X axis ##//        Fin
            get { return _velocity.x; }
            set { _velocity.x = value; }
        }
        public float XAcceleration
        {
            //## Implement acceleration on the X axis ##//    Fin
            get { return _acceleration.x; }
            set { _acceleration.x = value; }
        }
        public float YVelocity
        {
            //## Implement velocity on the Y axis ##//   Fin
            get { return _velocity.y;  }
            set { _velocity.y = value; }
        }
        public float YAcceleration
        {
            //## Implement acceleration on the Y axis ##//     Fin
            get { return _acceleration.y; }
            set { _acceleration.y = value; }
        }

        //Creates an Entity at the specified coordinates
        public Entity(float x, float y)
        {
            X = x;
            Y = y;
        }

        //Creates an Entity with the specified icon and default values
        public Entity(char icon)
        {
            Icon = icon;
        }

        //Creates an entity with the specified icon and image
        public Entity(char icon, string imageName) : this(icon)
        {
            Image = new Sprite();
            Sprite.Load(imageName);
            AddChild(Image);
        }

        public override void Update(float deltaTime)
        {
            //## Calculate velocity from acceleration ##//

            X += _velocity.x * deltaTime;
            Y += _velocity.y * deltaTime;
            //## Calculate position from velocity ##//
            base.Update(deltaTime);
        }
    }
}
