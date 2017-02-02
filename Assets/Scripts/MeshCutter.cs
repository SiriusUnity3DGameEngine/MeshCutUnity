using UnityEngine;
using System.Collections;
using BLINDED_AM_ME;

public class MeshCutter : MonoBehaviour {
    public Material capMaterial;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            if(Physics.Raycast(transform.position,transform.forward,out hit))
            {
                GameObject[] pieces = MeshCut.Cut(hit.collider.gameObject, transform.position, transform.right, capMaterial);
                if (!pieces[1].GetComponent<Rigidbody>())
                {
                    pieces[1].AddComponent<Rigidbody>();
                }
                Destroy(pieces[1], 1);
            }
        }
	}
}
