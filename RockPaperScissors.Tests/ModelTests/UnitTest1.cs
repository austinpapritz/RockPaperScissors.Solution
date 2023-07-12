using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;
using System.Collections.Generic;
using System;

namespace RockPaperScissors.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void GameConstructor_CreateInstanceOfGame()
    {
        // Arrange
        Game newGame = new Game("rock");
        // Assert
        Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    // [TestMethod]
    // public void PlayerConstructor_TakesInUserMove_String()
    // {
    //     // Arrange
    //     string userInput = "rock";
    //     // Act
    //     Game newGame = new Game(userInput);
    //     string playerMove = newPlayer.MoveSelection;
    //     // Assert
    //     Assert.AreEqual(userInput, playerMove);
    // }
    
    // [TestMethod]
    // public void GameLogic_DrawResults_String()
    // {
    //     //Arrange
    //     string result = "draw";
    //     Player newPlayer1 = new Player("rock");
    //     Player newPlayer2 = new Player("rock");
    //     // Act
    //     string gameResults = Player.GameLogic(newPlayer1.MoveSelection, newPlayer2.MoveSelection);
    //     // Assert
    //     Assert.AreEqual(result, gameResults);
    // }
    
} 

// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()