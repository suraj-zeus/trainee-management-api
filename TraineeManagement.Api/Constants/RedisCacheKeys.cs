

namespace TraineeManagement.Api.Constants;

public static class RedisCacheKeys
{
    public static string Trainee(int id)
    {
        return $"trainee:{id}";
    }

    public static string Mentor(int id)
    {
        return $"mentor:{id}";
    }

    public static string TaskAssignment(int id)
    {
        return $"task-assignment:{id}";
    }

    public static string Submission(int id)
    {
        return $"submission:{id}";
    }

    public static string SubmissionSummary(int id)
    {
        return $"submission-summary:{id}";
    }
}