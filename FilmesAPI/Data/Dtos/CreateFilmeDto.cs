﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O campo titulo e obrigatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor e obrigatorio")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O genero nao pode passar de 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve ter no minimo 1 e no maximo 600 minutos")]
        public int Duracao { get; set; }
    }
}
