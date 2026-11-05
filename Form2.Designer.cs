namespace examen_recu2
{
    partial class Form2
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.textnota1 = new System.Windows.Forms.TextBox();
            this.textnota2 = new System.Windows.Forms.TextBox();
            this.textnota3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textnota1
            // 
            this.textnota1.Location = new System.Drawing.Point(311, 49);
            this.textnota1.Name = "textnota1";
            this.textnota1.Size = new System.Drawing.Size(100, 22);
            this.textnota1.TabIndex = 1;
            this.textnota1.TextChanged += new System.EventHandler(this.textnota1_TextChanged);
            // 
            // textnota2
            // 
            this.textnota2.Location = new System.Drawing.Point(311, 120);
            this.textnota2.Name = "textnota2";
            this.textnota2.Size = new System.Drawing.Size(100, 22);
            this.textnota2.TabIndex = 2;
            // 
            // textnota3
            // 
            this.textnota3.Location = new System.Drawing.Point(311, 184);
            this.textnota3.Name = "textnota3";
            this.textnota3.Size = new System.Drawing.Size(100, 22);
            this.textnota3.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textnota3);
            this.Controls.Add(this.textnota2);
            this.Controls.Add(this.textnota1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textnota1;
        private System.Windows.Forms.TextBox textnota2;
        private System.Windows.Forms.TextBox textnota3;
    }
}