using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlazaToon
{
    class Info
    {
        public static TCPGecko gecko;
        public static float hex2Float(uint val) //uint to float converter from the joyous amibu
        {
            return BitConverter.ToSingle(BitConverter.GetBytes(val), 0);
        }
        private static decimal vert(uint sweetdreams)
        {
            return Convert.ToDecimal(Main.hex2Float(sweetdreams));
        }
        //RESET
        public static void resetti()
        {
            gecko = Main.gecko;
            callieInfoSize(1, 1, 1, 1, 1);
            callieChairInfoSize(1, 1, 1, 1, 1);
            marieInfoSize(1, 1, 1, 1, 1);
            marieChairInfoSize(1, 1, 1, 1, 1);
            juddInfoSize(1, 1, 1);
            spykeInfoSize(1, 1, 1, 1, 1);
            shellInfoSize(1, 1, 1, 1, 1);
            trainInfoSize(1, 1, 1);
            amiiboInfoSize(1, 1, 1, 1, 1);
            balloonInfoSize(1, 1, 1, 1, 1);
            postInfoSize(1, 1, 1, 1, 1);
            tree1InfoSize(1, 1, 1);
            tree2InfoSize(1, 1, 1);
            tree3InfoSize(1, 1, 1);
            tree4InfoSize(1, 1, 1);
            arcadeInfoSize(1, 1, 1, 1, 1);
            manholeInfoSize(1, 1, 1);
            weaponsignInfoSize(1, 1, 1, 1, 1);

            callieMasterScale(1);
            callieChairMasterScale(1);
            marieMasterScale(1);
            marieChairMasterScale(1);
            juddMasterScale(1);
            spykeMasterScale(1);
            shellMasterScale(1);
            trainMasterScale(1);
            amiiboMasterScale(1);
            balloonMasterScale(1);
            postMasterScale(1);
            tree1MasterScale(1);
            tree2MasterScale(1);
            tree3MasterScale(1);
            tree4MasterScale(1);
            arcadeMasterScale(1);
            manholeMasterScale(1);
            weaponsignMasterScale(1);

            callieInfoPoint(vert(Main.calliePoint[0]),
                vert(Main.calliePoint[1]),
                vert(Main.calliePoint[2]));

            callieChairInfoPoint(vert(Main.calliePoint[0]),
                vert(Main.calliePoint[1]),
                vert(Main.calliePoint[2]));

            marieInfoPoint(vert(Main.mariePoint[0]),
                vert(Main.mariePoint[1]),
                vert(Main.mariePoint[2]));

            marieChairInfoPoint(vert(Main.mariePoint[0]),
                vert(Main.mariePoint[1]),
                vert(Main.mariePoint[2]));

            juddInfoPoint(vert(Main.juddPoint[0]),
                vert(Main.juddPoint[1]),
                vert(Main.juddPoint[2]));

            spykeInfoPoint(vert(Main.spykePoint[0]),
                vert(Main.spykePoint[1]),
                vert(Main.spykePoint[2]));

            shellInfoPoint(vert(Main.shellPoint[0]),
                vert(Main.shellPoint[1]),
                vert(Main.shellPoint[2]));

            trainInfoPoint(0, 0, 0);

            amiiboInfoPoint(vert(Main.amiiboPoint[0]),
                vert(Main.amiiboPoint[1]),
                vert(Main.amiiboPoint[2]));

            balloonInfoPoint(vert(Main.balloonPoint[0]),
                vert(Main.balloonPoint[1]),
                vert(Main.balloonPoint[2]));

            postInfoPoint(vert(Main.postPoint[0]),
                vert(Main.postPoint[1]),
                vert(Main.postPoint[2]));

            tree1InfoPoint(vert(Main.treePoint[0]),
                vert(Main.treePoint[1]),
                vert(Main.treePoint[2]));

            tree2InfoPoint(vert(Main.tree2Point[0]),
                vert(Main.tree2Point[1]),
                vert(Main.tree2Point[2]));

            tree3InfoPoint(vert(Main.tree3Point[0]),
                vert(Main.tree3Point[1]),
                vert(Main.tree3Point[2]));

            tree4InfoPoint(vert(Main.tree4Point[0]),
                vert(Main.tree4Point[1]),
                vert(Main.tree4Point[2]));

            arcadeInfoPoint(vert(Main.arcadePoint[0]),
                vert(Main.arcadePoint[1]),
                vert(Main.arcadePoint[2]));

            manholeInfoPoint(vert(Main.manholePoint[0]),
                vert(Main.manholePoint[1]),
                vert(Main.manholePoint[2]));

            weaponsignInfoPoint(vert(Main.weaponsignPoint[0]),
                vert(Main.weaponsignPoint[1]),
                vert(Main.weaponsignPoint[2]));

            //Callie
            gecko.poke(Main.sistersAddr + 0x328, Main.callieSize[0]);
            gecko.poke(Main.sistersAddr + 0x330, Main.callieSize[2]);
            gecko.poke(Main.sistersAddr + 0x33C, Main.callieSize[4]);
            gecko.poke(Main.sistersAddr + 0x348, Main.callieSize[6]);
            gecko.poke(Main.sistersAddr + 0x350, Main.callieSize[8]);

            gecko.poke(Main.sistersAddr + 0x334, Main.calliePoint[0]);
            gecko.poke(Main.sistersAddr + 0x344, Main.calliePoint[1]);
            gecko.poke(Main.sistersAddr + 0x354, Main.calliePoint[2]);
            //Callie's Chair
            gecko.poke(Main.NPCAddr + 0x6BC, Main.calliechairSize[0]);
            gecko.poke(Main.NPCAddr + 0x6C4, Main.calliechairSize[2]);
            gecko.poke(Main.NPCAddr + 0x6CC, Main.calliechairSize[4]);
            gecko.poke(Main.NPCAddr + 0x6D4, Main.calliechairSize[6]);
            gecko.poke(Main.NPCAddr + 0x6DC, Main.calliechairSize[8]);

            gecko.poke(Main.NPCAddr + 0x6E0, Main.calliePoint[0]);
            gecko.poke(Main.NPCAddr + 0x6E4, Main.calliePoint[1]);
            gecko.poke(Main.NPCAddr + 0x6E8, Main.calliePoint[2]);
            //Marie
            gecko.poke(Main.sistersAddr + 0x7BC, Main.marieSize[0]);
            gecko.poke(Main.sistersAddr + 0x7C4, Main.marieSize[2]);
            gecko.poke(Main.sistersAddr + 0x7D0, Main.marieSize[4]);
            gecko.poke(Main.sistersAddr + 0x7DC, Main.marieSize[6]);
            gecko.poke(Main.sistersAddr + 0x7E4, Main.marieSize[8]);

            gecko.poke(Main.sistersAddr + 0x7C8, Main.mariePoint[0]);
            gecko.poke(Main.sistersAddr + 0x7D8, Main.mariePoint[1]);
            gecko.poke(Main.sistersAddr + 0x7E8, Main.mariePoint[2]);
            //Marie's Chair
            gecko.poke(Main.NPCAddr + 0xAC0, Main.mariechairSize[0]);
            gecko.poke(Main.NPCAddr + 0xAC8, Main.mariechairSize[2]);
            gecko.poke(Main.NPCAddr + 0xAD0, Main.mariechairSize[4]);
            gecko.poke(Main.NPCAddr + 0xAD8, Main.mariechairSize[6]);
            gecko.poke(Main.NPCAddr + 0xAE0, Main.mariechairSize[8]);

            gecko.poke(Main.NPCAddr + 0xAE4, Main.mariePoint[0]);
            gecko.poke(Main.NPCAddr + 0xAE8, Main.mariePoint[1]);
            gecko.poke(Main.NPCAddr + 0xAEC, Main.mariePoint[2]);
            //Judd
            gecko.poke(Main.NPCAddr - 0xE44, 0x3F800000);
            gecko.poke(Main.NPCAddr - 0xE34, 0x3F800000);
            gecko.poke(Main.NPCAddr - 0xE24, 0x3F800000);

            gecko.poke(Main.NPCAddr - 0xE20, Main.juddPoint[0]);
            gecko.poke(Main.NPCAddr - 0xE1C, Main.juddPoint[1]);
            gecko.poke(Main.NPCAddr - 0xE18, Main.juddPoint[2]);
            //Spyke
            gecko.poke(Main.spykeAddr - 0x538, Main.spykeSize[0]);
            gecko.poke(Main.spykeAddr - 0x530, Main.spykeSize[2]);
            gecko.poke(Main.spykeAddr - 0x528, Main.spykeSize[4]);
            gecko.poke(Main.spykeAddr - 0x520, Main.spykeSize[6]);
            gecko.poke(Main.spykeAddr - 0x518, Main.spykeSize[8]);

            gecko.poke(Main.spykeAddr - 0x514, Main.spykePoint[0]);
            gecko.poke(Main.spykeAddr - 0x510, Main.spykePoint[1]);
            gecko.poke(Main.spykeAddr - 0x50C, Main.spykePoint[2]);
            //Sea Snails
            gecko.poke(Main.NPCAddr - 0x6798, Main.shellSize[0]);
            gecko.poke(Main.NPCAddr - 0x6790, Main.shellSize[2]);
            gecko.poke(Main.NPCAddr - 0x6788, Main.shellSize[4]);
            gecko.poke(Main.NPCAddr - 0x6780, Main.shellSize[6]);
            gecko.poke(Main.NPCAddr - 0x6778, Main.shellSize[8]);

            gecko.poke(Main.NPCAddr - 0x6774, Main.shellPoint[0]);
            gecko.poke(Main.NPCAddr - 0x6770, Main.shellPoint[1]);
            gecko.poke(Main.NPCAddr - 0x676C, Main.shellPoint[2]);
            //Train
            gecko.poke(Main.NPCAddr - 0x9C2C, 0x3F800000);
            gecko.poke(Main.NPCAddr - 0x9C1C, 0x3F800000);
            gecko.poke(Main.NPCAddr - 0x9C0C, 0x3F800000);

            gecko.poke(Main.NPCAddr - 0x9C08, 0);
            gecko.poke(Main.NPCAddr - 0x9C04, 0);
            gecko.poke(Main.NPCAddr - 0x9C00, 0);
            //Amiibo Box
            gecko.poke(Main.NPCAddr - 0x608, Main.amiiboSize[0]);
            gecko.poke(Main.NPCAddr - 0x600, Main.amiiboSize[2]);
            gecko.poke(Main.NPCAddr - 0x5F8, Main.amiiboSize[4]);
            gecko.poke(Main.NPCAddr - 0x5F0, Main.amiiboSize[6]);
            gecko.poke(Main.NPCAddr - 0x5E8, Main.amiiboSize[8]);

            gecko.poke(Main.NPCAddr - 0x5E4, Main.amiiboPoint[0]);
            gecko.poke(Main.NPCAddr - 0x5E0, Main.amiiboPoint[1]);
            gecko.poke(Main.NPCAddr - 0x5DC, Main.amiiboPoint[2]);
            //Balloon
            gecko.poke(Main.NPCAddr - 0x90D8, Main.balloonSize[0]);
            gecko.poke(Main.NPCAddr - 0x90D0, Main.balloonSize[2]);
            gecko.poke(Main.NPCAddr - 0x90C8, Main.balloonSize[4]);
            gecko.poke(Main.NPCAddr - 0x90C0, Main.balloonSize[6]);
            gecko.poke(Main.NPCAddr - 0x90B8, Main.balloonSize[8]);

            gecko.poke(Main.NPCAddr - 0x90B4, Main.balloonPoint[0]);
            gecko.poke(Main.NPCAddr - 0x90B0, Main.balloonPoint[1]);
            gecko.poke(Main.NPCAddr - 0x90AC, Main.balloonPoint[2]);
            //Miiverse Post
            gecko.poke(Main.NPCAddr - 0x1884, Main.postSize[0]);
            gecko.poke(Main.NPCAddr - 0x187C, Main.postSize[2]);
            gecko.poke(Main.NPCAddr - 0x1874, Main.postSize[4]);
            gecko.poke(Main.NPCAddr - 0x186C, Main.postSize[6]);
            gecko.poke(Main.NPCAddr - 0x1864, Main.postSize[8]);

            gecko.poke(Main.NPCAddr - 0x1860, Main.postPoint[0]);
            gecko.poke(Main.NPCAddr - 0x185C, Main.postPoint[1]);
            gecko.poke(Main.NPCAddr - 0x1858, Main.postPoint[2]);
            //Tree
            gecko.poke(Main.NPCAddr - 0x8688, 0x3F800000);
            gecko.poke(Main.NPCAddr - 0x8678, 0x3F800000);
            gecko.poke(Main.NPCAddr - 0x8658, 0x3F800000);

            gecko.poke(Main.NPCAddr - 0x8664, Main.treePoint[0]);
            gecko.poke(Main.NPCAddr - 0x8660, Main.treePoint[1]);
            gecko.poke(Main.NPCAddr - 0x865C, Main.treePoint[2]);
            //Tree 2
            gecko.poke(Main.NPCAddr - 0x7C38, 0x3F800000);
            gecko.poke(Main.NPCAddr - 0x7C28, 0x3F800000);
            gecko.poke(Main.NPCAddr - 0x7C18, 0x3F800000);

            gecko.poke(Main.NPCAddr - 0x7C14, Main.tree2Point[0]);
            gecko.poke(Main.NPCAddr - 0x7C10, Main.tree2Point[1]);
            gecko.poke(Main.NPCAddr - 0x7C0C, Main.tree2Point[2]);
            //Tree 3
            gecko.poke(Main.NPCAddr - 0x5D48, 0x3F800000);
            gecko.poke(Main.NPCAddr - 0x5D38, 0x3F800000);
            gecko.poke(Main.NPCAddr - 0x5D28, 0x3F800000);

            gecko.poke(Main.NPCAddr - 0x5D24, Main.tree3Point[0]);
            gecko.poke(Main.NPCAddr - 0x5D20, Main.tree3Point[1]);
            gecko.poke(Main.NPCAddr - 0x5D1C, Main.tree3Point[2]);
            //Tree 4
            gecko.poke(Main.NPCAddr - 0x52F8, 0x3F800000);
            gecko.poke(Main.NPCAddr - 0x52E8, 0x3F800000);
            gecko.poke(Main.NPCAddr - 0x52D8, 0x3F800000);

            gecko.poke(Main.NPCAddr - 0x52D4, Main.tree4Point[0]);
            gecko.poke(Main.NPCAddr - 0x52D0, Main.tree4Point[1]);
            gecko.poke(Main.NPCAddr - 0x52CC, Main.tree4Point[2]);
            //Arcade
            gecko.poke(Main.NPCAddr + 0x140, Main.arcadeSize[0]);
            gecko.poke(Main.NPCAddr + 0x148, Main.arcadeSize[2]);
            gecko.poke(Main.NPCAddr + 0x150, Main.arcadeSize[4]);
            gecko.poke(Main.NPCAddr + 0x158, Main.arcadeSize[6]);
            gecko.poke(Main.NPCAddr + 0x160, Main.arcadeSize[8]);

            gecko.poke(Main.NPCAddr + 0x164, Main.arcadePoint[0]);
            gecko.poke(Main.NPCAddr + 0x168, Main.arcadePoint[1]);
            gecko.poke(Main.NPCAddr + 0x16C, Main.arcadePoint[2]);
            //Manhole
            gecko.poke(Main.manholeAddr - 0x6FC, 0x3F800000);
            gecko.poke(Main.manholeAddr - 0x6EC, 0x3F800000);
            gecko.poke(Main.manholeAddr - 0x6DC, 0x3F800000);

            gecko.poke(Main.manholeAddr - 0x6D8, Main.manholePoint[0]);
            gecko.poke(Main.manholeAddr - 0x6D4, Main.manholePoint[1]);
            gecko.poke(Main.manholeAddr - 0x6D0, Main.manholePoint[2]);
            //Weapon sign
            gecko.poke(Main.NPCAddr - 0x71E8, Main.weaponsignSize[0]);
            gecko.poke(Main.NPCAddr - 0x71E0, Main.weaponsignSize[2]);
            gecko.poke(Main.NPCAddr - 0x71D8, Main.weaponsignSize[4]);
            gecko.poke(Main.NPCAddr - 0x71D0, Main.weaponsignSize[6]);
            gecko.poke(Main.NPCAddr - 0x71C8, Main.weaponsignSize[8]);

            gecko.poke(Main.NPCAddr - 0x71C4, Main.weaponsignPoint[0]);
            gecko.poke(Main.NPCAddr - 0x71C0, Main.weaponsignPoint[1]);
            gecko.poke(Main.NPCAddr - 0x71BC, Main.weaponsignPoint[2]);
        }

        //Callie
        public static decimal callieInfoSize1 = 1;
        public static decimal callieInfoSize2 = 1;
        public static decimal callieInfoSize3 = 1;
        public static decimal callieInfoSize4 = 1;
        public static decimal callieInfoSize5 = 1;
        public static decimal callieInfoSizeMaster = 1;

        public static void callieInfoSize(decimal x1, decimal x2, decimal y, decimal z1, decimal z2)
        {
            callieInfoSize1 = x1;
            callieInfoSize2 = x2;
            callieInfoSize3 = y;
            callieInfoSize4 = z1;
            callieInfoSize5 = z2;
        }
        public static void callieMasterScale(decimal master)
        {
            callieInfoSizeMaster = master;
        }
        public static decimal callieInfoPoint1 = vert(Main.calliePoint[0]);
        public static decimal callieInfoPoint2 = vert(Main.calliePoint[1]);
        public static decimal callieInfoPoint3 = vert(Main.calliePoint[2]);

        public static void callieInfoPoint(decimal x, decimal y, decimal z)
        {
            callieInfoPoint1 = x;
            callieInfoPoint2 = y;
            callieInfoPoint3 = z;
        }
        //Callie's chair
        public static decimal callieChairInfoSize1 = 1;
        public static decimal callieChairInfoSize2 = 1;
        public static decimal callieChairInfoSize3 = 1;
        public static decimal callieChairInfoSize4 = 1;
        public static decimal callieChairInfoSize5 = 1;
        public static decimal callieChairInfoSizeMaster = 1;

        public static void callieChairInfoSize(decimal x1, decimal x2, decimal y, decimal z1, decimal z2)
        {
            callieChairInfoSize1 = x1;
            callieChairInfoSize2 = x2;
            callieChairInfoSize3 = y;
            callieChairInfoSize4 = z1;
            callieChairInfoSize5 = z2;
        }
        public static void callieChairMasterScale(decimal master)
        {
            callieChairInfoSizeMaster = master;
        }
        public static decimal callieChairInfoPoint1 = vert(Main.calliePoint[0]);
        public static decimal callieChairInfoPoint2 = vert(Main.calliePoint[1]);
        public static decimal callieChairInfoPoint3 = vert(Main.calliePoint[2]);

        public static void callieChairInfoPoint(decimal x, decimal y, decimal z)
        {
            callieChairInfoPoint1 = x;
            callieChairInfoPoint2 = y;
            callieChairInfoPoint3 = z;
        }
        //Marie
        public static decimal marieInfoSize1 = 1;
        public static decimal marieInfoSize2 = 1;
        public static decimal marieInfoSize3 = 1;
        public static decimal marieInfoSize4 = 1;
        public static decimal marieInfoSize5 = 1;
        public static decimal marieInfoSizeMaster = 1;

        public static void marieInfoSize(decimal x1, decimal x2, decimal y, decimal z1, decimal z2)
        {
            marieInfoSize1 = x1;
            marieInfoSize2 = x2;
            marieInfoSize3 = y;
            marieInfoSize4 = z1;
            marieInfoSize5 = z2;
        }
        public static void marieMasterScale(decimal master)
        {
            marieInfoSizeMaster = master;
        }
        public static decimal marieInfoPoint1 = vert(Main.mariePoint[0]);
        public static decimal marieInfoPoint2 = vert(Main.mariePoint[1]);
        public static decimal marieInfoPoint3 = vert(Main.mariePoint[2]);

        public static void marieInfoPoint(decimal x, decimal y, decimal z)
        {
            marieInfoPoint1 = x;
            marieInfoPoint2 = y;
            marieInfoPoint3 = z;
        }

        //Marie's chair
        public static decimal marieChairInfoSize1 = 1;
        public static decimal marieChairInfoSize2 = 1;
        public static decimal marieChairInfoSize3 = 1;
        public static decimal marieChairInfoSize4 = 1;
        public static decimal marieChairInfoSize5 = 1;
        public static decimal marieChairInfoSizeMaster = 1;

        public static void marieChairInfoSize(decimal x1, decimal x2, decimal y, decimal z1, decimal z2)
        {
            marieChairInfoSize1 = x1;
            marieChairInfoSize2 = x2;
            marieChairInfoSize3 = y;
            marieChairInfoSize4 = z1;
            marieChairInfoSize5 = z2;
        }
        public static void marieChairMasterScale(decimal master)
        {
            marieChairInfoSizeMaster = master;
        }
        public static decimal marieChairInfoPoint1 = vert(Main.mariePoint[0]);
        public static decimal marieChairInfoPoint2 = vert(Main.mariePoint[1]);
        public static decimal marieChairInfoPoint3 = vert(Main.mariePoint[2]);

        public static void marieChairInfoPoint(decimal x, decimal y, decimal z)
        {
            marieChairInfoPoint1 = x;
            marieChairInfoPoint2 = y;
            marieChairInfoPoint3 = z;
        }
        //Judd
        public static decimal juddInfoSize1 = 1;
        public static decimal juddInfoSize2 = 1;
        public static decimal juddInfoSize3 = 1;
        public static decimal juddInfoSizeMaster = 1;

        public static void juddInfoSize(decimal x, decimal y, decimal z)
        {
            juddInfoSize1 = x;
            juddInfoSize2 = y;
            juddInfoSize3 = z;
        }
        public static void juddMasterScale(decimal master)
        {
            juddInfoSizeMaster = master;
        }
        public static decimal juddInfoPoint1 = vert(Main.juddPoint[0]);
        public static decimal juddInfoPoint2 = vert(Main.juddPoint[1]);
        public static decimal juddInfoPoint3 = vert(Main.juddPoint[2]);

        public static void juddInfoPoint(decimal x, decimal y, decimal z)
        {
            juddInfoPoint1 = x;
            juddInfoPoint2 = y;
            juddInfoPoint3 = z;
        }
        //Spyke
        public static decimal spykeInfoSize1 = 1;
        public static decimal spykeInfoSize2 = 1;
        public static decimal spykeInfoSize3 = 1;
        public static decimal spykeInfoSize4 = 1;
        public static decimal spykeInfoSize5 = 1;
        public static decimal spykeInfoSizeMaster = 1;

        public static void spykeInfoSize(decimal x1, decimal x2, decimal y, decimal z1, decimal z2)
        {
            spykeInfoSize1 = x1;
            spykeInfoSize2 = x2;
            spykeInfoSize3 = y;
            spykeInfoSize4 = z1;
            spykeInfoSize5 = z2;
        }
        public static void spykeMasterScale(decimal master)
        {
            spykeInfoSizeMaster = master;
        }
        public static decimal spykeInfoPoint1 = vert(Main.spykePoint[0]);
        public static decimal spykeInfoPoint2 = vert(Main.spykePoint[1]);
        public static decimal spykeInfoPoint3 = vert(Main.spykePoint[2]);

        public static void spykeInfoPoint(decimal x, decimal y, decimal z)
        {
            spykeInfoPoint1 = x;
            spykeInfoPoint2 = y;
            spykeInfoPoint3 = z;
        }
        //Sea Snails
        public static decimal shellInfoSize1 = 1;
        public static decimal shellInfoSize2 = 1;
        public static decimal shellInfoSize3 = 1;
        public static decimal shellInfoSize4 = 1;
        public static decimal shellInfoSize5 = 1;
        public static decimal shellInfoSizeMaster = 1;

        public static void shellInfoSize(decimal x1, decimal x2, decimal y, decimal z1, decimal z2)
        {
            shellInfoSize1 = x1;
            shellInfoSize2 = x2;
            shellInfoSize3 = y;
            shellInfoSize4 = z1;
            shellInfoSize5 = z2;
        }
        public static void shellMasterScale(decimal master)
        {
            shellInfoSizeMaster = master;
        }
        public static decimal shellInfoPoint1 = vert(Main.shellPoint[0]);
        public static decimal shellInfoPoint2 = vert(Main.shellPoint[1]);
        public static decimal shellInfoPoint3 = vert(Main.shellPoint[2]);

        public static void shellInfoPoint(decimal x, decimal y, decimal z)
        {
            shellInfoPoint1 = x;
            shellInfoPoint2 = y;
            shellInfoPoint3 = z;
        }
        //Train
        public static decimal trainInfoSize1 = 1;
        public static decimal trainInfoSize2 = 1;
        public static decimal trainInfoSize3 = 1;
        public static decimal trainInfoSizeGlobal = 1;
        public static decimal trainInfoSizeMaster = 1;

        public static void trainInfoSize(decimal x, decimal y, decimal z)
        {
            trainInfoSize1 = x;
            trainInfoSize2 = y;
            trainInfoSize3 = z;
        }
        public static void trainMasterScale(decimal master)
        {
            trainInfoSizeMaster = master;
        }
        public static decimal trainInfoPoint1 = 0;
        public static decimal trainInfoPoint2 = 0;
        public static decimal trainInfoPoint3 = 0;

        public static void trainInfoPoint(decimal x, decimal y, decimal z)
        {
            trainInfoPoint1 = x;
            trainInfoPoint2 = y;
            trainInfoPoint3 = z;
        }
        //Amiibo
        public static decimal amiiboInfoSize1 = 1;
        public static decimal amiiboInfoSize2 = 1;
        public static decimal amiiboInfoSize3 = 1;
        public static decimal amiiboInfoSize4 = 1;
        public static decimal amiiboInfoSize5 = 1;
        public static decimal amiiboInfoSizeMaster = 1;

        public static void amiiboInfoSize(decimal x1, decimal x2, decimal y, decimal z1, decimal z2)
        {
            amiiboInfoSize1 = x1;
            amiiboInfoSize2 = x2;
            amiiboInfoSize3 = y;
            amiiboInfoSize4 = z1;
            amiiboInfoSize5 = z2;
        }
        public static void amiiboMasterScale(decimal master)
        {
            amiiboInfoSizeMaster = master;
        }
        public static decimal amiiboInfoPoint1 = vert(Main.amiiboPoint[0]);
        public static decimal amiiboInfoPoint2 = vert(Main.amiiboPoint[1]);
        public static decimal amiiboInfoPoint3 = vert(Main.amiiboPoint[2]);

        public static void amiiboInfoPoint(decimal x, decimal y, decimal z)
        {
            amiiboInfoPoint1 = x;
            amiiboInfoPoint2 = y;
            amiiboInfoPoint3 = z;
        }
        //Balloon
        public static decimal balloonInfoSize1 = 1;
        public static decimal balloonInfoSize2 = 1;
        public static decimal balloonInfoSize3 = 1;
        public static decimal balloonInfoSize4 = 1;
        public static decimal balloonInfoSize5 = 1;
        public static decimal balloonInfoSizeMaster = 1;

        public static void balloonInfoSize(decimal x1, decimal x2, decimal y, decimal z1, decimal z2)
        {
            balloonInfoSize1 = x1;
            balloonInfoSize2 = x2;
            balloonInfoSize3 = y;
            balloonInfoSize4 = z1;
            balloonInfoSize5 = z2;
        }
        public static void balloonMasterScale(decimal master)
        {
            balloonInfoSizeMaster = master;
        }
        public static decimal balloonInfoPoint1 = vert(Main.balloonPoint[0]);
        public static decimal balloonInfoPoint2 = vert(Main.balloonPoint[1]);
        public static decimal balloonInfoPoint3 = vert(Main.balloonPoint[2]);

        public static void balloonInfoPoint(decimal x, decimal y, decimal z)
        {
            balloonInfoPoint1 = x;
            balloonInfoPoint2 = y;
            balloonInfoPoint3 = z;
        }
        //Miiverse Post
        public static decimal postInfoSize1 = 1;
        public static decimal postInfoSize2 = 1;
        public static decimal postInfoSize3 = 1;
        public static decimal postInfoSize4 = 1;
        public static decimal postInfoSize5 = 1;
        public static decimal postInfoSizeMaster = 1;

        public static void postInfoSize(decimal x1, decimal x2, decimal y, decimal z1, decimal z2)
        {
            postInfoSize1 = x1;
            postInfoSize2 = x2;
            postInfoSize3 = y;
            postInfoSize4 = z1;
            postInfoSize5 = z2;
        }
        public static void postMasterScale(decimal master)
        {
            postInfoSizeMaster = master;
        }
        public static decimal postInfoPoint1 = vert(Main.postPoint[0]);
        public static decimal postInfoPoint2 = vert(Main.postPoint[1]);
        public static decimal postInfoPoint3 = vert(Main.postPoint[2]);

        public static void postInfoPoint(decimal x, decimal y, decimal z)
        {
            postInfoPoint1 = x;
            postInfoPoint2 = y;
            postInfoPoint3 = z;
        }
        //Tree 1
        public static decimal tree1InfoSize1 = 1;
        public static decimal tree1InfoSize2 = 1;
        public static decimal tree1InfoSize3 = 1;
        public static decimal tree1InfoSizeMaster = 1;

        public static void tree1InfoSize(decimal x, decimal y, decimal z)
        {
            tree1InfoSize1 = x;
            tree1InfoSize2 = y;
            tree1InfoSize3 = z;
        }
        public static void tree1MasterScale(decimal master)
        {
            tree1InfoSizeMaster = master;
        }
        public static decimal tree1InfoPoint1 = vert(Main.treePoint[0]);
        public static decimal tree1InfoPoint2 = vert(Main.treePoint[1]);
        public static decimal tree1InfoPoint3 = vert(Main.treePoint[2]);

        public static void tree1InfoPoint(decimal x, decimal y, decimal z)
        {
            tree1InfoPoint1 = x;
            tree1InfoPoint2 = y;
            tree1InfoPoint3 = z;
        }
        //Tree 2
        public static decimal tree2InfoSize1 = 1;
        public static decimal tree2InfoSize2 = 1;
        public static decimal tree2InfoSize3 = 1;
        public static decimal tree2InfoSizeMaster = 1;

        public static void tree2InfoSize(decimal x, decimal y, decimal z)
        {
            tree2InfoSize1 = x;
            tree2InfoSize2 = y;
            tree2InfoSize3 = z;
        }
        public static void tree2MasterScale(decimal master)
        {
            tree2InfoSizeMaster = master;
        }
        public static decimal tree2InfoPoint1 = vert(Main.tree2Point[0]);
        public static decimal tree2InfoPoint2 = vert(Main.tree2Point[1]);
        public static decimal tree2InfoPoint3 = vert(Main.tree2Point[2]);

        public static void tree2InfoPoint(decimal x, decimal y, decimal z)
        {
            tree2InfoPoint1 = x;
            tree2InfoPoint2 = y;
            tree2InfoPoint3 = z;
        }
        //Tree 3
        public static decimal tree3InfoSize1 = 1;
        public static decimal tree3InfoSize2 = 1;
        public static decimal tree3InfoSize3 = 1;
        public static decimal tree3InfoSizeMaster = 1;

        public static void tree3InfoSize(decimal x, decimal y, decimal z)
        {
            tree3InfoSize1 = x;
            tree3InfoSize2 = y;
            tree3InfoSize3 = z;
        }
        public static void tree3MasterScale(decimal master)
        {
            tree3InfoSizeMaster = master;
        }
        public static decimal tree3InfoPoint1 = vert(Main.tree3Point[0]);
        public static decimal tree3InfoPoint2 = vert(Main.tree3Point[1]);
        public static decimal tree3InfoPoint3 = vert(Main.tree3Point[2]);

        public static void tree3InfoPoint(decimal x, decimal y, decimal z)
        {
            tree3InfoPoint1 = x;
            tree3InfoPoint2 = y;
            tree3InfoPoint3 = z;
        }
        //Tree 4
        public static decimal tree4InfoSize1 = 1;
        public static decimal tree4InfoSize2 = 1;
        public static decimal tree4InfoSize3 = 1;
        public static decimal tree4InfoSizeMaster = 1;

        public static void tree4InfoSize(decimal x, decimal y, decimal z)
        {
            tree4InfoSize1 = x;
            tree4InfoSize2 = y;
            tree4InfoSize3 = z;
        }
        public static void tree4MasterScale(decimal master)
        {
            tree4InfoSizeMaster = master;
        }
        public static decimal tree4InfoPoint1 = vert(Main.tree4Point[0]);
        public static decimal tree4InfoPoint2 = vert(Main.tree4Point[1]);
        public static decimal tree4InfoPoint3 = vert(Main.tree4Point[2]);

        public static void tree4InfoPoint(decimal x, decimal y, decimal z)
        {
            tree4InfoPoint1 = x;
            tree4InfoPoint2 = y;
            tree4InfoPoint3 = z;
        }
        //Arcade
        public static decimal arcadeInfoSize1 = 1;
        public static decimal arcadeInfoSize2 = 1;
        public static decimal arcadeInfoSize3 = 1;
        public static decimal arcadeInfoSize4 = 1;
        public static decimal arcadeInfoSize5 = 1;
        public static decimal arcadeInfoSizeMaster = 1;

        public static void arcadeInfoSize(decimal x1, decimal x2, decimal y, decimal z1, decimal z2)
        {
            arcadeInfoSize1 = x1;
            arcadeInfoSize2 = x2;
            arcadeInfoSize3 = y;
            arcadeInfoSize4 = z1;
            arcadeInfoSize5 = z2;
        }
        public static void arcadeMasterScale(decimal master)
        {
            arcadeInfoSizeMaster = master;
        }
        public static decimal arcadeInfoPoint1 = vert(Main.arcadePoint[0]);
        public static decimal arcadeInfoPoint2 = vert(Main.arcadePoint[1]);
        public static decimal arcadeInfoPoint3 = vert(Main.arcadePoint[2]);

        public static void arcadeInfoPoint(decimal x, decimal y, decimal z)
        {
            arcadeInfoPoint1 = x;
            arcadeInfoPoint2 = y;
            arcadeInfoPoint3 = z;
        }
        //Manhole
        public static decimal manholeInfoSize1 = 1;
        public static decimal manholeInfoSize2 = 1;
        public static decimal manholeInfoSize3 = 1;
        public static decimal manholeInfoSizeMaster = 1;
        public static void manholeInfoSize(decimal x, decimal y, decimal z)
        {
            manholeInfoSize1 = x;
            manholeInfoSize2 = y;
            manholeInfoSize3 = z;
        }
        public static void manholeMasterScale(decimal master)
        {
            manholeInfoSizeMaster = master;
        }
        public static decimal manholeInfoPoint1 = vert(Main.manholePoint[0]);
        public static decimal manholeInfoPoint2 = vert(Main.manholePoint[1]);
        public static decimal manholeInfoPoint3 = vert(Main.manholePoint[2]);

        public static void manholeInfoPoint(decimal x, decimal y, decimal z)
        {
            manholeInfoPoint1 = x;
            manholeInfoPoint2 = y;
            manholeInfoPoint3 = z;
        }
        //Weapon Sign
        public static decimal weaponsignInfoSize1 = 1;
        public static decimal weaponsignInfoSize2 = 1;
        public static decimal weaponsignInfoSize3 = 1;
        public static decimal weaponsignInfoSize4 = 1;
        public static decimal weaponsignInfoSize5 = 1;
        public static decimal weaponsignInfoSizeMaster = 1;

        public static void weaponsignInfoSize(decimal x1, decimal x2, decimal y, decimal z1, decimal z2)
        {
            weaponsignInfoSize1 = x1;
            weaponsignInfoSize2 = x2;
            weaponsignInfoSize3 = y;
            weaponsignInfoSize4 = z1;
            weaponsignInfoSize5 = z2;
        }
        public static void weaponsignMasterScale(decimal master)
        {
            weaponsignInfoSizeMaster = master;
        }
        public static decimal weaponsignInfoPoint1 = vert(Main.weaponsignPoint[0]);
        public static decimal weaponsignInfoPoint2 = vert(Main.weaponsignPoint[1]);
        public static decimal weaponsignInfoPoint3 = vert(Main.weaponsignPoint[2]);

        public static void weaponsignInfoPoint(decimal x, decimal y, decimal z)
        {
            weaponsignInfoPoint1 = x;
            weaponsignInfoPoint2 = y;
            weaponsignInfoPoint3 = z;
        }
    }
}
