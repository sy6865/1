using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class 记事本 : Form
    {
        private String _FileName = " ";
        private Encoding _FileEncode = Encoding.UTF8;//系统默认编码为ANSI：Encoding.Default
        private bool _IsSaved = true;//是否已保存

        public 记事本()
        {
            InitializeComponent();
        }

        private void mi_Edit_Copy_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void mi_Edit_Cut_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void mi_Edit_Paste_Click(object sender, EventArgs e)
        {
            mi_Edit_Paste.Enabled = Clipboard.ContainsText();
            mi_Edit_Copy.Enabled = textBox1.SelectedText != "";
            mi_Edit_Cut.Enabled = mi_Edit_Copy.Enabled;
        }

        private void mi_Edit_Paste_Click_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
         private void mi_Edit_DropDownOpened(object sender, EventArgs e)
        {
            mi_Edit_Paste.Enabled = Clipboard.ContainsText();
            mi_Edit_Copy.Enabled = textBox1.SelectedText != "";
            mi_Edit_Cut.Enabled = mi_Edit_Copy.Enabled;
        }
    }
}
