using AppProductList.Data.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppProductList.Models
{
    public class ProductItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<ProductImageItemVM> Images { get; set; }
    }
    public class ProductImageItemVM
    {
        public string Path { get; set; }
    }

    public class ProductAddViewModel
    {
        public int Id { get; set; }
        [Display(Name="Назва")]
        public string Name { get; set; }
        [Display(Name="Ціна")]
        public decimal Price { get; set; }
        [Display(Name="Фоточка :)")]
        public List<IFormFile> Images { get; set; }
    }
    public class ProductDeleteVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<ProductImage> productVM { get; set; }
    }
    public class ProductUpdateVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<ProductImage> productImages { get; set; }
        public List<IFormFile> Image { get; set; }
    }
}
