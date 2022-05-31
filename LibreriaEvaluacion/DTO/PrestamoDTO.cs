using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEvaluacion.DTO
{
    public class PrestamoDTO
    {
        // ToDo: atributos

        private int id;
        private int monto;


        // ToDo: propiedades

        public int Id { get => id; set => id = value; }
        public int Monto { get => monto; set => monto = value; }

        internal static bool RemoveAt(int indiceElementoBuscado)
        {
            throw new NotImplementedException();
        }

        internal static bool Add(PrestamoDTO dato)
        {
            throw new NotImplementedException();
        }

        // ToDo: métodos
        static List<PrestamoDTO> list = new List<PrestamoDTO>();
        internal static List<PrestamoDTO> datos;
    }
}
