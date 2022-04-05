using Drover.Tests.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drover.Tests.Integration.Attachments
{
  public class AttachmentServiceTests
  {
    public async Task GetAttachment()
    {
      var attachmentService = Connection.BugherdConnection.CreateAttachmentService();

      await attachmentService.GetAttachment(1,1,1);
    }
  }
}
