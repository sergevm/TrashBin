using System.Collections.Generic;

namespace TrashBin.Mvc.Models
{
    public class ProjectListViewModel
    {
        public IEnumerable<ProjectViewModel> Projects { get; set; }
    }
}