using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetiersPortable;
using BLLFR;

namespace FilRougeForum.Tests
{
    /// <summary>
    /// Test sur la classe Rubric
    /// </summary>
    [TestClass]
    public class RubricTests
    {
        /// <summary>
        /// Test de création d'une nouvelle rubrique
        /// </summary>
        [TestMethod]
        public void TestCreationRubric()
        {
            string expectedString = "Test de Rubrique";
            Rubric rubric = new Rubric(2, "Test de Rubrique");

            Assert.AreEqual(rubric.Libelle, expectedString);
        }

        [TestMethod]
        public void TestGetRubricByID()
        {
            string expectedString = "Entraide.com";
            Rubric rubric = Outil.GetRubricByID(1);

            Assert.AreEqual(rubric.Libelle, expectedString);
        }
    }    
}
