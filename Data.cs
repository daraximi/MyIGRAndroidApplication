using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using App3;

using Xamarin.Forms;

namespace App3
{
    public class Data
    {
        public List<DataModel> Statistics { get; set; }
        public Data ()
        {
            Statistics = new List<DataModel>
            {
                new DataModel { State = "ABIA", totalIgr = 14769307658.56, share = 1.11, rank = 24 },
                new DataModel { State = "ADAMAWA", totalIgr = 9704660185.44, share = 0.73, rank = 29 },
                new DataModel { State = "AKWA IBOM", totalIgr = 32291014771.52, share = 2.42, rank = 8 },
                new DataModel { State = "ANAMBRA", totalIgr = 26369195854.89, share = 1.98, rank = 14 },
                new DataModel { State = "BAUCHI ", totalIgr = 11696955884.75, share = 0.88, rank = 27 },
                new DataModel { State = "BAYELSA", totalIgr = 16342762531.98, share = 1.22, rank = 21 },
                new DataModel { State = "BENUE", totalIgr = 17850480389.57, share = 1.34, rank = 18 },
                new DataModel { State = "BORNO", totalIgr = 8175248326.42, share = 0.61, rank = 33 },
                new DataModel { State = "CROSS RIVER", totalIgr = 22597063882.55, share = 1.69, rank = 15 },
                new DataModel { State = "DELTA", totalIgr = 64678796991.57, share = 4.85, rank = 5 },
                new DataModel { State = "EBONYI", totalIgr = 7455294676.59, share = 0.56, rank = 34 },
                new DataModel { State = "EDO", totalIgr = 29478406024.31, share = 2.21, rank = 12 },
                new DataModel { State = "EKITI", totalIgr = 8546875648.24, share = 0.64, rank = 30 },
                new DataModel { State = "ENUGU", totalIgr = 31069466913.00, share = 2.33, rank = 9 },
                new DataModel { State = "FCT", totalIgr = 74564180835.31, share = 5.59, rank = 3 },
                new DataModel { State = "GOMBE", totalIgr = 6803064814.10, share = 0.51, rank = 36 },
                new DataModel { State = "IMO", totalIgr = 16095299620.59, share = 1.21, rank = 22 },
                new DataModel { State = "JIGAWA", totalIgr = 12926658146.29, share = 0.97, rank = 25 },
                new DataModel { State = "KADUNA", totalIgr = 44956576583.38, share = 3.37, rank = 6 },
                new DataModel { State = "KANO", totalIgr = 40593701332.48, share = 3.04, rank = 7 },
                new DataModel { State = "KATSINA", totalIgr = 8496742119.00, share = 0.64, rank = 31 },
                new DataModel { State = "KEBBI", totalIgr = 7367334837.13, share = 0.55, rank = 35 },
                new DataModel { State = "KOGI", totalIgr = 16389026388.86, share = 1.23, rank = 20 },
                new DataModel { State = "KWARA", totalIgr = 30646731408.92, share = 2.3, rank = 10 },
                new DataModel { State = "LAGOS", totalIgr = 398732246493.38, share = 29.88, rank = 1 },
                new DataModel { State = "NASSARAWA", totalIgr = 10858822422.98, share = 0.81, rank = 28 },
                new DataModel { State = "NIGER", totalIgr = 12765034972.30, share = 0.96, rank = 26 },
                new DataModel { State = "OGUN", totalIgr = 70922590495.89, share = 5.32, rank = 4 },
                new DataModel { State = "ONDO", totalIgr = 30135881918.26, share = 2.26, rank = 11 },
                new DataModel { State = "OSUN", totalIgr = 17922590495.89, share = 5.32, rank = 4 },
                new DataModel { State = "OYO", totalIgr = 26746460235.93, share = 2.00, rank = 13 },
                new DataModel { State = "PLATEAU", totalIgr = 16480111593.83, share = 1.24, rank = 19 },
                new DataModel { State = "RIVERS", totalIgr = 140398744302.70, share = 10.52, rank = 2 },
                new DataModel { State = "SOKOTO", totalIgr = 19005093541.11, share = 1.42, rank = 16 },
                new DataModel { State = "TARABA", totalIgr = 6533106447.27, share = 0.49, rank = 37 },
                new DataModel { State = "YOBE", totalIgr = 8444634099.09, share = 0.63, rank = 32 },
                new DataModel { State = "ZAMFARA", totalIgr = 15416043399.76, share = 1.16, rank = 23 }
            };
        }       
  
    }
            
}