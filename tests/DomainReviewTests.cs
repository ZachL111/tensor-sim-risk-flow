using TensorSimRiskFlow;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(45, 54, 8, 71);
        if (DomainReviewLens.Score(item) != 191) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "ship") throw new Exception("domain lane mismatch");
    }
}
