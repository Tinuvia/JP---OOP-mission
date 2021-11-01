using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE - Ingredients are a child class of ItemSO
public class IngredientSO : ItemSO
{
    public string description;
    public EffectSO primaryEffect;
    public EffectSO secondaryEffect;
}
