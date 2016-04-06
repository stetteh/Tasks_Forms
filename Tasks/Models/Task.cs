using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tasks.Models
{
    public class Task
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Isdone { get; set; }

        public Task()
        {
            
        }
        public Task(int id, string name, string desc, bool isdone)
        {
            Id = id;
            Name = name;
            Description = desc;
            Isdone = isdone;
        }
    }
}