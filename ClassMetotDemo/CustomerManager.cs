using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.FirstName} {customer.LastName} isim müşteri eklendi.\n");
        }

        public void UpdateAddress(Customer customer, string address)
        {
            Console.WriteLine($"{customer.FirstName} {customer.LastName} isim müşterinin adresi {address} olarak güncellendi.\n");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine($"{customer.FirstName} {customer.LastName} isim müşteri silindi.\n");
        }

        public void Get(Customer customer)
        {
            Console.WriteLine($"Id: {customer.Id}");
            Console.WriteLine($"İsim: {customer.FirstName}");
            Console.WriteLine($"Soyisim: {customer.LastName}");
            Console.WriteLine($"Adres: {customer.Address}");
            Console.WriteLine("\n");
        }
    }
}
