using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuQuality : MonoBehaviour
{
    public void SetHighQuality()
    {
        QualitySettings.SetQualityLevel(2);
    }

    public void SetMediumQuality()
    {
        QualitySettings.SetQualityLevel(1);
    }

    public void SetLowQuality()
    {
        QualitySettings.SetQualityLevel(0);
    }
}
