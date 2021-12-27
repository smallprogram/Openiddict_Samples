using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BlazorServer.OpeniddictServer.ViewModels.Authorization
{
    public class LogoutViewModel
    {
        [BindNever]
        public string RequestId { get; set; }
    }
}
