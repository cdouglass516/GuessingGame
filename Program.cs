using System;


Console.WriteLine("Hello World!");
main();
int getNumber()
{
    int toGuessValue = 42;
    return toGuessValue;
}
bool checkIfWinner(int userguess)
{
    int rndNumber = getNumber();
    if (userguess == rndNumber)
    {
        Console.WriteLine("|----   Winner winner Chicken dinner   -----------------------------|");
        return true;

    }
    else
    {
        Console.WriteLine("|----   L L L L L L is for Loser               ---------------------|");
        Console.Write("|----   The number you guessed is :" + userguess.ToString());
        Console.Write("  ");
        for (int i = 0; i < (31 - userguess.ToString().Length); i++)
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
    for(int i =0; i<4; i++){
        int intGuess = askUser();
        if(checkIfWinner(intGuess)) break;
    }
    

}
