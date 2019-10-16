﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PergleLabs.UI
{

    public enum ReadyMadeFontogram
    {
        Test1,
        Test2,
        Sample_Logo,
        Sample_LogoWide,
        Sample_RgbSwirl
    }


    public class Fontogram
        : FontogramBase<ReadyMadeFontogram>
    {

        protected override void CreateBuiltin(ReadyMadeFontogram value)
        {
            switch (value)
            {
                case ReadyMadeFontogram.Test1:
                    AddLayers_Test1();
                    break;
                case ReadyMadeFontogram.Test2:
                    AddLayers_Test2();
                    break;
                case ReadyMadeFontogram.Sample_Logo:
                    AddLayers_Logo();  // 
                    break;
                default:
                    AddLayers_Default();
                    break;
            }
        }



        void AddLayers_Logo()
        {
            AddInternalLayer(
                    "0,0,0,0"
                    );
        }

        void AddLayers_Default()
        {

            AddInternalLayer(
                    "0,0,0,0"
                    );

        }

        void AddLayers_Test1()
        {

            AddInternalLayer(
                    "0,0,0,0"
                    );

            AddInternalLayer(
                    "0,0,0,0"
                    );

            AddInternalLayer(
                    "0,0,0,0"
                    );

            AddInternalLayer(
                    "0,0,0,0"
                    );
        }

        void AddLayers_Test2()
        {

            AddInternalLayer(
                    "0,0,0,0"
                    );

            AddInternalLayer(
                    "0,0,0,0"
                    );

            AddInternalLayer(
                    "0,0,0,0"
                    );

            AddInternalLayer(
                    "0,0,0,0"
                    );
        }

    }

}
