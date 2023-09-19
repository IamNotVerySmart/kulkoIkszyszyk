namespace kolkokrzyzyk
{
    internal class Gra
    {
        string[] val = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }; //pozycje na planszy
        int positionChoice;
        bool playerTurn = false;
        int drawValue = 0;
        public int gameStatus = 1; // 0 = przegrana | 1 = w trakcie | 2 = wygrana | 3 = remis
        //rozpoczecie gry oraz sprawdzanie czyja kolej.
        public void moveOnBoard()
        {
            if (playerTurn)
            {
                pickPosition();
                generateBoard();
                choseWinner("O");
                Console.WriteLine("<><><><><><><><><><><><><>");
            }
            else
            {
                pickAiPosition();
                generateBoard();
                choseWinner("X");
                Console.WriteLine("<><><><><><><><><><><><><>");
            }

        }
        //wybor pola na planszy przez gracza
        public void pickPosition()
        {
            string tmp = "";
            Console.WriteLine("Pick position for 'O': ");
            tmp = Console.ReadLine()!;
            if (int.TryParse(tmp, out int position) && position >= 1 && position <= 10)
            {
                positionChoice = int.Parse(tmp);
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
            else
            {
                Console.WriteLine("Unvailid position, please chose diffrent one.");
                pickPosition();
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
        public void choseWinner(string playerOrAi)
        {
            if ((val[1] == playerOrAi && val[2] == playerOrAi && val[3] == playerOrAi) ||
                (val[4] == playerOrAi && val[5] == playerOrAi && val[6] == playerOrAi) ||
                (val[7] == playerOrAi && val[8] == playerOrAi && val[9] == playerOrAi) ||
                (val[1] == playerOrAi && val[4] == playerOrAi && val[7] == playerOrAi) ||
                (val[2] == playerOrAi && val[5] == playerOrAi && val[8] == playerOrAi) ||
                (val[3] == playerOrAi && val[6] == playerOrAi && val[9] == playerOrAi) ||
                (val[1] == playerOrAi && val[5] == playerOrAi && val[9] == playerOrAi) ||
                (val[3] == playerOrAi && val[5] == playerOrAi && val[7] == playerOrAi))
            {
                if (playerOrAi == "O")
                {
                    gameStatus = 2;
                }
                else
                {
                    gameStatus = 0;
                }
            }
            //sprawdzanie czy plansza jest pełna bez zwycięscy(remis)
            foreach (string n in val)
            {
                if (n == "O" || n == "X")
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
                    break;
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