using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brewing : MonoBehaviour
{
    [SerializeField] ItemSO[] possiblePotions;
    public int numberOfTries;
    public List<DragObject> cookingList;

    private ItemSO[] addedItems;


    //particle system on cauldron instead of on items - just change the color and size based on item

    private void Start()
    {
       // GameEvents.current.onItemAdded += OnItemAdded;
    }

    private void OnItemAdded(DragObject addedItem)
    {
        Debug.Log("An item has been added to the cauldron.");
        // play drop sound, play particle cloud (function on ItemSO?)
        // disable object

        // if more than one ingredient has been added (if length.cookingList is > 0):
        // - check if the second is the same as the first 
        // --> return to startposition (need to get this, set a function in ItemSO to return to start?
        // - StartBrewing()

        // bool return true if ok to add
    }

    private void StartBrewing()
    {
        // start timer (or IEunmerator)
        // play boiling sound
        // CheckResults()
        // when timer ends, play cloud based on result
        // PlacePotion()
        // Clear cooking list
        numberOfTries++;
    }

    private ItemSO CheckResults(ItemSO firstItem, ItemSO secondItem)
    //takes two ingredients, compares their effects and execute methods
    {
        ItemSO item = firstItem; // get the correct version from list of possible potions

        // empty addedItems
        return item;
    }

    private void PlacePotion()
    {
        // decides if first of its kind, if so places on table else on shelf(unless shelf is full?)
        // use LeanTween to move slowly from cauldron to table?
    }

    private void Winning()
    {
        // check if all table slots are filled
        // play fanfare and confetti
        // show results and how many tries it took
    }
}
