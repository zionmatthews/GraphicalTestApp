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

            //Accesses the ObjectAxis class
            ObjectAxis user = new ObjectAxis(640, 380, 0);



            //Assigns variable to Child
            root.AddChild(user);

            game.Run();
        }
    }
}
