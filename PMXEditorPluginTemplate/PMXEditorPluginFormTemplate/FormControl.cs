using PEPExtensions;
using PEPlugin;
using PEPlugin.Pmx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class FormControl : Form
    {
        IPERunArgs Args { get; }

        public FormControl(IPERunArgs args)
        {
            Args = args;

            InitializeComponent();
            Reload();
        }

        internal void Reload()
        {
            // TODO: プラグインの再読み込み処理を記述します。
        }
    }
}
