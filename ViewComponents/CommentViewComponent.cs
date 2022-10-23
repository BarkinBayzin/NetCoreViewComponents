using Microsoft.AspNetCore.Mvc;
using NetCoreViewComponents.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCoreViewComponents.ViewComponents
{
    public class CommentViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new List<CommentViewModel>
            {
                new CommentViewModel
                {
                    Comment = "Deneme",
                    CommentBy = "Barkın",
                    CommentDate = System.DateTime.Now
                },
                 new CommentViewModel
                {
                    Comment = "Emir deneme yorumu",
                    CommentBy = "Emir",
                    CommentDate = System.DateTime.Now.AddDays(-5)
                }
            };

            return View(model);
        }
    }
}
