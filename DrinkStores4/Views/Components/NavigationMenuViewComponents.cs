using Microsoft.AspNetCore.Mvc;

namespace DrinkStores.Views.Components
{
    public class NavigationMenuViewComponents : ViewComponent //tạo view components để có thể sử dụng lại trong các trang web
    {
        public string Invoke()
        {
            return "Hello from the NGuyen Giang SOn Page";
        }
    }
}
