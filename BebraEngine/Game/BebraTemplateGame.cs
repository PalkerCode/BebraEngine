// Dmitry Belyaikin 2022 Template game

using System;
using System.Drawing;
using BebraEngine.BebraEngine;

namespace BebraEngine.Game
{
    // Game class
    public class BebraTemplateGame : BebraEngine.BebraEngine
    {
        // Create sprite variable
        private Sprite2D icon;
        
        // Create random X and Y values
        private Random xValue = new Random();
        private Random yValue = new Random();
        
        // Create X and Y speed variables
        private int xSpeed = 0;
        private int ySpeed = 0;
        
        // Game window settings                                Window Size           Window title
        public BebraTemplateGame() : base(new Vector2(1280, 720), "Bebra Engine Game") { }
        
        // When game instance created, this method will be executed
        public override void onLoad()
        {
            // Apply settings for icon sprite        Position                        Scale         Tag (Name)      Sprite Directory
            icon = new Sprite2D(new Vector2(640, 360), new Vector2(200, 200), "Icon", "DVD/index");
            
            // Apply random value to X and Y speed
            xSpeed = xValue.Next(-5, 5);
            ySpeed = yValue.Next(-5, 5);
        }
        
        // This method will be executed before next window frame rendered
        public override void onDraw()
        {
            
        }
        
        // This method will be executed every window frame
        public override void onUpdate()
        {
            // Apply X and Y speed to icon position
            icon.position.X += xSpeed;
            icon.position.Y += ySpeed;
            
            // If icon hits right side of the screen
            if (icon.position.X >= 1070)
            {
                // Apply random negative value to X speed
                xSpeed = xValue.Next(-10, -5);
                // Apply this value to icon position
                icon.position.X += xSpeed;
            }
            
            // If icon hits left side of the screen
            if (icon.position.X <= 0)
            {
                // Apply random positive value to X speed
                xSpeed = xValue.Next(5, 10);
                // Apply this value to icon position
                icon.position.X += xSpeed;
            }
            
            // If icon hits ceiling of the window
            if (icon.position.Y >= 530)
            {
                // Apply random negative value to Y speed
                ySpeed = yValue.Next(-10, -5);
                // Apply this value to icon position
                icon.position.Y += ySpeed;
            }

            // If icon hits bottom of the window
            if (icon.position.Y <= -50)
            {
                // Apply random positive value to Y speed
                ySpeed = yValue.Next(5, 10);
                // Apply this value to icon position
                icon.position.Y += ySpeed;
            }
        }
    }
}