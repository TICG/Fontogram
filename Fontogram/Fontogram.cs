﻿using System.Collections.Generic;
using System.Windows;

namespace PergleLabs.UI
{

    public partial class Fontogram
    {

        // For each type of ready-made Fontogram, must set each property as a '|'-separated list of layers,
        // each layer being a list of ';'-separated values of the component attributes.
        // Some attributes' values can be lists of ','-separated values.


        void Create__Fontogram_Logo(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {

            // " Text_L0 | ...(Layer1) | ...(Layer2) | ... "
            _Text = "🎞|A|A";

            // " TextFont_L0;TextFontWeight_L0;TextColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextAttr = ";;#999|Courier New;bold;#304f|Courier New;bold;#f01d";

            // " TextFontSize_L0;TextShiftX_L0;TextShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextPosRel = "100;26;7|70;-16.4;-0.6|70;-12;1";

            // " TextRotAngle_L0;TextScaleX_L0;TextScaleY_L0;TextSkewX_L0;TextSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextTransform = "-10;1;0.3;60;-20|-15.8;0.9;1.7;-18,17|-15.8;0.9;1.7;-18,17";

            // " BackOpacity_L0;BackFillColor_L0;BackStrokeColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackAttr = ";#7baa;#cbaa";

            // " BackWidth_L0;BackHeight_L0;BackShiftX_L0;BackShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackPosRel = "105;42;28;10";

            // " BackStrokeThickness_L0;BackCornerRadius_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackBorderNumbersRel = "1,0,0,1.5";

            // " BackRotAngle_L0;BackScaleX_L0;BackScaleY_L0;BackSkewX_L0;BackSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackTransform = "-10;1;0.3;60;-20";

        }

        void Create__Fontogram_LogoWide(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {

            // " Text_L0 | ...(Layer1) | ...(Layer2) | ... "
            _Text = "🎞|Abc|Abc";

            // " TextFont_L0;TextFontWeight_L0;TextColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextAttr = ";;#d999|Courier New;bold;#304f|Courier New;bold;#e04f";

            // " TextFontSize_L0;TextShiftX_L0;TextShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextPosRel = "100;58;-15|70;-16;-5|70;-13;-4";

            // " TextRotAngle_L0;TextScaleX_L0;TextScaleY_L0;TextSkewX_L0;TextSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextTransform = "-10;2;0.5;60;-20|-13.1;0.8;1.62;-8|-13.1;0.8;1.62;-8";

            // " BackOpacity_L0;BackFillColor_L0;BackStrokeColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackAttr = ";#6baa;#cbaa";

            // " BackWidth_L0;BackHeight_L0;BackShiftX_L0;BackShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackPosRel = "90;42;47;2";

            // " BackStrokeThickness_L0;BackCornerRadius_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackBorderNumbersRel = "0.5,0,0,0.7;8";

            // " BackRotAngle_L0;BackScaleX_L0;BackScaleY_L0;BackSkewX_L0;BackSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackTransform = "-10;2;0.5;60;-20";

        }

        void Create__DocState_Ready(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {

            // " Text_L0 | ...(Layer1) | ...(Layer2) | ... "
            _Text = " | ";

            // " TextFont_L0;TextFontWeight_L0;TextColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextAttr = " | ";

            // " TextFontSize_L0;TextShiftX_L0;TextShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextPosRel = " | ";

            // " TextRotAngle_L0;TextScaleX_L0;TextScaleY_L0;TextSkewX_L0;TextSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextTransform = " | ";

            // " BackOpacity_L0;BackFillColor_L0;BackStrokeColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackAttr = " | ";

            // " BackWidth_L0;BackHeight_L0;BackShiftX_L0;BackShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackPosRel = " | ";

            // " BackStrokeThickness_L0;BackCornerRadius_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackBorderNumbersRel = " | ";

            // " BackRotAngle_L0;BackScaleX_L0;BackScaleY_L0;BackSkewX_L0;BackSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackTransform = " | ";

        }

        void Create__DocState_Corrupt(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {

            // " Text_L0 | ...(Layer1) | ...(Layer2) | ... "
            _Text = " | ";

            // " TextFont_L0;TextFontWeight_L0;TextColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextAttr = " | ";

            // " TextFontSize_L0;TextShiftX_L0;TextShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextPosRel = " | ";

            // " TextRotAngle_L0;TextScaleX_L0;TextScaleY_L0;TextSkewX_L0;TextSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextTransform = " | ";

            // " BackOpacity_L0;BackFillColor_L0;BackStrokeColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackAttr = " | ";

            // " BackWidth_L0;BackHeight_L0;BackShiftX_L0;BackShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackPosRel = " | ";

            // " BackStrokeThickness_L0;BackCornerRadius_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackBorderNumbersRel = " | ";

            // " BackRotAngle_L0;BackScaleX_L0;BackScaleY_L0;BackSkewX_L0;BackSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackTransform = " | ";

        }

        void Create__DocState_Waiting(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {

            // " Text_L0 | ...(Layer1) | ...(Layer2) | ... "
            _Text = " | ";

            // " TextFont_L0;TextFontWeight_L0;TextColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextAttr = " | ";

            // " TextFontSize_L0;TextShiftX_L0;TextShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextPosRel = " | ";

            // " TextRotAngle_L0;TextScaleX_L0;TextScaleY_L0;TextSkewX_L0;TextSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextTransform = " | ";

            // " BackOpacity_L0;BackFillColor_L0;BackStrokeColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackAttr = " | ";

            // " BackWidth_L0;BackHeight_L0;BackShiftX_L0;BackShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackPosRel = " | ";

            // " BackStrokeThickness_L0;BackCornerRadius_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackBorderNumbersRel = " | ";

            // " BackRotAngle_L0;BackScaleX_L0;BackScaleY_L0;BackSkewX_L0;BackSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackTransform = " | ";

        }

        void Create__DocState_FolderNotFound(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {

            // " Text_L0 | ...(Layer1) | ...(Layer2) | ... "
            _Text = " | ";

            // " TextFont_L0;TextFontWeight_L0;TextColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextAttr = " | ";

            // " TextFontSize_L0;TextShiftX_L0;TextShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextPosRel = " | ";

            // " TextRotAngle_L0;TextScaleX_L0;TextScaleY_L0;TextSkewX_L0;TextSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextTransform = " | ";

            // " BackOpacity_L0;BackFillColor_L0;BackStrokeColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackAttr = " | ";

            // " BackWidth_L0;BackHeight_L0;BackShiftX_L0;BackShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackPosRel = " | ";

            // " BackStrokeThickness_L0;BackCornerRadius_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackBorderNumbersRel = " | ";

            // " BackRotAngle_L0;BackScaleX_L0;BackScaleY_L0;BackSkewX_L0;BackSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackTransform = " | ";

        }

        void Create__Sample_RgbSwirl(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {

            // " Text_L0 | ...(Layer1) | ...(Layer2) | ... "
            _Text = "G|R|B";

            // " TextFont_L0;TextFontWeight_L0;TextColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextAttr = "arial;bold;green|arial;bold;red|arial;bold;blue";

            // " TextFontSize_L0;TextShiftX_L0;TextShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextPosRel = "16;1;43|16;23;36.5|16;-20;38.5";

            // " TextRotAngle_L0;TextScaleX_L0;TextScaleY_L0;TextSkewX_L0;TextSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextTransform = "30|0|60";

            // " BackOpacity_L0;BackFillColor_L0;BackStrokeColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackAttr = ";#0f0;green|;#8f00;red|;#500f;blue";

            // " BackWidth_L0;BackHeight_L0;BackShiftX_L0;BackShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackPosRel = "60;60|60;60|60;60";

            // " BackStrokeThickness_L0;BackCornerRadius_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackBorderNumbersRel = "0.3,1.7,3.2,5;6|0.3,1.7,3.2,5;6|0.3,1.7,3.2,5;6";

            // " BackRotAngle_L0;BackScaleX_L0;BackScaleY_L0;BackSkewX_L0;BackSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackTransform = "30|0|60";

        }

        void Create__Sample_TopHatSmiley(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {

            // " Text_L0 | ...(Layer1) | ...(Layer2) | ... "
            _Text = " | ";

            // " TextFont_L0;TextFontWeight_L0;TextColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextAttr = " | ";

            // " TextFontSize_L0;TextShiftX_L0;TextShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextPosRel = " | ";

            // " TextRotAngle_L0;TextScaleX_L0;TextScaleY_L0;TextSkewX_L0;TextSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextTransform = " | ";

            // " BackOpacity_L0;BackFillColor_L0;BackStrokeColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackAttr = " | ";

            // " BackWidth_L0;BackHeight_L0;BackShiftX_L0;BackShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackPosRel = " | ";

            // " BackStrokeThickness_L0;BackCornerRadius_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackBorderNumbersRel = " | ";

            // " BackRotAngle_L0;BackScaleX_L0;BackScaleY_L0;BackSkewX_L0;BackSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackTransform = " | ";

        }
    }
}
