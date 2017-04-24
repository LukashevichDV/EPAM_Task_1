namespace Task_1.Interfaces
{
    public interface ISweetStuff
    {

        string Name { get; }
        int Weight { get; }
        int Sugar { get; }
        double Caloriety { get; }

        double GetPrice();



    }
}
