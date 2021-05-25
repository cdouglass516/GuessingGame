using System;


Console.WriteLine("Hello World!");
main();
int getNumber()
{
    Random rnd = new Random();
    int toGuessValue = rnd.Next(1, 101);
    return toGuessValue;
}
bool checkIfWinner(int userguess, int rndNumber, int loopCount)
{
    bool toHigh = true;
    if (userguess == rndNumber)
    {
        Console.WriteLine("|----   Winner winner Chicken dinner   -----------------------------|");
        return true;

    }
    else
    {
        if (userguess < rndNumber) toHigh = false;
        Console.WriteLine("|----   L L L L L L is for Loser               ---------------------|");
        Console.Write("|----   The number you guessed is :" + userguess.ToString());

        Console.Write("  You have " + (4 - (loopCount + 1)).ToString() + " ");
        for (int i = 0; i < (20 - userguess.ToString().Length); i++)
        {
            Console.Write('-');
        }
        Console.Write('|');
        Console.WriteLine();
        if (toHigh)
        {
            Console.WriteLine("|++++   your Guess was to High High High High       ++++++++++++++++|");
        }
        else
        {
            Console.WriteLine("|^^^^   your Guess was to Low Low Low               ^^^^^^^^^^^^^^^^|");
        }
        return false;
    }
}
int setLevel()
{
    bool validAnswer = false;

    do
    {
        //code block
        Console.WriteLine("|-------------------------------------------------------------------|");
        Console.WriteLine("|----   Please Select a level :       ------------------------------|");
        Console.WriteLine("|----   1) easy, 2) medium, 3) hard       --------------------------|");
        Console.Write("|----   Your Level:");
        string answer = Console.ReadLine();
        if(answer.ToLower() == "1"){
            validAnswer = true;
            Console.WriteLine("|----   You have Selected Easy       -------------------------------|");
            return 8;
        } else if (answer.ToLower() == "2")
        {
                        validAnswer = true;
            Console.WriteLine("|----   You have Selected Medium       -----------------------------|");
            return 6;
        } else if (answer.ToLower() == "3")
        {
                        validAnswer = true;
            Console.WriteLine("|----   You have Selected Hard       -------------------------------|");
            return 4;
        }else{
            validAnswer = false;
            Console.WriteLine("|----   Choose 1,  2   or 3       ----------------------------------|");
        }
       Console.WriteLine("|-------------------------------------------------------------------|");
    } while (!validAnswer);
    return 0;
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
    int level = setLevel();
    int compNumber = getNumber();
    for (int i = 0; i < level; i++)
    {
        int intGuess = askUser();
        if (checkIfWinner(intGuess, compNumber, i)) break;
    }


}
