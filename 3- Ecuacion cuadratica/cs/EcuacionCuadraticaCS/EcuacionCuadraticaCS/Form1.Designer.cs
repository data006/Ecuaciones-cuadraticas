namespace EcuacionCuadraticaCS
{
	partial class Form1
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
			this.btnSolve = new System.Windows.Forms.Button();
			this.txtC = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.txtA = new System.Windows.Forms.TextBox();
			this.lblC = new System.Windows.Forms.Label();
			this.lblB = new System.Windows.Forms.Label();
			this.lblA = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSolve
			// 
			this.btnSolve.Location = new System.Drawing.Point(329, 232);
			this.btnSolve.Name = "btnSolve";
			this.btnSolve.Size = new System.Drawing.Size(75, 23);
			this.btnSolve.TabIndex = 17;
			this.btnSolve.Text = "Solve";
			this.btnSolve.UseVisualStyleBackColor = true;
			this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(281, 206);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(181, 20);
			this.txtC.TabIndex = 16;
			this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC_KeyPress);
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(281, 171);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(181, 20);
			this.txtB.TabIndex = 15;
			this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(281, 136);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(181, 20);
			this.txtA.TabIndex = 14;
			this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
			// 
			// lblC
			// 
			this.lblC.AutoSize = true;
			this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblC.Location = new System.Drawing.Point(249, 201);
			this.lblC.Name = "lblC";
			this.lblC.Size = new System.Drawing.Size(33, 25);
			this.lblC.TabIndex = 13;
			this.lblC.Text = "C:";
			// 
			// lblB
			// 
			this.lblB.AutoSize = true;
			this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblB.Location = new System.Drawing.Point(249, 166);
			this.lblB.Name = "lblB";
			this.lblB.Size = new System.Drawing.Size(31, 25);
			this.lblB.TabIndex = 12;
			this.lblB.Text = "B:";
			// 
			// lblA
			// 
			this.lblA.AutoSize = true;
			this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA.Location = new System.Drawing.Point(249, 132);
			this.lblA.Name = "lblA";
			this.lblA.Size = new System.Drawing.Size(32, 25);
			this.lblA.TabIndex = 11;
			this.lblA.Text = "A:";
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl2.Location = new System.Drawing.Point(270, 82);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(184, 31);
			this.lbl2.TabIndex = 10;
			this.lbl2.Text = "Ax^2 + Bx + C";
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl1.Location = new System.Drawing.Point(52, 34);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(653, 31);
			this.lbl1.TabIndex = 9;
			this.lbl1.Text = "Ingrese los coeficientes de una ecuacion de la forma:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSolve);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.lblC);
			this.Controls.Add(this.lblB);
			this.Controls.Add(this.lblA);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.lbl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Button btnSolve;
		internal System.Windows.Forms.TextBox txtC;
		internal System.Windows.Forms.TextBox txtB;
		internal System.Windows.Forms.TextBox txtA;
		internal System.Windows.Forms.Label lblC;
		internal System.Windows.Forms.Label lblB;
		internal System.Windows.Forms.Label lblA;
		internal System.Windows.Forms.Label lbl2;
		internal System.Windows.Forms.Label lbl1;
	}
}

