using kolkokrzyzyk;
Console.WriteLine("Witaj graczu!");
Console.WriteLine("Ta gra to kółko i krzyżyk której zasady są proste.");
Console.WriteLine("Kto postawi 3 znaki koło siebie w lini poziomej, pionowej lub na ukos wygrywa");
Console.WriteLine("Gracz zaczyna jako: 'O' aby wybrać gdzie zacząć wpisz cyfrę od 1 do 9\n");
Console.WriteLine("Komputer zaczyna pierwszy w losowym miejscu!");

Gra gra = new Gra();
//gra.generateBoard();
while(gra.gameStatus == 1)
{
    //gra.generateBoard();
    //gra.choseWinner();
    gra.moveOnBoard();
}
if(gra.gameStatus == 0)
{
    Console.WriteLine("gameStatus = 0");
    Console.WriteLine("Przegrałeś! smutno :(");
}
if(gra.gameStatus == 2)
{
    Console.WriteLine("gameStatus = 2");
    Console.WriteLine("Gratulacje wygrałeś!");
}
if(gra.gameStatus == 3)
{
    Console.WriteLine("gameStatus = 3");
    Console.WriteLine("Niestety nikt nie wygrał! Może następnym razem!");
}