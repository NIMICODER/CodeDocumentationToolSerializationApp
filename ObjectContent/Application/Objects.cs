using System;
using System.Collections.Generic;
using System.Text;
using static ObjectContent.CustomDocumentDescriptionAttribute.DocumentAttribute;

namespace ObjectContent.Application
{
    [Description("This class holds all the implementation for getting information about Object.")]
    internal class Objects
    {

        [Description("This is id property")]
        public Guid _Id { get; set; }

        [Description("This is the User name property")]
        public string _Name { get; set; }
        public long _PhoneNumber { get; set; }

        public Objects()
        {

        }

        public Objects(Guid id, string name, long phoneNumber)
        {

            _Id = id;
            _Name = name;
            _PhoneNumber = phoneNumber;
        }

        [Description("This method performs a calculation.", "The input is a number.", "The output is the square of the input.")]
        public int Square(int number)
        {
            return number * number;
        }
    }

    [Description("This class holds all information about the product model.")]
    public class Product
    {
        [Description("This is the Product id property")]
        public Guid _Id { get; set; }
        public string _Name { get; set; }
        public int _Quantity { get; set; }
        public decimal _Price { get; set; }
        public string _Category { get; set; }
        public int _OrderCount { get; set; }


        public Product()
        {

        }

        public Product(Guid id, string name, int quantity, decimal price, string category, int orderCount)
        {
            _Id = id;
            _Name = name;
            _Quantity = quantity;
            _Price = price;
            _Category = category;
            _OrderCount = orderCount;

        }


    }

    [Description("This enum holds option for food selection.")]
    enum Foods
    {
        [EnumDescription("Value 1 Description for FriedRice")]
        FriedRice,
        [EnumDescription("Value 2 Description for JollofRice")]
        JollofRice,
        [EnumDescription("Value 3 Description for EgusiSoup")]
        EgusiSoup
    }
}
