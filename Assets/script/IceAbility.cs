using UnityEngine;

public class IceAbility : BaseAbility
{
    public override void Execute()
    {
        Shoot(5, StatusEffect.Burn, 3f);
        PlayFeedback();
    }
}
