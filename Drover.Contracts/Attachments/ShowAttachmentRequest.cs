using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Drover.Contracts.Attachments
{
    public class ShowAttachmentRequest : BaseAttachmentRequest
    {
        [AliasAs("id")]
        public long AttachmentId { get; set; }
    }
}
