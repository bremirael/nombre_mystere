namespace nombreMystere
{
    partial class FormIdentification
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
            this.label1 = new System.Windows.Forms.Label();
            this.nomIdBox = new System.Windows.Forms.TextBox();
            this.loginIdBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.NomLabel = new System.Windows.Forms.Label();
            this.JouerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDENTIFICATION";
            // 
            // nomIdBox
            // 
            this.nomIdBox.Location = new System.Drawing.Point(112, 89);
            this.nomIdBox.Name = "nomIdBox";
            this.nomIdBox.Size = new System.Drawing.Size(160, 20);
            this.nomIdBox.TabIndex = 1;
            // 
            // loginIdBox
            // 
            this.loginIdBox.Location = new System.Drawing.Point(112, 159);
            this.loginIdBox.Name = "loginIdBox";
            this.loginIdBox.Size = new System.Drawing.Size(160, 20);
            this.loginIdBox.TabIndex = 2;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(12, 162);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Login";
            // 
            // NomLabel
            // 
            this.NomLabel.AutoSize = true;
            this.NomLabel.Location = new System.Drawing.Point(12, 92);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(29, 13);
            this.NomLabel.TabIndex = 4;
            this.NomLabel.Text = "Nom";
            // 
            // JouerBtn
            // 
            this.JouerBtn.Location = new System.Drawing.Point(112, 214);
            this.JouerBtn.Name = "JouerBtn";
            this.JouerBtn.Size = new System.Drawing.Size(75, 23);
            this.JouerBtn.TabIndex = 5;
            this.JouerBtn.Text = "Jouer";
            this.JouerBtn.UseVisualStyleBackColor = true;
            this.JouerBtn.Click += new System.EventHandler(this.JouerBtn_Click);
            // 
            // FormIdentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.JouerBtn);
            this.Controls.Add(this.NomLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginIdBox);
            this.Controls.Add(this.nomIdBox);
            this.Controls.Add(this.label1);
            this.Name = "FormIdentification";
            this.Text = "Identification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomIdBox;
        private System.Windows.Forms.TextBox loginIdBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label NomLabel;
        private System.Windows.Forms.Button JouerBtn;
    }
}