using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsColleted : MonoBehaviour
{
    private int totalBananasCount;
    private int bananasCount = 0;
    public ObjectFinal chestObject;

    private void Start()
    {
        GameObject[] bananas = GameObject.FindGameObjectsWithTag("Banana");

        totalBananasCount = bananas.Length;
        Debug.Log(totalBananasCount);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            bananasCount = bananasCount + 1;
            Destroy(gameObject, 0.5f);
            if (bananasCount == totalBananasCount)
            {
                // Aquí puedes agregar el código para mostrar el cofre
                Debug.Log(bananasCount);
                chestObject.transform.GetChild(0).gameObject.SetActive(true);
            }
        }

    }
}
