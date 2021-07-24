using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;


namespace GameMuladores
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Arguments = "\"G:\\juegos\\The Legend of Zelda Skyward Sword HD [NSP]\\The Legend of Zelda Skyward Sword HD.nsp\"";
            info.FileName = @"C:\Users\JAVIER\AppData\Local\yuzu\yuzu-windows-msvc\yuzu.exe";
            info.UseShellExecute = true;
            System.Diagnostics.Process.Start(info);
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Arguments = "\"G:\\juegos\\Emulacion\\Nintendo 3ds\\roomm\\Kirby Battle Royale .3ds\"";
            info.FileName = @"C:\Users\JAVIER\AppData\Local\Citra\canary-mingw\citra-qt.exe";
            info.UseShellExecute = true;
            System.Diagnostics.Process.Start(info);
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Arguments = "-g \"G:\\juegos\\Emulacion\\Nintendo Wii u\\room\\SUPER MARIO 3D WORLD [ARDP0101]\\code\\RedCarpet.rpx\"";
            info.FileName = @"G:\juegos\Emulacion\Nintendo Wii u\cemu_1.17.0\cemu_1.17.0\Cemu.exe";
            MessageBox.Show("-g \"G:\\juegos\\Emulacion\\Nintendo Wii u\\room\\SUPER MARIO 3D WORLD [ARDP0101]\\code\\RedCarpet.rpx\"");
            info.UseShellExecute = true;
            System.Diagnostics.Process.Start(info);
        }
    }
}
