namespace TheClosestWay
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.lblWay = new System.Windows.Forms.Label();
            this.lblClosestWay = new System.Windows.Forms.Label();
            this.lblF2 = new System.Windows.Forms.Label();
            this.btnCal2 = new System.Windows.Forms.Button();
            this.lblClosestWay2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kat1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(543, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kat2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1027, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Noktası:";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(1135, 48);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(0, 13);
            this.lblS.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1027, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bitiş Noktası:";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(1135, 75);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(0, 13);
            this.lblF.TabIndex = 3;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(1030, 103);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(92, 26);
            this.btnCal.TabIndex = 4;
            this.btnCal.Text = "Yolu Hesabla";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(1030, 259);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(92, 26);
            this.btnClr.TabIndex = 4;
            this.btnClr.Text = "Verileri Sıfırla";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // lblWay
            // 
            this.lblWay.AutoSize = true;
            this.lblWay.Location = new System.Drawing.Point(1030, 136);
            this.lblWay.Name = "lblWay";
            this.lblWay.Size = new System.Drawing.Size(64, 13);
            this.lblWay.TabIndex = 5;
            this.lblWay.Text = "En Kısa Yol:";
            // 
            // lblClosestWay
            // 
            this.lblClosestWay.AutoSize = true;
            this.lblClosestWay.Location = new System.Drawing.Point(1030, 159);
            this.lblClosestWay.Name = "lblClosestWay";
            this.lblClosestWay.Size = new System.Drawing.Size(0, 13);
            this.lblClosestWay.TabIndex = 6;
            // 
            // lblF2
            // 
            this.lblF2.AutoSize = true;
            this.lblF2.Location = new System.Drawing.Point(1122, 75);
            this.lblF2.Name = "lblF2";
            this.lblF2.Size = new System.Drawing.Size(0, 13);
            this.lblF2.TabIndex = 9;
            // 
            // btnCal2
            // 
            this.btnCal2.Location = new System.Drawing.Point(1128, 103);
            this.btnCal2.Name = "btnCal2";
            this.btnCal2.Size = new System.Drawing.Size(92, 26);
            this.btnCal2.TabIndex = 10;
            this.btnCal2.Text = "Alternatif Yolu Hesabla";
            this.btnCal2.UseVisualStyleBackColor = true;
            this.btnCal2.Click += new System.EventHandler(this.btnCal2_Click);
            // 
            // lblClosestWay2
            // 
            this.lblClosestWay2.AutoSize = true;
            this.lblClosestWay2.Location = new System.Drawing.Point(1031, 208);
            this.lblClosestWay2.Name = "lblClosestWay2";
            this.lblClosestWay2.Size = new System.Drawing.Size(0, 13);
            this.lblClosestWay2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1031, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Alternatif En Kısa Yol: (Her zaman  farklı olmaya bilir!)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.lblClosestWay2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCal2);
            this.Controls.Add(this.lblF2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClosestWay);
            this.Controls.Add(this.lblWay);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Label lblWay;
        private System.Windows.Forms.Label lblClosestWay;
        private System.Windows.Forms.Label lblF2;
        private System.Windows.Forms.Button btnCal2;
        private System.Windows.Forms.Label lblClosestWay2;
        private System.Windows.Forms.Label label6;
    }
}

