using System.ComponentModel.DataAnnotations;

namespace BlazorServer.OpeniddictServer.ViewModels.Authorization
{
    public class AuthorizeViewModel
    {
        [Display(Name = "程序名称")]
        public string ApplicationName { get; set; }

        [Display(Name = "范围Scope")]
        public string Scope { get; set; }
    }
}
