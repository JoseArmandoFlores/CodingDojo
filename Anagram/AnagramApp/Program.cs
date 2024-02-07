using AnagramApp.Services;

Console.WriteLine("Anagram Word");

List<string> words = await FileReader.GetWords();
int counter = 0;
List<string[]> anagramsWords = AnagramAlgorithm.FindAnagrams(words).ToList();
foreach (string[] anagrams in anagramsWords)
{
    counter++;
    Console.WriteLine($"{counter}: {string.Join(" ", anagrams)}");
}