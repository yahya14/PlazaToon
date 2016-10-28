using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PlazaToon
{
    public partial class MainForm : Form
    {
        private uint sistersAddr;
        private uint chairsAddr;
        private uint spykeAddr;
        private uint treeAddr;
        public static uint triparamSizeDefault = 0x3F800000;

        //arrays
        public static uint[] marieSize = new uint[9]        { 0x3EFA4D62, 0x80000000, 0xBF5F52B5, 0, 0x3F800000, 0x80000000, 0x3F5F52B5, 0, 0x3EFA4D62 };
        public static uint[] mariechairSize = new uint[9]   { 0x3EFA4D5D, 0, 0x3F5F52B4, 0x80000000, 0x3F800000, 0, 0xBF5F52B4, 0x80000000, 0x3EFA4D5D };
        public static uint[] callieSize = new uint[9]       { 0x3F7490F0, 0x80000000, 0xBE974E63, 0, 0x3F800000, 0x80000000, 0x3E974E63, 0, 0x3F7490F0 };
        public static uint[] calliechairSize = new uint[9]  { 0x3F7490F0, 0, 0x3E974E64, 0x80000000, 0x3F800000, 0, 0xBE974E64, 0x80000000, 0x3F7490F0 };
        public static uint[] spykeSize = new uint[9]        { 0x3F2EA60F, 0, 0x3F3B2C5C, 0x80000000, 0x3F800000, 0, 0xBF3B2C5C, 0x80000000, 0x3F2EA60F };
        //public static uint[] treeSize = new uint[3]         { 0x3F800000, 0x3F800000, 0x3F800000 };
        //public static uint[] juddSize = new uint[3]         { 0x3F800000, 0x3F800000, 0x3F800000 };

        public static uint[] calliePoint = new uint[3]    { 0x4372B58C, 0x42840000, 0xC3118F23 };
        public static uint[] mariePoint = new uint[3]     { 0x4381775F, 0x42840000, 0xC305AC3A };
        public static uint[] juddPoint = new uint[3]      { 0x422B2428, 0x3E4CCCC7, 0xC3788B42 };
        public static uint[] spykePoint = new uint[3]     { 0x43C09762, 0x00000000, 0xC2FB6430 };
        public static uint[] treePoint = new uint[3]      { 0xC31F9663, 0x00000000, 0x42E39610 };
        public static uint[] originPoint = new uint[3]    { 0x00000000, 0x00000000, 0x00000000 };

        public static uint[] NPCSizeAddr = new uint[9];
        public static uint[] NPCSizeData = new uint[9];
        public static uint[] NPCPointData = new uint[9];

        public TCPGecko gecko = null;
        public MainForm()
        {
            InitializeComponent();
        }
        //Converters
        private uint pointer(uint addr, string sign, uint offset)
        {
            uint a;
            uint b;
            if (sign == "minus")
            {
                a = gecko.peek(addr) - offset;
                b = gecko.peek(a);
            }
            else
            {
                a = gecko.peek(addr) + offset;
                b = gecko.peek(a);
            }
            return b;
        }
        public static uint float2Hex(float fNum) //float to uint converter made by lean because he's bae
        {
            byte[] buffer = BitConverter.GetBytes(fNum);
            uint t1 = (uint)buffer[3];
            t1 <<= 8;
            t1 += buffer[2];
            t1 <<= 8;
            t1 += buffer[1];
            t1 <<= 8;
            t1 += buffer[0];
            return t1;
        }
        public static float hex2Float(uint val) //uint to float converter from the joyous amibu
        {
            return BitConverter.ToSingle(BitConverter.GetBytes(val), 0);
        }
        private void ConnectButton_Click(object sender, MouseEventArgs e)
        {
            ////TCPGecko Connection area
            //This becomes both a connect and a recalc button
            if (gecko == null)
            {
                gecko = new TCPGecko(IPBox.Text, 7331);
                try
                {
                    gecko.Connect();
                }
                catch (ETCPGeckoException)
                {
                    gecko = null;
                    MessageBox.Show("Could not connect to TCPGecko.", "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                ConnectButton.Text = "Recalculate";
                ConnectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
                DisconnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
                sistersAddr = gecko.peek(0x1CAAAC50);
                chairsAddr = gecko.peek(0x1CAAAE70);
                spykeAddr = gecko.peek(0x1CAAAE78);
                treeAddr = gecko.peek(chairsAddr - 0x4F40);
                NPCInfoSize();
                numericBoxLoad();
            }
            else
            {
                sistersAddr = gecko.peek(0x1CAAAC50);
                chairsAddr = gecko.peek(0x1CAAAE70);
                spykeAddr = gecko.peek(0x1CAAAE78);
                treeAddr = gecko.peek(chairsAddr - 0x4F40);

                if (e.Button == MouseButtons.Right)
                {
                    Info.resetti();
                    //Callie
                    gecko.poke(sistersAddr + 0x328, callieSize[0]);
                    gecko.poke(sistersAddr + 0x330, callieSize[2]);
                    gecko.poke(sistersAddr + 0x33C, callieSize[4]);
                    gecko.poke(sistersAddr + 0x348, callieSize[6]);
                    gecko.poke(sistersAddr + 0x350, callieSize[8]);
                    //Callie's Chair
                    gecko.poke(chairsAddr + 0x6BC, calliechairSize[0]);
                    gecko.poke(chairsAddr + 0x6C4, calliechairSize[2]);
                    gecko.poke(chairsAddr + 0x6CC, calliechairSize[4]);
                    gecko.poke(chairsAddr + 0x6D4, calliechairSize[6]);
                    gecko.poke(chairsAddr + 0x6DC, calliechairSize[8]);
                    //Marie
                    gecko.poke(sistersAddr + 0x7BC, marieSize[0]);
                    gecko.poke(sistersAddr + 0x7C4, marieSize[2]);
                    gecko.poke(sistersAddr + 0x7D0, marieSize[4]);
                    gecko.poke(sistersAddr + 0x7DC, marieSize[6]);
                    gecko.poke(sistersAddr + 0x7E4, marieSize[8]);
                    //Marie's Chair
                    gecko.poke(chairsAddr + 0xAC0, mariechairSize[0]);
                    gecko.poke(chairsAddr + 0xAC8, mariechairSize[2]);
                    gecko.poke(chairsAddr + 0xAD0, mariechairSize[4]);
                    gecko.poke(chairsAddr + 0xAD8, mariechairSize[6]);
                    gecko.poke(chairsAddr + 0xAE0, mariechairSize[8]);
                    //Judd
                    gecko.poke(chairsAddr - 0xE44, triparamSizeDefault);
                    gecko.poke(chairsAddr - 0xE34, triparamSizeDefault);
                    gecko.poke(chairsAddr - 0xE24, triparamSizeDefault);
                    //Spyke
                    gecko.poke(spykeAddr - 0x538, spykeSize[0]);
                    gecko.poke(spykeAddr - 0x530, spykeSize[2]);
                    gecko.poke(spykeAddr - 0x528, spykeSize[4]);
                    gecko.poke(spykeAddr - 0x520, spykeSize[6]);
                    gecko.poke(spykeAddr - 0x518, spykeSize[8]);
                    //Tree
                    gecko.poke(treeAddr + 0x3754, triparamSizeDefault);
                    gecko.poke(treeAddr + 0x3744, triparamSizeDefault);
                    gecko.poke(treeAddr + 0x3734, triparamSizeDefault);

                    numericUpDown1.Value = 1;
                    numericUpDown2.Value = 1;
                    numericUpDown3.Value = 1;
                    numericUpDown4.Value = 1;
                    numericUpDown5.Value = 1;
                }

            }
        }
        private void DisconnButton_Click(object sender, MouseEventArgs e)
        {
            if (gecko != null)
            {
                gecko.Disconnect();
                gecko = null;
                ConnectButton.Text = "Connect";
                ConnectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(200)))), ((int)(((byte)(92)))));
                DisconnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            }
        }
        private void NPCInfoSize()
        {
            if (NPCcomboBox.Text == "Callie")
            {
                NPCSizeData[0] = callieSize[0];
                NPCSizeData[1] = callieSize[2];
                NPCSizeData[2] = callieSize[4];
                NPCSizeData[3] = callieSize[6];
                NPCSizeData[4] = callieSize[8];
                NPCSizeAddr[0] = sistersAddr + 0x328;
                NPCSizeAddr[1] = sistersAddr + 0x330;
                NPCSizeAddr[2] = sistersAddr + 0x33C;
                NPCSizeAddr[3] = sistersAddr + 0x348;
                NPCSizeAddr[4] = sistersAddr + 0x350;
                NPCPointData[0] = sistersAddr + 0x334;
                NPCPointData[1] = sistersAddr + 0x344;
                NPCPointData[2] = sistersAddr + 0x354;
            }
            else if (NPCcomboBox.Text == "Callie's Chair")
            {
                NPCSizeData[0] = calliechairSize[0];
                NPCSizeData[1] = calliechairSize[2];
                NPCSizeData[2] = calliechairSize[4];
                NPCSizeData[3] = calliechairSize[6];
                NPCSizeData[4] = calliechairSize[8];
                NPCSizeAddr[0] = chairsAddr + 0x6BC;
                NPCSizeAddr[1] = chairsAddr + 0x6C4;
                NPCSizeAddr[2] = chairsAddr + 0x6CC;
                NPCSizeAddr[3] = chairsAddr + 0x6D4;
                NPCSizeAddr[4] = chairsAddr + 0x6DC;
                NPCPointData[0] = chairsAddr + 0x6E0;
                NPCPointData[1] = chairsAddr + 0x6E4;
                NPCPointData[2] = chairsAddr + 0x6E8;
            }
            else if (NPCcomboBox.Text == "Marie")
            {
                NPCSizeData[0] = marieSize[0];
                NPCSizeData[1] = marieSize[2];
                NPCSizeData[2] = marieSize[4];
                NPCSizeData[3] = marieSize[6];
                NPCSizeData[4] = marieSize[8];
                NPCSizeAddr[0] = sistersAddr + 0x7BC;
                NPCSizeAddr[1] = sistersAddr + 0x7C4;
                NPCSizeAddr[2] = sistersAddr + 0x7D0;
                NPCSizeAddr[3] = sistersAddr + 0x7DC;
                NPCSizeAddr[4] = sistersAddr + 0x7E4;
                NPCPointData[0] = sistersAddr + 0x7C8;
                NPCPointData[1] = sistersAddr + 0x7D8;
                NPCPointData[2] = sistersAddr + 0x7E8;

            }
            else if (NPCcomboBox.Text == "Marie's Chair")
            {
                NPCSizeData[0] = mariechairSize[0];
                NPCSizeData[1] = mariechairSize[2];
                NPCSizeData[2] = mariechairSize[4];
                NPCSizeData[3] = mariechairSize[6];
                NPCSizeData[4] = mariechairSize[8];
                NPCSizeAddr[0] = chairsAddr + 0xAC0;
                NPCSizeAddr[1] = chairsAddr + 0xAC8;
                NPCSizeAddr[2] = chairsAddr + 0xAD0;
                NPCSizeAddr[3] = chairsAddr + 0xAD8;
                NPCSizeAddr[4] = chairsAddr + 0xAE0;
                NPCPointData[0] = chairsAddr + 0xAE4;
                NPCPointData[1] = chairsAddr + 0xAE8;
                NPCPointData[2] = chairsAddr + 0xAF0;
            }
            else if (NPCcomboBox.Text == "Judd")
            {
                NPCSizeData[0] = triparamSizeDefault;
                NPCSizeData[1] = triparamSizeDefault;
                NPCSizeData[2] = triparamSizeDefault;
                NPCSizeAddr[0] = chairsAddr - 0xE44;
                NPCSizeAddr[1] = chairsAddr - 0xE34;
                NPCSizeAddr[2] = chairsAddr - 0xE24;
                NPCPointData[0] = chairsAddr - 0xE20;
                NPCPointData[1] = chairsAddr - 0xE1C;
                NPCPointData[2] = chairsAddr - 0xE18;

            }
            else if (NPCcomboBox.Text == "Spyke")
            {
                NPCSizeData[0] = spykeSize[0];
                NPCSizeData[1] = spykeSize[2];
                NPCSizeData[2] = spykeSize[4];
                NPCSizeData[3] = spykeSize[6];
                NPCSizeData[4] = spykeSize[8];
                NPCSizeAddr[0] = spykeAddr - 0x538;
                NPCSizeAddr[1] = spykeAddr - 0x530;
                NPCSizeAddr[2] = spykeAddr - 0x528;
                NPCSizeAddr[3] = spykeAddr - 0x520;
                NPCSizeAddr[4] = spykeAddr - 0x518;
                NPCPointData[0] = chairsAddr - 0x514;
                NPCPointData[1] = chairsAddr - 0x510;
                NPCPointData[2] = chairsAddr - 0x50C;
            }
            else if (NPCcomboBox.Text == "Tree")
            {
                NPCSizeData[0] = triparamSizeDefault;
                NPCSizeData[1] = triparamSizeDefault;
                NPCSizeData[2] = triparamSizeDefault;
                NPCSizeAddr[0] = treeAddr - 0x3754;
                NPCSizeAddr[1] = treeAddr - 0x3744;
                NPCSizeAddr[2] = treeAddr - 0x3734;
                NPCPointData[0] = treeAddr - 0x3730;
                NPCPointData[1] = treeAddr - 0x372C;
                NPCPointData[2] = treeAddr - 0x3728;
            }
        }
        private void numericBoxLoad()
        {
            if (NPCcomboBox.Text == "Callie")
            {
                masternumericUpDown.Value = Info.callieInfoSizeMaster;
                numericUpDown1.Value = Info.callieInfoSize1;
                numericUpDown2.Value = Info.callieInfoSize2;
                numericUpDown3.Value = Info.callieInfoSize3;
                numericUpDown4.Value = Info.callieInfoSize4;
                numericUpDown5.Value = Info.callieInfoSize5;

                locnumericUpDown1.Value = Info.callieInfoPoint1;
                locnumericUpDown2.Value = Info.callieInfoPoint2;
                locnumericUpDown3.Value = Info.callieInfoPoint3;
            }
            else if (NPCcomboBox.Text == "Callie's Chair")
            {
                masternumericUpDown.Value = Info.callieChairInfoSizeMaster;
                numericUpDown1.Value = Info.callieChairInfoSize1;
                numericUpDown2.Value = Info.callieChairInfoSize2;
                numericUpDown3.Value = Info.callieChairInfoSize3;
                numericUpDown4.Value = Info.callieChairInfoSize4;
                numericUpDown5.Value = Info.callieChairInfoSize5;

                locnumericUpDown1.Value = Info.callieChairInfoPoint1;
                locnumericUpDown2.Value = Info.callieChairInfoPoint2;
                locnumericUpDown3.Value = Info.callieChairInfoPoint3;

            }
            else if (NPCcomboBox.Text == "Marie")
            {
                masternumericUpDown.Value = Info.marieInfoSizeMaster;
                numericUpDown1.Value = Info.marieInfoSize1;
                numericUpDown2.Value = Info.marieInfoSize2;
                numericUpDown3.Value = Info.marieInfoSize3;
                numericUpDown4.Value = Info.marieInfoSize4;
                numericUpDown5.Value = Info.marieInfoSize5;

                locnumericUpDown1.Value = Info.marieInfoPoint1;
                locnumericUpDown2.Value = Info.marieInfoPoint2;
                locnumericUpDown3.Value = Info.marieInfoPoint3;

            }
            else if (NPCcomboBox.Text == "Marie's Chair")
            {
                masternumericUpDown.Value = Info.marieChairInfoSizeMaster;
                numericUpDown1.Value = Info.marieChairInfoSize1;
                numericUpDown2.Value = Info.marieChairInfoSize2;
                numericUpDown3.Value = Info.marieChairInfoSize3;
                numericUpDown4.Value = Info.marieChairInfoSize4;
                numericUpDown5.Value = Info.marieChairInfoSize5;

                locnumericUpDown1.Value = Info.marieChairInfoPoint1;
                locnumericUpDown2.Value = Info.marieChairInfoPoint2;
                locnumericUpDown3.Value = Info.marieChairInfoPoint3;
            }
            else if (NPCcomboBox.Text == "Judd")
            {
                masternumericUpDown.Value = Info.juddInfoSizeMaster;
                numericUpDown1.Value = Info.juddInfoSize1;
                numericUpDown2.Value = Info.juddInfoSize2;
                numericUpDown3.Value = Info.juddInfoSize3;

                locnumericUpDown1.Value = Info.juddInfoPoint1;
                locnumericUpDown2.Value = Info.juddInfoPoint2;
                locnumericUpDown3.Value = Info.juddInfoPoint3;

            }
            else if (NPCcomboBox.Text == "Spyke")
            {
                masternumericUpDown.Value = Info.spykeInfoSizeMaster;
                numericUpDown1.Value = Info.spykeInfoSize1;
                numericUpDown2.Value = Info.spykeInfoSize2;
                numericUpDown3.Value = Info.spykeInfoSize3;
                numericUpDown4.Value = Info.spykeInfoSize4;
                numericUpDown5.Value = Info.spykeInfoSize5;

                locnumericUpDown1.Value = Info.spykeInfoPoint1;
                locnumericUpDown2.Value = Info.spykeInfoPoint2;
                locnumericUpDown3.Value = Info.spykeInfoPoint3;
            }
            else if (NPCcomboBox.Text == "Tree")
            {
                masternumericUpDown.Value = Info.treeInfoSizeMaster;
                numericUpDown1.Value = Info.treeInfoSize1;
                numericUpDown2.Value = Info.treeInfoSize2;
                numericUpDown3.Value = Info.treeInfoSize3;

                locnumericUpDown1.Value = Info.treeInfoPoint1;
                locnumericUpDown2.Value = Info.treeInfoPoint2;
                locnumericUpDown3.Value = Info.treeInfoPoint3;
            }
        }
        
        private void NPCcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NPCInfoSize();
            numericBoxLoad();
            if (NPCcomboBox.Text == "Judd" || NPCcomboBox.Text == "Tree")
            {
                numericUpDown2.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else
            {
                numericUpDown2.Enabled = true;
                numericUpDown5.Enabled = true;
            }
        }

        private void NPCsav() //saves NPC values
        {
            if (NPCcomboBox.Text == "Callie")
            {
                Info.callieInfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                Info.callieInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
            }
            else if (NPCcomboBox.Text == "Callie's Chair")
            {
                Info.callieChairInfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                Info.callieChairInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);

            }
            else if (NPCcomboBox.Text == "Marie")
            {
                Info.marieInfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                Info.marieInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);

            }
            else if (NPCcomboBox.Text == "Marie's Chair")
            {
                Info.marieChairInfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                Info.marieChairInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);

            }
            else if (NPCcomboBox.Text == "Judd")
            {
                Info.juddInfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown2.Value);
                Info.juddInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);

            }
            else if (NPCcomboBox.Text == "Spyke")
            {
                Info.spykeInfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                Info.spykeInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);

            }
            else if (NPCcomboBox.Text == "Tree")
            {
                Info.treeInfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown2.Value);
                Info.treeInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);

            }
        }
        private void masterScaleSav() //saves NPC values
        {
            if (NPCcomboBox.Text == "Callie")
            {
                Info.callieMasterScale(masternumericUpDown.Value);
            }
            else if (NPCcomboBox.Text == "Callie's Chair")
            {
                Info.callieChairMasterScale(masternumericUpDown.Value);
            }
            else if (NPCcomboBox.Text == "Marie")
            {
                Info.marieMasterScale(masternumericUpDown.Value);
            }
            else if (NPCcomboBox.Text == "Marie's Chair")
            {
                Info.marieChairMasterScale(masternumericUpDown.Value);
            }
            else if (NPCcomboBox.Text == "Judd")
            {
                Info.juddMasterScale(masternumericUpDown.Value);
            }
            else if (NPCcomboBox.Text == "Spyke")
            {
                Info.spykeMasterScale(masternumericUpDown.Value);
            }
            else if (NPCcomboBox.Text == "Tree")
            {
                Info.treeMasterScale(masternumericUpDown.Value);
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var x1 = hex2Float(NPCSizeData[0]) * Convert.ToSingle(numericUpDown1.Value);
            if (gecko != null)
            {
                gecko.poke(NPCSizeAddr[0], float2Hex(x1));
            }
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            var y = hex2Float(NPCSizeData[1]) * Convert.ToSingle(numericUpDown2.Value);
            if (gecko != null)
            {
                gecko.poke(NPCSizeAddr[1], float2Hex(y));
            }
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            var x2 = hex2Float(NPCSizeData[2]) * Convert.ToSingle(numericUpDown3.Value);
            if (gecko != null)
            {
                gecko.poke(NPCSizeAddr[2], float2Hex(x2));
            }
        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            var y = hex2Float(NPCSizeData[3]) * Convert.ToSingle(numericUpDown4.Value);
            if (gecko != null)
            {
                gecko.poke(NPCSizeAddr[3], float2Hex(y));
            }
        }
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            var y = hex2Float(NPCSizeData[4]) * Convert.ToSingle(numericUpDown5.Value);
            if (gecko != null)
            {
                gecko.poke(NPCSizeAddr[4], float2Hex(y));
            }
        }

        private void masternumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (NPCcomboBox.Text == "Judd" || NPCcomboBox.Text == "Tree")
            {
                numericUpDown1.Value = masternumericUpDown.Value;
                numericUpDown4.Value = masternumericUpDown.Value;
                numericUpDown3.Value = masternumericUpDown.Value;
            }
            else
            {
                numericUpDown1.Value = masternumericUpDown.Value;
                numericUpDown2.Value = masternumericUpDown.Value;
                numericUpDown3.Value = masternumericUpDown.Value;
                numericUpDown4.Value = masternumericUpDown.Value;
                numericUpDown5.Value = masternumericUpDown.Value;
            }
        }
        private void locnumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (gecko != null)
            {
                gecko.poke(NPCPointData[0], float2Hex(Convert.ToSingle(locnumericUpDown1.Value)));
            }
        }
        private void locnumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (gecko != null)
            { 
            gecko.poke(NPCPointData[1], float2Hex(Convert.ToSingle(locnumericUpDown2.Value)));
            }

        }
        private void locnumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (gecko != null)
            {
                gecko.poke(NPCPointData[2], float2Hex(Convert.ToSingle(locnumericUpDown3.Value)));
            }
        }

        //saves NPC values with every click of the numeric boxes
        private void numericUpDown1_MouseUp(object sender, MouseEventArgs e) { NPCsav(); }
        private void numericUpDown2_MouseUp(object sender, MouseEventArgs e) { NPCsav(); }
        private void numericUpDown3_MouseUp(object sender, MouseEventArgs e) { NPCsav(); }
        private void numericUpDown4_MouseUp(object sender, MouseEventArgs e) { NPCsav(); }
        private void numericUpDown5_MouseUp(object sender, MouseEventArgs e) { NPCsav(); }
        private void numericUpDown6_MouseUp(object sender, MouseEventArgs e) { NPCsav(); }
        private void locnumericUpDown1_MouseUp(object sender, MouseEventArgs e) { NPCsav(); }
        private void locnumericUpDown2_MouseUp(object sender, MouseEventArgs e) { NPCsav(); }
        private void locnumericUpDown3_MouseUp(object sender, MouseEventArgs e) { NPCsav(); }
        //you know what they say, always play it safe
        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e) { NPCsav(); }
        private void numericUpDown2_KeyUp(object sender, KeyEventArgs e) { NPCsav(); }
        private void numericUpDown3_KeyUp(object sender, KeyEventArgs e) { NPCsav(); }
        private void numericUpDown4_KeyUp(object sender, KeyEventArgs e) { NPCsav(); }
        private void numericUpDown5_KeyUp(object sender, KeyEventArgs e) { NPCsav(); }
        private void numericUpDown6_KeyUp(object sender, KeyEventArgs e) { NPCsav(); }
        private void locnumericUpDown1_KeyUp(object sender, KeyEventArgs e) { NPCsav(); }
        private void locnumericUpDown2_KeyUp(object sender, KeyEventArgs e) { NPCsav(); }
        private void locnumericUpDown3_KeyUp(object sender, KeyEventArgs e) { NPCsav(); }
        //Master scale seperate save
        private void masternumericUpDown_KeyUp(object sender, KeyEventArgs e) { masterScaleSav(); }
        private void masternumericUpDown_MouseUp(object sender, MouseEventArgs e) { masterScaleSav(); }
    }
}
