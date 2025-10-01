using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.DTO
{
    internal class DTODisciplinas
    {
        private string nome, diaDaSemana, turno, cargaHoraria, horario;
        private int idDisciplina;

        public string Nome { get => nome; set => nome = value; }
        public string DiaDaSemana { get => diaDaSemana; set => diaDaSemana = value; }
        public string Turno { get => turno; set => turno = value; }
        public string CargaHoraria { get => cargaHoraria; set => cargaHoraria = value; }
        public string Horario { get => horario; set => horario = value; }
        public int IdDisciplina { get => idDisciplina; set => idDisciplina = value; }
    }
}
