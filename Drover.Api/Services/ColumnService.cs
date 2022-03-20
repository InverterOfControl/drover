using Drover.Api.Endpoints;
using Drover.Api.Factories;
using Drover.Contracts.Columns;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
    public class ColumnService : BaseService, IColumnService
  {
    private readonly IColumnApi _api;

    public ColumnService(IBugherdConnection connection) : base(connection)
    {
      _api = CreateApi<IColumnApi>();
    }

    public async Task<Column> CreateColumn(long projectId, string columnName, CancellationToken cancellationToken)
    {
      var newColumn = new Column { Name = columnName };

      var request = new CreateColumnRequest { ProjectId = projectId };

      var response = await _api.CreateColumn(request, newColumn, cancellationToken).ConfigureAwait(false);

      return response.Column;
    }

    public async Task<Column> GetColumn(long projectId, long columnId, CancellationToken cancellationToken)
    {
      var request = new SingleColumnRequest { ProjectId = projectId, ColumnId = columnId };

      var response = await _api.ShowColumn(request, cancellationToken).ConfigureAwait(false);

      return response.Column;
    }

    public async Task<IList<Column>> GetColumns(long projectId, CancellationToken cancellationToken)
    {
      var request = new ListColumnRequest { ProjectId = projectId };

      var response = await _api.ListColumns(request, cancellationToken).ConfigureAwait(false);

      return response.Columns;
    }

    public async Task<Column> UpdateColumn(long projectId, long columnId, string newColumnName, CancellationToken cancellationToken)
    {
      var newColumn = new Column { Name = newColumnName };

      var request = new UpdateColumnRequest { ProjectId = projectId, ColumnId = columnId };

      var response = await _api.UpdateColumn(request, newColumn, cancellationToken).ConfigureAwait(false);

      return response.Column;
    }
  }
}
