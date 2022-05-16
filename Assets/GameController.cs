using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public Camera cam;

    public TMP_Text ExampleText;
    public TMP_Text TargetText;

    public ExampleData[] Examples;
    public int currentExampleIndex = 0;

    public ExampleData currentExample {
        get { 
            return Examples[currentExampleIndex];
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        SetExample(0);
    }

    public void NextExample() { SetExample(currentExampleIndex + 1); }
    public void PrevExample() { SetExample(currentExampleIndex - 1); }

    public void SetExample (int example) {
        example = example % Examples.Length;

        currentExample.active = false;

        currentExampleIndex = example;

        currentExample.active = true;

        cam.transform.position = currentExample.CameraPosition.position;
        cam.transform.rotation = currentExample.CameraPosition.rotation;

        ExampleText.text = $"Example {example + 1}";
        UpdateTargetText();
    }

    public void NextTarget() { currentExample.NextTarget(); UpdateTargetText(); }
    public void PrevTarget() { currentExample.PrevTarget(); UpdateTargetText(); }

    void UpdateTargetText() {
        TargetText.text = $"Target {currentExample.currentTarget + 1}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
