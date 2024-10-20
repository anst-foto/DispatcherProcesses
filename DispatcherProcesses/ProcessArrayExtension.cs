using System.Collections.ObjectModel;
using System.Diagnostics;

namespace DispatcherProcesses;

public static class ProcessArrayExtension
{
    public static ObservableCollection<Process> ToObservableCollection(this Process[] processes)
    {
        var observableCollection = new ObservableCollection<Process>();
        foreach (var process in processes)
        {
            observableCollection.Add(process);
        }
        return observableCollection;
    }
}