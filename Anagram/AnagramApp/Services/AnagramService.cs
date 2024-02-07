using AnagramApp.Services.Abstractions;

namespace AnagramApp.Services
{
    public class AnagramService : IAnagramService
    {
        private readonly IAlgorithmService _algorithmService;
        private readonly IWordService _wordService;

        public AnagramService(IAlgorithmService algorithmService, IWordService wordService)
        {
            _algorithmService = algorithmService;
            _wordService = wordService;
        }

        public async Task<IEnumerable<string[]>> ProcessAnagrams()
        {
            List<string> words = await _wordService.GetWords();
            IEnumerable<string[]> result = _algorithmService.FindAnagrams(words);
            return result;
        }
    }
}