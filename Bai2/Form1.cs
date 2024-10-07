using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Frm1 : Form
    {
        private string currentFilePath = "";
        public Frm1()
        {
            InitializeComponent();
        }

        private void thoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BuildFontComboBox();
            BuildSizeComboBox();

        }
        private void BuildFontComboBox()
        {
            var fonts = FontFamily.Families.Select(f => f.Name).ToArray();
            toolStripcmbFont.Items.AddRange(fonts);
            toolStripcmbFont.SelectedItem = "Tahoma";
        }

        private void BuildSizeComboBox()
        {
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            toolStripcmbSize.Items.AddRange(sizes.Cast<object>().ToArray());
            toolStripcmbSize.SelectedItem = 14;
        }
        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                rtbA.ForeColor = fontDlg.Color;
                rtbA.Font = fontDlg.Font;
            }
        }
        private void toolStripcmbFont_Click(object sender, EventArgs e)
        {

        }

        private void toolStripcmbSize_Click(object sender, EventArgs e)
        {

        }

        private void toolStripcmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (toolStripcmbFont.SelectedIndex != -1 && toolStripcmbSize.SelectedIndex != -1)
                {
                    string selectedFont = toolStripcmbFont.SelectedItem.ToString();
                    float selectedSize = Convert.ToSingle(toolStripcmbSize.SelectedItem);
                    rtbA.SelectionFont = new Font(new FontFamily(selectedFont), selectedSize);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ResetRichTextBox()
        {
            rtbA.Clear();
            toolStripcmbFont.SelectedItem = "Tahoma"; 
            toolStripcmbSize.SelectedItem = 14; 
        }

        private void toolStripMenuItemThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rtbA_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void toolStripMenuItemMoTapTin_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Rich Text Files (*.rtf)|*.rtf|Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(openFileDialog.FileName).ToLower();

                    if (fileExtension == ".rtf")
                    {
                        rtbA.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                    }
                    else if (fileExtension == ".txt")
                    {
                        rtbA.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        MessageBox.Show("Định dạng tệp không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripNew_Click(object sender, EventArgs e)
        {
            ResetRichTextBox();
        }

        private void toolStripMenuItemTaoMoiVanBan_Click(object sender, EventArgs e)
        {
            ResetRichTextBox();
        }

        private void toolStripMenuItemLuuNoiDungVanBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Rich Text Files|*.rtf";
                saveFileDialog.Title = "Lưu tập tin";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                    rtbA.SaveFile(currentFilePath);
                    MessageBox.Show("Lưu tập tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                rtbA.SaveFile(currentFilePath);
                MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Rich Text Files|*.rtf";
                saveFileDialog.Title = "Lưu tập tin";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                    rtbA.SaveFile(currentFilePath);
                    MessageBox.Show("Lưu tập tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                rtbA.SaveFile(currentFilePath);
                MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripBold_Click(object sender, EventArgs e)
        {
            Font currentFont = rtbA.SelectionFont;
            if (currentFont != null)
            {
                Font newFont = new Font(currentFont, currentFont.Style);
                if (currentFont.Bold)
                {
                    newFont = new Font(newFont, newFont.Style & ~FontStyle.Bold);
                }
                else
                {
                    newFont = new Font(newFont, newFont.Style | FontStyle.Bold);
                }
                rtbA.SelectionFont = newFont;
            }
        }

        private void toolStripItaric_Click(object sender, EventArgs e)
        {
            Font currentFont = rtbA.SelectionFont;
            if (currentFont != null)
            {
                Font newFont = new Font(currentFont, currentFont.Style);
                if (currentFont.Italic)
                {
                    newFont = new Font(newFont, newFont.Style & ~FontStyle.Italic);
                }
                else
                {
                    newFont = new Font(newFont, newFont.Style | FontStyle.Italic);
                }
                rtbA.SelectionFont = newFont;
            }
        }

        private void toolStripUnderLine_Click(object sender, EventArgs e)
        {
            Font currentFont = rtbA.SelectionFont;
            if (currentFont != null)
            {
                Font newFont = new Font(currentFont, currentFont.Style);
                if (currentFont.Underline)
                {
                    newFont = new Font(newFont, newFont.Style & ~FontStyle.Underline);
                }
                else
                {
                    newFont = new Font(newFont, newFont.Style | FontStyle.Underline);
                }
                rtbA.SelectionFont = newFont;
            }
        }
        private void toolStripcmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (toolStripcmbFont.SelectedIndex != -1 && toolStripcmbSize.SelectedIndex != -1)
                {
                    string selectedFont = toolStripcmbFont.SelectedItem.ToString();
                    float selectedSize = Convert.ToSingle(toolStripcmbSize.SelectedItem);
                    rtbA.SelectionFont = new Font(new FontFamily(selectedFont), selectedSize);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
