using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ExampleData : MonoBehaviour
{
    public Transform CameraPosition;
    public Transform[] Targets;
    public Transform Marker;
    public MoverData Mover;
    public float power;
    public int currentTarget = 0;
    public bool active = false;

    public ExampleControllerParent controller;

    public void NextTarget() { SetTarget(currentTarget + 1); }
    public void PrevTarget() { SetTarget(currentTarget - 1); }
    public void SetTarget(int target) { 
        currentTarget = Mathf.Clamp(target, 0, Targets.Length - 1);
        Marker.position = Targets[currentTarget].position; 
    }
}
