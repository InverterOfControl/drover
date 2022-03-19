using Drover.Contracts.Comments;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
  public interface ICommentService
  {
    Task<IList<Comment>> GetComments(long projectId, long taskId);

    Task<Comment> CreateComment(long projectId, long taskId, string user, string text);
  }
}
