using Drover.Api.Endpoints;
using Drover.Api.Factories;
using Drover.Contracts.Attachments;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
    public class AttachmentService : BaseService, IAttachmentService
    {
        private readonly IAttachmentApi _api;

        public AttachmentService(IBugherdConnection connection) : base(connection)
        {
            _api = CreateApi<IAttachmentApi>();
        }

        public async Task<Attachment> CreateAttachment(long projectId, long taskId, string filename, Uri fileUri, CancellationToken cancellationToken)
        {
            var request = new CreateAttachmentRequest
            {
                ProjectId = projectId,
                TaskId = taskId,
                Attachment = new Attachment
                {
                    FileName = filename,
                    Url = fileUri.ToString(),
                }
            };

            var response = await _api.CreateAttachment(request, cancellationToken).ConfigureAwait(false);

            return response.Attachment;
        }

        public async Task<bool> DeleteAttachment(long projectId, long taskId, long attachmentId, CancellationToken cancellationToken)
        {
            var request = new DeleteAttachmentRequest { 
                ProjectId = projectId,
                TaskId = taskId,
                AttachmentId = attachmentId
            };

            try
            {
              var response = await _api.DeleteAttachment(request, cancellationToken).ConfigureAwait(false);
              return response.Success;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public async Task<Attachment> GetAttachment(long projectId, long taskId, long attachmentId, CancellationToken cancellationToken)
        {
            var request = new ShowAttachmentRequest
            {
                ProjectId = projectId,
                TaskId = taskId,
                AttachmentId = attachmentId
            };

            var response = await _api.ShowAttachment(request, cancellationToken).ConfigureAwait(false);

            return response.Attachment;
        }

        public async Task<IList<Attachment>> GetAttachments(long projectId, long taskId, CancellationToken cancellationToken)
        {
            var request = new ListAttachmentRequest
            {
                ProjectId= projectId,
                TaskId= taskId
            };

            var response = await _api.ListAttachments(request, cancellationToken).ConfigureAwait(false);

            return response.Attachments;
        }

        public async Task<Attachment> UploadAttachment(long projectId, long taskId, Stream data, CancellationToken cancellationToken)
        {
            var request = new UploadAttachmentRequest();

            var response = await _api.UploadAttachment(request, cancellationToken).ConfigureAwait(false);

            return response.Attachment;
        }
    }
}
