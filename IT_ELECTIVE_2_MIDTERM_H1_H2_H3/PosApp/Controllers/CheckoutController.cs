using Microsoft.AspNetCore.Mvc;
using PosApp.DTOs;
using PosApp.Models;
using PosApp.Services;
using System;
using System.Linq;

namespace PosApp.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            if (!InMemoryDatabase.ActiveCart.Items.Any())
            {
                TempData["ErrorMessage"] = "Cannot checkout with an empty cart.";
                return RedirectToAction("Index", "Cart");
            }
            return View(new CheckoutFormDTO());
        }

        [HttpPost]
        public IActionResult CompleteCheckout(CheckoutFormDTO dto)
        {
            if (!InMemoryDatabase.ActiveCart.Items.Any())
            {
                ModelState.AddModelError("", "Your shopping cart is empty.");
                return View("Index", dto);
            }

            if (!ModelState.IsValid)
            {
                return View("Index", dto);
            }
            foreach (var cartItem in InMemoryDatabase.ActiveCart.Items)
            {
                var product = InMemoryDatabase.Products.FirstOrDefault(p => p.Id == cartItem.ProductId);
                if (product != null)
                {
                    product.StockQuantity -= cartItem.Quantity;
                }
            }
            var transaction = new Transaction
            {
                TransactionId = Guid.NewGuid(),
                Date = DateTime.Now,
                CustomerName = dto.CustomerName,
                CustomerEmail = dto.CustomerEmail,
                TotalAmount = InMemoryDatabase.ActiveCart.GrandTotal,
                PurchasedItems = InMemoryDatabase.ActiveCart.Items.ToList()
            };

            InMemoryDatabase.Transactions.Add(transaction);
            InMemoryDatabase.ActiveCart.Items.Clear();

            return RedirectToAction("Success", new { id = transaction.TransactionId });
        }

        public IActionResult Success(Guid id)
        {
            var tx = InMemoryDatabase.Transactions.FirstOrDefault(t => t.TransactionId == id);
            if (tx == null) return RedirectToAction("Index", "Products");
            return View(tx);
        }

        public IActionResult History()
        {
            return View(InMemoryDatabase.Transactions);
        }

        public IActionResult Details(Guid id)
        {
            var tx = InMemoryDatabase.Transactions.FirstOrDefault(t => t.TransactionId == id);
            if (tx == null) return NotFound();
            return View(tx);
        }
    }
}