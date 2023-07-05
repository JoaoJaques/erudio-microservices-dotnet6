﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GeekShopping.ProductAPI.Data.ValueObjects
{
    public class ProductVO
    {
       
        public long Id { get; set; }

        public string Name { get; set; } = string.Empty;
       
        public decimal Price { get; set; }

        public string Description { get; set; } = string.Empty;

        public string CategoryName { get; set; } = string.Empty;

        public string ImageURL { get; set; } = string.Empty;
    }
}
