using System;
using System.Collections.Generic;

namespace _12_Employee
{
    internal class EmployeeRepository
    {
        List<Employee> le = new List<Employee>();
        int i = 0;
        public int Id = 0;
        internal void Clear()
        {
            le.Clear();
            i = 0;
        }

        internal int CountEmployees()
        {
            foreach (Employee l in le)
            {
                i++;
            }
            return i;
        }

        internal int newint()
        {
            return Id++;
        }

        internal Employee CreateEmployee(string v1, string v2)
        {
            newint();
            Employee e = new Employee();
            e.Name = v1;
            e.Type = v2;
            e.Id = Id;
            le.Add(e);
            return e;
        }

        internal void SaveEmployee(Employee simon)
        {
            
        }
       

        internal Employee LoadEmployee(int id)
        {
            Employee emp = new Employee();
            foreach (Employee l in le)
            {
               if (l.Id  == id)
                {
                    emp = l;
                }
            }
            return emp;
        }

        internal List<Employee> FindAllEmployees()
        {
            return le;
        }
    }
}