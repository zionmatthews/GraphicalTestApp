using System;
using Raylib;
using RL = Raylib.Raylib;

namespace GraphicalTestApp
{
    class Game
    {
        //The tilesize of the game
        public static readonly Vector2 UnitSize = new Vector2(16, 16);
        //The current root Actor
        private Actor _root = null;
        //The next root Actor
        private Actor _next = null;
        //The Timer for the entire Game
        private Timer _gameTimer;
        //The camera for the game
        Camera2D _camera = new Camera2D();

        //Creates a Game and new Scene instance as its active Scene
        public Game(int width, int height, string title)
        {
            RL.InitWindow(width, height, title);
            RL.SetTargetFPS(0);

            _gameTimer = new Timer();
        }
        
        //Run the game loop
        public void Run()
        {
            //Update, draw, and get input until the game is over
            while (!RL.WindowShouldClose())
            {
                //Change the Scene if needed
                if (_root != _next)
                {
                    _root = _next;
                }

                //Update the active Scene
                _root.Update(_gameTimer.GetDeltaTime());

                //Start the Scene if needed
                if (!_root.Started)
                {
                    _root.Start();
                }

                //Draw the active Scene
                RL.BeginDrawing();
                RL.BeginMode2D(_camera);
                _root.Draw();
                RL.EndMode2D();
                RL.EndDrawing();
            }

            RL.CloseWindow();
        }

        //The Scene we are currently running
        public Actor Root
        {
            get { return _root; }
            set
            {
                if (_root != null) _next = value;
                else _root = value;
            }
        }

        //The zoom level of the camera
        public float Zoom
        {
            get { return _camera.zoom; }
            set { _camera.zoom = value; }
        }
    }
}
