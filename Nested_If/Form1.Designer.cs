namespace Nested_If
{
    partial class frmNested
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblNested = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblOpen = new System.Windows.Forms.Label();
            this.lblFirstMessageBox = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblSecondMessageBox = new System.Windows.Forms.Label();
            this.lblElse = new System.Windows.Forms.Label();
            this.lblOpen2 = new System.Windows.Forms.Label();
            this.lblClose2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbQuestion = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlContainer.SuspendLayout();
            this.gbQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.btnExit);
            this.pnlContainer.Controls.Add(this.gbQuestion);
            this.pnlContainer.Controls.Add(this.btnClear);
            this.pnlContainer.Controls.Add(this.btnExecute);
            this.pnlContainer.Controls.Add(this.txtTemp);
            this.pnlContainer.Controls.Add(this.lblTemp);
            this.pnlContainer.Location = new System.Drawing.Point(12, 12);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(561, 325);
            this.pnlContainer.TabIndex = 0;
            // 
            // lblNested
            // 
            this.lblNested.AutoSize = true;
            this.lblNested.Location = new System.Drawing.Point(23, 37);
            this.lblNested.Name = "lblNested";
            this.lblNested.Size = new System.Drawing.Size(123, 18);
            this.lblNested.TabIndex = 0;
            this.lblNested.Text = "if(lblTemp <= 15)";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(73, 28);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(195, 18);
            this.lblTemp.TabIndex = 4;
            this.lblTemp.Text = "Enter temperature answer: ";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(274, 25);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 26);
            this.txtTemp.TabIndex = 5;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(396, 103);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(138, 47);
            this.btnExecute.TabIndex = 6;
            this.btnExecute.Text = "&Display Message";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Location = new System.Drawing.Point(23, 65);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(13, 18);
            this.lblOpen.TabIndex = 7;
            this.lblOpen.Text = "{";
            // 
            // lblFirstMessageBox
            // 
            this.lblFirstMessageBox.AutoSize = true;
            this.lblFirstMessageBox.Location = new System.Drawing.Point(44, 96);
            this.lblFirstMessageBox.Name = "lblFirstMessageBox";
            this.lblFirstMessageBox.Size = new System.Drawing.Size(316, 18);
            this.lblFirstMessageBox.TabIndex = 8;
            this.lblFirstMessageBox.Text = "MessageBox.Show(\"It\'s cold, wear a jacket\")";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Location = new System.Drawing.Point(23, 127);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(13, 18);
            this.lblClose.TabIndex = 9;
            this.lblClose.Text = "}";
            // 
            // lblSecondMessageBox
            // 
            this.lblSecondMessageBox.AutoSize = true;
            this.lblSecondMessageBox.Location = new System.Drawing.Point(44, 189);
            this.lblSecondMessageBox.Name = "lblSecondMessageBox";
            this.lblSecondMessageBox.Size = new System.Drawing.Size(225, 18);
            this.lblSecondMessageBox.TabIndex = 10;
            this.lblSecondMessageBox.Text = "MessageBox.Show(\"It\'s warm\")";
            // 
            // lblElse
            // 
            this.lblElse.AutoSize = true;
            this.lblElse.Location = new System.Drawing.Point(23, 150);
            this.lblElse.Name = "lblElse";
            this.lblElse.Size = new System.Drawing.Size(37, 18);
            this.lblElse.TabIndex = 11;
            this.lblElse.Text = "else";
            // 
            // lblOpen2
            // 
            this.lblOpen2.AutoSize = true;
            this.lblOpen2.Location = new System.Drawing.Point(23, 168);
            this.lblOpen2.Name = "lblOpen2";
            this.lblOpen2.Size = new System.Drawing.Size(13, 18);
            this.lblOpen2.TabIndex = 12;
            this.lblOpen2.Text = "{";
            // 
            // lblClose2
            // 
            this.lblClose2.AutoSize = true;
            this.lblClose2.Location = new System.Drawing.Point(23, 213);
            this.lblClose2.Name = "lblClose2";
            this.lblClose2.Size = new System.Drawing.Size(13, 18);
            this.lblClose2.TabIndex = 13;
            this.lblClose2.Text = "}";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(396, 179);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 47);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "&Reset";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbQuestion
            // 
            this.gbQuestion.BackColor = System.Drawing.Color.DimGray;
            this.gbQuestion.Controls.Add(this.lblNested);
            this.gbQuestion.Controls.Add(this.lblClose2);
            this.gbQuestion.Controls.Add(this.lblOpen);
            this.gbQuestion.Controls.Add(this.lblOpen2);
            this.gbQuestion.Controls.Add(this.lblFirstMessageBox);
            this.gbQuestion.Controls.Add(this.lblElse);
            this.gbQuestion.Controls.Add(this.lblClose);
            this.gbQuestion.Controls.Add(this.lblSecondMessageBox);
            this.gbQuestion.Location = new System.Drawing.Point(9, 67);
            this.gbQuestion.Name = "gbQuestion";
            this.gbQuestion.Size = new System.Drawing.Size(367, 246);
            this.gbQuestion.TabIndex = 15;
            this.gbQuestion.TabStop = false;
            this.gbQuestion.Text = "How the temperature will be evaluated:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(396, 251);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 47);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "&Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmNested
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 348);
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNested";
            this.Text = "Nested if";
            this.Load += new System.EventHandler(this.frmNested_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.gbQuestion.ResumeLayout(false);
            this.gbQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.GroupBox gbQuestion;
        private System.Windows.Forms.Label lblNested;
        private System.Windows.Forms.Label lblClose2;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.Label lblOpen2;
        private System.Windows.Forms.Label lblFirstMessageBox;
        private System.Windows.Forms.Label lblElse;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblSecondMessageBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Button btnExit;
    }
}

