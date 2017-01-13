using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetiersPortable;
using BLLFR;

namespace FilRougeForum.Tests
{
    /// <summary>
    /// Test sur la classe Subject
    /// </summary>
    [TestClass]
    public class SubjectTests
    {
        /// <summary>
        /// Test sur la méthode GetSujetByCategorieID
        /// </summary>
        [TestMethod]
        public void TestGetSujetByCategorieID()
        {
            //On instancie une liste de sujet, vide pour le moment
            List<Subject> sujetsAtt = new List<Subject>();

            //on instancie deux nouveaux sujets avec les ID 5 et 1
            Subject sujAtt = new Subject();
            sujAtt.Id = 31;

            Subject sujAtt1 = new Subject();
            sujAtt1.Id = 4;

            //on ajoute les sujets attendus dans la liste des sujets
            sujetsAtt.Add(sujAtt);
            sujetsAtt.Add(sujAtt1);

            //on instancie une liste de sujets retournés par la méthode GetSujetByCategorieID
            List<Subject> sujetsRet = new List<Subject>();

            sujetsRet = Outil.GetSujetsByCategorieID(2);
            CollectionAssert.AreEqual(sujetsAtt, sujetsRet);            
        }
    }
}
