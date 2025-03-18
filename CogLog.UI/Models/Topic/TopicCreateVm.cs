using System.ComponentModel.DataAnnotations;
using CogLog.UI.Models.Shared.Hierarchy;

namespace CogLog.UI.Models.Topic;

public class TopicCreateVm : HierarchyBaseWriteVm
{
    [Required]
    public int SubjectId { get; set; }
}
