namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bua = new System.Windows.Forms.RadioButton();
            this.bao = new System.Windows.Forms.RadioButton();
            this.keo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chơi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(425, 324);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(176, 84);
            this.output.TabIndex = 1;
            this.output.Text = "Thoát";
            this.output.UseVisualStyleBackColor = true;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(43, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kết Quả";
            // 
            // bua
            // 
            this.bua.AutoSize = true;
            this.bua.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bua.Location = new System.Drawing.Point(106, 126);
            this.bua.Name = "bua";
            this.bua.Size = new System.Drawing.Size(92, 40);
            this.bua.TabIndex = 3;
            this.bua.TabStop = true;
            this.bua.Text = "Búa";
            this.bua.UseVisualStyleBackColor = true;
            // 
            // bao
            // 
            this.bao.AutoSize = true;
            this.bao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bao.Location = new System.Drawing.Point(298, 126);
            this.bao.Name = "bao";
            this.bao.Size = new System.Drawing.Size(92, 40);
            this.bao.TabIndex = 4;
            this.bao.TabStop = true;
            this.bao.Text = "Bao";
            this.bao.UseVisualStyleBackColor = true;
            // 
            // keo
            // 
            this.keo.AutoSize = true;
            this.keo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keo.Location = new System.Drawing.Point(509, 126);
            this.keo.Name = "keo";
            this.keo.Size = new System.Drawing.Size(92, 40);
            this.keo.TabIndex = 5;
            this.keo.TabStop = true;
            this.keo.Text = "Kéo";
            this.keo.UseVisualStyleBackColor = true;
            this.keo.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.keo);
            this.Controls.Add(this.bao);
            this.Controls.Add(this.bua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton bua;
        private System.Windows.Forms.RadioButton bao;
        private System.Windows.Forms.RadioButton keo;
    }
}

