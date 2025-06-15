using Microsoft.AspNetCore.Mvc;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class BoardController : Controller
    {
        public ActionResult List(int? Id)
        {
           // if (Id == null)
            //{
             //   return BadRequest("id가 필요합니다.");
           // }

            DocumentActs documentActs = new DocumentActs();
            MemberActs memberActs = new MemberActs();

            var documents = documentActs.GetDocumnts();
            var member = memberActs.GetMember(1);

            // viewBag
            //ViewBag은 "작고 단순한 정보"를 보낼 때 주로 쓰는 도구
            //ViewBag.Member = member;
            ViewData["Member"] = member;

            return View(documents);
        }
    }
}
