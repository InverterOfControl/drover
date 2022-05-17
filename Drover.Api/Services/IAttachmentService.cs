using Drover.Contracts.Attachments;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
  public interface IAttachmentService
  {
    /// <summary>
    /// Get a paginated list of attachments for a task.
    /// </summary>
    /// <returns></returns>
    Task<IList<Attachment>> GetAttachments(long projectId, long taskId);

    /// <summary>
    /// Get detail for specific attachment.
    /// </summary>
    /// <returns></returns>
    Task<Attachment> GetAttachment(long projectId, long taskId, long attachmentId);

    /// <summary>
    /// Adds a new attachment to the specified task using an existing URL.
    /// </summary>
    /// <returns></returns>
    Task<Attachment> CreateAttachment(long projectId, long taskId, string filename, Uri fileUri);

    /// <summary>
    /// Upload a new attachment and add it to the specified task. The file contents need to be specified as the POST data on this request.
    /// Note that your upload needs to be reasonable in size as the maximum time the request may take is around 30 seconds.If you have larger uploads please create arrange your own file upload and create the attachment via <see cref="CreateAttachment"/> instead.
    /// </summary>
    /// <returns></returns>
    Task<Attachment> UploadAttachment(long projectId, long taskId, Stream data, string filename);

    /// <summary>
    /// Deletes an attachment.
    /// </summary>
    /// <param name="projectId"></param>
    /// <param name="taskId"></param>
    /// <param name="attachmentId"></param>
    /// <returns>A <see cref="bool"/> that indicates wether the delete-operation was successful or not.</returns>
    Task<bool> DeleteAttachment(long projectId, long taskId, long attachmentId);
  }
}
