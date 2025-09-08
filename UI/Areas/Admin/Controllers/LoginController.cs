using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace UI.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        UserBLL userBll = new UserBLL();
        // GET: Admin/Login
        public ActionResult Index()
        {
            UserDTO dto = new UserDTO();
            return View(dto);
        }

        [HttpPost]
        public ActionResult Index(UserDTO userModel)
        {
            if(ModelState.IsValid)
            {
                UserDTO userDTO = userBll.GetUserWithUsernameAndPassword(userModel);
                if(userDTO.ID != 0)
                {
                    return RedirectToAction("Index", "Post");
                } 
                else
                {
                    return View(userModel);
                }
            } 
            else
            {
                return View(userModel);
            }
               
        }
    }
}