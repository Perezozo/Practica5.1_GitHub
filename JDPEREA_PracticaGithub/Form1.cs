using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JDPEREA_PracticaGithub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Alumnos misAlumnos = new Alumnos();

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno miAlumno = new Alumno();
            String miAlumnoStr;
            
            // Se asigna a la clase alumno la "variable" nombre del textbox aluNombre

            miAlumno.Nombre = aluNombre.Text;

            // Se asigna a la clase alumno la "variable" nota del textbox aluNota


            miAlumno.Nota = Convert.ToInt32(aluNota.Text);
            miAlumnoStr = aluNombre.Text + " " + aluNota.Text + (miAlumno.Aprobado ? " Aprobado" : " Suspenso") + "\n";
            
            // generamos el listado en el textbox listaAlumnos con la cadena
            // miAlumnoStr

            listaAlumnos.AppendText(miAlumnoStr);
            misAlumnos.Agregar(miAlumno);
        }
    }
    class Alumno
    {
        private string nombre;
        private int nota;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Nota
        {
            get { return nota; }
            set
            {
                if (value >= 0 && value <= 10)  // antes de asignar el valor de nota en Nota( variable publica)
                    nota = value;               // se comprueba que esté entre 0 y 10
            }
        }
        public Boolean Aprobado  // funcion booleana que devuelve true si la nota es >= 5
        {
            get
            {
                if (nota >= 5)
                    return true;
                else
                    return false;
            }
        }
    }

    class Alumnos
    {
        private ArrayList listaAlumnos = new ArrayList();

        // Agrega un nuevo alumno a la lista
        //        
        public void Agregar(Alumno alu)
        {
            listaAlumnos.Add(alu);
        }

        // Devuelve el alumno que está en la posición num
        //
        public Alumno Obtener(int num)
        {
            if (num >= 0 && num <= listaAlumnos.Count)
            {
                return ((Alumno)listaAlumnos[num]);
            }
            return null;
        }

        // Devuelve la nota media de los alumnos
        //
        public float Media      
        {
            get
            {
                if (listaAlumnos.Count == 0)
                    return 0;
                else
                {
                    float media = 0;
                    for (int i = 0; i < listaAlumnos.Count; i++)
                    {
                        media += ((Alumno)listaAlumnos[i]).Nota;
                    }
                    return (media / listaAlumnos.Count);
                }
            }
        }
    }
}
