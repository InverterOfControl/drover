using Drover.Contracts.Columns;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
  public interface IColumnService
  {
    Task<IList<Column>> GetColumns(long projectId, CancellationToken cancellationToken);

    Task<Column> GetColumn(long projectId, long columnId, CancellationToken cancellationToken);

    Task<Column> CreateColumn(long projectId, string columnName, CancellationToken cancellationToken);

    Task<Column> UpdateColumn(long projectId, long columnId, string newColumnName, CancellationToken cancellationToken);
  }
}
