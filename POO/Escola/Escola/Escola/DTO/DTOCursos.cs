using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.DTO
{
    internal class DTOCursos
    {
        private string nome, turno, periodo, cargaHoraria;
        private int idCurso;

        public string Nome { get => nome; set => nome = value; }
        public string Turno { get => turno; set => turno = value; }
        public string Periodo { get => periodo; set => periodo = value; }
        public string CargaHoraria { get => cargaHoraria; set => cargaHoraria = value; }
        public int IdCurso { get => idCurso; set => idCurso = value; }
    }
}
