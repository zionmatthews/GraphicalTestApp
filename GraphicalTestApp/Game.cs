using System;
using Raylib;
using RL = Raylib.Raylib;

namespace GraphicalTestApp
{
    class Game
    {
        //The tilesize of the game
        public static readonly Vector2 UnitSize = new Vector2(16, 16);
        //The Scene we are currently running
        private static Scene _currentScene = null;
        //The Scene we are about to go to
        private static Scene _nextScene = null;
        //The Timer for the entire Game
        private Timer _gameTimer;

        //Creates a Game and new Scene instance as its active Scene
        public Game(int width, int height, string title)
        {
            RL.InitWindow(width, height, title);
            RL.SetTargetFPS(0);

            _gameTimer = new Timer();
        }

        //The Scene we are currently running
        public static Scene CurrentScene
        {
            set
            {
                _nextScene = value;
            }
            get
            {
                return _currentScene;
            }
        }
        
        //Run the game loop
        public void Run()
        {
            Camera2D camera = new Camera2D();

            // ## Adjust zoom level here ## //
            camera.zoom = 4;

            //Update, draw, and get input until the game is over
            while (!RL.WindowShouldClose())
            {
                //Change the Scene if needed
                if (_currentScene != _nextScene)
                {
                    _currentScene = _nextScene;
                }

                //Update the active Scene
                _currentScene.Update(_gameTimer.GetDeltaTime());

                //Start the Scene if needed
                if (!_currentScene.Started)
                {
                    _currentScene.Start();
                }

                //Draw the active Scene
                RL.BeginDrawing();
                RL.BeginMode2D(camera);
                _currentScene.Draw();
                RL.EndMode2D();
                RL.EndDrawing();
            }

            RL.CloseWindow();
        }
    }
}
