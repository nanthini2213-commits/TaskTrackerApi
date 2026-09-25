using TaskTrackerApi.Models;

namespace TaskTrackerApi.Data
{
    public static class DataStore
    {
        public static List<Project> Projects { get; set; } = new()
        {
            new Project
            {
                Id = 1,
                Name = "Website Redesign",
                Description = "Redesign the company website",
                CreatedAt = DateTime.Now
            },

            new Project
            {
                Id = 2,
                Name = "Mobile App",
                Description = "Develop a simple mobile application",
                CreatedAt = DateTime.Now
            }
        };

        public static List<TaskItem> Tasks { get; set; } = new()
        {
            new TaskItem
            {
                Id = 1,
                ProjectId = 1,
                Title = "Create wireframes",
                Description = "Design website wireframes",
                Status = "Todo",
                DueDate = DateTime.Now.AddDays(7),
                CreatedAt = DateTime.Now
            },

            new TaskItem
            {
                Id = 2,
                ProjectId = 1,
                Title = "Create homepage",
                Description = "Develop the homepage",
                Status = "InProgress",
                DueDate = DateTime.Now.AddDays(10),
                CreatedAt = DateTime.Now
            },

            new TaskItem
            {
                Id = 3,
                ProjectId = 2,
                Title = "Design login page",
                Description = "Create the login page design",
                Status = "Todo",
                DueDate = DateTime.Now.AddDays(5),
                CreatedAt = DateTime.Now
            },

            new TaskItem
            {
                Id = 4,
                ProjectId = 2,
                Title = "Test application",
                Description = "Test the mobile application",
                Status = "Done",
                DueDate = DateTime.Now.AddDays(14),
                CreatedAt = DateTime.Now
            }
        };
    }
}