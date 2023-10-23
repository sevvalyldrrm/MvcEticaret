using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;
using System.Diagnostics;

namespace MvcEticaret.Controllers
{
    public class HomeController : Controller
	{
		//method oluşturduk
		private List<ProductItemModel> GetSampleProducts()
		{
			var products = new List<ProductItemModel>
		{
			new ProductItemModel
		{
			IsOption = true,
			Title = "Yağmurluk",
			StarCount = 0,
			OldPrice = 19.99m,
			Price = 39.99m,
			ImageUrl = "https://st-thenorthface.mncdn.com/Content/media/ProductImg/original/638272004368117679.jpg",
			IsSale = false
		},
			new ProductItemModel
		{
				IsOption = false,
			Title = "Kamp Çadırı",
			StarCount = 5,
			OldPrice = 29.99m,
			Price = 19.99m,
			ImageUrl = "https://st-thenorthface.mncdn.com/Content/media/ProductImg/original/638154059507771574.jpg",
			IsSale = true
		},
				new ProductItemModel
		{
			IsOption = true,
			Title = "Suluk Çantası",
			StarCount = 0,
			OldPrice = 39.99m,
			Price = 29.99m,
			ImageUrl = "https://st-thenorthface.mncdn.com/Content/media/ProductImg/original/638271992678926764.jpg",
			IsSale = true
		},
				new ProductItemModel
		{
			IsOption = false,
			Title = "Kamp Çantası",
			StarCount = 4,
			OldPrice = 0m,
			Price = 39.99m,
			ImageUrl = "https://st-thenorthface.mncdn.com/Content/media/ProductImg/original/636734978447063571.jpg",
			IsSale = false
		},
				new ProductItemModel
		{
			IsOption = false,
			Title = "Kar Şapkası",
			StarCount = 0,
			OldPrice = 19.99m,
			Price = 9.99m,
			ImageUrl = "https://st-thenorthface.mncdn.com/Content/media/ProductImg/original/638271027307556807.jpg",
			IsSale = true
		},
				new ProductItemModel
		{
			IsOption = true,
			Title = "Yağmurluk",
			StarCount = 0,
			OldPrice = 29.99m,
			Price = 59.99m,
			ImageUrl ="https://st-thenorthface.mncdn.com/Content/media/ProductImg/original/638304374276601201.jpg",
			IsSale = false
		},
				new ProductItemModel
		{
			IsOption = false,
			Title = "Kadın Ayakkabı",
			StarCount = 5,
			OldPrice = 59.99m,
			Price = 39.99m,
			ImageUrl = "https://st-thenorthface.mncdn.com/Content/media/ProductImg/original/638029167052281948.jpg",
			IsSale = true
		},
				new ProductItemModel
		{
			IsOption = false,
			Title = "Unisex Eldiven",
			StarCount = 5,
			OldPrice = 0m,
			Price = 89.99m,
			ImageUrl = "https://st-thenorthface.mncdn.com/Content/media/ProductImg/original/638029172066220024.jpg",
			IsSale = false
		}
	    };
			return products;
		}

		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		//methodu index'e gönderdik
		public IActionResult Index()
		{
			var products = GetSampleProducts();
			return View(products);
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