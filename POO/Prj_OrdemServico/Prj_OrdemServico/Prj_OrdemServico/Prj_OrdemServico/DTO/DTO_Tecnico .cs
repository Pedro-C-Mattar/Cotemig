using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_Tecnico
    {
        private int id, espec_id;
        private string nome;
           
        public int Espec_id
        {
            get
            {
                return espec_id;
            }

            set
            {
                espec_id = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {  
                id = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }
    }
}
