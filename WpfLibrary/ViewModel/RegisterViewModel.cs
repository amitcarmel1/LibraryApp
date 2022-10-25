using BookLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using WpfLibrary.Interfaces;
using WpfLibrary.Service;
using System.Text.RegularExpressions;
//using System.Windows.Forms;

namespace WpfLibrary.ViewModel
{
    public class RegisterViewModel : ViewModelBase
    {
        private string name;
        private int id;
        public List<Worker> WorkersList;
        private IChangeView changeView;

        public int ID { get => id; set => Set(ref id, value); }
        public string Name { get => name; set => Set(ref name, value); }

        public List<Customer> custList = new List<Customer>();
        public bool workerPermisions;
        public bool CustomerPermisions;
        public bool managerPermisions;

        public RelayCommand LogInCommand { get; set; }
        public RelayCommand RegisterCommand { get; set; }
        public RelayCommand EnterWorkerCommand { get; set; }

        public RegisterViewModel(IChangeView changeView)
        {
            EnterWorkerCommand = new RelayCommand(WorkEnter);
            LogInCommand = new RelayCommand(LogIn);
            RegisterCommand = new RelayCommand(Register);
            workerPermisions = false;
            CustomerPermisions = false;
            managerPermisions = false;

            this.changeView = changeView;

            WorkersList = new List<Worker>();
            Worker Amit = new Worker { Name = "Amit", ID = 322435793 };
            Worker Niv = new Worker { Name = "Niv", ID = 120956245 };
            Worker Eden = new Worker { Name = "Eden", ID = 937285430 };
            Worker Yael = new Worker { Name = "Yael", ID = 736482956 };
            Worker Hanna = new Worker { Name = "Hanna", ID = 836293633 };
            WorkersList.Add(Amit);
            WorkersList.Add(Niv);
            WorkersList.Add(Eden);
            WorkersList.Add(Yael);
            WorkersList.Add(Hanna);

        }
        public void RegexValidationForNameId(string nameToCheck, string idToChek)
        {
            if (!Regex.IsMatch(idToChek, @"^\d{9}$"))
            {
                throw new ArgumentOutOfRangeException();
            }
            if (!Regex.IsMatch(nameToCheck, "[a-zA-Z]+"))
            {
                throw new ArgumentException();
            }

        }
        public void LogIn()
        {
            try
            {
                RegexValidationForNameId(name, id.ToString());
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Not a valid ID \n please enter a 9 digit number");
                return;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Not a valid Name");
                return;
            }
            if (custList.Exists(customer => customer.Name == name && customer.ID == id))
            {
                changeView.action.Invoke(3);
            }
            else
            {
                string messageBoxText = " this is your first time here. \n would you like to sing in?";
                System.Windows.Forms.DialogResult dialogResult = System.Windows.Forms.MessageBox.Show(messageBoxText, "Welcome", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);
                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    Register();
                }
                if (dialogResult == System.Windows.Forms.DialogResult.No)
                {
                    MessageBox.Show("Good Bye");
                    Application.Current.Shutdown();
                }

            }
            CustomerPermisions = true;
            workerPermisions = false;
        }

        private void Register()
        {
            try
            {
                RegexValidationForNameId(name, id.ToString());
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Not a valid ID \n please enter a 9 digit number");
                return;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Not a valid Name");
                return;
            }
            Customer cust = new Customer { Name = name, ID = id };
            if (custList.Exists(customer => customer.Name == cust.Name && customer.ID == cust.ID))
            {
                MessageBox.Show("you alredy exist. Welcome");
                LogIn();
            }
            else
            {
                custList.Add(cust);
                MessageBox.Show("welcome!");

            }
            CustomerPermisions = true;
            workerPermisions = false;
            changeView.action.Invoke(3);
        }
        private void WorkEnter()
        {
            try
            {
                RegexValidationForNameId(name, id.ToString());
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Not a valid ID \n please enter a 9 digit number");
                return;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Not a valid Name");
                return;
            }
            if (WorkersList.Exists(worker => worker.Name == name && worker.ID == id))
            {
                MessageBox.Show($"welcome {name}");
                CustomerPermisions = false;
                workerPermisions = true;
                changeView.action.Invoke(1);
            }
            else MessageBox.Show("Sorry you have no permmisions here");

        }
    }
}
