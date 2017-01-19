using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf2
{
    class Controler
    {
        private static Controler instance;
        private Repository repository;
        public Person CurentPerson { get; private set; }
        public int PerconCount { get; private set; }
        public int PersonIndex { get; private set; }

        private Controler()
        {
            CurentPerson = null;
            repository = new Repository();
            PerconCount = 0;
            PersonIndex = -1;
        }
        public static Controler GetInstance()
        {
            if (instance== null)
            {
                instance = new Controler();
            }
            return instance;
        }

        public void AddPerson()
        {
            Person percon = new Person();
            CurentPerson = percon;
            repository.AddPerson(percon);
            PerconCount = repository.PersonList.Count();
            PersonIndex = PerconCount-1;
        }
        public void NewPerson (Person p)
        {
            repository.AddPerson(p);
            PerconCount = repository.PersonList.Count();
            PersonIndex = PerconCount - 1;
        }
        public void DeletePerson()
        {
            if (CurentPerson != null)
            {
                repository.RemovePerson(CurentPerson);
                PersonIndex--;
                PerconCount = repository.PersonList.Count();
                CurentPerson = repository.GetPersonAtIndex(PersonIndex);
            }
        }

        public void NextPerson()
        {
            if (PersonIndex < PerconCount - 1)
            {
                PersonIndex++;
                CurentPerson = repository.GetPersonAtIndex(PersonIndex);
            }
        }
        public void PrevPerson()
        {
            if (PersonIndex > 0)
            {
                PersonIndex--;
                CurentPerson = repository.GetPersonAtIndex(PersonIndex);
            }
        }


    }
}
