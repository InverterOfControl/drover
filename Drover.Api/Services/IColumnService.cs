using Drover.Contracts.Columns;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
  public interface IColumnService
  {
    Task<IList<Column>> GetColumns(long projectId);

    Task<Column> GetColumn(long projectId, long columnId);

    Task<Column> CreateColumn(long projectId, string columnName);

    Task<Column> UpdateColumn(long projectId, long columnId, string newColumnName);
  }
}
