using System.ComponentModel.DataAnnotations;

namespace GameStore.API.Dtos;

public record class CreateGameDto(
    [Required][StringLength(50)] string Name, 
    int GenreId, 
    [Range(0,100)]decimal Price, 
    DateOnly ReleaseDate
);