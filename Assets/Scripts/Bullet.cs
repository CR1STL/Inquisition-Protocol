using UnityEngine;
public class Bullet : MonoBehaviour
{
    [SerializeField] public float _speed;
    private void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * _speed);
    }
}