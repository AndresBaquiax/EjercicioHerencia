using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioHerencia
{
    public partial class _Default : Page
    {
        static List<Alumnos> listAlumno = new List<Alumnos>();
        static List<Profesores> listProfesor = new List<Profesores>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void guardarAlumnos()
        {
            string fileName = Server.MapPath("~/Alumnos.txt");
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var dato in listAlumno)
            {
                writer.WriteLine(dato.noCarne);
                writer.WriteLine(dato.nombre);
                writer.WriteLine(dato.apellido);
                writer.WriteLine(dato.direccion);
                writer.WriteLine(dato.fechaNacimiento);
                writer.WriteLine(dato.notas);
                writer.WriteLine(dato.calculoEdad);
            }
            writer.Close();
        }
        public void leerAlumno()
        {
            string fileName = Server.MapPath("~/Alumnos.txt");
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Alumnos objAlumno = new Alumnos();
                objAlumno.noCarne = Convert.ToInt32(reader.ReadLine());
                objAlumno.nombre = reader.ReadLine();
                objAlumno.apellido = reader.ReadLine();
                objAlumno.direccion = reader.ReadLine();
                objAlumno.fechaNacimiento = Convert.ToDateTime(reader.ReadLine());
                objAlumno.notas = Convert.ToInt32(reader.ReadLine());
                objAlumno.calculoEdad = reader.ReadLine();
                listAlumno.Add(objAlumno);
            }
        }
        public void guardarProfesores()
        {
            string fileName = Server.MapPath("~/Profesores.txt");
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var dato in listProfesor)
            {
                writer.WriteLine(dato.nombre);
                writer.WriteLine(dato.apellido);
                writer.WriteLine(dato.direccion);
                writer.WriteLine(dato.titulo);
                writer.WriteLine(dato.fechaNacimiento);
                writer.WriteLine(dato.calculoEdad);
            }
            writer.Close();
        }
        public void leerProfesor()
        {
            string fileName = Server.MapPath("~/Profesores.txt");
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Profesores objProfesor = new Profesores();
                objProfesor.nombre = reader.ReadLine();
                objProfesor.apellido = reader.ReadLine();
                objProfesor.direccion = reader.ReadLine();
                objProfesor.titulo = reader.ReadLine();
                objProfesor.fechaNacimiento = Convert.ToDateTime(reader.ReadLine());
                objProfesor.calculoEdad = reader.ReadLine();
                listProfesor.Add(objProfesor);
            }
        }
        public int edadAlumnos()
        {
            DateTime fechaHoy = DateTime.Today;
            int edad = fechaHoy.Year - Calendar1.SelectedDate.Year;
            return edad;
        }
        public int edadProfesores()
        {
            DateTime fechaHoy = DateTime.Today;
            int edad = fechaHoy.Year - Calendar2.SelectedDate.Year;
            return edad;
        }
        protected void ButtonEdadAlumnos_Click(object sender, EventArgs e)
        {
            Alumnos objAlumnos = new Alumnos();
            objAlumnos.noCarne = Convert.ToInt32(TextBoxCarne.Text);
            objAlumnos.nombre = TextBoxNombreAlumnos.Text;
            objAlumnos.apellido = TextBoxApellidosAlumnos.Text;
            objAlumnos.direccion = TextBoxDireccionAlumnos.Text;
            objAlumnos.fechaNacimiento = Calendar1.SelectedDate;
            objAlumnos.notas = Convert.ToInt32(TextBoxNota.Text);
            objAlumnos.calculoEdad = edadAlumnos().ToString() ;
            listAlumno.Add(objAlumnos);
            guardarAlumnos();
        }

        protected void ButtonEdadProf_Click(object sender, EventArgs e)
        {
            Profesores objProfesores = new Profesores();
            objProfesores.nombre = TextBoxNombreProf.Text;
            objProfesores.apellido = TextBoxApellidoProf.Text;
            objProfesores.direccion = TextBoxDireccionProf.Text;
            objProfesores.titulo = TextBoxTitulo.Text;
            objProfesores.fechaNacimiento = Calendar2.SelectedDate;
            objProfesores.calculoEdad = edadProfesores().ToString();
            listProfesor.Add(objProfesores);
            guardarProfesores();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            leerAlumno();
            leerProfesor();
            GridView1.DataSource = listAlumno;
            GridView1.DataBind();
            GridView2.DataSource = listProfesor;
            GridView2.DataBind();
        }
    }
}