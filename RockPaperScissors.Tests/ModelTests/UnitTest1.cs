using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;
using System.Collections.Generic;
using System;

namespace RockPaperScissors.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void PlayerConstructor_CreateInstanceOfPlayer()
    {
        // Arrange
        Player newPlayer = new Player("rock");
        // Assert
        Assert.AreEqual(typeof(Player), newPlayer.GetType());
    }

    [TestMethod]
    public void PlayerConstructor_TakesInUserMove_String(){
        // Arrange
        string userInput = "rock";
        // Act
        Player newPlayer = new Player(userInput);
        string playerMove = newPlayer.MoveSelection;
        // Assert
        Assert.AreEqual(userInput, playerMove);

    }
    
}