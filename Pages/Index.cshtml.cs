using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Net6Test.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Date"] = DateTime.UtcNow.ToString();
            if (Request.QueryString.Value?.Contains("error") == true)
            {
                throw new Exception("Some error appears");
            }
        }
    }
}