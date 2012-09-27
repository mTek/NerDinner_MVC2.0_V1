using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace IEnumerable_IEnumerator.MyIEnumerable
{
    public class Employee
    {
        public Employee(string fName, string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
        }
        public string firstName;
        public string lastName;
    }
    public class Employees<T> : IEnumerable<T>
    {
        List<T> empList = new List<T>();
        public int Length { get { return empList.Count; } }
        public void Add(T e)
        {
            empList.Add(e);
        }
        public void AddEmployee(T e)
        {
            empList.Add(e);
        }
        public T GetEmployee(int index)
        {
            return empList[index];
        }
        //IEnumerator<T> IEnumerable<T>.GetEnumerator()
        //{
        //    return empList.GetEnumerator();
        //}
        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return empList.GetEnumerator();
        //}

        public IEnumerator<T> GetEnumerator()
        {
            return empList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return empList.GetEnumerator();
        }
    }
}

