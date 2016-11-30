using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;


namespace PlazaToon
{
    public partial class Main : Form
    {
        public static TCPGecko gecko = null;
        private uint diff;
        Control rattata = null;

        public static uint sistersAddr;
        public static uint NPCAddr;
        public static uint spykeAddr;
        public static uint manHoleAddr;
        public static string NPCText;
        public static uint triparamSizeDefault = 0x3F800000;

        //arrays
        //obj with no rotation are not necesary as size array:
        //train, tree, judd, Cloth
        public static uint[] amiiboSize = new uint[9] { 0xBF4201FA, 0, 0x3F270623, 0, 0x3F800000, 0, 0xBF270623, 0, 0xBF4201FA };
        public static uint[] balloonSize = new uint[9] { 0x3F776556, 0, 0xBE83A00A, 0, 0x3F800000, 0, 0x3E83A00A, 0, 0x3F776556 };
        public static uint[] postSize = new uint[9] { 0x3F708FB2, 0, 0xBEAF1D43, 0, 0x3F800000, 0, 0x3EAF1D43, 0, 0x3F708FB2 };
        public static uint[] weaponSignSize = new uint[9] { 0x3F742779, 0, 0xBE99F1CE, 0, 0x3F800000, 0, 0x3E99F1CE, 0, 0x3F742779 };
        public static uint[] shellSize = new uint[9] { 0xBF5ADC22, 0, 0xBF04CD49, 0, 0x3F800000, 0, 0x3F04CD49, 0, 0xBF5ADC22 };
        public static uint[] marieSize = new uint[9] { 0x3EFA4D62, 0, 0xBF5F52B5, 0, 0x3F800000, 0, 0x3F5F52B5, 0, 0x3EFA4D62 };
        public static uint[] mariechairSize = new uint[9] { 0x3EFA4D5D, 0, 0x3F5F52B4, 0, 0x3F800000, 0, 0xBF5F52B4, 0, 0x3EFA4D5D };
        public static uint[] callieSize = new uint[9] { 0x3F7490F0, 0, 0xBE974E63, 0, 0x3F800000, 0, 0x3E974E63, 0, 0x3F7490F0 };
        public static uint[] calliechairSize = new uint[9] { 0x3F7490F0, 0, 0x3E974E64, 0, 0x3F800000, 0, 0xBE974E64, 0, 0x3F7490F0 };
        public static uint[] spykeSize = new uint[9] { 0x3F2EA60F, 0, 0x3F3B2C5C, 0, 0x3F800000, 0, 0xBF3B2C5C, 0, 0x3F2EA60F };
        public static uint[] arcadeSize = new uint[9] { 0xBE882C60, 0, 0xBF76C799, 0, 0x3F800000, 0, 0x3F76C799, 0, 0xBE882C60 };
        public static uint[] birdSize = new uint[9] { 0xBF747206, 0, 0x3E9815B4, 0, 0x3F800000, 0, 0xBE9815B4, 0, 0xBF747206 };
        public static uint[] bird2Size = new uint[9] { 0x3F4D5627, 0, 0xBF18E1CC, 0, 0x3F800000, 0, 0x3F18E1CC, 0, 0x3F4D5627 };
        public static uint[] bird3Size = new uint[9] { 0x3F6563B3, 0, 0x3EE34D2A, 0, 0x3F800000, 0, 0xBEE34D2A, 0, 0x3F6563B3 };
        public static uint[] bird4Size = new uint[9] { 0xBF5DF576, 0, 0x3EFF1C26, 0, 0x3F800000, 0, 0xBEFF1C26, 0, 0xBF5DF576 };
        public static uint[] bird5Size = new uint[9] { 0xBF5DF576, 0, 0x3EFF1C26, 0, 0x3F800000, 0, 0xBEFF1C26, 0, 0xBF5DF576 };

        //obj that are located at (0, 0, 0) are not necessary as coord array:
        //all plaza doors, MainTV
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
        public static uint[] manHolePoint = new uint[3] { 0x42FEDB3C, 0x3E99999A, 0xC366BFA6 };
        public static uint[] originPoint = new uint[3] { 0x00000000, 0x00000000, 0x00000000 };
        public static uint[] weaponSignPoint = new uint[3] { 0xC2E61AF8, 0x00000000, 0xC33DCB02 };
        public static uint[] fishPoint = new uint[3] { 0xB5FC0000, 0x4320D7C4, 0xC3FF86B2 };
        public static uint[] clothPoint = new uint[3] { 0xC34A999A, 0x42300000, 0x432C0000 };
        public static uint[] birdPoint = new uint[3] { 0x4291315F, 0x41E17CCD, 0x438D1305 };
        public static uint[] bird2Point = new uint[3] { 0xC26A1B0B, 0x416C74D2, 0x4335BE91 };
        public static uint[] bird3Point = new uint[3] { 0x42489CB5, 0x3E4CCCAA, 0xC3192269 };
        public static uint[] bird4Point = new uint[3] { 0x43B15256, 0x3DCCB79A, 0xC2BBC150 };
        public static uint[] bird5Point = new uint[3] { 0x43B07CE9, 0x3DCCB799, 0xC2CED145 };

