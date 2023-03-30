using System.Security.Cryptography.X509Certificates;

namespace HalloAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(1000);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    progressBar1.Invoke(new Action(() => { progressBar1.Value = i; }));
                    Thread.Sleep(10);
                }

                progressBar1.Invoke(new Action(() => { button2.Enabled = true; }));
            });

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            var ts = TaskScheduler.FromCurrentSynchronizationContext();

            Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    var t = new Task(() => progressBar1.Value = i);
                    t.Start(ts);

                    Thread.Sleep(10);
                }

                progressBar1.Invoke(new Action(() => { button3.Enabled = true; }));
            });
        }

        private async void button4_ClickAsync(object sender, EventArgs e)
        {
            button4.Enabled = false;

            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;

                //Thread.Sleep(10);
                await Task.Delay(10);
            }

            button4.Enabled = true;
        }

        public long AlteUndLahm(int zahl)
        {
            Thread.Sleep(4000);
            return zahl * 9438;
        }

        public Task<long> AlteUndLahmAsync(int zahl)
        {
            return Task.Run(() => AlteUndLahm(zahl));
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Result: {AlteUndLahm(12)}");
            MessageBox.Show($"Result: {await AlteUndLahmAsync(12)}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var t1 = new Task(() =>
            {
                button1.Invoke(new Action(() => button1.Enabled = false));
                Thread.Sleep(2000);
                button1.Invoke(new Action(() => button1.Enabled = true));
            });

            var t2 = new Task(() =>
            {
                button1.Invoke(new Action(() => button2.Enabled = false));
                Thread.Sleep(2000);
                button1.Invoke(new Action(() => button2.Enabled = true));
                throw new ExecutionEngineException();
            });

            t1.ContinueWith(t => t2.Start());

            t2.ContinueWith(t => MessageBox.Show("Immer"));
            t2.ContinueWith(t => MessageBox.Show(":-)"), TaskContinuationOptions.OnlyOnRanToCompletion);
            t2.ContinueWith(t => MessageBox.Show($":-( {t.Exception.InnerException.Message}"), TaskContinuationOptions.OnlyOnFaulted);

            t1.Start();
        }
    }
}