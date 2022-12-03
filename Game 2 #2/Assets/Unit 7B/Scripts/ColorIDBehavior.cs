using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorIDBehavior : IDContainerBehavior
{
    public ColorIDDataList colorIDDataListobj;

    private void Awake()
    {
        idObj = colorIDDataListobj.currentColor;
    }
}
