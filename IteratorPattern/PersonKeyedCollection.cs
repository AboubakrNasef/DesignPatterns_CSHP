using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    record Person(int id,string Name);
    internal class PersonKeyedCollection : KeyedCollection<int, Person>
    {
        protected override int GetKeyForItem(Person person)
        {
           return person.id;
        }
    }
}
