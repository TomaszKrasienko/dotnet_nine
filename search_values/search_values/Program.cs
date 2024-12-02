using System.Buffers;

SearchValues<string> searchValues = SearchValues.Create(["Tomasz", "Jakub", "Marcin"], StringComparison.OrdinalIgnoreCase);

Console.WriteLine(
    MemoryExtensions.ContainsAny(["tomasz", "stefan"], searchValues)
);
