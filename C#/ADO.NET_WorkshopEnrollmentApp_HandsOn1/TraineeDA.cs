using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WorkShopEnrollmentApp
{
   
    public class TraineeDA{
         
public string ConnectionString

{

  get

  {

       return ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;

  }

}
        
     public bool AddTraineeDetails(TraineeBO objBO)
     {
        string query = "INSERT INTO dbo.tblTrainee (Trainee_Id,Trainee_Name, Batch_Code)  VALUES(@Id,@Name,@Code)";
    using(SqlConnection cn = new SqlConnection(ConnectionString))
    using(SqlCommand cmd = new SqlCommand(query, cn))
    {
            cmd.Parameters.Add("@Id", SqlDbType.BigInt).Value=objBO.TraineeId;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar, 100).Value=objBO.TraineeName;
            cmd.Parameters.Add("@Code", SqlDbType.VarChar, 100).Value=objBO.BatchCode;

        // open connection, execute command and close connection
        cn.Open();
        try{
            cmd.ExecuteNonQuery();
            return true;
        }
        catch(Exception)
        {
            return false;
        }
        finally{
            cn.Close();
        }
        
    }   
       
     }
    }
}