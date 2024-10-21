class ChessBoard {
    static int width = 8;
    static int height = 8;

    public void draw() {
        
        for(int i = 0; i < height; i++) {
            Console.Write(8 - i);
            Console.ForegroundColor = ConsoleColor.Black;
            for(int j = 0; j < width; j++) {
                var diff = (j + i % 2) % 2 == 0 ;
                Console.BackgroundColor = diff ? ConsoleColor.DarkBlue : ConsoleColor.DarkYellow;
                Console.Write("♚ ");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
        Console.Write(" ");
        for(int i = 0; i < width; i++) {
            Console.Write(" " + Char.ConvertFromUtf32('a' + i));
        }
        Console.WriteLine();
    }
}