namespace ZHpot_CM8IHC
{
    partial class NewStudent
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
            this.components = new System.ComponentModel.Container();
            this.textBoxnev = new System.Windows.Forms.TextBox();
            this.buttonok = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxneptun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxnev
            // 
            this.textBoxnev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxnev.Location = new System.Drawing.Point(65, 33);
            this.textBoxnev.Name = "textBoxnev";
            this.textBoxnev.Size = new System.Drawing.Size(100, 23);
            this.textBoxnev.TabIndex = 0;
            this.textBoxnev.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxnev_Validating);
            this.textBoxnev.Validated += new System.EventHandler(this.textBoxnev_Validated);
            // 
            // buttonok
            // 
            this.buttonok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonok.Location = new System.Drawing.Point(598, 302);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(94, 61);
            this.buttonok.TabIndex = 2;
            this.buttonok.Text = "ok";
            this.buttonok.UseVisualStyleBackColor = true;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttoncancel.Location = new System.Drawing.Point(467, 303);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(93, 60);
            this.buttoncancel.TabIndex = 3;
            this.buttoncancel.Text = "cancel";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBoxneptun
            // 
            this.textBoxneptun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxneptun.Location = new System.Drawing.Point(65, 86);
            this.textBoxneptun.Name = "textBoxneptun";
            this.textBoxneptun.Size = new System.Drawing.Size(100, 23);
            this.textBoxneptun.TabIndex = 4;
            this.textBoxneptun.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxneptun_Validating);
            this.textBoxneptun.Validated += new System.EventHandler(this.textBoxneptun_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "nev";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "neptun";
            // 
            // NewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxneptun);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonok);
            this.Controls.Add(this.textBoxnev);
            this.Name = "NewStudent";
            this.Text = "NewStudent";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox textBoxnev;
        private Button buttonok;
        private Button buttoncancel;
        private ErrorProvider errorProvider1;
        public TextBox textBoxneptun;
        private Label label2;
        private Label label1;
    }
}