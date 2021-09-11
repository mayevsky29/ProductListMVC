using AppProductList.Data;
using AppProductList.Data.Entities;
using AppProductList.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AppProductList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
       public EFAppContext _context { get; set; }
        public HomeController(ILogger<HomeController> logger, EFAppContext context)
        {
            _logger = logger;
            _context = context;
        }

    

    public IActionResult Index()
        {
            return View(_context.Products.Include(x => x.Images).Select(x => new ProductItemViewModel
            {
                Name = x.Name,
                Price = x.Price,
                Id = x.Id,
                Images = x.Images.Select(x => new ProductImageItemVM
                {
                    Path = x.Name,
                }).ToList()
            }).ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductAddViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            Product product = new Product();
            product.Name = model.Name;
            product.Price = model.Price;
            _context.Products.Add(product);
            _context.SaveChanges();

            List<ProductImage> images = new List<ProductImage>();
            foreach (var item in model.Images)
            {
                string ext = Path.GetExtension(item.FileName);
                string fileName = Path.GetRandomFileName() + ext;

                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "products", fileName);
                using (var stream = System.IO.File.Create(filePath))
                {
                    item.CopyTo(stream);
                }
                ProductImage productImage = new ProductImage
                {
                    Name = fileName,
                    Product = product
                };
                images.Add(productImage);
            }
            _context.ProductImages.AddRange(images);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        

        [HttpGet]
        public IActionResult Edit(int id)
        {

            var resultItem = _context.Products.FirstOrDefault(x => x.Id == id);
            var resultImage = _context.ProductImages.Where(c => c.ProductId == id).ToList();

            ProductUpdateVM modalUpdate = new();
            modalUpdate.Id = resultItem.Id;
            modalUpdate.Name = resultItem.Name;
            modalUpdate.Price = resultItem.Price;
            modalUpdate.productImages = resultImage;

            if (resultItem != null)
            {
                return View(modalUpdate);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, ProductUpdateVM modalUpdate)
        {

            if (ModelState.IsValid)
            {
                var productItem = _context.Products.FirstOrDefault(x => x.Id == id);

                productItem.Name = modalUpdate.Name;
                productItem.Price = modalUpdate.Price;

                _context.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(long id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                List<ProductImage> images = _context
                    .ProductImages.Where(x => x.ProductId == product.Id).ToList();

                foreach (var image in images)
                {
                    string imgName = Path.Combine(Directory.GetCurrentDirectory(), "images", image.Name);
                    if (System.IO.File.Exists(imgName))
                    {
                        System.IO.File.Delete(imgName);
                    }

                    _context.ProductImages.Remove(image);
                }
                _context.SaveChanges();

                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            return Ok();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
