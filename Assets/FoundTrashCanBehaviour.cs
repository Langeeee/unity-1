using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoundTrashCanBehaviour : MonoBehaviour
{
    public float detectObjectRadius = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var nearCols = Physics.OverlapSphere(transform.position, detectObjectRadius);
        foreach (Collider col in nearCols)
        {
            if (col.gameObject.tag == "Trash")
            {
                var trashRenderer = col.gameObject.GetComponent<Renderer>();
                trashRenderer.material.SetColor("_Color", Color.green);
            }
        }
    }
}