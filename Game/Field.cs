namespace GameTask
{
    public class Field
    {
        private object[,] field;

        public int Width { get; private set; }
        public int Height { get; private set; }
        public int BonusCount { get; set; }

        public void Create(int width, int height)
        {
            field = new object[width, height];
        }

    }
}
