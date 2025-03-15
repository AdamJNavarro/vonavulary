using CogLog.App.Constants;
using CogLog.App.Contracts.Persistence;
using FluentValidation;

namespace CogLog.App.Features.Subject.Commands;

public class CreateSubjectValidator : AbstractValidator<CreateSubjectCommand>
{
    private readonly ICategoryRepo _categoryRepo;

    public CreateSubjectValidator(ICategoryRepo categoryRepo)
    {
        _categoryRepo = categoryRepo;

        // RuleFor(x => x.CategoryId)
        //     .MustAsync(CategoryMustExist)
        //     .When(x => x.CategoryId is not null)
        //     .WithMessage("Category does not exist!");

        RuleFor(p => p.Name)
            .NotEmpty()
            .WithMessage("{PropertyName} is required")
            .NotNull()
            .MinimumLength(ValidationConstants.Subject.NameMinLength)
            .WithMessage("{PropertyName} must be at least {MinLength} characters");
    }

    private async Task<bool> CategoryMustExist(int id, CancellationToken arg2)
    {
        return await _categoryRepo.EntityExistsAsync(id);
    }
}
