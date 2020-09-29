using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sxlib;
using sxlib.Specialized;
namespace ApeShitV2
{
    public partial class Form1 : Form
    {
        public bool Attached;
        public bool Loaded;
        public static string Direct = Directory.GetCurrentDirectory();
        public Form1()
        {
            InitializeComponent();

            Functions.Lib = SxLib.InitializeWinForms(this, Direct);
            Functions.Lib.Load();
            Functions.Lib.LoadEvent += SynLoadEvent;
        }
        private void SynLoadEvent(SxLibBase.SynLoadEvents Event, object Param)
        {
            switch(Event)
            {
                case SxLibBase.SynLoadEvents.CHECKING_WL:
                    this.AttachingLabel.ForeColor = Color.FromArgb(0, 0, 0);
                    this.AttachingLabel.Text = "Checking WL...";
                    return;
                case SxLibBase.SynLoadEvents.READY:
                    this.AttachingLabel.ForeColor = Color.FromArgb(0, 255, 0);
                    this.AttachingLabel.Text = "Ready to attach to Roblox!";
                    this.Loaded = true;
                    return;

            }
        }
        private void SynAttachEvent(SxLibBase.SynAttachEvents Event, object Param)
        {
            switch (Event)
            {
                case SxLibBase.SynAttachEvents.INJECTING:
                    this.AttachingLabel.ForeColor = Color.FromArgb(0, 0, 0);
                    this.AttachingLabel.Text = "Injecting...";
                    return;
                case SxLibBase.SynAttachEvents.READY:
                    this.AttachingLabel.ForeColor = Color.FromArgb(0, 255, 0);
                    this.AttachingLabel.Text = "Online";
                    return;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AttachButton_Click(object sender, EventArgs e)
        {
            Functions.Lib.Attach();
            Functions.Lib.AttachEvent += SynAttachEvent;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ExecutingBox.Text = "";
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            string script = this.ExecutingBox.Text;
            Functions.Lib.Execute(script);
        }

        private void TopMostToggle_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost ^= true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {

            //wassup
            OpenFileDialog opendialogfile = new OpenFileDialog();
            opendialogfile.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";
            opendialogfile.FilterIndex = 2;
            opendialogfile.RestoreDirectory = true;
            if (opendialogfile.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                ExecutingBox.Text = "";
                System.IO.Stream stream;
                if ((stream = opendialogfile.OpenFile()) == null)
                    return;
                using (stream)
                    this.ExecutingBox.Text = System.IO.File.ReadAllText(opendialogfile.FileName);
            }
            catch (Exception)
            {
                int num = (int)MessageBox.Show("An unexpected error has occured", "OOF!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Txt Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua|All Files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream s = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(s);
                sw.Write(ExecutingBox.Text);
                sw.Close();
            }

        }
    }
}
