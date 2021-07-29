using UnityEngine;

public enum EffectColor { Blue, Red, Yellow };
public enum EffectName { Magic, Health, Stamina };

[CreateAssetMenu(fileName = "New EffectColor", menuName = "Alchemy/Effect")]
public class EffectSO: ScriptableObject
{
    public EffectColor effectColor;
    public EffectName effectName;
    public string affectedCharacterStats;
 }
