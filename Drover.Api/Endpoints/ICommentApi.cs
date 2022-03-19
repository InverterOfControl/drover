using Drover.Contracts.Comments;
using Refit;
using System.Threading.Tasks;

namespace Drover.Api.Endpoints
{
  internal interface ICommentApi
  {
    [Get("/api_v2/projects/{request.project_id}/tasks/{request.task_id}/comments.json")]
    Task<CommentResponse> ListComments(ListCommentRequest request);

    [Post("/api_v2/projects/{request.project_id}/tasks/{request.task_id}/comments.json")]
    Task<SingleCommentResponse> CreateComment(CreateCommentRequest request, [Body] Comment comment);
  }
}
