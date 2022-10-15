namespace Student_check_App
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
            this.id_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.search_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(304, 163);
            this.id_box.Multiline = true;
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(161, 30);
            this.id_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // search_result
            // 
            this.search_result.Location = new System.Drawing.Point(169, 318);
            this.search_result.Name = "search_result";
            this.search_result.Size = new System.Drawing.Size(400, 23);
            this.search_result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.search_result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox id_box;
        private Label label1;
        private Button button1;
        private TextBox search_result;
    }
}