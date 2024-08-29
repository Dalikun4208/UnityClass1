using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] Texture2D texture2D;
    [SerializeField] RaycastHit RaycastHit;
    [SerializeField] LayerMask layerMask;
    // Start is called beforethe first frame update
    void Start()
    {
        Cursor.SetCursor(texture2D, new Vector2(0, 0), CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit, Mathf.Infinity, layerMask))
            {
                IInterractable interractable = RaycastHit.collider.GetComponent<IInterractable>();

                if(interractable != null)
                {
                    interractable.Interact();
                }

            }
        }
    }
    private void OnDrawGizmos()
    {
        Debug.DrawRay(ray.origin, ray.direction, Color.red, 0.5f);
    }
}
