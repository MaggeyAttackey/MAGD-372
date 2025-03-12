
using UnityEngine;

public class LerpRotataion : MonoBehaviour
{

    Vector3 relativePosition;
    Quaternion targetRotation;

    public Transform target;
    public float speed = 0.01f;

    bool rotating = false;

    float rotationTime;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
        relativePosition = target.position - transform.position;
        targetRotation = Quaternion.LookRotation(relativePosition);
        rotating = true;
        rotationTime = 0;
        }

        if(rotating == true ){
            rotationTime += Time.deltaTime * speed;
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationTime );
        }

        if(rotationTime > 1)
        {
            rotating = false;
        }

        
    }
}
