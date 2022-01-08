namespace form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Button_1 = new System.Windows.Forms.Button();
            this.show_color = new System.Windows.Forms.Button();
            this.connButton = new System.Windows.Forms.Button();
            this.disconn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(244, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Button_1
            // 
            this.Button_1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Button_1.Location = new System.Drawing.Point(259, 215);
            this.Button_1.Name = "Button_1";
            this.Button_1.Size = new System.Drawing.Size(94, 29);
            this.Button_1.TabIndex = 1;
            this.Button_1.Text = "show";
            this.Button_1.UseVisualStyleBackColor = false;
            this.Button_1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // show_color
            // 
            this.show_color.Location = new System.Drawing.Point(259, 283);
            this.show_color.Name = "show_color";
            this.show_color.Size = new System.Drawing.Size(94, 29);
            this.show_color.TabIndex = 2;
            this.show_color.Text = "show color";
            this.show_color.UseVisualStyleBackColor = true;
            this.show_color.Click += new System.EventHandler(this.show_color_Click);
            // 
            // connButton
            // 
            this.connButton.ForeColor = System.Drawing.Color.OliveDrab;
            this.connButton.Location = new System.Drawing.Point(597, 144);
            this.connButton.Name = "connButton";
            this.connButton.Size = new System.Drawing.Size(94, 29);
            this.connButton.TabIndex = 3;
            this.connButton.Text = "conn";
            this.connButton.UseVisualStyleBackColor = true;
            this.connButton.Click += new System.EventHandler(this.connButton_Click);
            // 
            // disconn
            // 
            this.disconn.BackColor = System.Drawing.SystemColors.Highlight;
            this.disconn.ForeColor = System.Drawing.Color.Snow;
            this.disconn.Location = new System.Drawing.Point(597, 201);
            this.disconn.Name = "disconn";
            this.disconn.Size = new System.Drawing.Size(94, 29);
            this.disconn.TabIndex = 4;
            this.disconn.Text = "disconn";
            this.disconn.UseVisualStyleBackColor = false;
            this.disconn.Click += new System.EventHandler(this.disconn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.disconn);
            this.Controls.Add(this.connButton);
            this.Controls.Add(this.show_color);
            this.Controls.Add(this.Button_1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button Button_1;
        private Button show_color;
        private Button connButton;
        private Button disconn;
    }
}