using AnagramApp.Services.Abstractions;

namespace AnagramApp.Services
{
    public class AlgorithmService : IAlgorithmService
    {
        public IEnumerable<string[]> FindAnagrams(IEnumerable<string> candidates)
        {
            if (null == candidates) throw new ArgumentNullException(nameof(candidates));

            IEnumerable<IGrouping<string, string>> anagramGrouped = candidates.GroupBy(word => string.Concat(word.ToLower().OrderBy(c => c)));
            IEnumerable<IGrouping<string, string>> groupByAnagramCount = anagramGrouped.Where(group => group.Count() > 1);
            IEnumerable<string[]> result = groupByAnagramCount.Select(group => group.OrderBy(word => word).ToArray());
            return result;
        }
    }
}