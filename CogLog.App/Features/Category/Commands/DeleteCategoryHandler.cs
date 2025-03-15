using CogLog.App.Contracts.Persistence;
using CogLog.App.Exceptions;
using MediatR;

namespace CogLog.App.Features.Category.Commands;

public class DeleteCategoryHandler(ICategoryRepo repo)
    : IRequestHandler<DeleteCategoryCommand, Unit>
{
    public async Task<Unit> Handle(
        DeleteCategoryCommand request,
        CancellationToken cancellationToken
    )
    {
        var categoryToDelete = await repo.GetCategoryAsync(request.Id);

        if (categoryToDelete == null)
        {
            throw new NotFoundException(nameof(Topic), request.Id);
        }

        await repo.DeleteCategoryAsync(categoryToDelete);

        return Unit.Value;
    }
}
