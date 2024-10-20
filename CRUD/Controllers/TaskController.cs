using CRUD.EF;
using CRUD.Entidade;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace CRUD.Controllers
{
    [ApiController]
    public class TaskController : ControllerBase
    {

        [HttpPost]
        [Route("/CreateTask")]
        public async Task<string> Create(Tarefa tarefa)
        {
            // Instância da entidade
            var task = new Tarefa(tarefa.Id, tarefa.Tasktitle, tarefa.Description);

            // Instância do Data Context
            using var context = new TarefaDbContext();

            var resultTask = await context.Tasks.FirstOrDefaultAsync(x => x.Tasktitle == task.Tasktitle || x.Description == task.Description);

            if (resultTask is not null)
                return "Tarefa já existe com esse titulo ou descrição";

            // Adiciona a entidade ao Data Context
            await context.Tasks.AddAsync(task);

            // Persiste as mudanças
            var result = await context.SaveChangesAsync();

            return "Tarefa criada com sucesso";
        }


        [HttpGet]
        [Route("/ListTask")]
        public async Task<List<Tarefa>> List()
        {
            using var context = new TarefaDbContext();

            // Lê todas as categorias
            return await context.Tasks.ToListAsync();
        }

        [HttpPut]
        [Route("/UpdateTask")]
        public async Task<string> Update(Tarefa tarefa)
        {
            // Instância do Data Context
            using var context = new TarefaDbContext();

            // Recupera a entidade (Re-hidratação)
            var task = await context.Tasks.FirstOrDefaultAsync(x => x.Id == tarefa.Id);

            if (task is null)
                return "Tarefa não encontrada";

            // Altera a entidade
            task.Tasktitle = string.IsNullOrEmpty(tarefa.Tasktitle) ? task.Tasktitle : tarefa.Tasktitle;
            task.Description = string.IsNullOrEmpty(tarefa.Description) ? task.Description : tarefa.Description;

            // Atualiza os dados no DataContext
            context.Tasks.Update(task);

            // Persiste os dados no banco
            var t = await context.SaveChangesAsync();

            return "Tarefa atualizada com sucesso!";
        }

        [HttpDelete]
        [Route("/DeleteTask")]
        public async Task<string> Delete(int Id)
        {
            // Instância do Data Context
            using var context = new TarefaDbContext();

            // Recupera a entidade (Re-hidratação)
            var task = await context.Tasks.FirstOrDefaultAsync(x => x.Id == Id);

            if (task is null)
                return "Tarefa não encontrada";

            // Remove ela do DataContext
            context.Tasks.Remove(task);

            // Persiste os dados no banco
            await context.SaveChangesAsync();

            return "Tarefa removida com sucesso!";
        }
    }
}
