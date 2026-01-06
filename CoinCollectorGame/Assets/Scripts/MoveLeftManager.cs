using UnityEngine;

public class MoveLeftManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += transform.right * -1 * Time.deltaTime;
        Destroy(gameObject, 15);
    }
}
