﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFacingBillboard : MonoBehaviour {
    private Transform mainCameraTransform;
    void Start()
    {
        mainCameraTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    private void Update()
    {
        transform.LookAt(mainCameraTransform);
    }
}
