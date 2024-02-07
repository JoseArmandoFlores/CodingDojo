using AnagramApp.Services.Abstractions;

namespace AnagramApp.Services
{
    public class WordService : IWordService
    {
        public async Task<List<string>> GetWords()
            => (await File.ReadAllLinesAsync(@"words.txt")).ToList();
    }
}