using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantObjectDisplay : MonoBehaviour
{
    [SerializeField]
    private GameObject PlantCanvasUI;

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

        // prevents weird stacking
        AdjustZPosition();
    }

    private void AdjustZPosition()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.y + 5.0f);
        this.PlantCanvasUI.transform.GetComponent<RectTransform>().position = new Vector3(0.0f,0.0f, this.transform.position.z);
    }
}
