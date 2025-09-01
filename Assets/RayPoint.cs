using UnityEngine;

public class RayPoint : MonoBehaviour
{
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = Vector2.zero;

        // Ray ray = Camera.main.ScreenPointToRay(mousePos);


        RaycastHit2D hit = Physics2D.Raycast(mousePos, direction);

        if (hit.collider != null)
        {
            Debug.Log("Hit object: " + hit.collider.name);
        }
    }
}
