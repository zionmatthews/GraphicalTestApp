using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title of program
            Game game = new Game(1280, 760, "Welcome To Tank Tester II");

            //Accesses the Actor class
            Actor root = new Actor();
            game.Root = root;




            //## Set up game here ##//

            //Accesses the tank class
            Tank user = new Tank(640, 380);

            //Accesses the Sprite class
            Sprite guest = new Sprite();

            //Assigns variable to Child 
            root.AddChild(user);

            game.Run();
        }
    }
}
