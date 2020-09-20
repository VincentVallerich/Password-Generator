namespace PasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Result_txt = new System.Windows.Forms.RichTextBox();
            this.Copy_bttn = new System.Windows.Forms.Button();
            this.Generate_bttn = new System.Windows.Forms.Button();
            this.Upper_chk = new System.Windows.Forms.CheckBox();
            this.Lower_chk = new System.Windows.Forms.CheckBox();
            this.Number_chk = new System.Windows.Forms.CheckBox();
            this.Special_chk = new System.Windows.Forms.CheckBox();
            this.Lenght_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Error_Label = new System.Windows.Forms.Label();
            this.Copy_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Result_txt
            // 
            this.Result_txt.Location = new System.Drawing.Point(45, 36);
            this.Result_txt.Name = "Result_txt";
            this.Result_txt.ReadOnly = true;
            this.Result_txt.Size = new System.Drawing.Size(259, 27);
            this.Result_txt.TabIndex = 0;
            this.Result_txt.Text = "";
            this.Result_txt.Visible = false;
            // 
            // Copy_bttn
            // 
            this.Copy_bttn.Location = new System.Drawing.Point(310, 21);
            this.Copy_bttn.Name = "Copy_bttn";
            this.Copy_bttn.Size = new System.Drawing.Size(63, 53);
            this.Copy_bttn.TabIndex = 1;
            this.Copy_bttn.Text = "Copy";
            this.Copy_bttn.UseVisualStyleBackColor = true;
            this.Copy_bttn.Click += new System.EventHandler(this.Copy_bttn_Click);
            // 
            // Generate_bttn
            // 
            this.Generate_bttn.Location = new System.Drawing.Point(45, 261);
            this.Generate_bttn.Name = "Generate_bttn";
            this.Generate_bttn.Size = new System.Drawing.Size(329, 68);
            this.Generate_bttn.TabIndex = 2;
            this.Generate_bttn.Text = "Generate";
            this.Generate_bttn.UseVisualStyleBackColor = true;
            this.Generate_bttn.Click += new System.EventHandler(this.Generate_bttn_Click);
            // 
            // Upper_chk
            // 
            this.Upper_chk.AutoSize = true;
            this.Upper_chk.Checked = true;
            this.Upper_chk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Upper_chk.Location = new System.Drawing.Point(150, 134);
            this.Upper_chk.Name = "Upper_chk";
            this.Upper_chk.Size = new System.Drawing.Size(112, 21);
            this.Upper_chk.TabIndex = 3;
            this.Upper_chk.Text = "Upper letters";
            this.Upper_chk.UseVisualStyleBackColor = true;
            this.Upper_chk.CheckedChanged += new System.EventHandler(this.Upper_chk_CheckedChanged);
            // 
            // Lower_chk
            // 
            this.Lower_chk.AutoSize = true;
            this.Lower_chk.Checked = true;
            this.Lower_chk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Lower_chk.Location = new System.Drawing.Point(150, 162);
            this.Lower_chk.Name = "Lower_chk";
            this.Lower_chk.Size = new System.Drawing.Size(111, 21);
            this.Lower_chk.TabIndex = 4;
            this.Lower_chk.Text = "Lower letters";
            this.Lower_chk.UseVisualStyleBackColor = true;
            this.Lower_chk.CheckedChanged += new System.EventHandler(this.Lower_chk_CheckedChanged);
            // 
            // Number_chk
            // 
            this.Number_chk.AutoSize = true;
            this.Number_chk.Location = new System.Drawing.Point(150, 190);
            this.Number_chk.Name = "Number_chk";
            this.Number_chk.Size = new System.Drawing.Size(87, 21);
            this.Number_chk.TabIndex = 5;
            this.Number_chk.Text = "Numbers";
            this.Number_chk.UseVisualStyleBackColor = true;
            this.Number_chk.CheckedChanged += new System.EventHandler(this.Number_chk_CheckedChanged);
            // 
            // Special_chk
            // 
            this.Special_chk.AutoSize = true;
            this.Special_chk.Location = new System.Drawing.Point(150, 217);
            this.Special_chk.Name = "Special_chk";
            this.Special_chk.Size = new System.Drawing.Size(76, 21);
            this.Special_chk.TabIndex = 6;
            this.Special_chk.Text = "Special";
            this.Special_chk.UseVisualStyleBackColor = true;
            this.Special_chk.CheckedChanged += new System.EventHandler(this.Special_chk_CheckedChanged);
            // 
            // Lenght_txt
            // 
            this.Lenght_txt.Location = new System.Drawing.Point(175, 100);
            this.Lenght_txt.Name = "Lenght_txt";
            this.Lenght_txt.Size = new System.Drawing.Size(98, 22);
            this.Lenght_txt.TabIndex = 7;
            this.Lenght_txt.Text = "15";
            this.Lenght_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Lenght_txt.TextChanged += new System.EventHandler(this.Lenght_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Taille";
            // 
            // Error_Label
            // 
            this.Error_Label.AutoSize = true;
            this.Error_Label.Location = new System.Drawing.Point(111, 78);
            this.Error_Label.Name = "Error_Label";
            this.Error_Label.Size = new System.Drawing.Size(0, 17);
            this.Error_Label.TabIndex = 9;
            // 
            // Copy_Label
            // 
            this.Copy_Label.AutoSize = true;
            this.Copy_Label.Location = new System.Drawing.Point(317, 77);
            this.Copy_Label.Name = "Copy_Label";
            this.Copy_Label.Size = new System.Drawing.Size(0, 17);
            this.Copy_Label.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 370);
            this.Controls.Add(this.Copy_Label);
            this.Controls.Add(this.Error_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lenght_txt);
            this.Controls.Add(this.Special_chk);
            this.Controls.Add(this.Number_chk);
            this.Controls.Add(this.Lower_chk);
            this.Controls.Add(this.Upper_chk);
            this.Controls.Add(this.Generate_bttn);
            this.Controls.Add(this.Copy_bttn);
            this.Controls.Add(this.Result_txt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Result_txt;
        private System.Windows.Forms.Button Copy_bttn;
        private System.Windows.Forms.Button Generate_bttn;
        private System.Windows.Forms.CheckBox Upper_chk;
        private System.Windows.Forms.CheckBox Lower_chk;
        private System.Windows.Forms.CheckBox Number_chk;
        private System.Windows.Forms.CheckBox Special_chk;
        private System.Windows.Forms.TextBox Lenght_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Error_Label;
        private System.Windows.Forms.Label Copy_Label;
    }
}

