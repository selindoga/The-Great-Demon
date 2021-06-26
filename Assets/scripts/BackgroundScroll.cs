using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    float scrollingSpeed = 0.15f;
    private MeshRenderer meshRenderer;
    private float offsetY;
    private Vector2 offset;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void FixedUpdate()
    {
        offsetY = Time.time * scrollingSpeed;
        offset = new Vector2(0, offsetY);
        meshRenderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
