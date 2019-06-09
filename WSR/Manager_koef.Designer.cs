namespace WSR
{
    partial class Manager_koef
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wSRDataSet = new WSR.WSRDataSet();
            this.wSRDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksTableAdapter = new WSR.WSRDataSetTableAdapters.tasksTableAdapter();
            this.ID_log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фио = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.грейд = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колво = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSRDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_log,
            this.Фио,
            this.грейд,
            this.колво});
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(448, 349);
            this.dataGridView1.TabIndex = 0;
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "tasks";
            this.tasksBindingSource.DataSource = this.wSRDataSet;
            // 
            // wSRDataSet
            // 
            this.wSRDataSet.DataSetName = "WSRDataSet";
            this.wSRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wSRDataSetBindingSource
            // 
            this.wSRDataSetBindingSource.DataSource = this.wSRDataSet;
            this.wSRDataSetBindingSource.Position = 0;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // ID_log
            // 
            this.ID_log.DataPropertyName = "ID_login";
            this.ID_log.HeaderText = "ID_login";
            this.ID_log.Name = "ID_log";
            this.ID_log.ReadOnly = true;
            // 
            // Фио
            // 
            this.Фио.HeaderText = "Фио";
            this.Фио.Name = "Фио";
            this.Фио.ReadOnly = true;
            // 
            // грейд
            // 
            this.грейд.HeaderText = "Грейд";
            this.грейд.Name = "грейд";
            this.грейд.ReadOnly = true;
            // 
            // колво
            // 
            this.колво.HeaderText = "Кол-во выполненых задач";
            this.колво.Name = "колво";
            this.колво.ReadOnly = true;
            // 
            // Manager_koef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(752, 397);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager_koef";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Коэфиценты";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSRDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource wSRDataSetBindingSource;
        private WSRDataSet wSRDataSet;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private WSRDataSetTableAdapters.tasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_log;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фио;
        private System.Windows.Forms.DataGridViewTextBoxColumn грейд;
        private System.Windows.Forms.DataGridViewTextBoxColumn колво;
    }
}