using System;
using ServiceStack.Redis;

namespace RedisCache
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = "localhost:6379";
            var cpf = "123.456.789.12";

            var customer = new Customer(cpf) { Document = "15114818", Name = "Fulano" };
        
            using (var redisCustumer = new RedisClient(host))
            {
                redisCustumer.Set<Customer>(cpf, customer, new TimeSpan(0, 0, 50));

                var customerInf = redisCustumer.Get<Customer>(cpf);
            }
        }
    }
}
