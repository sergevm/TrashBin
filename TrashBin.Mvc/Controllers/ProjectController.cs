using System;
using System.Web.Mvc;
using TrashBin.Mvc.Models;
using TrashBin.Mvc.Services;

namespace TrashBin.Mvc.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService projectService;

        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        public ActionResult Index()
        {
            var projectList = projectService.GetProjects();
            return View(projectList);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProjectViewModel project)
        {
            if (ModelState.IsValid)
            {
                projectService.CreateProject(project);
                return RedirectToAction("Index");
            }
                 
            return View();
        }

        public ActionResult Delete(Guid id)
        {
            projectService.DeleteProject(id);
            return RedirectToAction("Index");
        }
    }
}
