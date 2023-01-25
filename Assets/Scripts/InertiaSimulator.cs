using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InertiaSimulator : MonoBehaviour
{
    public float deceleration; // D�termine combien de temps il faut pour que le bateau s'arr�te compl�tement.
    public float waterResistance; // D�termine la r�sistance de l'eau qui s'applique au bateau.
    public Vector3 windDirection; // La direction du vent.
    public float windForce; // La force du vent.
    public Rigidbody rb; // Le composant Rigidbody du bateau.
    //public MetaQuest2_Input leftController; // L'objet qui contient les informations de la manette gauche
    //public MetaQuest2_Input rightController; // L'objet qui contient les informations de la manette droite

    void Update()
    {
        // Si l'utilisateur rel�che les g�chettes des manettes
        //if (leftController.GetAxis("Trigger") < 0.1f && rightController.GetAxis("Trigger") < 0.1f)
        {
            // Applique une force de freinage pour simuler l'inertie.
            rb.AddForce(-rb.velocity * deceleration, ForceMode.Acceleration);
            // Applique une force de r�sistance de l'eau pour simuler l'effet de la r�sistance de l'eau.
            rb.AddForce(-rb.velocity.normalized * waterResistance, ForceMode.Acceleration);
            // Applique une force de vent pour simuler l'effet de la vitesse du vent.
            rb.AddForce(windDirection.normalized * windForce, ForceMode.Acceleration);
            // Applique une force de giration pour simuler l'effet de la giration du bateau.
            rb.AddTorque(transform.up * rb.velocity.magnitude, ForceMode.Acceleration);
        }
    }
}
