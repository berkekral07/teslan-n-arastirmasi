
using UnityEngine;

public class RoketDonme : MonoBehaviour
{
    public float donmeHizi = 100f;

    void Update()
    {
        transform.Rotate(0f, donmeHizi * Time.deltaTime, 0f);
    }
}
