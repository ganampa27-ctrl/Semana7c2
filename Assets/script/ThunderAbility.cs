using UnityEngine;

public class ThunderAbility : BaseAbility
{
    public override void Execute()
    {
        Shoot(2, StatusEffect.Burn, 3f);
        PlayFeedback();
    }
}
