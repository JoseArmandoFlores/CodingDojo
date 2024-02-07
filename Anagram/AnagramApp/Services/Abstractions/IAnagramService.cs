namespace AnagramApp.Services.Abstractions
{
    public interface IAnagramService
    {
        Task<IEnumerable<string[]>> ProcessAnagrams();
    }
}