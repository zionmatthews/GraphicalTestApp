using System;
using System.Collections.Generic;
using Raylib;
using RL = Raylib.Raylib;

namespace GraphicalTestApp
{
    delegate void StartEvent();
    delegate void UpdateEvent(float deltaTime);
    delegate void DrawEvent();

    class Actor
    {
        public StartEvent OnStart;
        public UpdateEvent OnUpdate;
        public DrawEvent OnDraw;

        public bool Started { get; private set; } = false;

        public Actor Parent { get; private set; } = null;
        private List<Actor> _children = new List<Actor>();

        private Matrix3 _localTransform = new Matrix3();
        private Matrix3 _globalTransform = new Matrix3();
        
        //## Implement X and Y relative and absolute coordinates ##//
        public float X
        {
            get { return 0; }
            set { }
        }
        public float XAbsolute
        {
            get { return 0; }
        }
        public float Y
        {
            get { return 0; }
            set { }
        }
        public float YAbsolute
        {
            get { return 0; }
        }

        //## Implement methods for rotating _localTransform ##//
        public float GetRotation()
        {
            return 0;
        }

        public void Rotate(float radians)
        {

        }

        //## Implement methods/properties for scaling _localTransform ##//
        public float GetScale()
        {
            return 0;
        }

        public void Scale(float scale)
        {

        }

        //## Implement AddChild(Actor) ##//
        public void AddChild(Actor child)
        {

        }

        //## Implement RemoveChild(Actor) ##//
        public void RemoveChild(Actor child)
        {

        }

        //## Implment UpdateTransform() ##//
        public void UpdateTransform()
        {

        }

        //Call the OnStart events of the Actor and its children
        public void Start()
        {
            OnStart?.Invoke();

            foreach (Actor child in _children)
            {
                child.Start();
            }

            Started = true;
        }

        //Call the OnUpdate events of the Actor and its children
        public void Update(float deltaTime)
        {
            OnUpdate?.Invoke(deltaTime);

            foreach (Actor child in _children)
            {
                child.Update(deltaTime);
            }
        }

        //Call the OnDraw events of the Actor and its children
        public void Draw()
        {
            OnDraw?.Invoke();

            foreach (Actor child in _children)
            {
                child.Draw();
            }
        }
    }
}
