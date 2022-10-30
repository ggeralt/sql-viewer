namespace SQLViewer
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CbDatabases = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LbTables = new System.Windows.Forms.ListBox();
            this.LbTableColumns = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LbViews = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LbViewColumns = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LbProcedureParameters = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LbProcedures = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TbProcedureDefinition = new System.Windows.Forms.TextBox();
            this.BtnXMLTables = new System.Windows.Forms.Button();
            this.BtnSelectTables = new System.Windows.Forms.Button();
            this.BtnSelectViews = new System.Windows.Forms.Button();
            this.BtnXMLViews = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Databases";
            // 
            // CbDatabases
            // 
            this.CbDatabases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbDatabases.FormattingEnabled = true;
            this.CbDatabases.Location = new System.Drawing.Point(90, 42);
            this.CbDatabases.Name = "CbDatabases";
            this.CbDatabases.Size = new System.Drawing.Size(177, 23);
            this.CbDatabases.TabIndex = 1;
            this.CbDatabases.SelectedIndexChanged += new System.EventHandler(this.CbDatabases_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tables";
            // 
            // LbTables
            // 
            this.LbTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTables.FormattingEnabled = true;
            this.LbTables.ItemHeight = 15;
            this.LbTables.Location = new System.Drawing.Point(90, 115);
            this.LbTables.Name = "LbTables";
            this.LbTables.Size = new System.Drawing.Size(177, 139);
            this.LbTables.TabIndex = 3;
            this.LbTables.SelectedIndexChanged += new System.EventHandler(this.LbTables_SelectedIndexChanged);
            // 
            // LbTableColumns
            // 
            this.LbTableColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTableColumns.FormattingEnabled = true;
            this.LbTableColumns.ItemHeight = 15;
            this.LbTableColumns.Location = new System.Drawing.Point(388, 115);
            this.LbTableColumns.Name = "LbTableColumns";
            this.LbTableColumns.Size = new System.Drawing.Size(177, 139);
            this.LbTableColumns.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Table Columns";
            // 
            // LbViews
            // 
            this.LbViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbViews.FormattingEnabled = true;
            this.LbViews.ItemHeight = 15;
            this.LbViews.Location = new System.Drawing.Point(693, 115);
            this.LbViews.Name = "LbViews";
            this.LbViews.Size = new System.Drawing.Size(177, 139);
            this.LbViews.TabIndex = 7;
            this.LbViews.SelectedIndexChanged += new System.EventHandler(this.LbViews_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(690, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Views";
            // 
            // LbViewColumns
            // 
            this.LbViewColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbViewColumns.FormattingEnabled = true;
            this.LbViewColumns.ItemHeight = 15;
            this.LbViewColumns.Location = new System.Drawing.Point(1004, 115);
            this.LbViewColumns.Name = "LbViewColumns";
            this.LbViewColumns.Size = new System.Drawing.Size(177, 139);
            this.LbViewColumns.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1001, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "View Columns";
            // 
            // LbProcedureParameters
            // 
            this.LbProcedureParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProcedureParameters.FormattingEnabled = true;
            this.LbProcedureParameters.ItemHeight = 15;
            this.LbProcedureParameters.Location = new System.Drawing.Point(1004, 391);
            this.LbProcedureParameters.Name = "LbProcedureParameters";
            this.LbProcedureParameters.Size = new System.Drawing.Size(177, 139);
            this.LbProcedureParameters.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1001, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Procedure parameters";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(385, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Procedure definition";
            // 
            // LbProcedures
            // 
            this.LbProcedures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProcedures.FormattingEnabled = true;
            this.LbProcedures.ItemHeight = 15;
            this.LbProcedures.Location = new System.Drawing.Point(90, 391);
            this.LbProcedures.Name = "LbProcedures";
            this.LbProcedures.Size = new System.Drawing.Size(177, 139);
            this.LbProcedures.TabIndex = 11;
            this.LbProcedures.SelectedIndexChanged += new System.EventHandler(this.LbProcedures_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(87, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Procedures";
            // 
            // TbProcedureDefinition
            // 
            this.TbProcedureDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbProcedureDefinition.Location = new System.Drawing.Point(388, 388);
            this.TbProcedureDefinition.Multiline = true;
            this.TbProcedureDefinition.Name = "TbProcedureDefinition";
            this.TbProcedureDefinition.Size = new System.Drawing.Size(482, 142);
            this.TbProcedureDefinition.TabIndex = 18;
            // 
            // BtnXMLTables
            // 
            this.BtnXMLTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXMLTables.Location = new System.Drawing.Point(273, 202);
            this.BtnXMLTables.Name = "BtnXMLTables";
            this.BtnXMLTables.Size = new System.Drawing.Size(75, 23);
            this.BtnXMLTables.TabIndex = 19;
            this.BtnXMLTables.Text = "XML";
            this.BtnXMLTables.UseVisualStyleBackColor = true;
            this.BtnXMLTables.Click += new System.EventHandler(this.BtnXMLClick);
            // 
            // BtnSelectTables
            // 
            this.BtnSelectTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelectTables.Location = new System.Drawing.Point(273, 231);
            this.BtnSelectTables.Name = "BtnSelectTables";
            this.BtnSelectTables.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectTables.TabIndex = 20;
            this.BtnSelectTables.Text = "SELECT";
            this.BtnSelectTables.UseVisualStyleBackColor = true;
            this.BtnSelectTables.Click += new System.EventHandler(this.BtnSelectClick);
            // 
            // BtnSelectViews
            // 
            this.BtnSelectViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelectViews.Location = new System.Drawing.Point(876, 231);
            this.BtnSelectViews.Name = "BtnSelectViews";
            this.BtnSelectViews.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectViews.TabIndex = 22;
            this.BtnSelectViews.Text = "SELECT";
            this.BtnSelectViews.UseVisualStyleBackColor = true;
            this.BtnSelectViews.Click += new System.EventHandler(this.BtnSelectClick);
            // 
            // BtnXMLViews
            // 
            this.BtnXMLViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXMLViews.Location = new System.Drawing.Point(876, 202);
            this.BtnXMLViews.Name = "BtnXMLViews";
            this.BtnXMLViews.Size = new System.Drawing.Size(75, 23);
            this.BtnXMLViews.TabIndex = 21;
            this.BtnXMLViews.Text = "XML";
            this.BtnXMLViews.UseVisualStyleBackColor = true;
            this.BtnXMLViews.Click += new System.EventHandler(this.BtnXMLClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 614);
            this.Controls.Add(this.BtnSelectViews);
            this.Controls.Add(this.BtnXMLViews);
            this.Controls.Add(this.BtnSelectTables);
            this.Controls.Add(this.BtnXMLTables);
            this.Controls.Add(this.TbProcedureDefinition);
            this.Controls.Add(this.LbProcedureParameters);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LbProcedures);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LbViewColumns);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbViews);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbTableColumns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbTables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbDatabases);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbDatabases;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LbTables;
        private System.Windows.Forms.ListBox LbTableColumns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LbViews;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LbViewColumns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LbProcedureParameters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox LbProcedures;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbProcedureDefinition;
        private System.Windows.Forms.Button BtnXMLTables;
        private System.Windows.Forms.Button BtnSelectTables;
        private System.Windows.Forms.Button BtnSelectViews;
        private System.Windows.Forms.Button BtnXMLViews;
    }
}

