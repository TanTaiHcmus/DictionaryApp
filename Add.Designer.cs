namespace Dictionary2
{
    partial class Add
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
            this.lblword = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lblsub = new System.Windows.Forms.Label();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblword
            // 
            this.lblword.AutoSize = true;
            this.lblword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblword.Location = new System.Drawing.Point(12, 69);
            this.lblword.Name = "lblword";
            this.lblword.Size = new System.Drawing.Size(86, 20);
            this.lblword.TabIndex = 0;
            this.lblword.Text = "&Keyword:";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(173, 67);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(145, 22);
            this.txtWord.TabIndex = 1;
            // 
            // lblsub
            // 
            this.lblsub.AutoSize = true;
            this.lblsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblsub.Location = new System.Drawing.Point(0, 153);
            this.lblsub.Name = "lblsub";
            this.lblsub.Size = new System.Drawing.Size(153, 20);
            this.lblsub.TabIndex = 2;
            this.lblsub.Text = "&Meaning of word:";
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(173, 151);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(145, 22);
            this.txtSub.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(249, 254);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 37);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 312);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.lblsub);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lblword);
            this.Name = "Add";
            this.Text = "Add";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblword;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label lblsub;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.Button btnAdd;
    }
}