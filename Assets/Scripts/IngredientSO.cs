using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ingredient", menuName = "Alchemy/Ingredient")]
public class IngredientSO : ScriptableObject
{
    public BaseEffect PrimaryEffect;
    public BaseEffect SecondaryEffect;
    public string Name;
}
