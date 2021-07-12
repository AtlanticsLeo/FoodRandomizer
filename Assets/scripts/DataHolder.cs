using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHolder : MonoBehaviour
{
   public string food;
   public void AddFood()
   {
       Food newFood = new Food(food, "chinese", 1);
       Serializer.Save<Food>("food.txt", newFood);
   }

   public void ReadFood()
   {
        Food food = Serializer.Load<Food>("food.txt");
        Debug.Log(food);
   }
}
