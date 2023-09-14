namespace yespad
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
            txtTexte = new RichTextBox();
            label1 = new Label();
            txtNom = new TextBox();
            btnCharger = new Button();
            btnEnregistrer = new Button();
            btnEffacer = new Button();
            btnTerminer = new Button();
            SuspendLayout();
            // 
            // txtTexte
            // 
            txtTexte.Location = new Point(38, 30);
            txtTexte.Margin = new Padding(2, 2, 2, 2);
            txtTexte.Name = "txtTexte";
            txtTexte.Size = new Size(512, 249);
            txtTexte.TabIndex = 0;
            txtTexte.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 326);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Nom du fichier:";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(146, 326);
            txtNom.Margin = new Padding(2, 2, 2, 2);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(209, 23);
            txtNom.TabIndex = 2;
            // 
            // btnCharger
            // 
            btnCharger.Location = new Point(38, 290);
            btnCharger.Margin = new Padding(2, 2, 2, 2);
            btnCharger.Name = "btnCharger";
            btnCharger.Size = new Size(78, 20);
            btnCharger.TabIndex = 3;
            btnCharger.Text = "Charger";
            btnCharger.UseVisualStyleBackColor = true;
            btnCharger.Click += btnCharger_Click;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Location = new Point(130, 290);
            btnEnregistrer.Margin = new Padding(2, 2, 2, 2);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(78, 20);
            btnEnregistrer.TabIndex = 4;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = true;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // btnEffacer
            // 
            btnEffacer.Location = new Point(221, 290);
            btnEffacer.Margin = new Padding(2, 2, 2, 2);
            btnEffacer.Name = "btnEffacer";
            btnEffacer.Size = new Size(78, 20);
            btnEffacer.TabIndex = 5;
            btnEffacer.Text = "Effacer";
            btnEffacer.UseVisualStyleBackColor = true;
            btnEffacer.Click += btnEffacer_Click;
            // 
            // btnTerminer
            // 
            btnTerminer.Location = new Point(470, 290);
            btnTerminer.Margin = new Padding(2, 2, 2, 2);
            btnTerminer.Name = "btnTerminer";
            btnTerminer.Size = new Size(78, 20);
            btnTerminer.TabIndex = 6;
            btnTerminer.Text = "Terminer";
            btnTerminer.UseVisualStyleBackColor = true;
            btnTerminer.Click += btnTerminer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 366);
            Controls.Add(btnTerminer);
            Controls.Add(btnEffacer);
            Controls.Add(btnEnregistrer);
            Controls.Add(btnCharger);
            Controls.Add(txtNom);
            Controls.Add(label1);
            Controls.Add(txtTexte);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtTexte;
        private Label label1;
        private TextBox txtNom;
        private Button btnCharger;
        private Button btnEnregistrer;
        private Button btnEffacer;
        private Button btnTerminer;
    }
}