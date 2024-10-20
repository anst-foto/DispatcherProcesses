using System.Collections.ObjectModel;
using System.Diagnostics;

namespace DispatcherProcesses;

public class MainWindowModel : BaseWindowModel
{
    public ObservableCollection<Process> Processes { get; private set; } = [];

    public LambdaCommand RefreshCommand { get; }
    
    
    public MainWindowModel()
    {
        RefreshCommand = new LambdaCommand(execute: (_) =>
        {
            RefreshProcesses(Processes, Process.GetProcesses());
        });
    }

    private void RefreshProcesses(ObservableCollection<Process> processes, Process[] processesArray)
    {
        processes.Clear();
        foreach (var process in processesArray)
        {
            processes.Add(process);
        }
    }
}