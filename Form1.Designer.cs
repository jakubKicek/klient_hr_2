namespace HR_To_AWS
{
    partial class Form1
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
            this.RunBTN = new System.Windows.Forms.Button();
            this.ReadBTN = new System.Windows.Forms.Button();
            this.ToCSVBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holldaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpracDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.illdaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workdaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aWSPRACWEKTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SendBTN = new System.Windows.Forms.Button();
            this.ChartBTN = new System.Windows.Forms.Button();
            this.RunLBL = new System.Windows.Forms.Label();
            this.ReadLBL = new System.Windows.Forms.Label();
            this.ToCSVLBL = new System.Windows.Forms.Label();
            this.SendLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aWSPRACWEKTORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RunBTN
            // 
            this.RunBTN.Location = new System.Drawing.Point(30, 37);
            this.RunBTN.Name = "RunBTN";
            this.RunBTN.Size = new System.Drawing.Size(106, 23);
            this.RunBTN.TabIndex = 0;
            this.RunBTN.Text = "Run";
            this.RunBTN.UseVisualStyleBackColor = true;
            this.RunBTN.Click += new System.EventHandler(this.RunBTN_Click);
            // 
            // ReadBTN
            // 
            this.ReadBTN.Location = new System.Drawing.Point(30, 83);
            this.ReadBTN.Name = "ReadBTN";
            this.ReadBTN.Size = new System.Drawing.Size(106, 23);
            this.ReadBTN.TabIndex = 1;
            this.ReadBTN.Text = "Read";
            this.ReadBTN.UseVisualStyleBackColor = true;
            this.ReadBTN.Click += new System.EventHandler(this.ReadBTN_Click);
            // 
            // ToCSVBTN
            // 
            this.ToCSVBTN.Location = new System.Drawing.Point(30, 127);
            this.ToCSVBTN.Name = "ToCSVBTN";
            this.ToCSVBTN.Size = new System.Drawing.Size(106, 23);
            this.ToCSVBTN.TabIndex = 2;
            this.ToCSVBTN.Text = "To CSV";
            this.ToCSVBTN.UseVisualStyleBackColor = true;
            this.ToCSVBTN.Click += new System.EventHandler(this.ToCSVBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.holldaysDataGridViewTextBoxColumn,
            this.idpracDataGridViewTextBoxColumn,
            this.illdaysDataGridViewTextBoxColumn,
            this.workdaysDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aWSPRACWEKTORBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(336, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(838, 373);
            this.dataGridView1.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // holldaysDataGridViewTextBoxColumn
            // 
            this.holldaysDataGridViewTextBoxColumn.DataPropertyName = "holl_days";
            this.holldaysDataGridViewTextBoxColumn.HeaderText = "holl_days";
            this.holldaysDataGridViewTextBoxColumn.Name = "holldaysDataGridViewTextBoxColumn";
            // 
            // idpracDataGridViewTextBoxColumn
            // 
            this.idpracDataGridViewTextBoxColumn.DataPropertyName = "id_prac";
            this.idpracDataGridViewTextBoxColumn.HeaderText = "id_prac";
            this.idpracDataGridViewTextBoxColumn.Name = "idpracDataGridViewTextBoxColumn";
            // 
            // illdaysDataGridViewTextBoxColumn
            // 
            this.illdaysDataGridViewTextBoxColumn.DataPropertyName = "ill_days";
            this.illdaysDataGridViewTextBoxColumn.HeaderText = "ill_days";
            this.illdaysDataGridViewTextBoxColumn.Name = "illdaysDataGridViewTextBoxColumn";
            // 
            // workdaysDataGridViewTextBoxColumn
            // 
            this.workdaysDataGridViewTextBoxColumn.DataPropertyName = "work_days";
            this.workdaysDataGridViewTextBoxColumn.HeaderText = "work_days";
            this.workdaysDataGridViewTextBoxColumn.Name = "workdaysDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "month";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            // 
            // aWSPRACWEKTORBindingSource
            // 
            this.aWSPRACWEKTORBindingSource.DataSource = typeof(HR_To_AWS.AWS_PRAC_WEKTOR);
            // 
            // SendBTN
            // 
            this.SendBTN.Location = new System.Drawing.Point(30, 169);
            this.SendBTN.Name = "SendBTN";
            this.SendBTN.Size = new System.Drawing.Size(106, 23);
            this.SendBTN.TabIndex = 6;
            this.SendBTN.Text = "Send CSV to Cloud";
            this.SendBTN.UseVisualStyleBackColor = true;
            this.SendBTN.Click += new System.EventHandler(this.SendBTN_Click);
            // 
            // ChartBTN
            // 
            this.ChartBTN.Location = new System.Drawing.Point(30, 211);
            this.ChartBTN.Name = "ChartBTN";
            this.ChartBTN.Size = new System.Drawing.Size(106, 23);
            this.ChartBTN.TabIndex = 7;
            this.ChartBTN.Text = "Prezentacja";
            this.ChartBTN.UseVisualStyleBackColor = true;
            this.ChartBTN.Click += new System.EventHandler(this.ChartBTN_Click);
            // 
            // RunLBL
            // 
            this.RunLBL.AutoEllipsis = true;
            this.RunLBL.AutoSize = true;
            this.RunLBL.Location = new System.Drawing.Point(155, 42);
            this.RunLBL.Name = "RunLBL";
            this.RunLBL.Size = new System.Drawing.Size(136, 13);
            this.RunLBL.TabIndex = 8;
            this.RunLBL.Text = "Dane zostały przetworzone";
            // 
            // ReadLBL
            // 
            this.ReadLBL.AutoSize = true;
            this.ReadLBL.Location = new System.Drawing.Point(155, 88);
            this.ReadLBL.Name = "ReadLBL";
            this.ReadLBL.Size = new System.Drawing.Size(118, 13);
            this.ReadLBL.TabIndex = 9;
            this.ReadLBL.Text = "Dane zostały wczytane";
            // 
            // ToCSVLBL
            // 
            this.ToCSVLBL.AutoSize = true;
            this.ToCSVLBL.Location = new System.Drawing.Point(155, 132);
            this.ToCSVLBL.Name = "ToCSVLBL";
            this.ToCSVLBL.Size = new System.Drawing.Size(127, 13);
            this.ToCSVLBL.TabIndex = 10;
            this.ToCSVLBL.Text = "Przygotowano do wysyłki";
            // 
            // SendLBL
            // 
            this.SendLBL.AutoSize = true;
            this.SendLBL.Location = new System.Drawing.Point(155, 174);
            this.SendLBL.Name = "SendLBL";
            this.SendLBL.Size = new System.Drawing.Size(131, 13);
            this.SendLBL.TabIndex = 11;
            this.SendLBL.Text = "Wysłano do serwisu AWS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 450);
            this.Controls.Add(this.SendLBL);
            this.Controls.Add(this.ToCSVLBL);
            this.Controls.Add(this.ReadLBL);
            this.Controls.Add(this.RunLBL);
            this.Controls.Add(this.ChartBTN);
            this.Controls.Add(this.SendBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ToCSVBTN);
            this.Controls.Add(this.ReadBTN);
            this.Controls.Add(this.RunBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aWSPRACWEKTORBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RunBTN;
        private System.Windows.Forms.Button ReadBTN;
        private System.Windows.Forms.Button ToCSVBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holldaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpracDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn illdaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workdaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aWSPRACWEKTORBindingSource;
        private System.Windows.Forms.Button SendBTN;
        private System.Windows.Forms.Button ChartBTN;
        private System.Windows.Forms.Label RunLBL;
        private System.Windows.Forms.Label ReadLBL;
        private System.Windows.Forms.Label ToCSVLBL;
        private System.Windows.Forms.Label SendLBL;
    }
}

