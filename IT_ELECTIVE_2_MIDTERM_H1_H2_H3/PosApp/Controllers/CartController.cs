using Microsoft.AspNetCore.Mvc;
using PosApp.DTOs;
using PosApp.Models;
using PosApp.Services;
using System.Linq;

namespace PosApp.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View(InMemoryDatabase.ActiveCart);
        }

        [HttpPost]
        public IActionResult AddToCart(AddToCartDTO dto)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Invalid quantity specified.";
                return RedirectToAction("Index", "Products");
            }

            var product = InMemoryDatabase.Products.FirstOrDefault(p => p.Id == dto.ProductId);
            if (product == null) return NotFound();

            var existingItem = InMemoryDatabase.ActiveCart.Items.FirstOrDefault(i => i.ProductId == dto.ProductId);
            int currentQty = existingItem?.Quantity ?? 0;

            if (currentQty + dto.Quantity > product.StockQuantity)
            {
                TempData["ErrorMessage"] = $"Cannot add {dto.Quantity} units. Only {product.StockQuantity - currentQty} available in stock.";
                return RedirectToAction("Index", "Products");
            }

            if (existingItem != null)
            {
                existingItem.Quantity += dto.Quantity;
            }
            else
            {
                InMemoryDatabase.ActiveCart.Items.Add(new CartItem
                {
                    ProductId = product.Id,
                    ProductName = product.Name,
                    UnitPrice = product.Price,
                    Quantity = dto.Quantity
                });
            }

            TempData["SuccessMessage"] = $"Added {product.Name} to cart.";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateQuantity(UpdateCartDTO dto)
        {
            var cartItem = InMemoryDatabase.ActiveCart.Items.FirstOrDefault(i => i.ProductId == dto.ProductId);
            var product = InMemoryDatabase.Products.FirstOrDefault(p => p.Id == dto.ProductId);

            if (cartItem == null || product == null) return RedirectToAction("Index");

            if (dto.Quantity > product.StockQuantity)
            {
                TempData["ErrorMessage"] = $"Requested quantity exceeds available stock ({product.StockQuantity}).";
                return RedirectToAction("Index");
            }

            cartItem.Quantity = dto.Quantity;
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remove(int productId)
        {
            var item = InMemoryDatabase.ActiveCart.Items.FirstOrDefault(i => i.ProductId == productId);
            if (item != null)
            {
                InMemoryDatabase.ActiveCart.Items.Remove(item);
            }
            return RedirectToAction("Index");
        }
    }
}