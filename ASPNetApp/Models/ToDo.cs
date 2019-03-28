using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetApp.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Importance { get; set; }
        public string Content { get; set; }
        public User User { get; set; }

        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }
    }
}
