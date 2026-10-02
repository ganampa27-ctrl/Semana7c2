using UnityEngine;

public class PosisonAbility : BaseAbility
{
    public override void Execute()
    {
        Shoot(11, StatusEffect.Burn, 5f);
        PlayFeedback();
    }
}
