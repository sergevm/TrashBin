using TrashBin.Mvc.Models;

namespace TrashBin.Mvc.Services
{
    public interface IProjectService
    {
        ProjectListViewModel GetProjects();
    }
}
