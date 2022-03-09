using Refit;

namespace Drover.Contracts.Projects
{
    public class SingleProjectRequest
    {
        [AliasAs("project_id")]
        public int Id { get; set; }
    }
}
