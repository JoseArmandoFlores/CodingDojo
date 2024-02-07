namespace AnagramApp.Interfaces
{
    public interface IFileReader
    {
        Task<List<string>> GetWords();
    }
}