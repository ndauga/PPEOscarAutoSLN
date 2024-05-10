using Microsoft.VisualStudio.TestTools.UnitTesting;
using PPO1ConcessionnaireLib;
using System;

namespace OscarBibliClasseTests
{
    [TestClass]
    public class TestClasses
    {
        [TestMethod]
        public void TestUser()
        {
            //Arrange
            string name = "test";
            string mdp = "test";
            //Act
            User testUser = new User(name, mdp);
            //Assert
            Assert.AreEqual(name, testUser.Name);
            Assert.AreEqual(mdp, testUser.Password);
        }
        [TestMethod]
        public void TestConcessionnaire()
        {
            //Arrange
            int concessionnaireID = 1;
            string nom = "test";
            string prenom = "test";
            string adresse = "test";
            string codePostal = "test";
            string ville = "test";
            //Act
            Concessionnaire testConcessionnaire = new Concessionnaire(concessionnaireID, nom, prenom, adresse, codePostal, ville);
            //Assert
            Assert.AreEqual(concessionnaireID, testConcessionnaire.ConcessionnaireID);
            Assert.AreEqual(nom, testConcessionnaire.Nom);
            Assert.AreEqual(prenom, testConcessionnaire.Prenom);
            Assert.AreEqual(codePostal, testConcessionnaire.CodePostal);
            Assert.AreEqual(ville, testConcessionnaire.Ville);

        }

        public void TestCrypto()
        {
            //Act
            string testcrypt = Crypto.EncryptString("Test2");
            //Assert
            Assert.AreEqual(testcrypt, "dGadqdFx0kZW5BV/Z/1OXg==");

        }
    }
}
