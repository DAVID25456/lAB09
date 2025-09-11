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
using PG02_LAB09_MOSQUITO_LUIS.Clases;

namespace PG02_LAB09_MOSQUITO_LUIS
{
    public partial class Frm_Estudiantes : Form
    {
        ArrayList aEstudiante = new ArrayList();
        clsestudiante objEstudiante = new clsestudiante();

        public Frm_Estudiantes()
        {
            InitializeComponent();
            
            txtnombre.Enabled = false;
            txtapellido.Enabled = false;
            txtnumero.Enabled = false;
            txtemail.Enabled = false;

            btnguardar.Enabled = false;
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void mtdPermitirBotones(bool a,bool b, bool c, bool d, bool e)
        {
            btnnuevo.Enabled = a;
            btnguardar.Enabled = b;
            btnmodificar.Enabled = c;
            btneliminar.Enabled= d;
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
            if (aEstudiante.Count < 1)
            {
                return "E001";
            }
            else
            {
                foreach (clsestudiante i in aEstudiante)
                {
                    codigo = i.codigo.ToString();
                }
            }
            return "E" + (int.Parse(codigo.Substring(1, 3)) + 1).ToString("000");
        }

        private void mtdListarEstudiante()
        {
            dgvEstudiante.Rows.Clear();
            foreach (clsestudiante e in aEstudiante)
            {
                dgvEstudiante.Rows.Add(e.codigo, e.nombre, e.apellido, e.numerodocumento, e.email);
            }
        }

        private void Frm_Estudiantes_Load(object sender, EventArgs e)
        {
            txtcodigo.Text = mtdGenerarCodigo();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnombre.Enabled = true;
            txtapellido.Enabled = true;
            txtnumero.Enabled = true;
            txtemail.Enabled = true;

            mtdPermitirBotones(false,true,false,false,true);
            mTdLimpiarControles();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
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

                objEstudiante.codigo = txtcodigo.Text;
                objEstudiante.nombre = txtnombre.Text;
                objEstudiante.email = txtemail.Text;
                objEstudiante.apellido = txtapellido.Text;
                objEstudiante.numerodocumento = txtnumero.Text;

                aEstudiante.Add(objEstudiante);

                mtdListarEstudiante();

                txtcodigo.Text = mtdGenerarCodigo();
                mtdPermitirBotones(true, false, false, false, true);
                mTdLimpiarControles();

            }
            catch (Exception)
            {
                MessageBox.Show("Error! no se registro al estudiante");
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (clsestudiante estudiante in aEstudiante)
                {
                    if (estudiante.codigo == txtcodigo.Text)
                    {
                        estudiante.nombre = txtnombre.Text;
                        estudiante.apellido = txtapellido.Text;
                        estudiante.numerodocumento = txtnumero.Text;
                        estudiante.email = txtemail.Text;

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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (clsestudiante estudiante in aEstudiante)
                {
                    if (estudiante.codigo == txtcodigo.Text)
                    {
                        aEstudiante.Remove(estudiante);

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

        

        private void dgvEstudiante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEstudiante.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtcodigo.Text = dgvEstudiante.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnombre.Text = dgvEstudiante.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtapellido.Text = dgvEstudiante.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtnumero.Text = dgvEstudiante.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtemail.Text = dgvEstudiante.Rows[e.RowIndex].Cells[4].Value.ToString();

            mtdPermitirBotones(false, false, true, true, true);
        }
    }
}
