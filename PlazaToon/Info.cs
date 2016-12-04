using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlazaToon
{
    class Info
    {
        public static TCPGecko gecko = Main.gecko;
        private static decimal vert(uint val)
        {
            return Convert.ToDecimal(BitConverter.ToSingle(BitConverter.GetBytes(val), 0));
        }
        public static uint data(uint npc, decimal multiplier)
        {
            var fnum = BitConverter.ToSingle(BitConverter.GetBytes(npc), 0) * Convert.ToSingle(multiplier);

            byte[] buffer = BitConverter.GetBytes(fnum);
            uint t1 = (uint)buffer[3];
            t1 <<= 8;
            t1 += buffer[2];
            t1 <<= 8;
            t1 += buffer[1];
            t1 <<= 8;
            t1 += buffer[0];
            return t1;
        }

        public static decimal[] callieInfo = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.calliePoint[0]), vert(Main.calliePoint[1]), vert(Main.calliePoint[2]) };
        public static decimal[] callieChairInfo = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.calliePoint[0]), vert(Main.calliePoint[1]), vert(Main.calliePoint[2]) };
        public static decimal[] marieInfo = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.mariePoint[0]), vert(Main.mariePoint[1]), vert(Main.mariePoint[2]) };
        public static decimal[] marieChairInfo = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.mariePoint[0]), vert(Main.mariePoint[1]), vert(Main.mariePoint[2]) };
        public static decimal[] juddInfo = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.juddPoint[0]), vert(Main.juddPoint[1]), vert(Main.juddPoint[2]) };
        public static decimal[] spykeInfo = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.spykePoint[0]), vert(Main.spykePoint[1]), vert(Main.spykePoint[2]) };
        public static decimal[] shellInfo = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.shellPoint[0]), vert(Main.shellPoint[1]), vert(Main.shellPoint[2]) };
        public static decimal[] trainInfo = new decimal[9] {1, 1, 1, 1, 1, 1, 0, 0, 0 };
        public static decimal[] amiiboInfo = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.amiiboPoint[0]), vert(Main.amiiboPoint[1]), vert(Main.amiiboPoint[2]) };
        public static decimal[] balloonInfo = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.balloonPoint[0]), vert(Main.balloonPoint[1]), vert(Main.balloonPoint[2]) };
        public static decimal[] postInfo = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.postPoint[0]), vert(Main.postPoint[1]), vert(Main.postPoint[2]) };
        public static decimal[] arcadeInfo = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.arcadePoint[0]), vert(Main.arcadePoint[1]), vert(Main.arcadePoint[2]) };
        public static decimal[] manHoleInfo = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.manHolePoint[0]), vert(Main.manHolePoint[1]), vert(Main.manHolePoint[2]) };
        public static decimal[] weaponSignInfo = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.weaponSignPoint[0]), vert(Main.weaponSignPoint[1]), vert(Main.weaponSignPoint[2]) };
        public static decimal[] clothInfo = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.clothPoint[0]), vert(Main.clothPoint[1]), vert(Main.clothPoint[2]) };
        public static decimal[] tvInfo = new decimal[9] {1, 1, 1, 1, 1, 1, 0, 0, 0 };
        public static decimal[] fishInfo = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.fishPoint[0]), vert(Main.fishPoint[1]), vert(Main.fishPoint[2]) };
        public static decimal[] tree1Info = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.tree1Point[0]), vert(Main.tree1Point[1]), vert(Main.tree1Point[2]) };
        public static decimal[] tree2Info = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.tree2Point[0]), vert(Main.tree2Point[1]), vert(Main.tree2Point[2]) };
        public static decimal[] tree3Info = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.tree3Point[0]), vert(Main.tree3Point[1]), vert(Main.tree3Point[2]) };
        public static decimal[] tree4Info = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.tree4Point[0]), vert(Main.tree4Point[1]), vert(Main.tree4Point[2]) };
        public static decimal[] bird1Info = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.bird1Point[0]), vert(Main.bird1Point[1]), vert(Main.bird1Point[2]) };
        public static decimal[] bird2Info = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.bird2Point[0]), vert(Main.bird2Point[1]), vert(Main.bird2Point[2]) };
        public static decimal[] bird3Info = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.bird3Point[0]), vert(Main.bird3Point[1]), vert(Main.bird3Point[2]) };
        public static decimal[] bird4Info = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.bird4Point[0]), vert(Main.bird4Point[1]), vert(Main.bird4Point[2]) };
        public static decimal[] bird5Info = new decimal[9] {1, 1, 1, 1, 1, 1, vert(Main.bird5Point[0]), vert(Main.bird5Point[1]), vert(Main.bird5Point[2]) };
        public static decimal[] doorHatInfo = new decimal[9] {1, 1, 1, 1, 1, 1, 0, 0, 0 };
        public static decimal[] doorShirtInfo = new decimal[9] {1, 1, 1, 1, 1, 1, 0, 0, 0 };
        public static decimal[] doorShoesInfo = new decimal[9] {1, 1, 1, 1, 1, 1, 0, 0, 0 };
        public static decimal[] doorWeaponInfo = new decimal[9] {1, 1, 1, 1, 1, 1, 0, 0, 0 };
        public static decimal[] doorVSInfo = new decimal[9] {1, 1, 1, 1, 1, 1, 0, 0, 0 };
        public static decimal[] doorDojoInfo = new decimal[9] {1, 1, 1, 1, 1, 1, 0, 0, 0 };

        //RESET
        public static void resetti()
        {
            callieInfoSizeSav(1, 1, 1, 1, 1, 1);
            callieChairInfoSizeSav(1, 1, 1, 1, 1, 1);
            marieInfoSizeSav(1, 1, 1, 1, 1, 1);
            marieChairInfoSizeSav(1, 1, 1, 1, 1, 1);
            juddInfoSizeSav(1, 1, 1, 1);
            spykeInfoSizeSav(1, 1, 1, 1, 1, 1);
            shellInfoSizeSav(1, 1, 1, 1, 1, 1);
            trainInfoSizeSav(1, 1, 1, 1);
            amiiboInfoSizeSav(1, 1, 1, 1, 1, 1);
            balloonInfoSizeSav(1, 1, 1, 1, 1, 1);
            postInfoSizeSav(1, 1, 1, 1, 1, 1);
            arcadeInfoSizeSav(1, 1, 1, 1, 1, 1);
            manHoleInfoSizeSav(1, 1, 1, 1);
            weaponSignInfoSizeSav(1, 1, 1, 1, 1, 1);
            clothInfoSizeSav(1, 1, 1, 1);
            tvInfoSizeSav(1, 1, 1, 1);
            fishInfoSizeSav(1, 1, 1, 1);
            tree1InfoSizeSav(1, 1, 1, 1);
            tree2InfoSizeSav(1, 1, 1, 1);
            tree3InfoSizeSav(1, 1, 1, 1);
            tree4InfoSizeSav(1, 1, 1, 1);
            bird1InfoSizeSav(1, 1, 1, 1, 1, 1);
            bird2InfoSizeSav(1, 1, 1, 1, 1, 1);
            bird3InfoSizeSav(1, 1, 1, 1, 1, 1);
            bird4InfoSizeSav(1, 1, 1, 1, 1, 1);
            bird5InfoSizeSav(1, 1, 1, 1, 1, 1);
            doorHatInfoSizeSav(1, 1, 1, 1);
            doorShirtInfoSizeSav(1, 1, 1, 1);
            doorShoesInfoSizeSav(1, 1, 1, 1);
            doorWeaponInfoSizeSav(1, 1, 1, 1);
            doorVSInfoSizeSav(1, 1, 1, 1);
            doorDojoInfoSizeSav(1, 1, 1, 1);

            callieInfoPointSav(vert(Main.calliePoint[0]),
                vert(Main.calliePoint[1]),
                vert(Main.calliePoint[2]));

            callieChairInfoPointSav(vert(Main.calliePoint[0]),
                vert(Main.calliePoint[1]),
                vert(Main.calliePoint[2]));

            marieInfoPointSav(vert(Main.mariePoint[0]),
                vert(Main.mariePoint[1]),
                vert(Main.mariePoint[2]));

            marieChairInfoPointSav(vert(Main.mariePoint[0]),
                vert(Main.mariePoint[1]),
                vert(Main.mariePoint[2]));

            juddInfoPointSav(vert(Main.juddPoint[0]),
                vert(Main.juddPoint[1]),
                vert(Main.juddPoint[2]));

            spykeInfoPointSav(vert(Main.spykePoint[0]),
                vert(Main.spykePoint[1]),
                vert(Main.spykePoint[2]));

            shellInfoPointSav(vert(Main.shellPoint[0]),
                vert(Main.shellPoint[1]),
                vert(Main.shellPoint[2]));

            trainInfoPointSav(0, 0, 0);

            amiiboInfoPointSav(vert(Main.amiiboPoint[0]),
                vert(Main.amiiboPoint[1]),
                vert(Main.amiiboPoint[2]));

            balloonInfoPointSav(vert(Main.balloonPoint[0]),
                vert(Main.balloonPoint[1]),
                vert(Main.balloonPoint[2]));

            postInfoPointSav(vert(Main.postPoint[0]),
                vert(Main.postPoint[1]),
                vert(Main.postPoint[2]));

            arcadeInfoPointSav(vert(Main.arcadePoint[0]),
                vert(Main.arcadePoint[1]),
                vert(Main.arcadePoint[2]));

            manHoleInfoPointSav(vert(Main.manHolePoint[0]),
                vert(Main.manHolePoint[1]),
                vert(Main.manHolePoint[2]));

            weaponSignInfoPointSav(vert(Main.weaponSignPoint[0]),
                vert(Main.weaponSignPoint[1]),
                vert(Main.weaponSignPoint[2]));

            clothInfoPointSav(vert(Main.clothPoint[0]),
                vert(Main.clothPoint[1]),
                vert(Main.clothPoint[2]));

            tvInfoPointSav(0, 0, 0);

            fishInfoPointSav(vert(Main.fishPoint[0]),
                vert(Main.fishPoint[1]),
                vert(Main.fishPoint[2]));

            tree1InfoPointSav(vert(Main.tree1Point[0]),
                vert(Main.tree1Point[1]),
                vert(Main.tree1Point[2]));

            tree2InfoPointSav(vert(Main.tree2Point[0]),
                vert(Main.tree2Point[1]),
                vert(Main.tree2Point[2]));

            tree3InfoPointSav(vert(Main.tree3Point[0]),
                vert(Main.tree3Point[1]),
                vert(Main.tree3Point[2]));

            tree4InfoPointSav(vert(Main.tree4Point[0]),
                vert(Main.tree4Point[1]),
                vert(Main.tree4Point[2]));

            arcadeInfoPointSav(vert(Main.arcadePoint[0]),
                vert(Main.arcadePoint[1]),
                vert(Main.arcadePoint[2]));

            manHoleInfoPointSav(vert(Main.manHolePoint[0]),
                vert(Main.manHolePoint[1]),
                vert(Main.manHolePoint[2]));

            weaponSignInfoPointSav(vert(Main.weaponSignPoint[0]),
                vert(Main.weaponSignPoint[1]),
                vert(Main.weaponSignPoint[2]));

            bird1InfoPointSav(vert(Main.bird1Point[0]),
                vert(Main.bird1Point[1]),
                vert(Main.bird1Point[2]));

            bird2InfoPointSav(vert(Main.bird2Point[0]),
                vert(Main.bird2Point[1]),
                vert(Main.bird2Point[2]));

            bird3InfoPointSav(vert(Main.bird3Point[0]),
                vert(Main.bird3Point[1]),
                vert(Main.bird3Point[2]));

            bird4InfoPointSav(vert(Main.bird4Point[0]),
                vert(Main.bird4Point[1]),
                vert(Main.bird4Point[2]));

            bird5InfoPointSav(vert(Main.bird5Point[0]),
                vert(Main.bird5Point[1]),
                vert(Main.bird5Point[2]));

            doorHatInfoPointSav(0, 0, 0);

            doorShirtInfoPointSav(0, 0, 0);

            doorShoesInfoPointSav(0, 0, 0);

            doorVSInfoPointSav(0, 0, 0);

            doorDojoInfoPointSav(0, 0, 0);

            loadi();
        }

        public static void loadi()
        {
            //Callie
            gecko.poke(Main.sistersAddr + 0x328, data(Main.callieSize[0], callieInfo[0]));
            gecko.poke(Main.sistersAddr + 0x330, data(Main.callieSize[2], callieInfo[1]));
            gecko.poke(Main.sistersAddr + 0x33C, data(Main.callieSize[4], callieInfo[2]));
            gecko.poke(Main.sistersAddr + 0x348, data(Main.callieSize[6], callieInfo[3]));
            gecko.poke(Main.sistersAddr + 0x350, data(Main.callieSize[8], callieInfo[4]));

            gecko.poke(Main.sistersAddr + 0x334, Main.float2Hex(Convert.ToSingle(callieInfo[6])));
            gecko.poke(Main.sistersAddr + 0x344, Main.float2Hex(Convert.ToSingle(callieInfo[7])));
            gecko.poke(Main.sistersAddr + 0x354, Main.float2Hex(Convert.ToSingle(callieInfo[8])));
            //Callie's Chair
            gecko.poke(Main.NPCAddr + 0x6BC, data(Main.calliechairSize[0], callieChairInfo[0]));
            gecko.poke(Main.NPCAddr + 0x6C4, data(Main.calliechairSize[2], callieChairInfo[1]));
            gecko.poke(Main.NPCAddr + 0x6CC, data(Main.calliechairSize[4], callieChairInfo[2]));
            gecko.poke(Main.NPCAddr + 0x6D4, data(Main.calliechairSize[6], callieChairInfo[3]));
            gecko.poke(Main.NPCAddr + 0x6DC, data(Main.calliechairSize[8], callieChairInfo[4]));

            gecko.poke(Main.NPCAddr + 0x6E0, Main.float2Hex(Convert.ToSingle(callieChairInfo[6])));
            gecko.poke(Main.NPCAddr + 0x6E4, Main.float2Hex(Convert.ToSingle(callieChairInfo[7])));
            gecko.poke(Main.NPCAddr + 0x6E8, Main.float2Hex(Convert.ToSingle(callieChairInfo[8])));
            //Marie
            gecko.poke(Main.sistersAddr + 0x7BC, data(Main.marieSize[0], marieInfo[0]));
            gecko.poke(Main.sistersAddr + 0x7C4, data(Main.marieSize[2], marieInfo[1]));
            gecko.poke(Main.sistersAddr + 0x7D0, data(Main.marieSize[4], marieInfo[2]));
            gecko.poke(Main.sistersAddr + 0x7DC, data(Main.marieSize[6], marieInfo[3]));
            gecko.poke(Main.sistersAddr + 0x7E4, data(Main.marieSize[8], marieInfo[4]));

            gecko.poke(Main.sistersAddr + 0x7C8, Main.float2Hex(Convert.ToSingle(marieInfo[6])));
            gecko.poke(Main.sistersAddr + 0x7D8, Main.float2Hex(Convert.ToSingle(marieInfo[7])));
            gecko.poke(Main.sistersAddr + 0x7E8, Main.float2Hex(Convert.ToSingle(marieInfo[8])));
            //Marie's Chair
            gecko.poke(Main.NPCAddr + 0xAC0, data(Main.mariechairSize[0], marieChairInfo[0]));
            gecko.poke(Main.NPCAddr + 0xAC8, data(Main.mariechairSize[2], marieChairInfo[1]));
            gecko.poke(Main.NPCAddr + 0xAD0, data(Main.mariechairSize[4], marieChairInfo[2]));
            gecko.poke(Main.NPCAddr + 0xAD8, data(Main.mariechairSize[6], marieChairInfo[3]));
            gecko.poke(Main.NPCAddr + 0xAE0, data(Main.mariechairSize[8], marieChairInfo[4]));

            gecko.poke(Main.NPCAddr + 0xAE4, Main.float2Hex(Convert.ToSingle(marieChairInfo[6])));
            gecko.poke(Main.NPCAddr + 0xAE8, Main.float2Hex(Convert.ToSingle(marieChairInfo[7])));
            gecko.poke(Main.NPCAddr + 0xAEC, Main.float2Hex(Convert.ToSingle(marieChairInfo[8])));
            //Judd
            gecko.poke(Main.NPCAddr - 0xE44, data(0x3F800000, juddInfo[0]));
            gecko.poke(Main.NPCAddr - 0xE34, data(0x3F800000, juddInfo[1]));
            gecko.poke(Main.NPCAddr - 0xE24, data(0x3F800000, juddInfo[2]));

            gecko.poke(Main.NPCAddr - 0xE20, Main.float2Hex(Convert.ToSingle(juddInfo[6])));
            gecko.poke(Main.NPCAddr - 0xE1C, Main.float2Hex(Convert.ToSingle(juddInfo[7])));
            gecko.poke(Main.NPCAddr - 0xE18, Main.float2Hex(Convert.ToSingle(juddInfo[8])));
            //Spyke
            gecko.poke(Main.spykeAddr - 0x538, data(Main.spykeSize[0], spykeInfo[0]));
            gecko.poke(Main.spykeAddr - 0x530, data(Main.spykeSize[2], spykeInfo[1]));
            gecko.poke(Main.spykeAddr - 0x528, data(Main.spykeSize[4], spykeInfo[2]));
            gecko.poke(Main.spykeAddr - 0x520, data(Main.spykeSize[6], spykeInfo[3]));
            gecko.poke(Main.spykeAddr - 0x518, data(Main.spykeSize[8], spykeInfo[4]));

            gecko.poke(Main.spykeAddr - 0x514, Main.float2Hex(Convert.ToSingle(spykeInfo[6])));
            gecko.poke(Main.spykeAddr - 0x510, Main.float2Hex(Convert.ToSingle(spykeInfo[7])));
            gecko.poke(Main.spykeAddr - 0x50C, Main.float2Hex(Convert.ToSingle(spykeInfo[8])));
            //Sea Snails
            gecko.poke(Main.NPCAddr - 0x6798, data(Main.shellSize[0], shellInfo[0]));
            gecko.poke(Main.NPCAddr - 0x6790, data(Main.shellSize[2], shellInfo[1]));
            gecko.poke(Main.NPCAddr - 0x6788, data(Main.shellSize[4], shellInfo[2]));
            gecko.poke(Main.NPCAddr - 0x6780, data(Main.shellSize[6], shellInfo[3]));
            gecko.poke(Main.NPCAddr - 0x6778, data(Main.shellSize[8], shellInfo[4]));

            gecko.poke(Main.NPCAddr - 0x6774, Main.float2Hex(Convert.ToSingle(shellInfo[6])));
            gecko.poke(Main.NPCAddr - 0x6770, Main.float2Hex(Convert.ToSingle(shellInfo[7])));
            gecko.poke(Main.NPCAddr - 0x676C, Main.float2Hex(Convert.ToSingle(shellInfo[8])));
            //Train
            gecko.poke(Main.NPCAddr - 0x9C2C, data(0x3F800000, trainInfo[0]));
            gecko.poke(Main.NPCAddr - 0x9C1C, data(0x3F800000, trainInfo[1]));
            gecko.poke(Main.NPCAddr - 0x9C0C, data(0x3F800000, trainInfo[2]));

            gecko.poke(Main.NPCAddr - 0x9C08, Main.float2Hex(Convert.ToSingle(trainInfo[6])));
            gecko.poke(Main.NPCAddr - 0x9C04, Main.float2Hex(Convert.ToSingle(trainInfo[7])));
            gecko.poke(Main.NPCAddr - 0x9C00, Main.float2Hex(Convert.ToSingle(trainInfo[8])));
            //Amiibo Box
            gecko.poke(Main.NPCAddr - 0x608, data(Main.amiiboSize[0], amiiboInfo[0]));
            gecko.poke(Main.NPCAddr - 0x600, data(Main.amiiboSize[2], amiiboInfo[1]));
            gecko.poke(Main.NPCAddr - 0x5F8, data(Main.amiiboSize[4], amiiboInfo[2]));
            gecko.poke(Main.NPCAddr - 0x5F0, data(Main.amiiboSize[6], amiiboInfo[3]));
            gecko.poke(Main.NPCAddr - 0x5E8, data(Main.amiiboSize[8], amiiboInfo[4]));

            gecko.poke(Main.NPCAddr - 0x5E4, Main.float2Hex(Convert.ToSingle(amiiboInfo[6])));
            gecko.poke(Main.NPCAddr - 0x5E0, Main.float2Hex(Convert.ToSingle(amiiboInfo[7])));
            gecko.poke(Main.NPCAddr - 0x5DC, Main.float2Hex(Convert.ToSingle(amiiboInfo[6])));
            //Balloon
            gecko.poke(Main.NPCAddr - 0x90D8, data(Main.balloonSize[0], balloonInfo[0]));
            gecko.poke(Main.NPCAddr - 0x90D0, data(Main.balloonSize[2], balloonInfo[1]));
            gecko.poke(Main.NPCAddr - 0x90C8, data(Main.balloonSize[4], balloonInfo[2]));
            gecko.poke(Main.NPCAddr - 0x90C0, data(Main.balloonSize[6], balloonInfo[3]));
            gecko.poke(Main.NPCAddr - 0x90B8, data(Main.balloonSize[8], balloonInfo[4]));

            gecko.poke(Main.NPCAddr - 0x90B4, Main.float2Hex(Convert.ToSingle(balloonInfo[6])));
            gecko.poke(Main.NPCAddr - 0x90B0, Main.float2Hex(Convert.ToSingle(balloonInfo[7])));
            gecko.poke(Main.NPCAddr - 0x90AC, Main.float2Hex(Convert.ToSingle(balloonInfo[8])));
            //Miiverse Post
            gecko.poke(Main.NPCAddr - 0x1884, data(Main.postSize[0], postInfo[0]));
            gecko.poke(Main.NPCAddr - 0x187C, data(Main.postSize[2], postInfo[1]));
            gecko.poke(Main.NPCAddr - 0x1874, data(Main.postSize[4], postInfo[2]));
            gecko.poke(Main.NPCAddr - 0x186C, data(Main.postSize[6], postInfo[3]));
            gecko.poke(Main.NPCAddr - 0x1864, data(Main.postSize[8], postInfo[4]));

            gecko.poke(Main.NPCAddr - 0x1860, Main.float2Hex(Convert.ToSingle(postInfo[6])));
            gecko.poke(Main.NPCAddr - 0x185C, Main.float2Hex(Convert.ToSingle(postInfo[7])));
            gecko.poke(Main.NPCAddr - 0x1858, Main.float2Hex(Convert.ToSingle(postInfo[8])));
            //Arcade
            gecko.poke(Main.NPCAddr + 0x140, data(Main.arcadeSize[0], arcadeInfo[0]));
            gecko.poke(Main.NPCAddr + 0x148, data(Main.arcadeSize[2], arcadeInfo[1]));
            gecko.poke(Main.NPCAddr + 0x150, data(Main.arcadeSize[4], arcadeInfo[2]));
            gecko.poke(Main.NPCAddr + 0x158, data(Main.arcadeSize[6], arcadeInfo[3]));
            gecko.poke(Main.NPCAddr + 0x160, data(Main.arcadeSize[8], arcadeInfo[4]));

            gecko.poke(Main.NPCAddr + 0x164, Main.float2Hex(Convert.ToSingle(arcadeInfo[6])));
            gecko.poke(Main.NPCAddr + 0x168, Main.float2Hex(Convert.ToSingle(arcadeInfo[7])));
            gecko.poke(Main.NPCAddr + 0x16C, Main.float2Hex(Convert.ToSingle(arcadeInfo[8])));
            //Manhole
            gecko.poke(Main.manHoleAddr - 0x6FC, data(0x3F800000, manHoleInfo[0]));
            gecko.poke(Main.manHoleAddr - 0x6EC, data(0x3F800000, manHoleInfo[1]));
            gecko.poke(Main.manHoleAddr - 0x6DC, data(0x3F800000, manHoleInfo[2]));

            gecko.poke(Main.manHoleAddr - 0x6D8, Main.float2Hex(Convert.ToSingle(manHoleInfo[6])));
            gecko.poke(Main.manHoleAddr - 0x6D4, Main.float2Hex(Convert.ToSingle(manHoleInfo[7])));
            gecko.poke(Main.manHoleAddr - 0x6D0, Main.float2Hex(Convert.ToSingle(manHoleInfo[8])));
            //Weapon sign
            gecko.poke(Main.NPCAddr - 0x71E8, data(Main.weaponSignSize[0], weaponSignInfo[0]));
            gecko.poke(Main.NPCAddr - 0x71E0, data(Main.weaponSignSize[2], weaponSignInfo[1]));
            gecko.poke(Main.NPCAddr - 0x71D8, data(Main.weaponSignSize[4], weaponSignInfo[2]));
            gecko.poke(Main.NPCAddr - 0x71D0, data(Main.weaponSignSize[6], weaponSignInfo[3]));
            gecko.poke(Main.NPCAddr - 0x71C8, data(Main.weaponSignSize[8], weaponSignInfo[4]));

            gecko.poke(Main.NPCAddr - 0x71C4, Main.float2Hex(Convert.ToSingle(weaponSignInfo[6])));
            gecko.poke(Main.NPCAddr - 0x71C0, Main.float2Hex(Convert.ToSingle(weaponSignInfo[7])));
            gecko.poke(Main.NPCAddr - 0x71BC, Main.float2Hex(Convert.ToSingle(weaponSignInfo[8])));
            //Awning
            gecko.poke(Main.NPCAddr - 0x48A8, data(0x3F800000, clothInfo[0]));
            gecko.poke(Main.NPCAddr - 0x4898, data(0x3F800000, clothInfo[1]));
            gecko.poke(Main.NPCAddr - 0x4888, data(0x3F800000, clothInfo[2]));

            gecko.poke(Main.NPCAddr - 0x4884, Main.float2Hex(Convert.ToSingle(clothInfo[6])));
            gecko.poke(Main.NPCAddr - 0x4880, Main.float2Hex(Convert.ToSingle(clothInfo[7])));
            gecko.poke(Main.NPCAddr - 0x487C, Main.float2Hex(Convert.ToSingle(clothInfo[8])));
            //Main TV
            gecko.poke(Main.sistersAddr + 0x28F4, data(0x3F800000, tvInfo[0]));
            gecko.poke(Main.sistersAddr + 0x2904, data(0x3F800000, tvInfo[1]));
            gecko.poke(Main.sistersAddr + 0x2914, data(0x3F800000, tvInfo[2]));

            gecko.poke(Main.sistersAddr + 0x2918, Main.float2Hex(Convert.ToSingle(tvInfo[6])));
            gecko.poke(Main.sistersAddr + 0x291C, Main.float2Hex(Convert.ToSingle(tvInfo[7])));
            gecko.poke(Main.sistersAddr + 0x2920, Main.float2Hex(Convert.ToSingle(tvInfo[8])));
            //Great Zapfish
            gecko.poke(Main.NPCAddr + 0x3730, data(0x3F800000, fishInfo[0]));
            gecko.poke(Main.NPCAddr + 0x3740, data(0x3F800000, fishInfo[1]));
            gecko.poke(Main.NPCAddr + 0x3750, data(0x3F800000, fishInfo[2]));

            gecko.poke(Main.NPCAddr + 0x3754, Main.float2Hex(Convert.ToSingle(fishInfo[6])));
            gecko.poke(Main.NPCAddr + 0x3758, Main.float2Hex(Convert.ToSingle(fishInfo[7])));
            gecko.poke(Main.NPCAddr + 0x375C, Main.float2Hex(Convert.ToSingle(fishInfo[8])));
            //Tree
            gecko.poke(Main.NPCAddr - 0x8688, data(0x3F800000, tree1Info[0]));
            gecko.poke(Main.NPCAddr - 0x8678, data(0x3F800000, tree1Info[1]));
            gecko.poke(Main.NPCAddr - 0x8658, data(0x3F800000, tree1Info[2]));

            gecko.poke(Main.NPCAddr - 0x8664, Main.float2Hex(Convert.ToSingle(tree1Info[6])));
            gecko.poke(Main.NPCAddr - 0x8660, Main.float2Hex(Convert.ToSingle(tree1Info[7])));
            gecko.poke(Main.NPCAddr - 0x865C, Main.float2Hex(Convert.ToSingle(tree1Info[8])));
            //Tree 2
            gecko.poke(Main.NPCAddr - 0x7C38, data(0x3F800000, tree2Info[0]));
            gecko.poke(Main.NPCAddr - 0x7C28, data(0x3F800000, tree2Info[1]));
            gecko.poke(Main.NPCAddr - 0x7C18, data(0x3F800000, tree2Info[2]));

            gecko.poke(Main.NPCAddr - 0x7C14, Main.float2Hex(Convert.ToSingle(tree2Info[6])));
            gecko.poke(Main.NPCAddr - 0x7C10, Main.float2Hex(Convert.ToSingle(tree2Info[7])));
            gecko.poke(Main.NPCAddr - 0x7C0C, Main.float2Hex(Convert.ToSingle(tree2Info[8])));
            //Tree 3
            gecko.poke(Main.NPCAddr - 0x5D48, data(0x3F800000, tree3Info[0]));
            gecko.poke(Main.NPCAddr - 0x5D38, data(0x3F800000, tree3Info[1]));
            gecko.poke(Main.NPCAddr - 0x5D28, data(0x3F800000, tree3Info[2]));

            gecko.poke(Main.NPCAddr - 0x5D24, Main.float2Hex(Convert.ToSingle(tree3Info[6])));
            gecko.poke(Main.NPCAddr - 0x5D20, Main.float2Hex(Convert.ToSingle(tree3Info[7])));
            gecko.poke(Main.NPCAddr - 0x5D1C, Main.float2Hex(Convert.ToSingle(tree3Info[8])));
            //Tree 4
            gecko.poke(Main.NPCAddr - 0x52F8, data(0x3F800000, tree4Info[0]));
            gecko.poke(Main.NPCAddr - 0x52E8, data(0x3F800000, tree4Info[1]));
            gecko.poke(Main.NPCAddr - 0x52D8, data(0x3F800000, tree4Info[2]));

            gecko.poke(Main.NPCAddr - 0x52D4, Main.float2Hex(Convert.ToSingle(tree4Info[6])));
            gecko.poke(Main.NPCAddr - 0x52D0, Main.float2Hex(Convert.ToSingle(tree4Info[7])));
            gecko.poke(Main.NPCAddr - 0x52CC, Main.float2Hex(Convert.ToSingle(tree4Info[8])));
            //Bird 1
            gecko.poke(Main.NPCAddr - 0x3D68, data(Main.birdSize[0], bird1Info[0]));
            gecko.poke(Main.NPCAddr - 0x3D50, data(Main.birdSize[2], bird1Info[1]));
            gecko.poke(Main.NPCAddr - 0x3D58, data(Main.birdSize[4], bird1Info[2]));
            gecko.poke(Main.NPCAddr - 0x3D40, data(Main.birdSize[6], bird1Info[3]));
            gecko.poke(Main.NPCAddr - 0x3D48, data(Main.birdSize[8], bird1Info[4]));

            gecko.poke(Main.NPCAddr - 0x3D44, Main.float2Hex(Convert.ToSingle(bird1Info[6])));
            gecko.poke(Main.NPCAddr - 0x3D40, Main.float2Hex(Convert.ToSingle(bird1Info[7])));
            gecko.poke(Main.NPCAddr - 0x3D3C, Main.float2Hex(Convert.ToSingle(bird1Info[8])));
            //Bird 2
            gecko.poke(Main.NPCAddr - 0x37DC, data(Main.bird2Size[0], bird2Info[0]));
            gecko.poke(Main.NPCAddr - 0x37D4, data(Main.bird2Size[2], bird2Info[1]));
            gecko.poke(Main.NPCAddr - 0x37CC, data(Main.bird2Size[4], bird2Info[2]));
            gecko.poke(Main.NPCAddr - 0x37C4, data(Main.bird2Size[6], bird2Info[3]));
            gecko.poke(Main.NPCAddr - 0x37BC, data(Main.bird2Size[8], bird2Info[4]));

            gecko.poke(Main.NPCAddr - 0x37B8, Main.float2Hex(Convert.ToSingle(bird2Info[6])));
            gecko.poke(Main.NPCAddr - 0x37B4, Main.float2Hex(Convert.ToSingle(bird2Info[7])));
            gecko.poke(Main.NPCAddr - 0x37B0, Main.float2Hex(Convert.ToSingle(bird2Info[8])));
            //Bird 3
            gecko.poke(Main.NPCAddr - 0x3250, data(Main.bird3Size[0], bird3Info[0]));
            gecko.poke(Main.NPCAddr - 0x3248, data(Main.bird3Size[2], bird3Info[1]));
            gecko.poke(Main.NPCAddr - 0x3240, data(Main.bird3Size[4], bird3Info[2]));
            gecko.poke(Main.NPCAddr - 0x3238, data(Main.bird3Size[6], bird3Info[3]));
            gecko.poke(Main.NPCAddr - 0x3230, data(Main.bird3Size[8], bird3Info[4]));

            gecko.poke(Main.NPCAddr - 0x322C, Main.float2Hex(Convert.ToSingle(bird3Info[6])));
            gecko.poke(Main.NPCAddr - 0x3228, Main.float2Hex(Convert.ToSingle(bird3Info[7])));
            gecko.poke(Main.NPCAddr - 0x3224, Main.float2Hex(Convert.ToSingle(bird3Info[8])));
            //Bird 4
            gecko.poke(Main.NPCAddr - 0x2CC4, data(Main.bird4Size[0], bird4Info[0]));
            gecko.poke(Main.NPCAddr - 0x2CBC, data(Main.bird4Size[2], bird4Info[1]));
            gecko.poke(Main.NPCAddr - 0x2CB4, data(Main.bird4Size[4], bird4Info[2]));
            gecko.poke(Main.NPCAddr - 0x2CAC, data(Main.bird4Size[6], bird4Info[3]));
            gecko.poke(Main.NPCAddr - 0x2CA4, data(Main.bird4Size[8], bird4Info[4]));

            gecko.poke(Main.NPCAddr - 0x2CA0, Main.float2Hex(Convert.ToSingle(bird4Info[6])));
            gecko.poke(Main.NPCAddr - 0x2C9C, Main.float2Hex(Convert.ToSingle(bird4Info[7])));
            gecko.poke(Main.NPCAddr - 0x2C98, Main.float2Hex(Convert.ToSingle(bird4Info[8])));
            //Bird 5
            gecko.poke(Main.NPCAddr - 0x2738, data(Main.bird5Size[0], bird5Info[0]));
            gecko.poke(Main.NPCAddr - 0x2730, data(Main.bird5Size[2], bird5Info[1]));
            gecko.poke(Main.NPCAddr - 0x2728, data(Main.bird5Size[4], bird5Info[2]));
            gecko.poke(Main.NPCAddr - 0x2720, data(Main.bird5Size[6], bird5Info[3]));
            gecko.poke(Main.NPCAddr - 0x2718, data(Main.bird5Size[8], bird5Info[4]));

            gecko.poke(Main.NPCAddr - 0x2714, Main.float2Hex(Convert.ToSingle(bird5Info[6])));
            gecko.poke(Main.NPCAddr - 0x2710, Main.float2Hex(Convert.ToSingle(bird5Info[7])));
            gecko.poke(Main.NPCAddr - 0x270C, Main.float2Hex(Convert.ToSingle(bird5Info[8])));
            //Plaza Door: Hat
            gecko.poke(Main.NPCAddr + 0xEE8, data(0x3F800000, doorHatInfo[0]));
            gecko.poke(Main.NPCAddr + 0xEF8, data(0x3F800000, doorHatInfo[1]));
            gecko.poke(Main.NPCAddr + 0xF08, data(0x3F800000, doorHatInfo[2]));

            gecko.poke(Main.NPCAddr + 0xF0C, Main.float2Hex(Convert.ToSingle(doorHatInfo[6])));
            gecko.poke(Main.NPCAddr + 0xF10, Main.float2Hex(Convert.ToSingle(doorHatInfo[7])));
            gecko.poke(Main.NPCAddr + 0xF14, Main.float2Hex(Convert.ToSingle(doorHatInfo[8])));
            //Plaza Door: Clothes
            gecko.poke(Main.NPCAddr + 0x1C10, data(0x3F800000, doorShirtInfo[0]));
            gecko.poke(Main.NPCAddr + 0x1C20, data(0x3F800000, doorShirtInfo[1]));
            gecko.poke(Main.NPCAddr + 0x1C30, data(0x3F800000, doorShirtInfo[2]));

            gecko.poke(Main.NPCAddr + 0x1C34, Main.float2Hex(Convert.ToSingle(doorShirtInfo[6])));
            gecko.poke(Main.NPCAddr + 0x1C38, Main.float2Hex(Convert.ToSingle(doorShirtInfo[7])));
            gecko.poke(Main.NPCAddr + 0x1C3C, Main.float2Hex(Convert.ToSingle(doorShirtInfo[8])));
            //Plaza Door: Shoes
            gecko.poke(Main.NPCAddr + 0x157C, data(0x3F800000, doorShoesInfo[0]));
            gecko.poke(Main.NPCAddr + 0x158C, data(0x3F800000, doorShoesInfo[1]));
            gecko.poke(Main.NPCAddr + 0x159C, data(0x3F800000, doorShoesInfo[2]));

            gecko.poke(Main.NPCAddr + 0x15A0, Main.float2Hex(Convert.ToSingle(doorShoesInfo[6])));
            gecko.poke(Main.NPCAddr + 0x15A4, Main.float2Hex(Convert.ToSingle(doorShoesInfo[7])));
            gecko.poke(Main.NPCAddr + 0x15A8, Main.float2Hex(Convert.ToSingle(doorShoesInfo[8])));
            //Plaza Door: Weapon
            gecko.poke(Main.NPCAddr + 0x22A4, data(0x3F800000, doorWeaponInfo[0]));
            gecko.poke(Main.NPCAddr + 0x22B4, data(0x3F800000, doorWeaponInfo[1]));
            gecko.poke(Main.NPCAddr + 0x22C4, data(0x3F800000, doorWeaponInfo[2]));

            gecko.poke(Main.NPCAddr + 0x22C8, Main.float2Hex(Convert.ToSingle(doorWeaponInfo[6])));
            gecko.poke(Main.NPCAddr + 0x22CC, Main.float2Hex(Convert.ToSingle(doorWeaponInfo[7])));
            gecko.poke(Main.NPCAddr + 0x22D0, Main.float2Hex(Convert.ToSingle(doorWeaponInfo[8])));
            //Plaza Door: VSGame
            gecko.poke(Main.NPCAddr + 0x2938, data(0x3F800000, doorVSInfo[0]));
            gecko.poke(Main.NPCAddr + 0x2948, data(0x3F800000, doorVSInfo[1]));
            gecko.poke(Main.NPCAddr + 0x2958, data(0x3F800000, doorVSInfo[2]));

            gecko.poke(Main.NPCAddr + 0x295C, Main.float2Hex(Convert.ToSingle(doorVSInfo[6])));
            gecko.poke(Main.NPCAddr + 0x2960, Main.float2Hex(Convert.ToSingle(doorVSInfo[7])));
            gecko.poke(Main.NPCAddr + 0x2964, Main.float2Hex(Convert.ToSingle(doorVSInfo[8])));
            //Plaza Door: Dojo
            gecko.poke(Main.NPCAddr + 0x2FCC, data(0x3F800000, doorDojoInfo[0]));
            gecko.poke(Main.NPCAddr + 0x2FDC, data(0x3F800000, doorDojoInfo[1]));
            gecko.poke(Main.NPCAddr + 0x2FEC, data(0x3F800000, doorDojoInfo[2]));

            gecko.poke(Main.NPCAddr + 0x2FF0, Main.float2Hex(Convert.ToSingle(doorDojoInfo[6])));
            gecko.poke(Main.NPCAddr + 0x2FF4, Main.float2Hex(Convert.ToSingle(doorDojoInfo[7])));
            gecko.poke(Main.NPCAddr + 0x2FF8, Main.float2Hex(Convert.ToSingle(doorDojoInfo[8])));
        }

        //Callie
        public static void callieInfoSizeSav(decimal x1, decimal x2, decimal y, decimal z1, decimal z2, decimal master)
        {
            callieInfo[0] = x1;
            callieInfo[1] = x2;
            callieInfo[2] = y;
            callieInfo[3] = z1;
            callieInfo[4] = z2;
            callieInfo[5] = master;
        }

        public static void callieInfoPointSav(decimal x, decimal y, decimal z)
        {
            callieInfo[6] = x;
            callieInfo[7] = y;
            callieInfo[8] = z;
        }
        //Callie's chair
        public static void callieChairInfoSizeSav(decimal x1, decimal x2, decimal y, decimal z1, decimal z2, decimal master)
        {
            callieChairInfo[0] = x1;
            callieChairInfo[1] = x2;
            callieChairInfo[2] = y;
            callieChairInfo[3] = z1;
            callieChairInfo[4] = z2;
            callieChairInfo[5] = master;
        }
        public static void callieChairInfoPointSav(decimal x, decimal y, decimal z)
        {
            callieChairInfo[6] = x;
            callieChairInfo[7] = y;
            callieChairInfo[8] = z;
        }
        //Marie
        public static void marieInfoSizeSav(decimal x1, decimal x2, decimal y, decimal z1, decimal z2, decimal master)
        {
            marieInfo[0] = x1;
            marieInfo[1] = x2;
            marieInfo[2] = y;
            marieInfo[3] = z1;
            marieInfo[4] = z2;
            marieInfo[5] = master;
        }
        public static void marieInfoPointSav(decimal x, decimal y, decimal z)
        {
            marieInfo[6] = x;
            marieInfo[7] = y;
            marieInfo[8] = z;
        }

        //Marie's chair
        public static void marieChairInfoSizeSav(decimal x1, decimal x2, decimal y, decimal z1, decimal z2, decimal master)
        {
            marieChairInfo[0] = x1;
            marieChairInfo[1] = x2;
            marieChairInfo[2] = y;
            marieChairInfo[3] = z1;
            marieChairInfo[4] = z2;
            marieChairInfo[5] = master;
        }
        public static void marieChairInfoPointSav(decimal x, decimal y, decimal z)
        {
            marieChairInfo[6] = x;
            marieChairInfo[7] = y;
            marieChairInfo[8] = z;
        }
        //Judd
        public static void juddInfoSizeSav(decimal x, decimal y, decimal z, decimal master)
        {
            juddInfo[0] = x;
            juddInfo[1] = y;
            juddInfo[2] = z;
            juddInfo[5] = master;
        }
        public static void juddInfoPointSav(decimal x, decimal y, decimal z)
        {
            juddInfo[6] = x;
            juddInfo[7] = y;
            juddInfo[8] = z;
        }
        //Spyke
        public static void spykeInfoSizeSav(decimal x1, decimal x2, decimal y, decimal z1, decimal z2, decimal master)
        {
            spykeInfo[0] = x1;
            spykeInfo[1] = x2;
            spykeInfo[2] = y;
            spykeInfo[3] = z1;
            spykeInfo[4] = z2;
            spykeInfo[5] = master;
        }
        public static void spykeInfoPointSav(decimal x, decimal y, decimal z)
        {
            spykeInfo[6] = x;
            spykeInfo[7] = y;
            spykeInfo[8] = z;
        }
        //Sea Snails
        public static void shellInfoSizeSav(decimal x1, decimal x2, decimal y, decimal z1, decimal z2, decimal master)
        {
            shellInfo[0] = x1;
            shellInfo[1] = x2;
            shellInfo[2] = y;
            shellInfo[3] = z1;
            shellInfo[4] = z2;
            shellInfo[5] = master;
        }
        public static void shellInfoPointSav(decimal x, decimal y, decimal z)
        {
            shellInfo[6] = x;
            shellInfo[7] = y;
            shellInfo[8] = z;
        }
        //Train
        public static void trainInfoSizeSav(decimal x, decimal y, decimal z, decimal master)
        {
            trainInfo[0] = x;
            trainInfo[1] = y;
            trainInfo[2] = z;
            trainInfo[5] = master;
        }
        public static void trainInfoPointSav(decimal x, decimal y, decimal z)
        {
            trainInfo[6] = x;
            trainInfo[7] = y;
            trainInfo[8] = z;
        }
        //Amiibo
        public static void amiiboInfoSizeSav(decimal x1, decimal x2, decimal y, decimal z1, decimal z2, decimal master)
        {
            amiiboInfo[0] = x1;
            amiiboInfo[1] = x2;
            amiiboInfo[2] = y;
            amiiboInfo[3] = z1;
            amiiboInfo[4] = z2;
            amiiboInfo[5] = master;
        }
        public static void amiiboInfoPointSav(decimal x, decimal y, decimal z)
        {
            amiiboInfo[6] = x;
            amiiboInfo[7] = y;
            amiiboInfo[8] = z;
        }
        //Balloon
        public static void balloonInfoSizeSav(decimal x1, decimal x2, decimal y, decimal z1, decimal z2, decimal master)
        {
            balloonInfo[0] = x1;
            balloonInfo[1] = x2;
            balloonInfo[2] = y;
            balloonInfo[3] = z1;
            balloonInfo[4] = z2;
            balloonInfo[5] = master;
        }
        public static void balloonInfoPointSav(decimal x, decimal y, decimal z)
        {
            balloonInfo[6] = x;
            balloonInfo[7] = y;
            balloonInfo[8] = z;
        }
        //Miiverse Post
        public static void postInfoSizeSav(decimal x1, decimal x2, decimal y, decimal z1, decimal z2, decimal master)
        {
            postInfo[0] = x1;
            postInfo[1] = x2;
            postInfo[2] = y;
            postInfo[3] = z1;
            postInfo[4] = z2;
            postInfo[5] = master;
        }
        public static void postInfoPointSav(decimal x, decimal y, decimal z)
        {
            postInfo[6] = x;
            postInfo[7] = y;
            postInfo[8] = z;
        }
        //Arcade
        public static void arcadeInfoSizeSav(decimal x1, decimal x2, decimal y, decimal z1, decimal z2, decimal master)
        {
            arcadeInfo[0] = x1;
            arcadeInfo[1] = x2;
            arcadeInfo[2] = y;
            arcadeInfo[3] = z1;
            arcadeInfo[4] = z2;
            arcadeInfo[5] = master;
        }
        public static void arcadeInfoPointSav(decimal x, decimal y, decimal z)
        {
            arcadeInfo[6] = x;
            arcadeInfo[7] = y;
            arcadeInfo[8] = z;
        }
        //Manhole
        public static void manHoleInfoSizeSav(decimal x, decimal y, decimal z, decimal master)
        {
            manHoleInfo[0] = x;
            manHoleInfo[1] = y;
            manHoleInfo[2] = z;
            manHoleInfo[5] = master;
        }
        public static void manHoleInfoPointSav(decimal x, decimal y, decimal z)
        {
            manHoleInfo[6] = x;
            manHoleInfo[7] = y;
            manHoleInfo[8] = z;
        }
        //Weapon Sign
        public static void weaponSignInfoSizeSav(decimal x1, decimal x2, decimal y, decimal z1, decimal z2, decimal master)
        {
            weaponSignInfo[0] = x1;
            weaponSignInfo[1] = x2;
            weaponSignInfo[2] = y;
            weaponSignInfo[3] = z1;
            weaponSignInfo[4] = z2;
            weaponSignInfo[5] = master;
        }
        public static void weaponSignInfoPointSav(decimal x, decimal y, decimal z)
        {
            weaponSignInfo[6] = x;
            weaponSignInfo[7] = y;
            weaponSignInfo[8] = z;
        }
        //Cloth
        public static void clothInfoSizeSav(decimal x, decimal y, decimal z, decimal master)
        {
            clothInfo[0] = x;
            clothInfo[1] = y;
            clothInfo[2] = z;
            clothInfo[5] = master;
        }
        public static void clothInfoPointSav(decimal x, decimal y, decimal z)
        {
            clothInfo[6] = x;
            clothInfo[7] = y;
            clothInfo[8] = z;
        }
        //Main TV
        public static void tvInfoSizeSav(decimal x, decimal y, decimal z, decimal master)
        {
            tvInfo[0] = x;
            tvInfo[1] = y;
            tvInfo[2] = z;
            tvInfo[5] = master;
        }
        public static void tvInfoPointSav(decimal x, decimal y, decimal z)
        {
            tvInfo[6] = x;
            tvInfo[7] = y;
            tvInfo[8] = z;
        }
        //Great Zapfish
        public static void fishInfoSizeSav(decimal x, decimal y, decimal z, decimal master)
        {
            fishInfo[0] = x;
            fishInfo[1] = y;
            fishInfo[2] = z;
            fishInfo[5] = master;
        }

        public static void fishInfoPointSav(decimal x, decimal y, decimal z)
        {
            fishInfo[6] = x;
            fishInfo[7] = y;
            fishInfo[8] = z;
        }
        //Tree 1
        public static void tree1InfoSizeSav(decimal x, decimal y, decimal z, decimal master)
        {
            tree1Info[0] = x;
            tree1Info[1] = y;
            tree1Info[2] = z;
            tree1Info[5] = master;
        }

        public static void tree1InfoPointSav(decimal x, decimal y, decimal z)
        {
            tree1Info[6] = x;
            tree1Info[7] = y;
            tree1Info[8] = z;
        }
        //Tree 2
        public static void tree2InfoSizeSav(decimal x, decimal y, decimal z, decimal master)
        {
            tree2Info[0] = x;
            tree2Info[1] = y;
            tree2Info[2] = z;
            tree2Info[5] = master;
        }
        public static void tree2InfoPointSav(decimal x, decimal y, decimal z)
        {
            tree2Info[6] = x;
            tree2Info[7] = y;
            tree2Info[8] = z;
        }
        //Tree 3
        public static void tree3InfoSizeSav(decimal x, decimal y, decimal z, decimal master)
        {
            tree3Info[0] = x;
            tree3Info[1] = y;
            tree3Info[2] = z;
            tree3Info[5] = master;
        }
        public static void tree3InfoPointSav(decimal x, decimal y, decimal z)
        {
            tree3Info[6] = x;
            tree3Info[7] = y;
            tree3Info[8] = z;
        }
         //Tree 4
        public static void tree4InfoSizeSav(decimal x, decimal y, decimal z, decimal master)
        {
            tree4Info[0] = x;
            tree4Info[1] = y;
            tree4Info[2] = z;
            tree4Info[5] = master;
        }
        public static void tree4InfoPointSav(decimal x, decimal y, decimal z)
        {
            tree4Info[6] = x;
            tree4Info[7] = y;
            tree4Info[8] = z;
        }
        //Bird 1
        public static void bird1InfoSizeSav(decimal x1, decimal x2, decimal y, decimal z1, decimal z2, decimal master)
        {
            bird1Info[0] = x1;
            bird1Info[1] = x2;
            bird1Info[2] = y;
            bird1Info[3] = z1;
            bird1Info[4] = z2;
            bird1Info[5] = master;
        }
        public static void bird1InfoPointSav(decimal x, decimal y, decimal z)
        {
            bird1Info[6] = x;
            bird1Info[7] = y;
            bird1Info[8] = z;
        }
        //Bird 2
        public static void bird2InfoSizeSav(decimal x1, decimal x2, decimal y, decimal z1, decimal z2, decimal master)
        {
            bird2Info[0] = x1;
            bird2Info[1] = x2;
            bird2Info[2] = y;
            bird2Info[3] = z1;
            bird2Info[4] = z2;
            bird2Info[5] = master;
        }
        public static void bird2InfoPointSav(decimal x, decimal y, decimal z)
        {
            bird2Info[6] = x;
            bird2Info[7] = y;
            bird2Info[8] = z;
        }
        //Bird 3
        public static void bird3InfoSizeSav(decimal x1, decimal x2, decimal y, decimal z1, decimal z2, decimal master)
        {
            bird3Info[0] = x1;
            bird3Info[1] = x2;
            bird3Info[2] = y;
            bird3Info[3] = z1;
            bird3Info[4] = z2;
            bird3Info[5] = master;
        }
        public static void bird3InfoPointSav(decimal x, decimal y, decimal z)
        {
            bird3Info[6] = x;
            bird3Info[7] = y;
            bird3Info[8] = z;
        }
        //Bird 4
        public static void bird4InfoSizeSav(decimal x1, decimal x2, decimal y, decimal z1, decimal z2, decimal master)
        {
            bird4Info[0] = x1;
            bird4Info[1] = x2;
            bird4Info[2] = y;
            bird4Info[3] = z1;
            bird4Info[4] = z2;
            bird4Info[5] = master;
        }
        public static void bird4InfoPointSav(decimal x, decimal y, decimal z)
        {
            bird4Info[6] = x;
            bird4Info[7] = y;
            bird4Info[8] = z;
        }
        //Bird 5
        public static void bird5InfoSizeSav(decimal x1, decimal x2, decimal y, decimal z1, decimal z2, decimal master)
        {
            bird5Info[0] = x1;
            bird5Info[1] = x2;
            bird5Info[2] = y;
            bird5Info[3] = z1;
            bird5Info[4] = z2;
            bird5Info[5] = master;
        }
        public static void bird5InfoPointSav(decimal x, decimal y, decimal z)
        {
            bird5Info[6] = x;
            bird5Info[7] = y;
            bird5Info[8] = z;
        }
        //Plaza door: Hat
        public static void doorHatInfoSizeSav(decimal x, decimal y, decimal z, decimal master)
        {
            doorHatInfo[0] = x;
            doorHatInfo[1] = y;
            doorHatInfo[2] = z;
            doorHatInfo[5] = master;
        }
        public static void doorHatInfoPointSav(decimal x, decimal y, decimal z)
        {
            doorHatInfo[6] = x;
            doorHatInfo[7] = y;
            doorHatInfo[8] = z;
        }
        //Plaza door: Shirt
        public static void doorShirtInfoSizeSav(decimal x, decimal y, decimal z, decimal master)
        {
            doorShirtInfo[0] = x;
            doorShirtInfo[1] = y;
            doorShirtInfo[2] = z;
            doorShirtInfo[5] = master;
        }
        public static void doorShirtInfoPointSav(decimal x, decimal y, decimal z)
        {
            doorShirtInfo[6] = x;
            doorShirtInfo[7] = y;
            doorShirtInfo[8] = z;
        }
        //Plaza door: Shoes
        public static void doorShoesInfoSizeSav(decimal x, decimal y, decimal z, decimal master)
        {
            doorShoesInfo[0] = x;
            doorShoesInfo[1] = y;
            doorShoesInfo[2] = z;
            doorShoesInfo[5] = master;
        }
        public static void doorShoesInfoPointSav(decimal x, decimal y, decimal z)
        {
            doorShoesInfo[6] = x;
            doorShoesInfo[7] = y;
            doorShoesInfo[8] = z;
        }
        //Plaza door: Weapon
        public static void doorWeaponInfoSizeSav(decimal x, decimal y, decimal z, decimal master)
        {
            doorWeaponInfo[0] = x;
            doorWeaponInfo[1] = y;
            doorWeaponInfo[2] = z;
            doorWeaponInfo[5] = master;
        }
        public static void doorWeaponInfoPointSav(decimal x, decimal y, decimal z)
        {
            doorWeaponInfo[6] = x;
            doorWeaponInfo[7] = y;
            doorWeaponInfo[8] = z;
        }
        //Plaza door: VSGame
        public static void doorVSInfoSizeSav(decimal x, decimal y, decimal z, decimal master)
        {
            doorVSInfo[0] = x;
            doorVSInfo[1] = y;
            doorVSInfo[2] = z;
            doorVSInfo[5] = master;
        }
        public static void doorVSInfoPointSav(decimal x, decimal y, decimal z)
        {
            doorVSInfo[6] = x;
            doorVSInfo[7] = y;
            doorVSInfo[8] = z;
        }
        //Plaza door: Dojo
        public static void doorDojoInfoSizeSav(decimal x, decimal y, decimal z, decimal master)
        {
            doorDojoInfo[0] = x;
            doorDojoInfo[1] = y;
            doorDojoInfo[2] = z;
            doorDojoInfo[5] = master;
        }
        public static void doorDojoInfoPointSav(decimal x, decimal y, decimal z)
        {
            doorDojoInfo[6] = x;
            doorDojoInfo[7] = y;
            doorDojoInfo[8] = z;
        }
    }
}
