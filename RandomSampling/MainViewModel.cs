using System;
using System.ComponentModel;
using System.Timers;
using System.Windows;
using System.Windows.Input;

namespace RandomSampling
{
    class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            Groups = new GroupCollection();
            ToggleConsole = new BaseCommand(obj => DoToggleConsole());
            PrimaryBigger = new BaseCommand(obj => DoPrimaryBigger());
            PrimarySmaller = new BaseCommand(obj => DoPrimarySmaller());
            SecondaryBigger = new BaseCommand(obj => DoSecondaryBigger());
            SecondarySmaller = new BaseCommand(obj => DoSecondarySmaller());
            NewRound = new BaseCommand(obj => DoNewRound());
            RandomCommand = new BaseCommand(obj => DoRandomCommand(obj));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        private Visibility showConsole = Visibility.Collapsed;
        public Visibility ShowConsole
        {
            get { return showConsole; }
            set { showConsole = value; NotifyPropertyChanged(nameof(ShowConsole)); }
        }


        private int primaryTextSize = 20;
        public int PrimaryTextSize
        {
            get { return primaryTextSize; }
            set { primaryTextSize = value; NotifyPropertyChanged(nameof(PrimaryTextSize)); }
        }


        private int secondaryTextSize = 20;
        public int SecondaryTextSize
        {
            get { return secondaryTextSize; }
            set { secondaryTextSize = value; NotifyPropertyChanged(nameof(SecondaryTextSize)); }
        }


        private double interval = 100;
        public double Interval
        {
            get { return interval; }
            set { interval = value; NotifyPropertyChanged(); }
        }


        public GroupCollection Groups;

        public GroupItem Group0 => Groups[0];
        public GroupItem Group1 => Groups[1];
        public GroupItem Group2 => Groups[2];
        public GroupItem Group3 => Groups[3];
        public GroupItem Group4 => Groups[4];
        public GroupItem Group5 => Groups[5];
        public GroupItem Group6 => Groups[6];
        public GroupItem Group7 => Groups[7];


        public ICommand ToggleConsole { get; set; }
        private void DoToggleConsole()
        {
            if (ShowConsole == Visibility.Visible)
            {
                ShowConsole = Visibility.Collapsed;
            }
            else
            {
                ShowConsole = Visibility.Visible;
            }
        }

        public ICommand PrimaryBigger { get; set; }
        private void DoPrimaryBigger()
        {
            PrimaryTextSize++;
        }

        public ICommand PrimarySmaller { get; set; }
        private void DoPrimarySmaller()
        {
            PrimaryTextSize--;
        }

        public ICommand SecondaryBigger { get; set; }
        private void DoSecondaryBigger()
        {
            SecondaryTextSize++;
        }

        public ICommand SecondarySmaller { get; set; }
        private void DoSecondarySmaller()
        {
            SecondaryTextSize--;
        }

        public ICommand NewRound { get; set; }
        private void DoNewRound()
        {
            foreach (var g in Groups)
            {
                g.NewRound();
            }
        }

        public ICommand RandomCommand { get; }
        private void DoRandomCommand(object obj)
        {
            var i = int.Parse(obj.ToString());
            Groups[i].RandomSampling();
        }
    }
}
