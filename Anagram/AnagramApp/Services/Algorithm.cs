namespace Anagram
{
    internal class Algorithm
    {
        public static IEnumerable<string[]> FindAnagrams(IEnumerable<string> candidates)
        {
            if (null == candidates) throw new ArgumentNullException(nameof(candidates));

            IEnumerable<IGrouping<string, string>> anagramGrouped = candidates.GroupBy(word => string.Concat(word.OrderBy(c => c)));
            IEnumerable<IGrouping<string, string>> groupByAnagramCount = anagramGrouped.Where(group => group.Count() > 1);
            IEnumerable<string[]> result = groupByAnagramCount.Select(group => group.OrderBy(word => word).ToArray());
            return result;
        }
    }
}
