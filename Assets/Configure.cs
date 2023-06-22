using UnityEngine;

public class Configure : MonoBehaviour
{
    public void Init()
    {
        Rigidbody body = gameObject.AddComponent<Rigidbody>();
        gameObject.SetActive(true);
        if (float.IsNaN(body.position.x))
        {
            Debug.Log("NaN!");
        }
        transform.localScale = Vector3.one;
        Destroy(gameObject, 1.0f);
    }
}
