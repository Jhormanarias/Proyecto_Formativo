using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFormativo
{
	public partial class login : Form
	{
		public login()
		{
			InitializeComponent();
		}

		private void txtUsusario_Enter(object sender, EventArgs e)
		{
			if (txtUsusario.Text == "Usuario")
			{
				txtUsusario.Text = "";
				txtUsusario.ForeColor = Color.LightGray;
			}
		}

		private void txtUsusario_Leave(object sender, EventArgs e)
		{
			if (txtUsusario.Text == "")
			{
				txtUsusario.Text = "Usuario";
				txtUsusario.ForeColor = Color.DimGray;
			}
		}

		private void txtContrasena_Leave(object sender, EventArgs e)
		{
			if (txtContrasena.Text == "")
			{
				txtContrasena.Text = "Contraseña";
				txtContrasena.ForeColor = Color.DimGray;
				txtContrasena.UseSystemPasswordChar = false;
			}
		}

		private void txtContrasena_Enter(object sender, EventArgs e)
		{
			if (txtContrasena.Text == "Contraseña")
			{
				txtContrasena.Text = "";
				txtContrasena.ForeColor = Color.LightGray;
				txtContrasena.UseSystemPasswordChar = true;
			}
		}

		private void txtContrasena_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
