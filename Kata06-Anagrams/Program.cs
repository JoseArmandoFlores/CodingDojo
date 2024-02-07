
int counter = 0;
var data = (await File.ReadAllLinesAsync(@"wordlist.txt")).ToList();
var words = data
        ?.GroupBy(word => string.Concat(word.OrderBy(c => c)))
        .Where(group => group.Count() > 1)
        .Select(group => group.OrderBy(word => word).ToArray())
        ?? throw new ArgumentNullException(nameof(data));


foreach (var anagram in words)
{
    counter++;
    Console.WriteLine($"Cantidad: {counter} Resultado: {string.Join(" ", anagram)}");
}

