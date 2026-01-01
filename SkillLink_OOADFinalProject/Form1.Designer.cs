namespace SkillLink_OOADFinalProject
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
            this.dataGridViewTrainees = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTraineeName = new System.Windows.Forms.TextBox();
            this.textBoxTraineeContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddTrainee = new System.Windows.Forms.Button();
            this.buttonCertify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTrainees
            // 
            this.dataGridViewTrainees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrainees.Location = new System.Drawing.Point(84, 221);
            this.dataGridViewTrainees.Name = "dataGridViewTrainees";
            this.dataGridViewTrainees.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewTrainees.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trainee Name:";
            // 
            // textBoxTraineeName
            // 
            this.textBoxTraineeName.Location = new System.Drawing.Point(224, 137);
            this.textBoxTraineeName.Name = "textBoxTraineeName";
            this.textBoxTraineeName.Size = new System.Drawing.Size(100, 20);
            this.textBoxTraineeName.TabIndex = 2;
            // 
            // textBoxTraineeContact
            // 
            this.textBoxTraineeContact.Location = new System.Drawing.Point(224, 163);
            this.textBoxTraineeContact.Name = "textBoxTraineeContact";
            this.textBoxTraineeContact.Size = new System.Drawing.Size(100, 20);
            this.textBoxTraineeContact.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trainee Contact:";
            // 
            // buttonAddTrainee
            // 
            this.buttonAddTrainee.Location = new System.Drawing.Point(84, 192);
            this.buttonAddTrainee.Name = "buttonAddTrainee";
            this.buttonAddTrainee.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTrainee.TabIndex = 5;
            this.buttonAddTrainee.Text = "Add Trainee";
            this.buttonAddTrainee.UseVisualStyleBackColor = true;
            // 
            // buttonCertify
            // 
            this.buttonCertify.Location = new System.Drawing.Point(249, 192);
            this.buttonCertify.Name = "buttonCertify";
            this.buttonCertify.Size = new System.Drawing.Size(75, 23);
            this.buttonCertify.TabIndex = 6;
            this.buttonCertify.Text = "Certify";
            this.buttonCertify.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCertify);
            this.Controls.Add(this.buttonAddTrainee);
            this.Controls.Add(this.textBoxTraineeContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTraineeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTrainees);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTrainees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTraineeName;
        private System.Windows.Forms.TextBox textBoxTraineeContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddTrainee;
        private System.Windows.Forms.Button buttonCertify;
    }
}

