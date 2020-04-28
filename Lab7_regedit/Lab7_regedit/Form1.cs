using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;
using Microsoft.Win32;

namespace Lab7_regedit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.Columns.Add("Имя",150);
            listView1.Columns.Add("Тип", 150);
            listView1.Columns.Add("Значение", 150);
            listView1.View = View.Details;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<RegistryKey> rootKeys = new List<RegistryKey>();
            rootKeys.Add(Registry.ClassesRoot);
            rootKeys.Add(Registry.CurrentUser);
            rootKeys.Add(Registry.LocalMachine);
            rootKeys.Add(Registry.Users);
            rootKeys.Add(Registry.CurrentConfig);

            foreach (RegistryKey key in rootKeys)
            {
                TreeNode treeNode = new TreeNode(key.Name);
                treeNode.Tag = key;
                FillNodes(treeNode, 0);
                treeView1.Nodes.Add(treeNode);

            }
        }

        private void FillNodes(TreeNode root, int depth)
        {
            if (depth > 5)
                return;
            
            RegistryKey key = root.Tag as RegistryKey;
            foreach (string nodes in key.GetSubKeyNames())
            {
                try
                {
                    RegistryKey subKey = key.OpenSubKey(nodes);
                    TreeNode childNodes = new TreeNode(nodes);
                    if (childNodes.Nodes.Count<0)
                    {
                        throw new Exception("Error to add childNodes");
                    }
                                       
                    childNodes.Tag = subKey;
                    FillNodes(childNodes, ++depth);
                    root.Nodes.Add(childNodes);

                }
               catch(Exception)
                {
                    
                }
            }


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            RegistryKey selecKey = e.Node.Tag as RegistryKey;
            listView1.Items.Clear();
            foreach (string str in selecKey.GetValueNames())
            {
                try
                {                       
                   ListViewItem item = listView1.Items.Add(str);
                   item.SubItems.Add(selecKey.GetValue(str).ToString());
                   item.SubItems.Add(selecKey.GetValueKind(str).ToString());
                   label1.Text = e.Node.FullPath.ToString();
                }
                catch (Exception)
                {
                }
            }
            
          
        }

    }
}
