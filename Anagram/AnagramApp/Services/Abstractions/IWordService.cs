namespace AnagramApp.Services.Abstractions
{
    public interface IWordService
    {
        Task<List<string>> GetWords();
    }
}