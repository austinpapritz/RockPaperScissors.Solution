using System;

namespace RockPaperScissors.Models;
public class Game 
{
    public string Player1Move { get; set; }
    // public string Player2Move { get; set; }

    public Game(string input1)
    {
        Player1Move = input1;
        // Player2Move = input2;
    }

    // public string GameLogic()
    // {
    //     // Draw if selections are same.
    //     if (Player1Move == Player2Move)
    //     {
    //         return "draw";
    //     } else {
    //         return "";
    //     }
    // }
}