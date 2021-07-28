using System.Collections;
using System.Collections.Generic;

public enum EffectColor
{
    Blue,
    Red,
    Yellow
}

public enum EffectSize
{
    big,
    small
}

public class BaseEffect
{
    public EffectColor EffectColor;
    public EffectSize EffectSize;
}
