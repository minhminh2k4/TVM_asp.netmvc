using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TVM_lessononline.Controllers
{
    /// <summary>
    /// Author: Trần Văn Minh
    /// class : k22 cntt2
    /// </summary>
    public class TvmController : Controller
    {
        // GET: Tvm
        public ActionResult Index()
        {
            //Truyền dữ liệu từ controller -> view
            ViewBag.name = "Trần Văn Minh";
            ViewData["Birthday"] = "20/06/2004";
            TempData["Phone"] = "0366421013";
            return View();
        }

        public ActionResult Details()
        {
            string TvmStr = "";
            TvmStr += "<h3> Họ và tên: Trần Văn Minh</h3>";
            TvmStr += "<p> Mã số: 2210900112";
            TvmStr += "<p> Địa chỉ gmail: tranvanminh20640@gmail.com";
            ViewBag.Details = TvmStr;
            return View("chitiết");
        }
        public ActionResult NgonNguRazon()
        {
            string[] names = { "Trần Văn A", "Nguyễn Thị M", "Lê Đại C", "Trịnh Văn C" };
            ViewBag.names = names;
            return View();
        }

        //HTMLHelper
        // Get: Tvm/AddNew
        public ActionResult AddNew()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNew(FormCollection form) 
        {
            // Lấy dữ liệu trên form
            string fullname = form["fullname"];
            string maSV = form["maSV"];
            string Taikhoan = form["Taikhoan"];
            string MatKhau = form["MatKhau"];
            string tvmStr = "<h3>" + fullname + "</h3>";
            tvmStr += "<p>" + maSV;
            tvmStr += "<p>" + Taikhoan;
            tvmStr += "<p>" + MatKhau;
            ViewBag.info = tvmStr;
            return View("Ketqua");
        }
    }
}