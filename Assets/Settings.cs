using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public void ToggleSound(Toggle toggle)
    {
        AudioListener.pause = !toggle.isOn;
    }
}
