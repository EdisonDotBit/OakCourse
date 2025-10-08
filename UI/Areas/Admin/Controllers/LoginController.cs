using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login

        UserBLL userBll = new UserBLL();

        public ActionResult Index()
        {
            UserDTO userDto = new UserDTO();
            return View(userDto);
        }

        [HttpPost]
        public ActionResult Index(UserDTO model)
        {
            if(ModelState.IsValid)
            {
                UserDTO userDto = userBll.GetUserWithUsernameAndPassword(model);
                if (userDto.ID != 0 )
                {
                    return RedirectToAction("Index", "Post");
                } else
                {
                    return View(model);
                }
            } else
            {
                return View(model);
            }
        
        }
    }
} 