using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    private Renderer rd;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Red() {
        rd.material.color = Color.red;
    }

    public void Blue() {
        rd.material.color = Color.blue;
    }   
    
    public void Black() {
        rd.material.color = Color.black;
    }
}
