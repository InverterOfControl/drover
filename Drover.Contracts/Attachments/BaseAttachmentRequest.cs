using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Drover.Contracts.Attachments
{
    public abstract class BaseAttachmentRequest
    {
        [AliasAs("project_id")]
        public long ProjectId { get; set; }

        [AliasAs("task_id")]
        public long TaskId { get; set; }
    }
}
