# CRUD WEB API
Este projeto é uma aplicação CRUD simples para gerenciar tarefas, desenvolvida com ASP.NET Core e Entity Framework Core. A API permite criar, listar, atualizar e deletar tarefas em um banco de dados SQL Server.

# Funcionalidades
- Criar Tarefa: Adiciona uma nova tarefa no banco de dados.

- Listar Tarefas: Retorna uma lista com todas as tarefas.

- Atualizar Tarefa: Atualiza uma tarefa existente no banco de dados.

- Deletar Tarefa: Remove uma tarefa do banco de dados.

# Tecnologias utilizadas
- ASP.NET Core 6.0: Framework para construção de APIs RESTful.

- Entity Framework Core (6.0.35): ORM para interagir com o banco de dados SQL Server.

- SQL Server: Banco de dados relacional utilizado na aplicação.

- Swagger: Documentação e testes da API.

# Estrutura do Projeto
Abaixo está um breve resumo das principais classes e namespaces:

- CRUD.Entidade.Tarefa: Representa a entidade "Tarefa", contendo propriedades como Id, Tasktitle e Description.

- CRUD.EF.TarefaDbContext: Classe de contexto do Entity Framework, que gerencia o acesso ao banco de dados.

- CRUD.Controllers.TaskController: Controlador da API que implementa os métodos para criação, listagem, atualização e exclusão de tarefas.

- Migrations: Configurações de migração do banco de dados, geradas pelo Entity Framework.

# Endpoints da API
- POST /CreateTask: Cria uma nova tarefa.

- GET /ListTask: Retorna todas as tarefas.

- PUT /UpdateTask: Atualiza uma tarefa existente.

- DELETE /DeleteTask: Exclui uma tarefa.    

# Exemplo de requisição:

**Criar uma nova tarefa (POST /CreateTask):**

**json**

{

  "id": 0,
  
  "tasktitle": "Estudar C#",
  
  "description": "Revisar conceitos de ASP.NET Core"
  
}

**Atualizar uma tarefa (PUT /UpdateTask):**

**json**

{

  "id": 1,
  
  "tasktitle": "Estudar C# e SQL",
  
  "description": "Revisar conceitos avançados de Entity Framework"
  
}

# Como executar o projeto
**1. Pré-requisitos:**

- .NET SDK 6.0 ou superior.
  
- SQL Server.

- Visual Studio ou VS Code.

**2. Clonar repositório:**

https://github.com/MathSabno/WebAPI.Crud.git

**3. Baixar e restaurar o banco de dados**
- Faça o download do arquivo de backup (WebAPI.bkp) do banco de dados.
- No SQL Server Management Studio (SSMS), siga as etapas para restaurar o banco:
  
1. Abra o SSMS e conecte-se ao servidor SQL.
   
2. Clique com o botão direito em "Databases" e selecione "Restore Database".
   
3. Escolha a opção "Device", selecione o arquivo `.bkp` baixado e siga as instruções para restaurar o banco.

**4. Configurar banco de dados:**

Certifique-se de que o banco de dados SQL Server esteja configurado no arquivo TarefaDbContext.cs na linha:
  
options.UseSqlServer("Server=(local)\\SQLEXPRESS;Database=INSTDB001;Trusted_Connection=True;");

**5. Rodar as migrações:**

No terminal do Visual Studio, rode o seguinte comando para aplicar as migrações:

dotnet ef database update

**6. Executar o projeto:**

No terminal do Visual Studio, aperte a tecla **F5** do teclado ou rode o seguinte comando para executar o projeto:

dotnet run

