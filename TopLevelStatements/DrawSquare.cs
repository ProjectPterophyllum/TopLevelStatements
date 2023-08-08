namespace TopLevelStatements
{
    public class Rectangle
    {
        private int x, y;
        private char symbol;
        public void draw()
        {
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
        }
        public int Height
        { get { return y; } set { y = value; } }
        public int Width
        { get { return x; } set { x = value; } }
        public char Symbol { get { return symbol; } set { symbol = value; } }
    }
}
