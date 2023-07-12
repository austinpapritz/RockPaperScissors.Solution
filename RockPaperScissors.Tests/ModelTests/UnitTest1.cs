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
        Game newGame = new Game("rock", "rock");
        // Assert
        Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void GameConstructor_TakesInUserMove_String()
    {
        // Arrange
        string user1Input = "rock";
        string user2Input = "rock";
        // Act
        Game newGame = new Game(user1Input, user2Input);
        // Assert
        Assert.AreEqual(user1Input, newGame.Player1Move);
        Assert.AreEqual(user2Input, newGame.Player2Move);
    }
    
    [TestMethod]
    public void GameLogic_DrawResults_String()
    {
        //Arrange
        string result = "draw";
        string user1Input = "rock";
        string user2Input = "rock";
        Game newGame = new Game(user1Input, user2Input);
        // Act
        string gameResult = newGame.GameLogic();
        // Assert
        Assert.AreEqual(result, gameResult);
    }
    
} 

// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()