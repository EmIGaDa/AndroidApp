using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_App_v._2.Model
{
    public class Review
    {
        [PrimaryKey, AutoIncrement]
        public int ReviewId { get; set; }

        public string Description { get; set; }

        public int DoctorID { get; set; }

    }
}
