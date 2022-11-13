using UnityEngine;
using System.Linq;





public class StarInfo
{
    public int hygId;
    public int hipId;
    public float apparentManitude;
    public float absoluteMagnitude;
    public string properName;
    public Vector3 position;
    public Color color;
    public float colorIndex;
    public Vector3 velocity;
    public StarInfo(string csvLine)
    {
        var lines = csvLine.Split(',');

        hygId = ParseUtility.SafeIntParse(lines[0]);
        hipId = ParseUtility.SafeIntParse(lines[1]);
        apparentManitude = ParseUtility.SafeFloatParse(lines[13]);
        absoluteMagnitude = ParseUtility.SafeFloatParse(lines[14]);
        properName = lines[6];

        colorIndex = ParseUtility.SafeFloatParse(lines[16]);
        color = ColorUtility.ColorIndexToRGB(colorIndex);
        
        position = new Vector3(
            ParseUtility.SafeFloatParse(lines[17]),
            ParseUtility.SafeFloatParse(lines[18]),
            ParseUtility.SafeFloatParse(lines[19])
        );

        velocity = new Vector3(
            ParseUtility.SafeFloatParse(lines[20]),
            ParseUtility.SafeFloatParse(lines[21]),
            ParseUtility.SafeFloatParse(lines[22])
        );
        position = Vector3.ClampMagnitude(position, 1000);
    }
}