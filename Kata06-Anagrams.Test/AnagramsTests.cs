using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Kata06_Anagrams;

namespace Kata06_Anagrams.Test
{
    [TestClass]
    public class AnagramsTests
    {
        [TestMethod]
        public async void When_PassedValidAnagrams_GetAnagrams_ShouldReturnAnagrams()
        {
          

            await Anagrams.GetAnagrams();
        }
    }
}
