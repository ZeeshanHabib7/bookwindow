namespace oose_Project
{
    partial class ViewReq
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LibrarySystemDataSet = new oose_Project.LibrarySystemDataSet();
            this.BookREqBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BookREqTableAdapter = new oose_Project.LibrarySystemDataSetTableAdapters.BookREqTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibrarySystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookREqBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(977, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(773, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "View Requests";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(757, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "View Reuturn Status";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BookREqBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "oose_Project.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 334);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(977, 244);
            this.reportViewer1.TabIndex = 3;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // LibrarySystemDataSet
            // 
            this.LibrarySystemDataSet.DataSetName = "LibrarySystemDataSet";
            this.LibrarySystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BookREqBindingSource
            // 
            this.BookREqBindingSource.DataMember = "BookREq";
            this.BookREqBindingSource.DataSource = this.LibrarySystemDataSet;
            // 
            // BookREqTableAdapter
            // 
            this.BookREqTableAdapter.ClearBeforeFill = true;
            // 
            // ViewReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 626);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewReq";
            this.Text = "ViewReq";
            this.Load += new System.EventHandler(this.ViewReq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibrarySystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookREqBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BookREqBindingSource;
        private LibrarySystemDataSet LibrarySystemDataSet;
        private LibrarySystemDataSetTableAdapters.BookREqTableAdapter BookREqTableAdapter;
    }
}