using Microsoft.AspNetCore.Mvc;

namespace MvcEticaret.Components
{
	public class ProductItem : ViewComponent
	{
		public IViewComponentResult Invoke(string title, int starCount, decimal oldPrice, decimal price, string imageUrl, bool isSale)
        {
            var model = new ProductItemModel
            {
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
