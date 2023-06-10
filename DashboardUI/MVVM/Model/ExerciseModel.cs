using System;

namespace DashboardUI.MVVM.Model;

public class ExerciseModel
{
    public string Title { get; set; }
    public string ExerciseName { get; set; }
    public int WorkoutTime { get; set; }
    public DateTime ExerciseDate { get; set; }

    public ExerciseModel(string title, string exerciseName, int workoutTime, DateTime exerciseDate)
    {
        Title = title;
        ExerciseName = exerciseName;
        WorkoutTime = workoutTime;
        ExerciseDate = exerciseDate;
    }
}