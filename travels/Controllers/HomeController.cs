using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using travels.Models;
using System.Data;
using System.Data.SqlClient;

namespace travels.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            
            return View();
            
        }

        public ActionResult Destination()
        {
            return View();
        }

        public ActionResult Tours()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string txtid,string txtpass)
        {
            DBManager db = new DBManager();
            string cmd = "select * from tbl_login where userid='"+txtid+"'and password='"+txtpass+"'and status=1";
            DataTable dt = db.GetAllRecord(cmd);
            if (dt.Rows.Count > 0)
            {
              string type = dt.Rows[0]["type"].ToString();
                if (type == "user")
                {
                    Session["wid"] = txtid;
                    Response.Redirect("/user/index");
                }
                else if (type =="manager")
                {
                    Session["mid"] = txtid;
                    Response.Redirect("/manager/index");
                }
                else
                {
                       ViewBag.msg="invalid type";
                }
            }
            else
            {
                ViewBag.msg = "userid and Password not Correct";
            }
            return View();
        }

        

        public ActionResult testimonials()
        {
            return View();
        }

        public ActionResult HotelBooking()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        } 

        public ActionResult Publish()
        {
            return View();
        }
    }
}
