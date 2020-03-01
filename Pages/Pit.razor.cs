using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NGUSaveAnalyser.Pages
{
    public class PitBase: ComponentBase
    {
        [Inject] NavigationManager NavigationManager { get; set; }
        [CascadingParameter] protected PlayerData playerdata { get; set; }
        protected double totalGold;
        protected int num;

        protected async override void OnInitialized()
        {
            if (playerdata == null)
            {
                await Task.Delay(2500);
                NavigationManager.NavigateTo("/");
            }
        }

        protected override void OnParametersSet()
        {
            if (playerdata != null)
            {
                totalGold = playerdata.pit.totalGold;
                UnityEngine.Random.state = playerdata.pit.pitState;
                num = UnityEngine.Random.Range(1, 6);
            }
        }
    }
}
