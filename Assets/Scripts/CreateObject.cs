using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    // THIS SCRIPT DOES NOT NEED FIXING!

    [SerializeField] GameObject objectPrefabToCreate;
    [SerializeField] Transform locationToCreateObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateNewObject()
    {
        Instantiate(objectPrefabToCreate, locationToCreateObject.position, locationToCreateObject.rotation);
    }
}
