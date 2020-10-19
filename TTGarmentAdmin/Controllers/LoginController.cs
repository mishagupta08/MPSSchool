using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TTGarmentAdmin.Models;

namespace TTGarmentAdmin.Controllers
{
    public class LoginController : Controller
    {
        private Repository repository;

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// validate user detail
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>Validation Result</returns>
        


        public async Task<ActionResult> SendOTP(string mobileNo)
        {
            try
            {
                if (mobileNo == null || string.IsNullOrEmpty(mobileNo))
                {
                    return Json("Please enter valid mobile no.");
                }                
                this.repository = new Repository();
                var user = await this.repository.SendOtp(mobileNo);
                return Json(user,JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.InnerException, JsonRequestBehavior.AllowGet);
            }            
        }

        public async Task<ActionResult> ValidateUser(LoginViewModel loginDetail)
        {
            try
            {
                if (loginDetail == null || string.IsNullOrEmpty(loginDetail.mobileNo))
                {
                    return Json("mobileNo is empty.");
                }

                if (string.IsNullOrEmpty(loginDetail.otp))
                {
                    return Json("otp is empty.");
                }

                this.repository = new Repository();
                var user = await this.repository.AdminLogin(loginDetail);
                if (user == null)
                {
                    return Json("Invalid OTP.");
                }                
                Session["LoginUser"] = user;
            }
            catch (Exception ex)
            {
                return Json(ex.InnerException);
            }

            return Json(string.Empty);
        }
    }
}