//getting data

using System.Text.Json;

var stringData = await File.ReadAllTextAsync("data/linq_data_1.json");
var persons = JsonSerializer.Deserialize<List<Person>>(stringData);

var personsCount = persons?.CountBy(x => x.Job);
foreach (var personCount in personsCount)
{
    Console.WriteLine($"{personCount.Key} : {personCount.Value}");
}

//results:
//Frontend : 3
//Backend : 2

var personsAggregated = persons
    .AggregateBy(keySelector: x => x.Job,
        seed: 0m,
        (totalValue, person) => totalValue + (person.Payment * person.Experience));

foreach (var personAggregate in personsAggregated.Index())
{
    Console.WriteLine($"{personAggregate.Index + 1}: {personAggregate.Item.Key} : {personAggregate.Item.Value}");
}

//results
//1: Frontend : 31200
//2: Backend : 61000


public sealed record Person(int Id, string Name, string Job, int Payment, int Experience); 