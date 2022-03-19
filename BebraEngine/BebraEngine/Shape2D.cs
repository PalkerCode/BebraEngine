using System.Drawing;

namespace BebraEngine.BebraEngine
{
    public class Shape2D
    {
        public Vector2 position = null;
        public Vector2 scale = null;

        public string tag = "";
        public static Color Color;

        public Shape2D(Vector2 position, Vector2 scale, string tag, Color color)
        {
            this.position = position;
            this.scale = scale;
            this.tag = tag;
            Shape2D.Color = color;
            
            BebraEngine.RegisterShape(this);
        }

        public void Destroy()
        {
            BebraEngine.UnregisterShape(this);
        }
    }
}