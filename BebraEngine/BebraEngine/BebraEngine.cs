using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace BebraEngine.BebraEngine
{
    class Canvas : Form
    {
        public Canvas()
        {
            this.DoubleBuffered = true;
        }
    }
    
    public abstract class BebraEngine
    {
        private Vector2 screenSize = new Vector2(512, 512);
        private string title = "Bebra Engine";
        private Canvas window = null;

        private Thread gameLoopThread = null;

        public Color backgroundColor = Color.Black;

        private static List<Shape2D> AllShapes = new List<Shape2D>();
        private static List<Sprite2D> AllSprites = new List<Sprite2D>();

        public BebraEngine(Vector2 screenSize, string title)
        {
            this.screenSize = screenSize;
            this.title = title;

            window = new Canvas();
            window.Size = new Size((int)this.screenSize.X, (int)this.screenSize.Y);
            window.Text = this.title;
            window.Paint += Renderer;

            gameLoopThread = new Thread(GameLoop);
            gameLoopThread.Start();
            
            Application.Run(window);
        }

        public static void RegisterShape(Shape2D shape)
        {
            AllShapes.Add(shape);
        }
        
        public static void RegisterSprite(Sprite2D sprite)
        {
            AllSprites.Add(sprite);
        }
        
        public static void UnregisterShape(Shape2D shape)
        {
            AllShapes.Remove(shape);
        }
        
        public static void UnregisterSprite(Sprite2D sprite)
        {
            AllSprites.Remove(sprite);
        }

        void GameLoop()
        {
            onLoad();
            while (gameLoopThread.IsAlive)
            {
                try
                {
                    onDraw();
                    window.BeginInvoke((MethodInvoker)delegate { window.Refresh(); });
                    onUpdate();
                    Thread.Sleep(1);
                }
                catch
                {
                    Debug.Warning("Window is not found... Waiting...");
                }
            }
        }

        private void Renderer(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            g.Clear(backgroundColor);

            foreach (Shape2D shape in AllShapes)
            {
                g.FillRectangle(new SolidBrush(Shape2D.Color), shape.position.X, shape.position.Y, shape.scale.X, shape.scale.Y);
            }

            foreach (Sprite2D sprite in AllSprites)
            {
                g.DrawImage(sprite.Sprite, sprite.position.X, sprite.position.Y, sprite.scale.X, sprite.scale.Y);
            }
        }
        
        public abstract void onLoad();
        public abstract void onDraw();
        public abstract void onUpdate();
    }
}