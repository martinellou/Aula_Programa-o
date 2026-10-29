using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimColecoes.Models
{
    public class RegistroNota
    {
        public string Estudante { get; set; } = "";
        public string Disciplina { get; set; } = "";
        public decimal Nota { get; set; } = 0;
    }
}
