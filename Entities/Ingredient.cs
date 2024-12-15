using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace RangoWeb.API.Entities;

public class Ingredient
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public required string Nome { get; set; }

    public ICollection<Rango> Rangos { get; set; } = [];

    public Ingredient()
    {

    }

    [SetsRequiredMembers]
    public Ingredient(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }
}