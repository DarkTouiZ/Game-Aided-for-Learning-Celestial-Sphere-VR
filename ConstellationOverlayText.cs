using UnityEngine;
using UnityEngine.UI;




public class ConstellationOverlayText
{

    public Text text;
    public ConstellationInfo constellationInfo;

    public void SetConstellation(ConstellationInfo _info)
    {
        constellationInfo = _info;
        text.text = constellationInfo.name;
    }

    void Update()
    {
        if(ConstellationInfo != null)
            UpdateTextPosition();
    }

    void UpdateTextPosition()
    {
        var canvasSize = text.canvas.GetComponent<RectTransform>().sizeDelta;
        vector3 viewPortPos = Camera.main.WorldToViewportPoint(constellationInfo.position);
        vector2 screenPos = viewPortPos * canvasSize;
        text.RectTransform.anchorePosition = screenPos;
        text.GameObject.SetActive(viewPortPos.z > 0);
    }
}

    
