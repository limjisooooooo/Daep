using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daep
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IniFile ini = new IniFile();
            ini["daep"]["server"] = txtServer.Text;
            ini["daep"]["port"] = int.Parse(txtPort.Text);
            ini["daep"]["database"] = txtDataBase.Text;
            ini["daep"]["user"] = txtUser.Text;
            ini["daep"]["passwd"] = txtPasswd.Text;
            ini.Save("daep.ini");
            dbWork.connStr = $"server={txtServer.Text};port={int.Parse(txtPort.Text)};database={txtDataBase.Text};user={txtUser.Text};password={txtPasswd.Text};Allow User Variables=True;";
            MessageBox.Show("저장되었습니다.");
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            IniFile ini = new IniFile();
            try
            {
                ini.Load("daep.ini");
            }
            catch (System.IO.FileNotFoundException)
            {
                ini["daep"]["server"] = "127.0.0.1";
                ini["daep"]["port"] = 3306;
                ini["daep"]["database"] = "daep";
                ini["daep"]["user"] = "root";
                ini["daep"]["passwd"] = "root";
                ini.Save("daep.ini");
            }
            finally
            {
                txtServer.Text = ini["daep"]["server"].ToString();
                txtPort.Text = ini["daep"]["port"].ToString();
                txtDataBase.Text = ini["daep"]["database"].ToString();
                txtUser.Text = ini["daep"]["user"].ToString();
                txtPasswd.Text = ini["daep"]["passwd"].ToString();
                //dbWork.connStr = $"server={server};port={port};database={database};user={user};password={passwd};Allow User Variables=True;";
            }
        }
    }
}
