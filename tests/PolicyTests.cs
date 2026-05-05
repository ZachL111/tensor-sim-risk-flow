using TensorSimRiskFlow;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(92, 77, 27, 14, 4);
        if (Policy.Score(signalcase_1) != 122) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "review") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(68, 107, 9, 24, 12);
        if (Policy.Score(signalcase_2) != 132) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "review") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(94, 89, 8, 23, 6);
        if (Policy.Score(signalcase_3) != 156) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "review") throw new Exception("decision mismatch");
    }
}
