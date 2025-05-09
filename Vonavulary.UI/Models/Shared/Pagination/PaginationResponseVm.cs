namespace Vonavulary.UI.Models.Shared.Pagination;

public abstract class PaginationResponseVm<T>
{
    public PaginationMetadataVm Pagination { get; set; }
    public IEnumerable<T> Data { get; set; }
}
