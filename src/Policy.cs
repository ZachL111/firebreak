namespace Firebreak;

public readonly record struct Signal(int Demand, int Capacity, int Latency, int Risk, int Weight);

public static class Policy
{
    private const int Threshold = 171;
    private const int RiskPenalty = 7;
    private const int LatencyPenalty = 4;
    private const int WeightBonus = 3;

    public static int Score(Signal signal) =>
        signal.Demand * 2 + signal.Capacity + signal.Weight * WeightBonus
        - signal.Latency * LatencyPenalty - signal.Risk * RiskPenalty;

    public static string Classify(Signal signal) => Score(signal) >= Threshold ? "accept" : "review";
}
