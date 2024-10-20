namespace CRUD.Entidade
{
    public class Tarefa
    {
       

        public Tarefa(int id, string tasktitle, string description)
        {
            this.Id = id;
            this.Tasktitle = tasktitle;
            this.Description = description;
        }

        public int Id { get; set; }
        public string Tasktitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }


    
}
