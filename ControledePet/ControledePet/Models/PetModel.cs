﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ControledePet.Models
{
    public class PetModel
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Raca { get; set; }
        public string Genero { get; set; }

    }
}
