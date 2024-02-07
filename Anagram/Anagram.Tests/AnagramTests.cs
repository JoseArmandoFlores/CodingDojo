namespace Anagram.Tests
{
    using AnagramApp.Services;
    using AnagramApp.Services.Abstractions;
    using FluentAssertions;
    using Moq;

    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void WhenNullWords_ShouldThrowArgumentExceptions()
        {
            AlgorithmService algorithmService = new AlgorithmService();

            Action comparison = () =>
            {
                algorithmService.FindAnagrams(null);
            };
            comparison.Should().ThrowExactly<ArgumentNullException>();
        }

        [TestMethod]
        public async Task WhenNoWords_ShouldReturnNoWords()
        {
            List<string> wordsMock = new() { };
            Mock<IWordService> wordServiceMock = new();
            wordServiceMock.Setup(x => x.GetWords()).ReturnsAsync(wordsMock);
            IAnagramService anagramService = new AnagramService(new AlgorithmService(), wordServiceMock.Object);
            IEnumerable<string[]> result = await anagramService.ProcessAnagrams();
            result.Should().BeEmpty();
        }

        [TestMethod]
        public async Task WhenTwoAnagramWordsOfTenTotalWords_ShouldReturnTwoAnagramWords()
        {
            List<string> wordsMock = new()
            {
                "xxxiv", "xxxvi",
                "zanzes","zazens",
                "yeti","yeuk","yeuks","youk","youks","zaniest",//NoAnagrams
            };
            Mock<IWordService> wordServiceMock = new();
            wordServiceMock.Setup(x => x.GetWords()).ReturnsAsync(wordsMock);
            IAnagramService anagramService = new AnagramService(new AlgorithmService(), wordServiceMock.Object);
            IEnumerable<string[]> result = await anagramService.ProcessAnagrams();
            result.Should().NotBeEmpty();
            result.Count().Should().Be(2);
        }

        [TestMethod]
        public async Task WhenTwoAnagramWordsOfFiveTotalWordsWithUpperCases_ShouldReturnTwoAnagramWords()
        {
            List<string> wordsMock = new()
            {
                "xxXiv", "xxxVi",
                "zaNzes","zaZens",
                "yeti","yeuk","yeuks","youk","youks","zaniest",//NoAnagrams
            };
            Mock<IWordService> wordServiceMock = new();
            wordServiceMock.Setup(x => x.GetWords()).ReturnsAsync(wordsMock);
            IAnagramService anagramService = new AnagramService(new AlgorithmService(), wordServiceMock.Object);
            IEnumerable<string[]> result = await anagramService.ProcessAnagrams();
            result.Should().NotBeEmpty();
            result.Count().Should().Be(2);
        }
    }
}