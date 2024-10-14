using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InGamePanel : MonoBehaviour
{
    [SerializeField] private TMP_Text Timer;

    private void LateUpdate()
    {
        Timer.text = DateTime.Now.ToString("HH:mm:ss");
    }
}
