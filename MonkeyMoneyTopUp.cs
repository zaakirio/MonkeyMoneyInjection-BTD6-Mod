using MelonLoader;
using BTD_Mod_Helper;
using MonkeyMoneyTopUp;
using Il2CppAssets.Scripts.Unity;
using BTD_Mod_Helper.Extensions;

[assembly: MelonInfo(typeof(MonkeyMoneyTopUp.MonkeyMoneyTopUp), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace MonkeyMoneyTopUp;

public class MonkeyMoneyTopUp : BloonsTD6Mod
{
    public override void OnMainMenu()
    {
        ModHelper.Msg<MonkeyMoneyTopUp>("Checking Liquidity...");
        if (Game.instance.GetMonkeyMoney() < 999999)
        {
            Game.instance.SetMonkeyMoney(999999);
            ModHelper.Msg<MonkeyMoneyTopUp>("Liquidity Injected!");
        }
        else
        {
            ModHelper.Msg<MonkeyMoneyTopUp>("Sufficient Liquidity!");
        }
    }
}