using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;

namespace Right_click_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Certain_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key_one = Registry.ClassesRoot;
                key_one.CreateSubKey(regedit.Text + dispaly_name.Text);
                RegistryKey software_one = key_one.OpenSubKey(regedit.Text + dispaly_name.Text, true);
                software_one.SetValue("Icon", icon.Text);
                key_one.Close();
                RegistryKey key_two = Registry.ClassesRoot;
                key_two.CreateSubKey(regedit.Text + dispaly_name.Text + "\\command");
                RegistryKey software_two = key_two.OpenSubKey(regedit.Text + dispaly_name.Text + "\\command", true);
                software_two.SetValue("", order.Text);
                key_two.Close();
                MessageBox.Show("操作成功");
            }
            catch
            {
                MessageBox.Show("写入失败，请以管理员身份运行");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Icon_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Current_path_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(current_path.Text.Trim())) {
                icon.Text = current_path.Text;

                if (current_path.Text == "")
                {
                    order.Text = "";
                }
                else
                {
                    order.Text = current_path.Text + " %1";
                }

                string[] path = current_path.Text.Split('\\');
                if (path[path.Length - 1] == "ida.exe")
                {
                    dispaly_name.Text = "IDA PRO (32-bit) " + GetVersion();
                }
                else if (path[path.Length - 1] == "ida64.exe")
                {
                    dispaly_name.Text = "IDA PRO (64-bit) " + GetVersion();
                }
                else if (path[path.Length - 1] == "x96dbg.exe")
                {
                    dispaly_name.Text = "用x96dbg调试";
                }
                else
                {
                    try
                    {
                        string[] tmp = path[path.Length - 1].Split('.');
                        dispaly_name.Text = tmp[0];
                    }
                    catch
                    {
                        dispaly_name.Text = "";
                    }
                }
            }
            else
            {
                icon.Text = "";
                dispaly_name.Text = "";
                order.Text = "";
            }
            
            
        }

        private string GetVersion()
        {
            if (File.Exists(current_path.Text.Trim()))
            {
                try
                {
                    FileVersionInfo ver = FileVersionInfo.GetVersionInfo(current_path.Text.Trim());
                    char[] Version = ver.FileVersion.ToCharArray();
                    return Version[0] + "." + Version[2];
                }
                catch
                {
                    return "";
                }

            }
            else
            {
                return "";
            }
        }

        private void Dispaly_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Regedit_TextChanged(object sender, EventArgs e)
        {
            string tmp = "*\\shell\\";
            if (tmp != regedit.Text.Trim())
            {
                MessageBox.Show("你在改动要被写入的位置");
            }
        }

        private void Order_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
