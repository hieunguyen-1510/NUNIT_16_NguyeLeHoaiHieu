namespace _16_NguyenLeHoaiHieu_SoNguyenTo
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
            this.txta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.btngiai = new System.Windows.Forms.Button();
            this.btnlamlai = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(233, 68);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(195, 22);
            this.txta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết quả";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(233, 110);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(195, 22);
            this.txtkq.TabIndex = 3;
            // 
            // btngiai
            // 
            this.btngiai.Location = new System.Drawing.Point(124, 180);
            this.btngiai.Name = "btngiai";
            this.btngiai.Size = new System.Drawing.Size(75, 23);
            this.btngiai.TabIndex = 4;
            this.btngiai.Text = "Giải";
            this.btngiai.UseVisualStyleBackColor = true;
            this.btngiai.Click += new System.EventHandler(this.btngiai_Click);
            // 
            // btnlamlai
            // 
            this.btnlamlai.Location = new System.Drawing.Point(233, 180);
            this.btnlamlai.Name = "btnlamlai";
            this.btnlamlai.Size = new System.Drawing.Size(75, 23);
            this.btnlamlai.TabIndex = 5;
            this.btnlamlai.Text = "Làm lại ";
            this.btnlamlai.UseVisualStyleBackColor = true;
            this.btnlamlai.Click += new System.EventHandler(this.btnlamlai_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(353, 180);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnlamlai);
            this.Controls.Add(this.btngiai);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button btngiai;
        private System.Windows.Forms.Button btnlamlai;
        private System.Windows.Forms.Button btnthoat;
    }
}

