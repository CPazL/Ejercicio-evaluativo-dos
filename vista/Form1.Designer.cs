
using System.ComponentModel;
using System.Windows.Forms;

namespace vista
{
    public partial class Form1 
    {

        private System.ComponentModel.IContainer components = null;


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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pacientesButton = new System.Windows.Forms.Button();
            this.medicosButton = new System.Windows.Forms.Button();
            this.salirbutton = new System.Windows.Forms.Button();
            this.titulolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pacientesButton
            // 
            this.pacientesButton.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pacientesButton.Location = new System.Drawing.Point(98, 181);
            this.pacientesButton.Name = "pacientesButton";
            this.pacientesButton.Size = new System.Drawing.Size(211, 38);
            this.pacientesButton.TabIndex = 0;
            this.pacientesButton.Text = "Pacientes";
            this.pacientesButton.UseVisualStyleBackColor = true;
            this.pacientesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // medicosButton
            // 
            this.medicosButton.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.medicosButton.Location = new System.Drawing.Point(458, 181);
            this.medicosButton.Name = "medicosButton";
            this.medicosButton.Size = new System.Drawing.Size(211, 38);
            this.medicosButton.TabIndex = 2;
            this.medicosButton.Text = "Médicos";
            this.medicosButton.UseVisualStyleBackColor = true;
            this.medicosButton.Click += new System.EventHandler(this.MedicosButton_Click);
            // 
            // salirbutton
            // 
            this.salirbutton.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salirbutton.Location = new System.Drawing.Point(274, 252);
            this.salirbutton.Name = "salirbutton";
            this.salirbutton.Size = new System.Drawing.Size(211, 38);
            this.salirbutton.TabIndex = 3;
            this.salirbutton.Text = "Salir";
            this.salirbutton.UseVisualStyleBackColor = true;
            this.salirbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // titulolabel
            // 
            this.titulolabel.AutoSize = true;
            this.titulolabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulolabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titulolabel.Location = new System.Drawing.Point(184, 72);
            this.titulolabel.Name = "titulolabel";
            this.titulolabel.Size = new System.Drawing.Size(408, 28);
            this.titulolabel.TabIndex = 4;
            this.titulolabel.Text = "Clinica privada de Buenos Aires";
            this.titulolabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(778, 349);
            this.Controls.Add(this.titulolabel);
            this.Controls.Add(this.salirbutton);
            this.Controls.Add(this.medicosButton);
            this.Controls.Add(this.pacientesButton);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "    ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pacientesButton;
        private System.Windows.Forms.Button medicosButton;
        private System.Windows.Forms.Button salirbutton;
        private System.Windows.Forms.Label titulolabel;
    }
}

