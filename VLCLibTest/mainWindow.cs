using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLCLibTest
{
    public partial class mainWindow : Form
    {
        /// <summary>
        /// VLC播放器
        /// </summary>
        public VLCBase player { get; private set; }
        public mainWindow()
        {
            InitializeComponent();
            string PLUGIN_PATH = Environment.CurrentDirectory + "\\plugins\\";
            Trace.WriteLine(PLUGIN_PATH);
            player = new VLCBase(PLUGIN_PATH);
            player.SetRenderWindow((int)panel_renderWindow.Handle);
            //player.LoadFile("br.h264");
            player.LoadURL("udp://@192.168.1.117:9090");
            player.Play();
        }

        
    }
}
