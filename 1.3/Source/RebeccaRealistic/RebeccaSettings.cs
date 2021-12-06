﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;

namespace RR
{
    public class RebeccaSettings : ModSettings
    {
        public static float BaseBonusThreatBigChance = 10;
        public static float BonusThreatBigChancePerWealthChance = .01f;
        public static float BonusThreatBigChancePerWealthThreshold = 10000;
        public static float VisitorChance = .15f;
        public static float VisitorIsOrbitalChance = .46f;
        public static float MTBUnit = 40000;
        public static float MTBCheckDuration = 1000;
        public static bool LoggingEnabled = false;

        public override void ExposeData()
        {
            Scribe_Values.Look(ref BaseBonusThreatBigChance, "BaseBonusRaidChance");
            Scribe_Values.Look(ref BonusThreatBigChancePerWealthChance, "BonusThreatBigChancePerWealthChance");
            Scribe_Values.Look(ref BonusThreatBigChancePerWealthThreshold, "BonusThreatBigChancePerWealthThreshold");
            Scribe_Values.Look(ref VisitorChance, "VisitorChance");
            Scribe_Values.Look(ref VisitorIsOrbitalChance, "VisitorIsOrbitalChance");
            Scribe_Values.Look(ref MTBUnit, "MTBUnit");
            Scribe_Values.Look(ref MTBCheckDuration, "MTBCheckDuration");
            Scribe_Values.Look(ref LoggingEnabled, "LoggingEnabled");
            base.ExposeData();
        }
    }
}