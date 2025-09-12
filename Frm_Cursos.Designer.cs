namespace PG02_LAB09_MOSQUITO_LUIS
{
    partial class Frm_Cursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.txt_Horas_Practicas = new System.Windows.Forms.TextBox();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.txt_Horas_Teoricas = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblHorasPracticas = new System.Windows.Forms.Label();
            this.lblHorasTecnicas = new System.Windows.Forms.Label();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.colcodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colapellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mantenimiento de Cursos";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(366, 178);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 66;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // dgvCurso
            // 
            this.dgvCurso.AllowUserToAddRows = false;
            this.dgvCurso.AllowUserToDeleteRows = false;
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colcodigo,
            this.colnombre,
            this.colapellido,
            this.coldocumento,
            this.colemail});
            this.dgvCurso.Location = new System.Drawing.Point(23, 241);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.ReadOnly = true;
            this.dgvCurso.Size = new System.Drawing.Size(544, 150);
            this.dgvCurso.TabIndex = 65;
            this.dgvCurso.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurso_CellContentDoubleClick);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(366, 149);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 64;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(366, 120);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 63;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(366, 91);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 62;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(366, 62);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 61;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // txt_Horas_Practicas
            // 
            this.txt_Horas_Practicas.Location = new System.Drawing.Point(149, 166);
            this.txt_Horas_Practicas.Name = "txt_Horas_Practicas";
            this.txt_Horas_Practicas.Size = new System.Drawing.Size(162, 20);
            this.txt_Horas_Practicas.TabIndex = 60;
            // 
            // txtCreditos
            // 
            this.txtCreditos.Location = new System.Drawing.Point(149, 114);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(162, 20);
            this.txtCreditos.TabIndex = 59;
            // 
            // txt_Horas_Teoricas
            // 
            this.txt_Horas_Teoricas.Location = new System.Drawing.Point(149, 140);
            this.txt_Horas_Teoricas.Name = "txt_Horas_Teoricas";
            this.txt_Horas_Teoricas.Size = new System.Drawing.Size(162, 20);
            this.txt_Horas_Teoricas.TabIndex = 58;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(93, 88);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(218, 20);
            this.txtCurso.TabIndex = 57;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(93, 62);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.ReadOnly = true;
            this.txtcodigo.Size = new System.Drawing.Size(218, 20);
            this.txtcodigo.TabIndex = 56;
            // 
            // lblHorasPracticas
            // 
            this.lblHorasPracticas.AutoSize = true;
            this.lblHorasPracticas.Location = new System.Drawing.Point(20, 170);
            this.lblHorasPracticas.Name = "lblHorasPracticas";
            this.lblHorasPracticas.Size = new System.Drawing.Size(108, 13);
            this.lblHorasPracticas.TabIndex = 55;
            this.lblHorasPracticas.Text = "HORAS PRACTICAS";
            // 
            // lblHorasTecnicas
            // 
            this.lblHorasTecnicas.AutoSize = true;
            this.lblHorasTecnicas.Location = new System.Drawing.Point(20, 144);
            this.lblHorasTecnicas.Name = "lblHorasTecnicas";
            this.lblHorasTecnicas.Size = new System.Drawing.Size(102, 13);
            this.lblHorasTecnicas.TabIndex = 54;
            this.lblHorasTecnicas.Text = "HORAS TEORICAS";
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.Location = new System.Drawing.Point(20, 118);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(62, 13);
            this.lblCreditos.TabIndex = 53;
            this.lblCreditos.Text = "CREDITOS";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(20, 92);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(45, 13);
            this.lblCurso.TabIndex = 52;
            this.lblCurso.Text = "CURSO";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 66);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 13);
            this.lblCodigo.TabIndex = 51;
            this.lblCodigo.Text = "CODIGO";
            // 
            // colcodigo
            // 
            this.colcodigo.HeaderText = "Codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.ReadOnly = true;
            // 
            // colnombre
            // 
            this.colnombre.HeaderText = "Curso";
            this.colnombre.Name = "colnombre";
            this.colnombre.ReadOnly = true;
            // 
            // colapellido
            // 
            this.colapellido.HeaderText = "Creditos";
            this.colapellido.Name = "colapellido";
            this.colapellido.ReadOnly = true;
            // 
            // coldocumento
            // 
            this.coldocumento.HeaderText = "Horas Practicas";
            this.coldocumento.Name = "coldocumento";
            this.coldocumento.ReadOnly = true;
            // 
            // colemail
            // 
            this.colemail.HeaderText = "Horas Teoricas";
            this.colemail.Name = "colemail";
            this.colemail.ReadOnly = true;
            // 
            // Frm_Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 407);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.dgvCurso);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.txt_Horas_Practicas);
            this.Controls.Add(this.txtCreditos);
            this.Controls.Add(this.txt_Horas_Teoricas);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblHorasPracticas);
            this.Controls.Add(this.lblHorasTecnicas);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Cursos";
            this.Text = "Frm_Cursos";
            this.Load += new System.EventHandler(this.Frm_Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridView dgvCurso;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txt_Horas_Practicas;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.TextBox txt_Horas_Teoricas;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblHorasPracticas;
        private System.Windows.Forms.Label lblHorasTecnicas;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colapellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colemail;
    }
}