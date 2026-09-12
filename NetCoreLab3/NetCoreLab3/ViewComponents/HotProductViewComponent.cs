using Microsoft.AspNetCore.Mvc;
using NetCoreLab3.Models;
using System.Collections.Generic;

namespace NetCoreLab3.ViewComponents
{
    public class HotProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Id = 4,
                    Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                    Image = "/images/com.jpg",
                    Price = 2500000
                },

                new Product
                {
                    Id = 5,
                    Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                    Image = "/images/com.jpg",
                    Price = 2500000
                },

                new Product
                {
                    Id = 6,
                    Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                    Image = "/images/com.jpg",
                    Price = 2500000
                }
            };

            return View(products);
        }
    }
}