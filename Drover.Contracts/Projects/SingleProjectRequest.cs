using Refit;

namespace Drover.Contracts.Projects
{
    public class SingleProjectRequest
    {
        [AliasAs("project_id")]
        public long Id { get; set; }
    }
}
