using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Entities
{
    public class Student
    {
        [DisplayName("Öğreni No")]
        public int Id { get; set; }
        [DisplayName("Öğrenci Adı")]
        public string NameSurname { get; set; }
        [DisplayName("İletişim No")]
        public string PhoneNumber { get; set; }
        [Browsable(false)]
        public int GradeId { get; set; }
    }
}
