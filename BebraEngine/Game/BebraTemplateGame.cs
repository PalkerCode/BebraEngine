using System;
using System.Drawing;
using BebraEngine.BebraEngine;

namespace BebraEngine.Game
{
    public class BebraTemplateGame : BebraEngine.BebraEngine
    {
        private Sprite2D icon;
        
        private Random xValue = new Random();
        private Random yValue = new Random();
        
        private int xSpeed = 0;
        private int ySpeed = 0;

        public BebraTemplateGame() : base(new Vector2(1280, 720), "Bebra Engine Game") { }

        public override void onLoad()
        {
            icon = new Sprite2D(new Vector2(640, 360), new Vector2(200, 200), "Icon", "DVD/index");
            xSpeed = xValue.Next(-5, 5);
            ySpeed = yValue.Next(-5, 5);
        }

        public override void onDraw()
        {
            
        }

        public override void onUpdate()
        {
            icon.position.X += xSpeed;
            icon.position.Y += ySpeed;
            
            Debug.Log(icon.position.X.ToString());

            if (icon.position.X >= 1070)
            {
                xSpeed = xValue.Next(-10, -5);
                icon.position.X += xSpeed;
            }

            if (icon.position.X <= 0)
            {
                xSpeed = xValue.Next(5, 10);
                icon.position.X += xSpeed;
            }
            
            if (icon.position.Y >= 530)
            {
                ySpeed = yValue.Next(-10, -5);
                icon.position.Y += ySpeed;
            }

            if (icon.position.Y <= -50)
            {
                ySpeed = yValue.Next(5, 10);
                icon.position.Y += ySpeed;
            }
        }
    }
}