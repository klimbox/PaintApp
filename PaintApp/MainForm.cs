using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paint.Presenter.Views;
using System.Globalization;
using System.Threading;


namespace Paint.UI
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-UA");

            InitializeComponent();
        }

    }
}
