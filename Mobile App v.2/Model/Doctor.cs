using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_App_v._2.Model
{

    public enum Function
    {
        Cardiologist,
        Urologist,
        Surgeon
    }

    public class Doctor
    {
        [PrimaryKey, AutoIncrement]
        public int DoctorID { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public Function Function { get; set; }

        [OneToMany]

        public List<Review> Reviews { get; set; }

    }
}
