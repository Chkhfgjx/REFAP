
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
            this.ImageFromFile = new System.Windows.Forms.PictureBox();
            this.recogniseButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.EnterFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageFromFile)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageFromFile
            // 
            this.ImageFromFile.Location = new System.Drawing.Point(28, 81);
            this.ImageFromFile.Name = "ImageFromFile";
            this.ImageFromFile.Size = new System.Drawing.Size(311, 326);
            this.ImageFromFile.TabIndex = 2;
            this.ImageFromFile.TabStop = false;
            this.ImageFromFile.Visible = false;
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
            this.recogniseButton.Click += new System.EventHandler(this.recogniseButton_Click);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EnterFile
            // 
            this.EnterFile.AutoSize = true;
            this.EnterFile.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterFile.Location = new System.Drawing.Point(28, 14);
            this.EnterFile.Name = "EnterFile";
            this.EnterFile.Size = new System.Drawing.Size(181, 39);
            this.EnterFile.TabIndex = 5;
            this.EnterFile.Text = "Выберите файл";
            this.EnterFile.UseVisualStyleBackColor = true;
            this.EnterFile.Click += new System.EventHandler(this.EnterFile_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnterFile);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.recogniseButton);
            this.Controls.Add(this.ImageFromFile);
            this.Name = "mainForm";
            this.Text = "Распознавание эмоции с картики";
            ((System.ComponentModel.ISupportInitialize)(this.ImageFromFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        #region AllComponentsInSystem
        private System.Windows.Forms.PictureBox ImageFromFile;
        private System.Windows.Forms.Button recogniseButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button EnterFile;
        #endregion
    }
}

