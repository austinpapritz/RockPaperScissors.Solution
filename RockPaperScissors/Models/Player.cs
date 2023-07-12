using System;

namespace RockPaperScissors.Models;
public class Player 
{
    public string MoveSelection { get; set; }

    public Player(string input)
    {
        MoveSelection = input;
    }

    // public string GameLogic(string player1, string player2)
    // {
    //     // Game logic here.
    // }

    

}