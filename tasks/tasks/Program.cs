List<Task<int>> tasks = Enumerable.Range(1, 10).Select(Calculate).ToList();

await foreach (var task in Task.WhenEach(tasks))
{
    Console.WriteLine(await task);
}

async Task<int> Calculate(int order)
{
    var number = Random.Shared.Next(500, 5000);
    await Task.Delay(number);
    return order;
}