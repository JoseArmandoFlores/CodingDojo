using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Kata06_Anagrams;
using System.Collections.Generic;

namespace Kata06_Anagrams.Test
{
    [TestClass]
    public class AnagramsTests
    {
        [TestMethod]
        public async void When_PassedValidAnagrams_GetAnagrams_ShouldReturnAnagrams()
        {
            // Arrange
            var wordlist = new List<string> { "act", "cat", "dog", "god", "tea", "ate", "eat" };
            var expectedAnagrams = new List<string[]>
            {
                new string[] { "act", "cat" },
                new string[] { "dog", "god" },
                new string[] { "ate", "eat", "tea" }
                // Add more expected anagrams if needed
            };

            // Act
            var actualAnagrams = Anagrams.GetAnagrams(wordlist);

            // Assert
            Assert
            Assert.NotNull(actualAnagrams);

            Assert.Equal(expectedAnagrams.Count, actualAnagrams.Count());

            foreach (var expectedAnagram in expectedAnagrams)
            {
                Assert.Contains(expectedAnagram.ToHashSet(), actualAnagrams.Select(a => a.ToHashSet()));
            }
        }
    }
}
