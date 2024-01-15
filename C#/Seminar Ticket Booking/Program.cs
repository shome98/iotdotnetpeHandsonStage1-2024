using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarTicketBooking  //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
    public  string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    
        public static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            int input = 0;
            string name; string seatno;
            
            Program pgm = new Program();
            
            Console.WriteLine("Seminar Ticket Booking");
            Console.WriteLine("1. New Booking");
            Console.WriteLine("2. View All Booking");
            Console.WriteLine("3. Update Booking");
            Console.WriteLine("4. Exit");
            input = Convert.ToInt32(Console.ReadLine());

            if (input == 4)
            {	 	  	  		   	     	      	  	 	
                return false;
            }

            if (input == 1)
            {
                Console.WriteLine("Booking Name : ");
                name = Console.ReadLine();

                Console.WriteLine("Seat No. : ");
                seatno = Console.ReadLine();

                pgm.NewBooking(name, seatno);
            }
            if (input == 2)
            {
                pgm.GetAllBooking();
            }
            else if (input == 3)
            {
                Console.WriteLine("Booking Name : ");
                name = Console.ReadLine();

                Console.WriteLine("Seat No. : ");
                seatno = Console.ReadLine();

                pgm.UpdateBooking(name, seatno);
            }
           

            Console.WriteLine();
            return true;
        }
        
        public void GetAllBooking()  //DO NOT change method signature
        {
            //Fill your code here
            string s="SELECT Name,Seatno from Booking";
             
            
           using(SqlConnection con = new SqlConnection(ConnectionString))
            using(SqlCommand cmd = new SqlCommand(s,con))
            {
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows){
                while (reader.Read())
            {
                Console.WriteLine(reader["Name"] + " " + reader["Seatno"]);
            }
            }
            
            //reader.close();
            con.Close();
        } 
        }
        public void NewBooking(string name, string seatno)  //DO NOT change method signature
        {
            //Fill Code here
            string s="INSERT INTO Booking(Name,Seatno)  VALUES(@Name,@Seatno)";
            using(SqlConnection con = new SqlConnection(ConnectionString))
            using(SqlCommand cmd = new SqlCommand(s,con))
            {
                cmd.Parameters.Add("@Name", SqlDbType.VarChar,50).Value=name;
                cmd.Parameters.Add("@Seatno", SqlDbType.VarChar, 20).Value=seatno;
                con.Open();
    
                cmd.ExecuteNonQuery();
          
            
                con.Close();
        }
        }
        public void UpdateBooking(string name, string seatno)   //DO NOT change method signature
        {
            //Fill Code here
            string s="update Booking set Name=@Name where Seatno=@Seatno";
            using(SqlConnection con = new SqlConnection(ConnectionString))
            using(SqlCommand cmd = new SqlCommand(s,con))
            {
                cmd.Parameters.Add("@Name", SqlDbType.VarChar,50).Value=name;
                cmd.Parameters.Add("@Seatno", SqlDbType.VarChar, 20).Value=seatno;
            con.Open();
             
           cmd.ExecuteNonQuery();
           con.Close();
        }
    }
}
}