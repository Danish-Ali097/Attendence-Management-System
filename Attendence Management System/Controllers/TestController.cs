using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Attendence_Management_System.Models;

namespace Attendence_Management_System.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public JsonResult ImageUpload(ImageUploadModel iu)
        {
            var File = iu.ImageFile;
            if(File != null)
            {
                var filename = Path.GetFileName(File.FileName);
                File.SaveAs(Server.MapPath(iu.PathtoSave + filename));
            }
            return Json(File.FileName, JsonRequestBehavior.AllowGet);
        }
    }
}