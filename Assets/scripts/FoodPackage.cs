using System.Collections.Generic;

public class FoodPackage
{
    public void Awake()
    {
        FoodPackage foodPackage = Serializer.Load<FoodPackage>("foodPackage.txt");
        IDictionary<string, Food> foodList = new Dictionary<string, Food>();
    }
    
}
