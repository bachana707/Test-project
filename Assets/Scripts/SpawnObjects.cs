using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

    public Transform ciclePrefab;
    public Transform squarePrefab;
    public Transform leftPosition;
    public Transform RightPosition;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Cicle")
        {
            
                StartCoroutine(InstantiateObjects());
            
        }
    }
    IEnumerator InstantiateObjects()
    {
        yield return new WaitForSeconds(3);
        Instantiate(ciclePrefab, new Vector3(Random.Range(leftPosition.transform.position.x, RightPosition.transform.position.x), RightPosition.transform.position.y, 0), Quaternion.identity);

    }
}
