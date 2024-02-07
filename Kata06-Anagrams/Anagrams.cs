using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata06_Anagrams
{
    public static class Anagrams
    {
        public async static Task GetAnagrams()
        {
            int counter = 0;
            var data = (await File.ReadAllLinesAsync(@"wordlist.txt")).ToList();
            var words = GetAnagrams(data);

            foreach (var anagram in words)
            {
                counter++;
                Console.WriteLine($"Cantidad: {counter} Resultado: {string.Join(" ", anagram)}");
            }
        }
        
        public static IEnumerable<string[]> GetAnagrams(List<string> wordlist)
        {
            return wordlist
                    ?.GroupBy(word => string.Concat(word.OrderBy(c => c)))
                    .Where(group => group.Count() > 1)
                    .Select(group => group.OrderBy(word => word).ToArray())
                    ?? throw new ArgumentNullException(nameof(wordlist));
        }
    }
}
