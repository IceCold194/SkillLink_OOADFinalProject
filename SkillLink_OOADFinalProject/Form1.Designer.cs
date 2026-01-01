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
            this.textBoxTraineeToCertify = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTrainees
            // 
            this.dataGridViewTrainees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrainees.Location = new System.Drawing.Point(104, 161);
            this.dataGridViewTrainees.Name = "dataGridViewTrainees";
            this.dataGridViewTrainees.Size = new System.Drawing.Size(576, 180);
            this.dataGridViewTrainees.TabIndex = 0;
            this.dataGridViewTrainees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTrainees_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trainee Name:";
            // 
            // textBoxTraineeName
            // 
            this.textBoxTraineeName.Location = new System.Drawing.Point(184, 135);
            this.textBoxTraineeName.Name = "textBoxTraineeName";
            this.textBoxTraineeName.Size = new System.Drawing.Size(112, 20);
            this.textBoxTraineeName.TabIndex = 2;
            // 
            // textBoxTraineeContact
            // 
            this.textBoxTraineeContact.Location = new System.Drawing.Point(398, 135);
            this.textBoxTraineeContact.Name = "textBoxTraineeContact";
            this.textBoxTraineeContact.Size = new System.Drawing.Size(112, 20);
            this.textBoxTraineeContact.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trainee Contact:";
            // 
            // buttonAddTrainee
            // 
            this.buttonAddTrainee.Location = new System.Drawing.Point(524, 133);
            this.buttonAddTrainee.Name = "buttonAddTrainee";
            this.buttonAddTrainee.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTrainee.TabIndex = 5;
            this.buttonAddTrainee.Text = "Add Trainee";
            this.buttonAddTrainee.UseVisualStyleBackColor = true;
            this.buttonAddTrainee.Click += new System.EventHandler(this.buttonAddTrainee_Click);
            // 
            // buttonCertify
            // 
            this.buttonCertify.Location = new System.Drawing.Point(605, 133);
            this.buttonCertify.Name = "buttonCertify";
            this.buttonCertify.Size = new System.Drawing.Size(75, 23);
            this.buttonCertify.TabIndex = 6;
            this.buttonCertify.Text = "Certify";
            this.buttonCertify.UseVisualStyleBackColor = true;
            this.buttonCertify.Click += new System.EventHandler(this.buttonCertify_Click);
            // 
            // textBoxTraineeToCertify
            // 
            this.textBoxTraineeToCertify.Location = new System.Drawing.Point(529, 71);
            this.textBoxTraineeToCertify.Name = "textBoxTraineeToCertify";
            this.textBoxTraineeToCertify.Size = new System.Drawing.Size(151, 20);
            this.textBoxTraineeToCertify.TabIndex = 7;
            this.textBoxTraineeToCertify.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(582, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "SkillLink: Barangay Skills Training Enrollment System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SkillLink_OOADFinalProject.Properties.Resources.side_view_worker_using_angle_grinder_metal_cutting;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTraineeToCertify);
            this.Controls.Add(this.buttonCertify);
            this.Controls.Add(this.buttonAddTrainee);
            this.Controls.Add(this.textBoxTraineeContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTraineeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTrainees);
            this.Name = "Form1";
            this.Text = "SkillLink";
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
        private System.Windows.Forms.TextBox textBoxTraineeToCertify;
        private System.Windows.Forms.Label label3;
    }
}

