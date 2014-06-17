using System.Collections.Generic;

namespace TDDandBBDD1
{
    public class WflLeerMatriculado
    {
        public List<Matriculados> leerMatriculados()
        {
            List<Matriculados> listaMatriculados = new List<Matriculados>();
            listaMatriculados.Add(new Matriculados());
            return listaMatriculados;
        }
    }
}