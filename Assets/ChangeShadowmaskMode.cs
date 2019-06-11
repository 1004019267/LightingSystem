using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShadowmaskMode : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (QualitySettings.shadowmaskMode==ShadowmaskMode.Shadowmask)
        {
            QualitySettings.shadowmaskMode = ShadowmaskMode.DistanceShadowmask;
        }
        else
        {
            QualitySettings.shadowmaskMode = ShadowmaskMode.Shadowmask;
        }
    }
}
