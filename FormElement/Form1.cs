using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FormElement
{
    public partial class Form1 : Form
    {
        TreeView tree;
        Button btn;
        Label lbl;
        PictureBox pb;
        CheckBox cbA, cbB, cbC, cbD;
        RadioButton rb, rb2;
        TextBox tbx;
        Button mb;
        TabControl tab;
        bool t = true;
        public Form1()
        {
            this.Height = 700;
            this.Width = 800;
            this.Text = "Vorm elementidega";
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("Elemendid");
            tn.Nodes.Add(new TreeNode("Nupp"));
            tn.Nodes.Add(new TreeNode("label"));
            tn.Nodes.Add(new TreeNode("PictureBox"));
            tn.Nodes.Add(new TreeNode("CheckBox"));
            tn.Nodes.Add(new TreeNode("Radiobutton"));
            tn.Nodes.Add(new TreeNode("TextBox"));
            tn.Nodes.Add(new TreeNode("TabControl"));
            tn.Nodes.Add(new TreeNode("MessageBox"));
            //nupp
            btn = new Button();
            btn.Text = "vajuta siia";
            btn.Location = new Point(150, 30);
            btn.Height = 30;
            btn.Width = 100;
            btn.Click += Btn_Click;
            //label
            lbl = new Label();
            lbl.Text = "Elamentide loomine c# abil";
            lbl.Size = new Size(60,30);
            lbl.Location = new Point(150, 0);
            lbl.MouseHover += Lbl_MouseHover;
            lbl.MouseLeave += Lbl_MouseLeave;
            //imageBox
            pb = new PictureBox();
            pb.Size = new Size(100, 100);
            pb.Location = new Point(150, 70);
            pb.ImageLocation = ("../../image/index.jpg");
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            pb.MouseDoubleClick += Pb_MouseDoubleClick;
            //checkBox
            cbA = new CheckBox();
            cbB = new CheckBox();
            cbC = new CheckBox();
            cbD = new CheckBox();
            
            cbA.Location = new Point(600, 70);
            cbA.Text = "Font(label)";
            cbB.Text = "Border(PictureBox)";
            cbB.Location = new Point(600, 50);
            cbB.Size = new Size(cbB.Text.Length * 8, 20);
            cbC.Location = new Point(600, 30);
            cbC.Text = "Background color";
            cbD.Location = new Point(600, 90);
            cbD.Text = "Size";
            cbA.MouseClick += CbA_MouseClick;
            cbB.MouseClick += CbB_MouseClick;
            cbC.MouseClick += CbC_MouseClick;
            cbD.MouseClick += CbD_MouseClick;
            //radiobutton
            rb = new RadioButton();
            rb2 = new RadioButton();
            rb.Location = new Point(500, 70);
            rb2.Location = new Point(500, 40);
            rb.Text = "Youtube";
            rb2.Text = "Moodle";
            rb.CheckedChanged += new EventHandler(rbt_Checked);
            rb2.CheckedChanged += new EventHandler(rbt_Checked);
            //messageBox
            mb = new Button();
            mb.Text = "MessageBox";
            mb.Size = new Size(mb.Text.Length * 8, 20);
            mb.Location = new Point(500, 300);
            mb.Click += Mb_Click;
            
            //textbox
            tbx = new TextBox();
            tbx.Location = new Point(500, 200);
            tbx.Size = new Size(200,100);
            Button bt = new Button();

            //tabControl
            tab = new TabControl();
            tab.Location = new Point(150,400);
            tab.Size = new Size(400, 300);
            TabPage tabp1 = new TabPage("Esimene");
            WebBrowser wb = new WebBrowser();
            wb.Url =new Uri("https://www.tthk.ee/");
            tabp1.Controls.Add(wb);
            TabPage tabp2 = new TabPage("Teine");
            //WebBrowser wb1 = new WebBrowser();
            //wb1.Url= new Uri("");
            //tabp2.Controls.Add(wb1);
            TabPage tabp3 = new TabPage("Kolmas");
            tabp3.MouseDoubleClick += Tabp3_MouseClick;
            tab.Controls.Add(tabp1);
            tab.Controls.Add(tabp2);
            tab.Controls.Add(tabp3);
            tab.DoubleClick += Tab_DoubleClick;
            




            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
            
        }

        private void Tab_DoubleClick(object sender, EventArgs e)
        {
            this.tab.TabPages.Remove(tab.SelectedTab);
        }

        private void Tabp3_MouseClick(object sender, MouseEventArgs e)
        {
            string title = "tabP" + (tab.TabCount + 1).ToString();
            TabPage tbb = new TabPage(title);
            tab.TabPages.Add(tbb);

        }

        private void rbt_Checked(object sender, EventArgs e)
        {
            if(rb2.Checked)
            {
                System.Diagnostics.Process.Start("https://moodle.edu.ee/");
            }
            else if (rb.Checked)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/");
            }
        }
        private void Mb_Click(object sender, EventArgs e)
        {
            var answer=MessageBox.Show(
            "Вы хотите перейти на сайт",
            "Сообщение",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if(answer==DialogResult.No)
            {
                var answers = MessageBox.Show(
                "Ты меня растраиваешь, ",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                if(answers == DialogResult.No)
                {
                    var answerss = MessageBox.Show(
                    "Если опять нажмёшь нет, то твой пк выключится",
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                    if (answerss == DialogResult.No)
                    {
                        Process.Start("shutdown", "/r /t 10");
                    }
                    else
                    {
                        System.Diagnostics.Process.Start("https://kabilov20.thkit.ee");
                    }
                }
                else
                {
                    System.Diagnostics.Process.Start("https://kabilov20.thkit.ee");
                }
            }
            else
            {
                System.Diagnostics.Process.Start("https://kabilov20.thkit.ee");
            }

        }
        private void CbD_MouseClick(object sender, MouseEventArgs e)
        {
            if (t)
            {
                this.Size = new Size(1000, 1000);
                cbD.Text = "Teeme väiksem";
                t = false;
            }
            else
            {
                this.Size = new Size(800, 500);
                cbD.Text = "Suurendame";
                t = true;
            }
        }

        private void CbC_MouseClick(object sender, MouseEventArgs e)
        {
            if (t)
            {
                lbl.Font = new Font("Times New Roman",7,FontStyle.Bold);
                cbC.Text = "Times New Roman";
                t = false;
            }
            else
            {
                lbl.Font = new Font("Arial",7, FontStyle.Bold);
                cbC.Text = "Arial";
                t = true;
            }
        }

        private void CbB_MouseClick(object sender, MouseEventArgs e)
        {
            if (t)
            {
                pb.BorderStyle = BorderStyle.Fixed3D;
                cbB.Text = "Fixed3D";
                t = false;
            }
            else
            {
                pb.BorderStyle = BorderStyle.None;
                cbB.Text = "None";
                t = true;
            }
            
        }

        private void CbA_MouseClick(object sender, MouseEventArgs e)
        {
            if (t)
            {
                BackColor = Color.Red;
                cbA.Text = "Red";
                t = false;
            }
            else
            {
                BackColor = Color.Blue;
                cbA.Text = "Blue";
                t = true;
            }
        }

        private void Pb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            List<string> list = new List<string>();
            list.Add("images.jpg");
            list.Add("index.jpg");
            list.Add("index2.jpg");
            
            Random rnd = new Random();

            int num = rnd.Next(3);

            pb.ImageLocation = ($"../../image/{list[num]}");
        }

        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl.BackColor = Color.Transparent;
        }

        private void Lbl_MouseHover(object sender, EventArgs e)
        {
            lbl.BackColor = Color.FromArgb(76,0,153);
        }

        
        private void Btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://kabilov20.thkit.ee");
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text=="Nupp")
            {
                this.Controls.Add(btn);
            }
            else if (e.Node.Text == "label")
            {
                this.Controls.Add(lbl);
            }
            else if (e.Node.Text == "PictureBox")
            {
                this.Controls.Add(pb);
            }
            else if (e.Node.Text == "CheckBox")
            {
                this.Controls.Add(cbA);
                this.Controls.Add(cbB);
                this.Controls.Add(cbC);
                this.Controls.Add(cbD);
            }
            else if (e.Node.Text == "Radiobutton")
            {
                this.Controls.Add(rb);
                this.Controls.Add(rb2);
            }
            else if (e.Node.Text == "MessageBox")
            {
                this.Controls.Add(mb);
               
            }
            else if (e.Node.Text == "TextBox")
            {
                this.Controls.Add(tbx);

            }
            else if(e.Node.Text == "TabControl")
            {
                this.Controls.Add(tab);

            }
        }
    }
}
