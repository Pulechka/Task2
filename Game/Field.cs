namespace GameTask
{
    public sealed class Field
    {
        private object[,] field;

        public int Width { get; private set; }
        public int Height { get; private set; }
        public int BonusCount { get; set; }


        private Field() { }

        public void Create(int width, int height)
        {
            field = new object[width, height];
        }

    }
}
