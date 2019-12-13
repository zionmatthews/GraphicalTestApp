using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Program
    {
        public static AABB box = new AABB(80, 20);
        static void Main(string[] args)
        {
            //Title of program
            Game game = new Game(1280, 760, "Welcome To Tank Tester II");

            //Accesses the Actor class
            Actor root = new Actor();
            game.Root = root;




            //## Set up game here ##//

            //Accesses the ObjectAxis class
            ObjectAxis user = new ObjectAxis(640, 380);

            //Box size
            box.X = 650;
            box.Y = 200;

            //Assigns variable to Child
            root.AddChild(user);
            root.AddChild(box);

            game.Run();
        }
    }
}
