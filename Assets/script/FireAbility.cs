using NUnit.Framework.Internal;
using UnityEngine;
public class FireAbility : BaseAbility
{
    public override void Execute()
    {
        Shoot(6, StatusEffect.Burn, 3f);
        PlayFeedback();
    }
}