class A
{   static void Main()
    {
        int[,] chess = new int[8, 8];
        int[,] temp = new int[8, 8];

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(chess[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.Write("Enter the number of row from 1 to 8: ");
        int r = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Enter the number of row from 1 to 8: ");
        int c = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine();

        int mr = 0;
        int mc = 0;
        int m = 0;
        int count = 64;
        int n; 
        bool var;

        chess[r, c] = 5;
        count = count - 1;
        

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if ((Math.Abs(r - i) == Math.Abs(c - j) && (i != r || j != c)) && chess[i, j] != 5)
                {
                    chess[i, j] = 1;
                    count--;
                }
                else if (((i == r && j != c) || i != r && j == c) && chess[i, j] != 5)
                {
                    chess[i, j] = 1;
                    count--;

                }
            }
        }

        do
         {
            int max = 0;
            chess[r, c] = 5;
            count = count - 1;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((Math.Abs(r - i) == Math.Abs(c - j) && (i != r || j != c)) && chess[i, j] != 5)
                    {
                        chess[i, j] = 1;
                    }
                    else if (((i == r && j != c) || i != r && j == c) && chess[i, j] != 5)
                    {
                        chess[i, j] = 1;
                    }
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (chess[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(chess[i, j] + " ");
                        Console.ForegroundColor= ConsoleColor.Gray;
                    }
                    else if (chess[i, j] == 0) {
                        Console.Write(chess[i, j] + " ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Q ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Do you want to continue? (y/n): ");
            string answer = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (answer == "y" && count >= 0)
            {
                var = true;

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if ((chess[i, j] == 0))
                        {
                            n = count;
                            chess[i, j] = 4;
                            r = i;
                            c = j;

                            for (int k = 0; k < 8;  k++)
                            {
                                for (int l = 0; l < 8; l++)
                                {
                                    if ((Math.Abs(r - k) == Math.Abs(c - l) && (k != r || l != c)) && chess[k, l] != 1)
                                    {
                                        n--;
                                    }
                                    else if (((k == r && l != c) || k != r && l == c) && chess[k, l] != 1)
                                    {
                                        n--;
                                    }
                                }
                            }
                            Console.WriteLine(n);
                            if (n > max)
                            {
                                max = n;
                                mr = i;
                                mc = j;
                            }
                            else if (n == 0 && (m == 0 || (count == 1 || count == 0)))
                            {
                                max = n;
                                mr = i;
                                mc = j;
                                m++;
                            }


                            //else /*if (n == 0 && m == 0)*/
                            //{
                            //  max = n;
                            //mr = i;
                            //mc = j;
                            //m++;
                            //}
                            temp[i, j] = n;
                        }
                    }
                }

                count = max;
                Console.WriteLine(count + " count");
                Console.WriteLine();
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (chess[i, j] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(chess[i, j] + "  ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else if (chess[i, j] == 0)
                        {
                            Console.Write(chess[i, j] + "  ");
                        }
                        else if (chess[i, j] == 4 && i == mr && j == mc)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            if (temp[i, j] > 9)
                            {
                                Console.Write(temp[i, j] + " ");
                            }
                            else
                            {
                                Console.Write(temp[i, j] + "  ");
                            }
                            Console.ForegroundColor = ConsoleColor.Gray;
                            chess[i, j] = 0;
                        }
                        else if (chess[i, j] == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            if (temp[i, j] > 9)
                            {
                                Console.Write(temp[i, j] + " ");
                            }
                            else
                            {
                                Console.Write(temp[i, j] + "  ");
                            }
                            Console.ForegroundColor = ConsoleColor.Gray;
                            chess[i, j] = 0;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Q  ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                r = mr;
                c = mc;
            
            }
            else
            {
                var = false;
                if (count < 0)
                {
                    Console.WriteLine("There is no fields left.");
                }
            }

        } while (var);
    }
}
