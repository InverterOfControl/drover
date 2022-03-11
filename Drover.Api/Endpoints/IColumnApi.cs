using Drover.Contracts.Columns;
using Refit;

namespace Drover.Api.Endpoints
{
  internal interface IColumnApi
  {
    [Get("/api_v2/projects/{request.project_id}/columns.json")]
    Task<MultipleColumnResponse> ListColumns(ListColumnRequest request);

    [Get("/api_v2/projects/{request.project_id}/columns/{request.column_id}.json")]
    Task<SingleColumnResponse> ShowColumn(SingleColumnRequest request);

    [Post("/api_v2/projects/{request.project_id}/columns.json")]
    Task<SingleColumnResponse> CreateColumn(CreateColumnRequest request, [Body] Column column);

    [Put("/api_v2/projects/{request.project_id}/columns/{request.column_id}.json")]
    Task<SingleColumnResponse> UpdateColumn(UpdateColumnRequest request, [Body] Column column);
  }
}
