﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    void Update()
    {
        //if (slider.value == 0)
        //{
        //    Destroy(this.gameObject);
        //}
    }

    public void SetMaxHealth(int health)
    {
      slider.maxValue = health;
      slider.value = health;
    }

    public void SetHealth(int health)
    {
      slider.value = health;
    }
}
