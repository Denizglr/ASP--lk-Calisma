using Microsoft.AspNetCore.Mvc;
using Ödev1.Models; 
namespace Ödev1.Controllers
{
    public class ProductController : Controller
    {
        // Verilerin kaybolmaması için static liste kullandım
        private static List<Product> _products = new List<Product>
        {
            // Test için içine örnek bir veri atadım
            new Product { Id = 1, Name = "Örnek Ruj", Category = "Makyaj", Price = 150, Description = "Kaliteli bir ürün" }
        };

        // 1. Listeleme Sayfası
        public IActionResult ProductList()
        {
            return View(_products);
        }

        // 2. Ekleme Sayfası (Sayfayı açar)
        [HttpGet]// get kullandım çünkü urldeki bilgiler herkese açık olsun istedim.
        public IActionResult ProductAdd()
        {
            return View();
        }

        // 2. Ekleme İşlemi (Form gönderilince çalışır)
        [HttpPost]//post ise url yi gizliyor o yüzden kullandım
        public IActionResult ProductAdd(Product product)
        {
            product.Id = _products.Count > 0 ? _products.Max(p => p.Id) + 1 : 1;
            _products.Add(product);
            return RedirectToAction("ProductList");
        }

        // 3. Detay Sayfası
        public IActionResult ProductDetay(int id)
        {
            var urun = _products.FirstOrDefault(x => x.Id == id);
            return View(urun);
        }

        // 4. Silme ve Düzenleme Listesi (Tablo hali)
        public IActionResult ProductDV()
        {
            return View(_products);
        }

        // 5. Silme İşlemi
        public IActionResult ProductDelete(int id)
        {
            var urun = _products.FirstOrDefault(x => x.Id == id);
            if (urun != null) _products.Remove(urun);
            return RedirectToAction("ProductDV");
        }
    }
}