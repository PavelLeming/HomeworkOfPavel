using UnityEngine;

public class Rotationer : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(_speed * Vector3.up * Time.deltaTime);
    }
}
