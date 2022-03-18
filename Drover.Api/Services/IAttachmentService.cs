using Drover.Contracts.Attachments;

namespace Drover.Api.Services
{
    public interface IAttachmentService
    {
        Task<IList<Attachment>> GetAttachments(long projectId, long taskId);

        Task<Attachment> GetAttachment(long projectId, long taskId, long attachmentId);

        Task<Attachment> CreateAttachment(long projectId, long taskId, string filename, Uri fileUri);

        Task<Attachment> UploadAttachment(long projectId, long taskId, Stream data);

        Task DeleteAttachment(long projectId, long taskId, long attachmentId);
    }
}
