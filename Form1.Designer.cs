
namespace WindowsFormsApp1
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterPathLabel = new System.Windows.Forms.Label();
            this.pathEdit = new System.Windows.Forms.TextBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.recogniseButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // enterPathLabel
            // 
            this.enterPathLabel.AutoSize = true;
            this.enterPathLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterPathLabel.Location = new System.Drawing.Point(23, 22);
            this.enterPathLabel.Name = "enterPathLabel";
            this.enterPathLabel.Size = new System.Drawing.Size(255, 29);
            this.enterPathLabel.TabIndex = 0;
            this.enterPathLabel.Text = "Введите путь к картинке";
            // 
            // pathEdit
            // 
            this.pathEdit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathEdit.Location = new System.Drawing.Point(282, 14);
            this.pathEdit.Name = "pathEdit";
            this.pathEdit.Size = new System.Drawing.Size(353, 37);
            this.pathEdit.TabIndex = 1;
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(28, 81);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(311, 326);
            this.image.TabIndex = 2;
            this.image.TabStop = false;
            this.image.Visible = false;
            // 
            // recogniseButton
            // 
            this.recogniseButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recogniseButton.Location = new System.Drawing.Point(660, 14);
            this.recogniseButton.Name = "recogniseButton";
            this.recogniseButton.Size = new System.Drawing.Size(136, 37);
            this.recogniseButton.TabIndex = 3;
            this.recogniseButton.Text = "Распознать";
            this.recogniseButton.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(401, 81);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(357, 32);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Эмоция: ";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.recogniseButton);
            this.Controls.Add(this.image);
            this.Controls.Add(this.pathEdit);
            this.Controls.Add(this.enterPathLabel);
            this.Name = "mainForm";
            this.Text = "Распознавание эмоции с картики";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterPathLabel;
        private System.Windows.Forms.TextBox pathEdit;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button recogniseButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

