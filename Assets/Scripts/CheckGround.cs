using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround: MonoBehaviour
{
    public static bool isGround;
    // Start is called before the first frame update
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        isGround = true;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        isGround=false;
    }
}
