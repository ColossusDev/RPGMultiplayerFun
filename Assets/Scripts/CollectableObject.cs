using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObject : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Collect Funktion am Player aufrufen und dieses Gameobjekt oder eine Componente davon �bergeben
            //
            //  <---- Here

            Destroy(this.gameObject);
        }
    }
}
