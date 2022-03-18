using System;
using System.Collections.Generic;
using System.Text;

namespace Drover.Contracts.Attachments
{
    public class MultipleAttachmentResponse
    {
        public IList<Attachment> Attachments { get; set; }
    }
}
