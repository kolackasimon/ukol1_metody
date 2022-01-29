
namespace ukol1_metody
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCtverecObsah = new System.Windows.Forms.Label();
            this.labelObdelnikObsah = new System.Windows.Forms.Label();
            this.labelKrychleObjem = new System.Windows.Forms.Label();
            this.labelKvadrObjem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown1.Location = new System.Drawing.Point(127, 76);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 39);
            this.numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown2.Location = new System.Drawing.Point(371, 76);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 39);
            this.numericUpDown2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(410, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(204, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Obsah";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(623, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Objem";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(353, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Vypočítat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCtverecObsah
            // 
            this.labelCtverecObsah.BackColor = System.Drawing.Color.Transparent;
            this.labelCtverecObsah.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCtverecObsah.ForeColor = System.Drawing.Color.White;
            this.labelCtverecObsah.Location = new System.Drawing.Point(115, 248);
            this.labelCtverecObsah.Name = "labelCtverecObsah";
            this.labelCtverecObsah.Size = new System.Drawing.Size(277, 32);
            this.labelCtverecObsah.TabIndex = 9;
            this.labelCtverecObsah.Text = "Čtverec: ";
            this.labelCtverecObsah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelObdelnikObsah
            // 
            this.labelObdelnikObsah.BackColor = System.Drawing.Color.Transparent;
            this.labelObdelnikObsah.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelObdelnikObsah.ForeColor = System.Drawing.Color.White;
            this.labelObdelnikObsah.Location = new System.Drawing.Point(115, 307);
            this.labelObdelnikObsah.Name = "labelObdelnikObsah";
            this.labelObdelnikObsah.Size = new System.Drawing.Size(277, 32);
            this.labelObdelnikObsah.TabIndex = 10;
            this.labelObdelnikObsah.Text = "Obdélník: ";
            this.labelObdelnikObsah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelKrychleObjem
            // 
            this.labelKrychleObjem.BackColor = System.Drawing.Color.Transparent;
            this.labelKrychleObjem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKrychleObjem.ForeColor = System.Drawing.Color.White;
            this.labelKrychleObjem.Location = new System.Drawing.Point(520, 248);
            this.labelKrychleObjem.Name = "labelKrychleObjem";
            this.labelKrychleObjem.Size = new System.Drawing.Size(277, 32);
            this.labelKrychleObjem.TabIndex = 11;
            this.labelKrychleObjem.Text = "Krychle: ";
            this.labelKrychleObjem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelKvadrObjem
            // 
            this.labelKvadrObjem.BackColor = System.Drawing.Color.Transparent;
            this.labelKvadrObjem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKvadrObjem.ForeColor = System.Drawing.Color.White;
            this.labelKvadrObjem.Location = new System.Drawing.Point(520, 307);
            this.labelKvadrObjem.Name = "labelKvadrObjem";
            this.labelKvadrObjem.Size = new System.Drawing.Size(277, 32);
            this.labelKvadrObjem.TabIndex = 12;
            this.labelKvadrObjem.Text = "Kvádr: ";
            this.labelKvadrObjem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(656, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "C";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown3.Location = new System.Drawing.Point(617, 76);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 39);
            this.numericUpDown3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(908, 503);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.labelKvadrObjem);
            this.Controls.Add(this.labelKrychleObjem);
            this.Controls.Add(this.labelObdelnikObsah);
            this.Controls.Add(this.labelCtverecObsah);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homework1 /kolackasimon";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCtverecObsah;
        private System.Windows.Forms.Label labelObdelnikObsah;
        private System.Windows.Forms.Label labelKrychleObjem;
        private System.Windows.Forms.Label labelKvadrObjem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}

