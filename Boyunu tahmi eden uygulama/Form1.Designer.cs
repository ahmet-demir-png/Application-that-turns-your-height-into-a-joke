
namespace Boyunu_tahmi_eden_uygulama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.anabutton1 = new System.Windows.Forms.Button();
            this.anatext1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // anabutton1
            // 
            this.anabutton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.anabutton1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.anabutton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anabutton1.Location = new System.Drawing.Point(240, 215);
            this.anabutton1.Name = "anabutton1";
            this.anabutton1.Size = new System.Drawing.Size(328, 80);
            this.anabutton1.TabIndex = 0;
            this.anabutton1.Text = "Hazır mısın?";
            this.anabutton1.UseVisualStyleBackColor = false;
            this.anabutton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.anabutton1_MouseClick);
            // 
            // anatext1
            // 
            this.anatext1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.anatext1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.anatext1.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.anatext1.ForeColor = System.Drawing.SystemColors.Window;
            this.anatext1.Location = new System.Drawing.Point(240, 147);
            this.anatext1.Name = "anatext1";
            this.anatext1.Size = new System.Drawing.Size(328, 44);
            this.anatext1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(240, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Boyunuzu yazın örnek(1.80)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anatext1);
            this.Controls.Add(this.anabutton1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Boyunu tahmin edecek inanır mısın?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button anabutton1;
        public System.Windows.Forms.TextBox anatext1;
        private System.Windows.Forms.Label label1;
    }
}

