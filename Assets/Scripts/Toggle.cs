﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour {

    public GameObject ui;

    public void G_Toggle()
    {
        ui.SetActive(!ui.activeSelf);

        if (ui.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
