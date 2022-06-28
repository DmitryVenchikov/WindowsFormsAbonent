namespace WindowsFormsAbonent
{
    partial class AddRequest
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
            this.textBoxAccountCD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxExecutorCD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFailureCD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerIncomingDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerExecutionDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxExecuted = new System.Windows.Forms.CheckBox();
            this.buttonAddRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAccountCD
            // 
            this.textBoxAccountCD.Location = new System.Drawing.Point(249, 70);
            this.textBoxAccountCD.Name = "textBoxAccountCD";
            this.textBoxAccountCD.Size = new System.Drawing.Size(406, 22);
            this.textBoxAccountCD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "AccountCD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ExecutorCD";
            // 
            // textBoxExecutorCD
            // 
            this.textBoxExecutorCD.Location = new System.Drawing.Point(249, 106);
            this.textBoxExecutorCD.Name = "textBoxExecutorCD";
            this.textBoxExecutorCD.Size = new System.Drawing.Size(406, 22);
            this.textBoxExecutorCD.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "FailureCD";
            // 
            // textBoxFailureCD
            // 
            this.textBoxFailureCD.Location = new System.Drawing.Point(249, 140);
            this.textBoxFailureCD.Name = "textBoxFailureCD";
            this.textBoxFailureCD.Size = new System.Drawing.Size(406, 22);
            this.textBoxFailureCD.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "IncomingDate";
            // 
            // dateTimePickerIncomingDate
            // 
            this.dateTimePickerIncomingDate.Location = new System.Drawing.Point(249, 180);
            this.dateTimePickerIncomingDate.Name = "dateTimePickerIncomingDate";
            this.dateTimePickerIncomingDate.Size = new System.Drawing.Size(406, 22);
            this.dateTimePickerIncomingDate.TabIndex = 7;
            // 
            // dateTimePickerExecutionDate
            // 
            this.dateTimePickerExecutionDate.Location = new System.Drawing.Point(249, 218);
            this.dateTimePickerExecutionDate.Name = "dateTimePickerExecutionDate";
            this.dateTimePickerExecutionDate.Size = new System.Drawing.Size(406, 22);
            this.dateTimePickerExecutionDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "ExecutionDate";
            // 
            // checkBoxExecuted
            // 
            this.checkBoxExecuted.AutoSize = true;
            this.checkBoxExecuted.Location = new System.Drawing.Point(249, 264);
            this.checkBoxExecuted.Name = "checkBoxExecuted";
            this.checkBoxExecuted.Size = new System.Drawing.Size(85, 20);
            this.checkBoxExecuted.TabIndex = 13;
            this.checkBoxExecuted.Text = "Executed";
            this.checkBoxExecuted.UseVisualStyleBackColor = true;
            // 
            // buttonAddRequest
            // 
            this.buttonAddRequest.Location = new System.Drawing.Point(316, 344);
            this.buttonAddRequest.Name = "buttonAddRequest";
            this.buttonAddRequest.Size = new System.Drawing.Size(175, 39);
            this.buttonAddRequest.TabIndex = 14;
            this.buttonAddRequest.Text = "Добавить заявку";
            this.buttonAddRequest.UseVisualStyleBackColor = true;
            this.buttonAddRequest.Click += new System.EventHandler(this.buttonAddRequest_Click);
            // 
            // AddExecuter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddRequest);
            this.Controls.Add(this.checkBoxExecuted);
            this.Controls.Add(this.dateTimePickerExecutionDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerIncomingDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFailureCD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxExecutorCD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAccountCD);
            this.Name = "AddExecuter";
            this.Text = "AddRequest";
            this.Load += new System.EventHandler(this.AddExecuter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxAccountCD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxExecutorCD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFailureCD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerIncomingDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerExecutionDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxExecuted;
        private System.Windows.Forms.Button buttonAddRequest;
    }
}