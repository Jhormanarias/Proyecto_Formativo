
namespace ProyectoFormativo
{
	partial class FrmControlAdmin
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
			this.button1 = new System.Windows.Forms.Button();
			this.tc_Usuario = new System.Windows.Forms.TabControl();
			this.Usuarios = new System.Windows.Forms.TabPage();
			this.Propietario = new System.Windows.Forms.TabPage();
			this.Equipo = new System.Windows.Forms.TabPage();
			this.Control = new System.Windows.Forms.TabPage();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtEquipo = new System.Windows.Forms.TextBox();
			this.txtDocumento = new System.Windows.Forms.TextBox();
			this.txtIdEquipo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tc_Usuario.SuspendLayout();
			this.Control.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.button1.ForeColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(165, 212);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(445, 73);
			this.button1.TabIndex = 0;
			this.button1.Text = "botoncito";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tc_Usuario
			// 
			this.tc_Usuario.Controls.Add(this.Usuarios);
			this.tc_Usuario.Controls.Add(this.Propietario);
			this.tc_Usuario.Controls.Add(this.Equipo);
			this.tc_Usuario.Controls.Add(this.Control);
			this.tc_Usuario.Location = new System.Drawing.Point(30, 34);
			this.tc_Usuario.Name = "tc_Usuario";
			this.tc_Usuario.SelectedIndex = 0;
			this.tc_Usuario.Size = new System.Drawing.Size(746, 389);
			this.tc_Usuario.TabIndex = 1;
			// 
			// Usuarios
			// 
			this.Usuarios.Location = new System.Drawing.Point(4, 22);
			this.Usuarios.Name = "Usuarios";
			this.Usuarios.Padding = new System.Windows.Forms.Padding(3);
			this.Usuarios.Size = new System.Drawing.Size(738, 363);
			this.Usuarios.TabIndex = 0;
			this.Usuarios.Text = "Usuarios";
			this.Usuarios.UseVisualStyleBackColor = true;
			// 
			// Propietario
			// 
			this.Propietario.Location = new System.Drawing.Point(4, 22);
			this.Propietario.Name = "Propietario";
			this.Propietario.Padding = new System.Windows.Forms.Padding(3);
			this.Propietario.Size = new System.Drawing.Size(738, 363);
			this.Propietario.TabIndex = 1;
			this.Propietario.Text = "Propietario";
			this.Propietario.UseVisualStyleBackColor = true;
			// 
			// Equipo
			// 
			this.Equipo.Location = new System.Drawing.Point(4, 22);
			this.Equipo.Name = "Equipo";
			this.Equipo.Padding = new System.Windows.Forms.Padding(3);
			this.Equipo.Size = new System.Drawing.Size(738, 363);
			this.Equipo.TabIndex = 2;
			this.Equipo.Text = "Equipo";
			this.Equipo.UseVisualStyleBackColor = true;
			// 
			// Control
			// 
			this.Control.Controls.Add(this.txtNombre);
			this.Control.Controls.Add(this.txtEquipo);
			this.Control.Controls.Add(this.txtDocumento);
			this.Control.Controls.Add(this.txtIdEquipo);
			this.Control.Controls.Add(this.label1);
			this.Control.Controls.Add(this.button1);
			this.Control.Location = new System.Drawing.Point(4, 22);
			this.Control.Name = "Control";
			this.Control.Padding = new System.Windows.Forms.Padding(3);
			this.Control.Size = new System.Drawing.Size(738, 363);
			this.Control.TabIndex = 3;
			this.Control.Text = "Control";
			this.Control.UseVisualStyleBackColor = true;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(51, 96);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 5;
			this.txtNombre.Text = "Nombre: ";
			this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
			// 
			// txtEquipo
			// 
			this.txtEquipo.Location = new System.Drawing.Point(179, 96);
			this.txtEquipo.Name = "txtEquipo";
			this.txtEquipo.Size = new System.Drawing.Size(100, 20);
			this.txtEquipo.TabIndex = 4;
			this.txtEquipo.Text = "Equipo: ";
			this.txtEquipo.Enter += new System.EventHandler(this.txtEquipo_Enter);
			// 
			// txtDocumento
			// 
			this.txtDocumento.Location = new System.Drawing.Point(179, 56);
			this.txtDocumento.Name = "txtDocumento";
			this.txtDocumento.Size = new System.Drawing.Size(100, 20);
			this.txtDocumento.TabIndex = 3;
			this.txtDocumento.Text = "Documento: ";
			this.txtDocumento.Enter += new System.EventHandler(this.txtDocumento_Enter);
			// 
			// txtIdEquipo
			// 
			this.txtIdEquipo.Location = new System.Drawing.Point(51, 56);
			this.txtIdEquipo.Name = "txtIdEquipo";
			this.txtIdEquipo.Size = new System.Drawing.Size(100, 20);
			this.txtIdEquipo.TabIndex = 2;
			this.txtIdEquipo.Text = "ID Equipo:";
			this.txtIdEquipo.Enter += new System.EventHandler(this.txtIdEquipo_Enter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// FrmControlAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tc_Usuario);
			this.Name = "FrmControlAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Control";
			this.Load += new System.EventHandler(this.FrmControlAdmin_Load);
			this.tc_Usuario.ResumeLayout(false);
			this.Control.ResumeLayout(false);
			this.Control.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabControl tc_Usuario;
		private System.Windows.Forms.TabPage Usuarios;
		private System.Windows.Forms.TabPage Propietario;
		private System.Windows.Forms.TabPage Equipo;
		private System.Windows.Forms.TabPage Control;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtEquipo;
		private System.Windows.Forms.TextBox txtDocumento;
		private System.Windows.Forms.TextBox txtIdEquipo;
		private System.Windows.Forms.Label label1;
	}
}

