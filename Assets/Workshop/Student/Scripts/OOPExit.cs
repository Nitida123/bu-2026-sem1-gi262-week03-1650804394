using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OOPExit : Identity
{
    [Header("UI Reference")]
    public GameObject winCanvas;

    public void ReachExit()
    {
        if (winCanvas != null)
        {
            winCanvas.SetActive(true);
        }
    }

}