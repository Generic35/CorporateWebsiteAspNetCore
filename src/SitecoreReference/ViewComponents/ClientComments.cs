using Microsoft.AspNet.Mvc;
using SitecoreReference.Services;

namespace SitecoreReference.ViewComponents
{
    public class ClientComments : ViewComponent
    {
        IClientCommentService _clientCommentsService;

        public ClientComments(IClientCommentService clientCommentsService)
        {
            _clientCommentsService = clientCommentsService;
        }

        public IViewComponentResult Invoke()
        {
            var clientComments = _clientCommentsService.GetAll();
            return View("Default", clientComments);
        }
    }
}
