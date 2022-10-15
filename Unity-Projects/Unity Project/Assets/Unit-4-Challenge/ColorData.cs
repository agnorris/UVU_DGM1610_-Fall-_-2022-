using UnityEngine;

[CreateAssetMenu]
public class ColorData : ScriptableObject
{
    public byte red;
    public byte green;
    public byte blue;

    public void RotateColor()
    {
        red += 3;
        green += 1;
        blue += 2;
    }
}
