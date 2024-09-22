using UnityEngine;
using UnityEngine.UI;
public class Energy : MonoBehaviour
{
    public float EnergyBar;
    public Image EnergyImage;
    private void Start()
    {
        EnergyBar = 1f;
    }
    private void Update()
    {
        EnergyImage.fillAmount = EnergyBar;
        if (Input.GetKey(KeyCode.Z))
        {
            if (EnergyBar >= 0)
            {
                EnergyBar -= 0.0005f;
            }
        }
        else
        {
            if (EnergyBar < 1)
            {
                EnergyBar += 0.002f;
                Time.timeScale = 1;
            }
        }
    }
}