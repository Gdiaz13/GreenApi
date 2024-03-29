﻿namespace Green.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Productname { get; set; }
        public string Description { get; set; }
        public string Artistname { get; set; }
        public decimal Unitprice { get; set; }


        public Product() {}


        public Product(string category, string productname, string description, string artistname, decimal unitprice)
        {
            Category = category;
            Productname = productname;
            Description = description;
            Artistname = artistname;
            Unitprice = unitprice;
        }

        public Product(int id, string category, string productname, string description, string artistname, decimal unitprice)
        {
            Id = id;            
            Category = category;
            Productname = productname;
            Description = description;
            Artistname = artistname;
            Unitprice = unitprice;
        }


    }
}
