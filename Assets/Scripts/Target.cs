﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
    public void Destroy()
    {
        Destroy(gameObject, 0.2f);
    }
}
