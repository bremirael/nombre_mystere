namespace nombreMystere
{
    partial class FormProposition
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
            this.propositionBox = new System.Windows.Forms.TextBox();
            this.labelProposition = new System.Windows.Forms.Label();
            this.Jouer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // propositionBox
            // 
            this.propositionBox.Location = new System.Drawing.Point(132, 110);
            this.propositionBox.Name = "propositionBox";
            this.propositionBox.Size = new System.Drawing.Size(118, 20);
            this.propositionBox.TabIndex = 0;
            this.propositionBox.TextChanged += new System.EventHandler(this.propositionBox_TextChanged);
            // 
            // labelProposition
            // 
            this.labelProposition.AutoSize = true;
            this.labelProposition.Location = new System.Drawing.Point(25, 110);
            this.labelProposition.Name = "labelProposition";
            this.labelProposition.Size = new System.Drawing.Size(59, 13);
            this.labelProposition.TabIndex = 1;
            this.labelProposition.Text = "Proposition";
            // 
            // Jouer
            // 
            this.Jouer.Location = new System.Drawing.Point(104, 208);
            this.Jouer.Name = "Jouer";
            this.Jouer.Size = new System.Drawing.Size(75, 23);
            this.Jouer.TabIndex = 2;
            this.Jouer.Text = "Jouer";
            this.Jouer.UseVisualStyleBackColor = true;
            this.Jouer.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Veuillez Choisir un nombre entre 1 et 500";
            // 
            // FormProposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Jouer);
            this.Controls.Add(this.labelProposition);
            this.Controls.Add(this.propositionBox);
            this.Name = "FormProposition";
            this.Text = "Début de la Partie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox propositionBox;
        private System.Windows.Forms.Label labelProposition;
        private System.Windows.Forms.Button Jouer;
        private System.Windows.Forms.Label label1;
    }
}