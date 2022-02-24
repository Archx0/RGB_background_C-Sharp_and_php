namespace rrggbb112
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
            this.BtnRgb = new System.Windows.Forms.Button();
            this.inputRR = new System.Windows.Forms.TextBox();
            this.inputR = new System.Windows.Forms.Label();
            this.inputB = new System.Windows.Forms.Label();
            this.RgbNum = new System.Windows.Forms.Label();
            this.inputG = new System.Windows.Forms.Label();
            this.inputBB = new System.Windows.Forms.TextBox();
            this.inputGG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnRgb
            // 
            this.BtnRgb.Location = new System.Drawing.Point(554, 173);
            this.BtnRgb.Name = "BtnRgb";
            this.BtnRgb.Size = new System.Drawing.Size(92, 31);
            this.BtnRgb.TabIndex = 0;
            this.BtnRgb.Text = "RGB !";
            this.BtnRgb.UseVisualStyleBackColor = true;
            this.BtnRgb.Click += new System.EventHandler(this.BtnRgb_Click);
            // 
            // inputRR
            // 
            this.inputRR.Location = new System.Drawing.Point(317, 102);
            this.inputRR.Name = "inputRR";
            this.inputRR.Size = new System.Drawing.Size(141, 20);
            this.inputRR.TabIndex = 1;
            this.inputRR.TabStop = false;
            this.inputRR.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputR
            // 
            this.inputR.AutoSize = true;
            this.inputR.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputR.ForeColor = System.Drawing.Color.Red;
            this.inputR.Location = new System.Drawing.Point(219, 102);
            this.inputR.Name = "inputR";
            this.inputR.Size = new System.Drawing.Size(48, 25);
            this.inputR.TabIndex = 2;
            this.inputR.Text = "Red";
            // 
            // inputB
            // 
            this.inputB.AutoSize = true;
            this.inputB.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputB.ForeColor = System.Drawing.Color.Blue;
            this.inputB.Location = new System.Drawing.Point(219, 266);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(53, 25);
            this.inputB.TabIndex = 3;
            this.inputB.Text = "Blue";
            this.inputB.Click += new System.EventHandler(this.label2_Click);
            // 
            // RgbNum
            // 
            this.RgbNum.AutoSize = true;
            this.RgbNum.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RgbNum.Location = new System.Drawing.Point(249, 369);
            this.RgbNum.Name = "RgbNum";
            this.RgbNum.Size = new System.Drawing.Size(74, 29);
            this.RgbNum.TabIndex = 4;
            this.RgbNum.Text = "RGB :";
            this.RgbNum.Click += new System.EventHandler(this.RgbNum_Click);
            // 
            // inputG
            // 
            this.inputG.AutoSize = true;
            this.inputG.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputG.ForeColor = System.Drawing.Color.Green;
            this.inputG.Location = new System.Drawing.Point(219, 184);
            this.inputG.Name = "inputG";
            this.inputG.Size = new System.Drawing.Size(68, 25);
            this.inputG.TabIndex = 5;
            this.inputG.Text = "Green";
            // 
            // inputBB
            // 
            this.inputBB.Location = new System.Drawing.Point(317, 266);
            this.inputBB.Name = "inputBB";
            this.inputBB.Size = new System.Drawing.Size(141, 20);
            this.inputBB.TabIndex = 6;
            this.inputBB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // inputGG
            // 
            this.inputGG.Location = new System.Drawing.Point(317, 184);
            this.inputGG.Name = "inputGG";
            this.inputGG.Size = new System.Drawing.Size(141, 20);
            this.inputGG.TabIndex = 7;
            this.inputGG.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputGG);
            this.Controls.Add(this.inputBB);
            this.Controls.Add(this.inputG);
            this.Controls.Add(this.RgbNum);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputR);
            this.Controls.Add(this.inputRR);
            this.Controls.Add(this.BtnRgb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRgb;
        private System.Windows.Forms.TextBox inputRR;
        private System.Windows.Forms.Label inputR;
        private System.Windows.Forms.Label inputB;
        private System.Windows.Forms.Label RgbNum;
        private System.Windows.Forms.Label inputG;
        private System.Windows.Forms.TextBox inputBB;
        private System.Windows.Forms.TextBox inputGG;
    }
}

