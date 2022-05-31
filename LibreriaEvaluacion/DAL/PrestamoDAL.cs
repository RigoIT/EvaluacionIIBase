using LibreriaEvaluacion.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEvaluacion.DAL
{
    public class PrestamoDAL
    {
        public bool Insertar(PrestamoDTO dato)
        {
            return PrestamoDTO.Add(dato);
        }
        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            int indiceElementoBuscado = BuscarPorId(id);

            if (indiceElementoBuscado >= 0)
            {
                return PrestamoDTO.RemoveAt(indiceElementoBuscado);
            }

            return false;
        }

        public int BuscarPorId(int id)
        {
            
            for (int i = 0; i < PrestamoDTO.datos.Count; i++)
            {
                if (PrestamoDTO.datos[i].Id == id) 
                {
                    return i;
                }
            }

            return -1;
        }

        public List<PrestamoDTO> Listar()
        {
            return PrestamoDTO.datos;
            
        }
    }
}

