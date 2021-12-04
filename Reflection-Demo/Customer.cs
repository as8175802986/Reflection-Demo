using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Demo
{
    class Customer
    {
        public int Id
        {
            get;
            set;
        }
        public string ClassName
        {
            get;
            set;
        }
        public Customer(int id, string name)
        {
            this.Id = id;
            this.ClassName = name;
        }
        public Customer()
        {
            this.Id = -1;
            this.ClassName = string.Empty;
        }
        public void PrintId()
        {
            Console.WriteLine("Id is:{0}", this.Id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name is:{0}", this.ClassName);
        }
    }
}
