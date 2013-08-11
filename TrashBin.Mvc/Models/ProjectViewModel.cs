using System;
using System.ComponentModel.DataAnnotations;

namespace TrashBin.Mvc.Models
{
    public class ProjectViewModel
    {
        [ScaffoldColumn(false)]
        public Guid Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }
        
        [Required, StringLength(200)]
        public string Description { get; set; }
    }
}