using UnityEngine;
using RotaryHeart.Lib.SerializableDictionary;
using UnityEngine.XR.ARFoundation;
using TMPro;
using UnityEngine.UI;

[System.Serializable]
public class colorPrefabDictionary : SerializableDictionaryBase<string, GameObject> { }

public class ImageTrackerTest : MonoBehaviour
{
    [SerializeField] colorPrefabDictionary colorPrefabs;

    [SerializeField] ARTrackedImageManager imageManager;


    private void OnEnable()

    {
    }

    void Update()
    {

        if (imageManager.trackables.count > 0)
        {
            foreach (ARTrackedImage image in imageManager.trackables)
            {
                InstantiateCube(image);
            }
        }

    }

    private void InstantiateCube(ARTrackedImage image)
    {
        string name = image.referenceImage.name.Split('-')[0];
        if (image.transform.childCount == 0)
        {
            // GameObject cube = Instantiate(colorPrefabs[name]);
            GameObject cube = Instantiate(colorPrefabs[checkInstance(name)]);
            Debug.Log(colorPrefabs[checkInstance(name)]);
            cube.transform.SetParent(image.transform, false);
        }
        else
        {
           // Debug.Log($"{name} already instantiated");
        }
       // Debug.Log(checkInstance(name));
    }

    private string checkInstance(string toCheck)
    {
        string checker = LogicEngine.checkDictionary(toCheck);
        Debug.Log(checker);
        switch(checker)
        {
            case "Unsolved":
                return toCheck + "Unsolved";
            case "Solved":
                return toCheck;
            default:
                return toCheck + "Unsolved";
        }
        
    }

}
