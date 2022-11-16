using System;
using System.CodeDom.Compiler;
using System.Windows.Forms;

namespace VizeCalismaProje
{
    public partial class Form1 : Form
    {
        class Node
        {
            public int no;
            public string name;
            public Node next;
        }

        Node first = null;

        public Form1()
        {
            InitializeComponent();
        }

        #region CLICKLER

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (txtBox_No.Text.Trim() != "" && txtBox_Ad.Text.Trim() != "")
            {
                int id = Convert.ToInt32(txtBox_No.Text);
                string name = txtBox_Ad.Text;
                Ekle(id, name);
            }
            else
            {
                MessageBox.Show("Değerler boş olamaz.");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (txtBox_No.Text.Trim() != "" && txtBox_Ad.Text.Trim() != "")
            {
                int id = Convert.ToInt32(txtBox_No.Text);
                Sil(id);
            }
            else
            {
                MessageBox.Show("Değerler boş olamaz.");
            }
        }

        private void btn_ListeYazdir_Click(object sender, System.EventArgs e)
        {
            ListeYazdir();
        }

        #endregion

        #region METODLAR

        public void Ekle(int id, string name)
        {
            Node newNode = new Node();
            newNode.no = id;
            newNode.name = name;

            if (first == null)
            {
                first = newNode;
                first.next = null;
            }
            else
            {
                Node temp = first;
                if(newNode.no <= temp.no)
                {
                    newNode.next = first;
                    first = newNode;
                }
                else
                {
                    while (temp.next != null)
                    {
                        if (temp.next.no >= newNode.no)
                        {
                            break;
                        }
                        temp = temp.next;
                    }
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
            }
        }
        
        public void Sil(int id)
        {
            Node nodeToDelete = new Node();
            nodeToDelete.no = id;

            if(first.next == null)
            {
                first = null;
            }
            else if(first.no == nodeToDelete.no)
            {
                first = first.next;
            }
            else
            {
                Node temp = first;
                Node tempPrevious = temp;
                while (temp.next != null)
                {
                    if (nodeToDelete.no == temp.no)
                    {
                        break;
                    }
                    tempPrevious = temp;
                    temp = temp.next;
                }
                tempPrevious.next = temp.next;
            }
        }

        public void ListeYazdir()
        {
            dGridView_Yazdir.Rows.Clear();
            Node temp = new Node();
            temp = first;
            if(temp != null)
            {
                while(temp != null)
                {
                    dGridView_Yazdir.Rows.Add(temp.no, temp.name);
                    temp = temp.next;
                }
            }
            else
            {
                MessageBox.Show("Liste boş.");
            }
        }

        #endregion
    }
}
