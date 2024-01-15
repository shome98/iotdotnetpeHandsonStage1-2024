using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopEnrollmentApp
{
    //Write your code here
public class TraineeBL{
    public bool SaveTraineeDetails(TraineeBO objBO){
        TraineeDA da=new TraineeDA();
        bool r=da.AddTraineeDetails(objBO);
        return r;
    }
}
}