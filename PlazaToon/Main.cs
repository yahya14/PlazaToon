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
    public partial class Main : Form
    {
        public static uint sistersAddr;
        public static uint NPCAddr;
        public static uint spykeAddr;
        public static uint manholeAddr;
        public static string NPCText;
        public static uint triparamSizeDefault = 0x3F800000;

        //arrays
        //Note: Train array is not neccessary here
        public static uint[] amiiboSize = new uint[9] { 0xBF4201FA, 0, 0x3F270623, 0, 0x3F800000, 0, 0xBF270623, 0, 0xBF4201FA };
        public static uint[] balloonSize = new uint[9] { 0x3F776556, 0, 0xBEAF1D43, 0, 0x3F800000, 0, 0x3EAF1D43, 0, 0x3F776556 };
        public static uint[] postSize = new uint[9] { 0x3F708FB2, 0, 0x3F270623, 0, 0x3F800000, 0, 0xBF270623, 0, 0x3F708FB2 };
        public static uint[] weaponsignSize = new uint[9] { 0x3F742779, 0, 0xBE99F1CE, 0, 0x3F800000, 0, 0x3E99F1CE, 0, 0x3F742779 };
        public static uint[] shellSize = new uint[9] { 0xBF5ADC22, 0, 0xBF04CD49, 0, 0x3F800000, 0, 0x3F04CD49, 0, 0xBF5ADC22 };
        public static uint[] marieSize = new uint[9] { 0x3EFA4D62, 0, 0xBE83A00A, 0, 0x3F800000, 0, 0x3E83A00A, 0, 0x3EFA4D62 };
        public static uint[] mariechairSize = new uint[9] { 0x3EFA4D5D, 0, 0x3F5F52B4, 0, 0x3F800000, 0, 0xBF5F52B4, 0, 0x3EFA4D5D };
        public static uint[] callieSize = new uint[9] { 0x3F7490F0, 0, 0xBE974E63, 0, 0x3F800000, 0, 0x3E974E63, 0, 0x3F7490F0 };
        public static uint[] calliechairSize = new uint[9] { 0x3F7490F0, 0, 0x3E974E64, 0, 0x3F800000, 0, 0xBE974E64, 0, 0x3F7490F0 };
        public static uint[] spykeSize = new uint[9] { 0x3F2EA60F, 0, 0x3F3B2C5C, 0, 0x3F800000, 0, 0xBF3B2C5C, 0, 0x3F2EA60F };
        public static uint[] arcadeSize = new uint[9] { 0xBE882C60, 0, 0xBF76C799, 0, 0x3F800000, 0, 0x3F76C799, 0, 0xBE882C60 };
        //public static uint[] treeSize = new uint[3]       { 0x3F800000, 0x3F800000, 0x3F800000 };
        //public static uint[] juddSize = new uint[3]       { 0x3F800000, 0x3F800000, 0x3F800000 };

        public static uint[] calliePoint = new uint[3] { 0x4372B58C, 0x42840000, 0xC3118F23 };
        public static uint[] mariePoint = new uint[3] { 0x4381775F, 0x42840000, 0xC305AC3A };
        public static uint[] juddPoint = new uint[3] { 0x422B2428, 0x3E4CCCC7, 0xC3788B42 };
        public static uint[] spykePoint = new uint[3] { 0x43C09762, 0x00000000, 0xC2FB6430 };
        public static uint[] shellPoint = new uint[3] { 0x43BF80FA, 0x00000000, 0xC2F35EC0 };
        public static uint[] amiiboPoint = new uint[3] { 0x4374D200, 0x00000000, 0x437E9400 };
        public static uint[] balloonPoint = new uint[3] { 0xC328370C, 0x41300000, 0xC2612360 };
        public static uint[] postPoint = new uint[3] { 0xC24688B9, 0x00000000, 0xC379BC00 };
        public static uint[] treePoint = new uint[3] { 0xC31F9663, 0x00000000, 0x42E39610 };
        public static uint[] tree2Point = new uint[3] { 0x4389D236, 0x3FB80000, 0x43B6BB6E };
        public static uint[] tree3Point = new uint[3] { 0x43AE55BC, 0x3FC82E70, 0x43AEB932 };
        public static uint[] tree4Point = new uint[3] { 0x43D8DA7B, 0x40AA7A2F, 0x438A87D9 };
        public static uint[] arcadePoint = new uint[3] { 0xC35546E2, 0x3DCCCCC7, 0x43152D36 };
        public static uint[] manholePoint = new uint[3] { 0x42FEDB3C, 0x3E99999A, 0xC366BFA6 };
        public static uint[] originPoint = new uint[3] { 0x00000000, 0x00000000, 0x00000000 };
        public static uint[] weaponsignPoint = new uint[3] { 0xC2E61AF8, 0x00000000, 0xC33DCB02 };

        public static uint[] NPCSizeAddr = new uint[9];
        public static uint[] NPCSizeData = new uint[9];
        public static uint[] NPCPointData = new uint[9];

        public static TCPGecko gecko = null;
        private uint diff;
        Control rattata = null;

        public Main()
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
        private void ConnectButton_Click(object sender, EventArgs e)
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
                var check = gecko.peek(0x1CAA74BC);
                if (check == 0) //Geckiine
                {
                    diff = 0x4C0;
                    ConnectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(210))))); //dark blue change indicating geckiine
                }
                else if (check == 0xFFFFFFFF && gecko.peek(0x12CE3DA0) != 0x000003F2) //Loadiine
                {
                    diff = 0;
                    ConnectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(145)))), ((int)(((byte)(245))))); //light blue change indicating Loadiine
                    //Console.WriteLine("pointer's are for Loadiine");
                }
                else //Codehandler
                {
                    //diff = placeholder;
                    //Console.WriteLine("pointer's are for the Codehandler...or none of the above");
                }
                if (autoModeToolStripMenuItem.Checked == true)
                {
                    ConnectButton.Text = "Recalculate";
                }
                DisconnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));

                recalculateAddr();
                NPCInfoSize();
                numericBoxLoad();
                NPCcomboBox.Focus();
            }
            else
            {
                if (ConnectButton.Text == "Recalculate")
                {
                    msgLabel.Text = "Addresses have been recalculated.";
                    msgLabel.Visible = true;
                    msgTimer.Stop();
                    msgTimer.Start();
                }
                recalculateAddr();
                NPCInfoSize();
            }
        }
        private void recalculateAddr()
        {
            sistersAddr = gecko.peek(0x1CAAAC50 - diff);
            manholeAddr = gecko.peek(0x1CAAAE68 - diff);
            NPCAddr = gecko.peek(0x1CAAAE70 - diff);
            spykeAddr = gecko.peek(0x1CAAAE78 - diff);
        }
        private void IPBox_KeyDown(object sender, KeyEventArgs e) //User can press Enter to connect
        {
            if (e.KeyCode.ToString() == "Return")
            {
                ConnectButton_Click(sender, e);
            }
        }
        private void DisconnButton_Click(object sender, EventArgs e)
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
        private void resetAllToolStripMenuItem_Click(object sender, EventArgs e) //resets all variables, sizes and locations in-game to default
        {
            var confirmResult = MessageBox.Show("Are you sure you want to reset the size and location for all NPCs?", "Reset All ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (gecko != null && confirmResult == DialogResult.Yes) //confirmation to reset
            {
                Info.resetti();
                recalculateAddr();
                NPCInfoSize();
                numericBoxLoad();
                msgLabel.Text = "All settings has resetted to default.";
                msgLabel.Visible = true;
                msgTimer.Stop();
                msgTimer.Start();
            }
            else if (confirmResult == DialogResult.No) { }
            else
            {
                MessageBox.Show("Size and location has not reset successfully.", "Reset All Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
        }
        private void msgTimer_Tick(object sender, EventArgs e) //displays that addresses have been recalculated
        {
            msgLabel.Visible = false;
            msgTimer.Enabled = false;
        }
        
        private void NPCcomboBox_SelectedIndexChanged(object sender, EventArgs e) //controls Enabled events
        {
            if (NPCcomboBox.Text == "Judd" || NPCcomboBox.Text == "Tree 1" || NPCcomboBox.Text == "Tree 2" || NPCcomboBox.Text == "Tree 3" || NPCcomboBox.Text == "Tree 4" || NPCcomboBox.Text == "Manhole")
            {
                numericUpDown2.Enabled = false;
                numericUpDown5.Enabled = false;
                numericUpDown1.Increment = (decimal)0.25;
                numericUpDown3.Increment = (decimal)0.25;
                numericUpDown4.Increment = (decimal)0.25;
                masternumericUpDown.Increment = (decimal)0.25;
            }
            else if (NPCcomboBox.Text == "Train")
            {
                numericUpDown2.Enabled = false;
                numericUpDown5.Enabled = false;
                numericUpDown1.Increment = (decimal)0.05;
                numericUpDown3.Increment = (decimal)0.05;
                numericUpDown4.Increment = (decimal)0.05;
                masternumericUpDown.Increment = (decimal)0.05;
            }
            else
            {
                numericUpDown2.Enabled = true;
                numericUpDown5.Enabled = true;
                numericUpDown1.Increment = (decimal)0.25;
                numericUpDown3.Increment = (decimal)0.25;
                numericUpDown4.Increment = (decimal)0.25;
                masternumericUpDown.Increment = (decimal)0.25;
            }
            NPCInfoSize();
            numericBoxLoad();
        }

        private void NPCcomboBox_MouseUp(object sender, MouseEventArgs e) { rattata = (Control)sender; }

        //several size numeric boxes
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (oneandtwoCheckBox.Checked == true && numericUpDown2.Enabled == true)
            {
                numericUpDown2.Value = numericUpDown1.Value;
            }
            scaleUpdate1();
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            scaleUpdate3();
        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (oneandtwoCheckBox.Checked == true && numericUpDown5.Enabled == true)
            {
                numericUpDown5.Value = numericUpDown4.Value;
            }
            scaleUpdate4();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (oneandtwoCheckBox.Checked == true && numericUpDown1.Enabled == true)
            {
                numericUpDown1.Value = numericUpDown2.Value;
            }
            scaleUpdate2();
        }
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (oneandtwoCheckBox.Checked == true && numericUpDown4.Enabled == true)
            {
                numericUpDown4.Value = numericUpDown5.Value;
            }
            scaleUpdate5();
        }
        
        //several location numeric boxes
        private void locnumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            locUpdate1();
        }
        private void locnumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            locUpdate2();
        }
        private void locnumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            locUpdate3();
        }

        //master numeric box
        private void masternumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (NPCcomboBox.Text == "Judd" || NPCcomboBox.Text == "Train" || NPCcomboBox.Text == "Tree 1" || NPCcomboBox.Text == "Tree 2" || NPCcomboBox.Text == "Tree 3" || NPCcomboBox.Text == "Tree 4" || NPCcomboBox.Text == "Manhole")
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

        //manual buttons
        private void pokeScaleButton_Click(object sender, EventArgs e)
        {
            if (gecko != null) { recalculateAddr(); msgLabel.Text = "All scale values have poked."; }
            else { msgLabel.Text = "No connection has established for poking."; }
            msgLabel.Visible = true;
            msgTimer.Stop();
            msgTimer.Start();
            scaleUpdate1();
            scaleUpdate2();
            scaleUpdate3();
            scaleUpdate4();
            scaleUpdate5();
            if (rattata != null) { rattata.Focus(); }
        }
        private void pokeLocButton_Click(object sender, EventArgs e)
        {
            if (gecko != null) { recalculateAddr(); msgLabel.Text = "All location values have poked."; }
            else { msgLabel.Text = "No connection has established for poking."; }
            msgLabel.Visible = true;
            msgTimer.Stop();
            msgTimer.Start();
            locUpdate1();
            locUpdate2();
            locUpdate3();
            if (rattata != null) { rattata.Focus(); }
        }
        private void pokeBothButton_Click(object sender, EventArgs e)
        {
            pokeScaleButton_Click(sender, e);
            pokeLocButton_Click(sender, e);
            if (gecko != null) { msgLabel.Text = "All location and scale values have poked."; }
            else { msgLabel.Text = "No connection has established for poking."; }
            msgLabel.Visible = true;
            msgTimer.Stop();
            msgTimer.Start();
        }

        //saves NPC values with every click of the numeric boxes
        private void numericUpDown1_MouseUp(object sender, MouseEventArgs e) { NPCsav(); rattata = (Control)sender; }
        private void numericUpDown2_MouseUp(object sender, MouseEventArgs e) { NPCsav(); rattata = (Control)sender; }
        private void numericUpDown3_MouseUp(object sender, MouseEventArgs e) { NPCsav(); rattata = (Control)sender; }
        private void numericUpDown4_MouseUp(object sender, MouseEventArgs e) { NPCsav(); rattata = (Control)sender; }
        private void numericUpDown5_MouseUp(object sender, MouseEventArgs e) { NPCsav(); rattata = (Control)sender; }
        private void numericUpDown6_MouseUp(object sender, MouseEventArgs e) { NPCsav(); rattata = (Control)sender; }
        private void locnumericUpDown1_MouseUp(object sender, MouseEventArgs e) { NPCsav(); rattata = (Control)sender; }
        private void locnumericUpDown2_MouseUp(object sender, MouseEventArgs e) { NPCsav(); rattata = (Control)sender; }
        private void locnumericUpDown3_MouseUp(object sender, MouseEventArgs e) { NPCsav(); rattata = (Control)sender; }
        //you know what they say, always play it safe (with keydowns)
        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) { NPCsav(); } }
        private void numericUpDown2_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) { NPCsav(); } }
        private void numericUpDown3_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) { NPCsav(); } }
        private void numericUpDown4_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) { NPCsav(); } }
        private void numericUpDown5_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) { NPCsav(); } }
        private void numericUpDown6_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) { NPCsav(); } }
        private void locnumericUpDown1_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) { NPCsav(); } }
        private void locnumericUpDown2_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) { NPCsav(); } }
        private void locnumericUpDown3_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) { NPCsav(); } }
        //Master scale seperate save
        private void masternumericUpDown_MouseUp(object sender, MouseEventArgs e) { rattata = (Control)sender; masterScaleSav(); }
        private void masternumericUpDown_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) { masterScaleSav(); } }

        //click the labels to set the coords to 0
        private void locxlabel_Click(object sender, EventArgs e) { locnumericUpDown1.Value = 0; NPCsav(); }
        private void locyLabel_Click(object sender, EventArgs e) { locnumericUpDown2.Value = 0; NPCsav(); }
        private void loczLabel_Click(object sender, EventArgs e) { locnumericUpDown3.Value = 0; NPCsav(); }

        //manual mode switch
        private void autoModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autoModeToolStripMenuItem.Checked == false)
            {
                if (gecko != null) { ConnectButton.Text = "Recalculate"; }
                autoModeToolStripMenuItem.Checked = true;
                manualGroupBox.Visible = false;
                manualGroupBox.Location = new Point(3, 350);
                creditLabel.Location = new Point(6, 316);
                creatorLabel.Location = new Point(279, 316);
                Size = new Size(367, 371);

                numericUpDown1.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
                numericUpDown3.ValueChanged += new EventHandler(numericUpDown3_ValueChanged);
                numericUpDown4.ValueChanged += new EventHandler(numericUpDown4_ValueChanged);
                numericUpDown2.ValueChanged += new EventHandler(numericUpDown2_ValueChanged);
                numericUpDown5.ValueChanged += new EventHandler(numericUpDown5_ValueChanged);
                locnumericUpDown1.ValueChanged += new EventHandler(locnumericUpDown1_ValueChanged);
                locnumericUpDown2.ValueChanged += new EventHandler(locnumericUpDown2_ValueChanged);
                locnumericUpDown3.ValueChanged += new EventHandler(locnumericUpDown3_ValueChanged);

            }
            else if (autoModeToolStripMenuItem.Checked == true)
            {
                ConnectButton.Text = "Connect";
                autoModeToolStripMenuItem.Checked = false;
                manualGroupBox.Visible = true;
                manualGroupBox.Location = new Point(3, 316);
                creditLabel.Location = new Point(6, 366);
                creatorLabel.Location = new Point(279, 366);
                Size = new Size(367, 421);
                numericUpDown1.ValueChanged -= new EventHandler(numericUpDown1_ValueChanged);
                numericUpDown3.ValueChanged -= new EventHandler(numericUpDown3_ValueChanged);
                numericUpDown4.ValueChanged -= new EventHandler(numericUpDown4_ValueChanged);
                numericUpDown2.ValueChanged -= new EventHandler(numericUpDown2_ValueChanged);
                numericUpDown5.ValueChanged -= new EventHandler(numericUpDown5_ValueChanged);
                locnumericUpDown1.ValueChanged -= new EventHandler(locnumericUpDown1_ValueChanged);
                locnumericUpDown2.ValueChanged -= new EventHandler(locnumericUpDown2_ValueChanged);
                locnumericUpDown3.ValueChanged -= new EventHandler(locnumericUpDown3_ValueChanged);
            }
        }

        //help buttons PLACEHOLDER FOR NOW
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rattataToolStripMenuItem.Visible == false && comingSoonToolStripMenuItem.Visible == false)
            {
                msgLabel.Text = "Help is coming Soon™";
                msgLabel.Visible = true;
                msgTimer.Stop();
                msgTimer.Start();
            }
        }
        private void rattataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msgLabel.Text = "Help is coming Soon™";
            msgLabel.Visible = true;
            msgTimer.Stop();
            msgTimer.Start();
        }
        private void comingSoonToolStripMenuItem_Click(object sender, EventArgs e) { rattataToolStripMenuItem_Click(sender, e); }

        //OTHER created poke definitions
        private void scaleUpdate1()
        {
            var x1 = hex2Float(NPCSizeData[0]) * Convert.ToSingle(numericUpDown1.Value);
            if (gecko != null)
            {
                gecko.poke(NPCSizeAddr[0], float2Hex(x1));
            }
        }
        private void scaleUpdate2()
        {
            var x2 = hex2Float(NPCSizeData[1]) * Convert.ToSingle(numericUpDown2.Value);
            if (gecko != null)
            {
                gecko.poke(NPCSizeAddr[1], float2Hex(x2));
            }
        }
        private void scaleUpdate3()
        {
            var y = hex2Float(NPCSizeData[2]) * Convert.ToSingle(numericUpDown3.Value);
            if (gecko != null)
            {
                gecko.poke(NPCSizeAddr[2], float2Hex(y));
            }
        }
        private void scaleUpdate4()
        {
            var z1 = hex2Float(NPCSizeData[3]) * Convert.ToSingle(numericUpDown4.Value);
            if (gecko != null)
            {
                gecko.poke(NPCSizeAddr[3], float2Hex(z1));
            }
        }
        private void scaleUpdate5()
        {
            var z2 = hex2Float(NPCSizeData[4]) * Convert.ToSingle(numericUpDown5.Value);
            if (gecko != null)
            {
                gecko.poke(NPCSizeAddr[4], float2Hex(z2));
            }
        }
        private void locUpdate1()
        {
            if (gecko != null)
            {
                gecko.poke(NPCPointData[0], float2Hex(Convert.ToSingle(locnumericUpDown1.Value)));
            }
        }
        private void locUpdate2()
        {
            if (gecko != null)
            {
                gecko.poke(NPCPointData[1], float2Hex(Convert.ToSingle(locnumericUpDown2.Value)));
            }
        }
        private void locUpdate3()
        {
            if (gecko != null)
            {
                gecko.poke(NPCPointData[2], float2Hex(Convert.ToSingle(locnumericUpDown3.Value)));
            }
        }

        private void NPCInfoSize() //Where NPC Data is handled
        {
            switch (NPCcomboBox.Text)
            {
                case "Callie":
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
                        break;
                    }
                case "Callie's Chair":
                    {
                        NPCSizeData[0] = calliechairSize[0];
                        NPCSizeData[1] = calliechairSize[2];
                        NPCSizeData[2] = calliechairSize[4];
                        NPCSizeData[3] = calliechairSize[6];
                        NPCSizeData[4] = calliechairSize[8];
                        NPCSizeAddr[0] = NPCAddr + 0x6BC;
                        NPCSizeAddr[1] = NPCAddr + 0x6C4;
                        NPCSizeAddr[2] = NPCAddr + 0x6CC;
                        NPCSizeAddr[3] = NPCAddr + 0x6D4;
                        NPCSizeAddr[4] = NPCAddr + 0x6DC;
                        NPCPointData[0] = NPCAddr + 0x6E0;
                        NPCPointData[1] = NPCAddr + 0x6E4;
                        NPCPointData[2] = NPCAddr + 0x6E8;
                        break;
                    }
                case "Marie":
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
                        break;
                    }
                case "Marie's Chair":
                    {
                        NPCSizeData[0] = mariechairSize[0];
                        NPCSizeData[1] = mariechairSize[2];
                        NPCSizeData[2] = mariechairSize[4];
                        NPCSizeData[3] = mariechairSize[6];
                        NPCSizeData[4] = mariechairSize[8];
                        NPCSizeAddr[0] = NPCAddr + 0xAC0;
                        NPCSizeAddr[1] = NPCAddr + 0xAC8;
                        NPCSizeAddr[2] = NPCAddr + 0xAD0;
                        NPCSizeAddr[3] = NPCAddr + 0xAD8;
                        NPCSizeAddr[4] = NPCAddr + 0xAE0;
                        NPCPointData[0] = NPCAddr + 0xAE4;
                        NPCPointData[1] = NPCAddr + 0xAE8;
                        NPCPointData[2] = NPCAddr + 0xAEC;
                        break;
                    }
                case "Judd":
                    {
                        NPCSizeData[0] = triparamSizeDefault;
                        NPCSizeData[2] = triparamSizeDefault;
                        NPCSizeData[3] = triparamSizeDefault;
                        NPCSizeAddr[0] = NPCAddr - 0xE44;
                        NPCSizeAddr[2] = NPCAddr - 0xE34;
                        NPCSizeAddr[3] = NPCAddr - 0xE24;
                        NPCPointData[0] = NPCAddr - 0xE20;
                        NPCPointData[1] = NPCAddr - 0xE1C;
                        NPCPointData[2] = NPCAddr - 0xE18;
                        break;
                    }
                case "Spyke":
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
                        NPCPointData[0] = spykeAddr - 0x514;
                        NPCPointData[1] = spykeAddr - 0x510;
                        NPCPointData[2] = spykeAddr - 0x50C;
                        break;
                    }
                case "Sea Snails":
                    {
                        NPCSizeData[0] = shellSize[0];
                        NPCSizeData[1] = shellSize[2];
                        NPCSizeData[2] = shellSize[4];
                        NPCSizeData[3] = shellSize[6];
                        NPCSizeData[4] = shellSize[8];
                        NPCSizeAddr[0] = NPCAddr - 0x6798;
                        NPCSizeAddr[1] = NPCAddr - 0x6790;
                        NPCSizeAddr[2] = NPCAddr - 0x6788;
                        NPCSizeAddr[3] = NPCAddr - 0x6780;
                        NPCSizeAddr[4] = NPCAddr - 0x6778;
                        NPCPointData[0] = NPCAddr - 0x6774;
                        NPCPointData[1] = NPCAddr - 0x6770;
                        NPCPointData[2] = NPCAddr - 0x676C;
                        break;
                    }
                case "Train":
                    {
                        NPCSizeData[0] = triparamSizeDefault;
                        NPCSizeData[2] = triparamSizeDefault;
                        NPCSizeData[3] = triparamSizeDefault;
                        NPCSizeAddr[0] = NPCAddr - 0x9C2C;
                        NPCSizeAddr[2] = NPCAddr - 0x9C1C;
                        NPCSizeAddr[3] = NPCAddr - 0x9C0C;
                        NPCPointData[0] = NPCAddr - 0x9C08;
                        NPCPointData[1] = NPCAddr - 0x9C04;
                        NPCPointData[2] = NPCAddr - 0x9C00;
                        break;
                    }
                case "Amiibo Box":
                    {
                        NPCSizeData[0] = amiiboSize[0];
                        NPCSizeData[1] = amiiboSize[2];
                        NPCSizeData[2] = amiiboSize[4];
                        NPCSizeData[3] = amiiboSize[6];
                        NPCSizeData[4] = amiiboSize[8];
                        NPCSizeAddr[0] = NPCAddr - 0x608;
                        NPCSizeAddr[1] = NPCAddr - 0x600;
                        NPCSizeAddr[2] = NPCAddr - 0x5F8;
                        NPCSizeAddr[3] = NPCAddr - 0x5F0;
                        NPCSizeAddr[4] = NPCAddr - 0x5E8;
                        NPCPointData[0] = NPCAddr - 0x5E4;
                        NPCPointData[1] = NPCAddr - 0x5E0;
                        NPCPointData[2] = NPCAddr - 0x5DC;
                        break;
                    }
                case "Balloon":
                    {
                        NPCSizeData[0] = balloonSize[0];
                        NPCSizeData[1] = balloonSize[2];
                        NPCSizeData[2] = balloonSize[4];
                        NPCSizeData[3] = balloonSize[6];
                        NPCSizeData[4] = balloonSize[8];
                        NPCSizeAddr[0] = NPCAddr - 0x90D8;
                        NPCSizeAddr[1] = NPCAddr - 0x90D0;
                        NPCSizeAddr[2] = NPCAddr - 0x90C8;
                        NPCSizeAddr[3] = NPCAddr - 0x90C0;
                        NPCSizeAddr[4] = NPCAddr - 0x90B8;
                        NPCPointData[0] = NPCAddr - 0x90B4;
                        NPCPointData[1] = NPCAddr - 0x90B0;
                        NPCPointData[2] = NPCAddr - 0x90AC;
                        break;
                    }
                case "Miiverse Post":
                    {
                        NPCSizeData[0] = postSize[0];
                        NPCSizeData[1] = postSize[2];
                        NPCSizeData[2] = postSize[4];
                        NPCSizeData[3] = postSize[6];
                        NPCSizeData[4] = postSize[8];
                        NPCSizeAddr[0] = NPCAddr - 0x1884;
                        NPCSizeAddr[1] = NPCAddr - 0x187C;
                        NPCSizeAddr[2] = NPCAddr - 0x1874;
                        NPCSizeAddr[3] = NPCAddr - 0x186C;
                        NPCSizeAddr[4] = NPCAddr - 0x1864;
                        NPCPointData[0] = NPCAddr - 0x1860;
                        NPCPointData[1] = NPCAddr - 0x185C;
                        NPCPointData[2] = NPCAddr - 0x1858;
                        break;
                    }
                case "Tree 1":
                    {
                        NPCSizeData[0] = triparamSizeDefault;
                        NPCSizeData[2] = triparamSizeDefault;
                        NPCSizeData[3] = triparamSizeDefault;
                        NPCSizeAddr[0] = NPCAddr - 0x8688;
                        NPCSizeAddr[2] = NPCAddr - 0x8678;
                        NPCSizeAddr[3] = NPCAddr - 0x8668;
                        NPCPointData[0] = NPCAddr - 0x8664;
                        NPCPointData[1] = NPCAddr - 0x8660;
                        NPCPointData[2] = NPCAddr - 0x865C;
                        break;
                    }
                case "Tree 2":
                    {
                        NPCSizeData[0] = triparamSizeDefault;
                        NPCSizeData[2] = triparamSizeDefault;
                        NPCSizeData[3] = triparamSizeDefault;
                        NPCSizeAddr[0] = NPCAddr - 0x7C38;
                        NPCSizeAddr[2] = NPCAddr - 0x7C28;
                        NPCSizeAddr[3] = NPCAddr - 0x7C18;
                        NPCPointData[0] = NPCAddr - 0x7C14;
                        NPCPointData[1] = NPCAddr - 0x7C10;
                        NPCPointData[2] = NPCAddr - 0x7C0C;
                        break;
                    }
                case "Tree 3":
                    {
                        NPCSizeData[0] = triparamSizeDefault;
                        NPCSizeData[2] = triparamSizeDefault;
                        NPCSizeData[3] = triparamSizeDefault;
                        NPCSizeAddr[0] = NPCAddr - 0x5D48;
                        NPCSizeAddr[2] = NPCAddr - 0x5D38;
                        NPCSizeAddr[3] = NPCAddr - 0x5D28;
                        NPCPointData[0] = NPCAddr - 0x5D24;
                        NPCPointData[1] = NPCAddr - 0x5D20;
                        NPCPointData[2] = NPCAddr - 0x5D1C;
                        break;
                    }
                case "Tree 4":
                    {
                        NPCSizeData[0] = triparamSizeDefault;
                        NPCSizeData[2] = triparamSizeDefault;
                        NPCSizeData[3] = triparamSizeDefault;
                        NPCSizeAddr[0] = NPCAddr - 0x52F8;
                        NPCSizeAddr[2] = NPCAddr - 0x52E8;
                        NPCSizeAddr[3] = NPCAddr - 0x52D8;
                        NPCPointData[0] = NPCAddr - 0x52D4;
                        NPCPointData[1] = NPCAddr - 0x52D0;
                        NPCPointData[2] = NPCAddr - 0x52CC;
                        break;
                    }
                case "Arcade":
                    {
                        NPCSizeData[0] = arcadeSize[0];
                        NPCSizeData[1] = arcadeSize[2];
                        NPCSizeData[2] = arcadeSize[4];
                        NPCSizeData[3] = arcadeSize[6];
                        NPCSizeData[4] = arcadeSize[8];
                        NPCSizeAddr[0] = NPCAddr + 0x140;
                        NPCSizeAddr[1] = NPCAddr + 0x148;
                        NPCSizeAddr[2] = NPCAddr + 0x150;
                        NPCSizeAddr[3] = NPCAddr + 0x158;
                        NPCSizeAddr[4] = NPCAddr + 0x160;
                        NPCPointData[0] = NPCAddr + 0x164;
                        NPCPointData[1] = NPCAddr + 0x168;
                        NPCPointData[2] = NPCAddr + 0x16C;
                        break;
                    }
                case "Manhole":
                    {
                        NPCSizeData[0] = triparamSizeDefault;
                        NPCSizeData[2] = triparamSizeDefault;
                        NPCSizeData[3] = triparamSizeDefault;
                        NPCSizeAddr[0] = manholeAddr - 0x6FC;
                        NPCSizeAddr[2] = manholeAddr - 0x6EC;
                        NPCSizeAddr[3] = manholeAddr - 0x6DC;
                        NPCPointData[0] = manholeAddr - 0x6D8;
                        NPCPointData[1] = manholeAddr - 0x6D4;
                        NPCPointData[2] = manholeAddr - 0x6D0;
                        break;
                    }
                case "Weapon Sign":
                    {
                        NPCSizeData[0] = weaponsignSize[0];
                        NPCSizeData[1] = weaponsignSize[2];
                        NPCSizeData[2] = weaponsignSize[4];
                        NPCSizeData[3] = weaponsignSize[6];
                        NPCSizeData[4] = weaponsignSize[8];
                        NPCSizeAddr[0] = NPCAddr - 0x71E8;
                        NPCSizeAddr[1] = NPCAddr - 0x71E0;
                        NPCSizeAddr[2] = NPCAddr - 0x71D8;
                        NPCSizeAddr[3] = NPCAddr - 0x71D0;
                        NPCSizeAddr[4] = NPCAddr - 0x71C8;
                        NPCPointData[0] = NPCAddr - 0x71C4;
                        NPCPointData[1] = NPCAddr - 0x71C0;
                        NPCPointData[2] = NPCAddr - 0x71BC;
                        break;
                    }
            }
        }
        private void numericBoxLoad() //where the numeric boxes are handled
        {
            switch (NPCcomboBox.Text)
            {
                case "Callie":
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
                        break;
                    }
                case "Callie's Chair":
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
                        break;
                    }
                case "Marie":
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
                        break;
                    }
                case "Marie's Chair":
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
                        break;
                    }
                case "Judd":
                    {
                        masternumericUpDown.Value = Info.juddInfoSizeMaster;
                        numericUpDown1.Value = Info.juddInfoSize1;
                        numericUpDown3.Value = Info.juddInfoSize2;
                        numericUpDown4.Value = Info.juddInfoSize3;
                        locnumericUpDown1.Value = Info.juddInfoPoint1;
                        locnumericUpDown2.Value = Info.juddInfoPoint2;
                        locnumericUpDown3.Value = Info.juddInfoPoint3;
                        break;
                    }
                case "Spyke":
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
                        break;
                    }
                case "Sea Snails":
                    {
                        masternumericUpDown.Value = Info.shellInfoSizeMaster;
                        numericUpDown1.Value = Info.shellInfoSize1;
                        numericUpDown2.Value = Info.shellInfoSize2;
                        numericUpDown3.Value = Info.shellInfoSize3;
                        numericUpDown4.Value = Info.shellInfoSize4;
                        numericUpDown5.Value = Info.shellInfoSize5;

                        locnumericUpDown1.Value = Info.shellInfoPoint1;
                        locnumericUpDown2.Value = Info.shellInfoPoint2;
                        locnumericUpDown3.Value = Info.shellInfoPoint3;
                        break;
                    }
                case "Train":
                    {
                        masternumericUpDown.Value = Info.trainInfoSizeMaster;
                        numericUpDown1.Value = Info.trainInfoSize1;
                        numericUpDown3.Value = Info.trainInfoSize2;
                        numericUpDown4.Value = Info.trainInfoSize3;
                        locnumericUpDown1.Value = Info.trainInfoPoint1;
                        locnumericUpDown2.Value = Info.trainInfoPoint2;
                        locnumericUpDown3.Value = Info.trainInfoPoint3;
                        break;
                    }
                case "Amiibo Box":
                    {
                        masternumericUpDown.Value = Info.amiiboInfoSizeMaster;
                        numericUpDown1.Value = Info.amiiboInfoSize1;
                        numericUpDown2.Value = Info.amiiboInfoSize2;
                        numericUpDown3.Value = Info.amiiboInfoSize3;
                        numericUpDown4.Value = Info.amiiboInfoSize4;
                        numericUpDown5.Value = Info.amiiboInfoSize5;

                        locnumericUpDown1.Value = Info.amiiboInfoPoint1;
                        locnumericUpDown2.Value = Info.amiiboInfoPoint2;
                        locnumericUpDown3.Value = Info.amiiboInfoPoint3;
                        break;
                    }
                case "Balloon":
                    {
                        masternumericUpDown.Value = Info.balloonInfoSizeMaster;
                        numericUpDown1.Value = Info.balloonInfoSize1;
                        numericUpDown2.Value = Info.balloonInfoSize2;
                        numericUpDown3.Value = Info.balloonInfoSize3;
                        numericUpDown4.Value = Info.balloonInfoSize4;
                        numericUpDown5.Value = Info.balloonInfoSize5;

                        locnumericUpDown1.Value = Info.balloonInfoPoint1;
                        locnumericUpDown2.Value = Info.balloonInfoPoint2;
                        locnumericUpDown3.Value = Info.balloonInfoPoint3;
                        break;
                    }
                case "Miiverse Post":
                    {
                        masternumericUpDown.Value = Info.postInfoSizeMaster;
                        numericUpDown1.Value = Info.postInfoSize1;
                        numericUpDown2.Value = Info.postInfoSize2;
                        numericUpDown3.Value = Info.postInfoSize3;
                        numericUpDown4.Value = Info.postInfoSize4;
                        numericUpDown5.Value = Info.postInfoSize5;

                        locnumericUpDown1.Value = Info.postInfoPoint1;
                        locnumericUpDown2.Value = Info.postInfoPoint2;
                        locnumericUpDown3.Value = Info.postInfoPoint3;
                        break;
                    }
                case "Tree 1":
                    {
                        masternumericUpDown.Value = Info.tree1InfoSizeMaster;
                        numericUpDown1.Value = Info.tree1InfoSize1;
                        numericUpDown3.Value = Info.tree1InfoSize2;
                        numericUpDown4.Value = Info.tree1InfoSize3;
                        locnumericUpDown1.Value = Info.tree1InfoPoint1;
                        locnumericUpDown2.Value = Info.tree1InfoPoint2;
                        locnumericUpDown3.Value = Info.tree1InfoPoint3;
                        break;
                    }
                case "Tree 2":
                    {
                        masternumericUpDown.Value = Info.tree2InfoSizeMaster;
                        numericUpDown1.Value = Info.tree2InfoSize1;
                        numericUpDown3.Value = Info.tree2InfoSize2;
                        numericUpDown4.Value = Info.tree2InfoSize3;
                        locnumericUpDown1.Value = Info.tree2InfoPoint1;
                        locnumericUpDown2.Value = Info.tree2InfoPoint2;
                        locnumericUpDown3.Value = Info.tree2InfoPoint3;
                        break;
                    }
                case "Tree 3":
                    {
                        masternumericUpDown.Value = Info.tree3InfoSizeMaster;
                        numericUpDown1.Value = Info.tree3InfoSize1;
                        numericUpDown3.Value = Info.tree3InfoSize2;
                        numericUpDown4.Value = Info.tree3InfoSize3;
                        locnumericUpDown1.Value = Info.tree3InfoPoint1;
                        locnumericUpDown2.Value = Info.tree3InfoPoint2;
                        locnumericUpDown3.Value = Info.tree3InfoPoint3;
                        break;
                    }
                case "Tree 4":
                    {
                        masternumericUpDown.Value = Info.tree4InfoSizeMaster;
                        numericUpDown1.Value = Info.tree4InfoSize1;
                        numericUpDown3.Value = Info.tree4InfoSize2;
                        numericUpDown4.Value = Info.tree4InfoSize3;
                        locnumericUpDown1.Value = Info.tree4InfoPoint1;
                        locnumericUpDown2.Value = Info.tree4InfoPoint2;
                        locnumericUpDown3.Value = Info.tree4InfoPoint3;
                        break;
                    }
                case "Arcade":
                    {
                        masternumericUpDown.Value = Info.arcadeInfoSizeMaster;
                        numericUpDown1.Value = Info.arcadeInfoSize1;
                        numericUpDown2.Value = Info.arcadeInfoSize2;
                        numericUpDown3.Value = Info.arcadeInfoSize3;
                        numericUpDown4.Value = Info.arcadeInfoSize4;
                        numericUpDown5.Value = Info.arcadeInfoSize5;
                        locnumericUpDown1.Value = Info.arcadeInfoPoint1;
                        locnumericUpDown2.Value = Info.arcadeInfoPoint2;
                        locnumericUpDown3.Value = Info.arcadeInfoPoint3;
                        break;
                    }
                case "Manhole":
                    {
                        masternumericUpDown.Value = Info.manholeInfoSizeMaster;
                        numericUpDown1.Value = Info.manholeInfoSize1;
                        numericUpDown3.Value = Info.manholeInfoSize2;
                        numericUpDown4.Value = Info.manholeInfoSize3;
                        locnumericUpDown1.Value = Info.manholeInfoPoint1;
                        locnumericUpDown2.Value = Info.manholeInfoPoint2;
                        locnumericUpDown3.Value = Info.manholeInfoPoint3;
                        break;
                    }
                case "Weapon Sign":
                    {
                        masternumericUpDown.Value = Info.weaponsignInfoSizeMaster;
                        numericUpDown1.Value = Info.weaponsignInfoSize1;
                        numericUpDown2.Value = Info.weaponsignInfoSize2;
                        numericUpDown3.Value = Info.weaponsignInfoSize3;
                        numericUpDown4.Value = Info.weaponsignInfoSize4;
                        numericUpDown5.Value = Info.weaponsignInfoSize5;

                        locnumericUpDown1.Value = Info.weaponsignInfoPoint1;
                        locnumericUpDown2.Value = Info.weaponsignInfoPoint2;
                        locnumericUpDown3.Value = Info.weaponsignInfoPoint3;
                        break;
                    }
            }
        }
        private void NPCsav() //saves NPC values
        {
            switch (NPCcomboBox.Text)
            {
                case "Callie":
                    {
                        Info.callieInfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                        Info.callieInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Callie's Chair":
                    {
                        Info.callieChairInfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                        Info.callieChairInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Marie":
                    {
                        Info.marieInfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                        Info.marieInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Marie's Chair":
                    {
                        Info.marieChairInfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                        Info.marieChairInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Judd":
                    {
                        Info.juddInfoSize(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value);
                        Info.juddInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Spyke":
                    {
                        Info.spykeInfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                        Info.spykeInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Sea Snails":
                    {
                        Info.shellInfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                        Info.shellInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Train":
                    {
                        Info.trainInfoSize(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value);
                        Info.trainInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Amiibo Box":
                    {
                        Info.amiiboInfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                        Info.amiiboInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Balloon":
                    {
                        Info.balloonInfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                        Info.balloonInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Miiverse Post":
                    {
                        Info.postInfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                        Info.postInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Tree 1":
                    {
                        Info.tree1InfoSize(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value);
                        Info.tree1InfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Tree 2":
                    {
                        Info.tree2InfoSize(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value);
                        Info.tree2InfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Tree 3":
                    {
                        Info.tree3InfoSize(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value);
                        Info.tree3InfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Tree 4":
                    {
                        Info.tree4InfoSize(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value);
                        Info.tree4InfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Arcade":
                    {
                        Info.arcadeInfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                        Info.arcadeInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Manhole":
                    {
                        Info.manholeInfoSize(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value);
                        Info.manholeInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Weapon Sign":
                    {
                        Info.weaponsignInfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                        Info.weaponsignInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
            }
        }
        private void masterScaleSav() //saves master scale values
        {
            switch (NPCcomboBox.Text)
            {
                case "Callie":
                    {
                        Info.callieMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Callie's Chair":
                    {
                        Info.callieChairMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Marie":
                    {
                        Info.marieMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Marie's Chair":
                    {
                        Info.marieChairMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Judd":
                    {
                        Info.juddMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Spyke":
                    {
                        Info.spykeMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Sea Snails":
                    {
                        Info.shellMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Train":
                    {
                        Info.trainMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Amiibo Box":
                    {
                        Info.amiiboMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Balloon":
                    {
                        Info.balloonMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Miiverse Post":
                    {
                        Info.postMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Tree 1":
                    {
                        Info.tree1MasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Tree 2":
                    {
                        Info.tree2MasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Tree 3":
                    {
                        Info.tree3MasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Tree 4":
                    {
                        Info.tree4MasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Arcade":
                    {
                        Info.arcadeMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Manhole":
                    {
                        Info.manholeMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Weapon Sign":
                    {
                        Info.weaponsignMasterScale(masternumericUpDown.Value);
                        break;
                    }
            }
        }
    }
}
