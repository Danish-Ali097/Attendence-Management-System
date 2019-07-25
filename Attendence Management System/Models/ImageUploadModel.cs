using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attendence_Management_System.Models
{
    public class ImageUploadModel
    {
        public HttpPostedFileWrapper ImageFile { set; get; }
        public string PathtoSave { set; get; }
    }
}