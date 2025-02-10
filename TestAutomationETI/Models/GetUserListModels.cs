using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace GetUserListModels
{
    public record User(
        [property: JsonProperty("id")] int Id,
        [property: JsonProperty("email")] string email,
        [property: JsonProperty("first_name")] string firstName,
        [property: JsonProperty("last_name")] string lastName,
        [property: JsonProperty("avatar")] string avatar);

    public record GetUserListResponse(
        [property: JsonProperty("page")] int Page,
        [property: JsonProperty("per_page")] int PerPage,
        [property: JsonProperty("total")] int Total,
        [property: JsonProperty("total_pages")] int TotalPages,
        [property: JsonProperty("data")]IEnumerable<User> Data);
}