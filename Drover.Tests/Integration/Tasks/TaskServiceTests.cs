using Drover.Tests.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Drover.Tests.Integration.Tasks
{
  public class TaskServiceTests
  {
    [Fact]
    public async Task CreateReadAndDeleteTask()
    {
      var taskService = Connection.BugherdConnection.CreateTaskService();

      var projectId = Connection.BugherdConfig.DefaultProject;

      var cancellationTokenSource = new CancellationTokenSource();

      // Create
      var newTask = await taskService.CreateTask(new Contracts.Tasks.CreateTaskRequest
      {
        ProjectId = projectId,
        NewTask = new Contracts.Tasks.NewTask
        {
          Description = "Testtask",
          RequesterEmail = "test@drover.com",
          ExternalId = "M123",
          Priority = Contracts.Tasks.TaskPriority.Normal,
          Status = "offen"
        }
      }, cancellationTokenSource.Token);

      // Retrieve
      var detailedTask = await taskService.GetTask(projectId, newTask.Id, cancellationTokenSource.Token);

      Assert.Equal("Testtask", detailedTask.Description);


      // Update
      await taskService.UpdateTask(new Contracts.Tasks.UpdateTaskRequest
      {
        ProjectId = projectId,
        TaskId = newTask.Id,
        UpdatedTask = new Contracts.Tasks.NewTask {
          Description = "Updated Description!",
          Status = "Ist transferiert",
          Priority = Contracts.Tasks.TaskPriority.Important
        }
      }, cancellationTokenSource.Token);

      // Retrieve again
      // Retrieve
      var updatedTask = await taskService.GetTask(projectId, newTask.Id, cancellationTokenSource.Token);

      Assert.Equal("Updated Description!", updatedTask.Description);
      //// Delete (Api does not support this yet)
      //await taskService.DeleteTask(projectId, newTask.Id);

      //Assert.True(success);
    }
  }
}
