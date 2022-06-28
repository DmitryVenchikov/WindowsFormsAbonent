namespace WindowsFormsAbonent
{
    partial class EditDisrepairForm
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
            this.buttonEditDisrepair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFAILURENM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEditDisrepair
            // 
            this.buttonEditDisrepair.Location = new System.Drawing.Point(251, 301);
            this.buttonEditDisrepair.Name = "buttonEditDisrepair";
            this.buttonEditDisrepair.Size = new System.Drawing.Size(285, 39);
            this.buttonEditDisrepair.TabIndex = 32;
            this.buttonEditDisrepair.Text = "Редактировать неисправность";
            this.buttonEditDisrepair.UseVisualStyleBackColor = true;
            this.buttonEditDisrepair.Click += new System.EventHandler(this.buttonEditDisrepair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "FAILURENM";
            // 
            // textBoxFAILURENM
            // 
            this.textBoxFAILURENM.Location = new System.Drawing.Point(251, 111);
            this.textBoxFAILURENM.Name = "textBoxFAILURENM";
            this.textBoxFAILURENM.Size = new System.Drawing.Size(406, 22);
            this.textBoxFAILURENM.TabIndex = 30;
            // 
            // EditDisrepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.buttonEditDisrepair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFAILURENM);
            this.Name = "EditDisrepairForm";
            this.Text = "EditDisrepairForm";
            this.Load += new System.EventHandler(this.EditDisrepairForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditDisrepair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFAILURENM;
    }
}