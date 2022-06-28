namespace WindowsFormsAbonent
{
    partial class AddDisrepair
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
            this.buttonAddDisrepair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFAILURENM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddDisrepair
            // 
            this.buttonAddDisrepair.Location = new System.Drawing.Point(251, 305);
            this.buttonAddDisrepair.Name = "buttonAddDisrepair";
            this.buttonAddDisrepair.Size = new System.Drawing.Size(285, 39);
            this.buttonAddDisrepair.TabIndex = 29;
            this.buttonAddDisrepair.Text = "Добавить неисправность";
            this.buttonAddDisrepair.UseVisualStyleBackColor = true;
            this.buttonAddDisrepair.Click += new System.EventHandler(this.buttonAddDisrepair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "FAILURENM";
            // 
            // textBoxFAILURENM
            // 
            this.textBoxFAILURENM.Location = new System.Drawing.Point(251, 115);
            this.textBoxFAILURENM.Name = "textBoxFAILURENM";
            this.textBoxFAILURENM.Size = new System.Drawing.Size(406, 22);
            this.textBoxFAILURENM.TabIndex = 27;
            // 
            // AddDisrepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddDisrepair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFAILURENM);
            this.Name = "AddDisrepair";
            this.Text = "AddDisrepair";
            this.Load += new System.EventHandler(this.AddDisrepair_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddDisrepair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFAILURENM;
    }
}