﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlurRenderer : MonoBehaviour
{
    public Camera BlurCamera;
    public Material BlurMaterial;

    void Start()
    {
        if (BlurCamera.targetTexture != null)
        {
            BlurCamera.targetTexture.Release();
        }
        BlurCamera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24, RenderTextureFormat.ARGB32, 1);
        BlurMaterial.SetTexture("_RenTex", BlurCamera.targetTexture);
    }

}
