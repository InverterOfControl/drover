using Drover.Contracts.Attachments;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
    public interface IAttachmentService
    {
        Task<IList<Attachment>> GetAttachments(long projectId, long taskId, CancellationToken cancellationToken);

        Task<Attachment> GetAttachment(long projectId, long taskId, long attachmentId, CancellationToken cancellationToken);

        Task<Attachment> CreateAttachment(long projectId, long taskId, string filename, Uri fileUri, CancellationToken cancellationToken);

        Task<Attachment> UploadAttachment(long projectId, long taskId, Stream data, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes an attachment.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="taskId"></param>
        /// <param name="attachmentId"></param>
        /// <returns>A <see cref="bool"/> that indicates wether the delete-operation was successful or not.</returns>
        Task<bool> DeleteAttachment(long projectId, long taskId, long attachmentId, CancellationToken cancellationToken);
    }
}
