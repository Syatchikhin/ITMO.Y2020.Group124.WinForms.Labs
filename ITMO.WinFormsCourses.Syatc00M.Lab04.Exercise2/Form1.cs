﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinFormsCourses.Syatc00M.Lab04.Exercise2
{
    public partial class editForm : Form
    {
        public editForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //add button
        {
            EditPersonForm editForm = new EditPersonForm();
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            ListViewItem newItem = personsListView.Items.Add(editForm.FirstName);
            newItem.SubItems.Add(editForm.LastName);
            newItem.SubItems.Add(editForm.Age.ToString());
        }

        private void button1_Click(object sender, EventArgs e) //edit button
        {
            if (personsListView.SelectedItems.Count == 0)
                return;
            ListViewItem item = personsListView.SelectedItems[0];

            EditPersonForm editForm = new EditPersonForm();
            editForm.FirstName = item.Text;
            editForm.LastName = item.SubItems[1].Text;
            editForm.Age = Convert.ToInt32(item.SubItems[2].Text);

            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            item.Text = editForm.FirstName;
            item.SubItems[1].Text = editForm.LastName;
            item.SubItems[2].Text = editForm.Age.ToString();


        }

        

    }
}
