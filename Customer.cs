using System;
using System.Collections.Generic;
using System.Text;

namespace RedisCache
{
    public class Customer
    {
        public Customer(string cpf)
        {
            Cpf = cpf;
        }

        public string Cpf { get; private set; }
        public string Name { get; set; }
        public string Document { get; set; }
    }
}
