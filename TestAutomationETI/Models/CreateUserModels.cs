using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CreateUserModels
{
    public record CreateUserRequestModel(
        [Required] string Name, 
        [Required] string Job);
    public record CreateUserResponseModel(
        [Required][property: JsonProperty("id")] int Id, 
        [Required][property: JsonProperty("name")] string Name, 
        [Required][property: JsonProperty("job")] string Job, 
        [Required][property: JsonProperty("createdAt")] DateTime CreatedAt);
}