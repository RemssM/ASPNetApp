using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetApp.Models
{
    public class ToDoImportanceViewModel
    {
        public List<ToDo> toDos;
        public SelectList Importance;
        public string ToDoImportance { get; set; }
        public string SearchString { get; set; }

    }
}
