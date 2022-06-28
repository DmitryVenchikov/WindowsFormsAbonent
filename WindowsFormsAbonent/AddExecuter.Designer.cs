namespace WindowsFormsAbonent
{
    partial class AddExecuter
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
            this.buttonAddExecuter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddExecuter
            // 
            this.buttonAddExecuter.Location = new System.Drawing.Point(318, 343);
            this.buttonAddExecuter.Name = "buttonAddExecuter";
            this.buttonAddExecuter.Size = new System.Drawing.Size(175, 39);
            this.buttonAddExecuter.TabIndex = 26;
            this.buttonAddExecuter.Text = "Добавить слесаря";
            this.buttonAddExecuter.UseVisualStyleBackColor = true;
            this.buttonAddExecuter.Click += new System.EventHandler(this.buttonAddExecuter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(245, 162);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(406, 22);
            this.textBoxFIO.TabIndex = 15;
            this.textBoxFIO.TextChanged += new System.EventHandler(this.textBoxFIO_TextChanged);
            // 
            // AddExecuter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddExecuter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFIO);
            this.Name = "AddExecuter";
            this.Text = "AddExecuter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddExecuter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFIO;
    }
}