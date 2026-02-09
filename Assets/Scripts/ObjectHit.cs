using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        //Changes color of touched objects
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
