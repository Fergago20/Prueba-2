using Estudiante.estructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiante
{
    public partial class Form1 : Form
    {
        List<Alumno> alumnoList= new List<Alumno>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                
                Alumno alumno = new Alumno();
                alumno.Nombre= tbNombre.Text;
                alumno.Apellido=tbApellido.Text;
                alumno.NotaFinal= double.Parse(tbNota.Text);
                alumno.NotaLetra=CalcularLetra(alumno.NotaFinal);
                if(alumno.NotaFinal>=0 && alumno.NotaFinal <= 100)
                {
                    alumnoList.Add(alumno);
                    MergeSort(alumnoList, 0, (alumnoList.Count - 1));
                }
                else
                {
                    MessageBox.Show("Error de rango de notas");
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void MergeSort(List<Alumno> alumnos, int left, int right)
        {
            if(left < right)
            {
                int mid= (left + right )/2;
                MergeSort(alumnos, left, mid);
                MergeSort(alumnos, mid+1, right);
                Merge(alumnos, left, mid, right);
            }
        }

        public void Merge(List<Alumno>alumnos, int left,int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            List<Alumno> alumnos1 = new List<Alumno>();
            List<Alumno> alumnos2 = new List<Alumno>();

            for (int i = 0; i < n1; i++)
            {
                alumnos1.Add(alumnos[left + i]);
            }

            for (int j = 0; j < n2; j++)
            {
                alumnos2.Add(alumnos[mid + 1 + j]);
            }

            int i1 = 0;
            int j1 = 0;
            int k = left;

            while (i1 < n1 && j1 < n2)
            {
                if (alumnos1[i1].NotaFinal <= alumnos2[j1].NotaFinal)
                {
                    alumnos[k] = alumnos1[i1];
                    i1++;
                }
                else
                {
                    alumnos[k] = alumnos2[j1];
                    j1++;
                }
                k++;
            }

            while (i1 < n1)
            {
                alumnos[k] = alumnos1[i1];
                i1++;
                k++;
            }

            while (j1 < n2)
            {
                alumnos[k] = alumnos2[j1];
                j1++;
                k++;
            }

        }

        private char CalcularLetra(double nota)
        {
            if(nota < 50)
            {
                return 'F';
            }else if(nota >50 && nota < 60)
            {
                return 'D';
            }else if(nota >60 && nota < 70)
            {
                return 'C';
            }else if(nota >70 && nota < 80)
            {
                return 'B';
            }
            else
            {
                return 'A';
            }
        }

        private void Observar_Click(object sender, EventArgs e)
        {
            dgvSalida.DataSource = null;
            dgvSalida.DataSource = alumnoList;
        }
    }
}
