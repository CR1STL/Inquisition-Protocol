using UnityEngine;
public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            GameObject.Find("Player").GetComponent<Player_1>().ScoreUpd();
        }

        if (other.tag == "Player")
        {
            Destroy(gameObject);
            other.gameObject.GetComponent<Player_1>().Damage();
        }
    }
}