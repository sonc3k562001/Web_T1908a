using Microsoft.AspNetCore.Mvc;
using DrinkStores.Models;
using System.Linq;
using DrinkStores.Models.ViewModels;
namespace DrinkStores.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int PageSize = 3;// số sản phẩm trong một page

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        //public ViewResult Index(int productPage = 1) => //productPage là số trang hiển thị trong lần đầu tiên
        //  View(repository.Products.OrderBy(p => p.ProductID)// Sắp xếp thứ tự sản phẩm theo ID

        // .Skip((productPage -1) * PageSize)//bỏ qua bao nhiêu bản ghi

        // .Take(PageSize)// lấy trang số mấy
        //  );

        //this is cách khác xịn hơn
        public ViewResult Index(int productPage = 1)
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                .OrderBy(p =>p.ProductID)
                .Skip((productPage-1)*PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Count()
                }
            });

    }
}
