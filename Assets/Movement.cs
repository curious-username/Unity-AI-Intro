using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject _greenCube, _orangeCube;
    private Vector3 v1 = new Vector3 (5,6,7);
    private Vector3 v2 = new Vector3(1,2,3);
    private float _speed = 2.0f;
    private Transform goal;

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        VectorMath();
        
        
    }

    void VectorMath()
    {
        goal = _orangeCube.transform;
        Vector3 direction = goal.position - _greenCube.transform.position;
        Debug.Log(direction.magnitude);
        if (Input.GetKeyDown(KeyCode.A))
        {
            _greenCube.transform.Translate(direction.normalized * _speed * Time.deltaTime);
        }
            

        


    }
}
