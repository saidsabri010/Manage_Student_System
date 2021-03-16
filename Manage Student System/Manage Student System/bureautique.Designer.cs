
namespace Manage_Student_System
{
    partial class bureautique
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
            this.ft = new System.Windows.Forms.Button();
            this.sd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ft
            // 
            this.ft.Location = new System.Drawing.Point(143, 285);
            this.ft.Name = "ft";
            this.ft.Size = new System.Drawing.Size(88, 31);
            this.ft.TabIndex = 0;
            this.ft.Text = "3 months";
            this.ft.UseVisualStyleBackColor = true;
            this.ft.Click += new System.EventHandler(this.ft_Click);
            // 
            // sd
            // 
            this.sd.Location = new System.Drawing.Point(336, 285);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(90, 31);
            this.sd.TabIndex = 0;
            this.sd.Text = "6 months";
            this.sd.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(551, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 31);
            this.button3.TabIndex = 1;
            this.button3.Text = "9 months";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.SpringGreen;
            this.back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.back.Location = new System.Drawing.Point(658, 396);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(91, 33);
            this.back.TabIndex = 2;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(523, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bureautique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.sd);
            this.Controls.Add(this.ft);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "bureautique";
            this.Text = "bureautique";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ft;
        private System.Windows.Forms.Button sd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button1;
    }
}