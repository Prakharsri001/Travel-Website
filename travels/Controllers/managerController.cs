using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using travels.Models;
using System.IO;

namespace travels.Controllers
{
    public class managerController : Controller
    {
        //
        // GET: /manager/

        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(string txtname, string txtdec, HttpPostedFileBase fupic)
        {
            string pic = Path.Combine(Server.MapPath("~/Content/Photo"),fupic.FileName);
            fupic.SaveAs(pic);
            DBManager db=new DBManager();
            string cmd = "insert into tbl_destination values('" + txtname + "','"+txtdec+"','"+fupic.FileName+"')";
            if (db.MyInsertUpdateDelete(cmd))
                Response.Write("<script>alert('Place Inserted')</script>");
            else
                Response.Write("<script>alert('Place Not Inserted')</script>");
            return View();
        }
        public ActionResult Addplace()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Addplace(string txtname, string txtdec, HttpPostedFileBase fupic)
        {
            string pic = Path.Combine(Server.MapPath("~/Content/Photo"), fupic.FileName);
            fupic.SaveAs(pic);
            DBManager db = new DBManager();
            string cmd = "insert into tbl_destination values('" + txtname + "','" + txtdec + "','" + fupic.FileName + "')";
            if (db.MyInsertUpdateDelete(cmd))
                Response.Write("<script>alert('Place Inserted')</script>");
            else
                Response.Write("<script>alert('Place Not Inserted')</script>");
            return View();
        }

        public ActionResult Deleteplace()
        {

            return View();
        }

    }
}
