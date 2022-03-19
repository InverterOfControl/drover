using Drover.Contracts.Attachments;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drover.Api.Endpoints
{
    internal interface IAttachmentApi
    {
        /// <summary>
        /// Get a paginated list of attachments for a task.
        /// </summary>
        /// <returns></returns>
        [Get("/api_v2/projects/{request.project_id}/tasks/{request.task_id}/attachments.json")]
        Task<MultipleAttachmentResponse> ListAttachments(ListAttachmentRequest request);

        /// <summary>
        /// Get detail for specific attachment.
        /// </summary>
        /// <returns></returns>
        [Get("/api_v2/projects/{request.project_id}/tasks/{request.task_id}/attachments/{request.id}.json")]
        Task<AttachmentResponse> ShowAttachment(ShowAttachmentRequest request);

        /// <summary>
        /// Adds a new attachment to the specified task using an existing URL.
        /// </summary>
        /// <returns></returns>
        [Post("/api_v2/projects/{request.project_id}/tasks/{request.task_id}/attachments.json")]
        Task<AttachmentResponse> CreateAttachment(CreateAttachmentRequest request);

        /// <summary>
        /// Upload a new attachment and add it to the specified task. The file contents need to be specified as the POST data on this request.
        /// Note that your upload needs to be reasonable in size as the maximum time the request may take is around 30 seconds.If you have larger uploads please create arrange your own file upload and create the attachment via <see cref="CreateAttachment"/> instead.
        /// </summary>
        /// <returns></returns>
        [Post("/api_v2/projects/{request.project_id}/tasks/{request.task_id}/attachments/upload")]
        Task<AttachmentResponse> UploadAttachment(UploadAttachmentRequest request);

        /// <summary>
        /// Delete an attachment from a task. Note that this action is permanent and cannot be undone.
        /// </summary>
        /// <returns></returns>
        [Delete("/api_v2/projects/{request.project_id}/tasks/{request.task_id}/attachments/{request.id}.json")]
        Task<DeleteAttachmentResponse> DeleteAttachment(DeleteAttachmentRequest request);
    }
}
