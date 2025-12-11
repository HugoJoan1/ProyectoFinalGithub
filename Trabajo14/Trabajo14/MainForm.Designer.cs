/*
 * Created by SharpDevelop.
 * User: Abelg
 * Date: 10/1/2025
 * Time: 12:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Trabajo14
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.lblLogin = new System.Windows.Forms.Label();
			this.btnAcceder = new System.Windows.Forms.Button();
			this.linkPass = new System.Windows.Forms.LinkLabel();
			this.btnCerrar = new System.Windows.Forms.PictureBox();
			this.btnMinimizar = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DimGray;
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(250, 312);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(32, 57);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(191, 178);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// txtUser
			// 
			this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUser.ForeColor = System.Drawing.Color.DimGray;
			this.txtUser.Location = new System.Drawing.Point(292, 139);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(408, 20);
			this.txtUser.TabIndex = 1;
			this.txtUser.Text = "USUARIO";
			this.txtUser.Enter += new System.EventHandler(this.TxtUserEnter);
			this.txtUser.Leave += new System.EventHandler(this.TxtUserLeave);
			// 
			// txtPass
			// 
			this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPass.ForeColor = System.Drawing.Color.DimGray;
			this.txtPass.Location = new System.Drawing.Point(291, 165);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(408, 20);
			this.txtPass.TabIndex = 2;
			this.txtPass.Text = "CONTRASEÑA";
			this.txtPass.Enter += new System.EventHandler(this.TxtPassEnter);
			this.txtPass.Leave += new System.EventHandler(this.TxtPassLeave);
			// 
			// lblLogin
			// 
			this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLogin.Location = new System.Drawing.Point(444, 10);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(100, 37);
			this.lblLogin.TabIndex = 2;
			this.lblLogin.Text = "LOGIN";
			// 
			// btnAcceder
			// 
			this.btnAcceder.FlatAppearance.BorderSize = 0;
			this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAcceder.ForeColor = System.Drawing.Color.LightGray;
			this.btnAcceder.Location = new System.Drawing.Point(291, 202);
			this.btnAcceder.Name = "btnAcceder";
			this.btnAcceder.Size = new System.Drawing.Size(408, 40);
			this.btnAcceder.TabIndex = 3;
			this.btnAcceder.Text = "ACCEDER";
			this.btnAcceder.UseVisualStyleBackColor = true;
			this.btnAcceder.Click += new System.EventHandler(this.BtnAccederClick);
			// 
			// linkPass
			// 
			this.linkPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkPass.LinkColor = System.Drawing.Color.DimGray;
			this.linkPass.Location = new System.Drawing.Point(421, 245);
			this.linkPass.Name = "linkPass";
			this.linkPass.Size = new System.Drawing.Size(158, 23);
			this.linkPass.TabIndex = 0;
			this.linkPass.TabStop = true;
			this.linkPass.Text = "¿Olvidaste el Patrón?";
			this.linkPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPassLinkClicked);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
			this.btnCerrar.Location = new System.Drawing.Point(706, 3);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(20, 20);
			this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnCerrar.TabIndex = 5;
			this.btnCerrar.TabStop = false;
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// btnMinimizar
			// 
			this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
			this.btnMinimizar.Location = new System.Drawing.Point(680, 3);
			this.btnMinimizar.Name = "btnMinimizar";
			this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
			this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMinimizar.TabIndex = 6;
			this.btnMinimizar.TabStop = false;
			this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.ClientSize = new System.Drawing.Size(731, 312);
			this.Controls.Add(this.btnMinimizar);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.linkPass);
			this.Controls.Add(this.btnAcceder);
			this.Controls.Add(this.lblLogin);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.Color.DimGray;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Trabajo14";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox btnMinimizar;
		private System.Windows.Forms.PictureBox btnCerrar;
		private System.Windows.Forms.LinkLabel linkPass;
		private System.Windows.Forms.Button btnAcceder;
		private System.Windows.Forms.Label lblLogin;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Panel panel1;
	}
}
