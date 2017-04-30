using Microsoft.WindowsAPICodePack.Dialogs;
using NCode.ReparsePoints;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Junction_creator
{
    public partial class Form1 : Form
    {
        [Flags]
        enum Event
        {
            NoneClicked = 0,
            InputClicked = 1,
            OutputClicked = 2,
            BothClicked = 3
        }

        Event clicked = Event.NoneClicked;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog("Please select the input directory");
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                lblInput.Text = dialog.FileName;
                lblCurrent.Text = "0";
                lblTotal.Text = (Directory.GetDirectories(dialog.FileName).Length + Directory.GetFiles(dialog.FileName).Length).ToString();
                clicked = clicked | Event.InputClicked;
            }
            if (clicked == Event.BothClicked)
            {
                btnCreateJunctions.Enabled = true;
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog("Please select the output directory");
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                lblOutput.Text = dialog.FileName;
                lblCurrent.Text = "0";
                clicked = clicked | Event.OutputClicked;
            }
            if (clicked == Event.BothClicked)
            {
                btnCreateJunctions.Enabled = true;
            }
        }

        private void btnCreateJunctions_Click(object sender, EventArgs e)
        {
            string input = lblInput.Text;
            string output = lblOutput.Text;

            string[] directories = Directory.GetDirectories(input);
            string[] files = Directory.GetFiles(input);

            ProgressBar.Step = 1;
            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = Int32.Parse(lblTotal.Text);
            var provider = ReparsePointFactory.Provider;
            foreach (string directoryPath in directories)
            {
                string directory = directoryPath.Substring(directoryPath.LastIndexOf('\\'));
                if (Directory.Exists(output + directory))
                {
                    DirectoryInfo nfo = new DirectoryInfo(output + directory);
                    if (nfo.Attributes.HasFlag(FileAttributes.ReparsePoint))
                    {
                        Directory.Delete(output + directory);
                    }
                }
                provider.CreateLink(output + directory, input + directory, LinkType.Junction);
                ProgressBar.PerformStep();
                lblCurrent.Text = (Int32.Parse(lblCurrent.Text) + 1).ToString();
            }
            foreach (string file_path in files)
            {
                string file = file_path.Substring(file_path.LastIndexOf('\\'));
                if (File.Exists(output + file))
                {
                    FileInfo nfo = new FileInfo(output + file);
                    if (nfo.Attributes.HasFlag(FileAttributes.ReparsePoint))
                    {
                        File.Delete(output + file);
                    }
                }
                provider.CreateLink(output + file, input + file, LinkType.Symbolic);
                ProgressBar.PerformStep();
                lblCurrent.Text = (Int32.Parse(lblCurrent.Text) + 1).ToString();
            }
        }
    }
}
