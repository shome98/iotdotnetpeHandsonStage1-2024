using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopEnrollmentApp
{
   //Write your code here
   public class TraineeBO{
       public long traineeId;
       public string traineeName;
       public string batchCode;
       public long TraineeId{
           get{return traineeId;}
           set{traineeId=value;}
       }
        public string TraineeName{
           get{return traineeName;}
           set{traineeName=value;}
       }
        public string BatchCode{
           get{return batchCode;}
           set{batchCode=value;}
       }
       public TraineeBO(){}
       public TraineeBO(long traineeId,string traineeName,string batchCode){
           this.traineeId=traineeId;
           this.traineeName=traineeName;
           this.batchCode=batchCode;
       }
   }
}