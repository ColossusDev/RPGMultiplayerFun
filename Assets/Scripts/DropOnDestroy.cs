using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOnDestroy : MonoBehaviour
{

    [SerializeField] private List<GameObject> droppedItems = new List<GameObject>();

    void OnDestroy()
    {
        foreach (GameObject go in droppedItems)
        {
            Debug.Log("Destroyed");
            Vector2 rngForce = new Vector2(Random.Range(-1f,1f), Random.Range(0f,1f));
            GameObject spawned = Instantiate(go, this.gameObject.transform.position, Quaternion.identity) as GameObject;
            spawned.GetComponent<Rigidbody2D>().AddForce(rngForce);
            spawned.SetActive(true);
        }
    }

}
