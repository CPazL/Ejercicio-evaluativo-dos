
namespace vista
{
    partial class medicosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medicosForm));
            this.estadisticasButton = new System.Windows.Forms.Button();
            this.salirbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DniColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_actualColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // estadisticasButton
            // 
            this.estadisticasButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.estadisticasButton.Location = new System.Drawing.Point(135, 388);
            this.estadisticasButton.Name = "estadisticasButton";
            this.estadisticasButton.Size = new System.Drawing.Size(236, 29);
            this.estadisticasButton.TabIndex = 0;
            this.estadisticasButton.Text = "Estadísticas";
            this.estadisticasButton.UseVisualStyleBackColor = false;
            this.estadisticasButton.Click += new System.EventHandler(this.estadisticasbutton_Click);
            // 
            // salirbutton
            // 
            this.salirbutton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.salirbutton.Location = new System.Drawing.Point(499, 388);
            this.salirbutton.Name = "salirbutton";
            this.salirbutton.Size = new System.Drawing.Size(246, 29);
            this.salirbutton.TabIndex = 1;
            this.salirbutton.Text = "Salir";
            this.salirbutton.UseVisualStyleBackColor = false;
            this.salirbutton.Click += new System.EventHandler(this.salirbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DniColumn,
            this.nombreColumn,
            this.ApellidoColumn,
            this.Estado_actualColumn});
            this.dataGridView1.Location = new System.Drawing.Point(50, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(804, 207);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DniColumn
            // 
            this.DniColumn.HeaderText = "DNI";
            this.DniColumn.MinimumWidth = 6;
            this.DniColumn.Name = "DniColumn";
            this.DniColumn.Width = 150;
            // 
            // nombreColumn
            // 
            this.nombreColumn.HeaderText = "Nombre";
            this.nombreColumn.MinimumWidth = 6;
            this.nombreColumn.Name = "nombreColumn";
            this.nombreColumn.Width = 220;
            // 
            // ApellidoColumn
            // 
            this.ApellidoColumn.HeaderText = "Apellido";
            this.ApellidoColumn.MinimumWidth = 6;
            this.ApellidoColumn.Name = "ApellidoColumn";
            this.ApellidoColumn.Width = 220;
            // 
            // Estado_actualColumn
            // 
            this.Estado_actualColumn.HeaderText = "Estado actual";
            this.Estado_actualColumn.MinimumWidth = 6;
            this.Estado_actualColumn.Name = "Estado_actualColumn";
            this.Estado_actualColumn.Width = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(285, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de médicos disponibles";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(94, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Especialidad";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(495, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // medicosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.salirbutton);
            this.Controls.Add(this.estadisticasButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "medicosForm";
            this.Text = "Médicos";
            this.Load += new System.EventHandler(this.medicosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button estadisticasButton;
        private System.Windows.Forms.Button salirbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_actualColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}