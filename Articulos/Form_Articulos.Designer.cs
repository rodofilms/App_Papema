﻿namespace App_Papema
{
    partial class Form_Articulos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Articulos));
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_modificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_buscar = new System.Windows.Forms.TextBox();
            this.grid_Articulos = new System.Windows.Forms.DataGridView();
            this.button_agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 44);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Enabled = false;
            this.textBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID.Location = new System.Drawing.Point(89, 499);
            this.textBox_ID.Multiline = true;
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(102, 46);
            this.textBox_ID.TabIndex = 24;
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.Color.DarkRed;
            this.button_eliminar.Enabled = false;
            this.button_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar.ForeColor = System.Drawing.Color.White;
            this.button_eliminar.Location = new System.Drawing.Point(929, 496);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(188, 59);
            this.button_eliminar.TabIndex = 23;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = false;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_modificar
            // 
            this.button_modificar.BackColor = System.Drawing.Color.SkyBlue;
            this.button_modificar.Enabled = false;
            this.button_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificar.Location = new System.Drawing.Point(709, 496);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(180, 59);
            this.button_modificar.TabIndex = 22;
            this.button_modificar.Text = "Modificar";
            this.button_modificar.UseVisualStyleBackColor = false;
            this.button_modificar.Click += new System.EventHandler(this.button_modificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 44);
            this.label1.TabIndex = 21;
            this.label1.Text = "Buscar";
            // 
            // textBox_buscar
            // 
            this.textBox_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_buscar.Location = new System.Drawing.Point(185, 39);
            this.textBox_buscar.Multiline = true;
            this.textBox_buscar.Name = "textBox_buscar";
            this.textBox_buscar.Size = new System.Drawing.Size(320, 46);
            this.textBox_buscar.TabIndex = 20;
            this.textBox_buscar.TextChanged += new System.EventHandler(this.textBox_buscar_TextChanged);
            // 
            // grid_Articulos
            // 
            this.grid_Articulos.AllowUserToAddRows = false;
            this.grid_Articulos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            this.grid_Articulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Articulos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grid_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Articulos.Location = new System.Drawing.Point(32, 101);
            this.grid_Articulos.Name = "grid_Articulos";
            this.grid_Articulos.ReadOnly = true;
            this.grid_Articulos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            this.grid_Articulos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Articulos.RowTemplate.Height = 24;
            this.grid_Articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Articulos.Size = new System.Drawing.Size(1085, 366);
            this.grid_Articulos.TabIndex = 19;
            this.grid_Articulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Articulos_CellClick);
            // 
            // button_agregar
            // 
            this.button_agregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar.ForeColor = System.Drawing.Color.Black;
            this.button_agregar.Location = new System.Drawing.Point(929, 26);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(188, 59);
            this.button_agregar.TabIndex = 27;
            this.button_agregar.Text = "Agregar";
            this.button_agregar.UseVisualStyleBackColor = false;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // Form_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1141, 594);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_buscar);
            this.Controls.Add(this.grid_Articulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Articulos";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Articulos";
            this.Load += new System.EventHandler(this.Form_Articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_buscar;
        private System.Windows.Forms.DataGridView grid_Articulos;
        private System.Windows.Forms.Button button_agregar;
    }
}