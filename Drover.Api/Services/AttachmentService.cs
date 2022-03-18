using Drover.Api.Endpoints;
using Drover.Api.Factories;
using Drover.Contracts.Attachments;

namespace Drover.Api.Services
{
    public class AttachmentService : BaseService, IAttachmentService
    {
        private readonly IAttachmentApi _api;

        public AttachmentService(IBugherdConnection connection) : base(connection)
        {
            _api = CreateApi<IAttachmentApi>();
        }

        public async Task<Attachment> CreateAttachment(long projectId, long taskId, string filename, Uri fileUri)
        {
            var request = new CreateAttachmentRequest();

            var response = await _api.CreateAttachment(request);

            return response.Attachment;
        }

        public async Task DeleteAttachment(long projectId, long taskId, long attachmentId)
        {
            var request = new DeleteAttachmentRequest();

            await _api.DeleteAttachment(request);
        }

        public async Task<Attachment> GetAttachment(long projectId, long taskId, long attachmentId)
        {
            var request = new ShowAttachmentRequest();

            var response = await _api.ShowAttachment(request);

            return response.Attachment;
        }

        public async Task<IList<Attachment>> GetAttachments(long projectId, long taskId)
        {
            var request = new ListAttachmentRequest();

            var response = await _api.ListAttachments(request);

            return response.Attachments;
        }

        public async Task<Attachment> UploadAttachment(long projectId, long taskId, Stream data)
        {
            var request = new UploadAttachmentRequest();

            var response = await _api.UploadAttachment(request);

            return response.Attachment;
        }
    }
}
