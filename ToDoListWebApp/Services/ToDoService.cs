using Microsoft.EntityFrameworkCore;
using ToDoListWebApp.Models;

namespace ToDoListWebApp.Services
{
    public class ToDoService
    {
        private readonly ToDoContext context;

        public ToDoService(ToDoContext context)
        {
            this.context = context;
        }
        public async Task<List<ToDo>> GetToDosAsync()
        {
            return await context.ToDos.ToListAsync();
        }
        public async Task AddAsync(ToDo toDo)
        {
            await context.ToDos.AddAsync(toDo);
            await context.SaveChangesAsync();
        }
    }
}
