using System;

namespace Survey.Domain
{
    [Flags]
    public enum SurveyStatus
    {
        New = 1,
        Edit = 2,
        Open = 4,
        Closed = 8
    }
}