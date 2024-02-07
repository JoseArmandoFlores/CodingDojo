namespace AnagramApp.Services
{
    public class FileReader
    {
        public static async Task<List<string>> GetWords()
            => (await File.ReadAllLinesAsync(@"words.txt")).ToList();
    }
}