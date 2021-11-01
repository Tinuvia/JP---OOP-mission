using UnityEngine;

public enum EffectType { Blue, Red, Yellow };
public enum EffectName { Magic, Health, Stamina };

[CreateAssetMenu(fileName = "New EffectColor", menuName = "Alchemy/Effect")]
public class EffectSO: ScriptableObject
{
    public EffectType effectColor;
    [SerializeField] ColorSO color;
    public EffectName effectName;
    public string affectedCharacterStats;
 }
