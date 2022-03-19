using Drover.Api.Services;

namespace Drover.Api.Factories
{
    public interface IBugherdConnection
    {
        string ApiKey { get; }

        string BaseUri { get; }

        IOrganisationService CreateOrganisationService();

        ITaskService CreateTaskService();

        IUsersService CreateUsersService();

        IProjectService CreateProjectService();

        IColumnService CreateColumnService();
        ICommentService CreateCommentService();
        IAttachmentService CreateAttachmentService();
    }
}