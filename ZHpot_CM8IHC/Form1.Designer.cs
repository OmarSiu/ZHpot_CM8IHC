namespace ZHpot_CM8IHC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neptunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttondel = new System.Windows.Forms.Button();
            this.textBoxszuro1 = new System.Windows.Forms.TextBox();
            this.textBoxszuro2 = new System.Windows.Forms.TextBox();
            this.listBoxnev = new System.Windows.Forms.ListBox();
            this.listBoxneptun = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.neptunDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.averageGradeDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(234, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(645, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // neptunDataGridViewTextBoxColumn
            // 
            this.neptunDataGridViewTextBoxColumn.DataPropertyName = "Neptun";
            this.neptunDataGridViewTextBoxColumn.HeaderText = "Neptun";
            this.neptunDataGridViewTextBoxColumn.Name = "neptunDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // averageGradeDataGridViewTextBoxColumn
            // 
            this.averageGradeDataGridViewTextBoxColumn.DataPropertyName = "AverageGrade";
            this.averageGradeDataGridViewTextBoxColumn.HeaderText = "AverageGrade";
            this.averageGradeDataGridViewTextBoxColumn.Name = "averageGradeDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(ZHpot_CM8IHC.Models.Student);
            // 
            // buttonadd
            // 
            this.buttonadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonadd.Location = new System.Drawing.Point(713, 355);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(116, 63);
            this.buttonadd.TabIndex = 1;
            this.buttonadd.Text = "add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttondel
            // 
            this.buttondel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttondel.Location = new System.Drawing.Point(544, 355);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(118, 63);
            this.buttondel.TabIndex = 2;
            this.buttondel.Text = "del";
            this.buttondel.UseVisualStyleBackColor = true;
            this.buttondel.Click += new System.EventHandler(this.buttondel_Click);
            // 
            // textBoxszuro1
            // 
            this.textBoxszuro1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxszuro1.Location = new System.Drawing.Point(12, 326);
            this.textBoxszuro1.Name = "textBoxszuro1";
            this.textBoxszuro1.Size = new System.Drawing.Size(120, 23);
            this.textBoxszuro1.TabIndex = 3;
            this.textBoxszuro1.TextChanged += new System.EventHandler(this.textBoxszuro1_TextChanged);
            // 
            // textBoxszuro2
            // 
            this.textBoxszuro2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxszuro2.Location = new System.Drawing.Point(12, 118);
            this.textBoxszuro2.Name = "textBoxszuro2";
            this.textBoxszuro2.Size = new System.Drawing.Size(120, 23);
            this.textBoxszuro2.TabIndex = 4;
            this.textBoxszuro2.TextChanged += new System.EventHandler(this.textBoxszuro2_TextChanged);
            // 
            // listBoxnev
            // 
            this.listBoxnev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxnev.FormattingEnabled = true;
            this.listBoxnev.ItemHeight = 15;
            this.listBoxnev.Location = new System.Drawing.Point(12, 355);
            this.listBoxnev.Name = "listBoxnev";
            this.listBoxnev.Size = new System.Drawing.Size(120, 94);
            this.listBoxnev.TabIndex = 5;
            // 
            // listBoxneptun
            // 
            this.listBoxneptun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxneptun.FormattingEnabled = true;
            this.listBoxneptun.ItemHeight = 15;
            this.listBoxneptun.Location = new System.Drawing.Point(12, 147);
            this.listBoxneptun.Name = "listBoxneptun";
            this.listBoxneptun.Size = new System.Drawing.Size(120, 94);
            this.listBoxneptun.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 508);
            this.Controls.Add(this.listBoxneptun);
            this.Controls.Add(this.listBoxnev);
            this.Controls.Add(this.textBoxszuro2);
            this.Controls.Add(this.textBoxszuro1);
            this.Controls.Add(this.buttondel);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn neptunDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn averageGradeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private BindingSource studentBindingSource;
        private Button buttonadd;
        private Button buttondel;
        private TextBox textBoxszuro1;
        private TextBox textBoxszuro2;
        private ListBox listBoxnev;
        private ListBox listBoxneptun;
    }
}