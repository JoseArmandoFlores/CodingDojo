
namespace Kata06_Anagrams.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Anagrams.GetAnagrams();
            Assert.Pass();
        }
    }
}