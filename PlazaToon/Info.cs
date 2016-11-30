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
        //RESET
        public static void resetti()
        {
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
            arcadeInfoSize(1, 1, 1, 1, 1);
            manHoleInfoSize(1, 1, 1);
            weaponSignInfoSize(1, 1, 1, 1, 1);
            clothInfoSize(1, 1, 1);
            tvInfoSize(1, 1, 1);
            fishInfoSize(1, 1, 1);
            tree1InfoSize(1, 1, 1);
            tree2InfoSize(1, 1, 1);
            tree3InfoSize(1, 1, 1);
            tree4InfoSize(1, 1, 1);
            bird1InfoSize(1, 1, 1, 1, 1);
            bird2InfoSize(1, 1, 1, 1, 1);
            bird3InfoSize(1, 1, 1, 1, 1);
            bird4InfoSize(1, 1, 1, 1, 1);
            bird5InfoSize(1, 1, 1, 1, 1);
            doorHatInfoSize(1, 1, 1);
            doorShirtInfoSize(1, 1, 1);
            doorShoesInfoSize(1, 1, 1);
            doorWeaponInfoSize(1, 1, 1);
            doorVSInfoSize(1, 1, 1);
            doorDojoInfoSize(1, 1, 1);

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
            arcadeMasterScale(1);
            manHoleMasterScale(1);
            weaponSignMasterScale(1);
            clothMasterScale(1);
            tvMasterScale(1);
            fishMasterScale(1);
            tree1MasterScale(1);
            tree2MasterScale(1);
            tree3MasterScale(1);
            tree4MasterScale(1);
            bird1MasterScale(1);
            bird2MasterScale(1);
            bird3MasterScale(1);
            bird4MasterScale(1);
            bird5MasterScale(1);
            doorHatMasterScale(1);
            doorShirtMasterScale(1);
            doorShoesMasterScale(1);
            doorWeaponMasterScale(1);
            doorVSMasterScale(1);
            doorDojoMasterScale(1);


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

            arcadeInfoPoint(vert(Main.arcadePoint[0]),
                vert(Main.arcadePoint[1]),
                vert(Main.arcadePoint[2]));

            manHoleInfoPoint(vert(Main.manHolePoint[0]),
                vert(Main.manHolePoint[1]),
                vert(Main.manHolePoint[2]));

            weaponSignInfoPoint(vert(Main.weaponSignPoint[0]),
                vert(Main.weaponSignPoint[1]),
                vert(Main.weaponSignPoint[2]));

            clothInfoPoint(vert(Main.clothPoint[0]),
                vert(Main.clothPoint[1]),
                vert(Main.clothPoint[2]));

            tvInfoPoint(0, 0, 0);

            fishInfoPoint(vert(Main.fishPoint[0]),
                vert(Main.fishPoint[1]),
                vert(Main.fishPoint[2]));

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

            manHoleInfoPoint(vert(Main.manHolePoint[0]),
                vert(Main.manHolePoint[1]),
                vert(Main.manHolePoint[2]));

            weaponSignInfoPoint(vert(Main.weaponSignPoint[0]),
                vert(Main.weaponSignPoint[1]),
                vert(Main.weaponSignPoint[2]));

            bird1InfoPoint(vert(Main.birdPoint[0]),
                vert(Main.birdPoint[1]),
                vert(Main.birdPoint[2]));

            bird2InfoPoint(vert(Main.bird2Point[0]),
                vert(Main.bird2Point[1]),
                vert(Main.bird2Point[2]));

            bird3InfoPoint(vert(Main.bird3Point[0]),
                vert(Main.bird3Point[1]),
                vert(Main.bird3Point[2]));

            bird4InfoPoint(vert(Main.bird4Point[0]),
                vert(Main.bird4Point[1]),
                vert(Main.bird4Point[2]));

            bird5InfoPoint(vert(Main.bird5Point[0]),
                vert(Main.bird5Point[1]),
                vert(Main.bird5Point[2]));

            doorHatInfoPoint(0, 0, 0);

            doorShirtInfoPoint(0, 0, 0);

            doorShoesInfoPoint(0, 0, 0);

            doorVSInfoPoint(0, 0, 0);

            doorDojoInfoPoint(0, 0, 0);

            loadi();
        }

        public static void loadi()
        {
            //Callie
            gecko.poke(Main.sistersAddr + 0x328, data(Main.callieSize[0], callieInfoSize1));
            gecko.poke(Main.sistersAddr + 0x330, data(Main.callieSize[2], callieInfoSize2));
            gecko.poke(Main.sistersAddr + 0x33C, data(Main.callieSize[4], callieInfoSize3));
            gecko.poke(Main.sistersAddr + 0x348, data(Main.callieSize[6], callieInfoSize4));
            gecko.poke(Main.sistersAddr + 0x350, data(Main.callieSize[8], callieInfoSize5));

            gecko.poke(Main.sistersAddr + 0x334, Main.float2Hex(Convert.ToSingle(callieInfoPoint1)));
            gecko.poke(Main.sistersAddr + 0x344, Main.float2Hex(Convert.ToSingle(callieInfoPoint2)));
            gecko.poke(Main.sistersAddr + 0x354, Main.float2Hex(Convert.ToSingle(callieInfoPoint3)));
            //Callie's Chair
            gecko.poke(Main.NPCAddr + 0x6BC, data(Main.calliechairSize[0], callieChairInfoSize1));
            gecko.poke(Main.NPCAddr + 0x6C4, data(Main.calliechairSize[2], callieChairInfoSize2));
            gecko.poke(Main.NPCAddr + 0x6CC, data(Main.calliechairSize[4], callieChairInfoSize3));
            gecko.poke(Main.NPCAddr + 0x6D4, data(Main.calliechairSize[6], callieChairInfoSize4));
            gecko.poke(Main.NPCAddr + 0x6DC, data(Main.calliechairSize[8], callieChairInfoSize5));

            gecko.poke(Main.NPCAddr + 0x6E0, Main.float2Hex(Convert.ToSingle(callieChairInfoPoint1)));
            gecko.poke(Main.NPCAddr + 0x6E4, Main.float2Hex(Convert.ToSingle(callieChairInfoPoint2)));
            gecko.poke(Main.NPCAddr + 0x6E8, Main.float2Hex(Convert.ToSingle(callieChairInfoPoint3)));
            //Marie
            gecko.poke(Main.sistersAddr + 0x7BC, data(Main.marieSize[0], marieInfoSize1));
            gecko.poke(Main.sistersAddr + 0x7C4, data(Main.marieSize[2], marieInfoSize2));
            gecko.poke(Main.sistersAddr + 0x7D0, data(Main.marieSize[4], marieInfoSize3));
            gecko.poke(Main.sistersAddr + 0x7DC, data(Main.marieSize[6], marieInfoSize4));
            gecko.poke(Main.sistersAddr + 0x7E4, data(Main.marieSize[8], marieInfoSize5));

            gecko.poke(Main.sistersAddr + 0x7C8, Main.float2Hex(Convert.ToSingle(marieInfoPoint1)));
            gecko.poke(Main.sistersAddr + 0x7D8, Main.float2Hex(Convert.ToSingle(marieInfoPoint2)));
            gecko.poke(Main.sistersAddr + 0x7E8, Main.float2Hex(Convert.ToSingle(marieInfoPoint3)));
            //Marie's Chair
            gecko.poke(Main.NPCAddr + 0xAC0, data(Main.mariechairSize[0], marieChairInfoSize1));
            gecko.poke(Main.NPCAddr + 0xAC8, data(Main.mariechairSize[2], marieChairInfoSize2));
            gecko.poke(Main.NPCAddr + 0xAD0, data(Main.mariechairSize[4], marieChairInfoSize3));
            gecko.poke(Main.NPCAddr + 0xAD8, data(Main.mariechairSize[6], marieChairInfoSize4));
            gecko.poke(Main.NPCAddr + 0xAE0, data(Main.mariechairSize[8], marieChairInfoSize5));

            gecko.poke(Main.NPCAddr + 0xAE4, Main.float2Hex(Convert.ToSingle(marieChairInfoPoint1)));
            gecko.poke(Main.NPCAddr + 0xAE8, Main.float2Hex(Convert.ToSingle(marieChairInfoPoint2)));
            gecko.poke(Main.NPCAddr + 0xAEC, Main.float2Hex(Convert.ToSingle(marieChairInfoPoint3)));
            //Judd
            gecko.poke(Main.NPCAddr - 0xE44, data(0x3F800000, juddInfoSize1));
            gecko.poke(Main.NPCAddr - 0xE34, data(0x3F800000, juddInfoSize2));
            gecko.poke(Main.NPCAddr - 0xE24, data(0x3F800000, juddInfoSize3));

            gecko.poke(Main.NPCAddr - 0xE20, Main.float2Hex(Convert.ToSingle(juddInfoPoint1)));
            gecko.poke(Main.NPCAddr - 0xE1C, Main.float2Hex(Convert.ToSingle(juddInfoPoint2)));
            gecko.poke(Main.NPCAddr - 0xE18, Main.float2Hex(Convert.ToSingle(juddInfoPoint3)));
            //Spyke
            gecko.poke(Main.spykeAddr - 0x538, data(Main.spykeSize[0], spykeInfoSize1));
            gecko.poke(Main.spykeAddr - 0x530, data(Main.spykeSize[2], spykeInfoSize2));
            gecko.poke(Main.spykeAddr - 0x528, data(Main.spykeSize[4], spykeInfoSize3));
            gecko.poke(Main.spykeAddr - 0x520, data(Main.spykeSize[6], spykeInfoSize4));
            gecko.poke(Main.spykeAddr - 0x518, data(Main.spykeSize[8], spykeInfoSize5));

            gecko.poke(Main.spykeAddr - 0x514, Main.float2Hex(Convert.ToSingle(spykeInfoPoint1)));
            gecko.poke(Main.spykeAddr - 0x510, Main.float2Hex(Convert.ToSingle(spykeInfoPoint2)));
            gecko.poke(Main.spykeAddr - 0x50C, Main.float2Hex(Convert.ToSingle(spykeInfoPoint3)));
            //Sea Snails
            gecko.poke(Main.NPCAddr - 0x6798, data(Main.shellSize[0], shellInfoSize1));
            gecko.poke(Main.NPCAddr - 0x6790, data(Main.shellSize[2], shellInfoSize2));
            gecko.poke(Main.NPCAddr - 0x6788, data(Main.shellSize[4], shellInfoSize3));
            gecko.poke(Main.NPCAddr - 0x6780, data(Main.shellSize[6], shellInfoSize4));
            gecko.poke(Main.NPCAddr - 0x6778, data(Main.shellSize[8], shellInfoSize5));

            gecko.poke(Main.NPCAddr - 0x6774, Main.float2Hex(Convert.ToSingle(shellInfoPoint1)));
            gecko.poke(Main.NPCAddr - 0x6770, Main.float2Hex(Convert.ToSingle(shellInfoPoint2)));
            gecko.poke(Main.NPCAddr - 0x676C, Main.float2Hex(Convert.ToSingle(shellInfoPoint3)));
            //Train
            gecko.poke(Main.NPCAddr - 0x9C2C, data(0x3F800000, trainInfoSize1));
            gecko.poke(Main.NPCAddr - 0x9C1C, data(0x3F800000, trainInfoSize2));
            gecko.poke(Main.NPCAddr - 0x9C0C, data(0x3F800000, trainInfoSize3));

            gecko.poke(Main.NPCAddr - 0x9C08, Main.float2Hex(Convert.ToSingle(trainInfoPoint1)));
            gecko.poke(Main.NPCAddr - 0x9C04, Main.float2Hex(Convert.ToSingle(trainInfoPoint2)));
            gecko.poke(Main.NPCAddr - 0x9C00, Main.float2Hex(Convert.ToSingle(trainInfoPoint3)));
            //Amiibo Box
            gecko.poke(Main.NPCAddr - 0x608, data(Main.amiiboSize[0], amiiboInfoSize1));
            gecko.poke(Main.NPCAddr - 0x600, data(Main.amiiboSize[2], amiiboInfoSize2));
            gecko.poke(Main.NPCAddr - 0x5F8, data(Main.amiiboSize[4], amiiboInfoSize3));
            gecko.poke(Main.NPCAddr - 0x5F0, data(Main.amiiboSize[6], amiiboInfoSize4));
            gecko.poke(Main.NPCAddr - 0x5E8, data(Main.amiiboSize[8], amiiboInfoSize5));

            gecko.poke(Main.NPCAddr - 0x5E4, Main.float2Hex(Convert.ToSingle(amiiboInfoPoint1)));
            gecko.poke(Main.NPCAddr - 0x5E0, Main.float2Hex(Convert.ToSingle(amiiboInfoPoint2)));
            gecko.poke(Main.NPCAddr - 0x5DC, Main.float2Hex(Convert.ToSingle(amiiboInfoPoint1)));
            //Balloon
            gecko.poke(Main.NPCAddr - 0x90D8, data(Main.balloonSize[0], balloonInfoSize1));
            gecko.poke(Main.NPCAddr - 0x90D0, data(Main.balloonSize[2], balloonInfoSize2));
            gecko.poke(Main.NPCAddr - 0x90C8, data(Main.balloonSize[4], balloonInfoSize3));
            gecko.poke(Main.NPCAddr - 0x90C0, data(Main.balloonSize[6], balloonInfoSize4));
            gecko.poke(Main.NPCAddr - 0x90B8, data(Main.balloonSize[8], balloonInfoSize5));

            gecko.poke(Main.NPCAddr - 0x90B4, Main.float2Hex(Convert.ToSingle(balloonInfoPoint1)));
            gecko.poke(Main.NPCAddr - 0x90B0, Main.float2Hex(Convert.ToSingle(balloonInfoPoint2)));
            gecko.poke(Main.NPCAddr - 0x90AC, Main.float2Hex(Convert.ToSingle(balloonInfoPoint3)));
            //Miiverse Post
            gecko.poke(Main.NPCAddr - 0x1884, data(Main.postSize[0], postInfoSize1));
            gecko.poke(Main.NPCAddr - 0x187C, data(Main.postSize[2], postInfoSize2));
            gecko.poke(Main.NPCAddr - 0x1874, data(Main.postSize[4], postInfoSize3));
            gecko.poke(Main.NPCAddr - 0x186C, data(Main.postSize[6], postInfoSize4));
            gecko.poke(Main.NPCAddr - 0x1864, data(Main.postSize[8], postInfoSize5));

            gecko.poke(Main.NPCAddr - 0x1860, Main.float2Hex(Convert.ToSingle(postInfoPoint1)));
            gecko.poke(Main.NPCAddr - 0x185C, Main.float2Hex(Convert.ToSingle(postInfoPoint2)));
            gecko.poke(Main.NPCAddr - 0x1858, Main.float2Hex(Convert.ToSingle(postInfoPoint3)));
            //Arcade
            gecko.poke(Main.NPCAddr + 0x140, data(Main.arcadeSize[0], arcadeInfoSize1));
            gecko.poke(Main.NPCAddr + 0x148, data(Main.arcadeSize[2], arcadeInfoSize2));
            gecko.poke(Main.NPCAddr + 0x150, data(Main.arcadeSize[4], arcadeInfoSize3));
            gecko.poke(Main.NPCAddr + 0x158, data(Main.arcadeSize[6], arcadeInfoSize4));
            gecko.poke(Main.NPCAddr + 0x160, data(Main.arcadeSize[8], arcadeInfoSize5));

            gecko.poke(Main.NPCAddr + 0x164, Main.float2Hex(Convert.ToSingle(arcadeInfoPoint1)));
            gecko.poke(Main.NPCAddr + 0x168, Main.float2Hex(Convert.ToSingle(arcadeInfoPoint2)));
            gecko.poke(Main.NPCAddr + 0x16C, Main.float2Hex(Convert.ToSingle(arcadeInfoPoint3)));
            //Manhole
            gecko.poke(Main.manHoleAddr - 0x6FC, data(0x3F800000, manHoleInfoSize1));
            gecko.poke(Main.manHoleAddr - 0x6EC, data(0x3F800000, manHoleInfoSize2));
            gecko.poke(Main.manHoleAddr - 0x6DC, data(0x3F800000, manHoleInfoSize3));

            gecko.poke(Main.manHoleAddr - 0x6D8, Main.float2Hex(Convert.ToSingle(manHoleInfoPoint1)));
            gecko.poke(Main.manHoleAddr - 0x6D4, Main.float2Hex(Convert.ToSingle(manHoleInfoPoint2)));
            gecko.poke(Main.manHoleAddr - 0x6D0, Main.float2Hex(Convert.ToSingle(manHoleInfoPoint3)));
            //Weapon sign
            gecko.poke(Main.NPCAddr - 0x71E8, data(Main.weaponSignSize[0], weaponSignInfoSize1));
            gecko.poke(Main.NPCAddr - 0x71E0, data(Main.weaponSignSize[2], weaponSignInfoSize2));
            gecko.poke(Main.NPCAddr - 0x71D8, data(Main.weaponSignSize[4], weaponSignInfoSize3));
            gecko.poke(Main.NPCAddr - 0x71D0, data(Main.weaponSignSize[6], weaponSignInfoSize4));
            gecko.poke(Main.NPCAddr - 0x71C8, data(Main.weaponSignSize[8], weaponSignInfoSize5));

            gecko.poke(Main.NPCAddr - 0x71C4, Main.float2Hex(Convert.ToSingle(weaponSignInfoPoint1)));
            gecko.poke(Main.NPCAddr - 0x71C0, Main.float2Hex(Convert.ToSingle(weaponSignInfoPoint2)));
            gecko.poke(Main.NPCAddr - 0x71BC, Main.float2Hex(Convert.ToSingle(weaponSignInfoPoint3)));
            //Awning
            gecko.poke(Main.NPCAddr - 0x48A8, data(0x3F800000, clothInfoSize1));
            gecko.poke(Main.NPCAddr - 0x4898, data(0x3F800000, clothInfoSize2));
            gecko.poke(Main.NPCAddr - 0x4888, data(0x3F800000, clothInfoSize3));

            gecko.poke(Main.NPCAddr - 0x4884, Main.float2Hex(Convert.ToSingle(clothInfoPoint1)));
            gecko.poke(Main.NPCAddr - 0x4880, Main.float2Hex(Convert.ToSingle(clothInfoPoint2)));
            gecko.poke(Main.NPCAddr - 0x487C, Main.float2Hex(Convert.ToSingle(clothInfoPoint3)));
            //Main TV
            gecko.poke(Main.sistersAddr + 0x28F4, data(0x3F800000, tvInfoSize1));
            gecko.poke(Main.sistersAddr + 0x2904, data(0x3F800000, tvInfoSize2));
            gecko.poke(Main.sistersAddr + 0x2914, data(0x3F800000, tvInfoSize3));

            gecko.poke(Main.sistersAddr + 0x2918, Main.float2Hex(Convert.ToSingle(tvInfoPoint1)));
            gecko.poke(Main.sistersAddr + 0x291C, Main.float2Hex(Convert.ToSingle(tvInfoPoint2)));
            gecko.poke(Main.sistersAddr + 0x2920, Main.float2Hex(Convert.ToSingle(tvInfoPoint3)));
            //Great Zapfish
            gecko.poke(Main.NPCAddr + 0x3730, data(0x3F800000, fishInfoSize1));
            gecko.poke(Main.NPCAddr + 0x3740, data(0x3F800000, fishInfoSize2));
            gecko.poke(Main.NPCAddr + 0x3750, data(0x3F800000, fishInfoSize3));

            gecko.poke(Main.NPCAddr + 0x3754, Main.float2Hex(Convert.ToSingle(fishInfoPoint1)));
            gecko.poke(Main.NPCAddr + 0x3758, Main.float2Hex(Convert.ToSingle(fishInfoPoint2)));
            gecko.poke(Main.NPCAddr + 0x375C, Main.float2Hex(Convert.ToSingle(fishInfoPoint3)));
            //Tree
            gecko.poke(Main.NPCAddr - 0x8688, data(0x3F800000, tree1InfoSize1));
            gecko.poke(Main.NPCAddr - 0x8678, data(0x3F800000, tree1InfoSize2));
            gecko.poke(Main.NPCAddr - 0x8658, data(0x3F800000, tree1InfoSize3));

            gecko.poke(Main.NPCAddr - 0x8664, Main.float2Hex(Convert.ToSingle(tree1InfoPoint1)));
            gecko.poke(Main.NPCAddr - 0x8660, Main.float2Hex(Convert.ToSingle(tree1InfoPoint2)));
            gecko.poke(Main.NPCAddr - 0x865C, Main.float2Hex(Convert.ToSingle(tree1InfoPoint3)));
            //Tree 2
            gecko.poke(Main.NPCAddr - 0x7C38, data(0x3F800000, tree2InfoSize1));
            gecko.poke(Main.NPCAddr - 0x7C28, data(0x3F800000, tree2InfoSize2));
            gecko.poke(Main.NPCAddr - 0x7C18, data(0x3F800000, tree2InfoSize3));

            gecko.poke(Main.NPCAddr - 0x7C14, Main.float2Hex(Convert.ToSingle(tree2InfoPoint1)));
            gecko.poke(Main.NPCAddr - 0x7C10, Main.float2Hex(Convert.ToSingle(tree2InfoPoint2)));
            gecko.poke(Main.NPCAddr - 0x7C0C, Main.float2Hex(Convert.ToSingle(tree2InfoPoint3)));
            //Tree 3
            gecko.poke(Main.NPCAddr - 0x5D48, data(0x3F800000, tree3InfoSize1));
            gecko.poke(Main.NPCAddr - 0x5D38, data(0x3F800000, tree3InfoSize2));
            gecko.poke(Main.NPCAddr - 0x5D28, data(0x3F800000, tree3InfoSize3));

            gecko.poke(Main.NPCAddr - 0x5D24, Main.float2Hex(Convert.ToSingle(tree3InfoPoint1)));
            gecko.poke(Main.NPCAddr - 0x5D20, Main.float2Hex(Convert.ToSingle(tree3InfoPoint2)));
            gecko.poke(Main.NPCAddr - 0x5D1C, Main.float2Hex(Convert.ToSingle(tree3InfoPoint3)));
            //Tree 4
            gecko.poke(Main.NPCAddr - 0x52F8, data(0x3F800000, tree4InfoSize1));
            gecko.poke(Main.NPCAddr - 0x52E8, data(0x3F800000, tree4InfoSize2));
            gecko.poke(Main.NPCAddr - 0x52D8, data(0x3F800000, tree4InfoSize3));

            gecko.poke(Main.NPCAddr - 0x52D4, Main.float2Hex(Convert.ToSingle(tree4InfoPoint1)));
            gecko.poke(Main.NPCAddr - 0x52D0, Main.float2Hex(Convert.ToSingle(tree4InfoPoint2)));
            gecko.poke(Main.NPCAddr - 0x52CC, Main.float2Hex(Convert.ToSingle(tree4InfoPoint3)));
            //Bird 1
            gecko.poke(Main.NPCAddr - 0x3D68, data(Main.birdSize[0], bird1InfoSize1));
            gecko.poke(Main.NPCAddr - 0x3D50, data(Main.birdSize[2], bird1InfoSize2));
            gecko.poke(Main.NPCAddr - 0x3D58, data(Main.birdSize[4], bird1InfoSize3));
            gecko.poke(Main.NPCAddr - 0x3D40, data(Main.birdSize[6], bird1InfoSize4));
            gecko.poke(Main.NPCAddr - 0x3D48, data(Main.birdSize[8], bird1InfoSize5));

            gecko.poke(Main.NPCAddr - 0x3D44, Main.float2Hex(Convert.ToSingle(bird1InfoPoint1)));
            gecko.poke(Main.NPCAddr - 0x3D40, Main.float2Hex(Convert.ToSingle(bird1InfoPoint2)));
            gecko.poke(Main.NPCAddr - 0x3D3C, Main.float2Hex(Convert.ToSingle(bird1InfoPoint3)));
            //Bird 2
            gecko.poke(Main.NPCAddr - 0x37DC, data(Main.bird2Size[0], bird2InfoSize1));
            gecko.poke(Main.NPCAddr - 0x37D4, data(Main.bird2Size[2], bird2InfoSize2));
            gecko.poke(Main.NPCAddr - 0x37CC, data(Main.bird2Size[4], bird2InfoSize3));
            gecko.poke(Main.NPCAddr - 0x37C4, data(Main.bird2Size[6], bird2InfoSize4));
            gecko.poke(Main.NPCAddr - 0x37BC, data(Main.bird2Size[8], bird2InfoSize5));

            gecko.poke(Main.NPCAddr - 0x37B8, Main.float2Hex(Convert.ToSingle(bird2InfoPoint1)));
            gecko.poke(Main.NPCAddr - 0x37B4, Main.float2Hex(Convert.ToSingle(bird2InfoPoint2)));
            gecko.poke(Main.NPCAddr - 0x37B0, Main.float2Hex(Convert.ToSingle(bird2InfoPoint3)));
            //Bird 3
            gecko.poke(Main.NPCAddr - 0x3250, data(Main.bird3Size[0], bird3InfoSize1));
            gecko.poke(Main.NPCAddr - 0x3248, data(Main.bird3Size[2], bird3InfoSize2));
            gecko.poke(Main.NPCAddr - 0x3240, data(Main.bird3Size[4], bird3InfoSize3));
            gecko.poke(Main.NPCAddr - 0x3238, data(Main.bird3Size[6], bird3InfoSize4));
            gecko.poke(Main.NPCAddr - 0x3230, data(Main.bird3Size[8], bird3InfoSize5));

            gecko.poke(Main.NPCAddr - 0x322C, Main.float2Hex(Convert.ToSingle(bird3InfoPoint1)));
            gecko.poke(Main.NPCAddr - 0x3228, Main.float2Hex(Convert.ToSingle(bird3InfoPoint2)));
            gecko.poke(Main.NPCAddr - 0x3224, Main.float2Hex(Convert.ToSingle(bird3InfoPoint3)));
            //Bird 4
            gecko.poke(Main.NPCAddr - 0x2CC4, data(Main.bird4Size[0], bird4InfoSize1));
            gecko.poke(Main.NPCAddr - 0x2CBC, data(Main.bird4Size[2], bird4InfoSize2));
            gecko.poke(Main.NPCAddr - 0x2CB4, data(Main.bird4Size[4], bird4InfoSize3));
            gecko.poke(Main.NPCAddr - 0x2CAC, data(Main.bird4Size[6], bird4InfoSize4));
            gecko.poke(Main.NPCAddr - 0x2CA4, data(Main.bird4Size[8], bird4InfoSize5));

            gecko.poke(Main.NPCAddr - 0x2CA0, Main.float2Hex(Convert.ToSingle(bird4InfoPoint1)));
            gecko.poke(Main.NPCAddr - 0x2C9C, Main.float2Hex(Convert.ToSingle(bird4InfoPoint2)));
            gecko.poke(Main.NPCAddr - 0x2C98, Main.float2Hex(Convert.ToSingle(bird4InfoPoint3)));
            //Bird 5
            gecko.poke(Main.NPCAddr - 0x2738, data(Main.bird5Size[0], bird5InfoSize1));
            gecko.poke(Main.NPCAddr - 0x2730, data(Main.bird5Size[2], bird5InfoSize2));
            gecko.poke(Main.NPCAddr - 0x2728, data(Main.bird5Size[4], bird5InfoSize3));
            gecko.poke(Main.NPCAddr - 0x2720, data(Main.bird5Size[6], bird5InfoSize4));
            gecko.poke(Main.NPCAddr - 0x2718, data(Main.bird5Size[8], bird5InfoSize5));

            gecko.poke(Main.NPCAddr - 0x2714, Main.float2Hex(Convert.ToSingle(bird5InfoPoint1)));
            gecko.poke(Main.NPCAddr - 0x2710, Main.float2Hex(Convert.ToSingle(bird5InfoPoint2)));
            gecko.poke(Main.NPCAddr - 0x270C, Main.float2Hex(Convert.ToSingle(bird5InfoPoint3)));
            //Plaza Door: Hat
            gecko.poke(Main.NPCAddr + 0xEE8, data(0x3F800000, doorHatInfoSize1));
            gecko.poke(Main.NPCAddr + 0xEF8, data(0x3F800000, doorHatInfoSize2));
            gecko.poke(Main.NPCAddr + 0xF08, data(0x3F800000, doorHatInfoSize3));

            gecko.poke(Main.NPCAddr + 0xF0C, Main.float2Hex(Convert.ToSingle(doorHatInfoPoint1)));
            gecko.poke(Main.NPCAddr + 0xF10, Main.float2Hex(Convert.ToSingle(doorHatInfoPoint2)));
            gecko.poke(Main.NPCAddr + 0xF14, Main.float2Hex(Convert.ToSingle(doorHatInfoPoint3)));
            //Plaza Door: Clothes
            gecko.poke(Main.NPCAddr + 0x1C10, data(0x3F800000, doorShirtInfoSize1));
            gecko.poke(Main.NPCAddr + 0x1C20, data(0x3F800000, doorShirtInfoSize2));
            gecko.poke(Main.NPCAddr + 0x1C30, data(0x3F800000, doorShirtInfoSize3));

            gecko.poke(Main.NPCAddr + 0x1C34, Main.float2Hex(Convert.ToSingle(doorShirtInfoPoint1)));
            gecko.poke(Main.NPCAddr + 0x1C38, Main.float2Hex(Convert.ToSingle(doorShirtInfoPoint2)));
            gecko.poke(Main.NPCAddr + 0x1C3C, Main.float2Hex(Convert.ToSingle(doorShirtInfoPoint3)));
            //Plaza Door: Shoes
            gecko.poke(Main.NPCAddr + 0x157C, data(0x3F800000, doorShoesInfoSize1));
            gecko.poke(Main.NPCAddr + 0x158C, data(0x3F800000, doorShoesInfoSize2));
            gecko.poke(Main.NPCAddr + 0x159C, data(0x3F800000, doorShoesInfoSize3));

            gecko.poke(Main.NPCAddr + 0x15A0, Main.float2Hex(Convert.ToSingle(doorShoesInfoPoint1)));
            gecko.poke(Main.NPCAddr + 0x15A4, Main.float2Hex(Convert.ToSingle(doorShoesInfoPoint2)));
            gecko.poke(Main.NPCAddr + 0x15A8, Main.float2Hex(Convert.ToSingle(doorShoesInfoPoint3)));
            //Plaza Door: Weapon
            gecko.poke(Main.NPCAddr + 0x22A4, data(0x3F800000, doorWeaponInfoSize1));
            gecko.poke(Main.NPCAddr + 0x22B4, data(0x3F800000, doorWeaponInfoSize2));
            gecko.poke(Main.NPCAddr + 0x22C4, data(0x3F800000, doorWeaponInfoSize3));

            gecko.poke(Main.NPCAddr + 0x22C8, Main.float2Hex(Convert.ToSingle(doorWeaponInfoPoint1)));
            gecko.poke(Main.NPCAddr + 0x22CC, Main.float2Hex(Convert.ToSingle(doorWeaponInfoPoint2)));
            gecko.poke(Main.NPCAddr + 0x22D0, Main.float2Hex(Convert.ToSingle(doorWeaponInfoPoint3)));
            //Plaza Door: VSGame
            gecko.poke(Main.NPCAddr + 0x2938, data(0x3F800000, doorVSInfoSize1));
            gecko.poke(Main.NPCAddr + 0x2948, data(0x3F800000, doorVSInfoSize2));
            gecko.poke(Main.NPCAddr + 0x2958, data(0x3F800000, doorVSInfoSize3));

            gecko.poke(Main.NPCAddr + 0x295C, Main.float2Hex(Convert.ToSingle(doorVSInfoPoint1)));
            gecko.poke(Main.NPCAddr + 0x2960, Main.float2Hex(Convert.ToSingle(doorVSInfoPoint2)));
            gecko.poke(Main.NPCAddr + 0x2964, Main.float2Hex(Convert.ToSingle(doorVSInfoPoint3)));
            //Plaza Door: Dojo
            gecko.poke(Main.NPCAddr + 0x2FCC, data(0x3F800000, doorDojoInfoSize1));
            gecko.poke(Main.NPCAddr + 0x2FDC, data(0x3F800000, doorDojoInfoSize2));
            gecko.poke(Main.NPCAddr + 0x2FEC, data(0x3F800000, doorDojoInfoSize3));

            gecko.poke(Main.NPCAddr + 0x2FF0, Main.float2Hex(Convert.ToSingle(doorDojoInfoPoint1)));
            gecko.poke(Main.NPCAddr + 0x2FF4, Main.float2Hex(Convert.ToSingle(doorDojoInfoPoint2)));
            gecko.poke(Main.NPCAddr + 0x2FF8, Main.float2Hex(Convert.ToSingle(doorDojoInfoPoint3)));
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
        public static decimal manHoleInfoSize1 = 1;
        public static decimal manHoleInfoSize2 = 1;
        public static decimal manHoleInfoSize3 = 1;
        public static decimal manHoleInfoSizeMaster = 1;
        public static void manHoleInfoSize(decimal x, decimal y, decimal z)
        {
            manHoleInfoSize1 = x;
            manHoleInfoSize2 = y;
            manHoleInfoSize3 = z;
        }
        public static void manHoleMasterScale(decimal master)
        {
            manHoleInfoSizeMaster = master;
        }
        public static decimal manHoleInfoPoint1 = vert(Main.manHolePoint[0]);
        public static decimal manHoleInfoPoint2 = vert(Main.manHolePoint[1]);
        public static decimal manHoleInfoPoint3 = vert(Main.manHolePoint[2]);

        public static void manHoleInfoPoint(decimal x, decimal y, decimal z)
        {
            manHoleInfoPoint1 = x;
            manHoleInfoPoint2 = y;
            manHoleInfoPoint3 = z;
        }
        //Weapon Sign
        public static decimal weaponSignInfoSize1 = 1;
        public static decimal weaponSignInfoSize2 = 1;
        public static decimal weaponSignInfoSize3 = 1;
        public static decimal weaponSignInfoSize4 = 1;
        public static decimal weaponSignInfoSize5 = 1;
        public static decimal weaponSignInfoSizeMaster = 1;

        public static void weaponSignInfoSize(decimal x1, decimal x2, decimal y, decimal z1, decimal z2)
        {
            weaponSignInfoSize1 = x1;
            weaponSignInfoSize2 = x2;
            weaponSignInfoSize3 = y;
            weaponSignInfoSize4 = z1;
            weaponSignInfoSize5 = z2;
        }
        public static void weaponSignMasterScale(decimal master)
        {
            weaponSignInfoSizeMaster = master;
        }
        public static decimal weaponSignInfoPoint1 = vert(Main.weaponSignPoint[0]);
        public static decimal weaponSignInfoPoint2 = vert(Main.weaponSignPoint[1]);
        public static decimal weaponSignInfoPoint3 = vert(Main.weaponSignPoint[2]);

        public static void weaponSignInfoPoint(decimal x, decimal y, decimal z)
        {
            weaponSignInfoPoint1 = x;
            weaponSignInfoPoint2 = y;
            weaponSignInfoPoint3 = z;
        }
        //Cloth
        public static decimal clothInfoSize1 = 1;
        public static decimal clothInfoSize2 = 1;
        public static decimal clothInfoSize3 = 1;
        public static decimal clothInfoSizeMaster = 1;

        public static void clothInfoSize(decimal x, decimal y, decimal z)
        {
            clothInfoSize1 = x;
            clothInfoSize2 = y;
            clothInfoSize3 = z;
        }
        public static void clothMasterScale(decimal master)
        {
            clothInfoSizeMaster = master;
        }
        public static decimal clothInfoPoint1 = vert(Main.clothPoint[0]);
        public static decimal clothInfoPoint2 = vert(Main.clothPoint[1]);
        public static decimal clothInfoPoint3 = vert(Main.clothPoint[2]);

        public static void clothInfoPoint(decimal x, decimal y, decimal z)
        {
            clothInfoPoint1 = x;
            clothInfoPoint2 = y;
            clothInfoPoint3 = z;
        }
        //Main TV
        public static decimal tvInfoSize1 = 1;
        public static decimal tvInfoSize2 = 1;
        public static decimal tvInfoSize3 = 1;
        public static decimal tvInfoSizeMaster = 1;

        public static void tvInfoSize(decimal x, decimal y, decimal z)
        {
            tvInfoSize1 = x;
            tvInfoSize2 = y;
            tvInfoSize3 = z;
        }
        public static void tvMasterScale(decimal master)
        {
            tvInfoSizeMaster = master;
        }
        public static decimal tvInfoPoint1 = 0;
        public static decimal tvInfoPoint2 = 0;
        public static decimal tvInfoPoint3 = 0;

        public static void tvInfoPoint(decimal x, decimal y, decimal z)
        {
            tvInfoPoint1 = x;
            tvInfoPoint2 = y;
            tvInfoPoint3 = z;
        }
        //Great Zapfish
        public static decimal fishInfoSize1 = 1;
        public static decimal fishInfoSize2 = 1;
        public static decimal fishInfoSize3 = 1;
        public static decimal fishInfoSizeMaster = 1;

        public static void fishInfoSize(decimal x, decimal y, decimal z)
        {
            fishInfoSize1 = x;
            fishInfoSize2 = y;
            fishInfoSize3 = z;
        }
        public static void fishMasterScale(decimal master)
        {
            fishInfoSizeMaster = master;
        }
        public static decimal fishInfoPoint1 = vert(Main.fishPoint[0]);
        public static decimal fishInfoPoint2 = vert(Main.fishPoint[1]);
        public static decimal fishInfoPoint3 = vert(Main.fishPoint[2]);

        public static void fishInfoPoint(decimal x, decimal y, decimal z)
        {
            fishInfoPoint1 = x;
            fishInfoPoint2 = y;
            fishInfoPoint3 = z;
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
        //Bird 1
        public static decimal bird1InfoSize1 = 1;
        public static decimal bird1InfoSize2 = 1;
        public static decimal bird1InfoSize3 = 1;
        public static decimal bird1InfoSize4 = 1;
        public static decimal bird1InfoSize5 = 1;
        public static decimal bird1InfoSizeMaster = 1;

        public static void bird1InfoSize(decimal x1, decimal x2, decimal y, decimal z1, decimal z2)
        {
            bird1InfoSize1 = x1;
            bird1InfoSize2 = x2;
            bird1InfoSize3 = y;
            bird1InfoSize4 = z1;
            bird1InfoSize5 = z2;
        }
        public static void bird1MasterScale(decimal master)
        {
            bird1InfoSizeMaster = master;
        }
        public static decimal bird1InfoPoint1 = vert(Main.birdPoint[0]);
        public static decimal bird1InfoPoint2 = vert(Main.birdPoint[1]);
        public static decimal bird1InfoPoint3 = vert(Main.birdPoint[2]);

        public static void bird1InfoPoint(decimal x, decimal y, decimal z)
        {
            bird1InfoPoint1 = x;
            bird1InfoPoint2 = y;
            bird1InfoPoint3 = z;
        }
        //Bird 2
        public static decimal bird2InfoSize1 = 1;
        public static decimal bird2InfoSize2 = 1;
        public static decimal bird2InfoSize3 = 1;
        public static decimal bird2InfoSize4 = 1;
        public static decimal bird2InfoSize5 = 1;
        public static decimal bird2InfoSizeMaster = 1;

        public static void bird2InfoSize(decimal x1, decimal x2, decimal y, decimal z1, decimal z2)
        {
            bird2InfoSize1 = x1;
            bird2InfoSize2 = x2;
            bird2InfoSize3 = y;
            bird2InfoSize4 = z1;
            bird2InfoSize5 = z2;
        }
        public static void bird2MasterScale(decimal master)
        {
            bird2InfoSizeMaster = master;
        }
        public static decimal bird2InfoPoint1 = vert(Main.bird2Point[0]);
        public static decimal bird2InfoPoint2 = vert(Main.bird2Point[1]);
        public static decimal bird2InfoPoint3 = vert(Main.bird2Point[2]);

        public static void bird2InfoPoint(decimal x, decimal y, decimal z)
        {
            bird2InfoPoint1 = x;
            bird2InfoPoint2 = y;
            bird2InfoPoint3 = z;
        }
        //Bird 3
        public static decimal bird3InfoSize1 = 1;
        public static decimal bird3InfoSize2 = 1;
        public static decimal bird3InfoSize3 = 1;
        public static decimal bird3InfoSize4 = 1;
        public static decimal bird3InfoSize5 = 1;
        public static decimal bird3InfoSizeMaster = 1;

        public static void bird3InfoSize(decimal x1, decimal x2, decimal y, decimal z1, decimal z2)
        {
            bird3InfoSize1 = x1;
            bird3InfoSize2 = x2;
            bird3InfoSize3 = y;
            bird3InfoSize4 = z1;
            bird3InfoSize5 = z2;
        }
        public static void bird3MasterScale(decimal master)
        {
            bird3InfoSizeMaster = master;
        }
        public static decimal bird3InfoPoint1 = vert(Main.bird3Point[0]);
        public static decimal bird3InfoPoint2 = vert(Main.bird3Point[1]);
        public static decimal bird3InfoPoint3 = vert(Main.bird3Point[2]);

        public static void bird3InfoPoint(decimal x, decimal y, decimal z)
        {
            bird3InfoPoint1 = x;
            bird3InfoPoint2 = y;
            bird3InfoPoint3 = z;
        }
        //Bird 4
        public static decimal bird4InfoSize1 = 1;
        public static decimal bird4InfoSize2 = 1;
        public static decimal bird4InfoSize3 = 1;
        public static decimal bird4InfoSize4 = 1;
        public static decimal bird4InfoSize5 = 1;
        public static decimal bird4InfoSizeMaster = 1;

        public static void bird4InfoSize(decimal x1, decimal x2, decimal y, decimal z1, decimal z2)
        {
            bird4InfoSize1 = x1;
            bird4InfoSize2 = x2;
            bird4InfoSize3 = y;
            bird4InfoSize4 = z1;
            bird4InfoSize5 = z2;
        }
        public static void bird4MasterScale(decimal master)
        {
            bird4InfoSizeMaster = master;
        }
        public static decimal bird4InfoPoint1 = vert(Main.bird4Point[0]);
        public static decimal bird4InfoPoint2 = vert(Main.bird4Point[1]);
        public static decimal bird4InfoPoint3 = vert(Main.bird4Point[2]);

        public static void bird4InfoPoint(decimal x, decimal y, decimal z)
        {
            bird4InfoPoint1 = x;
            bird4InfoPoint2 = y;
            bird4InfoPoint3 = z;
        }
        //Bird 5
        public static decimal bird5InfoSize1 = 1;
        public static decimal bird5InfoSize2 = 1;
        public static decimal bird5InfoSize3 = 1;
        public static decimal bird5InfoSize4 = 1;
        public static decimal bird5InfoSize5 = 1;
        public static decimal bird5InfoSizeMaster = 1;

        public static void bird5InfoSize(decimal x1, decimal x2, decimal y, decimal z1, decimal z2)
        {
            bird5InfoSize1 = x1;
            bird5InfoSize2 = x2;
            bird5InfoSize3 = y;
            bird5InfoSize4 = z1;
            bird5InfoSize5 = z2;
        }
        public static void bird5MasterScale(decimal master)
        {
            bird5InfoSizeMaster = master;
        }
        public static decimal bird5InfoPoint1 = vert(Main.bird5Point[0]);
        public static decimal bird5InfoPoint2 = vert(Main.bird5Point[1]);
        public static decimal bird5InfoPoint3 = vert(Main.bird5Point[2]);

        public static void bird5InfoPoint(decimal x, decimal y, decimal z)
        {
            bird5InfoPoint1 = x;
            bird5InfoPoint2 = y;
            bird5InfoPoint3 = z;
        }
        //Plaza door: Hat
        public static decimal doorHatInfoSize1 = 1;
        public static decimal doorHatInfoSize2 = 1;
        public static decimal doorHatInfoSize3 = 1;
        public static decimal doorHatInfoSizeGlobal = 1;
        public static decimal doorHatInfoSizeMaster = 1;

        public static void doorHatInfoSize(decimal x, decimal y, decimal z)
        {
            doorHatInfoSize1 = x;
            doorHatInfoSize2 = y;
            doorHatInfoSize3 = z;
        }
        public static void doorHatMasterScale(decimal master)
        {
            doorHatInfoSizeMaster = master;
        }
        public static decimal doorHatInfoPoint1 = 0;
        public static decimal doorHatInfoPoint2 = 0;
        public static decimal doorHatInfoPoint3 = 0;

        public static void doorHatInfoPoint(decimal x, decimal y, decimal z)
        {
            doorHatInfoPoint1 = x;
            doorHatInfoPoint2 = y;
            doorHatInfoPoint3 = z;
        }
        //Plaza door: Shirt
        public static decimal doorShirtInfoSize1 = 1;
        public static decimal doorShirtInfoSize2 = 1;
        public static decimal doorShirtInfoSize3 = 1;
        public static decimal doorShirtInfoSizeGlobal = 1;
        public static decimal doorShirtInfoSizeMaster = 1;

        public static void doorShirtInfoSize(decimal x, decimal y, decimal z)
        {
            doorShirtInfoSize1 = x;
            doorShirtInfoSize2 = y;
            doorShirtInfoSize3 = z;
        }
        public static void doorShirtMasterScale(decimal master)
        {
            doorShirtInfoSizeMaster = master;
        }
        public static decimal doorShirtInfoPoint1 = 0;
        public static decimal doorShirtInfoPoint2 = 0;
        public static decimal doorShirtInfoPoint3 = 0;

        public static void doorShirtInfoPoint(decimal x, decimal y, decimal z)
        {
            doorShirtInfoPoint1 = x;
            doorShirtInfoPoint2 = y;
            doorShirtInfoPoint3 = z;
        }
        //Plaza door: Shoes
        public static decimal doorShoesInfoSize1 = 1;
        public static decimal doorShoesInfoSize2 = 1;
        public static decimal doorShoesInfoSize3 = 1;
        public static decimal doorShoesInfoSizeGlobal = 1;
        public static decimal doorShoesInfoSizeMaster = 1;

        public static void doorShoesInfoSize(decimal x, decimal y, decimal z)
        {
            doorShoesInfoSize1 = x;
            doorShoesInfoSize2 = y;
            doorShoesInfoSize3 = z;
        }
        public static void doorShoesMasterScale(decimal master)
        {
            doorShoesInfoSizeMaster = master;
        }
        public static decimal doorShoesInfoPoint1 = 0;
        public static decimal doorShoesInfoPoint2 = 0;
        public static decimal doorShoesInfoPoint3 = 0;

        public static void doorShoesInfoPoint(decimal x, decimal y, decimal z)
        {
            doorShoesInfoPoint1 = x;
            doorShoesInfoPoint2 = y;
            doorShoesInfoPoint3 = z;
        }
        //Plaza door: Weapon
        public static decimal doorWeaponInfoSize1 = 1;
        public static decimal doorWeaponInfoSize2 = 1;
        public static decimal doorWeaponInfoSize3 = 1;
        public static decimal doorWeaponInfoSizeGlobal = 1;
        public static decimal doorWeaponInfoSizeMaster = 1;

        public static void doorWeaponInfoSize(decimal x, decimal y, decimal z)
        {
            doorWeaponInfoSize1 = x;
            doorWeaponInfoSize2 = y;
            doorWeaponInfoSize3 = z;
        }
        public static void doorWeaponMasterScale(decimal master)
        {
            doorWeaponInfoSizeMaster = master;
        }
        public static decimal doorWeaponInfoPoint1 = 0;
        public static decimal doorWeaponInfoPoint2 = 0;
        public static decimal doorWeaponInfoPoint3 = 0;

        public static void doorWeaponInfoPoint(decimal x, decimal y, decimal z)
        {
            doorWeaponInfoPoint1 = x;
            doorWeaponInfoPoint2 = y;
            doorWeaponInfoPoint3 = z;
        }
        //Plaza door: VSGame
        public static decimal doorVSInfoSize1 = 1;
        public static decimal doorVSInfoSize2 = 1;
        public static decimal doorVSInfoSize3 = 1;
        public static decimal doorVSInfoSizeGlobal = 1;
        public static decimal doorVSInfoSizeMaster = 1;

        public static void doorVSInfoSize(decimal x, decimal y, decimal z)
        {
            doorVSInfoSize1 = x;
            doorVSInfoSize2 = y;
            doorVSInfoSize3 = z;
        }
        public static void doorVSMasterScale(decimal master)
        {
            doorVSInfoSizeMaster = master;
        }
        public static decimal doorVSInfoPoint1 = 0;
        public static decimal doorVSInfoPoint2 = 0;
        public static decimal doorVSInfoPoint3 = 0;

        public static void doorVSInfoPoint(decimal x, decimal y, decimal z)
        {
            doorVSInfoPoint1 = x;
            doorVSInfoPoint2 = y;
            doorVSInfoPoint3 = z;
        }
        //Plaza door: Dojo
        public static decimal doorDojoInfoSize1 = 1;
        public static decimal doorDojoInfoSize2 = 1;
        public static decimal doorDojoInfoSize3 = 1;
        public static decimal doorDojoInfoSizeGlobal = 1;
        public static decimal doorDojoInfoSizeMaster = 1;

        public static void doorDojoInfoSize(decimal x, decimal y, decimal z)
        {
            doorDojoInfoSize1 = x;
            doorDojoInfoSize2 = y;
            doorDojoInfoSize3 = z;
        }
        public static void doorDojoMasterScale(decimal master)
        {
            doorDojoInfoSizeMaster = master;
        }
        public static decimal doorDojoInfoPoint1 = 0;
        public static decimal doorDojoInfoPoint2 = 0;
        public static decimal doorDojoInfoPoint3 = 0;

        public static void doorDojoInfoPoint(decimal x, decimal y, decimal z)
        {
            doorDojoInfoPoint1 = x;
            doorDojoInfoPoint2 = y;
            doorDojoInfoPoint3 = z;
        }
    }
}
