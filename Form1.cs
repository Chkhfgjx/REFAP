using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Функция для обработки события по нажатию кнопки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recogniseButton_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Функция для открытия изображения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterFile_Click(object sender, EventArgs e)
        {
            #region ValueForImage
            byte[] imageBytes = null;
            string imagePath = string.Empty;
            #endregion
            #region OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "d:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                    imageBytes = File.ReadAllBytes(imagePath);
                }
            }
            #endregion
            
        }
    }
}
