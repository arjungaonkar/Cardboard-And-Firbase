using Firebase.Extensions;
using Firebase.Firestore;
using System.Collections.Generic;
using UnityEngine;

public class FirebaseTest : MonoBehaviour
{
    void Start()
    {
        DocumentReference docRef = FirebaseFirestore.DefaultInstance.Collection("cities").Document("LA");
        Dictionary<string, object> city = new Dictionary<string, object>
        {
                { "Name", "Los Angeles" },
                { "State", "CA" },
                { "Country", "USA" }
        };
        docRef.SetAsync(city).ContinueWithOnMainThread(task =>
        {
            Debug.Log("Added data to the LA document in the cities collection.");
        });
    }
}
