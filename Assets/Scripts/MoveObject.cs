using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] Vector3 moveAmount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveTheObject()
    {
        gameObject.transform.Translate(moveAmount);
    }
    public void MoveTheObjectOppositeDirection()
    {
        gameObject.transform.Translate(-moveAmount);
    }
}
