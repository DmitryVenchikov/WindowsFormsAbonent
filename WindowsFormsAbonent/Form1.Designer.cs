namespace WindowsFormsAbonent
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewRequest = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRequest = new System.Windows.Forms.TabPage();
            this.tabPageExecutor = new System.Windows.Forms.TabPage();
            this.dataGridViewExecutor = new System.Windows.Forms.DataGridView();
            this.tabPageDisrepair = new System.Windows.Forms.TabPage();
            this.dataGridViewDisrepair = new System.Windows.Forms.DataGridView();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageRequest.SuspendLayout();
            this.tabPageExecutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExecutor)).BeginInit();
            this.tabPageDisrepair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisrepair)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRequest
            // 
            this.dataGridViewRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequest.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewRequest.Name = "dataGridViewRequest";
            this.dataGridViewRequest.RowHeadersWidth = 51;
            this.dataGridViewRequest.RowTemplate.Height = 24;
            this.dataGridViewRequest.Size = new System.Drawing.Size(769, 236);
            this.dataGridViewRequest.TabIndex = 0;
            this.dataGridViewRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRequest_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRequest);
            this.tabControl1.Controls.Add(this.tabPageExecutor);
            this.tabControl1.Controls.Add(this.tabPageDisrepair);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 344);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageRequest
            // 
            this.tabPageRequest.Controls.Add(this.dataGridViewRequest);
            this.tabPageRequest.Location = new System.Drawing.Point(4, 25);
            this.tabPageRequest.Name = "tabPageRequest";
            this.tabPageRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRequest.Size = new System.Drawing.Size(781, 315);
            this.tabPageRequest.TabIndex = 0;
            this.tabPageRequest.Text = "Заявки";
            this.tabPageRequest.UseVisualStyleBackColor = true;
            // 
            // tabPageExecutor
            // 
            this.tabPageExecutor.Controls.Add(this.dataGridViewExecutor);
            this.tabPageExecutor.Location = new System.Drawing.Point(4, 25);
            this.tabPageExecutor.Name = "tabPageExecutor";
            this.tabPageExecutor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExecutor.Size = new System.Drawing.Size(781, 315);
            this.tabPageExecutor.TabIndex = 1;
            this.tabPageExecutor.Text = "Слесари";
            this.tabPageExecutor.UseVisualStyleBackColor = true;
            // 
            // dataGridViewExecutor
            // 
            this.dataGridViewExecutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExecutor.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewExecutor.Name = "dataGridViewExecutor";
            this.dataGridViewExecutor.RowHeadersWidth = 51;
            this.dataGridViewExecutor.RowTemplate.Height = 24;
            this.dataGridViewExecutor.Size = new System.Drawing.Size(769, 236);
            this.dataGridViewExecutor.TabIndex = 1;
            // 
            // tabPageDisrepair
            // 
            this.tabPageDisrepair.Controls.Add(this.dataGridViewDisrepair);
            this.tabPageDisrepair.Location = new System.Drawing.Point(4, 25);
            this.tabPageDisrepair.Name = "tabPageDisrepair";
            this.tabPageDisrepair.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDisrepair.Size = new System.Drawing.Size(781, 315);
            this.tabPageDisrepair.TabIndex = 2;
            this.tabPageDisrepair.Text = "Неисправности";
            this.tabPageDisrepair.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDisrepair
            // 
            this.dataGridViewDisrepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisrepair.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewDisrepair.Name = "dataGridViewDisrepair";
            this.dataGridViewDisrepair.RowHeadersWidth = 51;
            this.dataGridViewDisrepair.RowTemplate.Height = 24;
            this.dataGridViewDisrepair.Size = new System.Drawing.Size(769, 236);
            this.dataGridViewDisrepair.TabIndex = 2;
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDataAdapter2
            // 
            this.sqlDataAdapter2.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDataAdapter2.InsertCommand = this.sqlInsertCommand2;
            this.sqlDataAdapter2.SelectCommand = this.sqlSelectCommand2;
            this.sqlDataAdapter2.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(148, 76);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(146, 28);
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(145, 24);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 459);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Лабораторная 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageRequest.ResumeLayout(false);
            this.tabPageExecutor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExecutor)).EndInit();
            this.tabPageDisrepair.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisrepair)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRequest;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRequest;
        private System.Windows.Forms.TabPage tabPageExecutor;
        private System.Windows.Forms.DataGridView dataGridViewExecutor;
        private System.Windows.Forms.TabPage tabPageDisrepair;
        private System.Windows.Forms.DataGridView dataGridViewDisrepair;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
    }
}

