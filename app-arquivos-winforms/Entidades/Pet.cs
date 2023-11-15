using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace app_arquivos_winforms.Entidades
{
    public class Pet
    {
        public Pet()
        {
            Id = Guid.NewGuid().ToString().Substring(0, 8);
        }
        public string? Id { get; set; }
        public string? Nome { get; set; }
        public string? Raca { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public string? Porte { get; set; }
        public DateTime DataVacinacao { get; set; }

        public override string ToString()
        {
            return $"{Id};{Nome};{Raca};{Idade};{Peso};{Porte}";
        }
    }
}
