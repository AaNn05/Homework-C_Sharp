class Chess
{
    static void Main()
    {
        string[,] chess = { { "0 ", "0 ", "0 " , "0 ", "0 ", "0 ", "0 ", "0 "},
                         { "0 ", "0 ", "0 " , "0 ", "0 ", "0 ", "0 ", "0 "},
                         { "0 ", "0 ", "0 " , "0 ", "0 ", "0 ", "0 ", "0 "},
                         { "0 ", "0 ", "0 " , "0 ", "0 ", "0 ", "0 ", "0 "},
                         { "0 ", "0 ", "0 " , "0 ", "0 ", "0 ", "0 ", "0 "},
                         { "0 ", "0 ", "0 " , "0 ", "0 ", "0 ", "0 ", "0 "},
                         { "0 ", "0 ", "0 " , "0 ", "0 ", "0 ", "0 ", "0 "},
                         { "0 ", "0 ", "0 " , "0 ", "0 ", "0 ", "0 ", "0 "},
        };

        for (int i = 0; i < chess.GetLength(0); i++)
        {
            for (int j = 0; j < chess.GetLength(1); j++)
            {
                Console.Write(chess[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.Write("Enter the number of row from 1 to 8: ");
        int r = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Enter the number of column from 1 to 8: ");
        int c = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine();

        chess[r, c] = "K ";


        bool var;
        do
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (chess[i, j] == "K ")
                    {
                        Console.Write(chess[i, j]);
                    }
                    else if (((r - i == 2 || i - r == 2) && (c - j == 1 || j - c == 1) || (r - i == 1 || i - r == 1) && (c - j == 2 || j - c == 2)))
                    {
                        chess[i, j] = "1 ";
                        Console.Write(chess[i, j]);
                    }
                    else
                    {
                        Console.Write(chess[i, j]);
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Do you want to continue? (y/n): ");
            string answer = Console.ReadLine().ToLower();
            Console.WriteLine();

            int count = 0;

            for (int i = 0; i < chess.GetLength(0); i++)
            {
                for (int j = 0; j < chess.GetLength(1); j++)
                {
                    if (chess[i, j] == "1 ")
                    {
                        count++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            if (answer == "y" && count != 0)
            {
                var = true;
                int[] x = new int[count];
                int[] y = new int[count];

                int n = 0;

                for (int i = 0; i < chess.GetLength(0); i++)
                {
                    for (int j = 0; j < chess.GetLength(1); j++)
                    {
                        if (chess[i, j] == "1 ")
                        {
                            x[n] = i;
                            y[n] = j;
                            n++;
                            chess[i, j] = "0 ";
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                Console.WriteLine();
                Random random = new Random();
                int m = random.Next(x.Length);

                chess[x[m], y[m]] = "K ";
                r = x[m];
                c = y[m];
            }
            else
            {
                var = false;
                if (count == 0)
                {
                    Console.WriteLine("There is no places left.");
                }
            }

        } while (var);

    }
}