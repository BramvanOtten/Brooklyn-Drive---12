using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreTekst;
    private int score = 20; // De huidige score

    private void Start()
    {
        UpdateScoreTekst(); // Initialiseer de score display
    }

    // Wanneer je de score wilt verhogen 
    public void scoreVerhogen(int amount)
    {
        score += amount; // Verhoogt de score bij een bepaald hoeveelheid
        UpdateScoreTekst(); // Update de score display
    }

    // Dit is nodig voor de score display, het is een update
    private void UpdateScoreTekst()
    {
        if (scoreTekst != null)
        {
            scoreTekst.text = "Score: " + score.ToString(); // De tekst updaten met de nieuwe score
        }
    }

    // Als de player een object met de tag Crash aanraakt, 2 minpunten
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Crash"))
        {
            scoreVerlagen(2); // Hoeveelheid van de score verminderen, kan aangepast worden
        }
    }

    // Deze method moet je callen wanneer je de score wilt verlagen
    private void scoreVerlagen(int amount)
    {
        score -= amount; // Verlaag de score bij een specifiek hoeveelheid
        UpdateScoreTekst(); // Update score display
    }
}