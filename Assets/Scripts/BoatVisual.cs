using UnityEngine;

public class BoatVisual : MonoBehaviour
{

    BoatAutoPilot autoPilot;

    private void Awake()
    {
        autoPilot = GetComponentInParent<BoatAutoPilot>(); //Je récupère la ref au boatAutopilot
        transform.localScale = autoPilot.Data.scale;
    }
}
