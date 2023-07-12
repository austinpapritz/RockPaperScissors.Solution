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
        Player newPlayer = new Player();
        // Assert
        Assert.AreEqual(typeof(Player), newPlayer.GetType());
    }
}