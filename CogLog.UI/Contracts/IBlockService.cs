using CogLog.UI.Models;
using CogLog.UI.Models.Block;
using CogLog.UI.Services.Base;

namespace CogLog.UI.Contracts;

public interface IBlockService
{
    Task<List<BlockVm>> GetBlocksAsync();

    Task<BlockVm> GetBlockAsync(int id);
    Task<Response<Guid>> CreateBlockAsync(CreateBlockVm block);

    Task<Response<Guid>> EditBlockAsync(int id, BlockVm block);

    Task<Response<Guid>> DeleteBlockAsync(int id);
}
