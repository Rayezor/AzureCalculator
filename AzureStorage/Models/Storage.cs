namespace AzureStorage.Models
{
    public class Storage
    {
        public int GigaBytes { get; set; }
        public bool GeoRedundant { get; set; }
        public double StorageCost
        {
            get
            {
                double MoreThanTB = GigaBytes - 1000;   // Number of Gigabytes more than 1TB
                double charge = 0;
                if (GeoRedundant)
                {
                    if (GigaBytes <= 1000)
                    {
                        charge = GigaBytes * 0.125;
                    }
                    else
                    {
                        charge = 1000 * 0.125 + GigaBytes * 0.11;
                    }
                }
                else    // if locally redundant
                {
                    if (GigaBytes <= 1000)
                    {
                        charge = GigaBytes * 0.093;
                    }
                    else
                    {
                        charge = 1000 * 0.093 + MoreThanTB * 0.083;
                    }
                }
                return Math.Round(charge,2);    // round the result to 2 decimal places
            }
        }
    }
}
