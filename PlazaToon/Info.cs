using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlazaToon
{
    class Info
    {
        //RESET
        public static void resetti()
        {
            callieInfoSize(1, 1, 1, 1, 1);
            callieChairInfoSize(1, 1, 1, 1, 1);
            marieInfoSize(1, 1, 1, 1, 1);
            marieChairInfoSize(1, 1, 1, 1, 1);
            juddInfoSize(1, 1, 1);
            spykeInfoSize(1, 1, 1, 1, 1);
            treeInfoSize(1, 1, 1);

            callieMasterScale(1);
            callieChairMasterScale(1);
            marieMasterScale(1);
            marieChairMasterScale(1);
            juddMasterScale(1);
            spykeMasterScale(1);
            treeMasterScale(1);
            arcadeMasterScale(1);
            manholeMasterScale(1);

            callieInfoPoint(Convert.ToDecimal(MainForm.hex2Float(MainForm.calliePoint[0])), Convert.ToDecimal(MainForm.hex2Float(MainForm.calliePoint[1])),Convert.ToDecimal(MainForm.hex2Float(MainForm.calliePoint[2])));
            callieChairInfoPoint(Convert.ToDecimal(MainForm.hex2Float(MainForm.calliePoint[0])), Convert.ToDecimal(MainForm.hex2Float(MainForm.calliePoint[1])), Convert.ToDecimal(MainForm.hex2Float(MainForm.calliePoint[2])));
            marieInfoPoint(Convert.ToDecimal(MainForm.hex2Float(MainForm.mariePoint[0])), Convert.ToDecimal(MainForm.hex2Float(MainForm.mariePoint[1])), Convert.ToDecimal(MainForm.hex2Float(MainForm.mariePoint[2])));
            marieChairInfoPoint(Convert.ToDecimal(MainForm.hex2Float(MainForm.mariePoint[0])), Convert.ToDecimal(MainForm.hex2Float(MainForm.mariePoint[1])), Convert.ToDecimal(MainForm.hex2Float(MainForm.mariePoint[2])));
            juddInfoPoint(Convert.ToDecimal(MainForm.hex2Float(MainForm.juddPoint[0])), Convert.ToDecimal(MainForm.hex2Float(MainForm.juddPoint[1])), Convert.ToDecimal(MainForm.hex2Float(MainForm.juddPoint[2])));
            spykeInfoPoint(Convert.ToDecimal(MainForm.hex2Float(MainForm.spykePoint[0])), Convert.ToDecimal(MainForm.hex2Float(MainForm.spykePoint[1])), Convert.ToDecimal(MainForm.hex2Float(MainForm.spykePoint[2])));
            treeInfoPoint(Convert.ToDecimal(MainForm.hex2Float(MainForm.treePoint[0])), Convert.ToDecimal(MainForm.hex2Float(MainForm.treePoint[1])), Convert.ToDecimal(MainForm.hex2Float(MainForm.treePoint[2])));
            arcadeInfoPoint(Convert.ToDecimal(MainForm.hex2Float(MainForm.arcadePoint[0])), Convert.ToDecimal(MainForm.hex2Float(MainForm.arcadePoint[1])), Convert.ToDecimal(MainForm.hex2Float(MainForm.arcadePoint[2])));
            manholeInfoPoint(Convert.ToDecimal(MainForm.hex2Float(MainForm.manholePoint[0])), Convert.ToDecimal(MainForm.hex2Float(MainForm.manholePoint[1])), Convert.ToDecimal(MainForm.hex2Float(MainForm.manholePoint[2])));
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
        public static decimal callieInfoPoint1 = Convert.ToDecimal(MainForm.hex2Float(MainForm.calliePoint[0]));
        public static decimal callieInfoPoint2 = Convert.ToDecimal(MainForm.hex2Float(MainForm.calliePoint[1]));
        public static decimal callieInfoPoint3 = Convert.ToDecimal(MainForm.hex2Float(MainForm.calliePoint[2]));

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
        public static decimal callieChairInfoPoint1 = Convert.ToDecimal(MainForm.hex2Float(MainForm.calliePoint[0]));
        public static decimal callieChairInfoPoint2 = Convert.ToDecimal(MainForm.hex2Float(MainForm.calliePoint[1]));
        public static decimal callieChairInfoPoint3 = Convert.ToDecimal(MainForm.hex2Float(MainForm.calliePoint[2]));

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
        public static decimal marieInfoPoint1 = Convert.ToDecimal(MainForm.hex2Float(MainForm.mariePoint[0]));
        public static decimal marieInfoPoint2 = Convert.ToDecimal(MainForm.hex2Float(MainForm.mariePoint[1]));
        public static decimal marieInfoPoint3 = Convert.ToDecimal(MainForm.hex2Float(MainForm.mariePoint[2]));

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
        public static decimal marieChairInfoPoint1 = Convert.ToDecimal(MainForm.hex2Float(MainForm.mariePoint[0]));
        public static decimal marieChairInfoPoint2 = Convert.ToDecimal(MainForm.hex2Float(MainForm.mariePoint[1]));
        public static decimal marieChairInfoPoint3 = Convert.ToDecimal(MainForm.hex2Float(MainForm.mariePoint[2]));

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
        public static decimal juddInfoPoint1 = Convert.ToDecimal(MainForm.hex2Float(MainForm.juddPoint[0]));
        public static decimal juddInfoPoint2 = Convert.ToDecimal(MainForm.hex2Float(MainForm.juddPoint[1]));
        public static decimal juddInfoPoint3 = Convert.ToDecimal(MainForm.hex2Float(MainForm.juddPoint[2]));

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
        public static decimal spykeInfoPoint1 = Convert.ToDecimal(MainForm.hex2Float(MainForm.spykePoint[0]));
        public static decimal spykeInfoPoint2 = Convert.ToDecimal(MainForm.hex2Float(MainForm.spykePoint[1]));
        public static decimal spykeInfoPoint3 = Convert.ToDecimal(MainForm.hex2Float(MainForm.spykePoint[2]));

        public static void spykeInfoPoint(decimal x, decimal y, decimal z)
        {
            spykeInfoPoint1 = x;
            spykeInfoPoint2 = y;
            spykeInfoPoint3 = z;
        }
        //Tree
        public static decimal treeInfoSize1 = 1;
        public static decimal treeInfoSize2 = 1;
        public static decimal treeInfoSize3 = 1;
        public static decimal treeInfoSizeMaster = 1;

        public static void treeInfoSize(decimal x, decimal y, decimal z)
        {
            treeInfoSize1 = x;
            treeInfoSize2 = y;
            treeInfoSize3 = z;
        }
        public static void treeMasterScale(decimal master)
        {
            treeInfoSizeMaster = master;
        }
        public static decimal treeInfoPoint1 = Convert.ToDecimal(MainForm.hex2Float(MainForm.treePoint[0]));
        public static decimal treeInfoPoint2 = Convert.ToDecimal(MainForm.hex2Float(MainForm.treePoint[1]));
        public static decimal treeInfoPoint3 = Convert.ToDecimal(MainForm.hex2Float(MainForm.treePoint[2]));

        public static void treeInfoPoint(decimal x, decimal y, decimal z)
        {
            treeInfoPoint1 = x;
            treeInfoPoint2 = y;
            treeInfoPoint3 = z;
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
        public static decimal arcadeInfoPoint1 = Convert.ToDecimal(MainForm.hex2Float(MainForm.arcadePoint[0]));
        public static decimal arcadeInfoPoint2 = Convert.ToDecimal(MainForm.hex2Float(MainForm.arcadePoint[1]));
        public static decimal arcadeInfoPoint3 = Convert.ToDecimal(MainForm.hex2Float(MainForm.arcadePoint[2]));

        public static void arcadeInfoPoint(decimal x, decimal y, decimal z)
        {
            arcadeInfoPoint1 = x;
            arcadeInfoPoint2 = y;
            arcadeInfoPoint3 = z;
        }
        public static decimal manholeInfoSize1 = 1;
        public static decimal manholeInfoSize2 = 1;
        public static decimal manholeInfoSize3 = 1;
        public static decimal manholeInfoSizeMaster = 1;
        //Manhole
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
        public static decimal manholeInfoPoint1 = Convert.ToDecimal(MainForm.hex2Float(MainForm.manholePoint[0]));
        public static decimal manholeInfoPoint2 = Convert.ToDecimal(MainForm.hex2Float(MainForm.manholePoint[1]));
        public static decimal manholeInfoPoint3 = Convert.ToDecimal(MainForm.hex2Float(MainForm.manholePoint[2]));

        public static void manholeInfoPoint(decimal x, decimal y, decimal z)
        {
            manholeInfoPoint1 = x;
            manholeInfoPoint2 = y;
            manholeInfoPoint3 = z;
        }
    }
}
