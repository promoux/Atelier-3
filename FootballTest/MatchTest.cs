using FootballLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FootballTest
{
    
    
    /// <summary>
    ///This is a test class for MatchTest and is intended
    ///to contain all MatchTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MatchTest
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
        ///A test for Away
        ///</summary>
        [TestMethod()]
        public void AwayTest()
        {
            Club c1 = new Club("club");
            Club c2 = new Club("club");
            Match m = new Match(c1,c2,3,3); // TODO: Initialize to an appropriate value 
            Assert.AreEqual(c2, m.Away);
        }

        /// <summary>
        ///A test for Home
        ///</summary>
        [TestMethod()]
        public void HomeTest()
        {
            Club c1 = new Club("club");
            Club c2 = new Club("club");
            Match m = new Match(c1,c2,3,5); // TODO: Initialize to an appropriate value
            Assert.AreEqual(c1, m.Home);
        }

        /// <summary>
        ///A test for AwayGoals
        ///</summary>
        [TestMethod()]
        public void AwayGoalsTest()
        {
            Club c1 = new Club("club");
            Club c2 = new Club("club");
            Match m = new Match(c1, c2, 3, 5);
            Assert.AreEqual(5, m.AwayGoals);
        }

        /// <summary>
        ///A test for HomeGoals
        ///</summary>
        [TestMethod()]
        public void HomeGoalsTest()
        {
            Club c1 = new Club("club");
            Club c2 = new Club("club");
            Match m = new Match(c1, c2, 3, 5);
            Assert.AreEqual(3, m.HomeGoals);
           
        }

        /// <summary>
        ///A test for isAwayForfeit
        ///</summary>
        [TestMethod()]
        public void isAwayForfeitTest()
        {
            Club c1 = new Club("club");
            Club c2 = new Club("club");
            Match m = new Match(c1,c2,true); 
            Assert.AreEqual(false, m.isAwayForfeit);
         
        }

        /// <summary>
        ///A test for isDraw
        ///</summary>
        [TestMethod()]
        public void isDrawTest()
        {
            Club c1 = new Club("bordeaux");
            Club c2 = new Club("marseille");
            Match m = new Match(c1,c2,3,3); // TODO: Initialize to an appropriate value
            Assert.AreEqual(true, m.isDraw);
            
        }

        /// <summary>
        ///A test for isHomeForfeit
        ///</summary>
        [TestMethod()]
        public void isHomeForfeitTest()
        {
            Club c1 = new Club("club");
            Club c2 = new Club("club2");
            Match m = new Match(c1, c2, true);
            Assert.AreEqual(true, m.isHomeForfeit);
        }
    }
}
