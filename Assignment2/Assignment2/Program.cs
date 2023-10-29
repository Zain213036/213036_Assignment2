using System;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        ArrayList dataList = new ArrayList();

        public MainForm()
        {
            InitializeComponent();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            string newItem = inputTextBox.Text;
            if (!string.IsNullOrEmpty(newItem))
            {
                dataList.Add(newItem);
                listBox.Items.Add(newItem);
                inputTextBox.Clear();
            }
        }


        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex >= 0)
            {
                int selectedIndex = listBox.SelectedIndex;
                dataList.RemoveAt(selectedIndex);
                listBox.Items.RemoveAt(selectedIndex);
            }
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            dataList.Clear();
            listBox.Items.Clear();
        }
    }