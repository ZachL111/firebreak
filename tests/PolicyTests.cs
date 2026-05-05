using Firebreak;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(53, 85, 9, 14, 13);
        if (Policy.Score(signalcase_1) != 96) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "review") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(65, 99, 17, 22, 13);
        if (Policy.Score(signalcase_2) != 46) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "review") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(78, 86, 18, 16, 12);
        if (Policy.Score(signalcase_3) != 94) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "review") throw new Exception("decision mismatch");
    }
}
