using System.Runtime.Serialization;

namespace Drover.Contracts.Tasks
{
  public enum TaskPriority {
    Normal,
    [EnumMember(Value = "not set")]
    NotSet,
    Critical,
    Important,
    Minor }
}
