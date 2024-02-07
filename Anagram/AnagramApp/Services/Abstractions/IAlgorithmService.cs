namespace AnagramApp.Services.Abstractions
{
    public interface IAlgorithmService
    {
        IEnumerable<string[]> FindAnagrams(IEnumerable<string> candidates);
    }
}