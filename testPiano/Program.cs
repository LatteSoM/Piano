namespace testPiano
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("для переключкня октав используйте f5, f6");
            ConsoleKeyInfo choiceOctave = Console.ReadKey();
            if (choiceOctave.Key == ConsoleKey.F4)
            {
                int[] octave4 = new int[] { 261,277,293,311, 329, 349, 370,
                    392, 415, 440, 466, 493};
                fiveOctave(octave4);
            }
            if (choiceOctave.Key == ConsoleKey.F5)
            {
                int[] octave5 = new int[] { 523, 554, 587, 622, 659, 698,
                740, 784, 830, 880, 932, 987};
                fiveOctave(octave5);
            }
            if (choiceOctave.Key == ConsoleKey.F6)
            {
                int[] octave6 = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 
                1480, 1568, 1661, 1760, 1865, 1976};
                fiveOctave(octave6);
            }
        }
        static void fiveOctave(int[] AllOctaves)
        {
                ConsoleKeyInfo fKey = Console.ReadKey();
            while (fKey.Key != ConsoleKey.Escape)
            {
                switch (fKey.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(AllOctaves[0], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.Q:
                        Console.Beep(AllOctaves[1], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.S:
                        Console.Beep(AllOctaves[2], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.W:
                        Console.Beep(AllOctaves[3], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.D:
                        Console.Beep(AllOctaves[4], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.E:
                        Console.Beep(AllOctaves[5], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.F:
                        Console.Beep(AllOctaves[6], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.R:
                        Console.Beep(AllOctaves[7], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.G:
                        Console.Beep(AllOctaves[8], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.T:
                        Console.Beep(AllOctaves[9], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.H:
                        Console.Beep(AllOctaves[10], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(AllOctaves[11], 200);
                        Console.Clear();
                        break;

                }
                fKey = Console.ReadKey();
            }
            Main();
        }
    }
}