using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnClick : MonoBehaviour
{
    private Renderer objectRenderer;
  
   

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    
    void OnMouseDown()  // OnMouseDown() is triggered when the object is clicked.
    {
        objectRenderer.material.color = Random.ColorHSV();  // Changes to a random color on click/ //Random.ColorHSV() generates a random color each time.   
    }
}
