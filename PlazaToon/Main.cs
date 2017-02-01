using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;


namespace PlazaToon
{
    public partial class Main : Form
    {
        public static TCPGecko gecko = null;
        Control rattata = null;

        public static uint sistersAddr;
        public static uint NPCAddr;
        public static uint spykeAddr;
        public static uint NPCAddr2;
        public static int Sign;
        public static uint triparamSizeDefault = 0x3F800000;

        //arrays
        //obj with no rotation are not necesary as size array:
        //train, tree, judd, Cloth
        public static uint[] amiiboSize = new uint[9] { 0xBF4201FA, 0, 0x3F270623, 0, 0x3F800000, 0, 0xBF270623, 0, 0xBF4201FA }; //
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
        public static uint[] tree1Point = new uint[3] { 0xC31F9663, 0x00000000, 0x42E39610 };
        public static uint[] tree2Point = new uint[3] { 0x4389D236, 0x3FB80000, 0x43B6BB6E };
        public static uint[] tree3Point = new uint[3] { 0x43AE55BC, 0x3FC82E70, 0x43AEB932 };
        public static uint[] tree4Point = new uint[3] { 0x43D8DA7B, 0x40AA7A2F, 0x438A87D9 };
        public static uint[] arcadePoint = new uint[3] { 0xC35546E2, 0x3DCCCCC7, 0x43152D36 };
        public static uint[] manHolePoint = new uint[3] { 0x42FEDB3C, 0x3E99999A, 0xC366BFA6 };
        public static uint[] originPoint = new uint[3] { 0x00000000, 0x00000000, 0x00000000 };
        public static uint[] weaponSignPoint = new uint[3] { 0xC2E61AF8, 0x00000000, 0xC33DCB02 };
        public static uint[] fishPoint = new uint[3] { 0xB5FC0000, 0x4320D7C4, 0xC3FF86B2 };
        public static uint[] clothPoint = new uint[3] { 0xC34A999A, 0x42300000, 0x432C0000 };
        public static uint[] bird1Point = new uint[3] { 0x4291315F, 0x41E17CCD, 0x438D1305 };
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

