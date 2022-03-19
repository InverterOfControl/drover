using Drover.Api.Services;

namespace Drover.Api.Factories
{
    internal class BugherdConnection : IBugherdConnection
    {
        public string ApiKey { get; private set; }
        public string BaseUri { get; private set; }

        internal BugherdConnection(string apiKey, string baseUri)
        {
            ApiKey = apiKey;

            BaseUri = baseUri;
        }

        public IOrganisationService CreateOrganisationService()
        {
            return new OrganisationService(this);
        }

        public ITaskService CreateTaskService()
        {
            return new TaskService(this);
        }

        public IUsersService CreateUsersService()
        {
            return new UsersService(this);
        }

        public IProjectService CreateProjectService()
        {
            return new ProjectService(this);
        }

        public IColumnService CreateColumnService()
        {
            return new ColumnService(this);
        }

        public ICommentService CreateCommentService()
        {
            return new CommentService(this);
        }

        public IAttachmentService CreateAttachmentService()
        {
            return new AttachmentService(this);
        }
    }
}