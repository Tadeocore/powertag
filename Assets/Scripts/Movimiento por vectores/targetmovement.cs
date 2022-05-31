using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetmovement : MonoBehaviour
{
    [Range (0,20)]
    public float movementMultiplier;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * Time.deltaTime);
       
    }
}
