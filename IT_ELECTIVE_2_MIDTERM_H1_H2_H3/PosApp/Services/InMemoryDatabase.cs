using PosApp.Models;
using System.Collections.Generic;

namespace PosApp.Services
{
    public static class InMemoryDatabase
    {
        public static List<Product> Products { get; set; } = new List<Product>
        {
            new Product { Id = 1, Name = "Super Mario Bros (NES)", Price = 49.99m, StockQuantity = 5 },
            new Product { Id = 2, Name = "The Legend of Zelda (SNES)", Price = 59.99m, StockQuantity = 2 },
            new Product { Id = 3, Name = "Sonic the Hedgehog (Genesis)", Price = 34.99m, StockQuantity = 0 }, // Out of stock item
            new Product { Id = 4, Name = "Pokémon Red (GameBoy)", Price = 89.99m, StockQuantity = 8 },
            new Product { Id = 5, Name = "Chrono Trigger (SNES)", Price = 120.00m, StockQuantity = 1 },
            new Product { Id = 6, Name = "Castlevania: Symphony of the Night (PS1)", Price = 75.00m, StockQuantity = 4 },
            new Product { Id = 7, Name = "Halo: Combat Evolved (Xbox)", Price = 25.00m, StockQuantity = 12 },
            new Product { Id = 8, Name = "Final Fantasy VII (PS1)", Price = 65.00m, StockQuantity = 3 }
        };

        public static ShoppingCart ActiveCart { get; set; } = new ShoppingCart();
        public static List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}