using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class controlLight : MonoBehaviour
{    
    public List<Light> light1;
    public List<Light> light2;
    public List<Light> light3;
    public List<Light> light4;
    public List<Light> light5;
    public List<Light> light6;
    public List<Light> light7;
    public List<Light> lightC;
    public List<Light> lightL;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Keypad0)){ 
            foreach (var L in light1)
            {
                L.enabled = !L.enabled;
            }
        }
        
        else if(Input.GetKeyDown(KeyCode.Keypad1)){ //line1 without LED
            foreach (var L in light1)
            {
                L.enabled = !L.enabled;
            }
        }

        else if(Input.GetKeyDown(KeyCode.Keypad2)){ //line2
            foreach (var L in light2)
            {
                L.enabled = !L.enabled;
            }
        }

        else if(Input.GetKeyDown(KeyCode.Keypad3)){ //line3 without LED
            foreach (var L in light3)
            {
                L.enabled = !L.enabled;
            }
        }

        else if(Input.GetKeyDown(KeyCode.Keypad4)){ //line4
            foreach (var L in light4)
            {
                L.enabled = !L.enabled;
            }
        }

        else if(Input.GetKeyDown(KeyCode.Keypad5)){ //line5
            foreach (var L in light5)
            {
                L.enabled = !L.enabled;
            }
        }

        else if(Input.GetKeyDown(KeyCode.Keypad6)){ //line6
            foreach (var L in light6)
            {
                L.enabled = !L.enabled;
            }
        }

        else if(Input.GetKeyDown(KeyCode.Keypad7)){ //line7
            foreach (var L in light7)
            {
                L.enabled = !L.enabled;
            }
        }

        else if(Input.GetKeyDown(KeyCode.Keypad8)){ //lineL
            foreach (var L in lightL)
            {
                L.enabled = !L.enabled;
            }
        }

        else if(Input.GetKeyDown(KeyCode.Keypad9)){ //lineC
            foreach (var L in lightC)
            {
                L.enabled = !L.enabled;
            }
        }
        
    }
}
