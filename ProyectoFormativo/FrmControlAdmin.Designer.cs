
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
			this.tc_Usuario.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(181, 365);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "botoncito";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// tc_Usuario
			// 
			this.tc_Usuario.Controls.Add(this.Usuarios);
			this.tc_Usuario.Controls.Add(this.Propietario);
			this.tc_Usuario.Controls.Add(this.Equipo);
			this.tc_Usuario.Controls.Add(this.Control);
			this.tc_Usuario.Location = new System.Drawing.Point(73, 49);
			this.tc_Usuario.Name = "tc_Usuario";
			this.tc_Usuario.SelectedIndex = 0;
			this.tc_Usuario.Size = new System.Drawing.Size(684, 310);
			this.tc_Usuario.TabIndex = 1;
			// 
			// Usuarios
			// 
			this.Usuarios.Location = new System.Drawing.Point(4, 22);
			this.Usuarios.Name = "Usuarios";
			this.Usuarios.Padding = new System.Windows.Forms.Padding(3);
			this.Usuarios.Size = new System.Drawing.Size(676, 284);
			this.Usuarios.TabIndex = 0;
			this.Usuarios.Text = "Usuarios";
			this.Usuarios.UseVisualStyleBackColor = true;
			// 
			// Propietario
			// 
			this.Propietario.Location = new System.Drawing.Point(4, 22);
			this.Propietario.Name = "Propietario";
			this.Propietario.Padding = new System.Windows.Forms.Padding(3);
			this.Propietario.Size = new System.Drawing.Size(676, 284);
			this.Propietario.TabIndex = 1;
			this.Propietario.Text = "Propietario";
			this.Propietario.UseVisualStyleBackColor = true;
			// 
			// Equipo
			// 
			this.Equipo.Location = new System.Drawing.Point(4, 22);
			this.Equipo.Name = "Equipo";
			this.Equipo.Padding = new System.Windows.Forms.Padding(3);
			this.Equipo.Size = new System.Drawing.Size(676, 284);
			this.Equipo.TabIndex = 2;
			this.Equipo.Text = "Equipo";
			this.Equipo.UseVisualStyleBackColor = true;
			// 
			// Control
			// 
			this.Control.Location = new System.Drawing.Point(4, 22);
			this.Control.Name = "Control";
			this.Control.Padding = new System.Windows.Forms.Padding(3);
			this.Control.Size = new System.Drawing.Size(676, 284);
			this.Control.TabIndex = 3;
			this.Control.Text = "Control";
			this.Control.UseVisualStyleBackColor = true;
			// 
			// FrmControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tc_Usuario);
			this.Controls.Add(this.button1);
			this.Name = "FrmControl";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Control";
			this.tc_Usuario.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabControl tc_Usuario;
		private System.Windows.Forms.TabPage Usuarios;
		private System.Windows.Forms.TabPage Propietario;
		private System.Windows.Forms.TabPage Equipo;
		private System.Windows.Forms.TabPage Control;
	}
}

