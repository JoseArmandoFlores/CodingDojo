using AnagramApp.Services;
using AnagramApp.Services.Abstractions;
using System.Diagnostics;

Stopwatch timer = new();
timer.Start();
Console.WriteLine("Anagram Word");
IAlgorithmService algorithmService = new AlgorithmService();
IWordService WordService = new WordService();
IAnagramService anagramService = new AnagramService(algorithmService, WordService);
IEnumerable<string[]> anagramsWords = await anagramService.ProcessAnagrams();
timer.Stop();
int counter = 0;
foreach (string[] anagrams in anagramsWords)
{
    counter++;
    Console.WriteLine($"{counter}: {string.Join(" ", anagrams)}");
}
Console.WriteLine($"TotalTime(seconds): {timer.Elapsed.TotalSeconds}");