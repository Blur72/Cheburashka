using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;


public class Bounds : MonoBehaviour
{
    void Start()
    {

    }
    public Collider2D boundary;

    void Update()
    {
        if (boundary == null)
        {
            Debug.LogError("Boundary is not assigned!");
            return;
        }
        Vector3 clampedPosition = transform.position;

        clampedPosition.x = Mathf.Clamp(clampedPosition.x, boundary.bounds.min.x, boundary.bounds.max.x);
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, boundary.bounds.min.y, boundary.bounds.max.y);

        transform.position = clampedPosition;
    }
}
