using AnagramApp.Interfaces;

namespace AnagramApp.Services
{
    public class FileReader : IFileReader
    {
        public async Task<List<string>> GetWords()
            => (await File.ReadAllLinesAsync(@"words.txt")).ToList();
    }
}