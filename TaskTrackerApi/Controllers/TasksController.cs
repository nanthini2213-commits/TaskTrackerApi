using Microsoft.AspNetCore.Mvc;
using TaskTrackerApi.Data;
using TaskTrackerApi.Models;

namespace TaskTrackerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        // GET: /api/tasks/1
        [HttpGet("{id}")]
        public IActionResult GetTask(int id)
        {
            var task = DataStore.Tasks.FirstOrDefault(t => t.Id == id);

            if (task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }

        // PUT: /api/tasks/1
        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, TaskItem updatedTask)
        {
            var task = DataStore.Tasks.FirstOrDefault(t => t.Id == id);

            if (task == null)
            {
                return NotFound();
            }

            task.Title = updatedTask.Title;
            task.Description = updatedTask.Description;
            task.Status = updatedTask.Status;
            task.DueDate = updatedTask.DueDate;

            return Ok(task);
        }

        // DELETE: /api/tasks/1
        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            var task = DataStore.Tasks.FirstOrDefault(t => t.Id == id);

            if (task == null)
            {
                return NotFound();
            }

            DataStore.Tasks.Remove(task);

            return NoContent();
        }
    }
}