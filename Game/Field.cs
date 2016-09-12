namespace Game
{
    public sealed class Field
    {
        private object[,] field;

        public int Width { get; private set; }
        public int Height { get; private set; }

        private Field() { }

        public void Create(int width, int height)
        {
            field = new object[width, height];
        }

    }
}
