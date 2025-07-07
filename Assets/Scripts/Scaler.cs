using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 one = new Vector3(1f, 1f, 1f);

    private void Update()
    {
        transform.localScale += one * _speed * Time.deltaTime;
    }
}
