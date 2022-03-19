using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Drover.Contracts.Attachments
{
    public class CreateAttachmentRequest : BaseAttachmentRequest
    {
        [AliasAs("attachment")]
        public Attachment Attachment { get; set; }
    }
}
