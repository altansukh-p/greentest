using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Drawing;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            decimal a = 0, b = 0, c;
            c = a / b;

            a = b / 0;

			
            for (int i = 0; i < 100; i++)
            {
                Image img = Image.FromFile("c:/test.png");
                
                DataTable table = new DataTable();
                table.Columns.Add("COL1");
                table.Columns.Add("COL2");
                table.Rows.Add(new object[] { "data1", "data2" });
                table.Rows.Add(new object[] { "data1", "data2" });
                table.Rows.Add(new object[] { "data1", "data2" });
            }
            ViewBag.Message = "This is my first MVC 5 App." + calcData(null);
            return View();
        }

        private string calcData(DataRow dr)
        {
            for (int i = 0; i < 10; i++)
            {
                DataTable table = new DataTable();
                table.Columns.Add("COL1");
                table.Columns.Add("COL2");
                table.Rows.Add(new object[] { "data1", "data2" });
                table.Rows.Add(new object[] { "data1", "data2" });
                table.Rows.Add(new object[] { "data1", "data2" });
            }
            return dr["COL"].ToString();
        }
        
    }
}