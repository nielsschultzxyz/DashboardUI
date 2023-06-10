using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;
using System.Windows.Controls;
using DashboardUI.MVVM.Model;

namespace DashboardUI.MVVM.ViewModel;

public class DashboardViewModel : Core.ViewModel
{
    // ListView Collection
    private ObservableCollection<ExerciseModel> _workoutCollection;

    public ObservableCollection<ExerciseModel> WorkoutCollection
    {
        get => _workoutCollection;
        set
        {
            _workoutCollection = value;
            OnPropertyChanged();
        }
    }
    
    // LiveCharts
    public SeriesCollection SeriesCollection { get; set; }
    public SeriesCollection BarcharCollecion { get; set; }
    public string[] Labels { get; set; }
    public string[] BarChartLabels { get; set; }
    public Func<double, string> YFormatter { get; set; }
    public Func<double, string> Formatter { get; set; }
    
    // ctor
    public DashboardViewModel()
    {
        WorkoutCollection = new ObservableCollection<ExerciseModel>()
        {
            new ExerciseModel("Running", "Morning run with the dogo", 30, DateTime.Now),
            new ExerciseModel("Bike", "Daily drive work", 20, DateTime.Now),
            new ExerciseModel("Running", "Dogo run", 30, DateTime.Now),
            new ExerciseModel("Placeholder", "get stuff done", 20, DateTime.Now),
            new ExerciseModel("Steps", "Walking", 40, DateTime.Now)
        };
        
        SeriesCollection = new SeriesCollection
        {
            new LineSeries
            {
                Title = "Bike",
                Values = new ChartValues<double> { 4, 6, 5, 2 ,4 }
            },
            new LineSeries
            {
                Title = "Running",
                Values = new ChartValues<double> { 6, 7, 3, 4 ,6 },
                PointGeometry = null
            },
            new LineSeries
            {
                Title = "Steps",
                Values = new ChartValues<double> { 4,2,7,2,7 },
                PointGeometry = DefaultGeometries.Square,
                PointGeometrySize = 15
            }
        };
 
        Labels = new[] {"Jan", "Feb", "Mar", "Apr", "May"};
        //YFormatter = value => value.ToString("C");
 
        //modifying the series collection will animate and update the chart
        SeriesCollection.Add(new LineSeries
        {
            Title = "Placeholder",
            Values = new ChartValues<double> {5, 3, 2, 4},
            LineSmoothness = 0, //0: straight lines, 1: really smooth lines
            PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
            PointGeometrySize = 50,
            PointForeground = Brushes.Gray
        });
 
        //modifying any series values will also animate and update the chart
        SeriesCollection[3].Values.Add(5d);

        BarcharCollecion = new SeriesCollection
        {
            new ColumnSeries
            {
                Title = "2015",
                Values = new ChartValues<double> { 10, 50, 39, 50 },
                //Fill = Brushes.LightGray,
                MaxColumnWidth = 30
            }
        };
 
        //adding series will update and animate the chart automatically
        BarcharCollecion.Add(new ColumnSeries
        {
            Title = "2016",
            Values = new ChartValues<double> { 11, 56, 42 },
            //Fill = Brushes.LightCoral,
            MaxColumnWidth = 30
        });
 
        //also adding values updates and animates the chart automatically
        BarcharCollecion[1].Values.Add(48d);
 
        BarChartLabels = new[] {"Bike", "Running", "Steps", "Placeholder"};
        //Formatter = value => value.ToString("N");
    }
}