using System.Linq;
using TrashBin.Domain;
using TrashBin.Mvc.Models;

namespace TrashBin.Mvc.Services
{
    public class ProjectService : IProjectService
    {
        private readonly TrashBinContext trashbinContext;

        public ProjectService(TrashBinContext trashbinContext)
        {
            this.trashbinContext = trashbinContext;
        }

        public ProjectListViewModel GetProjects()
        {
            var projects = trashbinContext.Projects.ToList();
            var projectViewModels = projects.Select(AutoMapper.Mapper.Map<Project, ProjectViewModel>);
            return new ProjectListViewModel
                {
                    Projects = projectViewModels.ToList()
                };
        }
    }
}