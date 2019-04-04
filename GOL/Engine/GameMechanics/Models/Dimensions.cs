namespace GOL.Engine.GameMechanics.Models
{
    public class Dimensions
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Dimensions(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
