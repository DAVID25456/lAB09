using PG02_LAB09_MOSQUITO_LUIS.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG02_LAB09_MOSQUITO_LUIS
{
    public partial class Frm_Docentes : Form
    {
        ArrayList aDocente = new ArrayList();

        public Frm_Docentes()
        {
            InitializeComponent();

            EstadoTextBox(false);

            btnguardar.Enabled = false;
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
        }

        public bool ValidarEmail(string Email)
        {
            if (string.IsNullOrEmpty(Email))
            {
                return false;
            }

            return Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        //Verifica si el texto es solo numero
        //Usar la funcion Regex
        //@"^[0-9]+$" --> para definir solo numeros
        private bool SoloNumeros(string texto)
        {
            return Regex.IsMatch(texto, @"^[0-9]+$");
        }

        private void EstadoTextBox(bool a)
        {
            txtnombre.Enabled = a;
            txtapellido.Enabled = a;
            txtnumero.Enabled = a;
            txtemail.Enabled = a;
        }

        private void VerificarCamposVacios()
        {
            if (string.IsNullOrEmpty(txtnombre.Text) && string.IsNullOrEmpty(txtapellido.Text) && string.IsNullOrEmpty(txtnumero.Text) && string.IsNullOrEmpty(txtemail.Text))
            {
                MessageBox.Show("Todo los campos estan vacios");
                return;
            }

            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                MessageBox.Show("El campo nombre se encuentra vacio");
                return;
            }

            if (string.IsNullOrEmpty(txtapellido.Text))
            {
                MessageBox.Show("El campo apellido se encuentra vacio");
                return;
            }

            if (string.IsNullOrEmpty(txtnumero.Text))
            {
                MessageBox.Show("El campo numero de documento se encuentra vacio");
                return;
            }

            if (string.IsNullOrEmpty(txtemail.Text))
            {
                MessageBox.Show("El campo Email se encuentra vacio");
                return;
            }
        }

        private void mtdPermitirBotones(bool a, bool b, bool c, bool d, bool e)
        {
            btnnuevo.Enabled = a;
            btnguardar.Enabled = b;
            btnmodificar.Enabled = c;
            btneliminar.Enabled = d;
            btnsalir.Enabled = e;
        }

        private void mTdLimpiarControles()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtnumero.Clear();
            txtemail.Clear();
        }

        private string mtdGenerarCodigo()
        {
            string codigo = "";
            if (aDocente.Count < 1)
            {
                return "E001";
            }
            else
            {
                foreach (clsPersona i in aDocente)
                {
                    codigo = i.codigo.ToString();
                }
            }
            return "E" + (int.Parse(codigo.Substring(1, 3)) + 1).ToString("000");
        }

        private void mtdListarEstudiante()
        {
            dgvDocentes.Rows.Clear();
            foreach (clsPersona e in aDocente)
            {
                dgvDocentes.Rows.Add(e.codigo, e.nombre, e.apellido, e.numerodocumento, e.email);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnombre.Enabled = true;
            txtapellido.Enabled = true;
            txtnumero.Enabled = true;
            txtemail.Enabled = true;

            mtdPermitirBotones(false, true, false, false, true);
            mTdLimpiarControles();
        }

        private void Frm_Docentescs_Load(object sender, EventArgs e)
        {
            txtcodigo.Text = mtdGenerarCodigo();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                //No permitir el ingreso de Datos Vacios
                VerificarCamposVacios();

                if (!SoloNumeros(txtnumero.Text))
                {
                    MessageBox.Show("Solo puede ingresar numeros en el Numero de Documento");
                    return;
                }

                if (!ValidarEmail(txtemail.Text))
                {
                    MessageBox.Show("Ese no es el dominio");
                    return;
                }

                foreach (DataGridViewRow row in dgvDocentes.Rows)
                {
                    if (row.IsNewRow) continue;

                    string codigo = row.Cells[0].Value?.ToString();
                    string nombre = row.Cells[1].Value?.ToString();
                    string apellido = row.Cells[2].Value?.ToString();
                    string numero = row.Cells[3].Value?.ToString();
                    string email = row.Cells[4].Value?.ToString();

                    if (codigo == txtcodigo.Text ||
                        (nombre == txtnombre.Text && apellido == txtapellido.Text) || numero == txtnumero.Text || email == txtemail.Text)
                    {
                        MessageBox.Show("⚠ El estudiante ya existe (mismo código o mismo nombre y apellido).");
                        return;
                    }
                }

                clsPersona ObjPersona = new clsPersona();

                ObjPersona.codigo = txtcodigo.Text;
                ObjPersona.nombre = txtnombre.Text;
                ObjPersona.email = txtemail.Text;
                ObjPersona.apellido = txtapellido.Text;
                ObjPersona.numerodocumento = txtnumero.Text;

                aDocente.Add(ObjPersona);

                mtdListarEstudiante();

                txtcodigo.Text = mtdGenerarCodigo();
                mtdPermitirBotones(true, false, false, false, true);
                mTdLimpiarControles();

            }
            catch (Exception)
            {
                MessageBox.Show("Error! no se registro al estudiante");
            }

            EstadoTextBox(false);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            EstadoTextBox(true);

            try
            {
                VerificarCamposVacios();
                foreach (clsPersona estudiante in aDocente)
                {
                    if (estudiante.codigo == txtcodigo.Text)
                    {
                        estudiante.nombre = txtnombre.Text;
                        estudiante.apellido = txtapellido.Text;
                        estudiante.numerodocumento = txtnumero.Text;

                        bool band = true;

                        do
                        {
                            if (ValidarEmail(txtemail.Text))
                            {
                                estudiante.email = txtemail.Text;
                                band = false;
                            }
                            else
                            {
                                MessageBox.Show("Ese no es el dominio");
                                return;
                            }
                        }
                        while (band);

                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar los datos del estudiante");
            }

            txtcodigo.Text = mtdGenerarCodigo();

            mtdListarEstudiante();
            mTdLimpiarControles();

            EstadoTextBox(false);
            mtdPermitirBotones(true, false, false, false, true);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (clsPersona estudiante in aDocente)
                {
                    if (estudiante.codigo == txtcodigo.Text)
                    {
                        aDocente.Remove(estudiante);

                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar los datos del estudiante");
            }

            txtcodigo.Text = mtdGenerarCodigo();

            mtdListarEstudiante();
            mTdLimpiarControles();

            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                mTdLimpiarControles();
            }
        }

        private void dgvEstudiante_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EstadoTextBox(true);

            dgvDocentes.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtcodigo.Text = dgvDocentes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnombre.Text = dgvDocentes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtapellido.Text = dgvDocentes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtnumero.Text = dgvDocentes.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtemail.Text = dgvDocentes.Rows[e.RowIndex].Cells[4].Value.ToString();

            mtdPermitirBotones(false, false, true, true, true);
        }
    }
}
