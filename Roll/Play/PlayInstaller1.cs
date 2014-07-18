using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace Roll.Play
{
    [RunInstaller(true)]
    public partial class PlayInstaller1 : System.Configuration.Install.Installer
    {
        public PlayInstaller1()
        {
            InitializeComponent();
        }
    }
}
