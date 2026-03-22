using Microsoft.AspNetCore.Mvc;

namespace ViewComponentExample.ViewComponents
{
    public class GridViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            return View("Default"); // invoke a partial view
                           // Views/Shared/Components/Grid/Default.cshtml
        }
    }
}
