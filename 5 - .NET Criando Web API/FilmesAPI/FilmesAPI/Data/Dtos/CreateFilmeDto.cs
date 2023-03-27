﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class CreateFilmeDto
{
   [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [StringLength(100, ErrorMessage = "O tamanho do gênero não pode exceder 100 caracteres")]
    public string Genero { get; set; }

    [Required]
    [Range(70, 600, ErrorMessage = "A duração deve ser entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
