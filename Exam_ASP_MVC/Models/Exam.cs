using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exam_ASP_MVC.Models
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }
        [Display(Name = "Exam Subject")]
        public ExamSubject Subject { get; set; }
        [Display(Name = "Exam Duration")]
        public int Duration { get; set; }
        public ExamClassroom ClassRoom { get; set; }
        public ExamFaculty Faculty { get; set; }
        public DateTime ExamDate { get; set; }
        public string StartTime { get; set; }
        public ExamStatus Status { get; set; }

        public enum ExamClassroom
        {
            B10 = 1,
            B16 = 2,
            B14 = 3
        }

        public enum ExamSubject
        {
            CoreJava = 1,
            AdvanceJava = 2,
            CSharp = 3
        }

        public enum ExamStatus
        {
            Done = 1,
            UpComing = 2,
            OnGoing = 3
        }
        public enum ExamFaculty
        {
            Jayalakshmi = 1,
            JohnCarter = 2,
            HienPA = 3
        }
    }

   
}