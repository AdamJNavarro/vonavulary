using CogLog.App.Contracts.Data.Subject;

namespace CogLog.App.Contracts.Data.Category;

public record CategoryWithSubjectsDto(
    int Id,
    string Label,
    string Icon,
    string? Description,
    List<SubjectDto> Subjects
);
