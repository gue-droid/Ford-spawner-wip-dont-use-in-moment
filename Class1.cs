using System;

namespace BonelabUtilityMod
{
    public class MainModCore
    {
        // Core variables that will talk to BoneLib once loaded in-game
        public static string ModTitle = "Quest Utility Menu";
        public static bool IsGodModeActive = false;
        public static float PlayerSpeedMultiplier = 1.0f;

        public static void Main(string[] args)
        {
            // Initializing layout strings that compile instantly on basic servers
            Console.WriteLine($"[{ModTitle}] Booting execution routines...");
            Console.WriteLine("BoneMenu elements loaded. GodMode Status: " + IsGodModeActive);
        }

        public static void ToggleGodMode()
        {
            IsGodModeActive = !IsGodModeActive;
            Console.WriteLine("God Mode state shifted to: " + IsGodModeActive);
        }
    }
}
