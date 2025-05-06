using UnityEngine;
using UnityEngine.UI;
using TMPro; 



public class GameOverScreen : MonoBehaviour
{
public TMP_Text pointsText;   
public void setup(int score)
   {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " Points";
   }
}
