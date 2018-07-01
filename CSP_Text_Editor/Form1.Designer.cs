namespace CSP_Text_Editor
{
    partial class frmEditor
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
            this.tboxCode = new System.Windows.Forms.RichTextBox();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblcolumns = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNums = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxCode
            // 
            this.tboxCode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCode.Location = new System.Drawing.Point(44, 0);
            this.tboxCode.Name = "tboxCode";
            this.tboxCode.Size = new System.Drawing.Size(598, 462);
            this.tboxCode.TabIndex = 0;
            this.tboxCode.Text = "";
            this.tboxCode.VScroll += new System.EventHandler(this.tboxCode_VScroll);
            this.tboxCode.TextChanged += new System.EventHandler(this.tboxCode_TextChanged);
            this.tboxCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxCode_KeyDown);
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(56, 476);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(35, 13);
            this.lblRows.TabIndex = 1;
            this.lblRows.Text = "label1";
            // 
            // lblcolumns
            // 
            this.lblcolumns.AutoSize = true;
            this.lblcolumns.Location = new System.Drawing.Point(236, 476);
            this.lblcolumns.Name = "lblcolumns";
            this.lblcolumns.Size = new System.Drawing.Size(35, 13);
            this.lblcolumns.TabIndex = 2;
            this.lblcolumns.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Column:";
            // 
            // lblNums
            // 
            this.lblNums.BackColor = System.Drawing.Color.GreenYellow;
            this.lblNums.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNums.Location = new System.Drawing.Point(0, 0);
            this.lblNums.Name = "lblNums";
            this.lblNums.Size = new System.Drawing.Size(45, 458);
            this.lblNums.TabIndex = 5;
            this.lblNums.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9\r\n10\r\n11\r\n12";
            this.lblNums.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Line:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Controls.Add(this.lblNums);
            this.panel1.Controls.Add(this.tboxCode);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 461);
            this.panel1.TabIndex = 7;
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcolumns);
            this.Controls.Add(this.lblRows);
            this.Name = "frmEditor";
            this.Text = "Editor";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tboxCode;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblcolumns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNums;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}

