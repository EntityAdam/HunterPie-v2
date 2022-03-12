﻿using System.Runtime.InteropServices;

namespace HunterPie.Core.Game.Rise.Definitions
{
    [StructLayout(LayoutKind.Explicit)]
    public struct MHRSubmarineStructure
    {
        [FieldOffset(0x28)]
        public int Item;

        [FieldOffset(0x2C)]
        public int BargainSkill;
        
        [FieldOffset(0x30)]
        public int DaysLeft;

        [FieldOffset(0x40)]
        public int ItemArrayPtr;
    }
}