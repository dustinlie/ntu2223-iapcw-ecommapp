﻿namespace iapCoursework2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ProductImg { get; set; }
        public string ProductIcon { get;  set; }
        public Category Category { get; set; }
    }
}
