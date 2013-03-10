using FootballLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FootballTest
{
    
    
    /// <summary>
    ///This is a test class for FrenchLeague1PointSystemTest and is intended
    ///to contain all FrenchLeague1PointSystemTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FrenchLeague1PointSystemTest
    {

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetPointsFromMatch
        ///</summary>

        [TestMethod()]
        public void PointTotalVictoireHome()
        {
            FrenchLeague1PointSystem fr = FrenchLeague1PointSystem.Instance;
            Match m = new Match(new Club("Bordeaux"), new Club("Marseille"), 2, 1);
            bool home = true;        

            Assert.AreEqual("Points : 3 Goal average : 1", fr.GetPointsFromMatch(m, home).ToString());
        }

        [TestMethod()]
        public void PointTotalDefaiteHome()
        {
            FrenchLeague1PointSystem fr = FrenchLeague1PointSystem.Instance;
            Match m = new Match(new Club("Bordeaux"), new Club("Marseille"), 2, 3);
            bool home = true;

            Assert.AreEqual("Points : 0 Goal average : -1", fr.GetPointsFromMatch(m, home).ToString());
        }

        [TestMethod()]
        public void PointTotalMatchNulHome()
        {
            FrenchLeague1PointSystem fr = FrenchLeague1PointSystem.Instance;
            Match m = new Match(new Club("Bordeaux"), new Club("Marseille"), 2, 2);
            bool home = true;

            Assert.AreEqual("Points : 1 Goal average : 0", fr.GetPointsFromMatch(m, home).ToString());
        }

        [TestMethod()]
        public void PointTotalVictoireAway()
        {
            FrenchLeague1PointSystem fr = FrenchLeague1PointSystem.Instance;
            Match m = new Match(new Club("Bordeaux"), new Club("Marseille"), 2, 3);
            bool home = false;

            Assert.AreEqual("Points : 3 Goal average : 1", fr.GetPointsFromMatch(m, home).ToString());
        }

        [TestMethod()]
        public void PointTotalDefaiteAway()
        {
            FrenchLeague1PointSystem fr = FrenchLeague1PointSystem.Instance;
            Match m = new Match(new Club("Bordeaux"), new Club("Marseille"), 2, 1);
            bool home = false;

            Assert.AreEqual("Points : 0 Goal average : -1", fr.GetPointsFromMatch(m, home).ToString());
        }

        [TestMethod()]
        public void PointTotalMatchNulAway()
        {
            FrenchLeague1PointSystem fr = FrenchLeague1PointSystem.Instance;
            Match m = new Match(new Club("Bordeaux"), new Club("Marseille"), 2, 2);
            bool home = false;

            Assert.AreEqual("Points : 1 Goal average : 0", fr.GetPointsFromMatch(m, home).ToString());
        }

    }
}
