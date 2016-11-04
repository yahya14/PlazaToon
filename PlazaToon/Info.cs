using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlazaToon
{
    class Info
    {
        public static float hex2Float(uint val) //uint to float converter from the joyous amibu
        {
            return BitConverter.ToSingle(BitConverter.GetBytes(val), 0);
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

            callieInfoPoint(Convert.ToDecimal(hex2Float(MainForm.calliePoint[0])), Convert.ToDecimal(hex2Float(MainForm.calliePoint[1])),Convert.ToDecimal(hex2Float(MainForm.calliePoint[2])));
            callieChairInfoPoint(Convert.ToDecimal(hex2Float(MainForm.calliePoint[0])), Convert.ToDecimal(hex2Float(MainForm.calliePoint[1])), Convert.ToDecimal(hex2Float(MainForm.calliePoint[2])));
            marieInfoPoint(Convert.ToDecimal(hex2Float(MainForm.mariePoint[0])), Convert.ToDecimal(hex2Float(MainForm.mariePoint[1])), Convert.ToDecimal(hex2Float(MainForm.mariePoint[2])));
            marieChairInfoPoint(Convert.ToDecimal(hex2Float(MainForm.mariePoint[0])), Convert.ToDecimal(hex2Float(MainForm.mariePoint[1])), Convert.ToDecimal(hex2Float(MainForm.mariePoint[2])));
            juddInfoPoint(Convert.ToDecimal(hex2Float(MainForm.juddPoint[0])), Convert.ToDecimal(hex2Float(MainForm.juddPoint[1])), Convert.ToDecimal(hex2Float(MainForm.juddPoint[2])));
            spykeInfoPoint(Convert.ToDecimal(hex2Float(MainForm.spykePoint[0])), Convert.ToDecimal(hex2Float(MainForm.spykePoint[1])), Convert.ToDecimal(hex2Float(MainForm.spykePoint[2])));
            shellInfoPoint(Convert.ToDecimal(hex2Float(MainForm.shellPoint[0])), Convert.ToDecimal(hex2Float(MainForm.shellPoint[1])), Convert.ToDecimal(hex2Float(MainForm.shellPoint[2])));
            amiiboInfoPoint(Convert.ToDecimal(hex2Float(MainForm.amiiboPoint[0])), Convert.ToDecimal(hex2Float(MainForm.amiiboPoint[1])), Convert.ToDecimal(hex2Float(MainForm.amiiboPoint[2])));
            balloonInfoPoint(Convert.ToDecimal(hex2Float(MainForm.balloonPoint[0])), Convert.ToDecimal(hex2Float(MainForm.balloonPoint[1])), Convert.ToDecimal(hex2Float(MainForm.balloonPoint[2])));
            postInfoPoint(Convert.ToDecimal(hex2Float(MainForm.postPoint[0])), Convert.ToDecimal(hex2Float(MainForm.postPoint[1])), Convert.ToDecimal(hex2Float(MainForm.postPoint[2])));
            tree1InfoPoint(Convert.ToDecimal(hex2Float(MainForm.treePoint[0])), Convert.ToDecimal(hex2Float(MainForm.treePoint[1])), Convert.ToDecimal(hex2Float(MainForm.treePoint[2])));
            tree2InfoPoint(Convert.ToDecimal(hex2Float(MainForm.tree2Point[0])), Convert.ToDecimal(hex2Float(MainForm.tree2Point[1])), Convert.ToDecimal(hex2Float(MainForm.tree2Point[2])));
            tree3InfoPoint(Convert.ToDecimal(hex2Float(MainForm.tree3Point[0])), Convert.ToDecimal(hex2Float(MainForm.tree3Point[1])), Convert.ToDecimal(hex2Float(MainForm.tree3Point[2])));
            tree4InfoPoint(Convert.ToDecimal(hex2Float(MainForm.tree4Point[0])), Convert.ToDecimal(hex2Float(MainForm.tree4Point[1])), Convert.ToDecimal(hex2Float(MainForm.tree4Point[2])));
            arcadeInfoPoint(Convert.ToDecimal(hex2Float(MainForm.arcadePoint[0])), Convert.ToDecimal(hex2Float(MainForm.arcadePoint[1])), Convert.ToDecimal(hex2Float(MainForm.arcadePoint[2])));
            manholeInfoPoint(Convert.ToDecimal(hex2Float(MainForm.manholePoint[0])), Convert.ToDecimal(hex2Float(MainForm.manholePoint[1])), Convert.ToDecimal(hex2Float(MainForm.manholePoint[2])));
            weaponsignInfoPoint(Convert.ToDecimal(hex2Float(MainForm.weaponsignPoint[0])), Convert.ToDecimal(hex2Float(MainForm.weaponsignPoint[1])), Convert.ToDecimal(hex2Float(MainForm.weaponsignPoint[2])));
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
        public static decimal callieInfoPoint1 = Convert.ToDecimal(hex2Float(MainForm.calliePoint[0]));
        public static decimal callieInfoPoint2 = Convert.ToDecimal(hex2Float(MainForm.calliePoint[1]));
        public static decimal callieInfoPoint3 = Convert.ToDecimal(hex2Float(MainForm.calliePoint[2]));

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
        public static decimal callieChairInfoPoint1 = Convert.ToDecimal(hex2Float(MainForm.calliePoint[0]));
        public static decimal callieChairInfoPoint2 = Convert.ToDecimal(hex2Float(MainForm.calliePoint[1]));
        public static decimal callieChairInfoPoint3 = Convert.ToDecimal(hex2Float(MainForm.calliePoint[2]));

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
        public static decimal marieInfoPoint1 = Convert.ToDecimal(hex2Float(MainForm.mariePoint[0]));
        public static decimal marieInfoPoint2 = Convert.ToDecimal(hex2Float(MainForm.mariePoint[1]));
        public static decimal marieInfoPoint3 = Convert.ToDecimal(hex2Float(MainForm.mariePoint[2]));

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
        public static decimal marieChairInfoPoint1 = Convert.ToDecimal(hex2Float(MainForm.mariePoint[0]));
        public static decimal marieChairInfoPoint2 = Convert.ToDecimal(hex2Float(MainForm.mariePoint[1]));
        public static decimal marieChairInfoPoint3 = Convert.ToDecimal(hex2Float(MainForm.mariePoint[2]));

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
        public static decimal juddInfoPoint1 = Convert.ToDecimal(hex2Float(MainForm.juddPoint[0]));
        public static decimal juddInfoPoint2 = Convert.ToDecimal(hex2Float(MainForm.juddPoint[1]));
        public static decimal juddInfoPoint3 = Convert.ToDecimal(hex2Float(MainForm.juddPoint[2]));

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
        public static decimal spykeInfoPoint1 = Convert.ToDecimal(hex2Float(MainForm.spykePoint[0]));
        public static decimal spykeInfoPoint2 = Convert.ToDecimal(hex2Float(MainForm.spykePoint[1]));
        public static decimal spykeInfoPoint3 = Convert.ToDecimal(hex2Float(MainForm.spykePoint[2]));

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
        public static decimal shellInfoPoint1 = Convert.ToDecimal(hex2Float(MainForm.shellPoint[0]));
        public static decimal shellInfoPoint2 = Convert.ToDecimal(hex2Float(MainForm.shellPoint[1]));
        public static decimal shellInfoPoint3 = Convert.ToDecimal(hex2Float(MainForm.shellPoint[2]));

        public static void shellInfoPoint(decimal x, decimal y, decimal z)
        {
            shellInfoPoint1 = x;
            shellInfoPoint2 = y;
            shellInfoPoint3 = z;
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
        public static decimal amiiboInfoPoint1 = Convert.ToDecimal(hex2Float(MainForm.amiiboPoint[0]));
        public static decimal amiiboInfoPoint2 = Convert.ToDecimal(hex2Float(MainForm.amiiboPoint[1]));
        public static decimal amiiboInfoPoint3 = Convert.ToDecimal(hex2Float(MainForm.amiiboPoint[2]));

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
        public static decimal balloonInfoPoint1 = Convert.ToDecimal(hex2Float(MainForm.balloonPoint[0]));
        public static decimal balloonInfoPoint2 = Convert.ToDecimal(hex2Float(MainForm.balloonPoint[1]));
        public static decimal balloonInfoPoint3 = Convert.ToDecimal(hex2Float(MainForm.balloonPoint[2]));

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
        public static decimal postInfoPoint1 = Convert.ToDecimal(hex2Float(MainForm.postPoint[0]));
        public static decimal postInfoPoint2 = Convert.ToDecimal(hex2Float(MainForm.postPoint[1]));
        public static decimal postInfoPoint3 = Convert.ToDecimal(hex2Float(MainForm.postPoint[2]));

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
        public static decimal tree1InfoPoint1 = Convert.ToDecimal(hex2Float(MainForm.treePoint[0]));
        public static decimal tree1InfoPoint2 = Convert.ToDecimal(hex2Float(MainForm.treePoint[1]));
        public static decimal tree1InfoPoint3 = Convert.ToDecimal(hex2Float(MainForm.treePoint[2]));

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
        public static decimal tree2InfoPoint1 = Convert.ToDecimal(hex2Float(MainForm.tree2Point[0]));
        public static decimal tree2InfoPoint2 = Convert.ToDecimal(hex2Float(MainForm.tree2Point[1]));
        public static decimal tree2InfoPoint3 = Convert.ToDecimal(hex2Float(MainForm.tree2Point[2]));

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
        public static decimal tree3InfoPoint1 = Convert.ToDecimal(hex2Float(MainForm.tree3Point[0]));
        public static decimal tree3InfoPoint2 = Convert.ToDecimal(hex2Float(MainForm.tree3Point[1]));
        public static decimal tree3InfoPoint3 = Convert.ToDecimal(hex2Float(MainForm.tree3Point[2]));

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
        public static decimal tree4InfoPoint1 = Convert.ToDecimal(hex2Float(MainForm.tree4Point[0]));
        public static decimal tree4InfoPoint2 = Convert.ToDecimal(hex2Float(MainForm.tree4Point[1]));
        public static decimal tree4InfoPoint3 = Convert.ToDecimal(hex2Float(MainForm.tree4Point[2]));

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
        public static decimal arcadeInfoPoint1 = Convert.ToDecimal(hex2Float(MainForm.arcadePoint[0]));
        public static decimal arcadeInfoPoint2 = Convert.ToDecimal(hex2Float(MainForm.arcadePoint[1]));
        public static decimal arcadeInfoPoint3 = Convert.ToDecimal(hex2Float(MainForm.arcadePoint[2]));

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
        public static decimal manholeInfoPoint1 = Convert.ToDecimal(hex2Float(MainForm.manholePoint[0]));
        public static decimal manholeInfoPoint2 = Convert.ToDecimal(hex2Float(MainForm.manholePoint[1]));
        public static decimal manholeInfoPoint3 = Convert.ToDecimal(hex2Float(MainForm.manholePoint[2]));

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
        public static decimal weaponsignInfoPoint1 = Convert.ToDecimal(hex2Float(MainForm.weaponsignPoint[0]));
        public static decimal weaponsignInfoPoint2 = Convert.ToDecimal(hex2Float(MainForm.weaponsignPoint[1]));
        public static decimal weaponsignInfoPoint3 = Convert.ToDecimal(hex2Float(MainForm.weaponsignPoint[2]));

        public static void weaponsignInfoPoint(decimal x, decimal y, decimal z)
        {
            weaponsignInfoPoint1 = x;
            weaponsignInfoPoint2 = y;
            weaponsignInfoPoint3 = z;
        }
    }
}
