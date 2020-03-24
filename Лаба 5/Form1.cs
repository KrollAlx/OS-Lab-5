using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Лаба_5
{
    public partial class Form1 : Form
    {
        private const int NUMBER_DEFAULT_COLUMNS = 7;
        private enum State { NotInSystem, InProgress, Waiting};
        private readonly Random random = new Random();      
        private class Process
        {
            public List<State> States { get; set; }
            public int UsedQuanta { get; set; }
            public string Name { get; set; }
            public static int Count { get; set; }
            public int AppearanceTime { get; set; }
            public int NumberQuanta { get; set; }
            public double P { get; set; }
            public double R { get; set; }
            public int M { get; set; }
            public int T { get; set; }
            public Process(Random random)
            {
                States = new List<State>();
                AppearanceTime = random.Next(1,10);
                NumberQuanta = 1;
                UsedQuanta = 0;
                T = 0;
                Count++;
                Name = "Процесс " + Convert.ToString(Count);
            }      
            public bool IsCompleted()
            {
                return NumberQuanta == UsedQuanta;
            }
            public void CalculateParameters()
            {
                M = T - NumberQuanta;
                R = Math.Round((double)NumberQuanta / (double)T, 2);
                P = Math.Round((double)T / (double)NumberQuanta, 2);
            }
            public static void CalculateMeanValues(Process[] processesArray, ref double meanTotalSystemTime,
              ref double meanLostTime, ref double meanReactivityRatio, ref double meanPenaltyRatio)
            {
                foreach(var process in processesArray)
                {
                    meanTotalSystemTime += process.T;
                    meanLostTime += process.M;
                    meanReactivityRatio += process.R;
                    meanPenaltyRatio += process.P;
                }
                meanTotalSystemTime = Math.Round(meanTotalSystemTime / (double)processesArray.Length, 2);
                meanLostTime = Math.Round(meanLostTime / (double)processesArray.Length, 2);
                meanReactivityRatio = Math.Round(meanReactivityRatio / (double)processesArray.Length, 2);
                meanPenaltyRatio = Math.Round(meanPenaltyRatio / (double)processesArray.Length, 2);
            }
        }
        private Queue<Process> processesQueueFCFS;
        private Process[] processesArray;
        private string[] processesNames;
        private Queue<Process> MFQ_queue_0;
        private Queue<Process> MFQ_queue_1;
        private Queue<Process> MFQ_queue_2;
        private Queue<Process> MFQ_queue_3;
        private List<Process> processesInSystem;
        private List<Process> processesInProgress;
        private int Q;
        public Form1()
        {
            InitializeComponent();
        }
        private void OKButtonFCFS_Click(object sender, EventArgs e)
        {
            InitProcesses((int)NumberProcessesFCFS.Value);      
            processesQueueFCFS = new Queue<Process>((int)NumberProcessesFCFS.Value);
            ProcessesListBoxFCFS.Items.Clear();
            ProcessesListBoxFCFS.Items.AddRange(processesNames);
        }
        private void SetRestriction(string processName,int restrictionValue)
        {
            foreach(var process in processesArray)
            {
                if (process.Name == processName)
                {
                    process.NumberQuanta = random.Next(1, restrictionValue);
                }
            }
        }
        private void ProcessesListBoxFCFS_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetRestriction(((ListBox)sender).SelectedItem.ToString(), (int)RestrictionFCFS.Value);
        }
        private Process GetBornProcess(int time, Queue<Process> queue)
        {
            foreach(var process in processesArray)
            {
                if (process.AppearanceTime == time && !queue.Contains(process))
                {
                    return process;
                }
            }
            return null;
        }
        private void AddStatesFCFS(int time)
        {
            foreach(var process in processesArray)
            {
                if (process.AppearanceTime > time || (process.AppearanceTime < time && !processesQueueFCFS.Contains(process)))
                {
                    process.States.Add(State.NotInSystem);
                }
                else if (process == processesQueueFCFS.Peek())
                {
                    process.States.Add(State.InProgress);
                }
                else
                {
                    process.States.Add(State.Waiting);
                }
            }
        }
        private void StartFCFSButton_Click(object sender, EventArgs e)
        {
            ClearDataGridViewFCFS();
            int countCompletedProcesses = 0;
            int currentTime = 0;
            Process currentProcess;
            while (countCompletedProcesses != processesArray.Length)
            {
                currentTime++;
                var newProcess = GetBornProcess(currentTime, processesQueueFCFS);
                while (newProcess != null)
                {
                    processesQueueFCFS.Enqueue(newProcess);
                    newProcess = GetBornProcess(currentTime, processesQueueFCFS);
                }
                AddStatesFCFS(currentTime);
                foreach (var process in processesQueueFCFS)
                {
                    process.T++;
                }
                if (processesQueueFCFS.Count != 0) 
                {
                    currentProcess = processesQueueFCFS.Peek();
                    currentProcess.UsedQuanta++;
                    if (currentProcess.IsCompleted())
                    {
                        processesQueueFCFS.Dequeue();
                        countCompletedProcesses++;
                    }
                }                                        
            }
            AddReultsInDataGridViewFCFS();
            AddMeanValuesFCFS();
        }
        private void ClearDataGridViewFCFS()
        {
            DataGridViewFCFS.Rows.Clear();
            int columsCount = DataGridViewFCFS.Columns.Count - 1;
            for (int i = columsCount; i >= NUMBER_DEFAULT_COLUMNS; --i) 
            {
                DataGridViewFCFS.Columns.RemoveAt(i);
            }
        }
        private void ClearDataGridViewMFQ()
        {
            DataGridViewMFQ.Rows.Clear();
            int columsCount = DataGridViewMFQ.Columns.Count - 1;
            for (int i = columsCount; i >= NUMBER_DEFAULT_COLUMNS; --i)
            {
                DataGridViewMFQ.Columns.RemoveAt(i);
            }
        }
        private void AddReultsInDataGridViewFCFS()
        {
            for (int i = 0; i < processesArray.Length; ++i)
            {
                processesArray[i].CalculateParameters();
                DataGridViewFCFS.Rows.Add();
                DataGridViewFCFS.Rows[i].Cells[0].Value = processesArray[i].Name;
                DataGridViewFCFS.Rows[i].Cells[1].Value = processesArray[i].NumberQuanta;
                DataGridViewFCFS.Rows[i].Cells[2].Value = processesArray[i].AppearanceTime;
                DataGridViewFCFS.Rows[i].Cells[3].Value = processesArray[i].T;
                DataGridViewFCFS.Rows[i].Cells[4].Value = processesArray[i].M;
                DataGridViewFCFS.Rows[i].Cells[5].Value = processesArray[i].R;
                DataGridViewFCFS.Rows[i].Cells[6].Value = processesArray[i].P;
            }
            for (int i = 0; i < processesArray[0].States.Count; ++i)
            {
                DataGridViewFCFS.Columns.Add("Quant " + Convert.ToString(i + 1), Convert.ToString(i + 1));
                DataGridViewFCFS.Columns[NUMBER_DEFAULT_COLUMNS + i].Width = 20;
            }
            for (int i = 0; i < processesArray.Length; ++i)
            {
                for (int j = 0; j < processesArray[i].States.Count; ++j)
                {
                    if (processesArray[i].States[j] == State.InProgress)
                    {
                        DataGridViewFCFS.Rows[i].Cells[NUMBER_DEFAULT_COLUMNS + j].Style.BackColor = Color.Green;
                    }
                    else if (processesArray[i].States[j] == State.NotInSystem)
                    {
                        DataGridViewFCFS.Rows[i].Cells[NUMBER_DEFAULT_COLUMNS + j].Style.BackColor = Color.Gray;
                    }
                    else
                    {
                        DataGridViewFCFS.Rows[i].Cells[NUMBER_DEFAULT_COLUMNS + j].Style.BackColor = Color.Yellow;
                    }
                }
            }
        }
        private void AddReultsInDataGridViewMFQ()
        {
            for (int i = 0; i < processesArray.Length; ++i)
            {
                processesArray[i].CalculateParameters();
                DataGridViewMFQ.Rows.Add();
                DataGridViewMFQ.Rows[i].Cells[0].Value = processesArray[i].Name;
                DataGridViewMFQ.Rows[i].Cells[1].Value = processesArray[i].NumberQuanta;
                DataGridViewMFQ.Rows[i].Cells[2].Value = processesArray[i].AppearanceTime;
                DataGridViewMFQ.Rows[i].Cells[3].Value = processesArray[i].T;
                DataGridViewMFQ.Rows[i].Cells[4].Value = processesArray[i].M;
                DataGridViewMFQ.Rows[i].Cells[5].Value = processesArray[i].R;
                DataGridViewMFQ.Rows[i].Cells[6].Value = processesArray[i].P;
            }
            for (int i = 0; i < processesArray[0].States.Count; ++i)
            {
                DataGridViewMFQ.Columns.Add("Quant " + Convert.ToString(i + 1), Convert.ToString(i + 1));
                DataGridViewMFQ.Columns[NUMBER_DEFAULT_COLUMNS + i].Width = 20;
            }
            for (int i = 0; i < processesArray.Length; ++i)
            {
                for (int j = 0; j < processesArray[i].States.Count; ++j)
                {
                    if (processesArray[i].States[j] == State.InProgress)
                    {
                        DataGridViewMFQ.Rows[i].Cells[NUMBER_DEFAULT_COLUMNS + j].Style.BackColor = Color.Green;
                    }
                    else if (processesArray[i].States[j] == State.NotInSystem)
                    {
                        DataGridViewMFQ.Rows[i].Cells[NUMBER_DEFAULT_COLUMNS + j].Style.BackColor = Color.Gray;
                    }
                    else
                    {
                        DataGridViewMFQ.Rows[i].Cells[NUMBER_DEFAULT_COLUMNS + j].Style.BackColor = Color.Yellow;
                    }
                }
            }
        }
        private void AddMeanValuesFCFS()
        {
            double meanTotalSystemTime = 0.0;
            double meanLostTime = 0.0;
            double meanReactivityRatio = 0.0;
            double meanPenaltyRatio = 0.0;
            Process.CalculateMeanValues(processesArray, ref meanTotalSystemTime, ref meanLostTime, ref meanReactivityRatio, ref meanPenaltyRatio);
            MeanTotalSystemTimeFCFS.Text = "Общее время пребывания процесса в системе: " + Convert.ToString(meanTotalSystemTime);
            MeanLostTimeFCFS.Text = "Потерянное время: " + Convert.ToString(meanLostTime);
            MeanReactivityRatioFCFS.Text = "Отношение реактивности: " + Convert.ToString(meanReactivityRatio);
            MeanPenaltyRatioFCFS.Text = "Штрафное отношение: " + Convert.ToString(meanPenaltyRatio);
        }
        private void AddMeanValuesMFQ()
        {
            double meanTotalSystemTime = 0.0;
            double meanLostTime = 0.0;
            double meanReactivityRatio = 0.0;
            double meanPenaltyRatio = 0.0;
            Process.CalculateMeanValues(processesArray, ref meanTotalSystemTime, ref meanLostTime, ref meanReactivityRatio, ref meanPenaltyRatio);
            MeanTotalSystemTimeMFQ.Text = "Общее время пребывания процесса в системе: " + Convert.ToString(meanTotalSystemTime);
            MeanLostTimeMFQ.Text = "Потерянное время: " + Convert.ToString(meanLostTime);
            MeanReactivityRatioMFQ.Text = "Отношение реактивности: " + Convert.ToString(meanReactivityRatio);
            MeanPenaltyRatioMFQ.Text = "Штрафное отношение: " + Convert.ToString(meanPenaltyRatio);
        }
        private void InitProcesses(int numberProcesses)
        {
            Process.Count = 0;
            int NumberProcesses = numberProcesses;
            processesArray = new Process[NumberProcesses];
            processesNames = new string[NumberProcesses];
            for (int i = 0; i < processesArray.Length; ++i)
            {
                processesArray[i] = new Process(random);
            }
            for (int i = 0; i < processesNames.Length; ++i)
            {
                processesNames[i] = processesArray[i].Name;
            }
        }
        private void OKButtonMFQ_Click(object sender, EventArgs e)
        {
            InitProcesses((int)NumberProcessesMFQ.Value);
            Q = (int)NumberQuanta_Q.Value;
            MFQ_queue_0 = new Queue<Process>();
            MFQ_queue_1 = new Queue<Process>();
            MFQ_queue_2 = new Queue<Process>();
            MFQ_queue_3 = new Queue<Process>();
            ProcessesListBoxMFQ.Items.Clear();
            ProcessesListBoxMFQ.Items.AddRange(processesNames);
        }
        private void ProcessesListBoxMFQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetRestriction(((ListBox)sender).SelectedItem.ToString(), (int)RestrictionMFQ.Value);
        }
        private void StartMFQButton_Click(object sender, EventArgs e)
        {
            ClearDataGridViewMFQ();
            int countCompletedProcesses = 0;
            int currentTime = 0;
            Process currentProcess;
            processesInSystem = new List<Process>();
            processesInProgress = new List<Process>();
            while (countCompletedProcesses != processesArray.Length)
            {
                currentTime++;
                var newProcess = GetBornProcess(currentTime, MFQ_queue_0);
                while (newProcess != null)
                {
                    MFQ_queue_0.Enqueue(newProcess);
                    processesInSystem.Add(newProcess);
                    newProcess = GetBornProcess(currentTime, MFQ_queue_0);
                }
                if (MFQ_queue_0.Count != 0)
                {
                    while (MFQ_queue_0.Count != 0)
                    {
                        ExecuteProcess(ref MFQ_queue_0, ref MFQ_queue_1, ref countCompletedProcesses, ref currentTime, ref processesInSystem, Q);
                    }                   
                }
                if (MFQ_queue_1.Count != 0) 
                {
                    while(MFQ_queue_1.Count != 0 && MFQ_queue_0.Count == 0)
                    {
                        ExecuteProcess(ref MFQ_queue_1, ref MFQ_queue_2, ref countCompletedProcesses, ref currentTime, ref processesInSystem, 2 * Q);
                    }                    
                }
                if (MFQ_queue_2.Count != 0) 
                {
                    while(MFQ_queue_2.Count != 0 && MFQ_queue_0.Count == 0 && MFQ_queue_1.Count == 0)
                    {
                        ExecuteProcess(ref MFQ_queue_2, ref MFQ_queue_3, ref countCompletedProcesses, ref currentTime, ref processesInSystem, 4 * Q);
                    }              
                }
                if(MFQ_queue_3.Count != 0)
                {
                    while(MFQ_queue_3.Count != 0 && MFQ_queue_2.Count == 0 && MFQ_queue_0.Count == 0 && MFQ_queue_1.Count == 0)
                    {
                        bool interrupt = false;
                        currentProcess = MFQ_queue_3.Peek();
                        processesInProgress.Add(currentProcess);
                        while (!currentProcess.IsCompleted())
                        {
                            currentProcess.UsedQuanta++;
                            foreach (var process in processesInSystem)
                            {
                                process.T++;                            
                            }
                            AddStatesMFQ();
                            currentTime++;
                            newProcess = GetBornProcess(currentTime, MFQ_queue_0);
                            while (newProcess != null)
                            {
                                MFQ_queue_0.Enqueue(newProcess);
                                processesInSystem.Add(newProcess);
                                interrupt = true;
                                newProcess = GetBornProcess(currentTime, MFQ_queue_0);
                            }                            
                            if (interrupt)
                            {
                                break;
                            }
                        }
                        if (!interrupt)
                        {
                            MFQ_queue_3.Dequeue();
                            processesInProgress.Remove(currentProcess);
                            countCompletedProcesses++;
                            processesInSystem.Remove(currentProcess);
                        }                       
                    }              
                }
                if (MFQ_queue_0.Count == 0 && MFQ_queue_1.Count == 0 && MFQ_queue_2.Count == 0 && MFQ_queue_3.Count == 0) 
                {
                    AddStatesMFQ();
                    foreach (var process in processesInSystem)
                    {
                        process.T++;
                    }
                }                           
            }
            AddReultsInDataGridViewMFQ();
            AddMeanValuesMFQ();
        }
        private void ExecuteProcess(ref Queue<Process> queue_1, ref Queue<Process> queue_2,
            ref int countCompletedProcesses, ref int currentTime,ref List<Process> processesInSystem, int Q)
        {
            bool interrupt = false;
            var currentProcess = queue_1.Peek();
            processesInProgress.Add(currentProcess);
            //AddStatesMFQ();
            for (int i = 0; i < Q; i++)
            {                
                currentProcess.UsedQuanta++;
                foreach (var process in processesInSystem)
                {
                    process.T++;
                }
                AddStatesMFQ();
                currentTime++;
                var newProcess = GetBornProcess(currentTime, MFQ_queue_0);
                while (newProcess != null)
                {
                    MFQ_queue_0.Enqueue(newProcess);
                    interrupt = true;
                    processesInSystem.Add(newProcess);
                    newProcess = GetBornProcess(currentTime, MFQ_queue_0);
                }                
                if (currentProcess.IsCompleted())
                {
                    queue_1.Dequeue();
                    countCompletedProcesses++;
                    processesInSystem.Remove(currentProcess);
                    break;
                }
                if (interrupt)
                {
                    break;
                }
            }
            if(!currentProcess.IsCompleted())
            {
                queue_2.Enqueue(queue_1.Dequeue());
            }
            processesInProgress.Remove(currentProcess);         
        }
        private void AddStatesMFQ()
        {
            foreach(var process in processesArray)
            {
                if (!processesInSystem.Contains(process))
                {
                    process.States.Add(State.NotInSystem);
                }
                else if (processesInProgress.Contains(process)) 
                {
                    process.States.Add(State.InProgress);
                }
                else
                {
                    process.States.Add(State.Waiting);
                }
            }
        }
    }
}
