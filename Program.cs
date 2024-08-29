using System.Net;

namespace Rock_Paper_Scissors;

class Program
{

        static int player1Score = 0;
        static int player2Score = 0;

    static void Main(string[] args)
    {
        for(int i = 1; i < 5; i++)
        {
        string player1Choice = RandomChoice();
        Console.WriteLine($"Player 1 choice: {player1Choice}");

        string player2Choice = RandomChoice();
        Console.WriteLine($"Player 2 choice: {player2Choice}");

        string result = Winner(player1Choice, player2Choice);
        Console.WriteLine(result);
        }

        Console.WriteLine($"Player 1 Score: {player1Score}");
        Console.WriteLine($"Player 2 Score: {player2Score}");



    }

     static string RandomChoice() 
    {
        string[] choices = ["rock","paper","scissors","lizard","Spock"];

        var random = new Random();
        int randomIndex = random.Next(choices.Length);

        return choices[randomIndex];
       
    }

    static string Winner(string player1, string player2)
     {
        
        if(player1 == player2) {
            return "It's a tie";
        }
        else if(
             (player1 == "rock" && player2 == "scissors" )||
             (player1 == "scissors" && player2 == "paper") ||
             (player1 == "paper" && player2 == "rock") ||
             (player1 == "Spock" && player2 == "scissors") ||
             (player1 == "lizard" && player2 == "Spock" )||
             (player1 == "rock" && player2 == "lizard" )||
             (player1 == "Spock" && player2 == "rock" )||
             (player1 == "lizard" && player2 == "paper") ||
             (player1 == "paper" && player2 == "Spock") ||
             (player1 == "scissors" && player2 == "lizard")) 
             {
                player1Score ++;
                return "Player 1 Wins!";
             }
         else if(
            (player2 == "rock" && player1 == "scissors") ||
             (player2 == "scissors" && player1 == "paper") ||
             (player2 == "paper" && player1 == "rock") ||
             (player2 == "Spock" && player1 == "scissors") ||
             (player2 == "lizard" && player1 == "Spock" )||
             (player2 == "rock" && player1 == "lizard" )||
             (player2 == "Spock" && player1 == "rock" )||
             (player2 == "lizard" && player1 == "paper") ||
             (player2 == "paper" && player1 == "Spock")  ||
            (player2 == "scissors" && player1 == "lizard")) 
            {
                player2Score ++;
                return "Player 2 Wins!";
            }   
            return "";
     }

    
}
