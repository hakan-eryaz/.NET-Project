using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke() {
            var comment = new List<UserComment> {
            new UserComment{
            ID = 1,
            UserName="Hakan"
            },
            new UserComment{
            ID = 1,
            UserName="Hakan"
            },
            new UserComment{
            ID = 1,
            UserName="Hakan"
            },
            new UserComment{
            ID = 1,
            UserName="Hakan"
            },
            new UserComment{
            ID = 1,
            UserName="Hakan"
            }
            };
            return View(comment);
        }

    }
}
