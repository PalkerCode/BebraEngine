// Dmitry Belyaikin 2022 Template game

using System;
using System.Drawing;
using System.Windows.Forms;
using BebraEngine.BebraEngine;

namespace BebraEngine.Game
{
    // Game class
    public class BebraTemplateGame : BebraEngine.BebraEngine
    {
        // Game window settings. Window Size, window title
        public BebraTemplateGame() : base(new Vector2(1280, 720), "Bebra Engine Game") { }
        
        // When game instance created, this method will be executed
        public override void OnLoad()
        {
            
        }
        
        // This method will be executed before next window frame rendered
        public override void OnDraw()
        {
            
        }
        
        // This method will be executed every window frame
        public override void OnUpdate()
        {
            
        }

        public override void GetKeyDown(KeyEventArgs e)
        {
            
        }

        public override void GetKeyUp(KeyEventArgs e)
        {
            
        }
    }
}