namespace BMI計算機_1131437_藍奕
{
    partial class frmBMI
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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.lblIdealWeight0 = new System.Windows.Forms.Label();
            this.lblIdealWeight = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.btnRun);
            this.grpInput.Controls.Add(this.txtWeight);
            this.grpInput.Controls.Add(this.txtHeight);
            this.grpInput.Controls.Add(this.lblWeight);
            this.grpInput.Controls.Add(this.lblHeight);
            this.grpInput.ForeColor = System.Drawing.Color.Black;
            this.grpInput.Location = new System.Drawing.Point(13, 13);
            this.grpInput.Margin = new System.Windows.Forms.Padding(4);
            this.grpInput.Name = "grpInput";
            this.grpInput.Padding = new System.Windows.Forms.Padding(4);
            this.grpInput.Size = new System.Drawing.Size(365, 89);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "輸入";
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Location = new System.Drawing.Point(225, 25);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(62, 56);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "計算";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.calculate_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeight.Location = new System.Drawing.Point(88, 56);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(131, 25);
            this.txtWeight.TabIndex = 1;
            // 
            // txtHeight
            // 
            this.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeight.Location = new System.Drawing.Point(88, 25);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(131, 25);
            this.txtHeight.TabIndex = 0;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.ForeColor = System.Drawing.Color.Black;
            this.lblWeight.Location = new System.Drawing.Point(22, 58);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(57, 17);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "體重(kg)";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.ForeColor = System.Drawing.Color.Black;
            this.lblHeight.Location = new System.Drawing.Point(22, 31);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(60, 17);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "身高(cm)";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lblIdealWeight);
            this.grpOutput.Controls.Add(this.lblIdealWeight0);
            this.grpOutput.Controls.Add(this.lblResult);
            this.grpOutput.Controls.Add(this.lblBMI);
            this.grpOutput.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpOutput.ForeColor = System.Drawing.Color.Black;
            this.grpOutput.Location = new System.Drawing.Point(12, 110);
            this.grpOutput.Margin = new System.Windows.Forms.Padding(4);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Padding = new System.Windows.Forms.Padding(4);
            this.grpOutput.Size = new System.Drawing.Size(366, 74);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "輸出";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(148, 20);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(208, 19);
            this.lblResult.TabIndex = 1;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.ForeColor = System.Drawing.Color.Black;
            this.lblBMI.Location = new System.Drawing.Point(23, 22);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(119, 17);
            this.lblBMI.TabIndex = 0;
            this.lblBMI.Text = "身體質量指數(BMI)";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(306, 38);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 56);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BMI計算機_1131437_藍奕.Properties.Resources.bmi2;
            this.pictureBox1.Location = new System.Drawing.Point(384, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 17;
            this.lstHistory.Location = new System.Drawing.Point(12, 191);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(366, 72);
            this.lstHistory.TabIndex = 0;
            this.lstHistory.TabStop = false;
            // 
            // lblIdealWeight0
            // 
            this.lblIdealWeight0.Location = new System.Drawing.Point(23, 47);
            this.lblIdealWeight0.Name = "lblIdealWeight0";
            this.lblIdealWeight0.Size = new System.Drawing.Size(119, 16);
            this.lblIdealWeight0.TabIndex = 8;
            this.lblIdealWeight0.Text = "理想體重範圍";
            // 
            // lblIdealWeight
            // 
            this.lblIdealWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdealWeight.Location = new System.Drawing.Point(148, 46);
            this.lblIdealWeight.Name = "lblIdealWeight";
            this.lblIdealWeight.Size = new System.Drawing.Size(208, 19);
            this.lblIdealWeight.TabIndex = 9;
            this.lblIdealWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBMI
            // 
            this.AcceptButton = this.btnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(769, 271);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI計算機";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Label lblIdealWeight0;
        private System.Windows.Forms.Label lblIdealWeight;
    }
}

