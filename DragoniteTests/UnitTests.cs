using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dragonite.Objects;
using Dragonite;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace DragoniteTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void GetLevelFromXpTest()
        {
            //Arrange   
            int xp = 1500;
            int expectedReturn = 1;

            //Act
            int result = Level.GetLevelFromXp(xp);

            //Assert
            Assert.AreEqual(expectedReturn, result);
        }

        //[TestMethod]
        //public void UpdateUIEgg()
        //{
        ////Arrange   
        //int eggXp = 10;
        //string expectedReturn = "YOUR EGG IS TOO COLD !";

        ////Act
        //int result = Dragonite.Hatching_Egg.UpdateUI(eggXp);

        ////Assert
        //Assert.AreEqual(expectedReturn, result);
        //}

        //[TestMethod]
        //public void GetDragonState()
        //{
        //    //Arrange   
        //    string dragonString = "dead";
        //    var expectedReturn = DragonState.dead;

        //    //Act
        //    int result = DragonStates.GetDragonState(dragonString);

        //    //Assert
        //    Assert.AreEqual(expectedReturn, result);
        //}
    }
}
