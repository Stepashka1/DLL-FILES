// Store.cs Выполнил студент группы 34ИС Родионов Степан
using System;
using System.Collections.Generic;

namespace RodionovStepan34is.Library
{
    public class Store
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Product> Products { get; set; }

        public Store()
        {
            Products = new List<Product>();
        }

        public void ShowAll()
        {
            Console.WriteLine($"Store: {Name}, Address: {Address}");
            foreach (Product product in Products)
            {
                product.Show();
            }
        }
    }
}