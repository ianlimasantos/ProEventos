using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string DataEvento {get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório"),
         StringLength(50, MinimumLength = 4, ErrorMessage ="Deve ter no mínimo 4 e no máximo 50 caracteres")
        // MinLength(4, ErrorMessage = "{0} deve ter no mínimo 4 caracteres"),
        // MaxLength(50, ErrorMessage = "{0} deve ter no máximo 50 caracteres")
        ]
        public string Tema {get; set; }
        
        [Display(Name = "Quantidade de pessoas")]
        [Range(1, 120000, ErrorMessage = "O campo {0} não pode ser maior que 1, nem maior que 120.000")]
        public int QtdPessoas {get; set; }

        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$", ErrorMessage = "Não é uma imagem válida (gif, jpg, jpeg, bmp ou png)")]
        public string ImagemURL{get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório"),
         Phone(ErrorMessage ="O campo {0} está com número inválido")]
        
        public string Telefone{get; set;}

        [Display(Name ="e-mail"),
         Required(ErrorMessage = "O campo {0} é obrigatório"),
         EmailAddress(ErrorMessage = "O campo {0} deve ser um email válido")]
        public string Email{get; set;}
        public IEnumerable<LoteDto> Lotes {get ; set; }
        public IEnumerable<RedeSocialDto> RedesSociais {get ; set; }
        public IEnumerable<PalestranteDto> PalestrantesEventos{get; set;}
    }
}