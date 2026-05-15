using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_Usuario
    {
        private int id, setor_id;
        private string nome, tel, email;

        public string Email
        {
            get
            { 
                return email;
            }

            set
            {
                email = value;
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

        public int Setor_id
        {
            get
            {
                return setor_id;
            }

            set
            {
                setor_id = value;
            }
        }

        public string Tel
        {
            get
            {
                return tel;
            }

            set
            {
                tel = value;
            }
        }
    }
}
