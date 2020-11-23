using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    public int countCubes;
    // Start is called before the first frame update
    void Start()
    {
        countCubes = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void recolect() {
        countCubes++;
        Destroy(gameObject);
    }
}
