using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace materias
{
    public class Ingles
    {
        private static readonly object tp1;
        private static object tp2;
        private static object tp3;
        private static object primer;
        private static object parcial;
        private static object tp4;
        private static object tp5;
        private static object tp6;
        private static object final;

        public DataTable DT { get; set; } = new DataTable();
        
        //public Ingles Nin { get; set; } = new Ingles();
        public Ingles()
            
            
        {
           
            DT.TableName = "notas de ingles";
            DT.Columns.Add("tp1");
            DT.Columns.Add("tp2");
            DT.Columns.Add("tp3");
            DT.Columns.Add(" primer parcial");
            DT.Columns.Add("tp4");
            DT.Columns.Add("tp5");
            DT.Columns.Add("tp6");
            DT.Columns.Add("segundo parcial ");
            DT.Columns.Add("NOTA FINAL");

            

        }
        public void LeerDeArchivo()
        {
            if (System.IO.File.Exists("Nin.xml"))
            {
                DT.Clear();
                DT.ReadXml("Nin.xml");
                

            }
        }
    public void Registrar(materia)
        {
            DT.Rows.Add();
            int RegistroNuevo = DT.Rows.Count - 1;
            DT.Rows[RegistroNuevo]["tp1"] = Ingles.tp1.ToString();
            DT.Rows[RegistroNuevo]["tp2"] = Ingles.tp2.ToString();
            DT.Rows[RegistroNuevo]["tp3"] = Ingles.tp3.ToString();
            DT.Rows[RegistroNuevo]["parcial"] = Ingles.parcial.ToString();
            DT.Rows[RegistroNuevo]["tp4"] = Ingles.tp4.ToString();
            DT.Rows[RegistroNuevo]["tp5"] = Ingles.tp5.ToString();
            DT.Rows[RegistroNuevo]["tp6"] = Ingles.tp6.ToString();
            DT.Rows[RegistroNuevo]["parcial"] = Ingles.parcial.ToString();
            DT.Rows[RegistroNuevo]["final"] = Ingles.final.ToString();

            LeerDeArchivo();

        }
    }
    
    
	

	}


        



