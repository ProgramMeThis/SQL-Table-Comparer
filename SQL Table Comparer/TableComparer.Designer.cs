namespace SQL_Server_Compare
{
    partial class TableComparer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableComparer));
            this.table1DataGridView = new System.Windows.Forms.DataGridView();
            this.table2DataGridView = new System.Windows.Forms.DataGridView();
            this.table1Label = new System.Windows.Forms.Label();
            this.table2Label = new System.Windows.Forms.Label();
            this.table1ComboBox = new System.Windows.Forms.ComboBox();
            this.changeTable1ConnectionButton = new System.Windows.Forms.Button();
            this.changeTable2ConnectionButton = new System.Windows.Forms.Button();
            this.table2ComboBox = new System.Windows.Forms.ComboBox();
            this.runComparisonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // table1DataGridView
            // 
            this.table1DataGridView.AllowUserToAddRows = false;
            this.table1DataGridView.AllowUserToDeleteRows = false;
            this.table1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table1DataGridView.Location = new System.Drawing.Point(12, 85);
            this.table1DataGridView.Name = "table1DataGridView";
            this.table1DataGridView.ReadOnly = true;
            this.table1DataGridView.Size = new System.Drawing.Size(475, 463);
            this.table1DataGridView.TabIndex = 1;
            // 
            // table2DataGridView
            // 
            this.table2DataGridView.AllowUserToAddRows = false;
            this.table2DataGridView.AllowUserToDeleteRows = false;
            this.table2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table2DataGridView.Location = new System.Drawing.Point(532, 85);
            this.table2DataGridView.Name = "table2DataGridView";
            this.table2DataGridView.ReadOnly = true;
            this.table2DataGridView.Size = new System.Drawing.Size(475, 463);
            this.table2DataGridView.TabIndex = 2;
            // 
            // table1Label
            // 
            this.table1Label.AutoSize = true;
            this.table1Label.Location = new System.Drawing.Point(9, 10);
            this.table1Label.Name = "table1Label";
            this.table1Label.Size = new System.Drawing.Size(35, 13);
            this.table1Label.TabIndex = 3;
            this.table1Label.Text = "label1";
            this.table1Label.Visible = false;
            // 
            // table2Label
            // 
            this.table2Label.AutoSize = true;
            this.table2Label.Location = new System.Drawing.Point(529, 10);
            this.table2Label.Name = "table2Label";
            this.table2Label.Size = new System.Drawing.Size(35, 13);
            this.table2Label.TabIndex = 4;
            this.table2Label.Text = "label2";
            this.table2Label.Visible = false;
            // 
            // table1ComboBox
            // 
            this.table1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.table1ComboBox.FormattingEnabled = true;
            this.table1ComboBox.Location = new System.Drawing.Point(247, 58);
            this.table1ComboBox.Name = "table1ComboBox";
            this.table1ComboBox.Size = new System.Drawing.Size(240, 21);
            this.table1ComboBox.TabIndex = 6;
            // 
            // changeTable1ConnectionButton
            // 
            this.changeTable1ConnectionButton.Location = new System.Drawing.Point(247, 29);
            this.changeTable1ConnectionButton.Name = "changeTable1ConnectionButton";
            this.changeTable1ConnectionButton.Size = new System.Drawing.Size(240, 23);
            this.changeTable1ConnectionButton.TabIndex = 7;
            this.changeTable1ConnectionButton.Text = "Choose Connection";
            this.changeTable1ConnectionButton.UseVisualStyleBackColor = true;
            this.changeTable1ConnectionButton.Click += new System.EventHandler(this.changeTable1ConnectionButton_Click);
            // 
            // changeTable2ConnectionButton
            // 
            this.changeTable2ConnectionButton.Location = new System.Drawing.Point(767, 29);
            this.changeTable2ConnectionButton.Name = "changeTable2ConnectionButton";
            this.changeTable2ConnectionButton.Size = new System.Drawing.Size(240, 23);
            this.changeTable2ConnectionButton.TabIndex = 9;
            this.changeTable2ConnectionButton.Text = "Choose Connection";
            this.changeTable2ConnectionButton.UseVisualStyleBackColor = true;
            this.changeTable2ConnectionButton.Click += new System.EventHandler(this.changeTable2ConnectionButton_Click);
            // 
            // table2ComboBox
            // 
            this.table2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.table2ComboBox.FormattingEnabled = true;
            this.table2ComboBox.Location = new System.Drawing.Point(767, 58);
            this.table2ComboBox.Name = "table2ComboBox";
            this.table2ComboBox.Size = new System.Drawing.Size(240, 21);
            this.table2ComboBox.TabIndex = 8;
            // 
            // runComparisonButton
            // 
            this.runComparisonButton.Location = new System.Drawing.Point(888, 554);
            this.runComparisonButton.Name = "runComparisonButton";
            this.runComparisonButton.Size = new System.Drawing.Size(119, 38);
            this.runComparisonButton.TabIndex = 10;
            this.runComparisonButton.Text = "Run Comparison";
            this.runComparisonButton.UseVisualStyleBackColor = true;
            this.runComparisonButton.Click += new System.EventHandler(this.runComparisonButton_Click);
            // 
            // TableComparer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 604);
            this.Controls.Add(this.runComparisonButton);
            this.Controls.Add(this.changeTable2ConnectionButton);
            this.Controls.Add(this.table2ComboBox);
            this.Controls.Add(this.changeTable1ConnectionButton);
            this.Controls.Add(this.table1ComboBox);
            this.Controls.Add(this.table2Label);
            this.Controls.Add(this.table1Label);
            this.Controls.Add(this.table2DataGridView);
            this.Controls.Add(this.table1DataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableComparer";
            this.Text = "Table Comparer";
            this.Load += new System.EventHandler(this.TableComparer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table1DataGridView;
        private System.Windows.Forms.DataGridView table2DataGridView;
        private System.Windows.Forms.Label table1Label;
        private System.Windows.Forms.Label table2Label;
        private System.Windows.Forms.ComboBox table1ComboBox;
        private System.Windows.Forms.Button changeTable1ConnectionButton;
        private System.Windows.Forms.Button changeTable2ConnectionButton;
        private System.Windows.Forms.ComboBox table2ComboBox;
        private System.Windows.Forms.Button runComparisonButton;
    }
}