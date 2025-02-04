using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation; // include xr library

public class imageTracker : MonoBehaviour
{
 [SerializeField]
ARTrackedImageManager m_TrackedImageManager;

public GameObject shipPrefab; //Prefab you want to appear on marker image

void OnEnable() => m_TrackedImageManager.trackedImagesChanged += OnChanged;

void OnDisable() => m_TrackedImageManager.trackedImagesChanged -= OnChanged;

void OnChanged(ARTrackedImagesChangedEventArgs eventArgs)
{
    foreach (var newImage in eventArgs.added)
    {
        // Handle added event
        GameObject newObject = GameObject.Instantiate(shipPrefab);
        	// parent prefab to the newImage so that they stick together.
			newObject.transform.SetParent(newImage.transform, false);
    }

    foreach (var updatedImage in eventArgs.updated)
    {
        // Handle updated event
    }

    foreach (var removedImage in eventArgs.removed)
    {
        // Handle removed event
    }
}
}
