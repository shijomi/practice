using System.ComponentModel.DataAnnotations;

namespace work.Models
{
    public enum Sex
    { 
        masculino, 
        femenino,
    }
    public class student
    {
        public string name { get; set; }
        public Sex sex { get; set; }
        [EmailAddress]
        public string email { get; set; }

    }
}