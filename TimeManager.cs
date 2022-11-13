using UnityEngine;


public class TimeManager : MonoBehaviour
{
    [Range(-100000, 100000)]
    public float curentYear = 2022;

    public float yearPerSecond = 10;

    public bool autoUpdate;
    public bool reset;

    void Update()
    {
        if(autoUpdate)
        {
            curentYear += yearPerSecond *Time.deltaTime;
            SetJ2000Offset(curentYear);
        }
    }

    void OnValidate()
    {
        SetJ2000Offset(curentYear);
        if(reset)
        {
            reset = false;
            curentYear = 2000;
            SetJ2000Offset(curentYear);
        }
    }

    
    void SetJ2000Offset(float year)
    {
            Shader.SetGlobalFloat("J2000Offset", year - 2000);
    }
}