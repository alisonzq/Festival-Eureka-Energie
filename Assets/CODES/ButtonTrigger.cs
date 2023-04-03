using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    [SerializeField]
    private Transform boxPrefab;
    [SerializeField]
    private Transform spawnPoint;
    public GameObject trash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Button"))
        {
            Transform t = Instantiate(boxPrefab);
            t.position = spawnPoint.position;
            trash.SetActive (false);

        }
    }
}
