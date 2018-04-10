namespace BaiMang20_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtSelec = new System.Windows.Forms.TextBox();
            this.btnKeo = new System.Windows.Forms.Button();
            this.btnBua = new System.Windows.Forms.Button();
            this.btnBao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Selection:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Result:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(178, 299);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(233, 22);
            this.txtResult.TabIndex = 2;
            // 
            // txtSelec
            // 
            this.txtSelec.Location = new System.Drawing.Point(178, 97);
            this.txtSelec.Name = "txtSelec";
            this.txtSelec.Size = new System.Drawing.Size(233, 22);
            this.txtSelec.TabIndex = 3;
            // 
            // btnKeo
            // 
            this.btnKeo.Location = new System.Drawing.Point(42, 171);
            this.btnKeo.Name = "btnKeo";
            this.btnKeo.Size = new System.Drawing.Size(101, 84);
            this.btnKeo.TabIndex = 4;
            this.btnKeo.Text = "Kéo";
            this.btnKeo.UseVisualStyleBackColor = true;
            this.btnKeo.Click += new System.EventHandler(this.btnKeo_Click);
            // 
            // btnBua
            // 
            this.btnBua.Location = new System.Drawing.Point(178, 171);
            this.btnBua.Name = "btnBua";
            this.btnBua.Size = new System.Drawing.Size(101, 84);
            this.btnBua.TabIndex = 5;
            this.btnBua.Text = "Búa";
            this.btnBua.UseVisualStyleBackColor = true;
            this.btnBua.Click += new System.EventHandler(this.btnBua_Click);
            // 
            // btnBao
            // 
            this.btnBao.Location = new System.Drawing.Point(310, 171);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(101, 84);
            this.btnBao.TabIndex = 6;
            this.btnBao.Text = "Bao";
            this.btnBao.UseVisualStyleBackColor = true;
            this.btnBao.Click += new System.EventHandler(this.btnBao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 416);
            this.Controls.Add(this.btnBao);
            this.Controls.Add(this.btnBua);
            this.Controls.Add(this.btnKeo);
            this.Controls.Add(this.txtSelec);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtSelec;
        private System.Windows.Forms.Button btnKeo;
        private System.Windows.Forms.Button btnBua;
        private System.Windows.Forms.Button btnBao;
    }
}

