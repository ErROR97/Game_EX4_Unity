﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class crateBox : MonoBehaviour
{
    public RawImage[] arrayImage;

    void Start()
    {
        for (int i = 0; i < arrayImage.Length; i++) arrayImage[i].enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            for (int i = 0; i < arrayImage.Length; i++) arrayImage[i].enabled = true;
        
    }
}
