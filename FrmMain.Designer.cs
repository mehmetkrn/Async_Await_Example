namespace Async_Await_Example
{
    partial class FrmMain
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
            this.BtnKahve = new System.Windows.Forms.Button();
            this.BtnCay = new System.Windows.Forms.Button();
            this.Lst = new System.Windows.Forms.ListBox();
            this.BtnHazirla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnKahve
            // 
            this.BtnKahve.Location = new System.Drawing.Point(590, 12);
            this.BtnKahve.Name = "BtnKahve";
            this.BtnKahve.Size = new System.Drawing.Size(210, 52);
            this.BtnKahve.TabIndex = 0;
            this.BtnKahve.Text = "Kahve";
            this.BtnKahve.UseVisualStyleBackColor = true;
            // 
            // BtnCay
            // 
            this.BtnCay.Location = new System.Drawing.Point(350, 12);
            this.BtnCay.Name = "BtnCay";
            this.BtnCay.Size = new System.Drawing.Size(210, 52);
            this.BtnCay.TabIndex = 1;
            this.BtnCay.Text = "Çay";
            this.BtnCay.UseVisualStyleBackColor = true;
            // 
            // Lst
            // 
            this.Lst.FormattingEnabled = true;
            this.Lst.Location = new System.Drawing.Point(350, 72);
            this.Lst.Name = "Lst";
            this.Lst.Size = new System.Drawing.Size(450, 368);
            this.Lst.TabIndex = 3;
            // 
            // BtnHazirla
            // 
            this.BtnHazirla.Location = new System.Drawing.Point(12, 15);
            this.BtnHazirla.Name = "BtnHazirla";
            this.BtnHazirla.Size = new System.Drawing.Size(146, 51);
            this.BtnHazirla.TabIndex = 4;
            this.BtnHazirla.Text = "Hazırla";
            this.BtnHazirla.UseVisualStyleBackColor = true;
            this.BtnHazirla.Click += new System.EventHandler(this.BtnHazirla_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.BtnHazirla);
            this.Controls.Add(this.Lst);
            this.Controls.Add(this.BtnCay);
            this.Controls.Add(this.BtnKahve);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKahve;
        private System.Windows.Forms.Button BtnCay;
        private System.Windows.Forms.ListBox Lst;
        private System.Windows.Forms.Button BtnHazirla;
    }
}

