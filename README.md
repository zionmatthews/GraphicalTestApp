# GraphicalTestApp

Zion Matthews
:---
s198031
Assessment 2
Tank Tester II

## I. Requirements

1. Description of Problem

     - **Name** : GraphicalTestApp 
     - **Problem Statement** : The creation of a game project that consists of using matracis and vectors to do 
     math, control object axis,etc.
     - **Problem Specifications** : the game must include: Vector classes for 3D vectors, Matrix classes for 
     3D matrices,including homogeneous 4D matrices, suitably commented to an industry standard, examples of 
     game objects moving using velocity and acceleration with vectors, and  examples of simple collision detection


2. Input Information

    - Use the (W) button to move foward
    - Use the (S) button to move backwards
    - Use the (A) button to turn the tank left
    - Use the (D) button to turn the tank right
    - Use the (Q) button to turn the turret left
    - Use the (E) button to turn the turret right
    - Use the (Space Bar) button to fire from the turret 

3. Output Information

    - A tank will be displayed to the user upon starting the program. Bullets should
    also apear when the fire button is pressed.

4. User Interface Infrormation

    - N/A

## II. Design

1. _System Architecture_

|
|:-----
Diagram(https://imgur.com/FPCK5WH)
|
|

3. ### Object Information

   **Class** AABB
           
           Description: The AABB class contains the roots for your players hitbox and/or any object in the game. This class also offers collision detection for your hitboxes.

           Variables: 
              Name: Width
              Description: Used to set the hitboxes width
              Type: float

              Name: Height
              Description: Used to set the hitboxes height
              Type: float

           Functions:
              public float Top: Returns the Y coordinate at the top of the box

              public float Bottom: Returns the Y coordinate at the top of the box

              public float Left: Returns the X coordinate at the top of the box

              public float Right: Returns the X coordinate at the top of the box

              public AABB(float width, float height): Creates an AABB(Hitbox) of the specifed size

              public bool DetectCollision(AABB other): Detects the bounding hitboxes Left, Right, Bottom, and Top

              public override void Draw(): Draws the bounding box to tthe screen
    
    **Class** Actor
            
            Description: The Actor class the roots for your players movement in game along with features such as Update and Parent.

            Variables:
               Name: Started
               Description: Used to flag the Actor as having already started
               Type: bool

               Name: Parent
               Description:  Used to mark any object as a parent of a child
               Type: class

               Name: _children
               Description: Used to add a child to parent
               Type: class

               Name: _additions
               Description: Adds child to collection
               Type: class

               Name: _removals
               Description: Removes child to collection
               Type: class

               Name: _localTransform
               Description: Used to get the players X and Y axis
               Type: class

               Name: _globalTransform
               Description: Used to get the worlds and/or all players X and Y axis
               Type class
            
            Functions:
                public float X: Sets the players X coordinate

                public float XAbsolute: Stes the players XAbsolute coordinate

                public float Y: Sets the players Y coordinate

                public float YAbsolute: Sets the players YAbsolute coordinate

                public float GetRotation: Gets rotation from the players axis

                public float GetRotationAbsolute: Gets rotation from the worlds axis

                public void Rotate: Creates Rotation

                public void SetRotation: Sets the rotation on an axis

                public void Scale: Implements scaling for the players axis

                public Vector3 GetDirection: Useful for getting a players direction

                public Vector3 GetDirection Absolute: Useful for getting the worlds direction

                public void AddChild(Actor child): Adds a child

                public void RemoveChild(Actor child): Removes a child

                public void UpdateTransform(): Updates child to parent

                public virtual void Start()/void Update(float deltaTime): Calls the Onstart events of the Actor and its children

                public virtual void Draw(): Callls the Ondraw events of the Actor and its children
    

    **Class** Bullet
       
             Description: The Bullet class is where the bullet entity is created, given a sprite and htibox.

             Variables:
                Name:  _bullet
                Description: used to give the bullet a sprite
                Type: Access of the Sprite class

                Name: _box
                Description: Used to give the bullet a hitbox
                Type: Access of the AABB class
            
            Functions:
                 Public Bullet(float x, float y) : base(x, y): Gives the bullet and hitbox a x and y coordinate and adds them to a child

                 public AABB GetAABB: Gets the bullets hitbox
    
    **Class**  Entity
             
             Description: The Entity class i sused to get any object in the game its movement and speed.

             Variables:
                Name: _velocity
                Description: Gives velocity
                Type: Class

                Name: _acceleration
                Description: Gives acceleration
                Type: Class

            Functions:
                public float XVelocity: Gives the object velocity on the x axis

                public float XAcceleration: Gives the object acceleration on the x axis

                public float YVelocity: Gives the object velocity on the y axis

                public float YAcceleration: Gives the object acceleration on the y axis

                public Entity(float x, float y) : base(): Gives object X axis and Y axis. Also returns

                public override void Update(float deltaTime): Updates velocity and acceleration

    **Class**  Game

            Description: The Game class is the back bone of this program. This is what everything runs on.

            Variables:
                Name: _root
                Description: the current root Actor
                Type: Actor class null

                Name: _next
                Description: the next root Actor
                Type: Actor class null

            Functions:
                public Game(int width, int height, title): Creates a game and new Scene instance as its active Scene

                public void Run(): Runs the game loop

                public Actor Root: The Actor we are currently running

    **Class**  All Matrix and Vector

             Description: The Matrix and Vector classes holds all the math in this program. Without these classes. Getting the x and y coordinates for the players and or object wouldn't be possible.

             Variables:
             Matrix: All values are stored in the matrix and is set to reference it
             Vectors: All Values are stored in the vector and is set to reference it

    **Class**  ObjectAxis
          
              Description: This class ment to gives any player or object its on axis to rotate on rather than the worlds. In other words. The root.

              Variables:
                Name: _tank
                Description: Used to access the Tank class
                Type: Class

                Name: _boxline;
                Description: Used to give colission to an AABB box
                Type: Class

                Name: _placementX
                Description: Used as an extra means to place the tank center map
                Type: float

                Name: _placementY
                Description: Used as an extra means to place the tank canter map
                Type: float

             Functions:
                 Public ObjectAxis(float x, float y) : base(x,y): Used to give the axis a coordinate

                 public void TankAxis(float deltatime): Gives the tank object its on axis

                 public void Placement(float deltatime):  Used as an extra means to place the tank center map

                 public void Collision(float deltatime):  Gives the tank object cllision detection

                 public void Rotateleft/right(float deltatime): Allows the tank to rotate left and or right with the keybind

    **Class** Program
     
            Description: This is where the game is setup.

            Variables: 
              Name: box
              Description: Used for collision detection
              Type: class AABB

    **Class** Sprite
             
              Description: This class allows sprites to be implumented.

              Functions:
              Public float Width: The width of the sprite

              public float Height: the height of the sprite

              public Sprite(string path): Default constructor

              public override void Draw(): draw the sprite to the screen

    **Class** Tank
           
             Description: This class is how the tank is created

             Variables:
                Name: _outline
                Description: Gives the tank a htibox
                Type: class AABB

                Name: _tank
                Description: used to create the tank
                Type: class sprite

                Name: _turret
                Description: used as a child to tthe tank
                Type: Class Turret

            Functions:
            public Tank(float x, float y string path) : base(x,y): Gives the tank a x and y axis. Also returns it.

            public void Movement(float deltatime): Allows the tank to move up and down with the input binds

    **Class** Turret

             Description: This class is how the turret is created

             Variables:
               Name: _turret
               Description: used to create a turret
               Type: class sprite

               Name: _bullet
               Description; used to connect the bullet class to turret
               Type: class Bullet

            Functions:
             public Turret(float x, float y):  Gives the turret a x and y axis. Also returns it.

             public void Rotateleft/right(float deltatime): Allows the turret to rotate left and right using the input binds

             public void  BulletCollision(float deltatime): Gives the bullet collision detection

             public void Fire(float deltatime): Gives the turret the ability to fire the bullet with a input bind.
        
## III Peer Reveiew outcome

   Details:  I tested to see if my matrix and vectors work successfully with my peer review outcome. Results:  Everything worked well.

                