        private static string GetNumbers(string input)
        {
            return new string(input.Where(c => char.IsDigit(c)).ToArray());
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
                Info.info.IPAddr = IPBox.Text;
                ConnectButton.BackColor = Color.FromArgb(50, 145, 245); //light blue change indicating Loadiine

                if (autoModeToolStripMenuItem.Checked == true)
                {
                    ConnectButton.Text = "Recalculate";
                }

                if (gecko != null)
                {
                    DisconnButton.BackColor = Color.FromArgb(225, 39, 39);
                    recalculateAddr();
                    NPCSizeUpdate();
                    numericBoxLoad();
                    NPCcomboBox.Focus();
                }
            }
            else
            {
                if (ConnectButton.Text == "Recalculate")
                {
                    displayMsg("Addresses have been recalculated.");
                }
                recalculateAddr();
                NPCSizeUpdate();
            }
        }
        private void recalculateAddr()
        {
            uint baseaddr = gecko.peek(0x106E5814);

            sistersAddr = gecko.peek(baseaddr + 0xBB0);
            NPCAddr = gecko.peek(baseaddr + 0xDD0);
            NPCAddr2 = gecko.peek(baseaddr + 0xDC8);
            spykeAddr = gecko.peek(baseaddr + 0xDD8);
            //[[0x106E5814] + 0xDD0] + 0x NPCAddr
            //[[0x106E5814] + 0xDC8] + 0x NPCAddr2
            //[[0x106E5814] + 0xDD8] - 0x spyke addr
            //[[0x106E5814] + 0xBB0] + 0x sistersAddr
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
                DisconnButton.BackColor = Color.FromArgb(200, 40, 50);
            }
        }

        private void resetAllToolStripMenuItem_Click(object sender, EventArgs e) //resets all variables, sizes and locations in-game to default
        {
            var confirmResult = MessageBox.Show("Are you sure you want to reset the size and location for all NPCs?",
                "Reset All", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (confirmResult == DialogResult.Yes) //confirmation to reset
            {
                if (gecko != null)
                    recalculateAddr();
                Info.info.resetti(1, true);
                NPCSizeUpdate();
                numericBoxLoad();
                displayMsg("All data has been resetted.");
                MessageBox.Show("All data has been resetted.",
                    "Saved Data has been Restored", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void setSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(customToolStripTextBox.Text);
                var confirmResult = MessageBox.Show("Do you want to set all the NPCs to " + i + "x times their size?",
                    "Set custom size to All", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (confirmResult == DialogResult.Yes) //confirmation to reset
                {
                    if (gecko != null)
                        recalculateAddr();
                    Info.info.resetti(i, false);
                    NPCSizeUpdate();
                    numericBoxLoad();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The number entered was invalid. Please try again.",
                    "The Value was not a Number", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                customToolStripTextBox.Text = GetNumbers(customToolStripTextBox.Text);
            }
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to reload the size and location for all NPCs?",
                "Reload All ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (confirmResult == DialogResult.Yes) //confirmation to reset
            {
                if (gecko != null)
                    recalculateAddr(); Info.info.loadi();
                NPCSizeUpdate();
                numericBoxLoad();
                displayMsg("All settings has been reloaded.");
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
            NPCSizeUpdate();
            numericBoxLoad();
        }

        private void NPCcomboBox_MouseUp(object sender, MouseEventArgs e) { NPCsav(); rattata = (Control)sender; }

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
            if (!NPCcomboBox.ContainsFocus && autoModeToolStripMenuItem.Checked == true) { locUpdate1(); }
        }
        private void locnumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (!NPCcomboBox.ContainsFocus && autoModeToolStripMenuItem.Checked == true) { locUpdate2(); }
        }
        private void locnumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (!NPCcomboBox.ContainsFocus && autoModeToolStripMenuItem.Checked == true) { locUpdate3(); }
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
        //saves with keydowns
        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode != Keys.OemMinus && e.KeyCode != Keys.Back) { NPCsav(); } }
        private void numericUpDown2_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode != Keys.OemMinus && e.KeyCode != Keys.Back) { NPCsav(); } }
        private void numericUpDown3_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode != Keys.OemMinus && e.KeyCode != Keys.Back) { NPCsav(); } }
        private void numericUpDown4_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode != Keys.OemMinus && e.KeyCode != Keys.Back) { NPCsav(); } }
        private void numericUpDown5_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode != Keys.OemMinus && e.KeyCode != Keys.Back) { NPCsav(); } }
        private void locnumericUpDown1_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode != Keys.OemMinus && e.KeyCode != Keys.Back) { NPCsav(); } }
        private void locnumericUpDown2_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode != Keys.OemMinus && e.KeyCode != Keys.Back) { NPCsav(); } }
        private void locnumericUpDown3_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode != Keys.OemMinus && e.KeyCode != Keys.Back) { NPCsav(); } }
        //Master scale seperate save
        private void masternumericUpDown_MouseUp(object sender, MouseEventArgs e) { rattata = (Control)sender; NPCsav(); }
        private void masternumericUpDown_KeyUp(object sender, KeyEventArgs e) { rattata = (Control)sender; if (e.KeyCode != Keys.OemMinus && e.KeyCode != Keys.Back) { NPCsav(); } }

        //click the labels to set the values to 1 and 0
        private void xScaleLabel_Click(object sender, EventArgs e) { numericUpDown1.Focus(); numericUpDown1.Value = 1; NPCsav(); }
        private void yScaleLabel_Click(object sender, EventArgs e) { numericUpDown3.Focus(); numericUpDown3.Value = 1; NPCsav(); }
        private void zScaleLabel_Click(object sender, EventArgs e) { numericUpDown4.Focus(); numericUpDown4.Value = 1; NPCsav(); }
        private void x2ScaleLabel_Click(object sender, EventArgs e) { numericUpDown2.Focus(); numericUpDown2.Value = 1; NPCsav(); }
        private void z2label_Click(object sender, EventArgs e) { numericUpDown5.Focus(); numericUpDown5.Value = 1; NPCsav(); }
        private void masterLabel_Click(object sender, EventArgs e) { masternumericUpDown.Focus(); masternumericUpDown.Value = 1; NPCsav(); }

        private void locxlabel_Click(object sender, EventArgs e) { locnumericUpDown1.Focus(); locnumericUpDown1.Value = 0; NPCsav(); }
        private void locyLabel_Click(object sender, EventArgs e) { locnumericUpDown1.Focus(); locnumericUpDown2.Value = 0; NPCsav(); }
        private void loczLabel_Click(object sender, EventArgs e) { locnumericUpDown1.Focus(); locnumericUpDown3.Value = 0; NPCsav(); }

        //manual mode switch
        private void autoModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autoModeToolStripMenuItem.Checked == false)
            {
                if (gecko != null) { recalculateAddr(); ConnectButton.Text = "Recalculate"; }
                autoModeToolStripMenuItem.Checked = true;
                manualGroupBox.Visible = false;
                autoModeToolStripMenuItem.BackColor = SystemColors.MenuHighlight;
                manualGroupBox.Location = new Point(3, 350);
                multiLabel.Location = new Point(6, 315);
                creatorLabel.Location = new Point(279, 315);
                Size = new Size(367, 371);
                if (rattata != null) { rattata.Focus(); }
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
                if (rattata != null) { rattata.Focus(); }
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
            if (gecko != null && ValidMemory.validAddress(NPCSizeAddr[0]))
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
        
        private void NPCSizeUpdate() //Where NPC Data is handled
        {
            switch (NPCcomboBox.Text)
            {
                case "Callie":
                    {
                        NPC5Offset(callieSize, sistersAddr, 0, 0x328);
                        break;
                    }
                case "Callie's Chair":
                    {
                        NPC5Offset(calliechairSize, NPCAddr, 0, 0x6BC);
                        break;
                    }
                case "Marie":
                    {
                        NPC5Offset(marieSize, sistersAddr, 0, 0x7BC);
                        break;
                    }
                case "Marie's Chair":
                    {
                        NPC5Offset(mariechairSize, NPCAddr, 0, 0xAC0);
                        break;
                    }
                case "Judd":
                    {
                        NPC3Offset(NPCAddr2, 0, 0xBA0);
                        break;
                    }
                case "Spyke":
                    {
                        NPC5Offset(spykeSize, spykeAddr, 1, 0x538);
                        break;
                    }
                case "Sea Snails":
                    {
                        NPC5Offset(shellSize, NPCAddr2, 1, 0x4DB4);
                        break;
                    }
                case "Train":
                    {
                        NPC3Offset(NPCAddr2, 1, 0x8248);
                        break;
                    }
                case "Amiibo Box":
                    {
                        NPC5Offset(amiiboSize, NPCAddr, 1, 0x608);
                        break;
                    }
                case "Balloon":
                    {
                        NPC5Offset(balloonSize, NPCAddr2, 1, 0x76F4);
                        break;
                    }
                case "Miiverse Post":
                    {
                        NPC5Offset(postSize, NPCAddr2, 0, 0x160);
                        break;
                    }
                case "Arcade":
                    {
                        NPC5Offset(arcadeSize, NPCAddr, 0, 0x140);
                        break;
                    }
                case "Manhole":
                    {
                        NPC3Offset(NPCAddr2, 1, 0x6FC);
                        break;
                    }
                case "Weapon Sign":
                    {
                        NPC5Offset(weaponSignSize, NPCAddr2, 1, 0x5804);
                        break;
                    }
                case "Awning":
                    {
                        NPC3Offset(NPCAddr2, 1, 0x2EC4);
                        break;
                    }
                case "Main TV":
                    {
                        NPC3Offset(sistersAddr, 0, 0x28F4);
                        break;
                    }
                case "Great Zapfish":
                    {
                        NPC3Offset(NPCAddr, 0, 0x3730);
                        break;
                    }
                case "Tree 1":
                    {
                        NPC3Offset(NPCAddr2, 1, 0x6CA4);
                        break;
                    }
                case "Tree 2":
                    {
                        NPC3Offset(NPCAddr2, 1, 0x6254);
                        break;
                    }
                case "Tree 3":
                    {
                        NPC3Offset(NPCAddr2, 1, 0x4364);
                        break;
                    }
                case "Tree 4":
                    {
                       NPC3Offset(NPCAddr2, 1, 0x3914);
                        break;
                    }
                case "Bird 1":
                    {
                        NPC5Offset(birdSize, NPCAddr2, 1, 0x2384);
                        break;
                    }
                case "Bird 2":
                    {
                        NPC5Offset(bird2Size, NPCAddr2, 1, 0x1DF8);
                        break;
                    }
                case "Bird 3":
                    {
                        NPC5Offset(bird3Size, NPCAddr2, 1, 0x186C);
                        break;
                    }
                case "Bird 4":
                    {
                        NPC5Offset(bird4Size, NPCAddr2, 1, 0x12E0);
                        break;
                    }
                case "Bird 5":
                    {
                       NPC5Offset(bird5Size, NPCAddr2, 1, 0xD54);
                        break;
                    }
                case "Doory (Cooler Heads)":
                    {
                        NPC3Offset(NPCAddr, 0, 0xEE8);
                        break;
                    }
                case "Doorothy (Jelly Fresh)":
                    {
                       NPC3Offset(NPCAddr, 0, 0x1C10);
                        break;
                    }
                case "Doorian (Shrimp Kicks)":
                    {
                        NPC3Offset(NPCAddr, 0, 0x157C);
                        break;
                    }
                case "Dooris (Ammo Knights)":
                    {
                        NPC3Offset(NPCAddr, 0, 0x22A4);
                        break;
                    }
                case "Inkopolis Tower Door":
                    {
                       NPC3Offset(NPCAddr, 0, 0x2938);
                        break;
                    }
                case "Battle Dojo Doors":
                    {
                       NPC3Offset(NPCAddr, 0, 0x2FCC);
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
                        value5numBox(Info.info.callieInfo);
                        break;
                    }
                case "Callie's Chair":
                    {
                        value5numBox(Info.info.callieChairInfo);
                        break;
                    }
                case "Marie":
                    {
                        value5numBox(Info.info.marieInfo);
                        break;
                    }
                case "Marie's Chair":
                    {
                        value5numBox(Info.info.marieChairInfo);
                        break;
                    }
                case "Judd":
                    {
                       value3numBox(Info.info.juddInfo);
                        break;
                    }
                case "Spyke":
                    {
                        value5numBox(Info.info.spykeInfo);
                        break;
                    }
                case "Sea Snails":
                    {
                        value5numBox(Info.info.shellInfo);
                        break;
                    }
                case "Train":
                    {
                        value3numBox(Info.info.trainInfo);
                        break;
                    }
                case "Amiibo Box":
                    {
                        value5numBox(Info.info.amiiboInfo);
                        break;
                    }
                case "Balloon":
                    {
                        value5numBox(Info.info.balloonInfo);
                        break;
                    }
                case "Miiverse Post":
                    {
                        value5numBox(Info.info.postInfo);
                        break;
                    }
                case "Arcade":
                    {
                        value5numBox(Info.info.arcadeInfo);
                        break;
                    }
                case "Manhole":
                    {
                        value3numBox(Info.info.manHoleInfo);
                        break;
                    }
                case "Weapon Sign":
                    {
                        value5numBox(Info.info.weaponSignInfo);
                        break;
                    }
                case "Awning":
                    {
                        value3numBox(Info.info.clothInfo);
                        break;
                    }
                case "Main TV":
                    {
                        value3numBox(Info.info.tvInfo);
                        break;
                    }
                case "Great Zapfish":
                    {
                        value3numBox(Info.info.fishInfo);
                        break;
                    }
                case "Tree 1":
                    {
                        value3numBox(Info.info.tree1Info);
                        break;
                    }
                case "Tree 2":
                    {
                        value3numBox(Info.info.tree2Info);
                        break;
                    }
                case "Tree 3":
                    {
                        value3numBox(Info.info.tree3Info);
                        break;
                    }
                case "Tree 4":
                    {
                        value3numBox(Info.info.tree4Info);
                        break;
                    }
                case "Bird 1":
                    {
                        value5numBox(Info.info.bird1Info);
                        break;
                    }
                case "Bird 2":
                    {
                       value5numBox(Info.info.bird2Info);
                        break;
                    }
                case "Bird 3":
                    {
                        value5numBox(Info.info.bird3Info);
                        break;
                    }
                case "Bird 4":
                    {
                        value5numBox(Info.info.bird4Info);
                        break;
                    }
                case "Bird 5":
                    {
                        value5numBox(Info.info.bird5Info);
                        break;
                    }
                case "Dooris (Ammo Knights)":
                    {
                        value3numBox(Info.info.doorWeaponInfo);
                        break;
                    }
                case "Doory (Cooler Heads)":
                    {
                        value3numBox(Info.info.doorHatInfo);
                        break;
                    }
                case "Doorothy (Jelly Fresh)":
                    {
                        value3numBox(Info.info.doorShirtInfo);
                        break;
                    }
                case "Doorian (Shrimp Kicks)":
                    {
                        value3numBox(Info.info.doorShoesInfo);
                        break;
                    }
                case "Inkopolis Tower Door":
                    {
                        value3numBox(Info.info.doorVSInfo);
                        break;
                    }
                case "Battle Dojo Doors":
                    {
                        value3numBox(Info.info.doorDojoInfo);
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
                        Info.info.callieInfoSizeSav(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value, masternumericUpDown.Value);
                        Info.info.callieInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Callie's Chair":
                    {
                        Info.info.callieChairInfoSizeSav(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value, masternumericUpDown.Value);
                        Info.info.callieChairInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Marie":
                    {
                        Info.info.marieInfoSizeSav(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value, masternumericUpDown.Value);
                        Info.info.marieInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Marie's Chair":
                    {
                        Info.info.marieChairInfoSizeSav(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value, masternumericUpDown.Value);
                        Info.info.marieChairInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Judd":
                    {
                        Info.info.juddInfoSizeSav(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value, masternumericUpDown.Value);
                        Info.info.juddInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Spyke":
                    {
                        Info.info.spykeInfoSizeSav(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value, masternumericUpDown.Value);
                        Info.info.spykeInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Sea Snails":
                    {
                        Info.info.shellInfoSizeSav(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value, masternumericUpDown.Value);
                        Info.info.shellInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Train":
                    {
                        Info.info.trainInfoSizeSav(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value, masternumericUpDown.Value);
                        Info.info.trainInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Amiibo Box":
                    {
                        Info.info.amiiboInfoSizeSav(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value, masternumericUpDown.Value);
                        Info.info.amiiboInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Balloon":
                    {
                        Info.info.balloonInfoSizeSav(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value, masternumericUpDown.Value);
                        Info.info.balloonInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Miiverse Post":
                    {
                        Info.info.postInfoSizeSav(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value, masternumericUpDown.Value);
                        Info.info.postInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Arcade":
                    {
                        Info.info.arcadeInfoSizeSav(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value, masternumericUpDown.Value);
                        Info.info.arcadeInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Manhole":
                    {
                        Info.info.manHoleInfoSizeSav(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value, masternumericUpDown.Value);
                        Info.info.manHoleInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Weapon Sign":
                    {
                        Info.info.weaponSignInfoSizeSav(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value, masternumericUpDown.Value);
                        Info.info.weaponSignInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Awning":
                    {
                        Info.info.clothInfoSizeSav(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value, masternumericUpDown.Value);
                        Info.info.clothInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Main TV":
                    {
                        Info.info.tvInfoSizeSav(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value, masternumericUpDown.Value);
                        Info.info.tvInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Great Zapfish":
                    {
                        Info.info.fishInfoSizeSav(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value, masternumericUpDown.Value);
                        Info.info.fishInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Tree 1":
                    {
                        Info.info.tree1InfoSizeSav(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value, masternumericUpDown.Value);
                        Info.info.tree1InfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Tree 2":
                    {
                        Info.info.tree2InfoSizeSav(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value, masternumericUpDown.Value);
                        Info.info.tree2InfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Tree 3":
                    {
                        Info.info.tree3InfoSizeSav(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value, masternumericUpDown.Value);
                        Info.info.tree3InfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Tree 4":
                    {
                        Info.info.tree4InfoSizeSav(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value, masternumericUpDown.Value);
                        Info.info.tree4InfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Bird 1":
                    {
                        Info.info.bird1InfoSizeSav(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value, masternumericUpDown.Value);
                        Info.info.bird1InfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Bird 2":
                    {
                        Info.info.bird2InfoSizeSav(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value, masternumericUpDown.Value);
                        Info.info.bird2InfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Bird 3":
                    {
                        Info.info.bird3InfoSizeSav(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value, masternumericUpDown.Value);
                        Info.info.bird3InfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Bird 4":
                    {
                        Info.info.bird4InfoSizeSav(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value, masternumericUpDown.Value);
                        Info.info.bird4InfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Bird 5":
                    {
                        Info.info.bird5InfoSizeSav(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value, masternumericUpDown.Value);
                        Info.info.bird5InfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Doory (Cooler Heads)":
                    {
                        Info.info.doorHatInfoSizeSav(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value, masternumericUpDown.Value);
                        Info.info.doorHatInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Doorothy (Jelly Fresh)":
                    {
                        Info.info.doorShirtInfoSizeSav(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value, masternumericUpDown.Value);
                        Info.info.doorShirtInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Doorian (Shrimp Kicks)":
                    {
                        Info.info.doorShoesInfoSizeSav(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value, masternumericUpDown.Value);
                        Info.info.doorShoesInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Dooris (Ammo Knights)":
                    {
                        Info.info.doorWeaponInfoSizeSav(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value, masternumericUpDown.Value);
                        Info.info.doorWeaponInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Inkopolis Tower Door":
                    {
                        Info.info.doorVSInfoSizeSav(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value, masternumericUpDown.Value);
                        Info.info.doorVSInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
                case "Battle Dojo Doors":
                    {
                        Info.info.doorDojoInfoSizeSav(numericUpDown1.Value, numericUpDown3.Value, numericUpDown4.Value, masternumericUpDown.Value);
                        Info.info.doorDojoInfoPointSav(locnumericUpDown1.Value, locnumericUpDown2.Value, locnumericUpDown3.Value);
                        break;
                    }
            }
        }

        //defines NPCSize, NPCSizeAddr, and NPCPointData arrays for controls depending on the selected NPC
        private void NPC5Offset(uint[] array, uint addr, uint sign, uint offset)
        {
            for (uint i = 0; i <= 4; i++)
                NPCSizeData[i] = array[i * 2];

            if (sign == 0)
                NPCSizeAddr[0] = addr + offset;
            else
                NPCSizeAddr[0] = addr - offset;


            if (NPCSizeData[1] == callieSize[2] || NPCSizeData[1] == marieSize[2]) //for the squid sisters
            {
                NPCSizeAddr[1] = NPCSizeAddr[0] + 0x8;
                NPCSizeAddr[2] = NPCSizeAddr[0] + 0x14;
                NPCSizeAddr[3] = NPCSizeAddr[0] + 0x20;
                NPCSizeAddr[4] = NPCSizeAddr[0] + 0x28;

                for (uint i = 0; i < 3; i++)
                    NPCPointData[i] = NPCSizeAddr[0] + 0xC + (i * 0x10);
            }
            else //for everything else
            {
                for (uint i = 0; i <= 4; i++)
                {
                    NPCSizeAddr[i] = NPCSizeAddr[0] + (i * 0x8);

                    if (i < 3)
                        NPCPointData[i] = NPCSizeAddr[0] + 0x24 + (i * 0x4);
                }
            }
            
        }

        private void NPC3Offset(uint addr, uint sign, uint offset)
        {
            NPCSizeData[0] = triparamSizeDefault;
            NPCSizeData[2] = triparamSizeDefault;
            NPCSizeData[3] = triparamSizeDefault;

            if (sign == 0)
                NPCSizeAddr[0] = addr + offset;
            else
                NPCSizeAddr[0] = addr - offset;

            NPCSizeAddr[2] = NPCSizeAddr[0] + 0x10;
            NPCSizeAddr[3] = NPCSizeAddr[0] + 0x20;

            for (uint i = 0; i < 3; i++)
                NPCPointData[i] = NPCSizeAddr[0] + 0x24 + (i * 0x4);
        }

        private void value5numBox(decimal[] array)
        {
            numericUpDown1.Value = array[0];
            numericUpDown2.Value = array[1];
            numericUpDown3.Value = array[2];
            numericUpDown4.Value = array[3];
            numericUpDown5.Value = array[4];
            masternumericUpDown.Value = array[5];
            locnumericUpDown1.Value = array[6];
            locnumericUpDown2.Value = array[7];
            locnumericUpDown3.Value = array[8];
        }

        private void value3numBox(decimal[] array)
        {
            numericUpDown1.Value = array[0];
            numericUpDown3.Value = array[1];
            numericUpDown4.Value = array[2];
            masternumericUpDown.Value = array[5];
            locnumericUpDown1.Value = array[6];
            locnumericUpDown2.Value = array[7];
            locnumericUpDown3.Value = array[8];
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Info.loadData();
            numericBoxLoad();
            IPBox.Text = Info.info.IPAddr;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Info.savData();
        }
    }
}
