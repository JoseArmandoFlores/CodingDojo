namespace Anagram
{
    public class FileReader
    {
        public async static Task<List<string>> GetWords()
            => (await File.ReadAllLinesAsync(@"words.txt")).ToList();
    }
}
