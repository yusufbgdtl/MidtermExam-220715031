namespace MidtermExam
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenTextEditor = new System.Windows.Forms.Button();
            this.btnOpenGrades = new System.Windows.Forms.Button();
            this.btnOpenColorController = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(285, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "\"Main Navigation Form";
            // 
            // btnOpenTextEditor
            // 
            this.btnOpenTextEditor.Location = new System.Drawing.Point(89, 243);
            this.btnOpenTextEditor.Name = "btnOpenTextEditor";
            this.btnOpenTextEditor.Size = new System.Drawing.Size(155, 23);
            this.btnOpenTextEditor.TabIndex = 1;
            this.btnOpenTextEditor.Text = "\"Open Text Editor";
            this.btnOpenTextEditor.UseVisualStyleBackColor = true;
            this.btnOpenTextEditor.Click += new System.EventHandler(this.btnOpenTextEditor_Click);
            // 
            // btnOpenGrades
            // 
            this.btnOpenGrades.Location = new System.Drawing.Point(290, 243);
            this.btnOpenGrades.Name = "btnOpenGrades";
            this.btnOpenGrades.Size = new System.Drawing.Size(200, 23);
            this.btnOpenGrades.TabIndex = 2;
            this.btnOpenGrades.Text = "Student Grades & To-Do List\", Name";
            this.btnOpenGrades.UseVisualStyleBackColor = true;
            this.btnOpenGrades.Click += new System.EventHandler(this.btnOpenGrades_Click);
            // 
            // btnOpenColorController
            // 
            this.btnOpenColorController.Location = new System.Drawing.Point(547, 243);
            this.btnOpenColorController.Name = "btnOpenColorController";
            this.btnOpenColorController.Size = new System.Drawing.Size(150, 23);
            this.btnOpenColorController.TabIndex = 3;
            this.btnOpenColorController.Text = "Background Color Controller";
            this.btnOpenColorController.UseVisualStyleBackColor = true;
            this.btnOpenColorController.Click += new System.EventHandler(this.btnOpenColorController_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnOpenColorController);
            this.Controls.Add(this.btnOpenGrades);
            this.Controls.Add(this.btnOpenTextEditor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenTextEditor;
        private System.Windows.Forms.Button btnOpenGrades;
        private System.Windows.Forms.Button btnOpenColorController;
    }
}

