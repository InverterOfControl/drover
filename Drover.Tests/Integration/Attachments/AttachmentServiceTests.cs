using Drover.Tests.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Drover.Tests.Integration.Attachments
{
  public class AttachmentServiceTests
  {
    [Fact]
    public async Task UploadRetrieveAndDeleteAttachment()
    {
      var attachmentService = Connection.BugherdConnection.CreateAttachmentService();

      var projectId = Connection.BugherdConfig.DefaultProject;
      var taskId = Connection.BugherdConfig.DefaultTask;
      var source = "Integration/Attachments/test.png";
      long createdAttachmentId = 0;

      // Create
      using (FileStream fs = new FileStream(source, FileMode.Open))
      {
        var newAttachment = await attachmentService.UploadAttachment(projectId, taskId, fs, "test.png");

        Assert.NotNull(newAttachment);
        createdAttachmentId = newAttachment.Id.Value;
      }

      // Retrieve
      var attachments = await attachmentService.GetAttachments(projectId, taskId);

      Assert.Contains(attachments, attachment => attachment.Id == createdAttachmentId);


      // Delete
      var success = await attachmentService.DeleteAttachment(projectId, taskId, createdAttachmentId);

      Assert.True(success);
    }
  }
}
