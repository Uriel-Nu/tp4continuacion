using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace materias1
{
    class lista
    {
        public lista ()
        {
            DT.TableName = "notas de materias";
            DT.Columns.Add("nombre");
            DT.Columns.Add("tp1");
            DT.Columns.Add("tp2");
            DT.Columns.Add("tp3");
            DT.Columns.Add("tp4");
            DT.Columns.Add("nota final");
            leerArchivo();
        }
        public DataTable DT { get; set; } = new DataTable();
        public void registrar(string nombre,int tp1,int tp2,int tp3, int tp4,int notafinal)
        {
            materia materias = new materia();
            materias.nombre = nombre;
            materias.tp1 = tp1;
            materias.tp2 = tp2;
            materias.tp3 = tp3;
            materias.tp4 = tp4;
            materias.notaFinal = notafinal;

            DT.Rows.Add();
            int nuevoregistro = DT.Rows.Count - 1;

            DT.Rows[nuevoregistro]["nombre"] = materias.nombre;
            DT.Rows[nuevoregistro]["tp1"] = materias.tp1.ToString();
            DT.Rows[nuevoregistro]["tp2"] = materias.tp2.ToString();
            DT.Rows[nuevoregistro]["tp3"] = materias.tp3.ToString();
            DT.Rows[nuevoregistro]["tp4"] = materias.tp4.ToString();
            DT.Rows[nuevoregistro]["nota final"] = materias.notaFinal.ToString();
            DT.WriteXml("notas.xml");
        }
        public void leerArchivo()
        {
            if (System.IO.File.Exists("notas.xml") )
            {
                DT.Clear();
                DT.ReadXml("notas.xml");

            }
        }
    }
}
