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
            this.lookfor = new System.Windows.Forms.TextBox();
            this.lookforInBD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultView = new System.Windows.Forms.DataGridView();
            this.newData = new System.Windows.Forms.Button();
            this.colorname = new System.Windows.Forms.TextBox();
            this.colorcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Button_1
            // 
            this.Button_1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Button_1.Location = new System.Drawing.Point(35, 103);
            this.Button_1.Name = "Button_1";
            this.Button_1.Size = new System.Drawing.Size(94, 29);
            this.Button_1.TabIndex = 1;
            this.Button_1.Text = "show";
            this.Button_1.UseVisualStyleBackColor = false;
            this.Button_1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // show_color
            // 
            this.show_color.Location = new System.Drawing.Point(35, 157);
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
            this.connButton.Location = new System.Drawing.Point(253, 57);
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
            this.disconn.Location = new System.Drawing.Point(253, 114);
            this.disconn.Name = "disconn";
            this.disconn.Size = new System.Drawing.Size(94, 29);
            this.disconn.TabIndex = 4;
            this.disconn.Text = "disconn";
            this.disconn.UseVisualStyleBackColor = false;
            this.disconn.Click += new System.EventHandler(this.disconn_Click);
            // 
            // lookfor
            // 
            this.lookfor.Location = new System.Drawing.Point(253, 263);
            this.lookfor.Name = "lookfor";
            this.lookfor.Size = new System.Drawing.Size(94, 27);
            this.lookfor.TabIndex = 5;
            // 
            // lookforInBD
            // 
            this.lookforInBD.BackColor = System.Drawing.SystemColors.Info;
            this.lookforInBD.Location = new System.Drawing.Point(253, 178);
            this.lookforInBD.Name = "lookforInBD";
            this.lookforInBD.Size = new System.Drawing.Size(94, 27);
            this.lookforInBD.TabIndex = 6;
            this.lookforInBD.Text = "lookforInBD";
            this.lookforInBD.UseVisualStyleBackColor = false;
            this.lookforInBD.Click += new System.EventHandler(this.lookforInBD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "what are you looking for?";
            // 
            // resultView
            // 
            this.resultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultView.Location = new System.Drawing.Point(154, 329);
            this.resultView.Name = "resultView";
            this.resultView.RowHeadersWidth = 51;
            this.resultView.RowTemplate.Height = 29;
            this.resultView.Size = new System.Drawing.Size(300, 188);
            this.resultView.TabIndex = 8;
            // 
            // newData
            // 
            this.newData.Location = new System.Drawing.Point(641, 238);
            this.newData.Name = "newData";
            this.newData.Size = new System.Drawing.Size(94, 29);
            this.newData.TabIndex = 9;
            this.newData.Text = "new color";
            this.newData.UseVisualStyleBackColor = true;
            this.newData.Click += new System.EventHandler(this.newData_Click);
            // 
            // colorname
            // 
            this.colorname.Location = new System.Drawing.Point(640, 116);
            this.colorname.Name = "colorname";
            this.colorname.Size = new System.Drawing.Size(125, 27);
            this.colorname.TabIndex = 10;
            // 
            // colorcode
            // 
            this.colorcode.Location = new System.Drawing.Point(641, 182);
            this.colorcode.Name = "colorcode";
            this.colorcode.Size = new System.Drawing.Size(125, 27);
            this.colorcode.TabIndex = 11;
            this.colorcode.TextChanged += new System.EventHandler(this.colorcode_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hex Code:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(640, 300);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(171, 29);
            this.delete.TabIndex = 14;
            this.delete.Text = "delete where name";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(641, 359);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(170, 29);
            this.update.TabIndex = 15;
            this.update.Text = "update where name";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 543);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colorcode);
            this.Controls.Add(this.colorname);
            this.Controls.Add(this.newData);
            this.Controls.Add(this.resultView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lookforInBD);
            this.Controls.Add(this.lookfor);
            this.Controls.Add(this.disconn);
            this.Controls.Add(this.connButton);
            this.Controls.Add(this.show_color);
            this.Controls.Add(this.Button_1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button Button_1;
        private Button show_color;
        private Button connButton;
        private Button disconn;
        private TextBox lookfor;
        private Button lookforInBD;
        private Label label2;
        private DataGridView resultView;
        private Button newData;
        private TextBox colorname;
        private TextBox colorcode;
        private Label label3;
        private Label label4;
        private Button delete;
        private Button update;
    }
}