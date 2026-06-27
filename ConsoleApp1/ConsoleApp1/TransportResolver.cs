namespace TransportChallenge;

public static class TransportResolver
{
    public static Vehicle? Resolve(string input)
    {
        return input.ToLower() switch
        {
            "car" => new Car(),
            "boat" => new Boat(),
            "plane" => new Airplane(),
            "helicopter" => new Helicopter(),
            _ => null
        };
    }
}