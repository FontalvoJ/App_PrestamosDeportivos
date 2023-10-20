namespace Presentacion
{
    partial class frm_modulo_usuarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox5 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox6 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox7 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.tblsexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbs_prestamos_deportivosDataSet = new Presentacion.dbs_prestamos_deportivosDataSet();
            this.materialTextBox8 = new MaterialSkin.Controls.MaterialTextBox();
            this.tbl_sexoTableAdapter = new Presentacion.dbs_prestamos_deportivosDataSetTableAdapters.tbl_sexoTableAdapter();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.tblsexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_prestamos_deportivosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(292, 20);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(146, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Registro de Usuarios";
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.Hint = "Primer Nombre";
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(28, 117);
            this.materialTextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(220, 50);
            this.materialTextBox2.TabIndex = 2;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            this.materialTextBox2.TextChanged += new System.EventHandler(this.materialTextBox2_TextChanged);
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.AnimateReadOnly = false;
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox3.Hint = "Segundo Nombre";
            this.materialTextBox3.LeadingIcon = null;
            this.materialTextBox3.Location = new System.Drawing.Point(496, 51);
            this.materialTextBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(220, 50);
            this.materialTextBox3.TabIndex = 3;
            this.materialTextBox3.Text = "";
            this.materialTextBox3.TrailingIcon = null;
            // 
            // materialTextBox4
            // 
            this.materialTextBox4.AnimateReadOnly = false;
            this.materialTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox4.Depth = 0;
            this.materialTextBox4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox4.Hint = "Primer Apellido";
            this.materialTextBox4.LeadingIcon = null;
            this.materialTextBox4.Location = new System.Drawing.Point(261, 51);
            this.materialTextBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialTextBox4.MaxLength = 50;
            this.materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox4.Multiline = false;
            this.materialTextBox4.Name = "materialTextBox4";
            this.materialTextBox4.Size = new System.Drawing.Size(220, 50);
            this.materialTextBox4.TabIndex = 4;
            this.materialTextBox4.Text = "";
            this.materialTextBox4.TrailingIcon = null;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "Identificación";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(28, 51);
            this.materialTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(220, 50);
            this.materialTextBox1.TabIndex = 6;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialTextBox5
            // 
            this.materialTextBox5.AnimateReadOnly = false;
            this.materialTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox5.Depth = 0;
            this.materialTextBox5.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox5.Hint = "Segundo Apellido";
            this.materialTextBox5.LeadingIcon = null;
            this.materialTextBox5.Location = new System.Drawing.Point(261, 116);
            this.materialTextBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialTextBox5.MaxLength = 50;
            this.materialTextBox5.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox5.Multiline = false;
            this.materialTextBox5.Name = "materialTextBox5";
            this.materialTextBox5.Size = new System.Drawing.Size(220, 50);
            this.materialTextBox5.TabIndex = 7;
            this.materialTextBox5.Text = "";
            this.materialTextBox5.TrailingIcon = null;
            // 
            // materialTextBox6
            // 
            this.materialTextBox6.AnimateReadOnly = false;
            this.materialTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox6.Depth = 0;
            this.materialTextBox6.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox6.Hint = "Contacto";
            this.materialTextBox6.LeadingIcon = null;
            this.materialTextBox6.Location = new System.Drawing.Point(496, 116);
            this.materialTextBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialTextBox6.MaxLength = 50;
            this.materialTextBox6.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox6.Multiline = false;
            this.materialTextBox6.Name = "materialTextBox6";
            this.materialTextBox6.Size = new System.Drawing.Size(220, 50);
            this.materialTextBox6.TabIndex = 8;
            this.materialTextBox6.Text = "";
            this.materialTextBox6.TrailingIcon = null;
            // 
            // materialTextBox7
            // 
            this.materialTextBox7.AnimateReadOnly = false;
            this.materialTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox7.Depth = 0;
            this.materialTextBox7.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox7.Hint = "Correo";
            this.materialTextBox7.LeadingIcon = null;
            this.materialTextBox7.Location = new System.Drawing.Point(28, 181);
            this.materialTextBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialTextBox7.MaxLength = 50;
            this.materialTextBox7.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox7.Multiline = false;
            this.materialTextBox7.Name = "materialTextBox7";
            this.materialTextBox7.Size = new System.Drawing.Size(453, 50);
            this.materialTextBox7.TabIndex = 9;
            this.materialTextBox7.Text = "";
            this.materialTextBox7.TrailingIcon = null;
            this.materialTextBox7.TextChanged += new System.EventHandler(this.materialTextBox7_TextChanged);
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.DataSource = this.tblsexoBindingSource;
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DisplayMember = "Nombre";
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(496, 182);
            this.materialComboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(220, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 10;
            this.materialComboBox1.ValueMember = "Nomenclatura";
            // 
            // tblsexoBindingSource
            // 
            this.tblsexoBindingSource.DataMember = "tbl_sexo";
            this.tblsexoBindingSource.DataSource = this.dbs_prestamos_deportivosDataSet;
            // 
            // dbs_prestamos_deportivosDataSet
            // 
            this.dbs_prestamos_deportivosDataSet.DataSetName = "dbs_prestamos_deportivosDataSet";
            this.dbs_prestamos_deportivosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialTextBox8
            // 
            this.materialTextBox8.AnimateReadOnly = false;
            this.materialTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox8.Depth = 0;
            this.materialTextBox8.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox8.Hint = "Dirección";
            this.materialTextBox8.LeadingIcon = null;
            this.materialTextBox8.Location = new System.Drawing.Point(28, 248);
            this.materialTextBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialTextBox8.MaxLength = 50;
            this.materialTextBox8.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox8.Multiline = false;
            this.materialTextBox8.Name = "materialTextBox8";
            this.materialTextBox8.Size = new System.Drawing.Size(688, 50);
            this.materialTextBox8.TabIndex = 11;
            this.materialTextBox8.Text = "";
            this.materialTextBox8.TrailingIcon = null;
            this.materialTextBox8.TextChanged += new System.EventHandler(this.materialTextBox8_TextChanged);
            // 
            // tbl_sexoTableAdapter
            // 
            this.tbl_sexoTableAdapter.ClearBeforeFill = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(384, 315);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(109, 36);
            this.materialButton1.TabIndex = 12;
            this.materialButton1.Text = "Actualizar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(513, 315);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(88, 36);
            this.materialButton2.TabIndex = 13;
            this.materialButton2.Text = "Guardar";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(620, 315);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(96, 36);
            this.materialButton3.TabIndex = 14;
            this.materialButton3.Text = "Cancelar";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // frm_modulo_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 378);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialTextBox8);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.materialTextBox7);
            this.Controls.Add(this.materialTextBox6);
            this.Controls.Add(this.materialTextBox5);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.materialTextBox4);
            this.Controls.Add(this.materialTextBox3);
            this.Controls.Add(this.materialTextBox2);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_modulo_usuarios";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_modulo_usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblsexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_prestamos_deportivosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox5;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox6;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox7;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox8;
        private dbs_prestamos_deportivosDataSet dbs_prestamos_deportivosDataSet;
        private System.Windows.Forms.BindingSource tblsexoBindingSource;
        private dbs_prestamos_deportivosDataSetTableAdapters.tbl_sexoTableAdapter tbl_sexoTableAdapter;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
    }
}

