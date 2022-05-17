using Refit;

namespace Drover.Contracts.Attachments
{
  public class UploadAttachmentRequest : BaseAttachmentRequest
  {
    [AliasAs("file_name")]
    public string FileName { get; set; }
  }
}
