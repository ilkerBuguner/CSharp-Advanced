using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    class Repository
    {
        private Dictionary<int, Person> repo;
        private int id = 0;

        public Repository()
        {
            repo = new Dictionary<int, Person>();
        }

        public int Count => repo.Count;
        public void Add(Person person)
        {
            repo.Add(id, person);
            id++;
        }

        public Person Get(int id)
        {
            Person wantedPerson = null;
            if (repo.ContainsKey(id))
            {
                wantedPerson = repo[id];
            }
            return wantedPerson;
        }

        public bool Update(int id, Person person)
        {
            if (repo.ContainsKey(id))
            {
                repo[id] = person;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            if (repo.ContainsKey(id))
            {
                repo.Remove(id);
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
