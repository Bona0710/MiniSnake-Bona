using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    [SerializeField]
    float xLimit = 16.0f;
    [SerializeField]
    float yLimit = 8.5f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-xLimit, xLimit),
        Random.Range(-yLimit, yLimit), 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.transform.parent.GetComponent<MiniSnake>().AddTail();

            transform.position = new Vector3(Random.Range(-xLimit, xLimit),
        Random.Range(-yLimit, yLimit), 0);
        }
    }
}
