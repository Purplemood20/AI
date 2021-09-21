using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPoint : MonoBehaviour
{
    [Range(0.1f ,10f)]
    public float radius = 1f;
    // Start is called before the first frame update
   
    public Vector3 GivePoint()
    {
        Vector3 point = Random.insideUnitCircle* radius;  // trouver un point dans une sph�re � un rayon un du centre * radius pour avoir le rayon, ad�quat
        point.z = point.y;
        point.y = 0;

        point += transform.position;
        return point;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
