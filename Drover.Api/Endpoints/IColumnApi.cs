using Drover.Contracts.Columns;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Drover.Api.Endpoints
{
  internal interface IColumnApi
  {
    [Get("/api_v2/projects/{request.project_id}/columns.json")]
    Task<MultipleColumnResponse> ListColumns(ListColumnRequest request, CancellationToken cancellationToken);

    [Get("/api_v2/projects/{request.project_id}/columns/{request.column_id}.json")]
    Task<SingleColumnResponse> ShowColumn(SingleColumnRequest request, CancellationToken cancellationToken);

    [Post("/api_v2/projects/{request.project_id}/columns.json")]
    Task<SingleColumnResponse> CreateColumn(CreateColumnRequest request, [Body] Column column, CancellationToken cancellationToken);

    [Put("/api_v2/projects/{request.project_id}/columns/{request.column_id}.json")]
    Task<SingleColumnResponse> UpdateColumn(UpdateColumnRequest request, [Body] Column column, CancellationToken cancellationToken);
  }
}
