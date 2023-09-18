namespace kolkokrzyzyk
{
    internal class Gra
    {
        string[] val = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }; //pozycje na planszy
        int positionChoice;
        bool playerTurn = false;
        int check = 0;
        int drawValue = 0;
        public int gameStatus = 1; // 0 = przegrana | 1 = w trakcie | 2 = wygrana | 3 = remis
        //rozpoczecie gry oraz sprawdzanie czyja kolej.
        public void moveOnBoard()
        {
            if (playerTurn)
            {
                //choseWinner();
                pickPosition();
                //generateBoard();
                Console.WriteLine("<><><><><><><><><><><><><>");
            }
            else
            {
                //choseWinner();
                pickAiPosition();
                // generateBoard();
                Console.WriteLine("<><><><><><><><><><><><><>");
            }

        }
        //wybor pola na planszy przez gracza
        public void pickPosition()
        {
            Console.WriteLine("Pick position for 'O': ");
            string tmp = Console.ReadLine()!;
            if (tmp == "")
            {
                Console.WriteLine("No position selected, please chose one.");
                pickPosition();
            }
            else
            {
                positionChoice = int.Parse(tmp);
                if (positionChoice == 0 || positionChoice >= val.Length)
                {
                    Console.WriteLine("Unvailid position, please chose diffrent one.");
                    positionChoice = int.Parse(Console.ReadLine()!);
                }
                else
                {
                    if (val[positionChoice] == "O" || val[positionChoice] == "X")
                    {
                        Console.WriteLine("Position already taken, pick another one.");
                        pickPosition();
                    }
                    else
                    {
                        val[positionChoice] = "O";
                        playerTurn = false;
                        positionChoice = 0;
                    }
                }
            }
        }
        //wybor pola na planszy przez komputer
        public void pickAiPosition()
        {
            Random rnd = new Random();
            positionChoice = rnd.Next(1, 10);

            if (val[positionChoice] == "O" || val[positionChoice] == "X")
            {
                pickAiPosition();
            }
            else
            {
                val[positionChoice] = "X";
                playerTurn = true;
                positionChoice = 0;
            }
        }
        //sprawdzanie kto wygral lub remisu
        public void choseWinner()
        {
            #region didPlayerWin?
            for (int i = 1; i < 3; i++)
            {
                if (val[i] == "O")
                {
                    check++;
                    if (check == 3)
                    {
                        gameStatus = 2;
                    }
                }
                else
                {
                    check = 0;
                    break;
                }
            }
            for(int i = 4; i < 6; i++)
            {
                if (val[i] == "O")
                {
                    check++;
                    if (check == 3)
                    {
                        gameStatus = 2;
                    }
                }
                else
                {
                    check = 0;
                    break;
                }
            }
            for(int i = 7; i < 9; i++)
            {
                if (val[i] == "O")
                {
                    check++;
                    if (check == 3)
                    {
                        gameStatus = 2;
                    }
                }
                else
                {
                    check = 0;
                    break;
                }
            }
            for (int i = 1; i < 7;)
            {
                if (val[i] == "O")
                {
                    check++;
                    i += 3;
                    if (check == 3)
                    {
                        gameStatus = 2;
                    }
                }
                else
                {
                    check = 0;
                    break;
                }
            }
            for (int i = 2; i < 8;)
            {
                if (val[i] == "O")
                {
                    check++;
                    i += 3;
                    if (check == 3)
                    {
                        gameStatus = 2;
                    }
                }
                else
                {
                    check = 0;
                    break;
                }
            }
            for (int i = 3; i < 9;)
            {
                if (val[i] == "O")
                {
                    check++;
                    i += 3;
                    if (check == 3)
                    {
                        gameStatus = 2;
                    }
                }
                else
                {
                    check = 0;
                    break;
                }
            }
            if (val[1] == "O" && val[5] == "O" && val[9] == "O")
            {
                gameStatus = 2;
            }
            if (val[3] == "O" && val[5] == "O" && val[7] == "O")
            {
                gameStatus = 2;
            }
            #endregion
            #region didComputerWin?
            for (int i = 1; i < 3; i++)
            {
                if (val[i] == "X")
                {
                    check++;
                    if (check == 3)
                    {
                        gameStatus = 0;
                    }
                }
                else
                {
                    check = 0;
                    break;
                }
            }
            for (int i = 4; i < 6; i++)
            {
                if (val[i] == "X")
                {
                    check++;
                    if (check == 3)
                    {
                        gameStatus = 0;
                    }
                }
                else
                {
                    check = 0;
                    break;
                }
            }
            for (int i = 7; i < 9; i++)
            {
                if (val[i] == "X")
                {
                    check++;
                    if (check == 3)
                    {
                        gameStatus = 0;
                    }
                }
                else
                {
                    check = 0;
                    break;
                }
            }
            for (int i = 1; i < 7;)
            {
                if (val[i] == "X")
                {
                    check++;
                    i += 3;
                    if (check == 3)
                    {
                        gameStatus = 0;
                    }
                }
                else
                {
                    check = 0;
                    break;
                }
            }
            for (int i = 2; i < 8;)
            {
                if (val[i] == "X")
                {
                    check++;
                    i += 3;
                    if (check == 3)
                    {
                        gameStatus = 0;
                    }
                }
                else
                {
                    check = 0;
                    break;
                }
            }
            for (int i = 3; i < 9;)
            {
                if (val[i] == "X")
                {
                    check++;
                    i += 3;
                    if (check == 3)
                    {
                        gameStatus = 0;
                    }
                }
                else
                {
                    check = 0;
                    break;
                }
            }
            if (val[1] == "X" && val[5] == "X" && val[9] == "X")
            {
                gameStatus = 0;
            }
            if (val[3] == "X" && val[5] == "X" && val[7] == "X")
            {
                gameStatus = 0;
            }
            #endregion
            //sprawdzanie czy plansza jest pełna bez zwycięscy
            foreach(string n in val)
            {
                if (n == "O"  || n == "X")
                {
                    drawValue++;
                    if (drawValue == 9)
                    {
                        gameStatus = 3;
                    }
                }
                else
                {
                    drawValue = 0;
                }
            }
        }
        //generowanie planszy
        public void generateBoard()
        {
            Console.Write("        |       |        \n");
            Console.Write("    {0}   |   {1}   |   {2}    \n", val[1], val[2], val[3]);
            Console.Write("________|_______|________\n");
            Console.Write("        |       |        \n");
            Console.Write("    {0}   |   {1}   |   {2}    \n", val[4], val[5], val[6]);
            Console.Write("________|_______|________\n");
            Console.Write("        |       |        \n");
            Console.Write("    {0}   |   {1}   |   {2}    \n", val[7], val[8], val[9]);
            Console.Write("        |       |        \n");
        }
    }
}