using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Village.Models
{
    //4.	צרו מודל של תושב עם שדות :ID , שם פרטי, שם האב, מגדר, האם נולד בכפר ותאריך לידה.
    public class Settler
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }

        public bool BornOnVillage { get; set; }
        public DateTime DateTime { get; set; }

    }
}