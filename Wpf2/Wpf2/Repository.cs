using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf2
{
    class Repository
    {
        public List<Person> PersonList { get; private set; }

        public Repository()
        {
            PersonList = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            PersonList.Add(person);
        }

        public Person GetPersonAtIndex(int index)
        {
            Person personResultat = null;
            if (index >= 0 && index < PersonList.Count)
            {
                personResultat = PersonList[index];
            }

            return personResultat;
        }
        public void RemovePersonAtIndex(int index)
        {
            if (index >= 0 && index < PersonList.Count)
            {
                PersonList.RemoveAt(index);
            }
        }
        public void RemovePerson(Person person)
        {
            if (person != null)
            {
                PersonList.Remove(person);
            }
        }

    }
}
