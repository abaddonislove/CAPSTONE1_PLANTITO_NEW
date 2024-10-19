using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantObjectDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        BoxCollider2D boxCollider = GetComponent<BoxCollider2D>();

        if (spriteRenderer != null && boxCollider != null)
        {
            // Set the BoxCollider2D size to match the sprite's size
            boxCollider.size = spriteRenderer.sprite.bounds.size;
            boxCollider.offset = spriteRenderer.sprite.bounds.center;
        }
    }

    private void Update()
    {

        if (this.GetComponent<PlantObject>().PlantObjectData.currentStage == PlantStage.Young)
        {
            this.GetComponent<SpriteRenderer>().sprite = this.GetComponent<PlantObject>().PlantObjectData.plant.PlantSprite[1];
        }

        if (this.GetComponent<PlantObject>().PlantObjectData.currentStage == PlantStage.Adult)
        {
            this.GetComponent<SpriteRenderer>().sprite = this.GetComponent<PlantObject>().PlantObjectData.plant.PlantSprite[2];
        }
    }
}
