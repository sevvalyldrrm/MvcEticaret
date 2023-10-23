using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;

namespace MvcEticaret.ViewComponents
{
	public class ProductItemViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string title, int starCount, decimal oldPrice, decimal price, string imageUrl, bool isSale, bool isOption)
        {
            var model = new ProductItemModel
            {
                IsOption = isOption,
                Title = title,
                StarCount = starCount,
                OldPrice = oldPrice,
                Price = price,
                ImageUrl = imageUrl,
                IsSale = isSale
            };

            return View(model);
        }
    }
}
