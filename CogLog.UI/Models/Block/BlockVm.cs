using System.ComponentModel.DataAnnotations;

namespace CogLog.UI.Models.Block;

public class BlockVm : BaseBlockVm
{
    [Required]
    public DateTime DateAdded { get; init; }

    [Required]
    public required string Title { get; init; }

    [Required]
    public required string Content { get; init; }

    public string? ExtraContent { get; init; }

    public string? Url { get; init; }

    public int? CategoryId { get; set; }

    // Category - VM

    public int? SubjectId { get; set; }

    // Subject - VM

    // BlockTopics VM

    // BlockTags VM
}
