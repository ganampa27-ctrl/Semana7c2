using UnityEngine;

public class SlowAbility : BaseAbility
{
    public override void Execute()
    {
        Shoot(15, StatusEffect.Burn, 4f);
        PlayFeedback();
    }
}
