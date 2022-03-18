using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Drover.Contracts.Attachments
{
    public class DeleteAttachmentRequest : BaseAttachmentRequest 
    {
        [AliasAs("id")]
        public long AttachmentId { get; set; }
    }
}
