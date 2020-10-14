using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EECoreTutorials.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        //Aplicando relaciones 
        public int studentId { get; set; }
        [ForeignKey("studentId")]
        public virtual Student Student { get; set; }

        public Course()
        {
            CourseId = 0;
            CourseName = string.Empty;
            studentId = 0;
        }
    }
}

