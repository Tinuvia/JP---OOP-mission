using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Alchemy/Item")]
public class ItemSO : ScriptableObject
{
    [SerializeField] EffectSO[] Effects;
    [SerializeField] ColorSO color;
    [SerializeField] string Name;
    [SerializeField] string Description;
    [SerializeField] AudioClip PickupSound;
    [SerializeField] AudioClip DropSound;
    [SerializeField] GameObject ItemPrefab;

    ParticleSystem particleSystem; 

    // ENCAPSULATION add getters (and setters?) for the variables (Name, Description, Color)

    public virtual Color GetCloudColor()
    {
        // check the EffectSO list - if list.length > 1 (and not null)
        // (this is an ingredient) - get the color of both effects
        // compare the two to find out cloud color - switch?
        // else (this is a potion) return the color of the first in list 
        Color color = new Color(1f, 1f, 1f, 1f);
        return color;
    }

    public virtual string GetDescription()
    {
        return "";
    }

}
