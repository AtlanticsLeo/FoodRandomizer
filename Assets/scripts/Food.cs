using System;


[Serializable]
public class Food
{
    string foodName, type;
    int price;

    public Food(string foodName, string type, int price)
    {
        this.foodName = foodName;
        this.type = type;
        this.price = price;
    }

    public string getName()
    {
        return foodName;
    }

    public string getType()
    {
        return type;
    }

    public int getPrice()
    {
        return price;
    }

    public void setName(string foodName)
    {
        this.foodName = foodName;
    }

    public void setType(string type)
    {
        this.type = type;
    }

    public void setPrice(int price)
    {
        this.price = price;
    }

}
