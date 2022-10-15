namespace Teacher_select
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
            this.pin_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pin_search = new System.Windows.Forms.Button();
            this.contracted_teacher = new System.Windows.Forms.ListBox();
            this.contractless_teacher = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pin_box
            // 
            this.pin_box.Location = new System.Drawing.Point(331, 92);
            this.pin_box.Multiline = true;
            this.pin_box.Name = "pin_box";
            this.pin_box.Size = new System.Drawing.Size(159, 31);
            this.pin_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(282, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "PIN:";
            // 
            // pin_search
            // 
            this.pin_search.Location = new System.Drawing.Point(364, 142);
            this.pin_search.Name = "pin_search";
            this.pin_search.Size = new System.Drawing.Size(75, 23);
            this.pin_search.TabIndex = 2;
            this.pin_search.Text = "Search";
            this.pin_search.UseVisualStyleBackColor = true;
            this.pin_search.Click += new System.EventHandler(this.pin_search_Click);
            // 
            // contracted_teacher
            // 
            this.contracted_teacher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contracted_teacher.FormattingEnabled = true;
            this.contracted_teacher.ItemHeight = 19;
            this.contracted_teacher.Location = new System.Drawing.Point(81, 250);
            this.contracted_teacher.Name = "contracted_teacher";
            this.contracted_teacher.Size = new System.Drawing.Size(653, 23);
            this.contracted_teacher.TabIndex = 3;
            // 
            // contractless_teacher
            // 
            this.contractless_teacher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contractless_teacher.FormattingEnabled = true;
            this.contractless_teacher.ItemHeight = 19;
            this.contractless_teacher.Location = new System.Drawing.Point(81, 370);
            this.contractless_teacher.Name = "contractless_teacher";
            this.contractless_teacher.Size = new System.Drawing.Size(653, 23);
            this.contractless_teacher.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stylus BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(345, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contracted";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stylus BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(331, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Without contract";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contractless_teacher);
            this.Controls.Add(this.contracted_teacher);
            this.Controls.Add(this.pin_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pin_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox pin_box;
        private Label label1;
        private Button pin_search;
        private ListBox contracted_teacher;
        private ListBox contractless_teacher;
        private Label label2;
        private Label label3;
    }
}