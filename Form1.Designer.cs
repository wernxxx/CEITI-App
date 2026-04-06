namespace CEITI
{
    partial class Form1
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
            System.Windows.Forms.Button btnUpdate;
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblAfisare = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnRaport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProfesorId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDisciplinaId = new System.Windows.Forms.TextBox();
            this.l = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(613, 244);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(173, 55);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Modifica nota";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.lblAfisare);
            this.panelRight.Controls.Add(this.dataGridView1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(937, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(937, 581);
            this.panelRight.TabIndex = 7;
            // 
            // lblAfisare
            // 
            this.lblAfisare.AutoSize = true;
            this.lblAfisare.Location = new System.Drawing.Point(467, 478);
            this.lblAfisare.Name = "lblAfisare";
            this.lblAfisare.Size = new System.Drawing.Size(73, 25);
            this.lblAfisare.TabIndex = 1;
            this.lblAfisare.Text = "Afisare";
            this.lblAfisare.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAfisare.Click += new System.EventHandler(this.lblAfisare_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(937, 439);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnRaport);
            this.panelLeft.Controls.Add(this.groupBox2);
            this.panelLeft.Controls.Add(this.btnLoad);
            this.panelLeft.Controls.Add(this.btnInsert);
            this.panelLeft.Controls.Add(this.btnFilter);
            this.panelLeft.Controls.Add(btnUpdate);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(937, 581);
            this.panelLeft.TabIndex = 8;
            // 
            // btnRaport
            // 
            this.btnRaport.Location = new System.Drawing.Point(628, 428);
            this.btnRaport.Name = "btnRaport";
            this.btnRaport.Size = new System.Drawing.Size(182, 75);
            this.btnRaport.TabIndex = 8;
            this.btnRaport.Text = "Raport";
            this.btnRaport.UseVisualStyleBackColor = true;
            this.btnRaport.Click += new System.EventHandler(this.btnRaport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNota);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtProfesorId);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDisciplinaId);
            this.groupBox2.Controls.Add(this.l);
            this.groupBox2.Controls.Add(this.txtStudentId);
            this.groupBox2.Location = new System.Drawing.Point(38, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 345);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestionare Note CEITI";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 260);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 29);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nota";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(212, 205);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(265, 29);
            this.txtNota.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "ProfesorID";
            // 
            // txtProfesorId
            // 
            this.txtProfesorId.Location = new System.Drawing.Point(212, 150);
            this.txtProfesorId.Name = "txtProfesorId";
            this.txtProfesorId.Size = new System.Drawing.Size(265, 29);
            this.txtProfesorId.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "DisciplinaID";
            // 
            // txtDisciplinaId
            // 
            this.txtDisciplinaId.Location = new System.Drawing.Point(212, 98);
            this.txtDisciplinaId.Name = "txtDisciplinaId";
            this.txtDisciplinaId.Size = new System.Drawing.Size(265, 29);
            this.txtDisciplinaId.TabIndex = 2;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(21, 53);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(99, 25);
            this.l.TabIndex = 1;
            this.l.Text = "StudentID";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(212, 50);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(265, 29);
            this.txtStudentId.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(613, 94);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(173, 55);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Incarca date";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(613, 165);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(173, 55);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Adauga nota";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(613, 315);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(230, 55);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filtrare dupa Student";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1874, 581);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProfesorId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDisciplinaId;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnRaport;
        private System.Windows.Forms.Label lblAfisare;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

