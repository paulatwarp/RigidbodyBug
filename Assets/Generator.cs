using System.Collections;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public Configure prefab;
    public float rate = 1f;

    private void Start()
    {
        StartCoroutine(Generate());
    }

    IEnumerator Generate()
    {
        while (true)
        {
            yield return new WaitForSeconds(rate);
            Configure configure = Instantiate<Configure>(prefab);
            configure.Init();
            yield return null;
        }
    }
}