        public static uint[] NPCSizeAddr = new uint[9];
        public static uint[] NPCSizeData = new uint[9];
        public static uint[] NPCPointData = new uint[9];

        public Main()
        {
            InitializeComponent();
            menuStrip.Renderer = new RenderColor();
        }
        //force customized tooltrip colours
        private class RenderColor : ToolStripProfessionalRenderer
        {
            public RenderColor() : base(new ToolStripColors()) { }

            protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
            {
                if (!e.Item.Selected && e.Item.BackColor != SystemColors.MenuHighlight)
                {
                    e.TextColor = Color.Black;
                    base.OnRenderItemText(e);
                }
                else if (!e.Item.IsOnDropDown)
                {
                    e.TextColor = Color.White;
                    base.OnRenderItemText(e);
                }
                else
                {
                    e.TextColor = Color.Black;
                    base.OnRenderItemText(e);
                }
            }
        }
        private void optionsToolStripMenuItem_DropDownOpened(object sender, EventArgs e) { optionsToolStripMenuItem.BackColor = SystemColors.MenuHighlight; }
        private void optionsToolStripMenuItem_DropDownClosed(object sender, EventArgs e) { optionsToolStripMenuItem.BackColor = Color.Transparent; }

        private void helpToolStripMenuItem_DropDownOpened(object sender, EventArgs e) { helpToolStripMenuItem.BackColor = SystemColors.MenuHighlight; }
        private void helpToolStripMenuItem_DropDownClosed(object sender, EventArgs e) { helpToolStripMenuItem.BackColor = Color.Transparent; }

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
                Info.gecko = gecko;
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
                    ConnectButton.BackColor = Color.FromArgb(60, 120, 210); //dark blue change indicating geckiine
                }
                else if (check == 0xFFFFFFFF && gecko.peek(0x12CE3DA0) != 0x000003F2) //Loadiine
                {
                    diff = 0;
                    ConnectButton.BackColor = Color.FromArgb(50, 145, 245); //light blue change indicating Loadiine
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
                DisconnButton.BackColor = Color.FromArgb(225, 39, 39);

                recalculateAddr();
                NPCInfoSize();
                numericBoxLoad();
                NPCcomboBox.Focus();
            }
            else
            {
                if (ConnectButton.Text == "Recalculate")
                {
                    displayMsg("Addresses have been recalculated.");
                }
                recalculateAddr();
                NPCInfoSize();
            }
        }
        private void recalculateAddr()
        {
            sistersAddr = gecko.peek(0x1CAAAC50 - diff);
            manHoleAddr = gecko.peek(0x1CAAAE68 - diff);
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
                ConnectButton.BackColor = Color.FromArgb(90, 200, 92);
                DisconnButton.BackColor = Color.FromArgb(190, 35, 50);
            }
        }

        private void resetAllToolStripMenuItem_Click(object sender, EventArgs e) //resets all variables, sizes and locations in-game to default
        {
            var confirmResult = MessageBox.Show("Are you sure you want to reset the size and location for all NPCs?", "Reset All ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (gecko != null && confirmResult == DialogResult.Yes) //confirmation to reset
            {
                recalculateAddr();
                Info.resetti();
                NPCInfoSize();
                numericBoxLoad();
                displayMsg("All settings has been resetted.");
            }
            else if (confirmResult == DialogResult.No) { }
            else
            {
                MessageBox.Show("Size and location has not been resetted successfully.", "Reset All Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }
        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to reload the size and location for all NPCs based on the changes you made?", "Reload All ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (gecko != null && confirmResult == DialogResult.Yes) //confirmation to reset
            {
                recalculateAddr();
                Info.loadi();
                NPCInfoSize();
                numericBoxLoad();
                displayMsg("All settings has been reloaded.");
            }
            else if (confirmResult == DialogResult.No) { }
            else
            {
                MessageBox.Show("Size and location has not been reloaded successfully.", "Reload All Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void displayMsg(string msg)
        {
            multiLabel.Text = msg;
            msgTimer.Stop();
            msgTimer.Start();
        }
        private void msgTimer_Tick(object sender, EventArgs e) //displays displayMsg message
        {
            multiLabel.Text = "Credits to Amibu, Splatonka, CosmoCortney, etc.";
            msgTimer.Stop();
        }

        private void NPCcomboBox_SelectedIndexChanged(object sender, EventArgs e) //controls Enabled events
        {
            if (NPCcomboBox.Text == "Judd" || NPCcomboBox.Text == "Tree 1" || NPCcomboBox.Text == "Tree 2" || NPCcomboBox.Text == "Tree 3" || NPCcomboBox.Text == "Tree 4"
                || NPCcomboBox.Text == "Manhole" || NPCcomboBox.Text == "Awning" || NPCcomboBox.Text == "Great Zapfish")
            {
                numericUpDown2.Enabled = false;
                numericUpDown5.Enabled = false;
                numericUpDown1.Increment = (decimal)0.25;
                numericUpDown3.Increment = (decimal)0.25;
                numericUpDown4.Increment = (decimal)0.25;
                masternumericUpDown.Increment = (decimal)0.25;
            }
            else if (NPCcomboBox.Text == "Train" || NPCcomboBox.Text == "Main TV" || NPCcomboBox.Text == "Doory (Cooler Heads)"
                || NPCcomboBox.Text == "Doorothy (Jelly Fresh)" || NPCcomboBox.Text == "Doorian (Shrimp Kicks)" || NPCcomboBox.Text == "Dooris (Ammo Knights)" || NPCcomboBox.Text == "Inkopolis Tower Door" || NPCcomboBox.Text == "Battle Dojo Doors")
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
            if (!NPCcomboBox.ContainsFocus && autoModeToolStripMenuItem.Checked == true) { scaleUpdate1(); }
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (!NPCcomboBox.ContainsFocus && autoModeToolStripMenuItem.Checked == true) { scaleUpdate3(); }
        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (oneandtwoCheckBox.Checked == true && numericUpDown5.Enabled == true)
            {
                numericUpDown5.Value = numericUpDown4.Value;
            }
            if (!NPCcomboBox.ContainsFocus && autoModeToolStripMenuItem.Checked == true) { scaleUpdate4(); }
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (oneandtwoCheckBox.Checked == true && numericUpDown1.Enabled == true)
            {
                numericUpDown1.Value = numericUpDown2.Value;
            }
            if (!NPCcomboBox.ContainsFocus && autoModeToolStripMenuItem.Checked == true) { scaleUpdate2(); }
        }
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (oneandtwoCheckBox.Checked == true && numericUpDown4.Enabled == true)
            {
                numericUpDown4.Value = numericUpDown5.Value;
            }
            if (!NPCcomboBox.ContainsFocus && autoModeToolStripMenuItem.Checked == true) { scaleUpdate5(); }
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
            if (NPCcomboBox.Text == "Judd" || NPCcomboBox.Text == "Train" || NPCcomboBox.Text == "Tree 1" || NPCcomboBox.Text == "Tree 2" || NPCcomboBox.Text == "Tree 3" || NPCcomboBox.Text == "Tree 4"
                || NPCcomboBox.Text == "Manhole" || NPCcomboBox.Text == "Awning" || NPCcomboBox.Text == "Main TV" || NPCcomboBox.Text == "Great Zapfish" || NPCcomboBox.Text == "Doory (Cooler Heads)"
                || NPCcomboBox.Text == "Doorothy (Jelly Fresh)" || NPCcomboBox.Text == "Doorian (Shrimp Kicks)" || NPCcomboBox.Text == "Dooris (Ammo Knights)" || NPCcomboBox.Text == "Inkopolis Tower Door" || NPCcomboBox.Text == "Battle Dojo Doors")
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
            if (gecko != null) { recalculateAddr(); displayMsg("All scale values have poked."); }
            else { displayMsg("No connection has established for poking."); }
            scaleUpdate1();
            scaleUpdate2();
            scaleUpdate3();
            scaleUpdate4();
            scaleUpdate5();
            if (rattata != null) { rattata.Focus(); }
        }
        private void pokeLocButton_Click(object sender, EventArgs e)
        {
            if (gecko != null) { recalculateAddr(); displayMsg("All location values have poked."); }
            else { displayMsg("No connection has established for poking."); }
            locUpdate1();
            locUpdate2();
            locUpdate3();
            if (rattata != null) { rattata.Focus(); }
        }
        private void pokeBothButton_Click(object sender, EventArgs e)
        {
            pokeScaleButton_Click(sender, e);
            pokeLocButton_Click(sender, e);
            if (gecko != null) { displayMsg("All location and scale values have poked."); }
            else { displayMsg("No connection has established for poking."); }
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
        private void locnumericUpDown1_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) { NPCsav(); } }
        private void locnumericUpDown2_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) { NPCsav(); } }
        private void locnumericUpDown3_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) { NPCsav(); } }
        //Master scale seperate save
        private void masternumericUpDown_MouseUp(object sender, MouseEventArgs e) { rattata = (Control)sender; masterScaleSav(); NPCsav(); }
        private void masternumericUpDown_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) { masterScaleSav(); NPCsav(); } }

        //click the labels to set the values to 1 and 0
        private void xScaleLabel_Click(object sender, EventArgs e) { numericUpDown1.Value = 1; NPCsav(); }
        private void yScaleLabel_Click(object sender, EventArgs e) { numericUpDown3.Value = 1; NPCsav(); }
        private void zScaleLabel_Click(object sender, EventArgs e) { numericUpDown4.Value = 1; NPCsav(); }
        private void x2ScaleLabel_Click(object sender, EventArgs e) { numericUpDown2.Value = 1; NPCsav(); }
        private void z2label_Click(object sender, EventArgs e) { numericUpDown5.Value = 1; NPCsav(); }
        private void masterLabel_Click(object sender, EventArgs e) { masternumericUpDown.Value = 1; NPCsav();  masterScaleSav(); }

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
                autoModeToolStripMenuItem.BackColor = SystemColors.MenuHighlight;
                manualGroupBox.Location = new Point(3, 350);
                multiLabel.Location = new Point(6, 315);
                creatorLabel.Location = new Point(279, 315);
                Size = new Size(367, 371);
            }
            else if (autoModeToolStripMenuItem.Checked == true)
            {
                ConnectButton.Text = "Connect";
                autoModeToolStripMenuItem.Checked = false;
                manualGroupBox.Visible = true;
                autoModeToolStripMenuItem.BackColor = Color.Transparent;
                manualGroupBox.Location = new Point(3, 316);
                multiLabel.Location = new Point(6, 365);
                creatorLabel.Location = new Point(279, 365);
                Size = new Size(367, 421);
            }
        }
        //help buttons PLACEHOLDER FOR NOW
        private void rattataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/yahya14/PlazaToon");
        }
        private void comingSoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/yahya14/PlazaToon/blob/master/tips_tricks.md");
        }

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
                        NPCSizeAddr[0] = manHoleAddr - 0x6FC;
                        NPCSizeAddr[2] = manHoleAddr - 0x6EC;
                        NPCSizeAddr[3] = manHoleAddr - 0x6DC;
                        NPCPointData[0] = manHoleAddr - 0x6D8;
                        NPCPointData[1] = manHoleAddr - 0x6D4;
                        NPCPointData[2] = manHoleAddr - 0x6D0;
                        break;
                    }
                case "Weapon Sign":
                    {
                        NPCSizeData[0] = weaponSignSize[0];
                        NPCSizeData[1] = weaponSignSize[2];
                        NPCSizeData[2] = weaponSignSize[4];
                        NPCSizeData[3] = weaponSignSize[6];
                        NPCSizeData[4] = weaponSignSize[8];
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
                case "Awning":
                    {
                        NPCSizeData[0] = triparamSizeDefault;
                        NPCSizeData[2] = triparamSizeDefault;
                        NPCSizeData[3] = triparamSizeDefault;
                        NPCSizeAddr[0] = NPCAddr - 0x48A8;
                        NPCSizeAddr[2] = NPCAddr - 0x4898;
                        NPCSizeAddr[3] = NPCAddr - 0x4888;
                        NPCPointData[0] = NPCAddr - 0x4884;
                        NPCPointData[1] = NPCAddr - 0x4880;
                        NPCPointData[2] = NPCAddr - 0x487C;
                        break;
                    }
                case "Main TV":
                    {
                        NPCSizeData[0] = triparamSizeDefault;
                        NPCSizeData[2] = triparamSizeDefault;
                        NPCSizeData[3] = triparamSizeDefault;
                        NPCSizeAddr[0] = sistersAddr + 0x28F4;
                        NPCSizeAddr[2] = sistersAddr + 0x2904;
                        NPCSizeAddr[3] = sistersAddr + 0x2914;
                        NPCPointData[0] = sistersAddr + 0x2918;
                        NPCPointData[1] = sistersAddr + 0x291C;
                        NPCPointData[2] = sistersAddr + 0x2920;
                        break;
                    }
                case "Great Zapfish":
                    {
                        NPCSizeData[0] = triparamSizeDefault;
                        NPCSizeData[2] = triparamSizeDefault;
                        NPCSizeData[3] = triparamSizeDefault;
                        NPCSizeAddr[0] = NPCAddr + 0x3730;
                        NPCSizeAddr[2] = NPCAddr + 0x3740;
                        NPCSizeAddr[3] = NPCAddr + 0x3750;
                        NPCPointData[0] = NPCAddr + 0x3754;
                        NPCPointData[1] = NPCAddr + 0x3758;
                        NPCPointData[2] = NPCAddr + 0x375C;
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
                case "Bird 1":
                    {
                        NPCSizeData[0] = birdSize[0];
                        NPCSizeData[1] = birdSize[2];
                        NPCSizeData[2] = birdSize[4];
                        NPCSizeData[3] = birdSize[6];
                        NPCSizeData[4] = birdSize[8];
                        NPCSizeAddr[0] = NPCAddr - 0x3D68;
                        NPCSizeAddr[1] = NPCAddr - 0x3D60;
                        NPCSizeAddr[2] = NPCAddr - 0x3D58;
                        NPCSizeAddr[3] = NPCAddr - 0x3D50;
                        NPCSizeAddr[4] = NPCAddr - 0x3D48;
                        NPCPointData[0] = NPCAddr - 0x3D44;
                        NPCPointData[1] = NPCAddr - 0x3D40;
                        NPCPointData[2] = NPCAddr - 0x3D3C;
                        break;
                    }
                case "Bird 2":
                    {
                        NPCSizeData[0] = bird2Size[0];
                        NPCSizeData[1] = bird2Size[2];
                        NPCSizeData[2] = bird2Size[4];
                        NPCSizeData[3] = bird2Size[6];
                        NPCSizeData[4] = bird2Size[8];
                        NPCSizeAddr[0] = NPCAddr - 0x37DC;
                        NPCSizeAddr[1] = NPCAddr - 0x37D4;
                        NPCSizeAddr[2] = NPCAddr - 0x37CC;
                        NPCSizeAddr[3] = NPCAddr - 0x37C4;
                        NPCSizeAddr[4] = NPCAddr - 0x37BC;
                        NPCPointData[0] = NPCAddr - 0x37B8;
                        NPCPointData[1] = NPCAddr - 0x37B4;
                        NPCPointData[2] = NPCAddr - 0x37B0;
                        break;
                    }
                case "Bird 3":
                    {
                        NPCSizeData[0] = bird3Size[0];
                        NPCSizeData[1] = bird3Size[2];
                        NPCSizeData[2] = bird3Size[4];
                        NPCSizeData[3] = bird3Size[6];
                        NPCSizeData[4] = bird3Size[8];
                        NPCSizeAddr[0] = NPCAddr - 0x3250;
                        NPCSizeAddr[1] = NPCAddr - 0x3248;
                        NPCSizeAddr[2] = NPCAddr - 0x3240;
                        NPCSizeAddr[3] = NPCAddr - 0x3238;
                        NPCSizeAddr[4] = NPCAddr - 0x3230;
                        NPCPointData[0] = NPCAddr - 0x322C;
                        NPCPointData[1] = NPCAddr - 0x3228;
                        NPCPointData[2] = NPCAddr - 0x3224;
                        break;
                    }
                case "Bird 4":
                    {
                        NPCSizeData[0] = bird4Size[0];
                        NPCSizeData[1] = bird4Size[2];
                        NPCSizeData[2] = bird4Size[4];
                        NPCSizeData[3] = bird4Size[6];
                        NPCSizeData[4] = bird4Size[8];
                        NPCSizeAddr[0] = NPCAddr - 0x2CC4;
                        NPCSizeAddr[1] = NPCAddr - 0x2CBC;
                        NPCSizeAddr[2] = NPCAddr - 0x2CB4;
                        NPCSizeAddr[3] = NPCAddr - 0x2CAC;
                        NPCSizeAddr[4] = NPCAddr - 0x2CA4;
                        NPCPointData[0] = NPCAddr - 0x2CA0;
                        NPCPointData[1] = NPCAddr - 0x2C9C;
                        NPCPointData[2] = NPCAddr - 0x2C98;
                        break;
                    }
                case "Bird 5":
                    {
                        NPCSizeData[0] = bird4Size[0];
                        NPCSizeData[1] = bird4Size[2];
                        NPCSizeData[2] = bird4Size[4];
                        NPCSizeData[3] = bird4Size[6];
                        NPCSizeData[4] = bird4Size[8];
                        NPCSizeAddr[0] = NPCAddr - 0x2738;
                        NPCSizeAddr[1] = NPCAddr - 0x2730;
                        NPCSizeAddr[2] = NPCAddr - 0x2728;
                        NPCSizeAddr[3] = NPCAddr - 0x2720;
                        NPCSizeAddr[4] = NPCAddr - 0x2718;
                        NPCPointData[0] = NPCAddr - 0x2614;
                        NPCPointData[1] = NPCAddr - 0x2710;
                        NPCPointData[2] = NPCAddr - 0x270C;
                        break;
                    }
                case "Doory (Cooler Heads)":
                    {
                        NPCSizeData[0] = triparamSizeDefault;
                        NPCSizeData[2] = triparamSizeDefault;
                        NPCSizeData[3] = triparamSizeDefault;
                        NPCSizeAddr[0] = NPCAddr + 0xEE8;
                        NPCSizeAddr[2] = NPCAddr + 0xEF8;
                        NPCSizeAddr[3] = NPCAddr + 0xF08;
                        NPCPointData[0] = NPCAddr + 0xF0C;
                        NPCPointData[1] = NPCAddr + 0xF10;
                        NPCPointData[2] = NPCAddr + 0xF14;
                        break;
                    }
                case "Doorothy (Jelly Fresh)":
                    {
                        NPCSizeData[0] = triparamSizeDefault;
                        NPCSizeData[2] = triparamSizeDefault;
                        NPCSizeData[3] = triparamSizeDefault;
                        NPCSizeAddr[0] = NPCAddr + 0x1C10;
                        NPCSizeAddr[2] = NPCAddr + 0x1C20;
                        NPCSizeAddr[3] = NPCAddr + 0x1C30;
                        NPCPointData[0] = NPCAddr + 0x1C34;
                        NPCPointData[1] = NPCAddr + 0x1C38;
                        NPCPointData[2] = NPCAddr + 0x1C3C;
                        break;
                    }
                case "Doorian (Shrimp Kicks)":
                    {
                        NPCSizeData[0] = triparamSizeDefault;
                        NPCSizeData[2] = triparamSizeDefault;
                        NPCSizeData[3] = triparamSizeDefault;
                        NPCSizeAddr[0] = NPCAddr + 0x157C;
                        NPCSizeAddr[2] = NPCAddr + 0x158C;
                        NPCSizeAddr[3] = NPCAddr + 0x159C;
                        NPCPointData[0] = NPCAddr + 0x15A0;
                        NPCPointData[1] = NPCAddr + 0x15A4;
                        NPCPointData[2] = NPCAddr + 0x15A8;
                        break;
                    }
                case "Dooris (Ammo Knights)":
                    {
                        NPCSizeData[0] = triparamSizeDefault;
                        NPCSizeData[2] = triparamSizeDefault;
                        NPCSizeData[3] = triparamSizeDefault;
                        NPCSizeAddr[0] = NPCAddr + 0x22A4;
                        NPCSizeAddr[2] = NPCAddr + 0x22B4;
                        NPCSizeAddr[3] = NPCAddr + 0x22C4;
                        NPCPointData[0] = NPCAddr + 0x22C8;
                        NPCPointData[1] = NPCAddr + 0x22CC;
                        NPCPointData[2] = NPCAddr + 0x22D0;
                        break;
                    }
                case "Inkopolis Tower Door":
                    {
                        NPCSizeData[0] = triparamSizeDefault;
                        NPCSizeData[2] = triparamSizeDefault;
                        NPCSizeData[3] = triparamSizeDefault;
                        NPCSizeAddr[0] = NPCAddr + 0x2938;
                        NPCSizeAddr[2] = NPCAddr + 0x2948;
                        NPCSizeAddr[3] = NPCAddr + 0x2958;
                        NPCPointData[0] = NPCAddr + 0x295C;
                        NPCPointData[1] = NPCAddr + 0x2960;
                        NPCPointData[2] = NPCAddr + 0x2964;
                        break;
                    }
                case "Battle Dojo Doors":
                    {
                        NPCSizeData[0] = triparamSizeDefault;
                        NPCSizeData[2] = triparamSizeDefault;
                        NPCSizeData[3] = triparamSizeDefault;
                        NPCSizeAddr[0] = NPCAddr + 0x2FCC;
                        NPCSizeAddr[2] = NPCAddr + 0x2FDC;
                        NPCSizeAddr[3] = NPCAddr + 0x2FEC;
                        NPCPointData[0] = NPCAddr + 0x2FF0;
                        NPCPointData[1] = NPCAddr + 0x2FF4;
                        NPCPointData[2] = NPCAddr + 0x2FF8;
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
                        masternumericUpDown.Value = Info.manHoleInfoSizeMaster;
                        numericUpDown1.Value = Info.manHoleInfoSize1;
                        numericUpDown3.Value = Info.manHoleInfoSize2;
                        numericUpDown4.Value = Info.manHoleInfoSize3;
                        locnumericUpDown1.Value = Info.manHoleInfoPoint1;
                        locnumericUpDown2.Value = Info.manHoleInfoPoint2;
                        locnumericUpDown3.Value = Info.manHoleInfoPoint3;
                        break;
                    }
                case "Weapon Sign":
                    {
                        masternumericUpDown.Value = Info.weaponSignInfoSizeMaster;
                        numericUpDown1.Value = Info.weaponSignInfoSize1;
                        numericUpDown2.Value = Info.weaponSignInfoSize2;
                        numericUpDown3.Value = Info.weaponSignInfoSize3;
                        numericUpDown4.Value = Info.weaponSignInfoSize4;
                        numericUpDown5.Value = Info.weaponSignInfoSize5;

                        locnumericUpDown1.Value = Info.weaponSignInfoPoint1;
                        locnumericUpDown2.Value = Info.weaponSignInfoPoint2;
                        locnumericUpDown3.Value = Info.weaponSignInfoPoint3;
                        break;
                    }
                case "Awning":
                    {
                        masternumericUpDown.Value = Info.clothInfoSizeMaster;
                        numericUpDown1.Value = Info.clothInfoSize1;
                        numericUpDown3.Value = Info.clothInfoSize2;
                        numericUpDown4.Value = Info.clothInfoSize3;
                        locnumericUpDown1.Value = Info.clothInfoPoint1;
                        locnumericUpDown2.Value = Info.clothInfoPoint2;
                        locnumericUpDown3.Value = Info.clothInfoPoint3;
                        break;
                    }
                case "Main TV":
                    {
                        masternumericUpDown.Value = Info.tvInfoSizeMaster;
                        numericUpDown1.Value = Info.tvInfoSize1;
                        numericUpDown3.Value = Info.tvInfoSize2;
                        numericUpDown4.Value = Info.tvInfoSize3;
                        locnumericUpDown1.Value = Info.tvInfoPoint1;
                        locnumericUpDown2.Value = Info.tvInfoPoint2;
                        locnumericUpDown3.Value = Info.tvInfoPoint3;
                        break;
                    }
                case "Great Zapfish":
                    {
                        masternumericUpDown.Value = Info.fishInfoSizeMaster;
                        numericUpDown1.Value = Info.fishInfoSize1;
                        numericUpDown3.Value = Info.fishInfoSize2;
                        numericUpDown4.Value = Info.fishInfoSize3;
                        locnumericUpDown1.Value = Info.fishInfoPoint1;
                        locnumericUpDown2.Value = Info.fishInfoPoint2;
                        locnumericUpDown3.Value = Info.fishInfoPoint3;
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
                case "Bird 1":
                    {
                        masternumericUpDown.Value = Info.bird1InfoSizeMaster;
                        numericUpDown1.Value = Info.bird1InfoSize1;
                        numericUpDown2.Value = Info.bird1InfoSize2;
                        numericUpDown3.Value = Info.bird1InfoSize3;
                        numericUpDown4.Value = Info.bird1InfoSize4;
                        numericUpDown5.Value = Info.bird1InfoSize5;
                        locnumericUpDown1.Value = Info.bird1InfoPoint1;
                        locnumericUpDown2.Value = Info.bird1InfoPoint2;
                        locnumericUpDown3.Value = Info.bird1InfoPoint3;
                        break;
                    }
                case "Bird 2":
                    {
                        masternumericUpDown.Value = Info.bird2InfoSizeMaster;
                        numericUpDown1.Value = Info.bird2InfoSize1;
                        numericUpDown2.Value = Info.bird2InfoSize2;
                        numericUpDown3.Value = Info.bird2InfoSize3;
                        numericUpDown4.Value = Info.bird2InfoSize4;
                        numericUpDown5.Value = Info.bird2InfoSize5;
                        locnumericUpDown1.Value = Info.bird2InfoPoint1;
                        locnumericUpDown2.Value = Info.bird2InfoPoint2;
                        locnumericUpDown3.Value = Info.bird2InfoPoint3;
                        break;
                    }
                case "Bird 3":
                    {
                        masternumericUpDown.Value = Info.bird3InfoSizeMaster;
                        numericUpDown1.Value = Info.bird3InfoSize1;
                        numericUpDown2.Value = Info.bird3InfoSize2;
                        numericUpDown3.Value = Info.bird3InfoSize3;
                        numericUpDown4.Value = Info.bird3InfoSize4;
                        numericUpDown5.Value = Info.bird3InfoSize5;
                        locnumericUpDown1.Value = Info.bird3InfoPoint1;
                        locnumericUpDown2.Value = Info.bird3InfoPoint2;
                        locnumericUpDown3.Value = Info.bird3InfoPoint3;
                        break;
                    }
                case "Bird 4":
                    {
                        masternumericUpDown.Value = Info.bird4InfoSizeMaster;
                        numericUpDown1.Value = Info.bird4InfoSize1;
                        numericUpDown2.Value = Info.bird4InfoSize2;
                        numericUpDown3.Value = Info.bird4InfoSize3;
                        numericUpDown4.Value = Info.bird4InfoSize4;
                        numericUpDown5.Value = Info.bird4InfoSize5;
                        locnumericUpDown1.Value = Info.bird4InfoPoint1;
                        locnumericUpDown2.Value = Info.bird4InfoPoint2;
                        locnumericUpDown3.Value = Info.bird4InfoPoint3;
                        break;
                    }
                case "Bird 5":
                    {
                        masternumericUpDown.Value = Info.bird5InfoSizeMaster;
                        numericUpDown1.Value = Info.bird5InfoSize1;
                        numericUpDown2.Value = Info.bird5InfoSize2;
                        numericUpDown3.Value = Info.bird5InfoSize3;
                        numericUpDown4.Value = Info.bird5InfoSize4;
                        numericUpDown5.Value = Info.bird5InfoSize5;
                        locnumericUpDown1.Value = Info.bird5InfoPoint1;
                        locnumericUpDown2.Value = Info.bird5InfoPoint2;
                        locnumericUpDown3.Value = Info.bird5InfoPoint3;
                        break;
                    }
                case "Dooris (Ammo Knights)":
                    {
                        masternumericUpDown.Value = Info.doorWeaponInfoSizeMaster;
                        numericUpDown1.Value = Info.doorWeaponInfoSize1;
                        numericUpDown3.Value = Info.doorWeaponInfoSize2;
                        numericUpDown4.Value = Info.doorWeaponInfoSize3;
                        locnumericUpDown1.Value = Info.doorWeaponInfoPoint1;
                        locnumericUpDown2.Value = Info.doorWeaponInfoPoint2;
                        locnumericUpDown3.Value = Info.doorWeaponInfoPoint3;
                        break;
                    }
                case "Doory (Cooler Heads)":
                    {
                        masternumericUpDown.Value = Info.doorHatInfoSizeMaster;
                        numericUpDown1.Value = Info.doorHatInfoSize1;
                        numericUpDown3.Value = Info.doorHatInfoSize2;
                        numericUpDown4.Value = Info.doorHatInfoSize3;
                        locnumericUpDown1.Value = Info.doorHatInfoPoint1;
                        locnumericUpDown2.Value = Info.doorHatInfoPoint2;
                        locnumericUpDown3.Value = Info.doorHatInfoPoint3;
                        break;
                    }
                case "Doorothy (Jelly Fresh)":
                    {
                        masternumericUpDown.Value = Info.doorShirtInfoSizeMaster;
                        numericUpDown1.Value = Info.doorShirtInfoSize1;
                        numericUpDown3.Value = Info.doorShirtInfoSize2;
                        numericUpDown4.Value = Info.doorShirtInfoSize3;
                        locnumericUpDown1.Value = Info.doorShirtInfoPoint1;
                        locnumericUpDown2.Value = Info.doorShirtInfoPoint2;
                        locnumericUpDown3.Value = Info.doorShirtInfoPoint3;
                        break;
                    }
                case "Doorian (Shrimp Kicks)":
                    {
                        masternumericUpDown.Value = Info.doorShoesInfoSizeMaster;
                        numericUpDown1.Value = Info.doorShoesInfoSize1;
                        numericUpDown3.Value = Info.doorShoesInfoSize2;
                        numericUpDown4.Value = Info.doorShoesInfoSize3;
                        locnumericUpDown1.Value = Info.doorShoesInfoPoint1;
                        locnumericUpDown2.Value = Info.doorShoesInfoPoint2;
                        locnumericUpDown3.Value = Info.doorShoesInfoPoint3;
                        break;
                    }
                case "Inkopolis Tower Door":
                    {
                        masternumericUpDown.Value = Info.doorVSInfoSizeMaster;
                        numericUpDown1.Value = Info.doorVSInfoSize1;
                        numericUpDown3.Value = Info.doorVSInfoSize2;
                        numericUpDown4.Value = Info.doorVSInfoSize3;
                        locnumericUpDown1.Value = Info.doorVSInfoPoint1;
                        locnumericUpDown2.Value = Info.doorVSInfoPoint2;
                        locnumericUpDown3.Value = Info.doorVSInfoPoint3;
                        break;
                    }
                case "Battle Dojo Doors":
                    {
                        masternumericUpDown.Value = Info.doorDojoInfoSizeMaster;
                        numericUpDown1.Value = Info.doorDojoInfoSize1;
                        numericUpDown3.Value = Info.doorDojoInfoSize2;
                        numericUpDown4.Value = Info.doorDojoInfoSize3;
                        locnumericUpDown1.Value = Info.doorDojoInfoPoint1;
                        locnumericUpDown2.Value = Info.doorDojoInfoPoint2;
                        locnumericUpDown3.Value = Info.doorDojoInfoPoint3;
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
                case "Arcade":
                    {
                        Info.arcadeInfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                        Info.arcadeInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Manhole":
                    {
                        Info.manHoleInfoSize(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value);
                        Info.manHoleInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Weapon Sign":
                    {
                        Info.weaponSignInfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                        Info.weaponSignInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Awning":
                    {
                        Info.clothInfoSize(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value);
                        Info.clothInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Main TV":
                    {
                        Info.tvInfoSize(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value);
                        Info.tvInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Great Zapfish":
                    {
                        Info.fishInfoSize(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value);
                        Info.fishInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
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
                case "Bird 1":
                    {
                        Info.bird1InfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                        Info.bird1InfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Bird 2":
                    {
                        Info.bird2InfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                        Info.bird2InfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Bird 3":
                    {
                        Info.bird3InfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                        Info.bird3InfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Bird 4":
                    {
                        Info.bird4InfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                        Info.bird4InfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Bird 5":
                    {
                        Info.bird5InfoSize(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value);
                        Info.bird5InfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Doory (Cooler Heads)":
                    {
                        Info.doorHatInfoSize(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value);
                        Info.doorHatInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Doorothy (Jelly Fresh)":
                    {
                        Info.doorShirtInfoSize(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value);
                        Info.doorShirtInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Doorian (Shrimp Kicks)":
                    {
                        Info.doorShoesInfoSize(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value);
                        Info.doorShoesInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Dooris (Ammo Knights)":
                    {
                        Info.doorWeaponInfoSize(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value);
                        Info.doorWeaponInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Inkopolis Tower Door":
                    {
                        Info.doorVSInfoSize(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value);
                        Info.doorVSInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Battle Dojo Doors":
                    {
                        Info.doorDojoInfoSize(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value);
                        Info.doorDojoInfoPoint(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
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
                case "Arcade":
                    {
                        Info.arcadeMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Manhole":
                    {
                        Info.manHoleMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Weapon Sign":
                    {
                        Info.weaponSignMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Awning":
                    {
                        Info.clothMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Main TV":
                    {
                        Info.tvMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Great Zapfish":
                    {
                        Info.fishMasterScale(masternumericUpDown.Value);
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
                case "Bird 1":
                    {
                        Info.bird1MasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Bird 2":
                    {
                        Info.bird2MasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Bird 3":
                    {
                        Info.bird3MasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Bird 4":
                    {
                        Info.bird4MasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Bird 5":
                    {
                        Info.bird5MasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Doory (Cooler Heads)":
                    {
                        Info.doorHatMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Doorothy (Jelly Fresh)":
                    {
                        Info.doorShirtMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Doorian (Shrimp Kicks)":
                    {
                        Info.doorShoesMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Dooris (Ammo Knights)":
                    {
                        Info.doorWeaponMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Inkopolis Tower Door":
                    {
                        Info.doorVSMasterScale(masternumericUpDown.Value);
                        break;
                    }
                case "Battle Dojo Doors":
                    {
                        Info.doorDojoMasterScale(masternumericUpDown.Value);
                        break;
                    }
            }
        }
    }
}
