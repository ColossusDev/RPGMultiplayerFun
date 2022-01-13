using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Collect Funktion am Player aufrufen und dieses Gameobjekt oder eine Componente davon übergeben
            //
            //  <---- Here

            Destroy(this.gameObject);
        }
    }
}
