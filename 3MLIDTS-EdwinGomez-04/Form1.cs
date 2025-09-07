using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3MLIDTS_EdwinGomez_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*txtEdad.TextChanged += validarEdad;
            txtEstatura.TextChanged += validarEstatura;
            txtApellido.TextChanged += validarApellido;
            txtNombre.TextChanged += validarNombre;
            txtTelefono.TextChanged += validarTelefono;*/
        }
        private void validarNombre(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextovalidar(textBox.Text))
            {
                MessageBox.Show("Porfavor ingrese valores corretos par el nombre", "Error Nombre",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
        private bool EsTextovalidar(string texto)
        {
            return Regex.IsMatch(texto, @"^[a-zA-Z\s]+$");
        }
        private void validarApellido(object sender, EventArgs e)
        {
        }
        private void validarTelefono(object sender, EventArgs e)
        {
        }
        private void validarEstatura(object sender, EventArgs e)
        {
        }
        private void validarEdad(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEstatura.Clear();
            txtTelefono.Clear();
            txtEdad.Clear();
            rbMasculino.Checked = false;
            rbFemenino.Checked = false;

          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombres = txtNombre.Text;
            string apellidos = txtApellido.Text;
            string estatura = txtEstatura.Text;
            string edad = txtEdad.Text;
            string telefono = txtTelefono.Text;
            string genero = "";
            if (rbMasculino.Checked)
            {
                genero = "Homebres";

            }
            else if (rbFemenino.Checked)
            {
                genero = "Femenino";
            }
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtEstatura.Text) &&
                !string.IsNullOrEmpty(txtTelefono.Text) && !string.IsNullOrEmpty(txtEdad.Text))
            {
                string datos = $"Nombre: {nombres}\r\nApellido: {apellidos}\r\nTelefono: {telefono}\r\nEstatura: {estatura}cm\r\nEdad: {edad}\r\nGenero: {genero}\r\n ";

                //MessageBox.Show(datos,"Infromacion de Registro",MessageBoxButtons.OK,MessageBoxIcon.Information);
                string ruta = "C:/Users/gomez/OneDrive/Documentos/EMMA/Materia 3/PA/3MDatosAgoto2025.txt";
                bool archivoExiste = File.Exists(ruta);
                using (StreamWriter writer = new StreamWriter(ruta, true))
                {
                    if (archivoExiste)
                    {
                        writer.WriteLine();
                    }
                    writer.WriteLine(datos);

                }

            }
            
            else
            {
                MessageBox.Show("Ingrese valor en los campos asignados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
            }
         }
    }
}
