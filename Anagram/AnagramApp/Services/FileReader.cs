using AnagramApp.Interfaces

namespace AnagramApp.Services
{
    public class FileReader : IFileReader
    {
        public static async Task<List<string>> GetWords()
            => (await File.ReadAllLinesAsync(@"words.txt")).ToList();
    }
}