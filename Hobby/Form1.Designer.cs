namespace Hobby
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bulgaria", "Italy", "Germany" });
            comboBox1.Location = new Point(37, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(262, 32);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 76);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 2;
            label1.Text = "Countries";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 81);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 3;
            label2.Text = "Cities";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(513, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(169, 215);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(733, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(169, 188);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(8, 35);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Reading";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(7, 76);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(122, 29);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Swimming";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(3, 110);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(96, 29);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Coding";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(3, 144);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(120, 29);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Gardening";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(2, 178);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(142, 29);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Photography";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 524);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox2;
        private CheckBox checkBox5;
    }
}