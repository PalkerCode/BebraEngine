using System.Drawing;

namespace BebraEngine.BebraEngine
{
    public class Sprite2D
    {
        public Vector2 position = null;
        public Vector2 scale = null;

        public string directory = "";
        public string tag = "";

        public Bitmap Sprite = null;

        public Sprite2D(Vector2 position, Vector2 scale, string tag, string directory)
        {
            this.position = position;
            this.scale = scale;
            this.tag = tag;
            this.directory = directory;
            
            Image tmp = Image.FromFile($"Assets/Sprites/{directory}.png");
            Bitmap sprite = new Bitmap(tmp, (int)this.scale.X, (int)this.scale.Y);

            Sprite = sprite;
            
            BebraEngine.RegisterSprite(this);
        }

        public void Destroy()
        {
            BebraEngine.UnregisterSprite(this);
        }
    }
}