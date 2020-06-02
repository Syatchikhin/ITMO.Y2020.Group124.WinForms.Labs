﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinFormsCourses.Syatc00M.Lab04.Exercise3
{
    public partial class editForm : Form
    {
        public editForm()
        {
            InitializeComponent();
        }

        List<Person> pers = new List<Person>();

        private void button2_Click(object sender, EventArgs e) //add button
        {
            Person p = new Person(); //p33
            //EditPersonForm editForm = new EditPersonForm();
            //EditPersonForm editForm = new EditPersonForm(p);
            //if (editForm.ShowDialog() != DialogResult.OK)
            //    return;
            //ListViewItem newItem = personsListView.Items.Add(editForm.FirstName);
            //newItem.SubItems.Add(editForm.LastName);
            //newItem.SubItems.Add(editForm.Age.ToString());

            EditPersonForm editForm = new EditPersonForm(p);
            if (editForm.ShowDialog() != DialogResult.OK)
            return;
            pers.Add(p);

            personsListView.VirtualListSize = pers.Count;
            personsListView.Invalidate();

        }

        private void button1_Click(object sender, EventArgs e) //edit button
        {
            //if (personsListView.SelectedItems.Count == 0)
             //   return;
            //ListViewItem item = personsListView.SelectedItems[0];

            //EditPersonForm editForm = new EditPersonForm();
            //editForm.FirstName = item.Text;
            //editForm.LastName = item.SubItems[1].Text;
            //editForm.Age = Convert.ToInt32(item.SubItems[2].Text);

            //if (editForm.ShowDialog() != DialogResult.OK)
            //    return;
            //item.Text = editForm.FirstName;
            //item.SubItems[1].Text = editForm.LastName;
            //item.SubItems[2].Text = editForm.Age.ToString();


            if (personsListView.SelectedIndices.Count == 0)
                return;
            Person p = pers[personsListView.SelectedIndices[0]];
            EditPersonForm editForm = new EditPersonForm(p);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                personsListView.Invalidate();
            }


        }

        private void personsListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < pers.Count)
            {
                e.Item = new ListViewItem(pers[e.ItemIndex].FirstName);
                e.Item.SubItems.Add(pers[e.ItemIndex].LastName);
                e.Item.SubItems.Add(pers[e.ItemIndex].Age.ToString());

            }


        }

        private void button3_Click(object sender, EventArgs e) //see the List btn
        {
            StringBuilder sb = new StringBuilder();
            foreach (Person item in pers)
            {
                sb.Append("Сотрудник: \n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return LastName + " " + FirstName + "\nВозраст:" + Age + "\n";
        }
    }



}
