using UnityEngine;

public class RollAndPitch : MonoBehaviour
{
    // Param�tres de roulis et tangage
    public float rollFrequency = 0.5f;
    public float rollAmplitude = 5f;
    public float pitchFrequency = 0.8f;
    public float pitchAmplitude = 5f;
    public float speed = 1f;

    // Variables de stockage de l'�tat de roulis et tangage
    private Quaternion startRotation;
    private float rollTime;
    private float pitchTime;

    void Start()
    {
        // Stocker la rotation initiale du bateau
        startRotation = transform.rotation;
    }

    void Update()
    {
        // Mettre � jour le temps de roulis et tangage
        rollTime += Time.deltaTime * speed;
        pitchTime += Time.deltaTime * speed;

        // Calculer l'angle de roulis en utilisant une fonction sinuso�dale
        float roll = Mathf.Sin(rollFrequency * rollTime) * rollAmplitude;

        // Calculer l'angle de tangage en utilisant une fonction sinuso�dale
        float pitch = Mathf.Sin(pitchFrequency * pitchTime) * pitchAmplitude;

        // Appliquer le roulis et le tangage � la rotation du bateau
        transform.rotation = startRotation * Quaternion.Euler(-pitch, 0f, roll);
    }
}
