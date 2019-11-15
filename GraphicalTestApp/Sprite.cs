using System;
using Raylib;
using RL = Raylib.Raylib;

namespace GraphicalTestApp
{
    class Sprite : Actor
    {
        private Texture2D _texture = new Texture2D();
        private Image _image = new Image();

        //The width of the Sprite
        public float Width
        {
            get { return _texture.width; }
        }
        //The height of the Sprite
        public float Height
        {
            get { return _texture.height; }
        }

        //Default constructor
        public Sprite()
        {
            OnDraw += Render;
        }

        //Loads an image from the specified path
        public void Load(string path)
        {
            _image = RL.LoadImage(path);
            _texture = RL.LoadTextureFromImage(_image);
        }

        //Draw the Sprite to the screen
        private void Render()
        {
            RL.DrawTextureEx(
                _texture,
                new Vector2(XAbsolute - Width / 2, YAbsolute - Height / 2), GetRotation(),
                GetScale(),
                Color.WHITE);
        }
    }
}
