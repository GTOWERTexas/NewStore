using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
namespace NewStore.Pages
{   // класс предназначен для того, чтобы от него наследовались модели представления Pages доступные только для администратора
    [Authorize(Roles ="Admins")]
    public class AdminPageModel : PageModel
    {
    }
}
