﻿namespace MvcEticaret.Models
{
    public class ProductItemModel
    {
        public bool IsOption { get; set; } 
        public string? Title { get; set; }
        public int StarCount { get; set; }
        public decimal OldPrice { get; set; }
        public decimal Price { get; set; }
        public required string ImageUrl { get; set; }
        public bool IsSale { get; set; }
    }
}