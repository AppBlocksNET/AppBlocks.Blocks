using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBlocks.Blocks
{
    public interface IBlock<T>
    {
        Task<IEnumerable<T>> ExecuteAsync(Dictionary<string, string> settings = null);
    }
}