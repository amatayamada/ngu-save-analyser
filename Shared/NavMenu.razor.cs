﻿using Microsoft.AspNetCore.Components;

namespace NGUSaveAnalyser.Shared
{
    public class NavMenuBase: ComponentBase
    {
        [CascadingParameter] protected PlayerData playerdata { get; set; }

        protected bool SaveFileLoaded = false;
        protected bool ChallengesUnlocked = false;
        protected bool PitUnlocked = false;
        protected bool YggUnlocked = false;

        protected override void OnParametersSet()
        {
            if (playerdata != null)
            {
                SaveFileLoaded = true;
                YggUnlocked = playerdata.settings.yggdrasilOn;
                PitUnlocked = playerdata.settings.pitUnlocked;
                ChallengesUnlocked = playerdata.highestBoss >= 58;
            }
        }
    }
}
