using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
namespace NewStore.Pages
{
    [Authorize(Roles ="Admins")]
    public class AdminPageModel : PageModel
    {
    }
}
