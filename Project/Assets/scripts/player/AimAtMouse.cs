﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used to aim the object at the mouse
public class AimAtMouse : AimAt 
{    
    protected override bool ShouldAim()
    {
        return true;
    }
     
    public override Vector2 getTarget()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }   
}
