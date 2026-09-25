using Microsoft.AspNetCore.Mvc;
using TaskTrackerApi.Data;
using TaskTrackerApi.Models;

namespace TaskTrackerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        // GET: /api/projects
        [HttpGet]
        public IActionResult GetProjects()
        {
            return Ok(DataStore.Projects);
        }

        // GET: /api/projects/1
        [HttpGet("{id}")]
        public IActionResult GetProject(int id)
        {
            var project = DataStore.Projects.FirstOrDefault(p => p.Id == id);

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        // POST: /api/projects
        [HttpPost]
        public IActionResult CreateProject(Project project)
        {
            project.Id = DataStore.Projects.Any()
                ? DataStore.Projects.Max(p => p.Id) + 1
                : 1;

            project.CreatedAt = DateTime.Now;

            DataStore.Projects.Add(project);

            return CreatedAtAction(
                nameof(GetProject),
                new { id = project.Id },
                project
            );
        }

        // PUT: /api/projects/1
        [HttpPut("{id}")]
        public IActionResult UpdateProject(int id, Project updatedProject)
        {
            var project = DataStore.Projects.FirstOrDefault(p => p.Id == id);

            if (project == null)
            {
                return NotFound();
            }

            project.Name = updatedProject.Name;
            project.Description = updatedProject.Description;

            return Ok(project);
        }

        // DELETE: /api/projects/1
        [HttpDelete("{id}")]
        public IActionResult DeleteProject(int id)
        {
            var project = DataStore.Projects.FirstOrDefault(p => p.Id == id);

            if (project == null)
            {
                return NotFound();
            }

            DataStore.Projects.Remove(project);

            // Also remove tasks belonging to this project
            DataStore.Tasks.RemoveAll(t => t.ProjectId == id);

            return NoContent();
        }

        // GET: /api/projects/1/tasks
        [HttpGet("{id}/tasks")]
        public IActionResult GetProjectTasks(int id)
        {
            var project = DataStore.Projects.FirstOrDefault(p => p.Id == id);

            if (project == null)
            {
                return NotFound();
            }

            var tasks = DataStore.Tasks
                .Where(t => t.ProjectId == id)
                .ToList();

            return Ok(tasks);
        }

        // POST: /api/projects/1/tasks
        [HttpPost("{id}/tasks")]
        public IActionResult CreateTask(int id, TaskItem task)
        {
            var project = DataStore.Projects.FirstOrDefault(p => p.Id == id);

            if (project == null)
            {
                return NotFound();
            }

            task.Id = DataStore.Tasks.Any()
                ? DataStore.Tasks.Max(t => t.Id) + 1
                : 1;

            task.ProjectId = id;
            task.CreatedAt = DateTime.Now;

            DataStore.Tasks.Add(task);

            return CreatedAtAction(
                nameof(GetProjectTasks),
                new { id = id },
                task
            );
        }
    }
}