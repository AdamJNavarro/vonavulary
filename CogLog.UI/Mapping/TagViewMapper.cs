using CogLog.UI.Models.Tag;
using CogLog.UI.Services.Base;

namespace CogLog.UI.Mapping;

public static class TagViewMapper
{
    public static TagMinimalVm ToTagMinimalVm(this TagMinimalDto topic)
    {
        return new TagMinimalVm
        {
            Id = topic.Id,
            Name = topic.Name,
            Icon = topic.Icon,
        };
    }

    public static BaseTagVm BaseTagVm(this TagDto topic)
    {
        return new BaseTagVm
        {
            Id = topic.Id,
            Name = topic.Name,
            SubjectId = topic.SubjectId,
        };
    }

    public static List<BaseTagVm> ToBaseTagVmList(this IEnumerable<TagDto> tags)
    {
        return tags.Select(x => x.BaseTagVm()).ToList();
    }
}
