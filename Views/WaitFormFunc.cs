
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventController.Views
{
    internal class WaitFormFunc
    {
        waitingForEmail wait;
        Thread loadthread;

        public void show()
        {
            // load thread
            loadthread = new Thread(new ThreadStart(LoadingProcess));
            loadthread.Start();
        }


        public void show(Form parent)
        {
            loadthread = new Thread(new ParameterizedThreadStart(LoadingProcess));
            loadthread.Start(parent);
        }

        public void Close()
        {
            if (wait != null)
            {
                wait.BeginInvoke(new System.Threading.ThreadStart(wait.CloseWaitForm));
                wait = null;
                loadthread = null;
            }
        }


        private void LoadingProcess()
        {
            wait = new waitingForEmail();
            wait.ShowDialog();

        }

        private void LoadingProcess(object parent)
        {
            Form Parent1 = parent as Form;
            wait = new waitingForEmail(Parent1);
            wait.ShowDialog();
        }
    }
}
