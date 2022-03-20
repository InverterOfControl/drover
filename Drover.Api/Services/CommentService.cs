using Drover.Api.Endpoints;
using Drover.Api.Factories;
using Drover.Contracts.Comments;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
    public class CommentService : BaseService, ICommentService
  {
    private readonly ICommentApi _api;

    public CommentService(IBugherdConnection connection) : base(connection)
    {
      _api = CreateApi<ICommentApi>();
    }

    public async Task<Comment> CreateComment(long projectId, long taskId, string user, string text, CancellationToken cancellationToken)
    {
      var newComment = new Comment { Email = user, Text = text };
      var request = new CreateCommentRequest { ProjectId = projectId, TaskId = taskId };

      var response = await _api.CreateComment(request, newComment, cancellationToken).ConfigureAwait(false);

      return response.Comment;
    }

    public async Task<IList<Comment>> GetComments(long projectId, long taskId, CancellationToken cancellationToken)
    {
      var request = new ListCommentRequest { ProjectId = projectId, TaskId=taskId };

      var response = await _api.ListComments(request, cancellationToken).ConfigureAwait(false);

      return response.Comments;
    }
  }
}
