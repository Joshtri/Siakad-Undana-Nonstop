using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siakad_Undana_Nonstop.Entity
{
    public class Grades
    {
        public string IdSemester { get; set; } //Key
        public string CodeSubject{ get; set; } //Key
        public string Nim { get; set; } //Key
        public double NumberGrade { get; set; }
        public string LetterGrade { get; set; }
    }
}
