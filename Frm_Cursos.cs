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
    public partial class Frm_Cursos : Form
    {
        ArrayList aCurso = new ArrayList();

        public Frm_Cursos()
        {
            InitializeComponent();

            EstadoTextBox(false);

            btnguardar.Enabled = false;
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private bool SoloNumeros(string texto)
        {
            return Regex.IsMatch(texto, @"^[0-9]+$");
        }

        private void EstadoTextBox(bool a)
        {
            txtCurso.Enabled = a;
            txt_Horas_Teoricas.Enabled = a;
            txtCreditos.Enabled = a;
            txt_Horas_Practicas.Enabled = a;
        }

        private void VerificarCamposVacios()
        {
            if (string.IsNullOrEmpty(txtCurso.Text) && string.IsNullOrEmpty(txt_Horas_Teoricas.Text) && string.IsNullOrEmpty(txtCreditos.Text) && string.IsNullOrEmpty(txt_Horas_Practicas.Text))
            {
                MessageBox.Show("Todo los campos estan vacios");
                return;
            }

            if (string.IsNullOrEmpty(txtCurso.Text))
            {
                MessageBox.Show("El campo nombre se encuentra vacio");
                return;
            }

            if (string.IsNullOrEmpty(txt_Horas_Teoricas.Text))
            {
                MessageBox.Show("El campo apellido se encuentra vacio");
                return;
            }

            if (string.IsNullOrEmpty(txtCreditos.Text))
            {
                MessageBox.Show("El campo numero de documento se encuentra vacio");
                return;
            }

            if (string.IsNullOrEmpty(txt_Horas_Practicas.Text))
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
            txtCurso.Clear();
            txtCreditos.Clear();
            txt_Horas_Practicas.Clear();
            txt_Horas_Teoricas.Clear();
        }

        private string mtdGenerarCodigo()
        {
            string codigo = "";
            if (aCurso.Count < 1)
            {
                return "E001";
            }
            else
            {
                foreach (clsPersona i in aCurso)
                {
                    codigo = i.codigo.ToString();
                }
            }
            return "E" + (int.Parse(codigo.Substring(1, 3)) + 1).ToString("000");
        }

        private void mtdListarEstudiante()
        {
            dgvCurso.Rows.Clear();
            foreach (clsCurso e in aCurso)
            {
                dgvCurso.Rows.Add(e.codigo, e.curso, e.creditos, e.horas_practicas, e.horas_teoricas);
            }
        }

        private void Frm_Cursos_Load(object sender, EventArgs e)
        {
            txtcodigo.Text = mtdGenerarCodigo();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtCurso.Enabled = true;
            txtCreditos.Enabled = true;
            txt_Horas_Practicas.Enabled = true;
            txt_Horas_Teoricas.Enabled = true;

            mtdPermitirBotones(false, true, false, false, true);
            mTdLimpiarControles();
        }

        private bool mtd_solo_numeros(string texto)
        {
            if (!SoloNumeros(texto))
            {
                MessageBox.Show("Solo puede ingresar números en este campo");
                return false;
            }
            return true;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            VerificarCamposVacios();

            if (!mtd_solo_numeros(txtCreditos.Text)) return;
            if (!mtd_solo_numeros(txt_Horas_Practicas.Text)) return;
            if (!mtd_solo_numeros(txt_Horas_Teoricas.Text)) return;

            foreach (DataGridViewRow row in dgvCurso.Rows)
            {
                if (row.IsNewRow) continue;

                string codigo = row.Cells[0].Value?.ToString();
                string curso = row.Cells[1].Value?.ToString();
                string creditos = row.Cells[2].Value?.ToString();
                string practicas = row.Cells[3].Value?.ToString();
                string teoricas = row.Cells[4].Value?.ToString();

                if (codigo == txtcodigo.Text || curso == txtCurso.Text || creditos  == txtCreditos.Text || practicas == txt_Horas_Practicas.Text || teoricas == txt_Horas_Teoricas.Text)
                {
                    MessageBox.Show("⚠ El estudiante ya existe (mismo código o mismo nombre y apellido).");
                    return;
                }
            }

            clsCurso ObjCurso = new clsCurso
            {
                codigo = txtcodigo.Text,
                curso = txtCurso.Text,
                creditos = txtCreditos.Text,
                horas_practicas = txt_Horas_Practicas.Text,
                horas_teoricas = txt_Horas_Teoricas.Text
            };


            aCurso.Add(ObjCurso);

            mtdListarEstudiante();

            txtcodigo.Text = mtdGenerarCodigo();
            mtdPermitirBotones(true, false, false, false, true);
            mTdLimpiarControles();
            EstadoTextBox(false);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            EstadoTextBox(true);

            try
            {
                VerificarCamposVacios();
                foreach (clsCurso curso in aCurso)
                {
                    if (curso.codigo == txtcodigo.Text)
                    {
                        curso.curso = txtCurso.Text;
                        curso.creditos = txtCreditos.Text;
                        curso.horas_practicas = txt_Horas_Practicas.Text;
                        curso.horas_teoricas = txt_Horas_Teoricas.Text;

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
                foreach (clsCurso Curso in aCurso)
                {
                    if (Curso.codigo == txtcodigo.Text)
                    {
                        aCurso.Remove(Curso);

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

        private void dgvCurso_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EstadoTextBox(true);

            dgvCurso.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtcodigo.Text = dgvCurso.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCurso.Text = dgvCurso.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCreditos.Text = dgvCurso.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Horas_Practicas.Text = dgvCurso.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Horas_Teoricas.Text = dgvCurso.Rows[e.RowIndex].Cells[4].Value.ToString();

            mtdPermitirBotones(false, false, true, true, true);
        }
    }
}
