using System;

namespace RockPaperScissors.Models;
public class G 
{
    public string MoveSelection { get; set; }

    public Player(string input)
    {
        MoveSelection = input;
    }

    public string GameLogic(string player1MoveSelection, string player2MoveSelection)
    {
        // Draw if selections are same.
        if (player1MoveSelection == player2MoveSelection)
        {
            return "draw";
        } else {
            return "";
        }
    }
}