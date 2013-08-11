using System;
using TrashBin.Mvc.Models;

namespace TrashBin.Mvc.Services
{
    public interface IProjectService
    {
        ProjectListViewModel GetProjects();
        void CreateProject(ProjectViewModel project);
        void DeleteProject(Guid projectId);
    }
}
