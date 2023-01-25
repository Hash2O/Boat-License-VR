using UnityEngine;

public class WaveMovement : MonoBehaviour
{
    // Paramètres de la houle
    public float waveFrequency = 0.5f;
    public float waveHeight = 0.1f;
    public float waveSpeed = 1f;

    // Variables de stockage de l'état de la houle
    private Vector3 startPos;
    private float waveTime;

    void Start()
    {
        // Stocker la position initiale du bateau
        startPos = transform.position;
    }

    void Update()
    {
        // Mettre à jour le temps de la houle
        waveTime += Time.deltaTime * waveSpeed;

        // Calculer la hauteur de la houle en utilisant une fonction sinusoïdale
        float yPos = Mathf.Sin(waveFrequency * waveTime) * waveHeight;

        // Appliquer le mouvement de la houle à la position du bateau
        transform.position = startPos + new Vector3(0f, yPos, 0f);
    }
}
