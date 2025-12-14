/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 12/14/2025
 * Time: 2:49 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Trabajo14
{
	partial class yuppie
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yuppie));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(740, 311);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Font = new System.Drawing.Font("Humnst777 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(10, 377);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(727, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "SI ESTAS LEYENDO ESTO SIGNIFICA QUE LO LOGRE, SOY LIBREEEE!!!\r\n";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(706, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(21, 21);
			this.button1.TabIndex = 2;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Font = new System.Drawing.Font("Humnst777 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(76, 400);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(602, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "o al menos eso espero, POR LO MIENTRAS A DESCANZAR";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Font = new System.Drawing.Font("Humnst777 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(200, 423);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(324, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Mi penitencia ha terminado";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Font = new System.Drawing.Font("Humnst777 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(217, 343);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(346, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "FANTASMA LO LOGRAMOOOOS";
			// 
			// yuppie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(739, 455);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "yuppie";
			this.Text = "yuppie";
			this.Load += new System.EventHandler(this.YuppieLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
