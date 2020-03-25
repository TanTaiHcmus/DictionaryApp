namespace Dictionary2
{
    partial class Edit
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.lblsub = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lblword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.Location = new System.Drawing.Point(270, 234);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 37);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(185, 141);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(132, 22);
            this.txtSub.TabIndex = 8;
            // 
            // lblsub
            // 
            this.lblsub.AutoSize = true;
            this.lblsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblsub.Location = new System.Drawing.Point(0, 143);
            this.lblsub.Name = "lblsub";
            this.lblsub.Size = new System.Drawing.Size(153, 20);
            this.lblsub.TabIndex = 7;
            this.lblsub.Text = "&Meaning of word:";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(185, 60);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(132, 22);
            this.txtWord.TabIndex = 6;
            // 
            // lblword
            // 
            this.lblword.AutoSize = true;
            this.lblword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblword.Location = new System.Drawing.Point(12, 60);
            this.lblword.Name = "lblword";
            this.lblword.Size = new System.Drawing.Size(86, 20);
            this.lblword.TabIndex = 5;
            this.lblword.Text = "&Keyword:";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 298);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.lblsub);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lblword);
            this.Name = "Edit";
            this.Text = "Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Edit_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.Label lblsub;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label lblword;
    }
}