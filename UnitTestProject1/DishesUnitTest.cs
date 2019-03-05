using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MenuProcessor;

namespace DishesUnitTestProject
{
    [TestClass]
    public class DishesUnitTest
    {
        [TestMethod]
        public void TestMenuLoadValid()
        {
            List<string> optionsList = new List<string>() { "morning", "1", "2", "3" };
            ProcessMenuConsole consoleOutput = new ProcessMenuConsole();
            string outputValues = consoleOutput.LoadMenuSelections(optionsList);
            Assert.AreNotEqual(outputValues, "");
        }

        [TestMethod]
        public void TestMenuLoadInvalid()
        {
            List<string> optionsList = new List<string>() { "morning", "1", "2", "7" };
            ProcessMenuConsole consoleOutput = new ProcessMenuConsole();
            string outputValues = consoleOutput.LoadMenuSelections(optionsList);
            bool containsError = outputValues.Contains("error");
            Assert.AreEqual(containsError, true);
        }

        [TestMethod]
        public void TestMealTimeValid()
        {
            List<string> optionsListOK = new List<string>() { "morning", "1", "2", "3" };
            string mealTimeOK = optionsListOK[0];
            Assert.AreEqual(mealTimeOK, MenuEnums.MealTime.morning.ToString());
        }

        [TestMethod]
        public void TestMealTimeInValid()
        {
            List<string> optionsListNotFound = new List<string>() { "brunch", "1", "2", "3" };
            string mealTimeNotFound = optionsListNotFound[0];
            Assert.AreNotEqual(mealTimeNotFound, MenuEnums.MealTime.morning.ToString());
        }
    }
}
