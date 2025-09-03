using UnityEngine;

public class RayPoint : MonoBehaviour
{
    private Collider2D hit;
    private Vector2 mousePos;
    private GameObject selectobject;
    private bool mvobj = false;

    void Update()
    {
        MouseClick();
        
    }

    void FixedUpdate()
    {
        MoveObject();
    }

    void MouseClick()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Vector2 direction = Vector2.zero;

        // Ray ray = Camera.main.ScreenPointToRay(mousePos);


        // RaycastHit2D hit = Physics2D.Raycast(mousePos, direction);

        // if (hit.collider != null)
        // {
        //     Debug.Log("Hit object: " + hit.collider.name);
        // }

        // hit = Physics2D.OverlapPoint(mousePos);

        // if (hit != null)
        // {
        //     // Debug.Log("Hit object: " + hit.name);
        //     if (Input.GetMouseButtonDown(0) && mvobj == false)
        //     {
        //         Debug.Log("Clicked on object: " + hit.name);
        //         mvobj = true;
        //     }
        //     else if (Input.GetMouseButtonDown(0) && mvobj == true)
        //     {
        //         mvobj = false;
        //     }
        // }

        if (Input.GetMouseButtonDown(0))
        {
            hit = Physics2D.OverlapPoint(mousePos);

            if (hit != null)
            {
                selectobject = hit.gameObject;// hit.gameobject 참조
                mvobj = !mvobj;
            }
            else
            {
                selectobject = null;
                mvobj = false;
            }
        }
    }
    void MoveObject()
    {
        if (mvobj && selectobject != null)
        {
            selectobject.transform.position = mousePos;
            //hit.gameobject.transform.position의 값도 변경된다

        }
    }
}
