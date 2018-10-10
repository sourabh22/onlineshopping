


using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using OnlineShoppingApplication.Models;
using OnlineShoppingServices.Models.DB;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShoppingApplication.Controllers
{  
    public class ProductController : Controller
    {
        SearchService searchService;

        public ProductController()
    {
            searchService = new SearchService();
    }
       
        public IActionResult GetProducts(SubCategory subCategory)
        {
            searchService.context = HttpContext;
            var result = searchService.GetProducts(subCategory);
            List<ProductViewModel> model = (from p in result select new ProductViewModel() {
                 CategoryId=p.CategoryId.Value,
                 Price=p.Price.Value,
                 ProductId=p.ProductId,
                 SubCategoryId=p.SubCategoryId.Value, Title=p.Title,
                   
            }).ToList();
            ViewData["products"] = model;
            return View();
        }
        
        [HttpPost]
            public IActionResult AddToCart(ProductViewModel model)
            {
                searchService.context = HttpContext;
          //      var result = HttpContext.Session.GetString("Cart");
                searchService.AddToCart(model);
            string json = HttpContext.Session.GetString("CatSubCat");
            SubCategory subcategory = JsonConvert.DeserializeObject<SubCategory>(json);
               return RedirectToAction("GetProducts",subcategory);

               
            }

    
        public IActionResult ProductCart()
        {
            searchService.context = HttpContext;
            var result=searchService.ProductCart();
            ViewData["products"] = result;
            return View(result); 
        }

        
        public IActionResult ProcessOrder(ProductViewModelCart[] products)
        {
            searchService.context = HttpContext;

            HttpContext.Session.Remove("CatSubCat");
            HttpContext.Session.Remove("Cart");
            string json = JsonConvert.SerializeObject(products);
            HttpContext.Session.SetString("Cart", json);
            return View();
        }
    }
}