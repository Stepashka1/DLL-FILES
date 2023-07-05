// Product.cs Выполнил студент группы 34ИС Родионов Степан
using System;

namespace RodionovStepan34is.Library
{
    public class Product : IComparable
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public void Show()
        {
            Console.WriteLine($"Product: {Name}, Number: {Number}");
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Product otherProduct = obj as Product;
            if (otherProduct != null)
                return this.Number.CompareTo(otherProduct.Number);
            else
                throw new ArgumentException("Object is not a Product");
        }
    }
}