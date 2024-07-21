namespace WinServWorker
{
    public class Worker : BackgroundService
    {    
        
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Logger.Write("Worked Service Running", "Info");
                WinServ.FileJob.Start();
                await Task.Delay(60000, stoppingToken);
            }
        }
    }
}
