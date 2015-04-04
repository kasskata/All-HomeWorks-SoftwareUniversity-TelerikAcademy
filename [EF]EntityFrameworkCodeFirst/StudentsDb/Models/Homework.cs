namespace StudentsDb
{
    using System;
    using Models;

    //Homework: id, content, content-type (e.g. application/pdf or application/zip), date and time

    public class Homework
    {
        public Homework()
        {
        }

        public int? Id { get; set; }

        public string Content { get; set; }

        public TypeContent TypeContent { get; set; }

        public DateTime? CreateOn { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
