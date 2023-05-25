using WordLib;
namespace WordLibTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WorderIsPalindrome()
        {
            Worder worder = new Worder();


            string expectedResult = "nitin"; //Shows expected outcome
            string input = "nitin"; //Acts as an input, in this case hardcoded, but in a real scenario it would be an input from a user
            string actualResult = worder.PalindromeChecker(input); //Sends the input to the PalindromeChecker in the class1.cs and returns the reversed string
            //Assert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual(expectedResult, actualResult); //Checks if the expected result and the returned value are the same
            //Skicka jämförelse från klass som reversas 
        }
        [TestMethod]
        public void WorderCheckLength()
        {
            Worder worder = new Worder();
            int expectedResult = 10; //Expected length of a word
            string input = "nitinnitin"; //wordinput
            string actualResult = worder.LengthChecker(input); //Sends wordinput to LengthChecker in class1.cs and returns the length
            Assert.AreEqual(expectedResult, int.Parse(actualResult)); //Checks the two to see if it is accurate


        }

    }
}