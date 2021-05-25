using System;


    Console.WriteLine("Hello World!");
    main();
    void askUser()
    {
        Console.WriteLine("|-------------------------------------------------------------------|");
        Console.WriteLine("|----   Please Guess the secret number :       ---------------------|");
        Console.Write("|       Your Guess Is:");
        string playerResponse = Console.ReadLine();
        int playerNumber;
        if(Int32.TryParse(playerResponse, out playerNumber))
        {
            Console.Write("|----   The number you guessed is :" + playerNumber.ToString());
            Console.Write ("  ");
            for(int i = 0; i < (31 - playerNumber.ToString().Length); i ++){
                Console.Write ('-');
            }
            Console.Write ('|');
            Console.WriteLine();
        }
        else{
              Console.WriteLine("|----   It has to be a number :       ------------------------------|");
              askUser();
        }

    }
    void main(){
        askUser();

    }
