using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Timers;
using System.Windows.Input;

namespace RandomSampling
{
    class GroupItem : INotifyPropertyChanged
    {
        public GroupItem(Group group)
        {
            Group = group;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        private Group Group { get; set; }
        public string GroupName => Group.Name;


        private string samplingMember;
        public string SamplingMember
        {
            get { return samplingMember; }
            set { samplingMember = value; NotifyPropertyChanged(nameof(SamplingMember)); }
        }


        private Timer timer;
        private Random myRandom;
        private bool start = false;
        private double interval = 100;
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Group.Members?.Count > 0)
            {
                SamplingMember = Group.Members[myRandom.Next(0, Group.Members.Count)];
            }
        }
        public void RandomSampling()
        {
            if (myRandom is null)
            {
                myRandom = new Random((DateTime.Now.ToLongTimeString() + Group.Name).GetHashCode());
            }
            start = !start;
            DoRandom(start);
        }
        public void DoRandom(bool isStart)
        {
            if (isStart)
            {
                timer = new Timer(interval);
                timer.Elapsed += Timer_Elapsed;
                timer.Start();
            }
            else
            {
                timer.Elapsed -= Timer_Elapsed;
                timer.Stop();
            }
        }
        public void NewRound()
        {
            if (start)
            {
                start = false;
                DoRandom(start);
            }
            if (SamplingMember != default)
            {
                Group.Members.Remove(SamplingMember);
                SamplingMember = default;
            }
        }
    }
}
