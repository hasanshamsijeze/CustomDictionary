
namespace CustomDictionary
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
            this.btn_Accept = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Word = new System.Windows.Forms.TextBox();
            this.tb_Discript = new System.Windows.Forms.TextBox();
            this.rb_Add = new System.Windows.Forms.RadioButton();
            this.rb_Search = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Accept
            // 
            this.btn_Accept.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Accept.Location = new System.Drawing.Point(191, 20);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(80, 21);
            this.btn_Accept.TabIndex = 0;
            this.btn_Accept.Text = "Accept";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rb_Search);
            this.groupBox1.Controls.Add(this.btn_Accept);
            this.groupBox1.Controls.Add(this.rb_Add);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 45);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // tb_Word
            // 
            this.tb_Word.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Word.Location = new System.Drawing.Point(68, 63);
            this.tb_Word.Name = "tb_Word";
            this.tb_Word.Size = new System.Drawing.Size(221, 20);
            this.tb_Word.TabIndex = 1;
            this.tb_Word.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Word_KeyDown);
            // 
            // tb_Discript
            // 
            this.tb_Discript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Discript.Location = new System.Drawing.Point(68, 89);
            this.tb_Discript.Multiline = true;
            this.tb_Discript.Name = "tb_Discript";
            this.tb_Discript.ReadOnly = true;
            this.tb_Discript.Size = new System.Drawing.Size(221, 130);
            this.tb_Discript.TabIndex = 2;
            // 
            // rb_Add
            // 
            this.rb_Add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rb_Add.AutoSize = true;
            this.rb_Add.Location = new System.Drawing.Point(74, 22);
            this.rb_Add.Name = "rb_Add";
            this.rb_Add.Size = new System.Drawing.Size(44, 17);
            this.rb_Add.TabIndex = 3;
            this.rb_Add.Text = "Add";
            this.rb_Add.UseVisualStyleBackColor = true;
            this.rb_Add.CheckedChanged += new System.EventHandler(this.rb_Add_CheckedChanged);
            // 
            // rb_Search
            // 
            this.rb_Search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rb_Search.AutoSize = true;
            this.rb_Search.Checked = true;
            this.rb_Search.Location = new System.Drawing.Point(6, 22);
            this.rb_Search.Name = "rb_Search";
            this.rb_Search.Size = new System.Drawing.Size(62, 17);
            this.rb_Search.TabIndex = 3;
            this.rb_Search.TabStop = true;
            this.rb_Search.Text = "Search ";
            this.rb_Search.UseVisualStyleBackColor = true;
            this.rb_Search.CheckedChanged += new System.EventHandler(this.rb_Search_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Discript:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Word:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 231);
            this.Controls.Add(this.tb_Discript);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Word);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(317, 270);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Search;
        private System.Windows.Forms.RadioButton rb_Add;
        private System.Windows.Forms.TextBox tb_Word;
        private System.Windows.Forms.TextBox tb_Discript;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

