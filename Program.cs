using System;


Console.WriteLine("Hello World!");
main();
int getNumber()
{    
    Random rnd = new Random();
    int toGuessValue = rnd.Next(1, 101);
    return toGuessValue;
}
bool checkIfWinner(int userguess,int rndNumber, int loopCount)
{
    if (userguess == rndNumber)
    {
        Console.WriteLine("|----   Winner winner Chicken dinner   -----------------------------|");
        return true;

    }
    else
    {
        Console.WriteLine("|----   L L L L L L is for Loser               ---------------------|");
        Console.Write("|----   The number you guessed is :" + userguess.ToString());
        Console.Write("  You have " + (4 - (loopCount +1)).ToString() + " ");
        for (int i = 0; i < (20 - userguess.ToString().Length); i++)
        {
            Console.Write('-');
        }
        Console.Write('|');
        Console.WriteLine();
        return false;
    }
}
int askUser()
{
    Console.WriteLine("|-------------------------------------------------------------------|");
    Console.WriteLine("|----   Please Guess the secret number :       ---------------------|");
    Console.Write("|       Your Guess Is:");
    string playerResponse = Console.ReadLine();
    int playerNumber;
    if (Int32.TryParse(playerResponse, out playerNumber))
    {

        return playerNumber;
    }
    else
    {
        Console.WriteLine("|----   It has to be a number :       ------------------------------|");
        askUser();
        return 0;
    }

}
void main()
{
    int compNumber = getNumber();
    for(int i =0; i<4; i++){
        int intGuess = askUser();
        if(checkIfWinner(intGuess,compNumber ,i)) break;
    }
    

}
