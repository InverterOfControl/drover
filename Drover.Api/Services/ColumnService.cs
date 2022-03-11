using Drover.Api.Endpoints;
using Drover.Api.Factories;
using Drover.Contracts.Columns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

    public async Task<Column> CreateColumn(long projectId, string columnName)
    {
      var newColumn = new Column { Name = columnName };

      var request = new CreateColumnRequest { ProjectId = projectId };

      var response = await _api.CreateColumn(request, newColumn);

      return response.Column;
    }

    public async Task<Column> GetColumn(long projectId, long columnId)
    {
      var request = new SingleColumnRequest { ProjectId = projectId, ColumnId = columnId };

      var response = await _api.ShowColumn(request);

      return response.Column;
    }

    public async Task<IList<Column>> GetColumns(long projectId)
    {
      var request = new ListColumnRequest { ProjectId = projectId };

      var response = await _api.ListColumns(request);

      return response.Columns;
    }

    public async Task<Column> UpdateColumn(long projectId, long columnId, string newColumnName)
    {
      var newColumn = new Column { Name = newColumnName };

      var request = new UpdateColumnRequest { ProjectId = projectId, ColumnId = columnId };

      var response = await _api.UpdateColumn(request, newColumn);

      return response.Column;
    }
  }
}
