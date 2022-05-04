﻿using Drover.Contracts.Tasks;
using Refit;
using System.Threading.Tasks;

namespace Drover.Api.Endpoints
{
  internal interface ITaskApi
  {
    [Get("/api_v2/projects/{request.project_id}/tasks.json")]
    Task<TasksResponse> GetTasks(TasksRequest request);

    [Get("/api_v2/projects/{request.project_id}/tasks/feedback.json")]
    Task<TasksResponse> GetFeedbackTasks(TasksRequest request);

    [Get("/api_v2/projects/{request.project_id}/tasks/archive.json")]
    Task<TasksResponse> GetArchiveTasks(TasksRequest request);

    [Get("/api_v2/projects/{request.project_id}/tasks/taskboard.json")]
    Task<TasksResponse> GetTaskboard(TasksRequest request);

    [Get("/api_v2/projects/{request.project_id}/tasks/{request.task_id}.json")]
    Task<TaskResponse> GetTask(TasksRequest request);

    [Get("/api_v2/projects/{request.project_id}/local_tasks/{request.task_id}.json")]
    Task<TaskResponse> GetLocalTask(TasksRequest request);

    [Post("/api_v2/projects/{request.project_id}/tasks.json")]
    Task<TaskResponse> CreateTask(CreateTaskRequest request);

    [Put("/api_v2/projects/{request.project_id}/tasks/{request.task_id}.json")]
    Task<TaskResponse> UpdateTask(UpdateTaskRequest request);

    [Delete("/api_v2/projects/{request.project_id}/tasks/{request.task_id}.json")]
    System.Threading.Tasks.Task DeleteTask(DeleteTaskRequest request);
  }
}
