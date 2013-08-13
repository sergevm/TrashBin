using System;
using System.Linq;
using NServiceBus;
using TrashBin.Domain;
using TrashBin.Messages.Commands;
using TrashBin.Mvc.Models;

namespace TrashBin.Mvc.Services
{
    public class ProjectService : IProjectService
    {
        private readonly TrashBinContext trashbinContext;
        private readonly IBus bus;

        public ProjectService(TrashBinContext trashbinContext, IBus bus)
        {
            this.trashbinContext = trashbinContext;
            this.bus = bus;
        }

        public void CreateProject(ProjectViewModel project)
        {
            bus.Send(new CreateProject {Name = project.Name, Description = project.Description});
        }

        public void DeleteProject(Guid projectId)
        {
            bus.Send(new DeleteProject {ProjectId = projectId});
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