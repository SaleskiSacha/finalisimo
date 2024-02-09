using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalisimo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            InitializeDefaultValues();
        }
        public struct Alquiler
        {
            public string NombreCliente;
            public string TipoDeBicicleta;
            public int CantidadDias;
            public decimal ImporteTotal;
        }
        Alquiler[] alquiler;
        int Posición;
        private void InitializeDefaultValues()
        {
            // Inicializar valores por defecto
            txtDias.Text = "1";
            btnRegistrar.Enabled = false;
        }
        private void InitializeComboBox()
        {
            // Inicializar el ComboBox con los tipos de bicicletas
            comboBoxTipoBicicleta.Items.AddRange(new string[] { "Adulto de Paseo", "Adulto Mountain Bike", "Niño de Paseo" });
            comboBoxTipoBicicleta.SelectedIndex = 0; // Seleccionar el primer tipo por defecto
        }
        private bool ValidardDatos()
        {
            // Validar que todos los campos estén completos y sean válidos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDias.Text)) 
                return false;//null es para verificar si tiene caracteres escritos

            if (txtNombre.Text.Length < 3)
            {
                MessageBox.Show("El nombre del cliente debe tener al menos 3 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtDias.Text, out int dias) || dias < 1 || dias > 3) //try parse convierte el numero
            {
                MessageBox.Show("La cantidad de días debe ser un valor numérico entre 1 y 3.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void CalculoTotal() 
        {
            // Calcular el importe total según la selección del usuario
            decimal subtotal = 0;

            switch (comboBoxTipoBicicleta.SelectedIndex)
            {
                case 0: // Adulto de Paseo
                    subtotal = 3000 * int.Parse(txtDias.Text);
                    break;
                case 1: // Adulto Mountain Bike
                    subtotal = 3500 * int.Parse(txtDias.Text);
                    break;
                case 2: // Niño de Paseo
                    subtotal = 2000 * int.Parse(txtDias.Text);
                    break;
            }

            if (chkCasco.Checked)
                subtotal += 300 * int.Parse(txtDias.Text);

            if (chkProtecciones.Checked)
                subtotal += 500 * int.Parse(txtDias.Text);

            if (chkPago.Checked)
                subtotal -= subtotal * 0.1m; // Aplicar descuento del 10%

            txtImporte.Text = subtotal.ToString("C");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //crear el arreglo de 30 Elementos 
            alquiler = new Alquiler[30];
            Posición = 0;
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Posición == alquiler.Length)
            {
                MessageBox.Show("No es posible seguir cargando datos");
            }
            else
            {
                string Tipo;
                if (optMountain.Checked == true)
                {
                    Tipo = "Mountain bike";
                }
                else
                {
                    Tipo = "Todos";
                }
                if (ValidardDatos())
                {
                    alquiler[Posición].NombreCliente = txtNombre.Text;
                    alquiler[Posición].ImporteTotal = decimal.Parse(txtImporte.Text.Replace("$", "").Trim());
                    alquiler[Posición].CantidadDias = int.Parse(txtDias.Text);
                    alquiler[Posición].TipoDeBicicleta = Tipo;
                    MessageBox.Show("Alquiler registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Posición++; //SE incrementa el indice 
                            //controlar si se completo el vector
                if (Posición == 30)
                {
                    btnRegistrar.Enabled = false;
                    MessageBox.Show("Datos completos, no se pueden agregar más");
                }
            }

            
            // limpiar la interfaz
            ResetForm();
            
        }
        private void ResetForm()
        {
            // Reiniciar la interfaz a su estado inicial
            txtNombre.Clear();
            InitializeDefaultValues();
            comboBoxTipoBicicleta.SelectedIndex = 0;
            chkCasco.Checked = false;
            chkProtecciones.Checked = false;
            chkPago.Checked = false;
            txtImporte.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgv1.Rows.Clear();
            Int32 i = 0;
            while (i < Posición)
            {
                if (optTodos.Checked)
                {
                    
                    
                        dgv1.Rows.Add(alquiler[i].TipoDeBicicleta, alquiler[i].NombreCliente, alquiler[i].CantidadDias, alquiler[i].ImporteTotal);

                    
                }
                else
                {
                    if (alquiler[i].TipoDeBicicleta == comboBoxTipoBicicleta.Text && alquiler[i].TipoDeBicicleta == "Mountain bike")
                    {
                        dgv1.Rows.Add(alquiler[i].TipoDeBicicleta, alquiler[i].NombreCliente, alquiler[i].CantidadDias, alquiler[i].ImporteTotal);
                    }

                }
                i++;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!ValidardDatos())
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnRegistrar.Enabled = true;
            CalculoTotal();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
