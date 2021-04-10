using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using TTGarmentAdmin.Models;

namespace TTGarmentAdmin.Controllers
{
    public class DashboardController : Controller
    {
        private Repository repository;
       
        public ActionResult Index()
        {
            ViewBag.Header = "MPS Bhilwara Class "+ (Session["LoginUser"]  as UserDetail).Stndard+ " 2020 - 21";
            return View();
        }

        

        public ActionResult LogOut()
        {
            Session["LoginUserName"] = null;
            return RedirectToAction("Index", "Home");
        }

        public ActionResult PrivacyPolicy()
        {           
            return View();
        }

        public ActionResult menus()
        {
            this.repository = new Repository();
            Response MenuList = new Response();
            MenuList.MediaTypeList = Task.Run(() => this.repository.GetMediaList()).Result;//await this.repository.GetMediaList();
            return PartialView(MenuList);
        }

        public async Task<ActionResult> GetPageDetail(string Page, int PageId)
        {
            this.repository = new Repository();
            List<SchoolMedia> Pagedetail = new List<SchoolMedia>();
            int UserId = (int)(Session["LoginUser"] as UserDetail).Id;
            ViewBag.Header = (Session["LoginUser"] as UserDetail).Stndard + " - " + Page;
            var response = await repository.GetPageDetail(UserId, PageId);
            return View("PageDetail", response.MediaList);
        }

        public FileResult DownloadFile(string file)
        {
            string filename = Path.GetFileName(new Uri(file).AbsolutePath);
            byte[] fileBytes = System.IO.File.ReadAllBytes(@"C:\HostingSpaces\admin\shopimage.bisplindia.in\wwwroot\SchoolData\" + filename);            
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, filename);
        }
    }
}