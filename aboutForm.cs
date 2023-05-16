using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinguaLearn
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
        }

        private void duoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            duoLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.duolingo.com");
            resoursePictureBox.Image =
               (Image)(Properties.Resources.ResourceManager.GetObject(
                   $"Duolingo-logo"));
        }

        private void babLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            babLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.babbel.com");
            resoursePictureBox.Image =
              (Image)(Properties.Resources.ResourceManager.GetObject(
                  $"babbel-logo"));
        }

        private void memLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            memLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.memrise.com");
            resoursePictureBox.Image =
              (Image)(Properties.Resources.ResourceManager.GetObject(
                  $"Memrise-logo"));
        }

        private void aboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
