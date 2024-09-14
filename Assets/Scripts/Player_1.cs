using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Player_1 : MonoBehaviour
{
    [SerializeField] public float _speed = 5f;
    [SerializeField] public int HP = 3;
    [SerializeField] private int Score = 0;
    [SerializeField] public TMP_Text HP_Text;
    [SerializeField] public TMP_Text ScoreText;
    private Vector3 pos;
    private void Update()
    {
        HP_Text.text = "HP: " + HP;
        ScoreText.text = "SCORE: " + Score.ToString();
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        pos = new Vector3(Horizontal, Vertical);
        transform.Translate(pos.normalized * Time.deltaTime * _speed);
    }
    public void ScoreUpd()
    {
        Score += 1;
    }
    public void Damage()
    {
        HP -= 1;
        if (HP < 1)
        {
            SceneManager.LoadScene(0);
        }
    }
}