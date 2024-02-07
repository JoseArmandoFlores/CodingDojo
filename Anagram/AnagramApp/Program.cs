using AnagramApp.Services;
using AnagramApp.Services.Abstractions;
using System.Diagnostics;

Stopwatch timer = new Stopwatch();
timer.Start();
Console.WriteLine("Anagram Word");
IAlgorithmService algorithmService = new AlgorithmService();
IWordService WordService = new WordService();
List<string> words = await WordService.GetWords();
int counter = 0;
List<string[]> anagramsWords = algorithmService.FindAnagrams(words).ToList();
timer.Stop();
foreach (string[] anagrams in anagramsWords)
{
    counter++;
    Console.WriteLine($"{counter}: {string.Join(" ", anagrams)}");
}
Console.WriteLine($"");