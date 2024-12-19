using IteratorPattern;
using System.Collections.Concurrent;

var list = new List<string>() {"a","b","c","d","e","f","g"};
var bag = new ConcurrentBag<string>() {"a","b","c","d","e","f","g"};
var keyedCollection = new PersonKeyedCollection() {new Person(1,"ahmed"), new Person(3, "ahmed") , new Person(2, "ahmed") };
var where = keyedCollection.Where(x => x.Name == "ahmed");
//foreach (var item in keyedCollection)
//{
//    Console.WriteLine(item);
//}
var lsssst =where.ToList();
var enumerator = list.GetEnumerator();
while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}