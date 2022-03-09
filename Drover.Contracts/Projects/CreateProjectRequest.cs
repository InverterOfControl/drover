using Refit;

namespace Drover.Contracts.Projects
{
    public class CreateProjectRequest
    {
        [AliasAs("name")]
        public string Name { get; set; }

        [AliasAs("devurl")]
        public string WebsiteUrl { get; set; }

        [AliasAs("is_active")]
        public bool IsActive { get; set; }

        [AliasAs("is_public")]
        public bool IsPublic { get; set; }

        [AliasAs("guests_see_guests")]
        public bool GuestsSeeGuests { get; set; }
    }
}